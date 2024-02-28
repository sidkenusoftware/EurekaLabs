using Sidkenu.LogicaNegocio.Servicios.DTOs.Base;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.MotivoBaja;

namespace Sidkenu.LogicaNegocio.Servicios.Interface.Core
{
    public interface IMotivoBajaServicio
    {
        ResultDTO Add(MotivoBajaPersistenciaDTO entidad, string user);
        ResultDTO Update(MotivoBajaPersistenciaDTO entidad, string user);
        ResultDTO Delete(MotivoBajaDeleteDTO deleteDTO, string user);

        // ================================================================= //

        ResultDTO GetById(Guid id);
        ResultDTO GetByFilter(MotivoBajaFilterDTO filter);
        ResultDTO GetAll(Guid empresaId);
        ResultDTO GetAll();

    }
}
