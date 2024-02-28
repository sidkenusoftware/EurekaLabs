using Sidkenu.LogicaNegocio.Servicios.DTOs.Base;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Seguridad.Configuracion;

namespace Sidkenu.LogicaNegocio.Servicios.Interface.Seguridad
{
    public interface IConfiguracionServicio
    {
        ResultDTO AddOrUpdate(ConfiguracionPersistenciaDTO entidad, string user);

        ResultDTO Get();
    }
}
