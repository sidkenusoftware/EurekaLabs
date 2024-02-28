using Sidkenu.AccesoDatos.Entidades.Base;

namespace Sidkenu.AccesoDatos.Entidades.Core
{
    public class PlanTarjeta : EntidadBase
    {
        // Propiedades
        public Guid TarjetaId { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public decimal Alicuota { get; set; }


        // Propiedades de Navegacion
        public virtual Tarjeta Tarjeta { get; set; }
        public virtual List<MedioPagoTarjeta> MedioPagos { get; set; }
    }
}