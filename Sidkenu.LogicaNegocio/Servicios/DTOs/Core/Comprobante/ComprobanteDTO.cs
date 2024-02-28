using Sidkenu.AccesoDatos.Constantes.Enum;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Base;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.Cliente;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.MedioPago;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Seguridad.Persona;

namespace Sidkenu.LogicaNegocio.Servicios.DTOs.Core.Comprobante
{
    public class ComprobanteDTO : EntidadBaseDTO
    {
        public ComprobanteDTO()
        {
            Detalles ??= new List<ComprobanteDetalleDTO>();
            MedioPagos ??= new List<MedioPagoDTO>();
        }

        public Guid EmpresaId { get; set; }
        public Guid CajaId { get; set; }
        public Guid CajaDetalleId { get; set; }

        public DateTime Fecha { get; set; }
        public ClienteDTO Cliente { get; set; }
        public bool ClienteEsConsumidorFinal { get; set; }
        public PersonaDTO Persona { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Descuento { get; set; }
        public decimal Total { get; set; }
        public bool EstaPagado { get; set; }
        

        public List<ComprobanteDetalleDTO> Detalles { get; set; }
        public List<MedioPagoDTO> MedioPagos { get; set;}
        public TipoComprobante TipoComprobante { get; set; }
        public EstadoComprobante EstadoComprobante { get; set; }

        public string Observacion { get; set; }

        public bool VieneDeCajaExterna { get; set; } = false;
    }
}
