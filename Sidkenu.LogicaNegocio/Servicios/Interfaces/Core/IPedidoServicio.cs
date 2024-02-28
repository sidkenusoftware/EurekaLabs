using Sidkenu.LogicaNegocio.Servicios.DTOs.Base;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.Pedido;

namespace Sidkenu.LogicaNegocio.Servicios.Interface.Core
{
    public interface IPedidoServicio
    {
        ResultDTO Add(PedidoPersistenciaDTO entidad, string user);

        // ================================================================= //

        ResultDTO GetById(Guid id);
        ResultDTO GetByFilter(PedidoFilterDTO filter);
        ResultDTO GetAll(Guid empresaId);
        ResultDTO GetAll();
    }
}
