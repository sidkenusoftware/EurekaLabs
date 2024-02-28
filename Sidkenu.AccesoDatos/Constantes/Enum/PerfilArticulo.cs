using System.ComponentModel;

namespace Sidkenu.AccesoDatos.Constantes.Enum
{
    public enum PerfilArticulo
    {
        [Description("Base")]
        Base = 0,

        [Description("Compra-Venta")]
        CompraVenta = 1,

        [Description("Compra")]
        Compra = 2,

        [Description("Venta")]
        Venta = 3,

        [Description("Bien de Uso")]
        BienUso = 4,
    }
}
