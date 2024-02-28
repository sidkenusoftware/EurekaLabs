using System.ComponentModel;

namespace Sidkenu.AccesoDatos.Constantes.Enum
{
    public enum TipoDeposito
    {
        [Description("Venta")]
        Venta = 0,

        [Description("Compra")]
        Compra = 1,

        [Description("Compra-Venta")]
        CompraVenta = 2,
    }
}