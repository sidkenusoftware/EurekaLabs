using Sidkenu.LogicaNegocio.Servicios.DTOs.Base;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.Variante;

namespace Sidkenu.LogicaNegocio.Servicios.Interface.Core
{
    public interface IVarianteServicio
    {
        ResultDTO Add(VariantePersistenciaDTO entidad, string user);
        ResultDTO Update(VariantePersistenciaDTO entidad, string user);
        ResultDTO Delete(VarianteDeleteDTO deleteDTO, string user);

        // ================================================================= //

        ResultDTO GetById(Guid id);
        ResultDTO GetByFilter(VarianteFilterDTO filter);
        ResultDTO GetAll(Guid empresaId);
        ResultDTO GetAll();
    }
}
