using Sidkenu.LogicaNegocio.Servicios.DTOs.Base;

namespace Sidkenu.LogicaNegocio.Servicios.DTOs.Seguridad.Localidad
{
    public class LocalidadFilterDTO : FilterBaseDTO
    {
        public Guid? ProvinciaId { get; set; }
        public string CadenaBuscar { get; set; }
    }
}
