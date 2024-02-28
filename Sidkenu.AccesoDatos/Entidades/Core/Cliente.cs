using Sidkenu.AccesoDatos.Entidades.Base;
using Sidkenu.AccesoDatos.Entidades.Seguridad;

namespace Sidkenu.AccesoDatos.Entidades.Core
{
    public class Cliente : EntidadBase
    {
        // Propiedades

        public Guid? EmpresaId { get; set; }
        public Guid? ListaPrecioId { get; set; }
        public Guid TipoResponsabilidadId { get; set; }
        public Guid TipoDocumentoId { get; set; }

        public string RazonSocial { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Mail { get; set; }
        public string Documento { get; set; }

        public DateTime? FechaNacimiento { get; set; }

        public bool ActivarCuentaCorriente { get; set; }
        public decimal? MontoMaximoCompra { get; set; }

        public bool ActivarBonificacion { get; set; }
        public decimal? Bonificacion { get; set; }

        // Propiedades de Navegacion        
        public virtual Empresa Empresa { get; set; }
        public virtual TipoResponsabilidad TipoResponsabilidad { get; set; }
        public virtual TipoDocumento TipoDocumento { get; set; }
        public virtual ListaPrecio ListaPrecio { get; set; }

        public virtual List<CuentaCorrienteCliente> CuentaCorrienteClientes { get; set; }
        public virtual List<Comprobante> Comprobantes { get; set; }
        public virtual List<MedioPagoCtaCte> MedioPagos { get; set; }
    }
}
