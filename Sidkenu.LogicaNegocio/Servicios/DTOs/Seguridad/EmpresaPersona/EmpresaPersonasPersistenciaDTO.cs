namespace Sidkenu.LogicaNegocio.Servicios.DTOs.Seguridad.EmpresaPersona
{
    public class EmpresaPersonasPersistenciaDTO
    {
        public Guid EmpresaId { get; set; }

        public List<Guid> PersonaIds { get; set; }
    }
}
