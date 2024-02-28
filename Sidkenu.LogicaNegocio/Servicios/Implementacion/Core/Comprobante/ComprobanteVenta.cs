using Microsoft.EntityFrameworkCore;
using Sidkenu.AccesoDatos.Constantes;
using Sidkenu.AccesoDatos.Constantes.Enum;
using Sidkenu.AccesoDatos.Entidades.Core;
using Sidkenu.Infraestructura;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Base;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.Articulo;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.Comprobante;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.ConfiguracionCore;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.MedioPago;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.OrdenFabricacion;
using System.Linq.Expressions;

namespace Sidkenu.LogicaNegocio.Servicios.Implementacion.Core.Comprobante
{
    public class ComprobanteVenta : Comprobante
    {
        public override ResultDTO AddOrUpdate(ComprobanteDTO comprobante, string userLogin)
        {
            var resultDto = new ResultDTO();

            using var _context = new DataContext();

            try
            {
                var nuevoComprobante = new AccesoDatos.Entidades.Core.ComprobanteVenta();

                var comprobanteResult = base.AddOrUpdate(comprobante, userLogin);

                if (comprobanteResult != null && comprobanteResult.State)
                {
                    if (!comprobante.VieneDeCajaExterna)
                    {
                        nuevoComprobante = (Sidkenu.AccesoDatos.Entidades.Core.ComprobanteVenta)comprobanteResult.Data;
                    }
                    else
                    {
                        nuevoComprobante = _context.Comprobantes.OfType<AccesoDatos.Entidades.Core.ComprobanteVenta>()
                            .First(x=>x.Id ==  comprobante.Id);

                        nuevoComprobante.Detalles = new List<ComprobanteDetalle>();
                        nuevoComprobante.Totales = new List<ComprobanteTotales>();
                        nuevoComprobante.MedioPagos = new List<MedioPago>();
                        nuevoComprobante.Movimientos = new List<MovimientoCaja>();
                    }

                    if (comprobante.EstaPagado)
                    {
                        if (comprobante.Detalles.Any(x => x.TipoItem == TipoItemFactura.Fabricacion))
                        {
                            nuevoComprobante.EstadoComprobante = EstadoComprobante.FacturadoConFabricacion;
                        }
                        else
                        {
                            nuevoComprobante.EstadoComprobante = EstadoComprobante.Facturado;
                        }
                    }
                    else
                    {
                        nuevoComprobante.EstadoComprobante = EstadoComprobante.Pendiente;
                    }

                    foreach (var detalle in comprobante.Detalles.Where(x => x.TipoItem == TipoItemFactura.Fabricacion).ToList())
                    {
                        var nuevoDetalle = new ComprobanteDetalle();

                        var articuloTemporalId = AsignarDatosArticuloTemporal(detalle, comprobante.EmpresaId, userLogin);

                        nuevoDetalle.ArticuloId = articuloTemporalId;
                        nuevoDetalle.Codigo = detalle.Codigo;
                        nuevoDetalle.Descripcion = detalle.Descripcion;
                        nuevoDetalle.Neto = detalle.Neto;
                        nuevoDetalle.Iva = detalle.Iva;
                        nuevoDetalle.Alicuota = detalle.Impuesto;
                        nuevoDetalle.Cantidad = detalle.Cantidad;
                        nuevoDetalle.SubTotal = detalle.SubTotal;
                        nuevoDetalle.Foto = detalle.Foto;
                        nuevoDetalle.FechaEntrega = detalle.FechaEntrega;
                        nuevoDetalle.EstaEliminado = false;
                        nuevoDetalle.TipoItem = detalle.TipoItem;

                        nuevoComprobante.Detalles.Add(nuevoDetalle);

                        var ordenFabricacion = AsignarDatosOrdenFabricacion(detalle, comprobante.EmpresaId, articuloTemporalId, userLogin);
                    }

                    /// Medios de Pagos

                    foreach (var mp in comprobante.MedioPagos.ToList())
                    {
                        if (mp is MedioPagoEfectivoDTO)
                        {
                            var mpEfectivo = AsignarMedioPagoEfectivo(comprobante, mp);
                            mpEfectivo.User = userLogin;

                            nuevoComprobante.MedioPagos.Add(mpEfectivo);

                            // Movimiento de Caja 

                            var nuevoMovCaja = AsignarMovimientoCaja(comprobante.Fecha,
                                mpEfectivo.Capital,
                                mpEfectivo.Interes,
                                $"Op => Efectivo",
                                comprobante.CajaDetalleId,
                                TipoOperacionMovimiento.Efectivo,
                                userLogin);

                            nuevoComprobante.Movimientos.Add(nuevoMovCaja);

                            continue;
                        }
                        else if (mp is MedioPagoChequeDTO)
                        {
                            var mpCheque = AsignarMedioPagoCheque(comprobante, mp);
                            mpCheque.User = userLogin;

                            nuevoComprobante.MedioPagos.Add(mpCheque);

                            // Movimiento de Caja

                            var _banco = _context.Bancos.Find(mpCheque.BancoId);

                            var nuevoMovCaja = AsignarMovimientoCaja(comprobante.Fecha,
                                mpCheque.Capital,
                                mpCheque.Interes,
                                $"Op => Cheque - Nro: {mpCheque.NumeroCheque} - Banco: {_banco.Descripcion} - Venc: {mpCheque.FechaVencimiento.ToShortDateString()}",
                                comprobante.CajaDetalleId,
                                TipoOperacionMovimiento.Cheque,
                                userLogin);

                            nuevoComprobante.Movimientos.Add(nuevoMovCaja);

                            continue;
                        }
                        else if (mp is MedioPagoTransferenciaDTO)
                        {
                            var mpTransferencia = AsignarMedioPagoTransferencia(comprobante, mp);
                            mpTransferencia.User = userLogin;

                            nuevoComprobante.MedioPagos.Add(mpTransferencia);

                            // Movimiento de Caja

                            var _banco = _context.Bancos.Find(mpTransferencia.BancoId);

                            var nuevoMovCaja = AsignarMovimientoCaja(comprobante.Fecha,
                                mpTransferencia.Capital,
                                mpTransferencia.Interes,
                                $"Op => Transferencia - Nro: {mpTransferencia.NumeroTransferencia} - Banco: {_banco.Descripcion} - Titular: {mpTransferencia.NombreTitular}",
                                comprobante.CajaDetalleId,
                                TipoOperacionMovimiento.Transferencia,
                                userLogin);

                            nuevoComprobante.Movimientos.Add(nuevoMovCaja);

                            continue;
                        }
                        else if (mp is MedioPagoTarjetaDTO)
                        {
                            var mpTarjeta = AsignarMedioPagoTarjeta(comprobante, mp);
                            mpTarjeta.User = userLogin;

                            nuevoComprobante.MedioPagos.Add(mpTarjeta);

                            // Movimiento de Caja

                            var planTarjeta = _context.PlanTarjetas.AsNoTracking().Include(x => x.Tarjeta).FirstOrDefault(x => x.Id == mpTarjeta.PlanTarjetaId);

                            var nuevoMovCaja = AsignarMovimientoCaja(comprobante.Fecha,
                                mpTarjeta.Capital,
                                mpTarjeta.Interes,
                                $"Op => Tarjeta - {planTarjeta.Tarjeta.Descripcion} - Plan: {planTarjeta.Descripcion} - Cupon: {mpTarjeta.NumeroCupon}",
                                comprobante.CajaDetalleId,
                                TipoOperacionMovimiento.Tarjeta,
                                userLogin);

                            nuevoComprobante.Movimientos.Add(nuevoMovCaja);

                            continue;
                        }
                        else if (mp is MedioPagoCtaCteDTO)
                        {
                            var mpCtaCte = AsignarMedioPagoCtaCte(comprobante, mp);
                            mpCtaCte.User = userLogin;

                            nuevoComprobante.MedioPagos.Add(mpCtaCte);

                            var _nuevaCtaCteCliente = AsignarCuentaCorriente(comprobante, userLogin, mpCtaCte);

                            _context.CuentaCorrienteClientes.Add(_nuevaCtaCteCliente);

                            var _cliente = _context.Clientes.Include(x => x.TipoDocumento)
                                .FirstOrDefault(x => x.Id == mpCtaCte.ClienteId);

                            var nuevoMovCaja = AsignarMovimientoCaja(comprobante.Fecha,
                                mpCtaCte.Capital,
                                mpCtaCte.Interes,
                                $"Op => Cta. Cte. {_cliente.RazonSocial} - {_cliente.TipoDocumento.Descripcion}: {_cliente.Documento}",
                                comprobante.CajaDetalleId,
                                TipoOperacionMovimiento.CuentaCorriente,
                                userLogin);

                            nuevoComprobante.Movimientos.Add(nuevoMovCaja);

                            continue;
                        }
                        else if (mp is MedioPagoDTO)
                        {
                            var mpPendiente = AsignarMedioPagoPendiente(comprobante, mp);
                            mpPendiente.User = userLogin;

                            nuevoComprobante.MedioPagos.Add(mpPendiente);

                            // Movimiento de Caja 

                            var nuevoMovCaja = AsignarMovimientoCaja(comprobante.Fecha,
                                mpPendiente.Capital,
                                mpPendiente.Interes,
                                $"Op => Efectivo",
                                comprobante.CajaDetalleId,
                                TipoOperacionMovimiento.PendienteDePago,
                                userLogin);

                            nuevoComprobante.Movimientos.Add(nuevoMovCaja);

                            continue;
                        }
                    }

                    if (!comprobante.VieneDeCajaExterna)
                    {
                        _context.Comprobantes.Add(nuevoComprobante);
                    }
                    else
                    {
                        nuevoComprobante.EstadoComprobante = EstadoComprobante.Facturado;
                        
                        _context.Comprobantes.Update(nuevoComprobante);
                    }

                    // Descontar Stock

                    var _configCoreResult = ConfiguracionCoreServicio.Get(comprobante.EmpresaId);

                    if (_configCoreResult == null || !_configCoreResult.State)
                    {
                        resultDto.State = false;
                        resultDto.Message = "Ocurrio un error al obtener la configuracion del deposito seleccionado para la venta";
                    }

                    var _configCore = (ConfiguracionCoreDTO)_configCoreResult.Data;


                    var _articulosDescontar = nuevoComprobante.Detalles.Where(x => x.ArticuloId.HasValue && x.TipoItem != TipoItemFactura.Fabricacion)
                                                                       .GroupBy(x => x.ArticuloId)
                                                                       .Select(x => new
                                                                       {
                                                                           Id = x.Key,
                                                                           Cantidad = x.Sum(s => s.Cantidad)
                                                                       }).ToList();


                    foreach (var _articulo in _articulosDescontar.ToList())
                    {
                        var _articulosDepositos = _context.ArticuloDepositos
                            .AsNoTracking()
                            .Include(z => z.Articulo)
                            .Include(z => z.Articulo).ThenInclude(z => z.ArticuloHijoKits)
                            .Include(z => z.Articulo).ThenInclude(z => z.ArticuloFormulas)
                            .Where(x => x.DepositoId == _configCore.DepositoPorDefectoParaVentaId && x.ArticuloId == _articulo.Id)
                            .ToList();

                        if (_articulosDepositos == null)
                        {
                            resultDto.State = false;
                            resultDto.Message = "Ocurrio un error al obtener el articulo para descontar Stock";
                        }

                        var _artDep = _articulosDepositos.First();

                        _artDep.Cantidad -= _articulo.Cantidad;

                        _context.ArticuloDepositos.Update(_artDep);

                        if (_artDep.Articulo.TipoArticulo == TipoArticulo.Kit)
                        {
                            foreach (var artkit in _artDep.Articulo.ArticuloHijoKits)
                            {
                                var _articulosDepositosKits = _context.ArticuloDepositos
                                    .AsNoTracking()
                                    .Where(x => x.DepositoId == _configCore.DepositoPorDefectoParaVentaId
                                                && x.ArticuloId == artkit.ArticuloHijoId)
                                    .ToList();

                                if (_articulosDepositosKits == null)
                                {
                                    resultDto.State = false;
                                    resultDto.Message = "Ocurrio un error al obtener el articulo para descontar Stock";
                                }

                                var _artDepkit = _articulosDepositosKits.First();

                                _artDepkit.Cantidad -= (_articulo.Cantidad * artkit.Cantidad);

                                _context.ArticuloDepositos.Update(_artDepkit);
                            }
                        }

                        if (_artDep.Articulo.TipoArticulo == TipoArticulo.Formula)
                        {
                            foreach (var artForm in _artDep.Articulo.ArticuloFormulas)
                            {
                                var _articulosDepositosForms = _context.ArticuloDepositos
                                    .AsNoTracking()
                                    .Where(x => x.DepositoId == _configCore.DepositoPorDefectoParaVentaId
                                                && x.ArticuloId == artForm.ArticuloSecundarioId)
                                    .ToList();

                                if (_articulosDepositosForms == null)
                                {
                                    resultDto.State = false;
                                    resultDto.Message = "Ocurrio un error al obtener el articulo para descontar Stock";
                                }

                                var _artDepForm = _articulosDepositosForms.First();

                                _artDepForm.Cantidad -= (_articulo.Cantidad * artForm.Cantidad);

                                _context.ArticuloDepositos.Update(_artDepForm);
                            }
                        }
                    }

                    _context.SaveChanges();

                    resultDto.State = true;
                    resultDto.Message = "Los datos se grabaron correctamente";
                }
                else
                {
                    resultDto = comprobanteResult;
                }
            }
            catch (Exception ex)
            {
                resultDto.Message = ex.Message;
                resultDto.State = false;
            }

            return resultDto;
        }

