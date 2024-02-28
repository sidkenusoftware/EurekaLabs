using Sidkenu.AccesoDatos.Constantes.Enum;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.OrdenFabricacion;

namespace SidkenuWF.Helpers
{
    public class CtrolOrdenFabricacionVM
    {
        public Guid Id { get; set; }
        public DateTime Fecha { get; set; }

        public string Descripcion { get; set; }
        public decimal CantidadProducir { get; set; }
        public List<OrdenFabricacionDetalleDTO> Detalles { get; set; }
        public int Numero { get; set; }

        public Guid DepositoOrigenId { get; set; }
        public string DepositoOrigen { get; set; }

        public Guid DepositoDestinoId { get; set; }
        public string DepositoDestino { get; set; }

        public Guid EmpresaId { get; set; }

        public Guid ArticuloBaseId { get; set; }
        public string ArticuloCodigo { get; set; }

        public EstadoOrdenFabricacion EstadoOrdenFabricacion { get; set; }

        public bool ActulizarPrecioPublico { get; set; }

        public bool SePuedeFabricar { get; set; }

        public OrigenFabricacion OrigenFabricacion { get; set; }
    }
}
