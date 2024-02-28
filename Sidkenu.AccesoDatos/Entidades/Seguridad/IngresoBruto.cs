using Sidkenu.AccesoDatos.Entidades.Base;

namespace Sidkenu.AccesoDatos.Entidades.Seguridad
{
    public class IngresoBruto : EntidadBase
    {
        public string Descripcion { get; set; }

        public List<Empresa> Empresas { get; set; }
    }
}