using Sidkenu.LogicaNegocio.Servicios.DTOs.Base;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Seguridad.Formulario;

namespace Sidkenu.LogicaNegocio.Servicios.Interface.Seguridad
{
    public interface IFormularioServicio
    {
        ResultDTO Add(List<FormularioDTO> formularios, string userLogin);

        ResultDTO GetAll();
    }
}
