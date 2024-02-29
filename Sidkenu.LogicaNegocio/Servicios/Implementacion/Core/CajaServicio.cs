using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Sidkenu.AccesoDatos.Constantes;
using Sidkenu.AccesoDatos.Constantes.Enum;
using Sidkenu.AccesoDatos.Entidades.Core;
using Sidkenu.Infraestructura;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Base;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.Caja;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.Cliente;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.Comprobante;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Seguridad.Persona;
using Sidkenu.LogicaNegocio.Servicios.Implementacion.Base;
using Sidkenu.LogicaNegocio.Servicios.Interface.Core;
using Sidkenu.LogicaNegocio.Servicios.Interface.Seguridad;
using System.Linq.Expressions;
using System.Transactions;
using static System.Net.Mime.MediaTypeNames;

namespace Sidkenu.LogicaNegocio.Servicios.Implementacion.Core
{
    public class CajaServicio : ServicioBase, ICajaServicio
    {
        private readonly IComprobanteServicio _comprobanteServicio;
        private readonly IClienteServicio _clienteServicio;
        private readonly IPersonaServicio _personaServicio;

        public CajaServicio(IMapper mapper,
                            IConfiguracionServicio configuracionServicio,  
                            IComprobanteServicio comprobanteServicio,
                            IClienteServicio clienteServicio,
                            IPersonaServicio personaServicio)
                            : base(mapper, configuracionServicio)
        {
            _comprobanteServicio = comprobanteServicio;
            _clienteServicio = clienteServicio;
            _personaServicio = personaServicio;
        }

        public ResultDTO Add(CajaPersistenciaDTO entidad, string user)
        {
            using var _context = new DataContext();

            try
            {
                var existeEntidad = VerificarSiExiste(entidad.Descripcion, entidad.EmpresaId);

                if (existeEntidad)
                    return new ResultDTO
                    {
                        Message = "Los datos ingresados ya existen",
                        State = false,
                    };

                var entity = _mapper.Map<Caja>(entidad);

                entity.User = user;
                entity.EstaEliminado = false;

                _context.Cajas.Add(entity);

                _context.SaveChanges();

                return new ResultDTO
                {
                    State = true,
                    Message = "Los datos se grabaron correctamente",
                    Data = entity
                };
            }
            catch (Exception ex)
            {
                return new ResultDTO
                {
                    Message = ex.Message,
                    State = false
                };
            }
        }

        public ResultDTO Update(CajaPersistenciaDTO entidad, string user)
        {
            using var _context = new DataContext();

            try
            {
                var entityActual = _context.Cajas.Find(entidad.Id);

                if (entityActual == null)
                {
                    return new ResultDTO
                    {
                        Message = "Ocurrio un error al obtener los datos del Caja",
                        State = false
                    };

                }

                if (entityActual.EstaEliminado)
                {
                    return new ResultDTO
                    {
                        Message = "No se puede Actualizar los datos porque la entidad seleccionada se encuentra eliminada",
                        State = false,
                    };
                }

                var entity = _mapper.Map<Caja>(entidad);

                entity.User = user;

                _context.Cajas.Update(entity);

                _context.SaveChanges();

                return new ResultDTO
                {
                    State = true,
                    Data = _mapper.Map<CajaDTO>(entity),
                    Message = "Los datos se actualizaron correctamente"
                };
            }
            catch (Exception ex)
            {
                return new ResultDTO
                {
                    Message = ex.Message,
                    State = false
                };
            }
        }

        public ResultDTO Delete(CajaDeleteDTO deleteDTO, string user)
        {
            using var _context = new DataContext();

            try
            {
                var entidad = _context.Cajas.Find(deleteDTO.Id);

                if (entidad == null)
                {
                    return new ResultDTO
                    {
                        Message = "Ocurrio un error al obtener los datos",
                        State = false
                    };
                }

                _context.RemoveLogic(entidad, user);

                _context.SaveChanges();

                return new ResultDTO
                {
                    State = true,
                    Message = !entidad.EstaEliminado ? "Los datos se eliminaron correctamente" : "Los datos se recuperaron correctamente"
                };
            }
            catch (Exception ex)
            {
                return new ResultDTO
                {
                    Message = ex.Message,
                    State = false
                };
            }
        }

