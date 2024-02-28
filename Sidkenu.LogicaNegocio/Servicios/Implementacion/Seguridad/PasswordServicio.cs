using Sidkenu.LogicaNegocio.Servicios.Interface.Seguridad;
using System.Security.Cryptography;
using static Sidkenu.AccesoDatos.Constantes.PasswordOptions;

namespace Sidkenu.LogicaNegocio.Servicios.Implementacion.Seguridad
{
    public class PasswordServicio : IPasswordServicio
    {
        public bool Check(string hash, string password)
        {
            var parts = hash.Split(".", 3);

            if (parts.Length != 3)
            {
                return false;
            }

            var iterations = Convert.ToInt32(parts[0]);
            var salt = Convert.FromBase64String(parts[1]);
            var key = Convert.FromBase64String(parts[2]);

            using var algorithm = new Rfc2898DeriveBytes(password, salt, iterations);

            var keyToCheck = algorithm.GetBytes(KeySize);

            return keyToCheck.SequenceEqual(key);
        }

        public string Hash(string password)
        {
            using var algorithm = new Rfc2898DeriveBytes(password, SaltSize, Iteractions);

            var key = Convert.ToBase64String(algorithm.GetBytes(KeySize));

            var salt = Convert.ToBase64String(algorithm.Salt);

            return $"{Iteractions}.{salt}.{key}";
        }

        public string Generar(int cantidadCaracteres = 10)
        {
            Random rdn = new Random();
            string caracteres = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890%$#@";
            int longitud = caracteres.Length;
            char letra;
            int longitudContrasenia = cantidadCaracteres;
            string contraseniaAleatoria = string.Empty;
            for (int i = 0; i < longitudContrasenia; i++)
            {
                letra = caracteres[rdn.Next(longitud)];
                contraseniaAleatoria += letra.ToString();
            }

            return contraseniaAleatoria;
        }
    }
}