        private static MovimientoCaja AsignarMovimientoCaja(DateTime fecha, decimal capital, decimal interes, string descripcion, Guid cajaDetalleId, TipoOperacionMovimiento operacion, string userLogin)
        {
            var nuevoMovCaja = new MovimientoCaja();

            nuevoMovCaja.TipoMovimiento = TipoMovimiento.Ingreso;
            nuevoMovCaja.Capital = capital;
            nuevoMovCaja.Interes = interes;
            nuevoMovCaja.CajaDetalleId = cajaDetalleId;
            nuevoMovCaja.Descripcion = descripcion; 
            nuevoMovCaja.EstaEliminado = false;
            nuevoMovCaja.Fecha = fecha;
            nuevoMovCaja.User = userLogin;
            nuevoMovCaja.TipoOperacion = operacion;

            return nuevoMovCaja;
        }

        private static CuentaCorrienteCliente AsignarCuentaCorriente(ComprobanteDTO comprobante, string userLogin, MedioPagoCtaCte mpCtaCte)
        {
            var _nuevaCtaCteCliente = new CuentaCorrienteCliente();

            _nuevaCtaCteCliente.ClienteId = mpCtaCte.ClienteId;
            _nuevaCtaCteCliente.TipoMovimiento = TipoMovimiento.Egreso;
            _nuevaCtaCteCliente.Fecha = comprobante.Fecha;
            _nuevaCtaCteCliente.NroComprobanteFactura = string.Empty;
            _nuevaCtaCteCliente.Monto = mpCtaCte.Capital + mpCtaCte.Interes;
            _nuevaCtaCteCliente.EstaEliminado = false;
            _nuevaCtaCteCliente.User = userLogin;

            return _nuevaCtaCteCliente;
        }

