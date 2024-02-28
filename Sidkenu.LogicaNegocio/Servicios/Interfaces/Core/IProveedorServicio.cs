using Sidkenu.LogicaNegocio.Servicios.DTOs.Base;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.Proveedor;

namespace Sidkenu.LogicaNegocio.Servicios.Interface.Core
{
    public interface IProveedorServicio
    {
        ResultDTO Add(ProveedorPersistenciaDTO entidad, string user);
        ResultDTO Update(ProveedorPersistenciaDTO entidad, string user);
        ResultDTO Delete(ProveedorDeleteDTO deleteDTO, string user);

        // ================================================================= //

        ResultDTO GetById(Guid id);
        ResultDTO GetByFilter(ProveedorFilterDTO filter);
        ResultDTO GetAll(Guid empresaId);
        ResultDTO GetAll();
    }
}
