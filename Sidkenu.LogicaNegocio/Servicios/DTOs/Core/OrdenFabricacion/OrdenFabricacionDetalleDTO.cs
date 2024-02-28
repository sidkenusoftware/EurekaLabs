using Sidkenu.LogicaNegocio.Servicios.DTOs.Base;

namespace Sidkenu.LogicaNegocio.Servicios.DTOs.Core.OrdenFabricacion
{
    public class OrdenFabricacionDetalleDTO : EntidadBaseDTO
    {
        public Guid ArticuloId { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        
        public decimal Cantidad { get; set; }
        
        public decimal StockActual { get; set; }
        
        public decimal CantidadFabricar { get; set; }

        public decimal CantidadTotal => CantidadFabricar * Cantidad;

        public decimal Faltante => CantidadFabricar * Cantidad > StockActual
            ? (CantidadFabricar * Cantidad) - StockActual
            : 0;

        public bool HayStock => StockActual > Cantidad * CantidadFabricar;

        public bool EsFormula { get; set; }
    }
}
