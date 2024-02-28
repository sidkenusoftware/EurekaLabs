using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Sidkenu.AccesoDatos.Constantes;
using Sidkenu.AccesoDatos.Entidades.Core;
using Sidkenu.Infraestructura;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Base;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.Articulo;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.ArticuloProveedor;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.ConfiguracionCore;
using Sidkenu.LogicaNegocio.Servicios.Implementacion.Base;
using Sidkenu.LogicaNegocio.Servicios.Interface.Core;
using Sidkenu.LogicaNegocio.Servicios.Interface.Seguridad;
using System.Linq.Expressions;

namespace Sidkenu.LogicaNegocio.Servicios.Implementacion.Core
{
    public class ArticuloProveedorServicio : ServicioBase, IArticuloProveedorServicio
    {
        private readonly IConfiguracionCoreServicio _configuracionCoreServicio;

        public ArticuloProveedorServicio(IMapper mapper,
                                         IConfiguracionServicio configuracionServicio,
                                         IConfiguracionCoreServicio configuracionCoreServicio)
                                         : base(mapper, configuracionServicio)
        {
            _configuracionCoreServicio = configuracionCoreServicio;
        }

        public ResultDTO GetAll(Guid? articuloId)
        {
            using var _context = new DataContext();
            //using var transaction = _context.Database.BeginTransaction();

            if (articuloId.HasValue)
            {
                return new ResultDTO
                {
                    State = true,
                    Data = new List<ArticuloProveedorDTO>()
                };
            }

            try
            {
                var entities = _context.Articulos.AsNoTracking().ToList();

                return new ResultDTO
                {
                    State = true,
                    Data = _mapper.Map<IEnumerable<ArticuloProveedorDTO>>(entities)
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

        public ResultDTO GetArticulosSugeridos(Guid? proveedorId, Guid empresaId)
        {
            using var _context = new DataContext();
            //using var transaction = _context.Database.BeginTransaction();

            try
            {
                var _configCoreResult = _configuracionCoreServicio
                    .Get(empresaId);

                if (_configCoreResult == null || !_configCoreResult.State)
                {
                    return new ResultDTO
                    {
                        State = false,
                        Message = "Ocurrió un error al obtener la configuracion del Inventario"
                    };
                }

                var _configCore = (ConfiguracionCoreDTO)_configCoreResult.Data;

                Expression<Func<Articulo, bool>> filtro = filtro => true;

                filtro = filtro.And(x => x.EmpresaId == empresaId || !x.EmpresaId.HasValue);

                if (proveedorId.HasValue)
                {
                    filtro = filtro.And(x => x.ArticuloProveedores.Any(p => p.ProveedorId == proveedorId.Value));
                }

                filtro = filtro.And(x => x.ArticuloDepositos.Any(d => d.DepositoId == _configCore.DepositoPorDefectoParaCompraId));

                var articulos = _context.Articulos
                    .AsNoTracking()
                    .Include(p => p.ArticuloProveedores)
                    .Include(p => p.ArticuloDepositos)
                    .Where(filtro)
                    .ToList();
                    
                var listaArticulosSugeridos = new List<Articulo>();

                foreach (var articulo in articulos.ToList())
                {
                    if (articulo.ArticuloDepositos.First(x => x.DepositoId == _configCore.DepositoPorDefectoParaCompraId && !x.EstaEliminado).Cantidad
                        <= articulo.PuntoPedido)
                    {
                        listaArticulosSugeridos.Add(articulo);
                    }
                }

                return new ResultDTO
                {
                    State = true,
                    Data = _mapper.Map<IEnumerable<ArticuloDTO>>(listaArticulosSugeridos)
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
    }
}
