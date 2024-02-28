using Sidkenu.LogicaNegocio.Servicios.DTOs.Base;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.UnidadMedida;

namespace Sidkenu.LogicaNegocio.Servicios.Interface.Core
{
    public interface IUnidadMedidaServicio
    {
        ResultDTO Add(UnidadMedidaPersistenciaDTO entidad, string user);
        ResultDTO Update(UnidadMedidaPersistenciaDTO entidad, string user);
        ResultDTO Delete(UnidadMedidaDeleteDTO deleteDTO, string user);

        // ================================================================= //

        ResultDTO GetById(Guid id);
        ResultDTO GetByFilter(UnidadMedidaFilterDTO filter);
        ResultDTO GetAll(Guid empresaId);
        ResultDTO GetAll();
    }
}
