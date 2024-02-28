using Sidkenu.AccesoDatos.Entidades.Base;
using Sidkenu.AccesoDatos.Entidades.Seguridad;

namespace Sidkenu.AccesoDatos.Entidades.Core
{
    public class MotivoBaja : EntidadBase
    {
        // Propiedad
        public Guid? EmpresaId { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }


        // Propiedad de Navegacion
        public virtual List<ArticuloBaja> ArticuloBajas { get; set; }
        public virtual Empresa Empresa { get; set; }
    }
}