        private static MedioPagoCtaCte AsignarMedioPagoCtaCte(ComprobanteDTO comprobante, MedioPagoDTO? mp)
        {
            var mpCtaCte = new MedioPagoCtaCte();

            var mpCtaCteDto = (MedioPagoCtaCteDTO)mp;

            mpCtaCte.EmpresaId = comprobante.EmpresaId;
            mpCtaCte.Interes = mpCtaCteDto.Interes;
            mpCtaCte.Capital = mpCtaCteDto.Capital;
            mpCtaCte.Tipo = mpCtaCteDto.Tipo;
            mpCtaCte.ClienteId = mpCtaCteDto.Cliente.Id;

            return mpCtaCte;
        }

        private static MedioPagoTarjeta AsignarMedioPagoTarjeta(ComprobanteDTO comprobante, MedioPagoDTO? mp)
        {
            var mpTarjeta = new MedioPagoTarjeta();

            var mpTarjetaDto = (MedioPagoTarjetaDTO)mp;

            mpTarjeta.EmpresaId = comprobante.EmpresaId;
            mpTarjeta.Interes = mpTarjetaDto.Interes;
            mpTarjeta.Capital = mpTarjetaDto.Capital;
            mpTarjeta.Tipo = mpTarjetaDto.Tipo;
            mpTarjeta.NumeroCupon = mpTarjetaDto.NumeroCupon;
            mpTarjeta.PlanTarjetaId = mpTarjetaDto.PlanTarjetaId;

            return mpTarjeta;
        }

