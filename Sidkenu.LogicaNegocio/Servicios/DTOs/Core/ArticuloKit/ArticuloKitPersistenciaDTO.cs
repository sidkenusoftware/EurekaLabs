namespace Sidkenu.LogicaNegocio.Servicios.DTOs.Core.ArticuloKit
{
    public class ArticuloKitPersistenciaDTO
    {
        public Guid EmpresaId { get; set; }
        public Guid ArticuloBaseId { get; set; }
        public DateTime FechaVigencia { get; set; }
        public decimal PrecioCosto { get; set; }
        public decimal PrecioPublico { get; set; }
        public decimal Stock { get; set; }
        public List<ArticuloKitDTO> Articulos { get; set; }
    }
}
