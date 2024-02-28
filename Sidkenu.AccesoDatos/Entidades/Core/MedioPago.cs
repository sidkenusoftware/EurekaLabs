using Sidkenu.AccesoDatos.Entidades.Base;
using Sidkenu.AccesoDatos.Entidades.Seguridad;
using Sidkenu.AccesoDatos.Constantes.Enum;

namespace Sidkenu.AccesoDatos.Entidades.Core
{
    public class MedioPago : EntidadBase
    {
        // Propiedades
        public Guid EmpresaId { get; set; }
        public Guid ComprobanteId { get; set; }

        public TipoMedioDePago Tipo { get; set; }
        public decimal Capital { get; set; }
        public decimal Interes { get; set; }


        // Propiedades de Navegacion
        public virtual Empresa Empresa { get; set; }
        public virtual Comprobante Comprobante { get; set; }
    }
}
