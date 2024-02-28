using Sidkenu.AccesoDatos.Entidades.Base;
using Sidkenu.AccesoDatos.Constantes.Enum;

namespace Sidkenu.AccesoDatos.Entidades.Core
{
    public class ComprobanteDetalle : EntidadBase
    {
        // Propiedades
        public Guid ComprobanteId { get; set; }
        public Guid? ArticuloId { get; set; }

        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public decimal Neto { get; set; }
        public decimal Alicuota { get; set; }
        public decimal Iva { get; set; }
        public decimal Cantidad { get; set; }
        public decimal SubTotal { get; set; }
        public byte[]? Foto { get; set; }
        public DateTime? FechaEntrega { get; set; }
        // public string? CodigoFabricacion { get; set; }
        public TipoItemFactura TipoItem { get; set; }

        // Propiedades de Navegacion
        public virtual Comprobante Comprobante { get; set; }
        public virtual Articulo Articulo { get; set; }
        public virtual List<ComprobanteDetalleFabricacion> Fabricaciones { get; set; }
    }
}
