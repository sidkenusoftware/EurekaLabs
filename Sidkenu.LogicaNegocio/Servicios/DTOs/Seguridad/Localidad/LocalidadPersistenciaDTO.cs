using Sidkenu.LogicaNegocio.Servicios.DTOs.Base;

namespace Sidkenu.LogicaNegocio.Servicios.DTOs.Seguridad.Localidad
{
    public class LocalidadPersistenciaDTO : EntidadBaseDTO
    {
        public Guid ProvinciaId { get; set; }
        public string Descripcion { get; set; }
    }
}
