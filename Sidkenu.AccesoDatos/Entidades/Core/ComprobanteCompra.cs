namespace Sidkenu.AccesoDatos.Entidades.Core
{
    public class ComprobanteCompra : Comprobante
    {
        public Guid ProveedorId { get; set; }

        public string NumeroCompra { get; set; }

        // Ivas
        public decimal Iva27 { get; set; }

        public decimal Iva21 { get; set; }

        public decimal Iva105 { get; set; }

        // Percepciones
        public decimal PercepcionTemp { get; set; }

        public decimal PercepcionPyP { get; set; }

        public decimal PercepcionIva { get; set; }

        public decimal PercepcionIB { get; set; }

        public decimal Descuento { get; set; }

        // Propiedades de Navegacion
        public virtual List<CuentaCorrienteProveedor> CuentaCorrienteProveedores { get; set; }

        public virtual Proveedor Proveedor { get; set; }
    }
}
