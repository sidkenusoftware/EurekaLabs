using Sidkenu.LogicaNegocio.Servicios.DTOs.Base;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.Variante;

namespace Sidkenu.LogicaNegocio.Servicios.Interface.Core
{
    public interface IVarianteValorServicio
    {
        ResultDTO Add(ValorVariantePersistenciaDTO entidad, string user);
        ResultDTO Delete(ValorVarianteDeleteDTO deleteDTO, string user);
        ResultDTO GetAll(Guid escalaId);
    }
}
