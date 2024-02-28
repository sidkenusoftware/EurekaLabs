using Sidkenu.AccesoDatos.Entidades.Base;

namespace Sidkenu.AccesoDatos.Entidades.Core
{
    public class OrdenFabricacionDetalle : EntidadBase
    {
        // Propiedades
        public Guid OrdenFabricacionId { get; set; }
        public Guid ArticuloId { get; set; }

        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public decimal Cantidad { get; set; }


        // Propiedades de Navegacion
        public virtual OrdenFabricacion OrdenFabricacion { get; set; }
        public virtual Articulo Articulo { get; set; }
    }
}