        public ResultDTO Transferir(CajaTransferenciaDTO cajaTransferencia, string user)
        {
            using var _context = new DataContext();

            try
            {
                var fechaActual = DateTime.Now;

                var cajaOrigen = _context.Cajas
                    .Include(z => z.CajaDetalles)
                    .FirstOrDefault(x => x.Id == cajaTransferencia.CajaOrigenId);
                
                var cajaDestino = _context.Cajas
                    .Include(z => z.CajaDetalles)
                    .FirstOrDefault(x => x.Id == cajaTransferencia.CajaDestinoId);

                // Comprobante de Gastos

                var _clienteResult = _clienteServicio.GetConsumidorFinal();

                if (_clienteResult == null || !_clienteResult.State)
                {
                    return new ResultDTO
                    {
                        State = false,
                        Message = "Ocurrió un error al obtener el cliente por defecto para asignarlo al comprobante"
                    };
                }

                var _personaResult = _personaServicio.GetById(cajaTransferencia.PersonaId);

                if (_personaResult == null || !_personaResult.State)
                {
                    return new ResultDTO
                    {
                        State = false,
                        Message = "Ocurrió un error al obtener la persona que esta registrando el gasto"
                    };
                }

                // Caja Origen

                var _comprobanteTransferenciaOrigen = new ComprobanteTransferenciaDTO();

                _comprobanteTransferenciaOrigen.CajaDetalleId = cajaOrigen.CajaDetalles.First(x=>x.EstadoCaja == EstadoCaja.Abierta).Id;

                _comprobanteTransferenciaOrigen.EmpresaId = cajaTransferencia.EmpresaId;

                _comprobanteTransferenciaOrigen.Cliente = (ClienteDTO)_clienteResult.Data;
                _comprobanteTransferenciaOrigen.Persona = (PersonaDTO)_personaResult.Data;
                _comprobanteTransferenciaOrigen.Fecha = fechaActual;
                _comprobanteTransferenciaOrigen.CajaId = cajaOrigen.Id;
                _comprobanteTransferenciaOrigen.SubTotal = cajaTransferencia.Monto;
                _comprobanteTransferenciaOrigen.Descuento = 0m;
                _comprobanteTransferenciaOrigen.Total = cajaTransferencia.Monto;
                _comprobanteTransferenciaOrigen.TipoComprobante = TipoComprobante.TransferenciaCaja;
                _comprobanteTransferenciaOrigen.Descripcion = $"Transf. {cajaOrigen.Descripcion} a {cajaDestino.Descripcion} un monto {cajaTransferencia.Monto.ToString("C")}";

                var resultDtoOrigen = _comprobanteServicio.AddOrUpdate(_comprobanteTransferenciaOrigen, user);

                var _comprobanteResultOrigen = (ComprobanteDTO)resultDtoOrigen.Data;

                // Movimiento Caja Origen

                var _movimientoCajaOrigen = new MovimientoCaja
                {
                    TipoMovimiento = TipoMovimiento.Egreso,
                    TipoOperacion = TipoOperacionMovimiento.TransferenciaCaja,
                    CajaDetalleId = _comprobanteTransferenciaOrigen.CajaDetalleId,
                    Capital = cajaTransferencia.Monto,
                    Interes = 0m,
                    Descripcion = _comprobanteTransferenciaOrigen.Descripcion,
                    Fecha = fechaActual,
                    User = user,
                    ComprobanteId = _comprobanteResultOrigen.Id,
                    EstaEliminado = false,
                };

                _context.MovimientoCajas.Add(_movimientoCajaOrigen);

                // Caja Destino

                var _comprobanteTransferenciaDestino = new ComprobanteTransferenciaDTO();

                _comprobanteTransferenciaDestino.CajaDetalleId = cajaDestino.CajaDetalles.First(x => x.EstadoCaja == EstadoCaja.Abierta).Id;

                _comprobanteTransferenciaDestino.EmpresaId = cajaTransferencia.EmpresaId;

                _comprobanteTransferenciaDestino.Cliente = (ClienteDTO)_clienteResult.Data;
                _comprobanteTransferenciaDestino.Persona = (PersonaDTO)_personaResult.Data;
                _comprobanteTransferenciaDestino.Fecha = fechaActual;
                _comprobanteTransferenciaDestino.CajaId = cajaDestino.Id;
                _comprobanteTransferenciaDestino.SubTotal = cajaTransferencia.Monto;
                _comprobanteTransferenciaDestino.Descuento = 0m;
                _comprobanteTransferenciaDestino.Total = cajaTransferencia.Monto;
                _comprobanteTransferenciaDestino.TipoComprobante = TipoComprobante.TransferenciaCaja;
                _comprobanteTransferenciaDestino.Descripcion = $"Transf. {cajaOrigen.Descripcion} a {cajaDestino.Descripcion} un monto {cajaTransferencia.Monto.ToString("C")}";

                var resultDtoDestino = _comprobanteServicio.AddOrUpdate(_comprobanteTransferenciaDestino, user);

                var _comprobanteResultDestino = (ComprobanteDTO)resultDtoDestino.Data;

                // Movimiento Caja Destino

                var _movimientoCajaDestino = new MovimientoCaja
                {
                    TipoMovimiento = TipoMovimiento.Ingreso,
                    TipoOperacion = TipoOperacionMovimiento.TransferenciaCaja,
                    CajaDetalleId = _comprobanteTransferenciaDestino.CajaDetalleId,
                    Capital = cajaTransferencia.Monto,
                    Interes = 0m,
                    Descripcion = _comprobanteTransferenciaDestino.Descripcion,
                    Fecha = fechaActual,
                    User = user,
                    ComprobanteId = _comprobanteResultDestino.Id,
                    EstaEliminado = false,
                };

                _context.MovimientoCajas.Add(_movimientoCajaDestino);

                _context.SaveChanges();

                return new ResultDTO
                {
                    State = true,
                    Message = "Los datos se grabaron correctamente",
                    Data = null
                };
            }
            catch (Exception ex)
            {
                return new ResultDTO
                {
                    Message = ex.Message,
                    State = false
                };
            }
        }

