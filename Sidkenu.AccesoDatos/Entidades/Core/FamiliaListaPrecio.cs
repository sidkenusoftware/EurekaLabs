using Sidkenu.AccesoDatos.Entidades.Base;
using Sidkenu.AccesoDatos.Entidades.Seguridad;
using Sidkenu.AccesoDatos.Constantes.Enum;

namespace Sidkenu.AccesoDatos.Entidades.Core
{
    public class FamiliaListaPrecio : EntidadBase
    {
        // Propiedades
        public Guid? EmpresaId { get; set; }
        public Guid FamiliaId { get; set; }
        public Guid ListaPrecioId { get; set; }
        public TipoValor TipoValor { get; set; }
        public decimal Valor { get; set; }


        // Propiedades de Navegacion
        public virtual Familia Familia { get; set; }
        public virtual ListaPrecio ListaPrecio { get; set; }
        public virtual Empresa Empresa { get; set; }
    }
}
