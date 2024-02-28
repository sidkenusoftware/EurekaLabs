using Sidkenu.LogicaNegocio.Servicios.DTOs.Base;

namespace Sidkenu.LogicaNegocio.Servicios.DTOs.Seguridad.Localidad
{
    public class LocalidadDTO : EntidadBaseDTO
    {
        public Guid ProvinciaId { get; set; }
        public string Provincia { get; set; }
        public string Descripcion { get; set; }
    }
}
