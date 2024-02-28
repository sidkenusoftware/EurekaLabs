using Sidkenu.LogicaNegocio.Servicios.DTOs.Base;

namespace Sidkenu.LogicaNegocio.Servicios.DTOs.Seguridad.PuestoTrabajo
{
    public class PuestoTrabajoFilterDTO : FilterBaseDTO
    {
        public Guid EmpresaId { get; set; }
        public string CadenaBuscar { get; set; }
    }
}
