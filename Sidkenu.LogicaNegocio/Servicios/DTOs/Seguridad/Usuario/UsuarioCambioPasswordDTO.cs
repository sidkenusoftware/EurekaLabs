namespace Sidkenu.LogicaNegocio.Servicios.DTOs.Seguridad.Usuario
{
    public class UsuarioCambioPasswordDTO
    {
        public Guid UserId { get; set; }

        public string PasswordActual { get; set; }

        public string PasswordNueva { get; set; }
    }
}
