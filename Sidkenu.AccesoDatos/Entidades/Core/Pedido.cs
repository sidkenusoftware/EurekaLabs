using Sidkenu.AccesoDatos.Entidades.Base;
using Sidkenu.AccesoDatos.Entidades.Seguridad;

namespace Sidkenu.AccesoDatos.Entidades.Core
{
    public class Pedido : EntidadBase
    {
        // Propiedades
        public Guid EmpresaId { get; set; }
        public Guid ProveedorId { get; set; }
        public Guid PersonaId { get; set; }
        public int Numero { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Total { get; set; }

        // Propiedades de Navegacion
        public Empresa  Empresa { get; set; }
        public Proveedor Proveedor { get; set; }
        public Persona Persona { get; set; }
        public List<PedidoDetalle> Detalles { get; set; }
    }
}
