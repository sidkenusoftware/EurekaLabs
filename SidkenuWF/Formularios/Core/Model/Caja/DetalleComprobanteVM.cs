namespace SidkenuWF.Formularios.Core.Model.Caja
{
    public class DetalleComprobanteVM
    {
        public Guid ComprobanteId { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public decimal Cantidad { get; set; }
        public decimal Subtotal { get; set; }

        // -------------------------------------------- //

        public Color ColorRow { get; set; }
    }
}
