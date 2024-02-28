namespace Sidkenu.AccesoDatos.Entidades.Core
{
    public class MedioPagoTarjeta : MedioPago
    {
        // Propiedades
        public Guid PlanTarjetaId { get; set; }
        public string NumeroCupon { get; set; }


        // Propiedades de Navegacion
        public virtual PlanTarjeta PlanTarjeta { get; set; }
    }
}
