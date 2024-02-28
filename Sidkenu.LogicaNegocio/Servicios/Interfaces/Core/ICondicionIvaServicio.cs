using Sidkenu.LogicaNegocio.Servicios.DTOs.Base;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.CondicionIva;

namespace Sidkenu.LogicaNegocio.Servicios.Interface.Core
{
    public interface ICondicionIvaServicio
    {
        ResultDTO Add(CondicionIvaPersistenciaDTO entidad, string user);
        ResultDTO Update(CondicionIvaPersistenciaDTO entidad, string user);
        ResultDTO Delete(CondicionIvaDeleteDTO deleteDTO, string user);

        // ================================================================= //

        ResultDTO GetById(Guid id);
        ResultDTO GetByFilter(CondicionIvaFilterDTO filter);
        ResultDTO GetAll(Guid empresaId);
        ResultDTO GetAll();
    }
}
