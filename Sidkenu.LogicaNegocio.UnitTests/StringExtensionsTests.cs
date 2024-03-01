using NUnit.Framework;
using Sidkenu.LogicaNegocio.Extensiones;

namespace Sidkenu.LogicaNegocio.UnitTests
{
    [TestFixture]
    public class StringExtensionsTests
    {
        [TestCase("ejemplo@dominio.com")]
        [TestCase("usuario123@example.com")]
        [TestCase("nombre.apellido@subdominio.dominio.com")]
        [TestCase("usuario+test@dominio.com")]
        public void IsValidEmail_ValidEmail_ReturnsTrue(string email)
        {
            // Arrange

            // Act
            bool isValid = email.IsValidEmail();

            // Assert
            Assert.IsTrue(isValid);
        }

        [TestCase("ejemplo@dominio")] // Sin extensión de dominio
        [TestCase("usuario.example.com")] // Sin "@" separando usuario y dominio
        [TestCase("usuario@ejemplo@dominio.com")] // Varios "@" presentes
        [TestCase("usuario@dominio_com")] // Caracteres no válidos en el dominio
        [TestCase("usuario@dominio.")] // Sin extensión de dominio
        [TestCase("usuario@dominio..com")] // Punto duplicado en el dominio
        [TestCase("usuario@dominio.com.")] // Punto adicional al final del dominio
        [TestCase("usuario@dominio.com ")] // Espacio al final
        [TestCase("usuario@ dominio.com")] // Espacio al principio
        public void IsValidEmail_InvalidEmail_ReturnsFalse(string email)
        {
            // Arrange

            // Act
            bool isValid = email.IsValidEmail();

            // Assert
            Assert.IsFalse(isValid);
        }
    }

}