        private static MedioPagoTransferencia AsignarMedioPagoTransferencia(ComprobanteDTO comprobante, MedioPagoDTO? mp)
        {
            var mpTransferencia = new MedioPagoTransferencia();

            var mpTransferenciaDto = (MedioPagoTransferenciaDTO)mp;

            mpTransferencia.EmpresaId = comprobante.EmpresaId;
            mpTransferencia.Interes = mpTransferenciaDto.Interes;
            mpTransferencia.Capital = mpTransferenciaDto.Capital;
            mpTransferencia.Tipo = mpTransferenciaDto.Tipo;
            mpTransferencia.NumeroTransferencia = mpTransferenciaDto.NumeroTransferencia;
            mpTransferencia.BancoId = mpTransferenciaDto.BancoId;
            mpTransferencia.NombreTitular = mpTransferenciaDto.NombreTitular;

            return mpTransferencia;
        }

        private static MedioPagoCheque AsignarMedioPagoCheque(ComprobanteDTO comprobante, MedioPagoDTO? mp)
        {
            var mpCheque = new MedioPagoCheque();

            var mpChequeDto = (MedioPagoChequeDTO)mp;

            mpCheque.EmpresaId = comprobante.EmpresaId;
            mpCheque.Interes = mpChequeDto.Interes;
            mpCheque.Capital = mpChequeDto.Capital;
            mpCheque.Tipo = mpChequeDto.Tipo;
            mpCheque.NumeroCheque = mpChequeDto.NumeroCheque;
            mpCheque.BancoId = mpChequeDto.BancoId;
            mpCheque.FechaVencimiento = mpChequeDto.FechaVencimiento;

            return mpCheque;
        }