        public ResultDTO GetAll(Guid empresaId)
        {
            using var _context = new DataContext();

            // using var transaction = _context.Database.BeginTransaction();

            try
            {
                var entities = _context.Cajas
                    .AsNoTracking()
                    .Where(x => x.EmpresaId == empresaId)
                    .ToList();

                return new ResultDTO
                {
                    State = true,
                    Data = _mapper.Map<IEnumerable<CajaDTO>>(entities)
                };
            }
            catch (Exception ex)
            {
                return new ResultDTO
                {
                    Message = ex.Message,
                    State = false
                };
            }
        }

        public ResultDTO GetByFilter(CajaFilterDTO filter)
        {
            using var _context = new DataContext();

            // using var transaction = _context.Database.BeginTransaction();

            try
            {
                filter.CadenaBuscar = !string.IsNullOrEmpty(filter.CadenaBuscar) ? filter.CadenaBuscar : string.Empty;

                Expression<Func<Caja, bool>> filtro = filtro => true;

                filtro = filtro.And(x => x.EmpresaId == filter.EmpresaId);

                if (filter.CadenaBuscar.IndexOf(SeparacionFiltroBusqueda.CaracterSeparador) != -1)
                {
                    var primeraPasada = true;

                    var listaCadenas = filter.CadenaBuscar.Split(SeparacionFiltroBusqueda.CaracterSeparador, StringSplitOptions.RemoveEmptyEntries);

                    foreach (var cadena in listaCadenas)
                    {
                        if (primeraPasada)
                        {
                            filtro = filtro.And(x => x.EstaEliminado == filter.VerEliminados
                                && x.Descripcion.ToLower().Contains(cadena.ToLower()));

                            primeraPasada = false;
                        }
                        else
                        {
                            filtro = filtro.Or(x => x.EstaEliminado == filter.VerEliminados
                                && x.Descripcion.ToLower().Contains(cadena.ToLower()));
                        }
                    }
                }
                else
                {
                    filtro = filtro.And(x => x.EstaEliminado == filter.VerEliminados
                                && x.Descripcion.ToLower().Contains(filter.CadenaBuscar.ToLower()));
                }

                var entities = _context.Cajas
                    .AsNoTracking()
                    .Include(z => z.CajaDetalles).ThenInclude(z => z.Movimientos)
                    .Where(filtro)
                    .ToList();
                
                return new ResultDTO
                {
                    State = true,
                    Data = _mapper.Map<IEnumerable<CajaDTO>>(entities)
                };
            }
            catch (Exception ex)
            {
                return new ResultDTO
                {
                    Message = ex.Message,
                    State = false
                };
            }
        }

