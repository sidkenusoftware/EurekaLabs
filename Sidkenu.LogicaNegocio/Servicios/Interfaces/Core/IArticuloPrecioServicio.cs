using Sidkenu.AccesoDatos.Entidades.Core;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Base;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.ArticuloPrecio;

namespace Sidkenu.LogicaNegocio.Servicios.Interface.Core
{
    public interface IArticuloPrecioServicio
    {
        ResultDTO AddOrUpdate(ArticuloPrecioPersistenciaDTO articuloPrecioDTO, string user);

        ResultDTO AddOrUpdate(ArticuloPrecioPersistenciaDTO articuloPrecioDTO, Articulo articuloNuevo, string user);
    }
}
