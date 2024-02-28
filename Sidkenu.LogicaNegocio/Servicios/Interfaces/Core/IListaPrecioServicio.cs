using Sidkenu.LogicaNegocio.Servicios.DTOs.Base;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.ListaPrecio;

namespace Sidkenu.LogicaNegocio.Servicios.Interface.Core
{
    public interface IListaPrecioServicio
    {
        ResultDTO Add(ListaPrecioPersistenciaDTO entidad, string user);
        ResultDTO Update(ListaPrecioPersistenciaDTO entidad, string user);
        ResultDTO Delete(ListaPrecioDeleteDTO deleteDTO, string user);

        // ================================================================= //

        ResultDTO GetById(Guid id);
        ResultDTO GetByFilter(ListaPrecioFilterDTO filter);
        ResultDTO GetAll(Guid empresaId);
        ResultDTO GetAll();
    }
}
