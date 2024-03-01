using System.Text;

namespace SidkenuWF.Helpers
{
    public static class ColorAleatorio
    {
        public static Color Obtener(string letra)
        {
            if (string.IsNullOrEmpty(letra))
            {
                return Color.FromArgb(48, 66, 80);
            }

            int codigoAscii = Encoding.ASCII.GetBytes(letra.ToUpper())[0];

            if (codigoAscii >= 65 && codigoAscii < 70)
            {
                return Color.DarkRed;
            }
            else if (codigoAscii >= 70 && codigoAscii < 75)
            {
                return Color.Orange;
            }
            else if (codigoAscii >= 75 && codigoAscii < 80)
            {
                return Color.Blue;
            }
            else if (codigoAscii >= 80 && codigoAscii < 85)
            {
                return Color.DarkViolet;
            }
            else if (codigoAscii >= 85 && codigoAscii <= 90)
            {
                return Color.Green;
            }

            return Color.FromArgb(48, 66, 80);
        }

        public static Color Obtener(int numero)
        {
            if (numero >= 0 && numero < 7)
            {
                return Color.DarkRed;
            }
            else if (numero >= 8 && numero < 14)
            {
                return Color.Orange;
            }
            else if (numero >= 15 && numero < 20)
            {
                return Color.Blue;
            }
            else if (numero >= 21 && numero < 25)
            {
                return Color.DarkViolet;
            }
            else if (numero >= 26 && numero <= 31)
            {
                return Color.Green;
            }

            return Color.FromArgb(48, 66, 80);
        }
    }
}
