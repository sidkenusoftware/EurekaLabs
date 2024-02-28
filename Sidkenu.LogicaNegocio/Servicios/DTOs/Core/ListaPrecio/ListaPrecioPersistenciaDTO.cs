using Sidkenu.LogicaNegocio.Servicios.DTOs.Base;

namespace Sidkenu.LogicaNegocio.Servicios.DTOs.Core.ListaPrecio
{
    public class ListaPrecioPersistenciaDTO : EntidadBaseDTO
    {
        public Guid EmpresaId { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }

        public decimal Rentabilidad { get; set; }
    }
}
