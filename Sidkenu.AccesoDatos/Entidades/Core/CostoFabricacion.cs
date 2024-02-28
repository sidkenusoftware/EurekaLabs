using Sidkenu.AccesoDatos.Entidades.Base;
using Sidkenu.AccesoDatos.Entidades.Seguridad;

namespace Sidkenu.AccesoDatos.Entidades.Core
{
    public class CostoFabricacion : EntidadBase
    {
        public Guid EmpresaId { get; set; }                
        public string Descripcion { get; set; }
        public decimal Monto { get; set; }


        // Propiedades de Navegacion
        public virtual Empresa Empresa { get; set; }
    }
}
