using Sidkenu.AccesoDatos.Constantes.Enum;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.ArticuloProveedor;

namespace Sidkenu.LogicaNegocio.Servicios.DTOs.Core.Articulo
{
    public class ArticuloPersistenciaDTO : ArticuloBaseDTO
    {
        public ArticuloPersistenciaDTO()
        {
            ArticuloProveedores ??= new List<ArticuloProveedorDTO>();
        }

        // Propiedades

        public string Abreviatura { get; set; }
        public string DescripcionAdicional { get; set; }
        public string CodigoBarra { get; set; }
        public string? Detalle { get; set; }

        public PerfilArticulo PerfilArticulo { get; set; }

        public TipoArticulo TipoArticulo { get; set; }

        public decimal PrecioCosto { get; set; }

        public Guid ArticuloId { get; set; }
        public bool SeleccionoEmpresa { get; set; }
        public Guid FamiliaId { get; set; }
        public Guid? UnidadMedidaVentaId { get; set; }
        public Guid? UnidadMedidaCompraId { get; set; }
        public Guid CondicionIvaId { get; set; }
        public Guid MarcaId { get; set; }
        
        public bool PermiteStockNegativo { get; set; }

        public bool TienePerdida { get; set; }
        public decimal? PorcentajePerdida { get; set; }

        public bool ActivarLimiteVenta { get; set; }
        public decimal? LimiteVenta { get; set; }

        public bool EstaBloqueado { get; set; }

        public decimal? Comision { get; set; }

        public bool ActivarBonificacion { get; set; }
        public decimal? Bonificacion { get; set; }
        public DateTime? BonificacionFechaDesde { get; set; }
        public DateTime? BonificacionFechaHasta { get; set; }
        public TipoValor? TipoBonificacion { get; set; }

        public bool TieneGarantia { get; set; }
        public int? Garantia { get; set; }

        public decimal StockMaximo { get; set; }
        public decimal StockMinimo { get; set; }
        public decimal PuntoPedido { get; set; }

        public Guid? DepositoId { get; set; }
        public decimal? StockInicial { get; set; }
        public Guid ListaPrecioId { get; set; }
        public decimal? PrecioCostoInicial { get; set; }

        public bool TieneRentabilidad { get; set; }
        public decimal? Rentabilidad { get; set; }

        public bool FacturacionPorImporte { get; set; }

        public bool NecesitaAutorizacion { get; set; }

        public List<ArticuloProveedorDTO> ArticuloProveedores { get; set; }

        public bool PermiteMostrarFormula { get; set; }
    }
}
