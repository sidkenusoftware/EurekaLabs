using Sidkenu.LogicaNegocio.Servicios.DTOs.Base;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.PlanTarjeta;

namespace Sidkenu.LogicaNegocio.Servicios.Interface.Core
{
    public interface IPlanTarjetaServicio
    {
        ResultDTO Add(PlanTarjetaPersistenciaDTO entidad, string user);
        ResultDTO Update(PlanTarjetaPersistenciaDTO entidad, string user);
        ResultDTO Delete(PlanTarjetaDeleteDTO deleteDTO, string user);

        // ================================================================= //

        ResultDTO GetById(Guid id);
        ResultDTO GetByFilter(PlanTarjetaFilterDTO filter);
        ResultDTO GetAll(Guid tarjetaId);
        ResultDTO GetAll();
    }
}
