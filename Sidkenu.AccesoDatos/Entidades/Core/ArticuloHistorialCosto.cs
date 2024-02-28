using Sidkenu.AccesoDatos.Entidades.Base;

namespace Sidkenu.AccesoDatos.Entidades.Core
{
    public class ArticuloHistorialCosto : EntidadBase
    {
        // Propiedades 
        public Guid ArticuloId { get; set; }
        public decimal PrecioCostoAnterior { get; set; }
        public decimal PrecioCostoNuevo { get; set; }
        public DateTime FechaActualizacion { get; set; }

        // Propiedades de Navegacion
        public virtual Articulo Articulo { get; set; }
    }
}
