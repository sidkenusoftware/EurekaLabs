using Sidkenu.LogicaNegocio.Servicios.DTOs.Base;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Seguridad.Localidad;

namespace Sidkenu.LogicaNegocio.Servicios.Interface.Seguridad
{
    public interface ILocalidadServicio
    {
        ResultDTO Add(LocalidadPersistenciaDTO entidad, string user);
        ResultDTO Update(LocalidadPersistenciaDTO entidad, string user);
        ResultDTO Delete(LocalidadDeleteDTO deleteDTO, string user);

        // ================================================================= //

        ResultDTO GetById(Guid id);
        ResultDTO GetByFilter(LocalidadFilterDTO filter);
        ResultDTO GetAll();
    }
}