        private static MedioPagoEfectivo AsignarMedioPagoEfectivo(ComprobanteDTO comprobante, MedioPagoDTO? mp)
        {
            var mpEfectivo = new MedioPagoEfectivo();

            var mpEfectivoDto = (MedioPagoEfectivoDTO)mp;

            mpEfectivo.EmpresaId = comprobante.EmpresaId;
            mpEfectivo.Interes = mpEfectivoDto.Interes;
            mpEfectivo.Capital = mpEfectivoDto.Capital;
            mpEfectivo.Tipo = mpEfectivoDto.Tipo;

            return mpEfectivo;
        }

        private static MedioPago AsignarMedioPagoPendiente(ComprobanteDTO comprobante, MedioPagoDTO? mp)
        {
            var mpPendiente = new MedioPago();

            var mpPendienteDto = (MedioPagoDTO)mp;

            mpPendiente.EmpresaId = comprobante.EmpresaId;
            mpPendiente.Interes = mpPendienteDto.Interes;
            mpPendiente.Capital = mpPendienteDto.Capital;
            mpPendiente.Tipo = mpPendienteDto.Tipo;

            return mpPendiente;
        }

        private ResultDTO AsignarDatosOrdenFabricacion(ComprobanteDetalleDTO detalle, Guid empresaId, Guid articuloTemporalId, string userLogin)
        {
            var configCoreResult = ConfiguracionCoreServicio.Get(empresaId);

            var _configuracion = (ConfiguracionCoreDTO)configCoreResult.Data;

            var nuevaOrdenFabricacion = new OrdenFabricacionPersistenciaDTO();

            nuevaOrdenFabricacion.OrigenFabricacion = OrigenFabricacion.Venta;
            nuevaOrdenFabricacion.ArticuloId = articuloTemporalId;
            nuevaOrdenFabricacion.EmpresaId = empresaId;
            nuevaOrdenFabricacion.NumeroOrden = int.Parse(detalle.CodigoFabricacion);
            nuevaOrdenFabricacion.FechaFinalizacion = null;
            nuevaOrdenFabricacion.Cantidad = detalle.Cantidad;
            nuevaOrdenFabricacion.DepositoOrigenId = _configuracion.DepositoPorDefectoParaVentaId;
            nuevaOrdenFabricacion.DepositoDestinoId = _configuracion.DepositoPorDefectoParaVentaId;
            nuevaOrdenFabricacion.EstaEliminado = false;               
            nuevaOrdenFabricacion.ActulizarPrecioPublico = false;
            nuevaOrdenFabricacion.Foto = detalle.Foto;

            nuevaOrdenFabricacion.Detalles = new List<OrdenFabricacionDetalleDTO>();

            foreach (var detalleFabricacion in detalle.FabricacionDetalles.ToList())
            {
                var nuevoDetalleFabricacion = new OrdenFabricacionDetalleDTO();

                nuevoDetalleFabricacion.ArticuloId = detalleFabricacion.ArticuloId.Value;
                nuevoDetalleFabricacion.Cantidad = detalleFabricacion.Cantidad;
                nuevoDetalleFabricacion.Codigo = detalleFabricacion.Codigo;
                nuevoDetalleFabricacion.Descripcion = detalleFabricacion.Descripcion;
                nuevoDetalleFabricacion.EstaEliminado = false;
                
                nuevaOrdenFabricacion.Detalles.Add(nuevoDetalleFabricacion);
            }

            var result = OrdenFabricacionServicio.Add(nuevaOrdenFabricacion, userLogin);

            return new ResultDTO { State = true, Data = result };
        }

