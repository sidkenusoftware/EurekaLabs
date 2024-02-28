using Sidkenu.LogicaNegocio.Servicios.DTOs.Base;

namespace Sidkenu.LogicaNegocio.Servicios.DTOs.Core.PlanTarjeta
{
    public class PlanTarjetaDTO : EntidadBaseDTO
    {
        public Guid TarjetaId { get; set; }
        public string Tarjeta { get; set; }

        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public decimal Alicuota { get; set; }

        public string DescripcionCompleta => $"{Descripcion} - {AlicuotaStr}";        
        public string AlicuotaStr => $"{Alicuota.ToString("N2")} %";
    }
}
