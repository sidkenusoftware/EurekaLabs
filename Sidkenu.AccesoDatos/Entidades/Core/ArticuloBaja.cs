using Sidkenu.AccesoDatos.Entidades.Base;

namespace Sidkenu.AccesoDatos.Entidades.Core
{
    public class ArticuloBaja : EntidadBase
    {
        // Propiedad
        public Guid ArticuloId { get; set; }
        public Guid MotivoBajaId { get; set; }

        public DateTime Fecha { get; set; }
        public decimal Cantidad { get; set; }
        public string Observacion { get; set; }


        // Propiedad de Navegación
        public virtual Articulo Articulo { get; set; }
        public virtual MotivoBaja MotivoBaja { get; set; }
    }
}