        public ResultDTO GetById(Guid id)
        {
            using var _context = new DataContext();

            // using var transaction = _context.Database.BeginTransaction();

            try
            {
                var entity = _context.Cajas.Find(id);

                if (entity == null)
                {
                    return new ResultDTO
                    {
                        State = false,
                        Message = "No se encontro el dato solicitado"
                    };
                }

                return new ResultDTO
                {
                    State = true,
                    Data = _mapper.Map<CajaDTO>(entity)
                };
            }
            catch (Exception ex)
            {
                return new ResultDTO
                {
                    Message = ex.Message,
                    State = false
                };
            }
        }

        public ResultDTO AbrirCaja(CajaAperturaDTO cajaAperturaDTO, string user)
        {
            using var _context = new DataContext();

            // using var transaction = _context.Database.BeginTransaction();

            try
            {
                var detalle = new CajaDetalle
                {
                    CajaId = cajaAperturaDTO.Id,
                    MontoApertura = cajaAperturaDTO.Monto,
                    FechaApertura = DateTime.Now,
                    PersonaAperturaId = cajaAperturaDTO.PersonaAperturaId,
                    Diferencia = 0m,
                    EstadoCaja = EstadoCaja.Abierta,
                    FechaCierre = null,
                    PersonaCierreId = null,
                    MontoCierre = null,
                    User = user,
                    EstaEliminado = false,
                    MontoSistema = 0m
                };

                _context.CajaDetalles.Add(detalle);

                _context.SaveChanges();

                return new ResultDTO
                {
                    State = true,
                    Message = "La caja se abrió correctamente",
                    Data = detalle
                };
            }
            catch (Exception ex)
            {
                return new ResultDTO
                {
                    State = false,
                    Message = $"Ocurrio un error al abrir la Caja. {ex.Message}",
                };
            }
        }

        public ResultDTO GetDetalle(Guid cajaId, DateTime fechaDesde, DateTime fechaHasta)
        {
            using var _context = new DataContext();

            // using var transaction = _context.Database.BeginTransaction();

            try
            {
                var fechaInicio = new DateTime(fechaDesde.Year, fechaDesde.Month, fechaDesde.Day, 0, 0, 0);

                var fechaFin = new DateTime(fechaHasta.Year, fechaHasta.Month, fechaHasta.Day, 23, 23, 59);

                Expression<Func<CajaDetalle, bool>> filter = filter => true;

                filter = filter.And(x => x.CajaId == cajaId
                                       && x.FechaApertura.Date >= fechaInicio && x.FechaApertura.Date <= fechaFin);

                var result = _context.CajaDetalles
                    .AsNoTracking()
                    .Include(z => z.PersonaApertura)
                    .Include(z => z.PersonaCierre)
                    .Include(z => z.Movimientos)
                    .Where(filter)
                    .ToList();

                return new ResultDTO
                {
                    State = true,
                    Data = _mapper.Map<List<CajaDetalleDTO>>(result)
                };
            }
            catch (Exception ex)
            {
                return new ResultDTO
                {
                    State = false,
                    Message = $"Ocurrió un error al obtener el detalle. {ex.Message}",
                };
            }
        }

        public ResultDTO GetDetalle(Guid cajaDetalleId)
        {
            using var _context = new DataContext();

            // using var transaction = _context.Database.BeginTransaction();

            try
            {
                Expression<Func<CajaDetalle, bool>> filter = filter => true;

                filter = filter.And(x => x.Id == cajaDetalleId && x.EstadoCaja == EstadoCaja.Abierta);

                var result = _context.CajaDetalles
                    .AsNoTracking()
                    .Include(z => z.PersonaApertura)
                    .Include(z => z.PersonaCierre)
                    .Include(z => z.Movimientos)
                    .Where(filter)
                    .ToList();

                return new ResultDTO
                {
                    State = true,
                    Data = _mapper.Map<CajaDetalleDTO>(result.FirstOrDefault())
                };
            }
            catch (Exception ex)
            {
                return new ResultDTO
                {
                    State = false,
                    Message = $"Ocurrió un error al obtener el detalle. {ex.Message}",
                };
            }
        }

