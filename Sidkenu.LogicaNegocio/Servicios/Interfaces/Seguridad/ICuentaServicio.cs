using Sidkenu.LogicaNegocio.Servicios.DTOs.Seguridad.Cuenta;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Seguridad.Usuario;

namespace Sidkenu.LogicaNegocio.Servicios.Interface.Seguridad
{
    public interface ICuentaServicio
    {
        (bool, UsuarioDTO) GetLoginByCredentials(UserLoginDTO login);

        bool GenerarNuevoPassword(Guid userId);
    }
}
