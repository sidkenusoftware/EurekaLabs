using Sidkenu.LogicaNegocio.Servicios.DTOs.Base;

namespace Sidkenu.LogicaNegocio.Servicios.DTOs.Core.Mesa
{
    public class MesaFilterDTO : FilterBaseDTO
    {
        public Guid? SalonId { get; set; }
        public string? CadenaBuscar { get; set; } = null;
    }
}