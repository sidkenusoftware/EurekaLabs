namespace Sidkenu.LogicaNegocio.Servicios.DTOs.Core.Caja
{
    public class CajaCerrarDTO
    {
        public Guid Id { get; set; }
        public Guid PersonaCierreId { get; set; }
        public decimal MontoCierre { get; set; }
        public decimal MontoProximoTurno { get; set; }

        // ------------------------------------------ //

        public decimal MontoSistema { get; set; }
        public decimal Diferencia { get; set; }

        // ------------------------------------------ //

        public bool EstaPorTransferirDinero { get; set; }

        public decimal MontoTransferir { get; set; }

        public Guid EmpresaId { get; set; }

        public Guid CajaDetalleId { get; set; }
    }
}
