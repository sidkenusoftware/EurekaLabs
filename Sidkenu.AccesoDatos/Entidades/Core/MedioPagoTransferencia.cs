namespace Sidkenu.AccesoDatos.Entidades.Core
{
    public class MedioPagoTransferencia : MedioPago
    {
        // Propiedades
        public Guid BancoId { get; set; }
        public string NumeroTransferencia { get; set; }
        public string NombreTitular { get; set; }


        // Propiedades de Navegacion
        public virtual Banco Banco { get; set; }
    }
}
