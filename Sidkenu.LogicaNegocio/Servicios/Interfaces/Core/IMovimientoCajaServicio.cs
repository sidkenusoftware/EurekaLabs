using Sidkenu.LogicaNegocio.Servicios.DTOs.Base;

namespace Sidkenu.LogicaNegocio.Servicios.Interface.Core
{
    public interface IMovimientoCajaServicio
    {
        ResultDTO ObtenerMovimientos(Guid? cajaDetalleId, DateTime fechaDesde, DateTime fechaHasta);
    }
}
