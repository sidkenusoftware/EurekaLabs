using Sidkenu.AccesoDatos.Constantes.Enum;
using Sidkenu.AccesoDatos.Entidades.Base;
using Sidkenu.AccesoDatos.Entidades.Seguridad;

namespace Sidkenu.AccesoDatos.Entidades.Core
{
    public class CajaDetalle : EntidadBase
    {
        // Propiedades
        public Guid CajaId { get; set; }

        public decimal MontoApertura { get; set; }
        public DateTime FechaApertura { get; set; }
        public Guid PersonaAperturaId { get; set; }

        public decimal? MontoCierre { get; set; }
        public DateTime? FechaCierre { get; set; }
        public Guid? PersonaCierreId { get; set; }

        public decimal? MontoSistema { get; set; }
        public decimal? Diferencia { get; set; }
        public EstadoCaja EstadoCaja { get; set; }

        // Propiedades de Navegacion
        public virtual Persona PersonaApertura { get; set; }
        public virtual Persona PersonaCierre { get; set; }
        public virtual Caja Caja { get; set; }
        public virtual List<MovimientoCaja> Movimientos { get; set; }
    }
}
