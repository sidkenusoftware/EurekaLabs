using Sidkenu.LogicaNegocio.Servicios.DTOs.Base;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.Tarjeta;

namespace Sidkenu.LogicaNegocio.Servicios.Interface.Core
{
    public interface ITarjetaServicio 
    {
        ResultDTO Add(TarjetaPersistenciaDTO entidad, string user);
        ResultDTO Update(TarjetaPersistenciaDTO entidad, string user);
        ResultDTO Delete(TarjetaDeleteDTO deleteDTO, string user);

        // ================================================================= //

        ResultDTO GetById(Guid id);
        ResultDTO GetByFilter(TarjetaFilterDTO filter);
        ResultDTO GetAll(Guid empresaId);
        ResultDTO GetAll();
    }
}
