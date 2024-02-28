using System.ComponentModel;

namespace Sidkenu.AccesoDatos.Constantes.Enum
{
    public enum TipoComprobante
    {
        [Description("Venta")]
        Venta = 0,

        [Description("Compra")]
        Compra = 1,

        [Description("Nota de Crédito")]
        NotaCredito = 2,

        [Description("Salon")]
        Salon = 3,

        [Description("Nota de Débito")]
        NotaDebito = 4,

        [Description("Gastos")]
        Gastos = 5,

        [Description("Transferencia entre Cajas")]
        TransferenciaCaja = 6
    }
}
