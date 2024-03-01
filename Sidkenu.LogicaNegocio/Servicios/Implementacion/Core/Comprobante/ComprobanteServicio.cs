using AutoMapper;
using Sidkenu.AccesoDatos.Constantes.Enum;
using Sidkenu.AccesoDatos.Entidades.Seguridad;
using Sidkenu.Infraestructura;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Base;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.Comprobante;
using Sidkenu.LogicaNegocio.Servicios.Implementacion.Base;
using Sidkenu.LogicaNegocio.Servicios.Interface.Core;
using Sidkenu.LogicaNegocio.Servicios.Interface.Seguridad;

namespace Sidkenu.LogicaNegocio.Servicios.Implementacion.Core.Comprobante
{
    public class ComprobanteServicio : ServicioBase, IComprobanteServicio
    {
        private Dictionary<TipoComprobante, string> _diccionarioComprobante;

        private readonly IArticuloServicio _articuloServicio;
        private readonly IArticuloTemporalServicio _articuloTemporalServicio;
        private readonly IOrdenFabricacionServicio _ordenFabricacionServicio;
        private readonly IConfiguracionCoreServicio _configuracionCoreServicio;

        public ComprobanteServicio(IMapper mapper,
                                   IConfiguracionServicio configuracionServicio,
                                   IArticuloServicio articuloServicio,
                                   IArticuloTemporalServicio articuloTemporalServicio,
                                   IOrdenFabricacionServicio ordenFabricacionServicio,
                                   IConfiguracionCoreServicio configuracionCoreServicio)
                                   : base(mapper, configuracionServicio)
        {
            _articuloServicio = articuloServicio;
            _articuloTemporalServicio = articuloTemporalServicio;
            _ordenFabricacionServicio = ordenFabricacionServicio;
            _configuracionCoreServicio = configuracionCoreServicio;

            _diccionarioComprobante = new Dictionary<TipoComprobante, string>();

            CargarDiccionario(_diccionarioComprobante);
        }

        private void CargarDiccionario(Dictionary<TipoComprobante, string> diccionario)
        {
            diccionario.Add(TipoComprobante.Venta, "Sidkenu.LogicaNegocio.Servicios.Implementacion.Core.Comprobante.ComprobanteVenta");
            diccionario.Add(TipoComprobante.Salon, "Sidkenu.LogicaNegocio.Servicios.Implementacion.Core.Comprobante.ComprobanteSalon");
            diccionario.Add(TipoComprobante.Compra, "Sidkenu.LogicaNegocio.Servicios.Implementacion.Core.Comprobante.ComprobanteCompra");
            diccionario.Add(TipoComprobante.NotaCredito, "Sidkenu.LogicaNegocio.Servicios.Implementacion.Core.Comprobante.ComprobanteNotaCredito");
            diccionario.Add(TipoComprobante.NotaDebito, "Sidkenu.LogicaNegocio.Servicios.Implementacion.Core.Comprobante.ComprobanteNotaDebito");
            diccionario.Add(TipoComprobante.Gastos, "Sidkenu.LogicaNegocio.Servicios.Implementacion.Core.Comprobante.ComprobanteGastos");
            diccionario.Add(TipoComprobante.TransferenciaCaja, "Sidkenu.LogicaNegocio.Servicios.Implementacion.Core.Comprobante.ComprobanteTransferencia");
        }

        public ResultDTO AddOrUpdate(ComprobanteDTO comprobante, string userLogin)
        {
            // Valida que este en el diccionario
            if (!_diccionarioComprobante.TryGetValue(comprobante.TipoComprobante, out string? tipoComprobante))
            {
                throw new Exception("No se encontro el Comprobante seleccionado");
            }

            // Valida el tipo de comprobante (clase)
            var _comprobante = Type.GetType(tipoComprobante) ?? throw new Exception("Ocurrio un error al obtener el comprobante");

            var comprobanteResult = Activator.CreateInstance(_comprobante) as Comprobante;

            if (comprobanteResult != null)
            {
                comprobanteResult.ConfiguracionServicio = base._configuracionServicio;
                comprobanteResult.Mapper = base._mapper;
                comprobanteResult.ArticuloServicio = _articuloServicio;
                comprobanteResult.ArticuloTemporalServicio = _articuloTemporalServicio;
                comprobanteResult.OrdenFabricacionServicio = _ordenFabricacionServicio;
                comprobanteResult.ConfiguracionCoreServicio = _configuracionCoreServicio;

                return comprobanteResult.AddOrUpdate(comprobante, userLogin);
            }
            else
            {
                return new ResultDTO()
                {
                    State = false,
                    Message = "Ocurrió un error al grabar la Factura",
                };
            }
        }

