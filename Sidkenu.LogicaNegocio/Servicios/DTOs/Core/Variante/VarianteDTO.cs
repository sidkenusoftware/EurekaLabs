using Sidkenu.LogicaNegocio.Servicios.DTOs.Base;

namespace Sidkenu.LogicaNegocio.Servicios.DTOs.Core.Variante
{
    public class VarianteDTO : EntidadBaseDTO
    {
        public VarianteDTO()
        {
            Valores ??= new List<ValorVarianteDTO> ();
        }

        // Propiedades
        public Guid? EmpresaId { get; set; }

        public string Codigo { get; set; }

        public string Descripcion { get; set; }

        public List<ValorVarianteDTO> Valores { get; set; }
    }
}
