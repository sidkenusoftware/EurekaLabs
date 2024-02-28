using Sidkenu.AccesoDatos.Constantes.Enum;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Base;

namespace Sidkenu.LogicaNegocio.Servicios.DTOs.Core.Marca
{
    public class MarcaDTO : EntidadBaseDTO
    {
        public Guid? EmpresaId { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }

        // ================================================================= //

        public bool ActivarAumentoPrecioPublico { get; set; }
        public decimal? AumentoPrecioPublico { get; set; }
        public TipoValor? TipoValorPublico { get; set; }

        // ================================================================= //

        public bool ActivarAumentoPrecioPublicoListaPrecio { get; set; }
        public decimal? AumentoPrecioPublicoListaPrecio { get; set; }
        public TipoValor? TipoValorPublicoListaPrecio { get; set; }
    }
}
