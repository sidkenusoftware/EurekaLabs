using Sidkenu.AccesoDatos.Constantes.Enum;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Base;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.Deposito;

namespace Sidkenu.LogicaNegocio.Servicios.Interface.Core
{
    public interface IDepositoServicio
    {
        ResultDTO Add(DepositoPersistenciaDTO entidad, string user);
        ResultDTO Update(DepositoPersistenciaDTO entidad, string user);
        ResultDTO Delete(DepositoDeleteDTO deleteDTO, string user);

        // ================================================================= //

        ResultDTO GetById(Guid id);
        ResultDTO GetByFilter(DepositoFilterDTO filter);
        ResultDTO GetAll(Guid empresaId);
        ResultDTO GetAll();

        // ================================================================= //

        ResultDTO MarcarComoPredeterminado(Guid depositoId, Guid empresaId, TipoDeposito tipoDeposito);
    }
}
