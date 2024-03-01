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

        public static bool IsValidUsaPhoneNumber(this string phoneNumber)
        {
            // Expresión regular para validar un número de teléfono en formato estadounidense de 10 dígitos
            string phonePattern = @"^\d{3}-\d{3}-\d{4}$";

            // Comprobación con la expresión regular
            return Regex.IsMatch(phoneNumber, phonePattern);
        }

        public static bool IsValidPhoneNumber(this string phoneNumber)
        {
            phoneNumber = phoneNumber.Trim().Replace(" ", "").Replace("-", "");

            // Expresión regular para validar un número de teléfono en los formatos deseados
            string phonePattern = @"^\+\d{2}(\d{2})?9\d{3}\d{7}$";

            // Comprobación con la expresión regular
            return Regex.IsMatch(phoneNumber, phonePattern);
        }

        public static bool IsValidCuitCuil(this string cuitCuil)
        {
            // Expresión regular para validar un CUIT/CUIL en los formatos deseados
            string cuitCuilPattern = @"^\d{2}-?\d{8}-?\d$";

            // Comprobación con la expresión regular
            return Regex.IsMatch(cuitCuil, cuitCuilPattern);
        }

        public static bool IsValidPassword(this string password)
        {
            // Expresión regular para validar una contraseña con al menos 8 caracteres, una letra mayúscula, una letra minúscula, un carácter especial y un número
            string passwordPattern = @"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d)(?=.*[^a-zA-Z0-9]).{8,}$";

            // Comprobación con la expresión regular
            return Regex.IsMatch(password, passwordPattern);
        }
    }
}
