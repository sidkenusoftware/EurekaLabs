using Sidkenu.LogicaNegocio.Servicios.DTOs.Base;

namespace Sidkenu.LogicaNegocio.Servicios.DTOs.Core.Articulo
{
    public class ArticuloBaseDTO : EntidadBaseDTO
    {
        // Propiedades
        public Guid? EmpresaId { get; set; }

        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public byte[] Foto { get; set; }

        public decimal PrecioPublico { get; set; }
    }
}
