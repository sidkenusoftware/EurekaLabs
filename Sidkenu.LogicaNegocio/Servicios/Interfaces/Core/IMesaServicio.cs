using Sidkenu.LogicaNegocio.Servicios.DTOs.Base;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.Mesa;

namespace Sidkenu.LogicaNegocio.Servicios.Interface.Core
{
    public interface IMesaServicio
    {
        ResultDTO Add(MesaPersistenciaDTO entidad, string user);
        ResultDTO Update(MesaPersistenciaDTO entidad, string user);
        ResultDTO Delete(MesaDeleteDTO deleteDTO, string user);

        // ================================================================= //

        ResultDTO GetById(Guid id);
        ResultDTO GetByFilter(MesaFilterDTO filter);
        ResultDTO GetAll(Guid empresaId);
        ResultDTO GetAll();
    }
}
