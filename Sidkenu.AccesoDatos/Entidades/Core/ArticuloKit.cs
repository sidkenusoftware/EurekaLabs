using Sidkenu.AccesoDatos.Entidades.Base;

namespace Sidkenu.AccesoDatos.Entidades.Core
{
    public class ArticuloKit : EntidadBase
    {
        // Propiedades
        public Guid ArticuloPadreId { get; set; }
        public Guid ArticuloHijoId { get; set; }
        public decimal Cantidad { get; set; }

        // Propiedades de Navegacion
        public virtual Articulo ArticuloPadre { get; set; }
        public virtual Articulo ArticuloHijo { get; set; }
    }
}
