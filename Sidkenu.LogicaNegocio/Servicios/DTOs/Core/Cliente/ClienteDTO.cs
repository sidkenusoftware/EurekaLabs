using Sidkenu.LogicaNegocio.Servicios.DTOs.Base;

namespace Sidkenu.LogicaNegocio.Servicios.DTOs.Core.Cliente
{
    public class ClienteDTO : EntidadBaseDTO
    {
        public Guid? EmpresaId { get; set; }

        public Guid? ListaPrecioId { get; set; }
        public string? ListaPrecio { get; set; }

        public Guid TipoResponsabilidadId { get; set; }
        public string TipoResponsabilidad { get; set; }

        public Guid TipoDocumentoId { get; set; }
        public string TipoDocumento { get; set; }

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
    }
}
