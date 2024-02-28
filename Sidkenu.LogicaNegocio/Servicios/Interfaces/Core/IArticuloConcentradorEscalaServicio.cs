using Sidkenu.LogicaNegocio.Servicios.DTOs.Base;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.ArticuloVariante;

namespace Sidkenu.LogicaNegocio.Servicios.Interface.Core
{
    public interface IArticuloVarianteServicio
    {
        ResultDTO Add(List<ArticuloVarianteValorPersistenciaDTO> listaVariantes, Guid empresaId, string user);
    }
}
