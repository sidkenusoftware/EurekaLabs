using Sidkenu.AccesoDatos.Entidades.Base;
using Sidkenu.AccesoDatos.Entidades.Seguridad;
using Sidkenu.AccesoDatos.Constantes.Enum;

namespace Sidkenu.AccesoDatos.Entidades.Core
{
    public class Familia : EntidadBase
    {
        // Propiedades
        public Guid? EmpresaId { get; set; }
        public string Codigo { get; set; }

        public string Descripcion { get; set; }

        // =========================================================== //

        public bool ActivarRestriccionHoraVenta { get; set; }
        public string? RestriccionHoraVentaDesde { get; set; }
        public string? RestriccionHoraVentaHasta { get; set; }

        // =========================================================== //

        public bool ActivarAumentoPrecioHoraVenta { get; set; }
        public decimal? AumentoPrecioHoraVenta { get; set; }
        public string? AumentoPrecioHoraVentaDesde { get; set; }
        public string? AumentoPrecioHoraVentaHasta { get; set; }
        public TipoValor? TipoValor { get; set; }

        // =========================================================== //

        public bool ActivarAumentoPrecioPublico { get; set; }
        public decimal? AumentoPrecioPublico { get; set; }
        public TipoValor? TipoValorPublico { get; set; }

        // ================================================================= //
        public bool ActivarAumentoPrecioPublicoListaPrecio { get; set; }
        public decimal? AumentoPrecioPublicoListaPrecio { get; set; }
        public TipoValor? TipoValorPublicoListaPrecio { get; set; }

        // ================================================================= //

        // Propiedades de Navegacion
        public virtual Empresa Empresa { get; set; }
        public virtual List<Articulo> Articulos { get; set; }
        public virtual List<FamiliaCaja> FamiliaCajas { get; set; }
        public virtual List<FamiliaListaPrecio> FamiliaListaPrecios { get; set; }
    }
}
