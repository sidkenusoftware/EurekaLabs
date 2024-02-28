using System.Reflection;

namespace SidkenuWF.Formularios.Base.Constantes
{
    public static class ThemeManager
    {
        public static void ApplyTheme(Control control, Color backgroundColor, Color textColor)
        {
            control.BackColor = backgroundColor;
            control.ForeColor = textColor;

            foreach (Control childControl in control.Controls)
            {
                ApplyTheme(childControl, backgroundColor, textColor);
            }
        }

        public static void ApplyTheme(Control control, string themeName)
        {
            // Obtener el tipo de color según el nombre del tema
            Type colorType = typeof(Color);
            PropertyInfo[] properties = colorType.GetProperties(BindingFlags.Static | BindingFlags.Public);

            foreach (PropertyInfo property in properties)
            {
                if (property.Name.Equals(themeName, StringComparison.OrdinalIgnoreCase))
                {
                    Color backgroundColor = (Color)property.GetValue(null, null);
                    Color textColor = GetContrastColor(backgroundColor);
                    ApplyTheme(control, backgroundColor, textColor);
                    break;
                }
            }
        }

        public static void ApplyTheme(Control control, Color themeName)
        {
            // Obtener el tipo de color según el nombre del tema
            Type colorType = typeof(Color);
            PropertyInfo[] properties = colorType.GetProperties(BindingFlags.Static | BindingFlags.Public);

            foreach (PropertyInfo property in properties)
            {
                Color backgroundColor = themeName;
                Color textColor = GetContrastColor(backgroundColor);
                ApplyTheme(control, backgroundColor, textColor);
                break;
            }
        }

        private static Color GetContrastColor(Color color)
        {
            // Determinar el color de texto adecuado basado en el contraste del color de fondo
            double luminance = (0.299 * color.R + 0.587 * color.G + 0.114 * color.B) / 255;
            return luminance > 0.5 ? Color.Black : Color.White;
        }
    }
}
