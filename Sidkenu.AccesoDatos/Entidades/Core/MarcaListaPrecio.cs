using Sidkenu.AccesoDatos.Entidades.Base;
using Sidkenu.AccesoDatos.Entidades.Seguridad;
using Sidkenu.AccesoDatos.Constantes.Enum;

namespace Sidkenu.AccesoDatos.Entidades.Core
{
    public class MarcaListaPrecio : EntidadBase
    {
        // Propiedades
        public Guid? EmpresaId { get; set; }
        public Guid MarcaId { get; set; }
        public Guid ListaPrecioId { get; set; }
        public TipoValor TipoValor { get; set; }
        public decimal Valor { get; set; }

        // Propiedades de Navegacion
        public virtual Marca Marca { get; set; }
        public virtual ListaPrecio ListaPrecio { get; set; }
        public virtual Empresa Empresa { get; set; }
    }
}
