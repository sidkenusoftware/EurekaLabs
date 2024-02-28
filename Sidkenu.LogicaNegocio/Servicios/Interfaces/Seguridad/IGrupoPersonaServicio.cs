using Sidkenu.LogicaNegocio.Servicios.DTOs.Base;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Seguridad.GrupoPersona;

namespace Sidkenu.LogicaNegocio.Servicios.Interface.Seguridad
{
    public interface IGrupoPersonaServicio
    {
        ResultDTO GetByPersonasAsignadas(GrupoPersonaFilterDTO filterDTO);
        ResultDTO GetByPersonasNoAsignadas(GrupoPersonaFilterDTO filterDTO);

        ResultDTO AddPersonaGrupo(GrupoPersonaPersistenciaDTO GrupoPersonaPersistenciaDTO, string userLogin);
        ResultDTO AddPersonasGrupo(GrupoPersonasPersistenciaDTO GrupoPersonasPersistenciaDTO, string userLogin);

        ResultDTO DeletePersonaGrupo(GrupoPersonaPersistenciaDTO GrupoPersonaPersistenciaDTO, string userLogin);
        ResultDTO DeletePersonasGrupo(GrupoPersonasPersistenciaDTO GrupoPersonasPersistenciaDTO, string userLogin);
    }
}
