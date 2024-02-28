using Sidkenu.LogicaNegocio.Servicios.Implementacion.Core;
using Sidkenu.LogicaNegocio.Servicios.Interface.Core;
using StructureMap;
using Sidkenu.LogicaNegocio.Servicios.Implementacion.Core.Comprobante;

namespace Sidkenu.LogicaNegocio.IoC
{
    public class StructureMapRegistryCore : Registry
    {
        public StructureMapRegistryCore()
        {
            // Servicios Core
            For<ICajaServicio>().Use<CajaServicio>();
            For<ITipoGastoServicio>().Use<TipoGastoServicio>();
            For<IGastosServicio>().Use<GastoServicio>();
            For<IClienteServicio>().Use<ClienteServicio>();
            For<IProveedorServicio>().Use<ProveedorServicio>();
            For<IListaPrecioServicio>().Use<ListaPrecioServicio>();
            For<ITipoDocumentoServicio>().Use<TipoDocumentoServicio>();
            For<IFamiliaServicio>().Use<FamiliaServicio>();
            For<IMarcaServicio>().Use<MarcaServicio>();
            For<IUnidadMedidaServicio>().Use<UnidadMedidaServicio>();
            For<IMesaServicio>().Use<MesaServicio>();
            For<IMotivoBajaServicio>().Use<MotivoBajaServicio>();
            For<IArticuloServicio>().Use<ArticuloServicio>();
            For<IArticuloProveedorServicio>().Use<ArticuloProveedorServicio>();
            For<ICondicionIvaServicio>().Use<CondicionIvaServicio>();
            For<IVarianteServicio>().Use<VarianteServicio>();
            For<IVarianteValorServicio>().Use<VarianteValorServicio>();
            For<IArticuloVarianteServicio>().Use<ArticuloVarianteServicio>();
            For<IArticuloKitServicio>().Use<ArticuloKitServicio>();
            For<IArticuloFormulaServicio>().Use<ArticuloFormulaServicio>();
            For<IDepositoServicio>().Use<DepositoServicio>();
            For<IConfiguracionCoreServicio>().Use<ConfiguracionCoreServicio>();
            For<IConfiguracionBalanzaServicio>().Use<ConfiguracionBalanzaServicio>();
            For<IOrdenFabricacionServicio>().Use<OrdenFabricacionServicio>();
            For<IContadorServicio>().Use<ContadorServicio>();
            For<ICostoFabricacionServicio>().Use<CostoFabricacionServicio>();
            For<IArticuloPrecioServicio>().Use<ArticuloPrecioServicio>();
            For<ITarjetaServicio>().Use<TarjetaServicio>();
            For<IPlanTarjetaServicio>().Use<PlanTarjetaServicio>();
            For<ICuentaCorrienteClienteServicio>().Use<CuentaCorrienteClienteServicio>();
            For<IBancoServicio>().Use<BancoServicio>();
            For<IComprobanteServicio>().Use<ComprobanteServicio>();
            For<IArticuloTemporalServicio>().Use<ArticuloTemporalServicio>();
            For<ICajaPuestoTrabajoServicio>().Use<CajaPuestoTrabajoServicio>();
            For<IMovimientoCajaServicio>().Use<MovimientoCajaServicio>();
            For<IPedidoServicio>().Use<PedidoServicio>();
        }
    }
}



