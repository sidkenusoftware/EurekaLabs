using AutoMapper;
using Sidkenu.AccesoDatos.Constantes.Enum;
using Sidkenu.AccesoDatos.Entidades.Core;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Base;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.Comprobante;
using Sidkenu.LogicaNegocio.Servicios.Interface.Core;
using Sidkenu.LogicaNegocio.Servicios.Interface.Seguridad;

namespace Sidkenu.LogicaNegocio.Servicios.Implementacion.Core.Comprobante
{
    public class Comprobante
    {
        public IConfiguracionServicio ConfiguracionServicio { get; set; }
        public IMapper Mapper { get; set; }
        public IArticuloServicio ArticuloServicio { get; set; }
        public IArticuloTemporalServicio ArticuloTemporalServicio { get; set; }
        public IOrdenFabricacionServicio OrdenFabricacionServicio { get; set; }
        public IConfiguracionCoreServicio ConfiguracionCoreServicio { get; set; }


        public virtual ResultDTO AddOrUpdate(ComprobanteDTO comprobante, string userLogin)
        {
            try
            {
                var nuevoComprobante = ObtenerTipoComprobante(comprobante);
                    
                nuevoComprobante.ClienteId = comprobante.Cliente.Id;
                nuevoComprobante.PersonaId = comprobante.Persona.Id;
                nuevoComprobante.EmpresaId = comprobante.EmpresaId;
                nuevoComprobante.SubTotal = comprobante.SubTotal;
                nuevoComprobante.Descuento = comprobante.Descuento;
                nuevoComprobante.Total = comprobante.Total;
                nuevoComprobante.Fecha = comprobante.Fecha;
                nuevoComprobante.User = userLogin;
                nuevoComprobante.EstaEliminado = false;

                nuevoComprobante.Detalles = new List<ComprobanteDetalle>();
                nuevoComprobante.Totales = new List<ComprobanteTotales>();
                nuevoComprobante.MedioPagos = new List<MedioPago>();
                nuevoComprobante.Movimientos = new List<MovimientoCaja>();

                foreach (var detalle in comprobante.Detalles.Where(x=>x.TipoItem != TipoItemFactura.Fabricacion).ToList())
                {
                    var nuevoDetalle = new ComprobanteDetalle();

                    nuevoDetalle.ArticuloId = detalle.ArticuloId;
                    nuevoDetalle.Codigo = detalle.Codigo;
                    nuevoDetalle.Descripcion = detalle.Descripcion;
                    nuevoDetalle.Neto = detalle.Neto;
                    nuevoDetalle.Iva = detalle.Iva;
                    nuevoDetalle.Alicuota = detalle.Impuesto;
                    nuevoDetalle.Cantidad = detalle.Cantidad;
                    nuevoDetalle.SubTotal = detalle.SubTotal;
                    nuevoDetalle.Foto = detalle.TipoItem == TipoItemFactura.Fabricacion ? detalle.Foto : null;
                    nuevoDetalle.FechaEntrega = detalle.TipoItem == TipoItemFactura.Fabricacion ? detalle.FechaEntrega : null;
                    nuevoDetalle.EstaEliminado = false;
                    nuevoDetalle.TipoItem = detalle.TipoItem;
                    
                    nuevoComprobante.Detalles.Add(nuevoDetalle);
                }

                var totalesPorAlicuota = comprobante.Detalles
                    .GroupBy(x => x.Impuesto)
                    .Select(x => new ComprobanteTotales
                    {
                        Alicuota = x.Key,
                        Neto = x.Sum(n => n.Neto),
                        Iva = x.Sum(i => i.Iva)
                    });

                foreach (var item in totalesPorAlicuota.ToList())
                {
                    var nuevoTotal = new ComprobanteTotales();
                    nuevoTotal.Alicuota = item.Alicuota;
                    nuevoTotal.Neto = item.Neto;
                    nuevoTotal.Iva = item.Iva;
                    nuevoTotal.User = userLogin;
                    nuevoTotal.EstaEliminado = false;
                    
                    nuevoComprobante.Totales.Add(nuevoTotal);
                }

                return new ResultDTO
                {
                    State = true,
                    Data = nuevoComprobante,
                };
            }
            catch (Exception ex)
            {
                return new ResultDTO { State = false, Data = null, Message = "Ocurrio un error al crear el nuevo Comprobante Base" };
            }           
        }

        public virtual ResultDTO GetComprobantesPendientesCobroVentaMostrador(Guid id, Guid empresaId)
        {
            try
            {
                return new ResultDTO
                {
                    State = true,
                };
            }
            catch (Exception ex)
            {
                return new ResultDTO { State = false, Data = null, Message = "Ocurrio un error al obtener los datos" };
            }
        }

        public virtual ResultDTO GetComprobantesPendientesCobroVentaMostrador(Guid id, Guid empresaId, string cuit)
        {
            try
            {
                return new ResultDTO
                {
                    State = true,
                };
            }
            catch (Exception ex)
            {
                return new ResultDTO { State = false, Data = null, Message = "Ocurrio un error al obtener los datos" };
            }
        }

        public virtual ResultDTO GetDatosEstadisticos(DateTime fechaInicio, DateTime fechaFin, Guid empresaId)
        {
            try
            {
                return new ResultDTO
                {
                    State = true,
                };
            }
            catch (Exception ex)
            {
                return new ResultDTO { State = false, Data = null, Message = "Ocurrio un error al obtener los datos estadisticos" };
            }
        }

        private AccesoDatos.Entidades.Core.Comprobante ObtenerTipoComprobante(ComprobanteDTO comprobante)
        {
            if (comprobante is ComprobanteVentaDTO)
            {
                return new AccesoDatos.Entidades.Core.ComprobanteVenta();
            }

            if (comprobante is ComprobanteGastoDTO)
            {
                return new AccesoDatos.Entidades.Core.ComprobanteGasto();
            }

            if (comprobante is ComprobanteTransferenciaDTO)
            {
                return new AccesoDatos.Entidades.Core.ComprobanteTransferencia();
            }

            return new AccesoDatos.Entidades.Core.Comprobante();
        }
    }
}
