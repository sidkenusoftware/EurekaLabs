using System.ComponentModel;

namespace Sidkenu.AccesoDatos.Constantes.Enum
{
    public enum TipoMovimiento
    {
        [Description("Ingreso")]
        Ingreso = 1,

        [Description("Egreso")]
        Egreso = -1
    }
}
