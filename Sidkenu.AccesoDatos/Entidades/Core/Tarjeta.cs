using Sidkenu.AccesoDatos.Entidades.Base;
using Sidkenu.AccesoDatos.Entidades.Seguridad;

namespace Sidkenu.AccesoDatos.Entidades.Core
{
    public class Tarjeta : EntidadBase
    {
        // Propiedades
        public Guid? EmpresaId { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }


        // Propiedades de Navegacion
        public Empresa Empresa { get; set; }
        public virtual List<PlanTarjeta> PlanesTarjetas { get; set; }
    }
}