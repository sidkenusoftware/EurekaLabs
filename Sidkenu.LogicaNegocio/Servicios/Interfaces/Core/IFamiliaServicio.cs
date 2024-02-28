using Sidkenu.LogicaNegocio.Servicios.DTOs.Base;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.Familia;

namespace Sidkenu.LogicaNegocio.Servicios.Interface.Core
{
    public interface IFamiliaServicio
    {
        ResultDTO Add(FamiliaPersistenciaDTO entidad, string user);
        ResultDTO Update(FamiliaPersistenciaDTO entidad, bool actualizarPrecio, string user);
        ResultDTO Delete(FamiliaDeleteDTO deleteDTO, string user);

        // ================================================================= //

        ResultDTO GetById(Guid id);
        ResultDTO GetByFilter(FamiliaFilterDTO filter);
        ResultDTO GetAll(Guid empresaId);
        ResultDTO GetAll();
    }
}
