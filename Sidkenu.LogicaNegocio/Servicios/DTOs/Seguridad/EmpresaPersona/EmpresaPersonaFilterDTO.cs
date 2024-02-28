using Sidkenu.LogicaNegocio.Servicios.DTOs.Base;

namespace Sidkenu.LogicaNegocio.Servicios.DTOs.Seguridad.EmpresaPersona
{
    public class EmpresaPersonaFilterDTO : FilterBaseDTO
    {
        public Guid EmpresaId { get; set; }
        public string? CadenaBuscar { get; set; } = null;
    }
}