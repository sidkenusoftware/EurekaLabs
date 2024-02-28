namespace SidkenuWF.Formularios.Core.Model.PuntoVenta
{
    public class DetalleTemporalVM : BaseVM
    {
        public Guid? ArticuloId { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public decimal Cantidad { get; set; }
        public decimal PrecioPublico { get; set; }
        public decimal SubTotal => PrecioPublico * Cantidad;
    }
}
