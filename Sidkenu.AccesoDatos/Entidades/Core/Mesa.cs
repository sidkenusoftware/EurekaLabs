using Sidkenu.AccesoDatos.Entidades.Base;
using Sidkenu.AccesoDatos.Constantes.Enum;

namespace Sidkenu.AccesoDatos.Entidades.Core
{
    public class Mesa : EntidadBase
    {
        // Propiedades
        public Guid SalonId { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public EstadoMesa EstadoMesa { get; set; }

        // Propiedades de Navegacion
        public virtual Salon Salon { get; set; }
        public virtual List<ComprobanteSalon> ComprobantesSalones { get; set; }
    }
}
