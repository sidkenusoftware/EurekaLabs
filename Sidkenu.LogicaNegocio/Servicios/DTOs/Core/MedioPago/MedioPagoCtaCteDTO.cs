using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.Cliente;

namespace Sidkenu.LogicaNegocio.Servicios.DTOs.Core.MedioPago
{
    public class MedioPagoCtaCteDTO : MedioPagoDTO
    {
        public ClienteDTO Cliente { get; set; }
    }
}
