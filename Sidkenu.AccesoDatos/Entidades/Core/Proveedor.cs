using Sidkenu.AccesoDatos.Entidades.Base;
using Sidkenu.AccesoDatos.Entidades.Seguridad;

namespace Sidkenu.AccesoDatos.Entidades.Core
{
    public class Proveedor : EntidadBase
    {
        // Propiedades
        public Guid? EmpresaId { get; set; }
        public Guid TipoResponsabilidadId { get; set; }

        public string Codigo { get; set; }

        public string RazonSocial { get; set; }

        public string CUIT { get; set; }

        public string Direccion { get; set; }

        public string Telefono { get; set; }

        public string Contacto { get; set; }

        public string Mail { get; set; }

        public bool ActivarCuentaCorriente { get; set; }


        // Propiedades de Navegacion
        public virtual Empresa Empresa { get; set; }
        public virtual TipoResponsabilidad TipoResponsabilidad { get; set; }
        public virtual List<ComprobanteCompra> ComprobantesCompras { get; set; }
        public virtual List<ArticuloProveedor> ArticuloProveedores { get; set; }
    }
}
