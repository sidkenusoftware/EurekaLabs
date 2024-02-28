using Sidkenu.LogicaNegocio.Servicios.DTOs.Base;

namespace Sidkenu.LogicaNegocio.Servicios.DTOs.Core.Pedido
{
    public class PedidoPersistenciaDTO : EntidadBaseDTO
    {
        public PedidoPersistenciaDTO()
        {
            Detalles ??= new List<PedidoDetalleDTO>();
        }

        public Guid? EmpresaId { get; set; }
        public int Numero { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Total { get; set; }

        public List<PedidoDetalleDTO> Detalles { get; set; }
    }
}
