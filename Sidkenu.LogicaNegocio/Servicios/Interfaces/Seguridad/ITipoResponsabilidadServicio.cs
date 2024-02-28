using Sidkenu.LogicaNegocio.Servicios.DTOs.Base;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Seguridad.TipoResponsabilidad;

namespace Sidkenu.LogicaNegocio.Servicios.Interface.Seguridad
{
    public interface ITipoResponsabilidadServicio
    {
        ResultDTO Add(TipoResponsabilidadPersistenciaDTO entidad, string user);
        ResultDTO Update(TipoResponsabilidadPersistenciaDTO entidad, string user);
        ResultDTO Delete(TipoResponsabilidadDeleteDTO deleteDTO, string user);

        // ================================================================= //

        ResultDTO GetById(Guid id);
        ResultDTO GetByFilter(TipoResponsabilidadFilterDTO filter);
        ResultDTO GetAll();
    }
}
