using Sidkenu.LogicaNegocio.Servicios.DTOs.Base;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.Marca;

namespace Sidkenu.LogicaNegocio.Servicios.Interface.Core
{
    public interface IMarcaServicio
    {
        ResultDTO Add(MarcaPersistenciaDTO entidad, string user);
        ResultDTO Update(MarcaPersistenciaDTO entidad, bool actualizarPrecio,  string user);
        ResultDTO Delete(MarcaDeleteDTO deleteDTO, string user);

        // ================================================================= //

        ResultDTO GetById(Guid id);
        ResultDTO GetByFilter(MarcaFilterDTO filter);
        ResultDTO GetAll(Guid empresaId);
        ResultDTO GetAll();
    }
}
