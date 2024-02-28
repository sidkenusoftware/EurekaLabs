using Sidkenu.LogicaNegocio.Servicios.DTOs.Base;

namespace Sidkenu.LogicaNegocio.Servicios.DTOs.Seguridad.Grupo
{
    public class GrupoDTO : EntidadBaseDTO
    {
        public Guid EmpresaId { get; set; }

        public string Empresa { get; set; }

        public string Descripcion { get; set; }

        public bool PorDefecto { get; set; }
    }
}
