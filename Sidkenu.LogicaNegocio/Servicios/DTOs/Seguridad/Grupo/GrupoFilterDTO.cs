using Sidkenu.LogicaNegocio.Servicios.DTOs.Base;

namespace Sidkenu.LogicaNegocio.Servicios.DTOs.Seguridad.Grupo
{
    public class GrupoFilterDTO : FilterBaseDTO
    {
        public Guid EmpresaId { get; set; }
        public string CadenaBuscar { get; set; }
    }
}