        public ResultDTO GetUltimaCajaAbierta(Guid empresaId)
        {
            using var _context = new DataContext();

            // using var transaction = _context.Database.BeginTransaction();

            try
            {
                var result = _context.CajaDetalles
                    .AsNoTracking()
                    .Include(z => z.Caja)
                    .Include(z => z.Movimientos)
                    .Where(x => x.Caja.EmpresaId == empresaId && x.EstadoCaja == EstadoCaja.Abierta)
                    .ToList();

                return new ResultDTO
                {
                    State = true,
                    Data = _mapper.Map<List<CajaDetalleDTO>>(result),
                };
            }
            catch (Exception)
            {
                return new ResultDTO
                {
                    State = false,
                    Data = null,
                    Message = "Ocurrió un error al obtener la ultima caja Abierta"
                };
            }
        }

        public ResultDTO GetUltimaCajaAbierta(Guid empresaId, Guid cajaId)
        {
            using var _context = new DataContext();

            // using var transaction = _context.Database.BeginTransaction();

            try
            {
                var result = _context.CajaDetalles
                    .AsNoTracking()
                    .Include(z => z.Caja)
                    .Where(x => x.Caja.EmpresaId == empresaId
                                && x.CajaId == cajaId
                                && x.EstadoCaja == EstadoCaja.Abierta)
                    .ToList();

                return new ResultDTO
                {
                    State = true,
                    Data = _mapper.Map<List<CajaDetalleDTO>>(result),
                };
            }
            catch (Exception)
            {
                return new ResultDTO
                {
                    State = false,
                    Data = null,
                    Message = "Ocurrió un error al obtener la ultima caja Abierta"
                };
            }
        }

        public ResultDTO CerrarCaja(CajaCerrarDTO cajaCerrarDTO, string user)
        {
            using var _context = new DataContext();

            try
            {
                var resultCajaDetalleOrigen = _context.CajaDetalles
                    .AsNoTracking()
                    .Where(x => x.CajaId == cajaCerrarDTO.Id && x.EstadoCaja == EstadoCaja.Abierta)
                    .ToList();

                if (resultCajaDetalleOrigen == null || !resultCajaDetalleOrigen.Any())
                {
                    return new ResultDTO
                    {
                        State = false,
                        Message = "Ocurrio un error al obtener el detalle de la Caja seleccionada"
                    };
                }

                var cajaDetalleOrigen = resultCajaDetalleOrigen.First();

                if (cajaDetalleOrigen == null)
                {
                    return new ResultDTO
                    {
                        State = false,
                        Message = "Ocurrio un error al obtener el detalle de la Caja seleccionada"
                    };
                }

                var fechaOperacion = DateTime.Now;

                cajaDetalleOrigen.FechaCierre = fechaOperacion;
                cajaDetalleOrigen.EstadoCaja = EstadoCaja.Cerrada;
                cajaDetalleOrigen.MontoCierre = cajaCerrarDTO.MontoCierre;
                cajaDetalleOrigen.MontoSistema = cajaCerrarDTO.MontoSistema;
                cajaDetalleOrigen.Diferencia = cajaCerrarDTO.Diferencia;
                cajaDetalleOrigen.PersonaCierreId = cajaCerrarDTO.PersonaCierreId;

                if (cajaCerrarDTO.EstaPorTransferirDinero)
                {
                    cajaDetalleOrigen.Movimientos = new List<MovimientoCaja>();

                    //cajaDetalleOrigen.Movimientos.Add(new MovimientoCaja
                    //{
                    //    CajaDetalleId = cajaDetalleOrigen.Id,
                    //    EstaEliminado = false,
                    //    Fecha = fechaOperacion,
                    //    Monto = cajaCerrarDTO.MontoTransferir,
                    //    TipoMovimiento = Aplicacion.Constantes.TipoMovimiento.Egreso,
                    //    Descripcion = $"Nro de Transf: {1}"
                    //});

                    var cajaDetalleDestino = _context.CajaDetalles.Find(cajaCerrarDTO.CajaDetalleId);

                    if (cajaDetalleDestino == null)
                    {
                        return new ResultDTO
                        {
                            State = false,
                            Message = "Ocurrio un error al obtener el detalle de la Caja seleccionada para realizar la Transferencia"
                        };
                    }

                    cajaDetalleDestino.Movimientos = new List<MovimientoCaja>();

                    //cajaDetalleDestino.Movimientos.Add(new MovimientoCaja
                    //{
                    //    CajaDetalleId = cajaCerrarDTO.Id,
                    //    EstaEliminado = false,
                    //    Fecha = fechaOperacion,
                    //    Monto = cajaCerrarDTO.MontoTransferir,
                    //    TipoMovimiento = Aplicacion.Constantes.TipoMovimiento.Ingreso,
                    //    Descripcion = $"Nro de Transf: {1}"
                    //});

                    _context.CajaDetalles.Update(cajaDetalleDestino);
                }

                _context.SaveChanges();

                _context.CajaDetalles.Update(cajaDetalleOrigen);

                _context.SaveChanges();

                return new ResultDTO
                {
                    State = true,
                    Message = "La caja se cerró correctamente",
                };
            }
            catch (Exception ex)
            {
                return new ResultDTO
                {
                    State = false,
                    Message = $"Ocurrió un error al cerrar la caja (turno). {ex.Message}"
                };
            }
        }

