using Sidkenu.LogicaNegocio.Servicios.DTOs.Base;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.Gasto;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.Movimiento;

namespace Sidkenu.LogicaNegocio.Servicios.DTOs.Core.Caja
{
    public class CajaDetalleDTO : EntidadBaseDTO
    {
        public CajaDetalleDTO()
        {
            MovimientosCtaCte ??= new List<MovimientoCtaCteDTO>();
            MovimientosGasto ??= new List<GastoDTO>();
            MovimientosProveedor ??= new List<MovimientoProveedorDTO>();

            Movimientos ??= new List<MovimientoCajaDTO>();
        }

        // Propiedades

        public Guid CajaId { get; set; }

        public decimal MontoApertura { get; set; }
        public DateTime FechaApertura { get; set; }
        public string PersonaApertura { get; set; }

        public decimal? MontoCierre { get; set; }
        public DateTime? FechaCierre { get; set; }
        public string? PersonaCierre { get; set; }

        public decimal? MontoSistema { get; set; }
        public decimal? Diferencia { get; set; }
        public string Estado { get; set; }

        // ================================================================== //

        public List<MovimientoCtaCteDTO> MovimientosCtaCte { get; set; }
        public List<GastoDTO> MovimientosGasto { get; set; }
        public List<MovimientoProveedorDTO> MovimientosProveedor { get; set; }

        public List<MovimientoCajaDTO> Movimientos { get; set; }
    }
}
