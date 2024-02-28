using Sidkenu.LogicaNegocio.Servicios.DTOs.Base;

namespace Sidkenu.LogicaNegocio.Servicios.DTOs.Core.Gasto
{
    public class GastosPersistenciaDTO : EntidadBaseDTO
    {
        public Guid EmpresaId { get; set; }
        public Guid CajaDetalleId { get; set; }
        public Guid CajaId { get; set; }
        public Guid TipoGastoId { get; set; }
        public Guid PersonaId { get; set; }

        public DateTime Fecha { get; set; }
        public decimal Monto { get; set; }
        public string Descripcion { get; set; }
    }
}
