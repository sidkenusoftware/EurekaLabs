using Sidkenu.AccesoDatos.Constantes;
using Sidkenu.AccesoDatos.Constantes.Enum;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Base;

namespace Sidkenu.LogicaNegocio.Servicios.DTOs.Core.Comprobante
{
    public class ComprobanteDetalleDTO : EntidadBaseDTO
    {
        public ComprobanteDetalleDTO()
        {
            FabricacionDetalles ??= new List<ComprobanteDetalleFabricacionDTO>();
        }

        public List<ComprobanteDetalleFabricacionDTO> FabricacionDetalles { get; set; }

        public Guid? ArticuloId { get; set; }
        public Guid? ListaPrecioId { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public decimal Cantidad { get; set; }        
        public decimal PrecioPublico { get; set; }
        public decimal Descuento { get; set; }
        public decimal Impuesto { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Iva => Porcentaje.Calcular(PrecioPublico, Impuesto);
        public decimal Neto => PrecioPublico - Iva;
        public byte[] Foto { get; set; }
        public string CodigoFabricacion { get; set; }
        public TipoItemFactura TipoItem { get; set; }
        public DateTime FechaEntrega { get; set; }
    }
}
