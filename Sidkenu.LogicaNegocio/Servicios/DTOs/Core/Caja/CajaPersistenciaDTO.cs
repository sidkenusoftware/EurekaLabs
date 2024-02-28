using Sidkenu.LogicaNegocio.Servicios.DTOs.Base;

namespace Sidkenu.LogicaNegocio.Servicios.DTOs.Core.Caja
{
    public class CajaPersistenciaDTO : EntidadBaseDTO
    {
        public Guid EmpresaId { get; set; }
        public string Abreviatura { get; set; }
        public string Descripcion { get; set; }
        public bool PermiteGastos { get; set; }
        public bool PermitePagosProveedor { get; set; }

        public bool AceptaMedioPagoEfectivo { get; set; }
        public bool AceptaMedioPagoCheque { get; set; }
        public bool AceptaMedioPagoTarjeta { get; set; }
        public bool AceptaMedioPagoTransferencia { get; set; }
        public bool AceptaMedioPagoCtaCte { get; set; }
    }
}
