using Sidkenu.AccesoDatos.Entidades.Base;

namespace Sidkenu.AccesoDatos.Entidades.Seguridad
{
    public class Formulario : EntidadBase
    {
        // Propiedades
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public string DescripcionCompleta { get; set; }
        public bool EstaVigente { get; set; }

        // Propiedades de Navegacion
        public List<GrupoFormulario> GruposFormularios { get; set; }
    }
}
