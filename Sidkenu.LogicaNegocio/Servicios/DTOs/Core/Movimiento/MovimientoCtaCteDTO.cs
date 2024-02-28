using Sidkenu.LogicaNegocio.Servicios.DTOs.Base;

namespace Sidkenu.LogicaNegocio.Servicios.DTOs.Core.Movimiento
{
    public class MovimientoCtaCteDTO : EntidadBaseDTO
    {
        // Propiedades de Navegacion
        public Guid CajaDetalleId { get; set; }
        public Guid CuentaCorrienteClienteId { get; set; }

        public string Cliente { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Monto { get; set; }
        public string Descripcion { get; set; }
    }
}
