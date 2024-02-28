namespace Sidkenu.LogicaNegocio.Servicios.DTOs.Core.MedioPago
{
    public class MedioPagoTransferenciaDTO : MedioPagoDTO
    {
        public Guid BancoId { get; set; }
        public string NumeroTransferencia { get; set; }
        public string NombreTitular { get; set; }
    }
}
