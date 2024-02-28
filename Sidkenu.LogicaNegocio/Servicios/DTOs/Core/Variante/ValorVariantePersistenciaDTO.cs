using Sidkenu.LogicaNegocio.Servicios.DTOs.Base;

namespace Sidkenu.LogicaNegocio.Servicios.DTOs.Core.Variante
{
    public class ValorVariantePersistenciaDTO : EntidadBaseDTO
    {   
        public Guid VarianteId { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
    }
}
