using Sidkenu.LogicaNegocio.Servicios.DTOs.Base;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Seguridad.Provincia;

namespace Sidkenu.LogicaNegocio.Servicios.Interface.Seguridad
{
    public interface IProvinciaServicio
    {
        ResultDTO Add(ProvinciaPersistenciaDTO entidad, string user);
        ResultDTO Update(ProvinciaPersistenciaDTO entidad, string user);
        ResultDTO Delete(ProvinciaDeleteDTO deleteDTO, string user);

        // ================================================================= //

        ResultDTO GetById(Guid id);
        ResultDTO GetByFilter(ProvinciaFilterDTO filter);
        ResultDTO GetAll();
    }
}
