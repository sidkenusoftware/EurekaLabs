using Sidkenu.LogicaNegocio.Servicios.DTOs.Base;

namespace Sidkenu.LogicaNegocio.Servicios.DTOs.Core.CostoFabricacion
{
    public class CostoFabricacionPersistenciaDTO : EntidadBaseDTO
    {
        public Guid? EmpresaId { get; set; }
        public string Descripcion { get; set; }
        public decimal Monto { get; set; }
    }
}
