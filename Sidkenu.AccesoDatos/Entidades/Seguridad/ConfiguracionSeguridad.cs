using Sidkenu.AccesoDatos.Entidades.Base;

namespace Sidkenu.AccesoDatos.Entidades.Seguridad
{
    public class ConfiguracionSeguridad : EntidadBase
    {
        public Guid EmpresaId { get; set; }
        // Login
        public bool LoginNormal { get; set; }

        // Correo Electronico
        public string UsuarioCredencial { get; set; }
        public string PasswordCredencial { get; set; }
        public int Puerto { get; set; }
        public string Host { get; set; }

        // Tipo de Loggin
        public bool LogInformacion { get; set; }
        public bool LogWarning { get; set; }
        public bool LogError { get; set; }

        // Seguridad
        public bool EnviarMailCreateUsuario { get; set; }
    }
}
