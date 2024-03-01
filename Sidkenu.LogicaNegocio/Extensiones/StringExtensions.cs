using System.Text.RegularExpressions;

namespace Sidkenu.LogicaNegocio.Extensiones
{
    public static class StringExtensions
    {
        public static bool IsValidEmail(this string email)
        {
            // Expresión regular para validar un correo electrónico
            string pattern = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+(\.[a-zA-Z0-9-]+)*$";

            // Comprobación con la expresión regular
            return Regex.IsMatch(email, pattern) && email.Contains(".") && !email.EndsWith(".");
        }
    }
}
