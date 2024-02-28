namespace Sidkenu.AccesoDatos.Entidades.Core
{ 
    public class MedioPagoCheque : MedioPago
    {
        // Propiedades
        public Guid BancoId { get; set; }
        public string NumeroCheque { get; set; }
        public DateTime FechaVencimiento { get; set; }


        // Propiedades de Navegacion
        public virtual Banco Banco { get; set; }
    }
}
