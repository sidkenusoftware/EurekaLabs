using Sidkenu.LogicaNegocio.Servicios.DTOs.Base;

namespace Sidkenu.LogicaNegocio.Servicios.DTOs.Core.Caja
{
    public class CajaDTO : EntidadBaseDTO
    {
        public Guid EmpresaId { get; set; }
        public string Abreviatura { get; set; }
        public string Descripcion { get; set; }
        public bool PermiteGastos { get; set; }
        public bool PermitePagosProveedor { get; set; }
        public bool EstaAbierta { get; set; }
        
        public Guid? CajaDetalleId { get; set; }

        public DateTime? FechaApertura { get; set; }
        public string? UserApertura { get; set; }
        public decimal? MontoApertura { get; set; }

        public DateTime? FechaCierre { get; set; }
        public string? UserCierre { get; set; }
        public decimal? MontoCierre { get; set; }

        public bool AceptaMedioPagoEfectivo { get; set; }
        public bool AceptaMedioPagoCheque { get; set; }
        public bool AceptaMedioPagoTarjeta { get; set; }
        public bool AceptaMedioPagoTransferencia { get; set; }
        public bool AceptaMedioPagoCtaCte { get; set; }

        public decimal TotalIngreso { get; set; }
        public decimal TotalEgreso { get; set; }
    }
}
