using Sidkenu.LogicaNegocio.Servicios.DTOs.Base;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.Gasto;

namespace Sidkenu.LogicaNegocio.Servicios.Interface.Core
{
    public interface IGastosServicio
    {
        ResultDTO Add(GastosPersistenciaDTO entidad, string user);
    }
}
