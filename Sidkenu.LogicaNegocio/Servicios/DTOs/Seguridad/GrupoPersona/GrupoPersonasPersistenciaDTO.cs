namespace Sidkenu.LogicaNegocio.Servicios.DTOs.Seguridad.GrupoPersona
{
    public class GrupoPersonasPersistenciaDTO
    {
        public Guid GrupoId { get; set; }

        public List<Guid> PersonaIds { get; set; }
    }
}
