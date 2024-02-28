using Sidkenu.AccesoDatos.Entidades.Base;
using Sidkenu.AccesoDatos.Entidades.Seguridad;

namespace Sidkenu.AccesoDatos.Entidades.Core
{
    public class CajaPuestoTrabajo : EntidadBase
    {
        // Propiedades
        public Guid CajaId { get; set; }

        public Guid PuestoTrabajoId { get; set; }


        // Propiedades de Navegacion
        public virtual Caja Caja { get; set; }

        public virtual PuestoTrabajo PuestoTrabajo { get; set; }
    }
}
