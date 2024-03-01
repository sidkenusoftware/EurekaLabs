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

        [TestCase("123-456-7890", ExpectedResult = true)]
        [TestCase("999-999-9999", ExpectedResult = true)]
        [TestCase("1234567890", ExpectedResult = false)] // Sin guiones
        [TestCase("1234-567-890", ExpectedResult = false)] // Formato incorrecto
        [TestCase("abc-def-ghij", ExpectedResult = false)] // Caracteres no numéricos
        [TestCase("12-3456-7890", ExpectedResult = false)] // Longitud incorrecta
        public bool IsValidUsaPhoneNumber_ValidPhone_ReturnsExpected(string phoneNumber)
        {
            // Arrange & Act
            return phoneNumber.IsValidUsaPhoneNumber();
        }

        [TestCase("+54 9 381 3630058", ExpectedResult = true)]
        [TestCase("+5493813630058", ExpectedResult = true)]
        [TestCase("+54 9 3813 63-0058", ExpectedResult = true)]
        [TestCase("+123 456 7890", ExpectedResult = false)] // Prefijo de país incorrecto
        [TestCase("123-456-7890", ExpectedResult = false)] // Formato incorrecto para el método IsValidPhoneNumber
        [TestCase("999-999-9999", ExpectedResult = false)] // Formato incorrecto para el método IsValidPhoneNumber
        [TestCase("abc-def-ghij", ExpectedResult = false)] // Caracteres no numéricos
        [TestCase("123456789012345", ExpectedResult = false)] // Longitud incorrecta
        public bool IsValidPhoneNumber_ValidPhone_ReturnsExpected(string phoneNumber)
        {
            // Arrange & Act
            return phoneNumber.IsValidPhoneNumber();
        }
    }

}