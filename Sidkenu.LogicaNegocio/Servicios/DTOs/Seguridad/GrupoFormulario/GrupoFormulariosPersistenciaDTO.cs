namespace Sidkenu.LogicaNegocio.Servicios.DTOs.Seguridad.GrupoFormulario
{
    public class GrupoFormulariosPersistenciaDTO
    {
        public Guid GrupoId { get; set; }

        public List<Guid> FormularioIds { get; set; }
    }
}
