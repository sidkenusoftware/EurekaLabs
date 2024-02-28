using System.ComponentModel;

namespace Sidkenu.AccesoDatos.Constantes.Enum
{
    public enum EstadoReserva
    {
        [Description("Confirmada")]
        Confirmada = 0,

        [Description("No Confirmada")]
        NoConfirmada = 1,

        [Description("Cancelada")]
        Cancelada = 2
    }
}
