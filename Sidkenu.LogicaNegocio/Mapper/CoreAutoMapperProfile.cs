using AutoMapper;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.Articulo;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.ArticuloProveedor;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.Caja;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.Cliente;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.CondicionIva;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.Deposito;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.Variante;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.Familia;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.Gasto;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.ListaPrecio;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.Marca;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.Mesa;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.MotivoBaja;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.Movimiento;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.Proveedor;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.TipoDocumento;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.TipoGasto;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.UnidadMedida;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.ConfiguracionCore;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.ArticuloKit;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.ArticuloFormula;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.OrdenFabricacion;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.CostoFabricacion;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.ConfiguracionBalanza;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.Tarjeta;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.PlanTarjeta;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.CuentaCorrienteCliente;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.Banco;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Seguridad.PuestoTrabajo;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.Pedido;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.Comprobante;
using Sidkenu.AccesoDatos.Entidades.Core;
using Sidkenu.AccesoDatos.Constantes.Enum;

namespace Sidkenu.Servicio.Mapper
{
    public class CoreAutoMapperProfile : Profile
    {
        public CoreAutoMapperProfile()
        {
            CreateMap<CajaDetalle, CajaDTO>()
                .ForMember(x => x.Id, y => y.MapFrom(z => z.CajaId))
                .ForMember(x => x.CajaDetalleId, y => y.MapFrom(z => z.Id))
                .ForMember(x => x.Descripcion, y => y.MapFrom(z => z.Caja.Descripcion));

            CreateMap<Caja, CajaDTO>()
                .ForMember(x => x.EstaAbierta, y => y.MapFrom(z => z.CajaDetalles != null && z.CajaDetalles.Any(a => a.EstadoCaja == EstadoCaja.Abierta)))

                .ForMember(x => x.FechaApertura, y => y.MapFrom(z => z.CajaDetalles != null && z.CajaDetalles.Any(a => !a.FechaCierre.HasValue)
                              ? z.CajaDetalles.First(a => !a.FechaCierre.HasValue).FechaApertura
                              : (DateTime?)null))

                .ForMember(x => x.MontoApertura, y => y.MapFrom(z => z.CajaDetalles != null && z.CajaDetalles.Any(a => !a.FechaCierre.HasValue)
                              ? z.CajaDetalles.First().MontoApertura
                              : (Decimal?)null))

                .ForMember(x => x.UserApertura, y => y.MapFrom(z => z.CajaDetalles != null && z.CajaDetalles.Any(a => !a.FechaCierre.HasValue)
                              ? $"{z.CajaDetalles.First().PersonaApertura.Apellido} {z.CajaDetalles.First().PersonaApertura.Nombre}"
                              : string.Empty))

                .ForMember(x => x.CajaDetalleId, y => y.MapFrom(z => z.CajaDetalles != null && z.CajaDetalles.Any(a => !a.FechaCierre.HasValue)
                              ? z.CajaDetalles.First().Id
                              : Guid.Empty))

            .ForMember(x => x.TotalIngreso, y => y.MapFrom(z => z.CajaDetalles != null && z.CajaDetalles.Any(a => !a.FechaCierre.HasValue)
                              ? z.CajaDetalles.First().Movimientos.Where(m => m.TipoMovimiento == TipoMovimiento.Ingreso)
                              .Sum(s => s.Capital + s.Interes)
                              : 0))

            .ForMember(x => x.TotalEgreso, y => y.MapFrom(z => z.CajaDetalles != null && z.CajaDetalles.Any(a => !a.FechaCierre.HasValue)
                              ? z.CajaDetalles.First().Movimientos.Where(m => m.TipoMovimiento == TipoMovimiento.Egreso)
                              .Sum(s => s.Capital + s.Interes)
                              : 0));

            CreateMap<CajaPuestoTrabajo, CajaDTO>()
                .ForMember(x => x.Id, y => y.MapFrom(z => z.CajaId))
                .ForMember(x => x.Descripcion, y => y.MapFrom(z => z.Caja.Descripcion))
                .ForMember(x => x.EstaAbierta, y => y.MapFrom(z => z.Caja.CajaDetalles != null && z.Caja.CajaDetalles.Any(a => !a.FechaCierre.HasValue)))

                .ForMember(x => x.FechaApertura, y => y.MapFrom(z => z.Caja.CajaDetalles != null && z.Caja.CajaDetalles.Any(a => !a.FechaCierre.HasValue)
                              ? z.Caja.CajaDetalles.First().FechaApertura
                              : (DateTime?)null))

                .ForMember(x => x.MontoApertura, y => y.MapFrom(z => z.Caja.CajaDetalles != null && z.Caja.CajaDetalles.Any(a => !a.FechaCierre.HasValue)
                              ? z.Caja.CajaDetalles.First().MontoApertura
                              : (Decimal?)null))

                .ForMember(x => x.UserApertura, y => y.MapFrom(z => z.Caja.CajaDetalles != null && z.Caja.CajaDetalles.Any(a => !a.FechaCierre.HasValue)
                              ? $"{z.Caja.CajaDetalles.First().PersonaApertura.Apellido} {z.Caja.CajaDetalles.First().PersonaApertura.Nombre}"
                              : string.Empty))

                .ForMember(x => x.CajaDetalleId, y => y.MapFrom(z => z.Caja.CajaDetalles != null && z.Caja.CajaDetalles.Any(a => !a.FechaCierre.HasValue)
                              ? z.Caja.CajaDetalles.First().Id
                              : Guid.Empty));

            CreateMap<CajaPersistenciaDTO, Caja>();

            CreateMap<CajaDetalle, CajaDetalleDTO>()
                .ForMember(x => x.PersonaApertura, y => y.MapFrom(z => $"{z.PersonaApertura.Apellido} {z.PersonaApertura.Nombre}"))
                .ForMember(x => x.PersonaCierre, y => y.MapFrom(z => $"{z.PersonaCierre.Apellido} {z.PersonaCierre.Nombre}"))
                .ForMember(x => x.Movimientos, y => y.MapFrom(z => z.Movimientos))
                .ReverseMap();

            CreateMap<MovimientoCaja, MovimientoCajaDTO>()
                .ReverseMap();

            //============================================================================================ //

            CreateMap<Pedido, PedidoDTO>().ReverseMap();
            CreateMap<PedidoDetalle, PedidoDetalleDTO>().ReverseMap();
            CreateMap<PedidoPersistenciaDTO, Pedido>();

            //============================================================================================ //

            CreateMap<TipoDocumento, TipoDocumentoDTO>().ReverseMap();

            //============================================================================================ //

            CreateMap<TipoGasto, TipoGastoDTO>().ReverseMap();
            CreateMap<TipoGastoPersistenciaDTO, TipoGasto>();

            //============================================================================================ //

            CreateMap<GastosPersistenciaDTO, Gasto>().ReverseMap();

            //============================================================================================ //

            CreateMap<Cliente, ClienteDTO>()
                .ForMember(x => x.TipoResponsabilidad, y => y.MapFrom(z => z.TipoResponsabilidad.Descripcion))
                .ForMember(x => x.ListaPrecio, y => y.MapFrom(z => z.ListaPrecio.Descripcion))
                .ForMember(x => x.TipoDocumento, y => y.MapFrom(z => z.TipoDocumento.Descripcion))
                .ReverseMap();

            CreateMap<ClientePersistenciaDTO, Cliente>();

            //============================================================================================ //

            CreateMap<Proveedor, ProveedorDTO>()
                .ForMember(x => x.TipoResponsabilidad, y => y.MapFrom(z => z.TipoResponsabilidad.Descripcion))
                .ReverseMap();

            CreateMap<ProveedorPersistenciaDTO, Proveedor>();

            //============================================================================================ //

            CreateMap<ListaPrecio, ListaPrecioDTO>().ReverseMap();
            CreateMap<ListaPrecioPersistenciaDTO, ListaPrecio>();

            //============================================================================================ //

            CreateMap<Familia, FamiliaDTO>().ReverseMap();
            CreateMap<FamiliaPersistenciaDTO, Familia>()
                .ForMember(x => x.AumentoPrecioPublico, y => y.MapFrom(z => z.ActivarAumentoPrecioPublico ? z.AumentoPrecioPublico.Value : 0))
                .ForMember(x => x.AumentoPrecioPublicoListaPrecio, y => y.MapFrom(z => z.ActivarAumentoPrecioPublicoListaPrecio ? z.AumentoPrecioPublicoListaPrecio.Value : 0));

            //============================================================================================ //

            CreateMap<UnidadMedida, UnidadMedidaDTO>().ReverseMap();
            CreateMap<UnidadMedidaPersistenciaDTO, UnidadMedida>();

            //============================================================================================ //

            CreateMap<Deposito, DepositoDTO>().ReverseMap();
            CreateMap<DepositoPersistenciaDTO, Deposito>();

            //============================================================================================ //

            CreateMap<Mesa, MesaDTO>().ReverseMap();
            CreateMap<MesaPersistenciaDTO, Mesa>();

            //============================================================================================ //

            CreateMap<MotivoBaja, MotivoBajaDTO>().ReverseMap();
            CreateMap<MotivoBajaPersistenciaDTO, MotivoBaja>();

            //============================================================================================ //

            CreateMap<Articulo, ArticuloDTO>()
                .ForMember(x => x.Marca, y => y.MapFrom(z => z.Marca.Descripcion))
                .ForMember(x => x.CondicionIva, y => y.MapFrom(z => z.CondicionIva.Descripcion))
                .ForMember(x => x.PorcentajeCondicionIva, y => y.MapFrom(z => z.CondicionIva.Valor))
                .ForMember(x => x.UnidadMedidaCompra, y => y.MapFrom(z => z.UnidadMedidaCompra.Descripcion))
                .ForMember(x => x.UnidadMedidaVenta, y => y.MapFrom(z => z.UnidadMedidaVenta.Descripcion))
                .ForMember(x => x.Familia, y => y.MapFrom(z => z.Familia.Descripcion))
                .ForMember(x => x.FamiliaActivarAumentoPrecioHoraVenta, y => y.MapFrom(z => z.Familia.ActivarAumentoPrecioHoraVenta))
                .ForMember(x => x.FamiliaActivarRestriccionHoraVenta, y => y.MapFrom(z => z.Familia.ActivarRestriccionHoraVenta))
                .ForMember(x => x.FamiliaAumentoPrecioHoraVenta, y => y.MapFrom(z => z.Familia.AumentoPrecioHoraVenta))
                .ForMember(x => x.FamiliaAumentoPrecioHoraVentaDesde, y => y.MapFrom(z => z.Familia.AumentoPrecioHoraVentaDesde))
                .ForMember(x => x.FamiliaAumentoPrecioHoraVentaHasta, y => y.MapFrom(z => z.Familia.AumentoPrecioHoraVentaHasta))
                .ForMember(x => x.FamiliaRestriccionHoraVentaDesde, y => y.MapFrom(z => z.Familia.RestriccionHoraVentaDesde))
                .ForMember(x => x.FamiliaRestriccionHoraVentaHasta, y => y.MapFrom(z => z.Familia.RestriccionHoraVentaHasta))
                .ForMember(x => x.FamiliaTipoValorHoraVenta, y => y.MapFrom(z => z.Familia.TipoValor))
                .ForMember(x => x.FamiliaAumentoPrecioVenta, y => y.MapFrom(z => z.Familia.AumentoPrecioPublico))
                .ForMember(x => x.FamiliaTipoValorVenta, y => y.MapFrom(z => z.Familia.TipoValorPublico))
                .ForMember(x => x.FamiliaActivarAumentoPrecioVenta, y => y.MapFrom(z => z.Familia.ActivarAumentoPrecioPublico))
                .ForMember(x => x.MarcaAumentoPrecioVenta, y => y.MapFrom(z => z.Marca.AumentoPrecioPublico))
                .ForMember(x => x.MarcaTipoValorVenta, y => y.MapFrom(z => z.Marca.TipoValorPublico))
                .ForMember(x => x.MarcaActivarAumentoPrecioVenta, y => y.MapFrom(z => z.Marca.ActivarAumentoPrecioPublico))
                .ForMember(x => x.PermiteMostrarFormula, y => y.MapFrom(z => z.PermiteMostrarFormula))
                .ForMember(x => x.PrecioCosto, y => y.MapFrom(z => z.PrecioCosto))

                .ForMember(x => x.ListaPrecios, y => y.MapFrom(z => z.ArticuloPrecios))
                .ForMember(x => x.Cantidades, y => y.MapFrom(z => z.ArticuloDepositos))
                .ForMember(x => x.ArticuloKits, y => y.MapFrom(z => z.ArticuloPadreKits))
                .ForMember(x => x.ArticuloFormulas, y => y.MapFrom(z => z.ArticuloFormulas))
                .ForMember(x => x.Sugeridos, y => y.MapFrom(z => z.ArticuloHijoOpcionales));

            CreateMap<ArticuloPrecio, ArticuloPrecioDTO>()
                .ForMember(x => x.Id, y => y.MapFrom(z => z.Id))
                .ForMember(x => x.ListaPrecioId, y => y.MapFrom(z => z.ListaPrecioId))
                .ForMember(x => x.ListaPrecio, y => y.MapFrom(z => z.ListaPrecio.Descripcion))
                .ForMember(x => x.FechaActualizacion, y => y.MapFrom(z => z.FechaActualizacion))
                .ForMember(x => x.Monto, y => y.MapFrom(z => z.Monto));

            CreateMap<ArticuloDeposito, ArticuloDepositoDTO>()
                .ForMember(x => x.Id, y => y.MapFrom(z => z.Id))
                .ForMember(x => x.DepositoId, y => y.MapFrom(z => z.DepositoId))
                .ForMember(x => x.Deposito, y => y.MapFrom(z => z.Deposito.Descripcion))
                .ForMember(x => x.Cantidad, y => y.MapFrom(z => z.Cantidad))
                .ForMember(x => x.EmpresaId, y => y.MapFrom(z => z.Deposito.EmpresaId))
                .ForMember(x => x.Empresa, y => y.MapFrom(z => z.Deposito.Empresa.Descripcion));

            CreateMap<ArticuloKit, ArticuloKitDTO>()
               .ForMember(x => x.Id, y => y.MapFrom(z => z.Id))
               .ForMember(x => x.ArticuloHijoId, y => y.MapFrom(z => z.ArticuloHijoId))
               .ForMember(x => x.Cantidad, y => y.MapFrom(z => z.Cantidad))
               .ForMember(x => x.Codigo, y => y.MapFrom(z => z.ArticuloHijo.Codigo))
               .ForMember(x => x.Descripcion, y => y.MapFrom(z => z.ArticuloHijo.Descripcion));

            CreateMap<ArticuloFormula, ArticuloFormulaDTO>()
               .ForMember(x => x.Id, y => y.MapFrom(z => z.Id))
               .ForMember(x => x.ArticuloHijoId, y => y.MapFrom(z => z.ArticuloSecundarioId))
               .ForMember(x => x.Cantidad, y => y.MapFrom(z => z.Cantidad))
               .ForMember(x => x.Codigo, y => y.MapFrom(z => z.ArticuloSecundario.Codigo))
               .ForMember(x => x.Descripcion, y => y.MapFrom(z => z.ArticuloSecundario.Descripcion));


            CreateMap<ArticuloPersistenciaDTO, Articulo>()
                .IgnoreAllPropertiesWithAnInaccessibleSetter();

            CreateMap<ArticuloProveedor, ArticuloProveedorDTO>()
                .ForMember(x => x.Id, y => y.MapFrom(z => z.Id))
                .ForMember(x => x.ProveedorId, y => y.MapFrom(z => z.ProveedorId))
                .ForMember(x => x.CodigoProveedor, y => y.MapFrom(z => z.CodigoProveedor))
                .ForMember(x => x.Proveedor, y => y.MapFrom(z => z.Proveedor.RazonSocial))
                .ForMember(x => x.Cuit, y => y.MapFrom(z => z.Proveedor.CUIT))
                .ForMember(x => x.EstaBD, y => y.MapFrom(z => true))
                .ForMember(x => x.Eliminar, y => y.MapFrom(z => false))
                .ReverseMap();

            //============================================================================================ //

            CreateMap<VarianteValor, ValorVarianteDTO>()
                .ReverseMap();

            CreateMap<ValorVariantePersistenciaDTO, VarianteValor>();

            CreateMap<Variante, VarianteDTO>()
                .ForMember(x=>x.Valores, y=>y.MapFrom(z=>z.VarianteValores.ToList()))
                .ReverseMap();

            CreateMap<VariantePersistenciaDTO, Variante>();

            //============================================================================================ //

            CreateMap<Marca, MarcaDTO>()
                .ForMember(x => x.AumentoPrecioPublico, y => y.MapFrom(z => z.ActivarAumentoPrecioPublico ? z.AumentoPrecioPublico.Value : 0))
                .ForMember(x => x.AumentoPrecioPublicoListaPrecio, y => y.MapFrom(z => z.ActivarAumentoPrecioPublicoListaPrecio ? z.AumentoPrecioPublicoListaPrecio.Value : 0));

            CreateMap<MarcaPersistenciaDTO, Marca>();

            //============================================================================================ //

            CreateMap<CondicionIva, CondicionIvaDTO>().ReverseMap();
            CreateMap<CondicionIvaPersistenciaDTO, CondicionIva>();

            //============================================================================================ //

            CreateMap<ConfiguracionCore, ConfiguracionCoreDTO>().ReverseMap();
            CreateMap<ConfiguracionCorePersistenciaDTO, ConfiguracionCore>();

            //============================================================================================ //

            CreateMap<ConfiguracionBalanza, ConfiguracionBalanzaDTO>().ReverseMap();
            CreateMap<ConfiguracionBalanzaPersistenciaDTO, ConfiguracionBalanza>();

            //============================================================================================ //

            CreateMap<OrdenFabricacion, OrdenFabricacionDTO>()
                .ForMember(x => x.Id, y => y.MapFrom(z => z.Id))
                .ForMember(x => x.DepositoDestinoId, y => y.MapFrom(z => z.DepositoDestinoId))
                .ForMember(x => x.DepositoDestino, y => y.MapFrom(z => z.DepositoDestino.Descripcion))
                .ForMember(x => x.DepositoOrigenId, y => y.MapFrom(z => z.DepositoOrigenId))
                .ForMember(x => x.DepositoOrigen, y => y.MapFrom(z => z.DepositoOrigen.Descripcion))
                .ForMember(x => x.ArticuloBaseId, y => y.MapFrom(z => z.ArticuloBaseId))
                .ForMember(x => x.ArticuloDescripcion, y => y.MapFrom(z => z.ArticuloBase.Descripcion))
                .ForMember(x => x.ArticuloCodigo, y => y.MapFrom(z => z.ArticuloBase.Codigo))
                .ForMember(x => x.Fecha, y => y.MapFrom(z => z.Fecha))
                .ForMember(x => x.Numero, y => y.MapFrom(z => z.Numero))
                .ForMember(x => x.ActulizarPrecioPublico, y => y.MapFrom(z => z.ActulizarPrecioPublico))
                .ForMember(x => x.EstadoOrdenFabricacion, y => y.MapFrom(z => z.EstadoOrdenFabricacion))
                .ForMember(x => x.CantidadFabricar, y => y.MapFrom(z => z.CantidadFabricar))
                .ForMember(x => x.Detalles, y => y.MapFrom(z => z.OrdenFabricacionDetalles));

            CreateMap<OrdenFabricacionDetalle, OrdenFabricacionDetalleDTO>()
                .ForMember(x => x.Id, y => y.MapFrom(z => z.Id))
                .ForMember(x => x.ArticuloId, y => y.MapFrom(z => z.ArticuloId))
                .ForMember(x => x.Codigo, y => y.MapFrom(z => z.Codigo))
                .ForMember(x => x.Cantidad, y => y.MapFrom(z => z.Cantidad))
                .ForMember(x => x.Descripcion, y => y.MapFrom(z => z.Descripcion))
                .ForMember(x => x.EsFormula, y => y.MapFrom(z => z.Articulo.TipoArticulo == TipoArticulo.Formula))
                .ForMember(x => x.HayStock, y => y.MapFrom(z => false));

            CreateMap<OrdenFabricacionPersistenciaDTO, OrdenFabricacion>()
                .ForMember(x => x.ArticuloBaseId, y => y.MapFrom(z => z.ArticuloId))
                .ForMember(x => x.CantidadFabricar, y => y.MapFrom(z => z.Cantidad));

            //============================================================================================ //

            CreateMap<CostoFabricacion, CostoFabricacionDTO>().ReverseMap();
            CreateMap<CostoFabricacionPersistenciaDTO, CostoFabricacion>();

            //============================================================================================ //

            CreateMap<Tarjeta, TarjetaDTO>().ReverseMap();
            CreateMap<TarjetaPersistenciaDTO, Tarjeta>();

            //============================================================================================ //

            CreateMap<PlanTarjeta, PlanTarjetaDTO>()
                .ForMember(x => x.Tarjeta, y => y.MapFrom(z => z.Tarjeta.Descripcion))
                .ReverseMap();
            CreateMap<PlanTarjetaPersistenciaDTO, PlanTarjeta>();

            //============================================================================================ //

            CreateMap<CuentaCorrienteCliente, CtaCteClienteDTO>().ReverseMap();
            CreateMap<CtaCteClientePersistenciaDTO, CuentaCorrienteCliente>();

            //============================================================================================ //

            CreateMap<Banco, BancoDTO>().ReverseMap();
            CreateMap<BancoPersistenciaDTO, Banco>();

            //============================================================================================ //

            CreateMap<ArticuloTemporal, ArticuloTemporalDTO>().ReverseMap();
            CreateMap<ArticuloTemporalPersistenciaDTO, ArticuloTemporal>();

            //============================================================================================ //

            CreateMap<CajaPuestoTrabajo, PuestoTrabajoDTO>()
                .ForMember(x => x.Id, y => y.MapFrom(z => z.PuestoTrabajoId))
                .ForMember(x => x.Descripcion, y => y.MapFrom(z => z.PuestoTrabajo.Descripcion))
                .ForMember(x => x.ExisteBase, y => y.MapFrom(z => true));

            //============================================================================================ //

            CreateMap<ComprobanteVenta, ComprobanteVentaDTO>()
                .ReverseMap();

            CreateMap<ComprobanteDetalle, ComprobanteDetalleDTO>()
                .ReverseMap();
        }
    }
}
