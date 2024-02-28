using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Sidkenu.AccesoDatos.Constantes;
using Sidkenu.AccesoDatos.Constantes.Enum;
using Sidkenu.AccesoDatos.Entidades.Core;
using Sidkenu.Infraestructura;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Base;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.Articulo;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.OrdenFabricacion;
using Sidkenu.LogicaNegocio.Servicios.Implementacion.Base;
using Sidkenu.LogicaNegocio.Servicios.Interface.Core;
using Sidkenu.LogicaNegocio.Servicios.Interface.Seguridad;
using System.Linq.Expressions;
using System.Transactions;

namespace Sidkenu.LogicaNegocio.Servicios.Implementacion.Core
{
    public class OrdenFabricacionServicio : ServicioBase, IOrdenFabricacionServicio
    {
        private readonly IConfiguracionCoreServicio _configuracionCoreServicio;
        private readonly IArticuloServicio _articuloServicio;
        private readonly IContadorServicio _contadorServicio;
        private readonly IArticuloPrecioServicio _articuloPrecioServicio;

        public OrdenFabricacionServicio(IMapper mapper,
                                IConfiguracionServicio configuracionServicio,
                                IConfiguracionCoreServicio configuracionCoreServicio,
                                IArticuloServicio articuloServicio,
                                IContadorServicio contadorServicio,
                                IArticuloPrecioServicio articuloPrecioServicio)
                                : base(mapper, configuracionServicio)
        {
            _configuracionCoreServicio = configuracionCoreServicio;
            _articuloServicio = articuloServicio;
            _articuloPrecioServicio = articuloPrecioServicio;
            _contadorServicio = contadorServicio;            
        }

