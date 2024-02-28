using Sidkenu.LogicaNegocio.Servicios.DTOs.Base;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.CuentaCorrienteCliente;

namespace Sidkenu.LogicaNegocio.Servicios.Interface.Core
{
    public interface ICuentaCorrienteClienteServicio
    {
        ResultDTO GetByCliente(Guid clienteId);

        ResultDTO Add(CtaCteClientePersistenciaDTO ctaCteCliente, string user);
    }
}
