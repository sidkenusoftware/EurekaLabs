using Sidkenu.AccesoDatos.Constantes.Enum;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Base;

namespace Sidkenu.LogicaNegocio.Servicios.DTOs.Core.CuentaCorrienteCliente
{
    public class CtaCteClienteDTO : EntidadBaseDTO
    {
        public Guid ClienteId { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime? FechaVencimiento { get; set; }
        public string NroComprobanteFactura { get; set; }
        public TipoMovimiento TipoMovimiento { get; set; }
        public decimal Monto { get; set; }
        public string? Observacion { get; set; }
    }
}
