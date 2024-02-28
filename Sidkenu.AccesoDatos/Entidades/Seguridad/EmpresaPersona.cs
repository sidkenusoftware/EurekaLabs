using Sidkenu.AccesoDatos.Entidades.Base;

namespace Sidkenu.AccesoDatos.Entidades.Seguridad
{
    public class EmpresaPersona : EntidadBase
    {
        // Propiedades
        public Guid PersonaId { get; set; }
        public Guid EmpresaId { get; set; }

        // Propiedades de Navegacion

        public Persona Persona { get; set; }
        public Empresa Empresa { get; set; }
    }
}
