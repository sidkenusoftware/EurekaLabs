using Sidkenu.AccesoDatos.Entidades.Base;
using Sidkenu.AccesoDatos.Entidades.Seguridad;

namespace Sidkenu.AccesoDatos.Entidades.Core
{
    public class ArticuloBase : EntidadBase
    {
        // Propiedades
        public Guid? EmpresaId { get; set; }

        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public byte[] Foto { get; set; }

        // Propiedades de Navegacion
        public virtual Empresa Empresa { get; set; }
        public virtual List<OrdenFabricacion> OrdenFabricaciones { get; set; }
    }
}