        public ResultDTO Add(OrdenFabricacionPersistenciaDTO entidad, string user)
        {
            using var _context = new DataContext();

            // using var transaction = _context.Database.BeginTransaction();

            try
            {
                var contadorResult = _contadorServicio
                    .ObtenerNumero(TipoContador.OrdenFabricacion, entidad.EmpresaId, user);

                var existeEntidad = VerificarSiExiste(entidad.ArticuloId, entidad.EmpresaId);

                if (existeEntidad)
                    return new ResultDTO
                    {
                        Message = "Los datos ingresados ya existen",
                        State = false,
                    };

                var entity = _mapper.Map<OrdenFabricacion>(entidad);

                entity.Numero = entidad.OrigenFabricacion == OrigenFabricacion.Fabrica ? (int)contadorResult : entidad.NumeroOrden;
                entity.Fecha = DateTime.Now;
                entity.EstadoOrdenFabricacion = EstadoOrdenFabricacion.Pendiente;
                entity.User = user;
                entity.EstaEliminado = false;
                entity.OrdenFabricacionDetalles = new List<OrdenFabricacionDetalle>();
                entity.OrigenFabricacion = entidad.OrigenFabricacion;
                entity.ActulizarPrecioPublico = entidad.ActulizarPrecioPublico; 

                foreach (var detalle in entidad.Detalles)
                {
                    entity.OrdenFabricacionDetalles.Add(new OrdenFabricacionDetalle
                    {
                        ArticuloId = detalle.ArticuloId,
                        Cantidad = detalle.Cantidad,
                        Codigo = detalle.Codigo,
                        Descripcion = detalle.Descripcion,
                        EstaEliminado = false,
                        User = user
                    });
                }

                _context.OrdenFabricaciones.Add(entity);

                entidad.Id = entity.Id;

                _context.SaveChanges();

                return new ResultDTO
                {
                    State = true,
                    Message = "Los datos se grabaron correctamente",
                    Data = entidad
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

        private bool VerificarSiExiste(Guid articuloId, Guid empresaId)
        {
            using var _context = new DataContext();

            // using var transaction = _context.Database.BeginTransaction();

            var result = _context.OrdenFabricaciones
                .AsNoTracking()
                .Where(x => x.ArticuloBaseId == articuloId
                            && x.EmpresaId == empresaId
                            && x.EstadoOrdenFabricacion == EstadoOrdenFabricacion.Pendiente);

            return result !=null && result.Any();
        }

        public ResultDTO GetByFilter(OrdenFabricacionFilterDTO filter)
        {
            using var _context = new DataContext();

            // using var transaction = _context.Database.BeginTransaction();

            try
            {
                filter.CadenaBuscar = !string.IsNullOrEmpty(filter.CadenaBuscar) ? filter.CadenaBuscar : string.Empty;

                Expression<Func<OrdenFabricacion, bool>> filtro = filtro => true;

                filtro = filtro.And(x => x.EmpresaId == filter.EmpresaId);

                if (int.TryParse(filter.CadenaBuscar, out int _codigo))
                {
                    filtro = filtro.And(x => x.Numero == _codigo);
                }

                var entities = _context.OrdenFabricaciones
                    .AsNoTracking()
                    .Include(x => x.ArticuloBase)
                    .Include(x => x.OrdenFabricacionDetalles)
                                   .ThenInclude(x => x.Articulo)
                                   .ThenInclude(x => x.ArticuloDepositos)
                    .Include(x => x.OrdenFabricacionDetalles)
                                   .ThenInclude(x => x.Articulo)
                                   .ThenInclude(x => x.ArticuloPrecios)
                    .Where(filtro)
                    .OrderByDescending(x => x.Fecha)
                    .ToList();
                
                var result = _mapper.Map<IEnumerable<OrdenFabricacionDTO>>(entities);

                // Controlar que haya todos los Insumos

                foreach (var orden in result
                    // .Where(x => x.EstadoOrdenFabricacion == Aplicacion.Constantes.EstadoOrdenFabricacion.Pendiente)
                    .ToList())
                {
                    var resultArticulos = _articuloServicio
                        .GetByIds(orden.Detalles.Select(x => x.ArticuloId).ToList(), filter.EmpresaId, orden.DepositoOrigenId);

                    if (!resultArticulos.State)
                    {
                        return new ResultDTO
                        {
                            State = false,
                            Message = "Ocurrio un problema al verificar los Stock de cada Articulo involucrado en el proceso de fabricacion"
                        };
                    }

                    foreach (var detalle in orden.Detalles.ToList())
                    {
                        var _resultArt = (List<ArticuloDTO>)resultArticulos.Data;

                        var _art = _resultArt.FirstOrDefault(x=>x.Id == detalle.ArticuloId);

                        if (_art != null)
                        {
                            detalle.StockActual = _art.Stock;
                            detalle.CantidadFabricar = orden.CantidadFabricar;
                        }
                    }

                    orden.SePuedeFabricar = !orden.Detalles.Any(x => x.Faltante > 0);
                }

                return new ResultDTO
                {
                    State = true,
                    Data = result.ToList(),
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

        public ResultDTO CambiarEstadoEnProceso(Guid ordenFabricacionId, string user)
        {
            using var transaction = new TransactionScope();
            using var _context = new DataContext();            

            try
            {
                var orden = _context.OrdenFabricaciones
                    .AsNoTracking()
                    .Include(z => z.OrdenFabricacionDetalles)
                    .FirstOrDefault(x => x.Id == ordenFabricacionId);

                if(orden != null) 
                {
                    orden.EstadoOrdenFabricacion = EstadoOrdenFabricacion.EnProceso;
                    orden.User = user;
                }

                _context.OrdenFabricaciones.Update(orden);

                foreach (var detalle in orden.OrdenFabricacionDetalles)
                {
                    var articuloDeposito = _context.ArticuloDepositos
                        .FirstOrDefault(x => x.DepositoId == orden.DepositoOrigenId
                                             && x.ArticuloId == detalle.ArticuloId);

                    var resultArticuloDeposito = _context.ArticuloDepositos.Find(articuloDeposito.Id);
                    
                    resultArticuloDeposito.Cantidad -= orden.CantidadFabricar * detalle.Cantidad;

                    _context.ArticuloDepositos.Update(resultArticuloDeposito);
                }

                _context.SaveChanges();

                transaction.Complete();

                return new ResultDTO { State = true };
            }
            catch (Exception ex)
            {
                transaction.Dispose();

                return new ResultDTO
                {
                    Message = ex.Message,
                    State = false
                };
            }
        }

        public ResultDTO CancelarOrdenFabricacion(Guid OrdenFabricacionId, string user)
        {
            using var transaction = new TransactionScope();
            using var _context = new DataContext();                       

            try
            {
                var orden = _context.OrdenFabricaciones
                    .Include(z => z.OrdenFabricacionDetalles)
                    .FirstOrDefault(x=>x.Id == OrdenFabricacionId);

                if (orden != null)
                {
                    orden.EstadoOrdenFabricacion = EstadoOrdenFabricacion.Pendiente;
                    orden.User = user;
                }

                _context.OrdenFabricaciones.Update(orden);

                foreach (var detalle in orden.OrdenFabricacionDetalles)
                {
                    var articuloDeposito = _context.ArticuloDepositos
                        .FirstOrDefault(x => x.DepositoId == orden.DepositoOrigenId
                                             && x.ArticuloId == detalle.ArticuloId);

                    var resultArticuloDeposito = _context.ArticuloDepositos.Find(articuloDeposito.Id);

                    resultArticuloDeposito.Cantidad += orden.CantidadFabricar * detalle.Cantidad;

                    _context.ArticuloDepositos.Update(resultArticuloDeposito);
                }

                _context.SaveChanges();

                transaction.Complete();

                return new ResultDTO { State = true , Message = "La Orden de Fabricación se canceló" };
            }
            catch (Exception ex)
            {
                transaction.Dispose();

                return new ResultDTO
                {
                    Message = ex.Message,
                    State = false
                };
            }
        }

        public ResultDTO FinalizarOrdenFabricacion(Guid ordenFabricacionId, string user)
        {
            using var transaction = new TransactionScope();
            using var _context = new DataContext();
            
            try
            {
                var orden = _context.OrdenFabricaciones
                    .Include(z => z.OrdenFabricacionDetalles)
                    .Include(z => z.ArticuloBase)
                    .Include(z => z.ArticuloBase).ThenInclude(z => z.OrdenFabricaciones)
                    .FirstOrDefault(x => x.Id == ordenFabricacionId);
                
                if (orden != null)
                {
                    orden.EstadoOrdenFabricacion = EstadoOrdenFabricacion.Finalizada;
                    orden.User = user;
                }

                _context.OrdenFabricaciones.Update(orden);

                if (orden.OrigenFabricacion == OrigenFabricacion.Fabrica)
                {
                    // Actualizo el Stock

                    var articuloDeposito = _context.ArticuloDepositos
                        .FirstOrDefault(x => x.DepositoId == orden.DepositoOrigenId
                                             && x.ArticuloId == orden.ArticuloBaseId);

                    var resultArticuloDeposito = _context.ArticuloDepositos.Find(articuloDeposito.Id);

                    resultArticuloDeposito.Cantidad += orden.CantidadFabricar;

                    _context.ArticuloDepositos.Update(resultArticuloDeposito);

                    foreach (var item in orden.OrdenFabricacionDetalles.ToList())
                    {
                        var articuloDepositoDetalle = _context.ArticuloDepositos
                            .FirstOrDefault(x => x.DepositoId == orden.DepositoOrigenId
                                                 && x.ArticuloId == item.ArticuloId);

                        var resultArticuloDepositoDetalle = _context.ArticuloDepositos.Find(articuloDepositoDetalle.Id);

                        resultArticuloDepositoDetalle.Cantidad += orden.CantidadFabricar;

                        _context.ArticuloDepositos.Update(resultArticuloDepositoDetalle);
                    }

                    //// Actualizo los Precios
                }
                else
                {
                    foreach (var item in orden.OrdenFabricacionDetalles.ToList())
                    {
                        var articuloDepositoDetalle = _context.ArticuloDepositos
                            .FirstOrDefault(x => x.DepositoId == orden.DepositoOrigenId
                                                 && x.ArticuloId == item.ArticuloId);

                        var resultArticuloDepositoDetalle = _context.ArticuloDepositos.Find(articuloDepositoDetalle.Id);

                        resultArticuloDepositoDetalle.Cantidad += orden.CantidadFabricar;
                        
                        _context.ArticuloDepositos.Update(resultArticuloDepositoDetalle);
                    }
                }

                _context.SaveChanges();

                transaction.Complete();

                return new ResultDTO { State = true, Message = "La Orden de Fabricación se canceló" };
            }
            catch (Exception ex)
            {
                transaction.Dispose();

                return new ResultDTO
                {
                    Message = ex.Message,
                    State = false
                };
            }
        }
    }
}
