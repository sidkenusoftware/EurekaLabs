using Sidkenu.LogicaNegocio.Servicios.DTOs.Base;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Seguridad.Grupo;

namespace Sidkenu.LogicaNegocio.Servicios.Interface.Seguridad
{
    public interface IGrupoServicio
    {
        ResultDTO Add(GrupoPersistenciaDTO entidad, string user);
        ResultDTO Update(GrupoPersistenciaDTO entidad, string user);
        ResultDTO Delete(GrupoDeleteDTO deleteDTO, string user);

        // ================================================================= //

        ResultDTO GetById(Guid id);
        ResultDTO GetByFilter(GrupoFilterDTO filter);
        ResultDTO GetAll();
    }
}
