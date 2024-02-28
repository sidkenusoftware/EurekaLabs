using Sidkenu.AccesoDatos.Entidades.Base;

namespace Sidkenu.AccesoDatos.Entidades.Core
{
    public class PedidoDetalle : EntidadBase
    {
        // Propiedades
        public Guid PedidoId { get; set; }

        public Guid ArticuloId { get; set; }

        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public decimal Iva { get; set; }
        public decimal Cantidad { get; set; }
        public decimal SubTotal { get; set; }

        // Propiedades de Nevegacion
        public Pedido Pedido { get; set; }
        public Articulo Articulo { get; set; }
    }
}
