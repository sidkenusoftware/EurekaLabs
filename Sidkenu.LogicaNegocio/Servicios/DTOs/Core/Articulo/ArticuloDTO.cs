using Sidkenu.AccesoDatos.Constantes.Enum;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.ArticuloFormula;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.ArticuloKit;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.ArticuloProveedor;

namespace Sidkenu.LogicaNegocio.Servicios.DTOs.Core.Articulo
{
    public class ArticuloDTO : ArticuloBaseDTO
    {
        public ArticuloDTO()
        {
            ListaPrecios ??= new List<ArticuloPrecioDTO>();
            Cantidades ??= new List<ArticuloDepositoDTO>();
            ArticuloKits ??= new List<ArticuloKitDTO>();
            ArticuloFormulas ??= new List<ArticuloFormulaDTO>();
            ArticuloProveedores ??= new List<ArticuloProveedorDTO>();
            Sugeridos ??= new List<ArticuloDTO>();
        }

        // Propiedades
        public Guid ArticuloId { get; set; }

        public string Abreviatura { get; set; }
        public string DescripcionAdicional { get; set; }
        public string CodigoBarra { get; set; }
        public string? Detalle { get; set; }
        public PerfilArticulo PerfilArticulo { get; set; }
        public TipoArticulo TipoArticulo { get; set; }
        public decimal PrecioCosto { get; set; }

        // Familia
        public Guid FamiliaId { get; set; }
        public string Familia { get; set; }
        public bool FamiliaActivarRestriccionHoraVenta { get; set; }
        public DateTime? FamiliaRestriccionHoraVentaDesde { get; set; }
        public DateTime? FamiliaRestriccionHoraVentaHasta { get; set; }


        public bool FamiliaActivarAumentoPrecioHoraVenta { get; set; }
        public decimal? FamiliaAumentoPrecioHoraVenta { get; set; }
        public DateTime? FamiliaAumentoPrecioHoraVentaDesde { get; set; }
        public DateTime? FamiliaAumentoPrecioHoraVentaHasta { get; set; }
        public TipoValor? FamiliaTipoValorHoraVenta { get; set; }

        public bool FamiliaActivarAumentoPrecioVenta { get; set; }
        public decimal? FamiliaAumentoPrecioVenta { get; set; }
        public TipoValor? FamiliaTipoValorVenta { get; set; }

        public bool MarcaActivarAumentoPrecioVenta { get; set; }
        public decimal? MarcaAumentoPrecioVenta { get; set; }
        public TipoValor? MarcaTipoValorVenta { get; set; }

        public Guid UnidadMedidaVentaId { get; set; }
        public Guid UnidadMedidaCompraId { get; set; }

        // Condicion de Iva
        public Guid CondicionIvaId { get; set; }
        public decimal PorcentajeCondicionIva { get; set; }

        public Guid MarcaId { get; set; }
        
        public string UnidadMedidaVenta { get; set; }
        public string UnidadMedidaCompra { get; set; }
        public string CondicionIva { get; set; }
        public string Marca { get; set; }

        public string VarianteValorUno { get; set; }
        public string VarianteValorDos { get; set; }
        public string DescripcionCompleta => $"{Descripcion} {VarianteValorUno} {VarianteValorDos}";

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

        public bool TieneRentabilidad { get; set; }
        public decimal? Rentabilidad { get; set; }

        // Variantes
        public Guid? VarianteValor1Id { get; set; }

        public Guid? VarianteValor2Id { get; set; }
        
        public bool TieneProveedor => ArticuloProveedores.Any();
        
        public decimal Stock { get; set; }
        public DateTime? FechaVigenciaKit { get; set; }
        public bool FacturacionPorImporte { get; set; }
        public bool NecesitaAutorizacion { get; set; }
        public bool PermiteMostrarFormula { get; set; }


        // Listas
        public List<ArticuloPrecioDTO> ListaPrecios { get; set; }
        public List<ArticuloDepositoDTO> Cantidades { get; set; }
        public List<ArticuloKitDTO> ArticuloKits { get; set; }
        public List<ArticuloFormulaDTO> ArticuloFormulas { get; set; }
        public List<ArticuloProveedorDTO> ArticuloProveedores { get; set; }
        public List<ArticuloDTO> Sugeridos { get; set; }
    }
}


