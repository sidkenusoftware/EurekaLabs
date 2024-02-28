using Sidkenu.LogicaNegocio.Servicios.DTOs.Base;

namespace Sidkenu.LogicaNegocio.Servicios.DTOs.Seguridad.GrupoFormulario
{
    public class GrupoFormularioFilterDTO : FilterBaseDTO
    {
        public Guid GrupoId { get; set; }
        public string? CadenaBuscar { get; set; } = null;
    }
}