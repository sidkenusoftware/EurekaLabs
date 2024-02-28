using Sidkenu.LogicaNegocio.Servicios.DTOs.Base;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.ArticuloKit;

namespace Sidkenu.LogicaNegocio.Servicios.Interface.Core
{
    public interface IArticuloKitServicio
    {
        ResultDTO Add(ArticuloKitPersistenciaDTO articuloKit, string user);
    }
}
