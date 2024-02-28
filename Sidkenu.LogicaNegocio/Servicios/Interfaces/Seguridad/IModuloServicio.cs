using Sidkenu.LogicaNegocio.Servicios.DTOs.Base;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Seguridad.Modulo;

namespace Sidkenu.LogicaNegocio.Servicios.Interface.Seguridad
{
    public interface IModuloServicio
    {
        ResultDTO AddOrUpdate(ModuloPersistenciaDTO entidad, string user);

        ResultDTO Get(Guid empresaId);
    }
}
