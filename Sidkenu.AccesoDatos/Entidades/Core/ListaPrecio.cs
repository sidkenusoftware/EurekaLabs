using Sidkenu.AccesoDatos.Entidades.Base;
using Sidkenu.AccesoDatos.Entidades.Seguridad;

namespace Sidkenu.AccesoDatos.Entidades.Core
{
    public class ListaPrecio : EntidadBase
    {
        // Propiedades
        public Guid EmpresaId { get; set; }

        public string Codigo { get; set; }

        public string Descripcion { get; set; }

        public decimal Rentabilidad { get; set; }


        // Propiedades de Navegacion
        public virtual Empresa Empresa { get; set; }
        public virtual List<Cliente> Clientes { get; set; }
        public virtual List<ArticuloPrecio> Precios { get; set; }
        public virtual List<ConfiguracionCore> ConfiguracionCoreListaPrecios { get; set; }
        public virtual List<FamiliaListaPrecio> FamiliaListaPrecios { get; set; }
        public virtual List<MarcaListaPrecio> MarcaListaPrecios { get; set; }
    }
}
