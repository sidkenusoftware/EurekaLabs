using Sidkenu.AccesoDatos.Entidades.Base;
using Sidkenu.AccesoDatos.Constantes.Enum;

namespace Sidkenu.AccesoDatos.Entidades.Core
{
    public class CuentaCorrienteCliente : EntidadBase
    {
        // Propiedades
        public Guid ClienteId { get; set; }

        public DateTime Fecha { get; set; }
        public DateTime? FechaVencimiento { get; set; }
        public string NroComprobanteFactura { get; set; }
        public TipoMovimiento TipoMovimiento { get; set; }
        public decimal Monto { get; set; }
        public string? Observacion { get; set; }


        // Propiedades de Navegacion
        public virtual Cliente Cliente { get; set; }
    }
}
