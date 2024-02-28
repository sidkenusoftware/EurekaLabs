namespace Sidkenu.LogicaNegocio.Servicios.DTOs.Core.Caja
{
    public class CajaAperturaDTO
    {
        public Guid Id { get; set; }
        public Guid PersonaAperturaId { get; set; }
        public decimal Monto { get; set; }
    }
}
