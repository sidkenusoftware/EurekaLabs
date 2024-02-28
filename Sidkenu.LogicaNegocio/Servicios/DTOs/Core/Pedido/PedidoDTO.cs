using Sidkenu.LogicaNegocio.Servicios.DTOs.Base;

namespace Sidkenu.LogicaNegocio.Servicios.DTOs.Core.Pedido
{
    public class PedidoDTO : EntidadBaseDTO
    {
        public PedidoDTO()
        {
            Detalles ??= new List<PedidoDetalleDTO>();
        }

        public Guid EmpresaId { get; set; }
        public int Numero { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Total { get; set; }

        public Guid ProveedorId { get; set; }
        public string Proveedor { get; set; }

        public Guid PersonaId { get; set; }
        public string Persona { get; set; }

        public List<PedidoDetalleDTO> Detalles { get; set; }
    }
}
