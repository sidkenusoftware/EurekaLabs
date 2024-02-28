using Sidkenu.LogicaNegocio.Servicios.DTOs.Base;

namespace Sidkenu.LogicaNegocio.Servicios.DTOs.Core.CajaPuestoTrabajo
{
    public class CajaPuestoTrabajoFilterDTO : FilterBaseDTO
    {
        public Guid CajaId { get; set; }
        public string? CadenaBuscar { get; set; } = null;
    }
}