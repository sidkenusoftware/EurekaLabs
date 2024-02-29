using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Sidkenu.AccesoDatos.Entidades.Core;
using Sidkenu.Infraestructura;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Base;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.Pedido;
using Sidkenu.LogicaNegocio.Servicios.Implementacion.Base;
using Sidkenu.LogicaNegocio.Servicios.Interface.Core;
using Sidkenu.LogicaNegocio.Servicios.Interface.Seguridad;
using System.Linq.Expressions;
using Sidkenu.AccesoDatos.Constantes;
using System.Transactions;

namespace Sidkenu.LogicaNegocio.Servicios.Implementacion.Core
{
    public class PedidoServicio : ServicioBase, IPedidoServicio
    {
        public PedidoServicio(IMapper mapper,
                              IConfiguracionServicio configuracionServicio)
                              : base(mapper, configuracionServicio)
        {

        }

        public ResultDTO Add(PedidoPersistenciaDTO entidad, string user)
        {
            using var _context = new DataContext();

            try
            {
                var existeEntidad = VerificarSiExiste(entidad.Numero, entidad.EmpresaId);

                if (existeEntidad)
                    return new ResultDTO
                    {
                        Message = "Los datos ingresados ya existen",
                        State = false,
                    };

                var entity = _mapper.Map<Pedido>(entidad);

                entity.User = user;
                entity.EstaEliminado = false;
                entity.Detalles = new List<PedidoDetalle>();

                foreach (var detalleDto in entidad.Detalles.ToList())
                {
                    var entityDetalle = _mapper.Map<PedidoDetalle>(detalleDto);

                    entityDetalle.User = user;
                    entityDetalle.EstaEliminado = false;

                    entity.Detalles.Add(entityDetalle);
                }

                _context.Pedidos.Add(entity);

                _context.SaveChanges();

                return new ResultDTO
                {
                    State = true,
                    Message = "Los datos se grabaron correctamente",
                    Data = entity
                };
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


        public ResultDTO GetAll()
        {
            using var _context = new DataContext();

            // using var transaction = _context.Database.BeginTransaction();

            try
            {
                var entities = _context.Pedidos
                    .AsNoTracking()
                    .Include(z => z.Proveedor)
                    .Include(z => z.Detalles).ThenInclude(a => a.Articulo)
                    .ToList();

                return new ResultDTO
                {
                    State = true,
                    Data = _mapper.Map<IEnumerable<PedidoDTO>>(entities)
                };
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

        public ResultDTO GetAll(Guid empresaId)
        {
            using var _context = new DataContext();

            // using var transaction = _context.Database.BeginTransaction();

            try
            {
                Expression<Func<Pedido, bool>> filtro = filtro => true;

                filtro = filtro.And(x => x.EmpresaId == empresaId || x.EmpresaId == null);

                var entities = _context.Pedidos
                    .AsNoTracking()
                    .Include(z => z.Proveedor)
                    .Include(z => z.Detalles).ThenInclude(a => a.Articulo)
                    .Where(filtro)
                    .ToList();

                return new ResultDTO
                {
                    State = true,
                    Data = _mapper.Map<IEnumerable<PedidoDTO>>(entities)
                };
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

        public ResultDTO GetByFilter(PedidoFilterDTO filter)
        {
            using var _context = new DataContext();

            // using var transaction = _context.Database.BeginTransaction();

            try
            {
                filter.CadenaBuscar = !string.IsNullOrEmpty(filter.CadenaBuscar) ? filter.CadenaBuscar : string.Empty;

                int _numeroPedido = 0;

                int.TryParse(filter.CadenaBuscar, out _numeroPedido);

                Expression<Func<Pedido, bool>> filtro = filtro => true;

                filtro = filtro.And(x => x.EmpresaId == filter.EmpresaId || x.EmpresaId == null);

                filtro = filtro.And(x => x.EstaEliminado == filter.VerEliminados
                                    && (x.Numero == _numeroPedido
                                    || x.Proveedor.RazonSocial.ToLower() == filter.CadenaBuscar.ToLower()
                                    || x.Proveedor.CUIT == filter.CadenaBuscar));

                var entities = _context.Pedidos
                    .AsNoTracking()
                    .Include(z => z.Proveedor)
                    .Include(z => z.Detalles).ThenInclude(a => a.Articulo)
                    .Where(filtro)
                    .ToList();

                return new ResultDTO
                {
                    State = true,
                    Data = _mapper.Map<IEnumerable<PedidoDTO>>(entities)
                };
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

        public ResultDTO GetById(Guid id)
        {
            using var _context = new DataContext();

            // using var transaction = _context.Database.BeginTransaction();

            try
            {
                var entity = _context.Pedidos
                    .AsNoTracking()
                    .Include(z => z.Proveedor)
                    .Include(z => z.Detalles).ThenInclude(a => a.Articulo)
                    .FirstOrDefault(x => x.Id == id);

                if (entity == null)
                {
                    return new ResultDTO
                    {
                        State = false,
                        Message = "No se encontro el dato solicitado"
                    };
                }

                return new ResultDTO
                {
                    State = true,
                    Data = _mapper.Map<PedidoDTO>(entity)
                };
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

        // ------------------------------------------------------------------------------------------------------ //
        // ------------------------------             Metodos Privados              ----------------------------- //
        // ------------------------------------------------------------------------------------------------------ //
        private bool VerificarSiExiste(int numero, Guid? empresaId, Guid? id = null)
        {
            using var _context = new DataContext();

            // using var transaction = _context.Database.BeginTransaction();

            if (id == null)
            {
                if (empresaId.HasValue)
                {
                    return _context.Pedidos.Any(x => x.EmpresaId == empresaId.Value && x.Numero == numero);
                }
                else
                {
                    return _context.Pedidos.Any(x => x.Numero == numero);
                }
            }
            else
            {
                if (empresaId.HasValue)
                {
                    return _context.Pedidos.Any(x => x.Id != id.Value
                        && x.EmpresaId == empresaId
                        && x.Numero == numero);
                }
                else
                {
                    return _context.Pedidos.Any(x => x.Id != id.Value
                        && x.Numero == numero);
                }
            }
        }
    }
}
