using Sidkenu.AccesoDatos.Entidades.Base;

namespace Sidkenu.AccesoDatos.Entidades.Core
{
    public class ArticuloOpcional : EntidadBase
    {
        // Propiedades
        public Guid ArticuloPadreId { get; set; }
        public Guid ArticuloHijoId { get; set; }


        // Propiedades de Navegacion
        public virtual Articulo ArticuloPadre { get; set; }
        public virtual Articulo ArticuloHijo { get; set; }
    }
}
