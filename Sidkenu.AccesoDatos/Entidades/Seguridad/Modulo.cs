using Sidkenu.AccesoDatos.Entidades.Base;

namespace Sidkenu.AccesoDatos.Entidades.Seguridad
{
    public class Modulo : EntidadBase
    {
        // Propiedades
        public Guid EmpresaId { get; set; }

        public bool Seguridad { get; set; }

        public bool Venta { get; set; }

        public bool Compra { get; set; }

        public bool Inventario { get; set; }

        public bool Fabricacion { get; set; }

        public bool PuntoVenta { get; set; }

        public bool Caja { get; set; }

        public bool Dashboard { get; set; }

        // Propiedades de Navegacion
        public Empresa Empresa { get; set; }
    }
}
