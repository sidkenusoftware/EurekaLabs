using Sidkenu.LogicaNegocio.Servicios.DTOs.Base;

namespace Sidkenu.LogicaNegocio.Servicios.DTOs.Seguridad.GrupoPersona
{
    public class GrupoPersonaFilterDTO : FilterBaseDTO
    {
        public Guid GrupoId { get; set; }
        public string? CadenaBuscar { get; set; } = null;
    }
}