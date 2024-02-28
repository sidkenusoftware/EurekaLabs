using System.ComponentModel;

namespace Sidkenu.AccesoDatos.Constantes.Enum
{
    public enum EstadoOrdenFabricacion
    {
        [Description("Pendiente")]
        Pendiente = 0,

        [Description("En Proceso")]
        EnProceso = 1,

        [Description("Finalizada")]
        Finalizada = 2,
    }
}
