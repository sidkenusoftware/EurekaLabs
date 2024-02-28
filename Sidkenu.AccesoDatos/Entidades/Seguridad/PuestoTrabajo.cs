using Sidkenu.AccesoDatos.Entidades.Base;
using Sidkenu.AccesoDatos.Entidades.Core;

namespace Sidkenu.AccesoDatos.Entidades.Seguridad
{
    public class PuestoTrabajo : EntidadBase
    {
        // Propiedades
        public Guid EmpresaId { get; set; }

        public string Descripcion { get; set; }

        public string SerialNumber { get; set; }


        // Propiedades de Navegacion
        public virtual Empresa Empresa { get; set; }

        public virtual List<CajaPuestoTrabajo> Cajas { get; set; }
    }
}
