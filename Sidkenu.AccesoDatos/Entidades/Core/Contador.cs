using Sidkenu.AccesoDatos.Entidades.Base;
using Sidkenu.AccesoDatos.Entidades.Seguridad;
using Sidkenu.AccesoDatos.Constantes.Enum;

namespace Sidkenu.AccesoDatos.Entidades.Core
{
    public class Contador : EntidadBase
    {
        public Guid EmpresaId { get; set; }
        public TipoContador TipoContador { get; set; }
        public long Numero { get; set; }

        // Propiedades de Navegacion
        public virtual Empresa Empresa { get; set; }
    }
}
