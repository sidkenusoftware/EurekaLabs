using Sidkenu.LogicaNegocio.Servicios.DTOs.Base;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.ConfiguracionBalanza;

namespace Sidkenu.LogicaNegocio.Servicios.Interface.Core
{
    public interface IConfiguracionBalanzaServicio
    {
        ResultDTO AddOrUpdate(ConfiguracionBalanzaPersistenciaDTO entidad, string userLogin);

        ResultDTO Get(Guid empresaId);
    }
}
