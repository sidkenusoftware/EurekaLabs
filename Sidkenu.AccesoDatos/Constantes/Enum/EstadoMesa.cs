using System.ComponentModel;

namespace Sidkenu.AccesoDatos.Constantes.Enum
{
    public enum EstadoMesa
    {
        [Description("Cerrada")]
        Cerrada = 0,

        [Description("Abierta")]
        Abierta = 1,

        [Description("Fuera de Servicio")]
        FueraServicio = 2,

        [Description("Reservada")]
        Reservada = 3
    }
}