        private Guid AsignarDatosArticuloTemporal(ComprobanteDetalleDTO detalle, Guid empresaId, string userLogin)
        {
            var nuevoArticuloTemporal = new ArticuloTemporalPersistenciaDTO();

            nuevoArticuloTemporal.EmpresaId = empresaId;
            nuevoArticuloTemporal.Codigo = detalle.Codigo;
            nuevoArticuloTemporal.Descripcion = detalle.Descripcion;
            nuevoArticuloTemporal.Foto = detalle.Foto;
            nuevoArticuloTemporal.PrecioPublico = detalle.PrecioPublico;
            nuevoArticuloTemporal.EstaEliminado = true;
            nuevoArticuloTemporal.Foto = detalle.Foto;

            var result = ArticuloTemporalServicio.Add(nuevoArticuloTemporal, userLogin);

            if (result == null || !result.State)
            {
                throw new Exception("Ocurrió un error al crear el archivo temporal");
            }

            return ((ArticuloTemporalPersistenciaDTO)result.Data).Id;
        }

        public override ResultDTO GetComprobantesPendientesCobroVentaMostrador(Guid id, Guid empresaId)
        {
            using var _context = new DataContext();

            try
            {
                Expression<Func<AccesoDatos.Entidades.Core.ComprobanteVenta, bool>> filtro = filtro => true;

                filtro = filtro.And(x => x.EmpresaId == empresaId && x.Movimientos.Any(m=>m.CajaDetalle.CajaId == id) && x.Movimientos.Count <= 1);

                filtro = filtro.And(x => x.EstadoComprobante == EstadoComprobante.Pendiente);

                var entities = _context.Comprobantes.OfType<AccesoDatos.Entidades.Core.ComprobanteVenta>()
                    .AsNoTracking()
                    .Include(x => x.Empresa)
                    .Include(x => x.Persona)
                    .Include(x => x.Cliente)
                    .Include(x => x.Movimientos).ThenInclude(x => x.CajaDetalle)
                    .Include(x => x.Detalles)
                    .Where(filtro)
                    .OrderByDescending(d => d.Fecha)
                    .ToList();

                return new ResultDTO
                {
                    State = true,
                    Data = Mapper.Map<IEnumerable<ComprobanteVentaDTO>>(entities)
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

        public override ResultDTO GetComprobantesPendientesCobroVentaMostrador(Guid id, Guid empresaId, string cuit)
        {
            using var _context = new DataContext();

            try
            {
                Expression<Func<AccesoDatos.Entidades.Core.ComprobanteVenta, bool>> filtro = filtro => true;

                filtro = filtro.And(x => x.EmpresaId == empresaId
                                         && x.Movimientos.Any(m => m.CajaDetalle.CajaId == id)
                                         && x.Persona.Cuil == cuit);

                filtro = filtro.And(x => x.EstadoComprobante == EstadoComprobante.Pendiente);

                var entities = _context.Comprobantes.OfType<AccesoDatos.Entidades.Core.ComprobanteVenta>()
                    .AsNoTracking()
                    .Include(x => x.Empresa)
                    .Include(x => x.Persona)
                    .Include(x => x.Cliente)
                    .Include(x => x.Movimientos).ThenInclude(x => x.CajaDetalle)
                    .Include(x => x.Detalles)
                    .Where(filtro)
                    .OrderByDescending(d => d.Fecha)
                    .ToList();
                
                var listaComprobantes = Mapper.Map<IEnumerable<ComprobanteVentaDTO>>(entities);

                Parallel.ForEach(listaComprobantes, x =>
                {
                    x.EstaSeleccionado = true;
                });

                return new ResultDTO
                {
                    State = true,
                    Data = listaComprobantes.ToList()
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
    }
}

