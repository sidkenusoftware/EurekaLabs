using Sidkenu.AccesoDatos.Constantes.Enum;

namespace Sidkenu.AccesoDatos.Entidades.Core
{
    public class Articulo : ArticuloBase
    {
        // Propiedades
        public string Abreviatura { get; set; }
        public string DescripcionAdicional { get; set; }
        public string CodigoBarra { get; set; }
        public string? Detalle { get; set; }

        public PerfilArticulo PerfilArticulo { get; set; }

        public TipoArticulo TipoArticulo { get; set; }

        public decimal PrecioCosto { get; set; }

        public Guid? ArticuloPadreId { get; set; }
        public Guid FamiliaId { get; set; }
        public Guid UnidadMedidaVentaId { get; set; }
        public Guid UnidadMedidaCompraId { get; set; }
        public Guid CondicionIvaId { get; set; }
        public Guid MarcaId { get; set; }
        public Guid VarianteValorUnoId { get; set; }
        public Guid VarianteValorDosId { get; set; }

        public bool PermiteStockNegativo { get; set; }

        public bool TienePerdida { get; set; }
        public decimal? PorcentajePerdida { get; set; }

        public bool ActivarLimiteVenta { get; set; }
        public decimal? LimiteVenta { get; set; }

        public bool EstaBloqueado { get; set; }

        public decimal? Comision { get; set; }

        public bool ActivarBonificacion { get; set; }
        public decimal? Bonificacion { get; set; }
        public TipoValor? TipoBonificacion { get; set; }
        public DateTime? BonificacionFechaDesde { get; set; }
        public DateTime? BonificacionFechaHasta { get; set; }

        public bool TieneGarantia { get; set; }
        public int? Garantia { get; set; }

        public decimal StockMaximo { get; set; }
        public decimal StockMinimo { get; set; }
        public decimal PuntoPedido { get; set; }

        public bool TieneRentabilidad { get; set; }
        public decimal? Rentabilidad { get; set; }
        public DateTime? FechaVigenciaKit { get; set; }
        public bool FacturacionPorImporte { get; set; }
        public bool NecesitaAutorizacion { get; set; }

        public bool PermiteMostrarFormula { get; set; }

        // Propiedades de Navegacion
        public virtual Articulo ArticuloPadre { get; set; }
        public virtual Familia Familia { get; set; }
        public virtual CondicionIva CondicionIva { get; set; }
        public virtual UnidadMedida UnidadMedidaVenta { get; set; }
        public virtual UnidadMedida UnidadMedidaCompra { get; set; }
        public virtual Marca Marca { get; set; }
        public virtual VarianteValor VarianteValorUno { get; set; }
        public virtual VarianteValor VarianteValorDos { get; set; }

        // -------------------------------------------------------------------------------- //

        public virtual List<ArticuloBaja> ArticuloBajas { get; set; }
        public virtual List<ArticuloFormula> ArticuloFormulas { get; set; }
        public virtual List<ArticuloFormula> ArticuloSecundarioFormulas { get; set; }
        public virtual List<ArticuloDeposito> ArticuloDepositos { get; set; }
        public virtual List<ArticuloOpcional> ArticuloPadreOpcionales { get; set; }
        public virtual List<ArticuloOpcional> ArticuloHijoOpcionales { get; set; }
        public virtual List<ArticuloProveedor> ArticuloProveedores { get; set; }
        public virtual List<ArticuloPrecio> ArticuloPrecios { get; set; }
        public virtual List<ArticuloHistorialCosto> ArticuloHistorialCostos { get; set; }
        public virtual List<ArticuloKit> ArticuloPadreKits { get; set; }
        public virtual List<ArticuloKit> ArticuloHijoKits { get; set; }
        public virtual List<OrdenFabricacionDetalle> OrdenFabricacionDetalles { get; set; }        
        public virtual List<ComprobanteDetalle> Detalles { get; set; }
    }
}
