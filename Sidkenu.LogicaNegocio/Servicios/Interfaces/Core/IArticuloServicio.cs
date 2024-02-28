using Sidkenu.AccesoDatos.Constantes.Enum;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Base;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.Articulo;

namespace Sidkenu.LogicaNegocio.Servicios.Interface.Core
{
    public interface IArticuloServicio
    {
        ResultDTO GetByFilter(ArticuloFilterDTO filter);
        ResultDTO GetByFilterLookUp(ArticuloFilterDTO filter);
        ResultDTO GetByFilterLookUp(ArticuloFilterDTO filter, List<TipoArticulo> tipos);
        ResultDTO GetById(Guid id, Guid empresaId);
        ResultDTO GetById(Guid id, Guid empresaId, Guid depositoId);

        ResultDTO GetByIds(List<Guid> ids, Guid empresaId);

        ResultDTO GetByIds(List<Guid> ids, Guid empresaId, Guid depositoId);
        ResultDTO GetAll(Guid empresaId);
        ResultDTO GetAll();

        //// ================================================================= //

        ResultDTO Add(ArticuloPersistenciaDTO entidad, string user);
        ResultDTO Update(ArticuloPersistenciaDTO entidad, string user);
        ResultDTO Delete(ArticuloDeleteDTO deleteDTO, string user);

        //// ================================================================= //

        ResultDTO GetByIdPivot(Guid empresaId, Guid articuloId);

        //// ================================================================= //
        ///
        ResultDTO GetByCodigo(Guid listaPresioId, string codigo, Guid empresaId);

        ResultDTO GetByCodigoProveedor(Guid? proveedorId, string cadenaBuscar, Guid empresaId);
    }
}
