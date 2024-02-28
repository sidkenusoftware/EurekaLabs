namespace Sidkenu.LogicaNegocio.Servicios.DTOs.Core.Articulo
{
    public class ArticuloPrecioDTO
    {
        public Guid Id { get; set; }
        public Guid ListaPrecioId { get; set; }
        public string ListaPrecio { get; set; }
        public decimal Monto { get; set; }
        public DateTime FechaActualizacion { get; set; }
    }
}
