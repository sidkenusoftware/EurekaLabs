using Sidkenu.LogicaNegocio.Servicios.DTOs.Base;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Seguridad.PuestoTrabajo;

namespace Sidkenu.LogicaNegocio.Servicios.Interface.Seguridad
{
    public interface IPuestoTrabajoServicio
    {
        ResultDTO Add(PuestoTrabajoPersistenciaDTO entidad, string user);
        ResultDTO Update(PuestoTrabajoPersistenciaDTO entidad, string user);
        ResultDTO Delete(PuestoTrabajoDeleteDTO deleteDTO, string user);

        // ================================================================= //

        ResultDTO GetById(Guid id);
        ResultDTO GetByFilter(PuestoTrabajoFilterDTO filter);
        ResultDTO GetAll();
        ResultDTO GetByNumeroSerie(string numeroSerie, Guid empresaId);
    }
}
