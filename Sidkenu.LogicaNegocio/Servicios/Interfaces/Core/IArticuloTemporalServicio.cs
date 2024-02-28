using Sidkenu.LogicaNegocio.Servicios.DTOs.Base;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.Articulo;

namespace Sidkenu.LogicaNegocio.Servicios.Interface.Core
{
    public interface IArticuloTemporalServicio
    {
        ResultDTO Add(ArticuloTemporalPersistenciaDTO entidad, string user);
        ResultDTO GetAll(Guid empresaId);
        ResultDTO GetByFilter(ArticuloFilterDTO filter);
        ResultDTO GetByFilterLookUp(ArticuloFilterDTO filter);
        ResultDTO GetById(Guid id, Guid empresaId);
    }
}
