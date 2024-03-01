using Sidkenu.LogicaNegocio.Servicios.DTOs.Base;

namespace Sidkenu.LogicaNegocio.Servicios.DTOs.Seguridad.Modulo
{
    public class ModuloDTO : EntidadBaseDTO
    {
        public Guid EmpresaId { get; set; }

        public bool Seguridad { get; set; }

        public bool Venta { get; set; }

        public bool Compra { get; set; }

        public bool Inventario { get; set; }

        public bool Fabricacion { get; set; }

        public bool PuntoVenta { get; set; }

        public bool Caja { get; set; }

        public bool Dashboard { get; set; }
    }
}
