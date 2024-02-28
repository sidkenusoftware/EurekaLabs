using Sidkenu.AccesoDatos.Entidades.Base;
using Sidkenu.AccesoDatos.Entidades.Core;

namespace Sidkenu.AccesoDatos.Entidades.Seguridad
{
    public class TipoResponsabilidad : EntidadBase
    {
        // Propiedades
        public int Codigo { get; set; }
        public string Descripcion { get; set; }

        // Propiedades de Navegacion
        public virtual List<Empresa> Empresas { get; set; }
        public virtual List<Proveedor> Proveedores { get; set; }
        public virtual List<Cliente> Clientes { get; set; }
    }
}