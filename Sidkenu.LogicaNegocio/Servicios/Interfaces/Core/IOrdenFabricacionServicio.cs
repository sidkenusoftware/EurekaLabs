using Sidkenu.LogicaNegocio.Servicios.DTOs.Base;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.OrdenFabricacion;

namespace Sidkenu.LogicaNegocio.Servicios.Interface.Core
{
    public interface IOrdenFabricacionServicio
    {
        ResultDTO GetByFilter(OrdenFabricacionFilterDTO filter);

        ResultDTO Add(OrdenFabricacionPersistenciaDTO entidad, string user);

        ResultDTO CambiarEstadoEnProceso(Guid OrdenFabricacionId, string user);

        ResultDTO CancelarOrdenFabricacion(Guid OrdenFabricacionId, string user);

        ResultDTO FinalizarOrdenFabricacion(Guid OrdenFabricacionId, string user);
    }
}
