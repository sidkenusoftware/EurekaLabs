namespace Sidkenu.LogicaNegocio.Servicios.DTOs.Core.Caja
{
    public class CajaTransferenciaDTO
    {
        public Guid CajaOrigenId { get; set; }

        public Guid CajaDestinoId { get; set; }

        public Guid PersonaId { get; set; }

        public Guid EmpresaId { get; set; }

        public decimal Monto { get; set; }
    }
}
