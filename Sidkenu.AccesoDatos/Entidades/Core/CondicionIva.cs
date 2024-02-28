using Sidkenu.AccesoDatos.Entidades.Base;
using Sidkenu.AccesoDatos.Entidades.Seguridad;

namespace Sidkenu.AccesoDatos.Entidades.Core
{
    public class CondicionIva : EntidadBase
    {
        // Propiedades
        public Guid? EmpresaId { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public decimal Valor { get; set; }
        public bool AplicaParaFacturaElectronica { get; set; }

        // Propiedades de Navegacion
        public virtual List<Articulo> Articulos { get; set; }
        public virtual Empresa Empresa { get; set; }
    }
}