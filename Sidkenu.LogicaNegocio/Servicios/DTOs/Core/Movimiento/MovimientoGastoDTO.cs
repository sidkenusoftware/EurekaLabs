using Sidkenu.LogicaNegocio.Servicios.DTOs.Base;

namespace Sidkenu.LogicaNegocio.Servicios.DTOs.Core.Movimiento
{
    public class MovimientoGastoDTO : EntidadBaseDTO
    {
        // Propiedades de Navegacion        
        public Guid GastoId { get; set; }
        public Guid TipoGastoId { get; set; }
        public Guid CajaDetalleId { get; set; }

        public string TipoGasto { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Monto { get; set; }
        public string Descripcion { get; set; }
    }
}