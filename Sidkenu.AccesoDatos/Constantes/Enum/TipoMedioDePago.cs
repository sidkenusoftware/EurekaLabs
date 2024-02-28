using System.ComponentModel;

namespace Sidkenu.AccesoDatos.Constantes.Enum
{
    public enum TipoMedioDePago
    {
        [Description("Pendiente de Pago")]
        PendienteDePago = 0,

        [Description("Efectivo")]
        Efectivo = 1,

        [Description("Tarjeta")]
        Tarjeta = 2,

        [Description("Cuenta Corriente")]
        CuentaCorriente = 3,

        [Description("Cheque")]
        Cheque = 4,

        [Description("Transferencia")]
        Transferencia = 5,

        [Description("Mercado Pago")]
        MercadoPago = 6,
    }
}
