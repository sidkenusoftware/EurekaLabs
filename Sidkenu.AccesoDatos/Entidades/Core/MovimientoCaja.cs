using Sidkenu.AccesoDatos.Entidades.Base;
using Sidkenu.AccesoDatos.Constantes.Enum;

namespace Sidkenu.AccesoDatos.Entidades.Core
{
    public class MovimientoCaja : EntidadBase
    {
        public Guid CajaDetalleId { get; set; }

        public Guid ComprobanteId { get; set; }

        public decimal Capital { get; set; }

        public decimal Interes { get; set; }

        public DateTime Fecha { get; set; }

        public TipoOperacionMovimiento TipoOperacion { get; set; }

        public string Descripcion { get; set; }

        public TipoMovimiento TipoMovimiento { get; set; }

        // Propiedades de Navegacion

        public CajaDetalle CajaDetalle { get; set; }

        public Comprobante Comprobante { get; set; }
    }
}