        public ResultDTO GetComprobantesPendientesCobroVentaMostrador(Guid id, Guid empresaId)
        {
            // Valida que este en el diccionario
            if (!_diccionarioComprobante.TryGetValue(TipoComprobante.Venta, out string? tipoComprobante))
            {
                throw new Exception("No se encontro el Comprobante seleccionado");
            }

            // Valida el tipo de comprobante (clase)
            var _comprobante = Type.GetType(tipoComprobante) ?? throw new Exception("Ocurrio un error al obtener el comprobante");

            var comprobanteResult = Activator.CreateInstance(_comprobante) as Comprobante;

            if (comprobanteResult != null)
            {
                comprobanteResult.ConfiguracionServicio = base._configuracionServicio;
                comprobanteResult.Mapper = base._mapper;
                comprobanteResult.ArticuloServicio = _articuloServicio;
                comprobanteResult.ArticuloTemporalServicio = _articuloTemporalServicio;
                comprobanteResult.OrdenFabricacionServicio = _ordenFabricacionServicio;
                comprobanteResult.ConfiguracionCoreServicio = _configuracionCoreServicio;

                return comprobanteResult.GetComprobantesPendientesCobroVentaMostrador(id, empresaId);
            }
            else
            {
                return new ResultDTO()
                {
                    State = false,
                    Message = "Ocurrió un error al grabar la Factura",
                };
            }
        }

        public ResultDTO GetComprobantesPendientesCobroVentaMostrador(Guid id, Guid empresaId, string cuit)
        {
            // Valida que este en el diccionario
            if (!_diccionarioComprobante.TryGetValue(TipoComprobante.Venta, out string? tipoComprobante))
            {
                throw new Exception("No se encontro el Comprobante seleccionado");
            }

            // Valida el tipo de comprobante (clase)
            var _comprobante = Type.GetType(tipoComprobante) ?? throw new Exception("Ocurrio un error al obtener el comprobante");

            var comprobanteResult = Activator.CreateInstance(_comprobante) as Comprobante;

            if (comprobanteResult != null)
            {
                comprobanteResult.ConfiguracionServicio = base._configuracionServicio;
                comprobanteResult.Mapper = base._mapper;
                comprobanteResult.ArticuloServicio = _articuloServicio;
                comprobanteResult.ArticuloTemporalServicio = _articuloTemporalServicio;
                comprobanteResult.OrdenFabricacionServicio = _ordenFabricacionServicio;
                comprobanteResult.ConfiguracionCoreServicio = _configuracionCoreServicio;

                return comprobanteResult.GetComprobantesPendientesCobroVentaMostrador(id, empresaId, cuit);
            }
            else
            {
                return new ResultDTO()
                {
                    State = false,
                    Message = "Ocurrió un error al grabar la Factura",
                };
            }
        }

        public ResultDTO GetDatosEstadisticos(DateTime fechaInicio, DateTime fechaFin, Guid empresaId)
        {
            // Valida que este en el diccionario
            if (!_diccionarioComprobante.TryGetValue(TipoComprobante.Venta, out string? tipoComprobante))
            {
                throw new Exception("No se encontro el Comprobante seleccionado");
            }

            // Valida el tipo de comprobante (clase)
            var _comprobante = Type.GetType(tipoComprobante) ?? throw new Exception("Ocurrio un error al obtener el comprobante");

            var comprobanteResult = Activator.CreateInstance(_comprobante) as Comprobante;

            if (comprobanteResult != null)
            {
                comprobanteResult.ConfiguracionServicio = base._configuracionServicio;
                comprobanteResult.Mapper = base._mapper;
                comprobanteResult.ArticuloServicio = _articuloServicio;
                comprobanteResult.ArticuloTemporalServicio = _articuloTemporalServicio;
                comprobanteResult.OrdenFabricacionServicio = _ordenFabricacionServicio;
                comprobanteResult.ConfiguracionCoreServicio = _configuracionCoreServicio;

                return comprobanteResult.GetDatosEstadisticos(fechaInicio, fechaFin, empresaId);
            }
            else
            {
                return new ResultDTO()
                {
                    State = false,
                    Message = "Ocurrió un error al grabar la Factura",
                };
            }
        }
    }
}
