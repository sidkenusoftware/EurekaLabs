using Sidkenu.LogicaNegocio.Servicios.DTOs.Base;

namespace Sidkenu.LogicaNegocio.Servicios.DTOs.Seguridad.PuestoTrabajo
{
    public class PuestoTrabajoPersistenciaDTO : EntidadBaseDTO
    {
        public Guid EmpresaId { get; set; }
        public string Descripcion { get; set; }
        public string SerialNumber { get; set; }
    }
}
