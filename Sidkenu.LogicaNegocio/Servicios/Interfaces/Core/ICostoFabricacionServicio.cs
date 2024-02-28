using Sidkenu.LogicaNegocio.Servicios.DTOs.Base;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.CostoFabricacion;

namespace Sidkenu.LogicaNegocio.Servicios.Interface.Core
{
    public interface ICostoFabricacionServicio
    {
        ResultDTO Add(CostoFabricacionPersistenciaDTO entidad, string user);
        ResultDTO Update(CostoFabricacionPersistenciaDTO entidad, bool actualizarPrecio, string user);
        ResultDTO Delete(CostoFabricacionDeleteDTO deleteDTO, string user);

        // ================================================================= //

        ResultDTO GetById(Guid id);
        ResultDTO GetByFilter(CostoFabricacionFilterDTO filter);
        ResultDTO GetAll(Guid empresaId);
        ResultDTO GetAll();
    }
}
