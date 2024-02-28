using Sidkenu.AccesoDatos.Constantes.Enum;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Base;

namespace Sidkenu.LogicaNegocio.Servicios.DTOs.Core.Familia
{
    public class FamiliaDTO : EntidadBaseDTO
    {
        public Guid? EmpresaId { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }

        public bool ActivarRestriccionHoraVenta { get; set; }
        public string? RestriccionHoraVentaDesde { get; set; }
        public string? RestriccionHoraVentaHasta { get; set; }

        public bool ActivarAumentoPrecioHoraVenta { get; set; }
        public decimal? AumentoPrecioHoraVenta { get; set; }
        public string? AumentoPrecioHoraVentaDesde { get; set; }
        public string? AumentoPrecioHoraVentaHasta { get; set; }
        public string? TipoValor { get; set; }

        public bool ActivarAumentoPrecioPublico { get; set; }
        public decimal? AumentoPrecioPublico { get; set; }
        public TipoValor? TipoValorPublico { get; set; }

        public bool ActivarAumentoPrecioPublicoListaPrecio { get; set; }
        public decimal? AumentoPrecioPublicoListaPrecio { get; set; }
        public TipoValor? TipoValorPublicoListaPrecio { get; set; }
    }
}
