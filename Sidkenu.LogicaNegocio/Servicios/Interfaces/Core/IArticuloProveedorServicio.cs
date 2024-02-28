using Sidkenu.LogicaNegocio.Servicios.DTOs.Base;

namespace Sidkenu.LogicaNegocio.Servicios.Interface.Core
{
    public interface IArticuloProveedorServicio
    {
        ResultDTO GetAll(Guid? articuloId);

        ResultDTO GetArticulosSugeridos(Guid? proveedorId, Guid empresaId);
    }
}
