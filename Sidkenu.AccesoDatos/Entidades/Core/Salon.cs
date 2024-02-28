using Sidkenu.AccesoDatos.Entidades.Base;
using Sidkenu.AccesoDatos.Entidades.Seguridad;

namespace Sidkenu.AccesoDatos.Entidades.Core
{
    public class Salon : EntidadBase
    {
        // Propiedades
        public Guid EmpresaId { get; set; }
        public Guid? ListaPrecioId { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }


        // Propiedades de Navegacion
        public virtual ListaPrecio ListaPrecio { get; set; }
        public virtual Empresa Empresa { get; set; }
        public virtual List<Mesa> Mesas { get; set; }
    }
}