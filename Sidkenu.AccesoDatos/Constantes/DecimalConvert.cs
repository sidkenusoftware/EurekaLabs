using System.Globalization;

namespace Sidkenu.AccesoDatos.Constantes
{
    public static class DecimalConvert
    {
        public static decimal Parse(string valor, int decimales)
        {
            string separadorDecimal = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;

            if (decimales == 0)
            {
                return decimal.Parse(valor);
            }
            else
            {
                var parteEntera = valor.Substring(0, valor.Length - decimales);

                var parteDecimal = valor.Substring(valor.Length - decimales, decimales);

                var resultStr = $"{parteEntera}{separadorDecimal}{parteDecimal}";

                return decimal.Parse(resultStr);
            }
        }
    }
}
