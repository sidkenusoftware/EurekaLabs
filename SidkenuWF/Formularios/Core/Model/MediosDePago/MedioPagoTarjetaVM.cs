namespace SidkenuWF.Formularios.Core.Model.MediosDePago
{
    public class MedioPagoTarjetaVM : MedioPagoVM
    {
        public Guid PlanTarjetaId { get; set; }
        public string NumeroCupon { get; set; }
    }
}
