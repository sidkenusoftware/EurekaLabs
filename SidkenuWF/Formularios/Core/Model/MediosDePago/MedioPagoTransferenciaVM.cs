namespace SidkenuWF.Formularios.Core.Model.MediosDePago
{
    public class MedioPagoTransferenciaVM : MedioPagoVM
    {
        public Guid BancoId { get; set; }
        public string NumeroTransferencia { get; set; }
        public string NombreTitular { get; set; }
    }
}
