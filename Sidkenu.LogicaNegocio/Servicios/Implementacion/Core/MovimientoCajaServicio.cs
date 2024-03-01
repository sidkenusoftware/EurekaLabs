using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Sidkenu.AccesoDatos.Constantes;
using Sidkenu.AccesoDatos.Constantes.Enum;
using Sidkenu.AccesoDatos.Entidades.Core;
using Sidkenu.AccesoDatos.Infraestructura;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Base;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.Movimiento;
using Sidkenu.LogicaNegocio.Servicios.Implementacion.Base;
using Sidkenu.LogicaNegocio.Servicios.Interface.Core;
using Sidkenu.LogicaNegocio.Servicios.Interface.Seguridad;
using System.Linq.Expressions;

namespace Sidkenu.LogicaNegocio.Servicios.Implementacion.Core
{
    public class MovimientoCajaServicio : ServicioBase, IMovimientoCajaServicio
    {
        public MovimientoCajaServicio(IMapper mapper,
                                      IConfiguracionServicio configuracionServicio)
                                      : base(mapper, configuracionServicio)
        {
        }

        public ResultDTO ObtenerMovimientos(Guid? cajaDetalleId, DateTime fechaDesde, DateTime fechaHasta)
        {
            using var _context = new DataContext();

            // using var transaction = _context.Database.BeginTransaction();

            var _esPrimeraPasada = true;

            try
            {
                var _fechaDesde = new DateTime(fechaDesde.Year, fechaDesde.Month, fechaDesde.Day, 0, 0, 0);
                var _fechaHasta = new DateTime(fechaHasta.Year, fechaHasta.Month, fechaHasta.Day, 23, 59, 59);

                Expression<Func<MovimientoCaja, bool>> filtro = filtro => true;

                filtro = filtro.And(x => x.Fecha >= _fechaDesde && x.Fecha <= _fechaHasta);

                filtro = filtro.And(x => x.TipoOperacion != TipoOperacionMovimiento.PendienteDePago);

                if (cajaDetalleId.HasValue)
                {
                    filtro = filtro.And(x => x.CajaDetalleId == cajaDetalleId.Value);

                    var movimientos = _context.MovimientoCajas
                        .AsNoTracking()
                        .Include(z => z.CajaDetalle)
                        .Where(filtro)
                        .OrderByDescending(i => i.Fecha)
                        .ToList();

                    return new ResultDTO
                    {
                        State = true,
                        Data = _mapper.Map<IEnumerable<MovimientoCajaDTO>>(movimientos)
                    };
                }
                else
                {
                    return new ResultDTO
                    {
                        State = true,
                        Data = new List<MovimientoCajaDTO>()
                    };
                }
            }
            catch (Exception ex)
            {
                return new ResultDTO
                {
                    Message = ex.Message,
                    State = false
                };
            }
        }
    }
}
