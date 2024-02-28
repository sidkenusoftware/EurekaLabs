using Sidkenu.LogicaNegocio.Servicios.DTOs.Base;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.ConfiguracionCore;

namespace Sidkenu.LogicaNegocio.Servicios.Interface.Core
{
    public interface IConfiguracionCoreServicio
    {
        ResultDTO AddOrUpdate(ConfiguracionCorePersistenciaDTO entidad, string userLogin);

        ResultDTO Get(Guid empresaId);
    }
}
