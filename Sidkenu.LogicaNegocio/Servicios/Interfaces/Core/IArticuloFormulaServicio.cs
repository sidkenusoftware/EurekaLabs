using Sidkenu.LogicaNegocio.Servicios.DTOs.Base;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.ArticuloFormula;

namespace Sidkenu.LogicaNegocio.Servicios.Interface.Core
{
    public interface IArticuloFormulaServicio
    {
        ResultDTO Add(ArticuloFormulaPersistenciaDTO articuloKit, string user);
    }
}
