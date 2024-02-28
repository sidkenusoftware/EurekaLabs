using Sidkenu.LogicaNegocio.Servicios.DTOs.Base;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Seguridad.GrupoFormulario;

namespace Sidkenu.LogicaNegocio.Servicios.Interface.Seguridad
{
    public interface IGrupoFormularioServicio
    {
        ResultDTO GetByFormulariosAsignadas(GrupoFormularioFilterDTO filterDTO);
        ResultDTO GetByFormulariosNoAsignadas(GrupoFormularioFilterDTO filterDTO);

        ResultDTO AddFormularioGrupo(GrupoFormularioPersistenciaDTO GrupoFormularioPersistenciaDTO, string userLogin);
        ResultDTO AddFormulariosGrupo(GrupoFormulariosPersistenciaDTO GrupoFormulariosPersistenciaDTO, string userLogin);

        ResultDTO DeleteFormularioGrupo(GrupoFormularioPersistenciaDTO GrupoFormularioPersistenciaDTO, string userLogin);
        ResultDTO DeleteFormulariosGrupo(GrupoFormulariosPersistenciaDTO GrupoFormulariosPersistenciaDTO, string userLogin);
    }
}
