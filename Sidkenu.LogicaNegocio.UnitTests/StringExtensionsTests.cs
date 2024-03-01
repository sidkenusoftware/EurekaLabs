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

        [TestCase("ejemplo@dominio")] // Sin extensi�n de dominio
        [TestCase("usuario.example.com")] // Sin "@" separando usuario y dominio
        [TestCase("usuario@ejemplo@dominio.com")] // Varios "@" presentes
        [TestCase("usuario@dominio_com")] // Caracteres no v�lidos en el dominio
        [TestCase("usuario@dominio.")] // Sin extensi�n de dominio
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
        [TestCase("abc-def-ghij", ExpectedResult = false)] // Caracteres no num�ricos
        [TestCase("12-3456-7890", ExpectedResult = false)] // Longitud incorrecta
        public bool IsValidUsaPhoneNumber_ValidPhone_ReturnsExpected(string phoneNumber)
        {
            // Arrange & Act
            return phoneNumber.IsValidUsaPhoneNumber();
        }

        [TestCase("+54 9 381 3630058", ExpectedResult = true)]
        [TestCase("+5493813630058", ExpectedResult = true)]
        [TestCase("+54 9 3813 63-0058", ExpectedResult = true)]
        [TestCase("+123 456 7890", ExpectedResult = false)] // Prefijo de pa�s incorrecto
        [TestCase("123-456-7890", ExpectedResult = false)] // Formato incorrecto para el m�todo IsValidPhoneNumber
        [TestCase("999-999-9999", ExpectedResult = false)] // Formato incorrecto para el m�todo IsValidPhoneNumber
        [TestCase("abc-def-ghij", ExpectedResult = false)] // Caracteres no num�ricos
        [TestCase("123456789012345", ExpectedResult = false)] // Longitud incorrecta
        public bool IsValidPhoneNumber_ValidPhone_ReturnsExpected(string phoneNumber)
        {
            // Arrange & Act
            return phoneNumber.IsValidPhoneNumber();
        }

        [TestCase("20123404329", ExpectedResult = true)]
        [TestCase("20-12340432-9", ExpectedResult = true)]
        [TestCase("2012340432", ExpectedResult = false)] // Longitud incorrecta
        [TestCase("20-12340432-91", ExpectedResult = false)] // Longitud incorrecta
        [TestCase("abc-def-ghij", ExpectedResult = false)] // Caracteres no num�ricos
        [TestCase("123456789012345", ExpectedResult = false)] // Longitud incorrecta
        public bool IsValidCuitCuil_ValidCuitCuil_ReturnsExpected(string cuitCuil)
        {
            // Arrange & Act
            return cuitCuil.IsValidCuitCuil();
        }

        [TestCase("P@ssw0rd", ExpectedResult = true)] // V�lida
        [TestCase("Password1", ExpectedResult = false)] // Falta car�cter especial
        [TestCase("pass", ExpectedResult = false)] // Menos de 8 caracteres
        [TestCase("P@ssword", ExpectedResult = false)] // Falta n�mero
        [TestCase("P@ssw0rd!", ExpectedResult = true)] // V�lida
        [TestCase("PASSWORD1", ExpectedResult = false)] // Falta letra min�scula
        [TestCase("p@ssword1", ExpectedResult = false)] // Falta letra may�scula
        [TestCase("P@ssword123456789", ExpectedResult = true)] // V�lida
        [TestCase("P@ssword!123456789", ExpectedResult = true)] // V�lida
        [TestCase("P@ssw0rd#", ExpectedResult = true)] // V�lida
        [TestCase("P@ssw0rd1", ExpectedResult = true)] // V�lida
        [TestCase("P@ssw0rd1!", ExpectedResult = true)] // V�lida
        [TestCase("P@ssword!@#$%123", ExpectedResult = true)] // V�lida
        [TestCase("P@ssw0rd!@#$%123456", ExpectedResult = true)] // V�lida
        [TestCase("p@ssword", ExpectedResult = false)] // Falta n�mero y letra may�scula
        [TestCase("P@SSWORD1", ExpectedResult = false)] // Falta letra min�scula y car�cter especial
        [TestCase("p@ssword!", ExpectedResult = false)] // Falta letra may�scula y n�mero
        [TestCase("P@SSWORD!", ExpectedResult = false)] // Falta letra min�scula y n�mero
        [TestCase("P@ssword1", ExpectedResult = true)] // V�lida
        [TestCase("P@ssword!", ExpectedResult = false)] // Falta un n�mero
        [TestCase("P@SSWORD1!", ExpectedResult = false)] // Falta una letra min�scula
        [TestCase("P@ssword1!", ExpectedResult = true)] // V�lida
        [TestCase("P@ssword123", ExpectedResult = true)] // V�lida
        [TestCase("!@#$%&*()", ExpectedResult = false)] // Menos de 8 caracteres
        [TestCase("12345678", ExpectedResult = false)] // Menos de 8 caracteres
        [TestCase("P@ssword", ExpectedResult = false)] // Falta n�mero y car�cter especial
        [TestCase("P@SSW0RD!", ExpectedResult = false)] // Falta letra min�scula
        public bool IsValidPassword_ValidPassword_ReturnsExpected(string password)
        {
            // Arrange & Act
            return password.IsValidPassword();
        }
    }

}