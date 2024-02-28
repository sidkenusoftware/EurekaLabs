using Sidkenu.AccesoDatos.Entidades.Base;

namespace Sidkenu.AccesoDatos.Entidades.Core
{
    public class ComprobanteDetalleFabricacion : EntidadBase
    {
        // Propiedades
        public Guid ComprobanteDetalleId { get; set; }
        public Guid? ArticuloId { get; set; }
        public string? Codigo { get; set; }
        public string? Descripcion { get; set; }
        public decimal Cantidad { get; set; }
        public decimal PrecioPublico { get; set; }
        public decimal SubTotal { get; set; }

        // Propiedades de Navegacion
        public virtual ComprobanteDetalle ComprobanteDetalle { get; set; }
    }
}