        public ResultDTO GetCajasParaHacerTransferencia(Guid empresaId)
        {
            using var _context = new DataContext();

            // using var transaction = _context.Database.BeginTransaction();

            try
            {
                Expression<Func<CajaDetalle, bool>> filtro = filtro => true;

                filtro = filtro.And(x => x.Caja.EmpresaId == empresaId
                                         && !x.EstaEliminado
                                         && x.EstadoCaja == EstadoCaja.Abierta);

                var entities = _context.CajaDetalles
                    .AsNoTracking()
                    .Include(z => z.Caja)
                    .Where(filtro)
                    .ToList(); 

                return new ResultDTO
                {
                    State = true,
                    Data = _mapper.Map<IEnumerable<CajaDTO>>(entities)
                };
            }
            catch (Exception ex)
            {
                return new ResultDTO
                {
                    Message = ex.Message,
                    State = false
                };
            }
        }

        public bool VerificarSiEstaAbiertaCaja(Guid empresaId)
        {
            using var _context = new DataContext();

            // using var transaction = _context.Database.BeginTransaction();

            try
            {
                var cajas = _context.CajaDetalles
                    .AsNoTracking()
                    .Include(z => z.Caja)
                    .Where(x => x.Caja.EmpresaId == empresaId
                                && x.EstadoCaja == EstadoCaja.Abierta)
                    .OrderBy(z => z.Caja.Descripcion)
                    .ToList();

                return cajas.Any();
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool VerificarSiEstaAbiertaCaja(Guid empresaId, Guid cajaId)
        {
            using var _context = new DataContext();

            // using var transaction = _context.Database.BeginTransaction();

            try
            {
                var cajas = _context.CajaDetalles
                    .AsNoTracking()
                    .Include(z => z.Caja)
                    .Where(x => x.Caja.EmpresaId == empresaId
                                && x.EstadoCaja == EstadoCaja.Abierta
                                && x.CajaId == cajaId)
                    .OrderBy(z => z.Caja.Descripcion)
                    .ToList();

                return cajas.Any();
            }
            catch (Exception)
            {
                return false;
            }
        }

        public int ObtenerCantidadCajasAbiertas(Guid empresaId)
        {
            using var _context = new DataContext();

            // using var transaction = _context.Database.BeginTransaction();

            try
            {
                var cajas = _context.CajaDetalles
                    .AsNoTracking()
                    .Include(z => z.Caja)
                    .Where(x => x.Caja.EmpresaId == empresaId
                                && x.EstadoCaja == EstadoCaja.Abierta)
                    .OrderBy(z => z.Caja.Descripcion)
                    .ToList();
                
                return cajas.Count();
            }
            catch (Exception)
            {
                return 0;
            }
        }

        // ------------------------------------------------------------------------------------------------------ //
        // ------------------------------             Metodos Privados              ----------------------------- //
        // ------------------------------------------------------------------------------------------------------ //

        private bool VerificarSiExiste(string descripcion, Guid empresaId, Guid? id = null)
        {
            using var _context = new DataContext();

            if (id == null)
            {

                return _context.Cajas.Any(x => x.EmpresaId == empresaId && x.Descripcion.ToLower() == descripcion.ToLower());
            }
            else
            {
                return _context.Cajas.Any(x => x.Id != id.Value
                                               && x.EmpresaId == empresaId
                                               && x.Descripcion.ToLower() == descripcion.ToLower());
            }
        }        
    }
}
