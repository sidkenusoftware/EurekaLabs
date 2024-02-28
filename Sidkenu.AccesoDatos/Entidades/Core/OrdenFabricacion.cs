using Sidkenu.AccesoDatos.Entidades.Base;
using Sidkenu.AccesoDatos.Entidades.Seguridad;
using Sidkenu.AccesoDatos.Constantes.Enum;

namespace Sidkenu.AccesoDatos.Entidades.Core
{
    public class OrdenFabricacion : EntidadBase
    {

        // Propiedades
        public Guid EmpresaId { get; set; }
        public Guid DepositoOrigenId { get; set; }
        public Guid DepositoDestinoId { get; set; }
        public Guid ArticuloBaseId { get; set; }


        public DateTime Fecha { get; set; }        
        public int Numero { get; set; }        
        public EstadoOrdenFabricacion EstadoOrdenFabricacion { get; set; }
        public bool ActulizarPrecioPublico { get; set; }
        public decimal CantidadFabricar { get; set; }
        public OrigenFabricacion OrigenFabricacion { get; set; }
        public DateTime? FechaFinalizacion { get; set; }

        public byte[] Foto { get; set; }

        // Propiedades de Navegación
        public Deposito DepositoOrigen { get; set; }
        public Deposito DepositoDestino { get; set; }
        public Empresa Empresa { get; set; }
        public List<OrdenFabricacionDetalle> OrdenFabricacionDetalles { get; set; }
        public ArticuloBase ArticuloBase { get; set; }
    }
}
