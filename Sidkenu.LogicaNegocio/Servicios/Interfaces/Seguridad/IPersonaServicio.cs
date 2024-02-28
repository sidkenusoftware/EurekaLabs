using Sidkenu.LogicaNegocio.Servicios.DTOs.Base;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Seguridad.Persona;

namespace Sidkenu.LogicaNegocio.Servicios.Interface.Seguridad
{
    public interface IPersonaServicio
    {
        ResultDTO Add(PersonaPersistenciaDTO entidad, string user);
        ResultDTO Update(PersonaPersistenciaDTO entidad, string user);
        ResultDTO Delete(PersonaDeleteDTO deleteDTO, string user);

        // ================================================================= //

        ResultDTO GetById(Guid id);
        ResultDTO GetByFilter(PersonaFilterDTO filter);
        ResultDTO GetByFilterLookUp(PersonaFilterDTO filter);
        ResultDTO GetAll();
    }
}
