using Sidkenu.LogicaNegocio.Servicios.DTOs.Base;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.TipoGasto;

namespace Sidkenu.LogicaNegocio.Servicios.Interface.Core
{
    public interface ITipoGastoServicio
    {
        ResultDTO Add(TipoGastoPersistenciaDTO entidad, string user);
        ResultDTO Update(TipoGastoPersistenciaDTO entidad, string user);
        ResultDTO Delete(TipoGastoDeleteDTO deleteDTO, string user);

        // ================================================================= //

        ResultDTO GetById(Guid id);
        ResultDTO GetByFilter(TipoGastoFilterDTO filter);
        ResultDTO GetAll(Guid empresaId);
        ResultDTO GetAll();
    }
}
