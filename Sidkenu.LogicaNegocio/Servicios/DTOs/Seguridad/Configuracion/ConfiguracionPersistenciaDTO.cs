using Sidkenu.LogicaNegocio.Servicios.DTOs.Base;

namespace Sidkenu.LogicaNegocio.Servicios.DTOs.Seguridad.Configuracion
{
    public class ConfiguracionPersistenciaDTO : EntidadBaseDTO
    {
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
