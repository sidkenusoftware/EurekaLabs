using System.ComponentModel;

namespace Sidkenu.AccesoDatos.Constantes.Enum
{
    public enum TipoArticulo
    {
        [Description("Base")] // Solo sirve para Generar las Variantes
        Base = 0,

        [Description("Variante")]
        Variante = 1,

        [Description("Simple")] // La mayoria de los productos
        Simple = 2,

        [Description("Kit")] // Solo para las Promociones
        Kit = 3,

        [Description("Fórmula")] // Cuando esta compuesto por varios otros articulos
        Formula = 4,

        [Description("Servicio")] // Ej: Mantenimiento
        Servicio = 5,

        [Description("Bien de Uso")] // Ej: Herramientas
        BienUso = 6,
    }
}
