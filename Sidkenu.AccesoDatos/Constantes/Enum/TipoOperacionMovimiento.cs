using System.ComponentModel;

namespace Sidkenu.AccesoDatos.Constantes.Enum
{
    public enum TipoOperacionMovimiento
    {
        [Description("Efectivo")]
        Efectivo = 0,

        [Description("Tarjeta")]
        Tarjeta = 1,

        [Description("Cheque")]
        Cheque = 2,

        [Description("Transferencia")]
        Transferencia = 3,

        [Description("Cuenta Corriente")]
        CuentaCorriente = 4,

        [Description("Gastos")]
        Gastos = 5,

        [Description("Pagos")]
        Pagos = 6,

        [Description("Servicio")]
        Servicio = 7,

        [Description("Transf. Caja")]
        TransferenciaCaja = 8,

        [Description("Pendiente de Pago")]
        PendienteDePago = 9,
    }
}
