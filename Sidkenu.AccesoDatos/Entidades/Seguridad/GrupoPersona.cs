using Sidkenu.AccesoDatos.Entidades.Base;

namespace Sidkenu.AccesoDatos.Entidades.Seguridad
{
    public class GrupoPersona : EntidadBase
    {
        // Propiedades
        public Guid GrupoId { get; set; }
        public Guid PersonaId { get; set; }


        // Propiedades de Navegacion
        public Grupo Grupo { get; set; }
        public Persona Persona { get; set; }
    }
}
