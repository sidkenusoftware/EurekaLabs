using Sidkenu.AccesoDatos.Entidades.Base;
using Sidkenu.AccesoDatos.Entidades.Seguridad;

namespace Sidkenu.AccesoDatos.Entidades.Core
{
    public class Caja : EntidadBase
    {
        // Propiedades
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


        // Propiedades de Navegacion
        public virtual Empresa Empresa { get; set; }

        public virtual List<CajaDetalle> CajaDetalles { get; set; }

        public virtual List<FamiliaCaja> FamiliaCajas { get; set; }

        public virtual List<CajaPuestoTrabajo> Puestos { get; set; }
    }
}
