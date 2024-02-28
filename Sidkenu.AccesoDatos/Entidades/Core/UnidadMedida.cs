using Sidkenu.AccesoDatos.Entidades.Base;
using Sidkenu.AccesoDatos.Entidades.Seguridad;

namespace Sidkenu.AccesoDatos.Entidades.Core
{
    public class UnidadMedida : EntidadBase
    {
        public Guid? EmpresaId { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public decimal Equivalencia { get; set; }

        // Propiedad de Navegacion
        public virtual List<Articulo> ArticulosVentas { get; set; }
        public virtual List<Articulo> ArticulosCompras { get; set; }

        public virtual Empresa Empresa { get; set; }
    }
}