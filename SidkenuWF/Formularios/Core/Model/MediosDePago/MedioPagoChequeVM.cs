namespace SidkenuWF.Formularios.Core.Model.MediosDePago
{
    public class MedioPagoChequeVM : MedioPagoVM
    {
        public string NumeroCheque { get; set; }

        public Guid BancoId { get; set; }

        public DateTime FechaVencimiento { get; set; }
    }
}
