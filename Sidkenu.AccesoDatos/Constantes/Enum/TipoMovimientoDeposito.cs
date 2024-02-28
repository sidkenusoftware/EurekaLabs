using System.ComponentModel;

namespace Sidkenu.AccesoDatos.Constantes.Enum
{
    public enum TipoMovimientoDeposito
    {
        [Description("Transferencia")]
        Transferencia = 0,

        [Description("Baja")]
        Baja = 1,

        [Description("Ajuste")]
        Ajuste = 2,

        [Description("Entrada")]
        Entrada = 3,

        [Description("Salida")]
        Salida = 4,

        [Description("Armado")]
        Armado = 5,
    }
}
