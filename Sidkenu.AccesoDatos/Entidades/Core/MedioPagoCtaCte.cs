namespace Sidkenu.AccesoDatos.Entidades.Core
{
    public class MedioPagoCtaCte : MedioPago
    {
        // Propiedades
        public Guid ClienteId { get; set; }


        // Propiedades de Navegacion
        public virtual Cliente Cliente { get; set; }
    }
}
