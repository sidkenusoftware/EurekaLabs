using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Sidkenu.AccesoDatos.Constantes;
using Sidkenu.AccesoDatos.Constantes.Enum;
using Sidkenu.AccesoDatos.Entidades.Core;
using Sidkenu.AccesoDatos.Infraestructura;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Base;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.Articulo;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.ArticuloPrecio;
using Sidkenu.LogicaNegocio.Servicios.Implementacion.Base;
using Sidkenu.LogicaNegocio.Servicios.Interface.Core;
using Sidkenu.LogicaNegocio.Servicios.Interface.Seguridad;
using System.Linq.Expressions;

namespace Sidkenu.LogicaNegocio.Servicios.Implementacion.Core
{
    public class ArticuloServicio : ServicioBase, IArticuloServicio
    {
        private readonly IArticuloPrecioServicio _articuloPrecioServicio;

        public ArticuloServicio(IMapper mapper,                                
                                IConfiguracionServicio configuracionServicio,
                                IArticuloPrecioServicio articuloPrecioServicio)
                                : base(mapper, configuracionServicio)
        {
            _articuloPrecioServicio = articuloPrecioServicio;
        }

        public ResultDTO Add(ArticuloPersistenciaDTO entidad, string user)
        {
            using var _context = new DataContext();

            try
            {
                // ======================================================================================================== //
                // ==================                            ADD ARTICULO                           =================== //
                // ======================================================================================================== //

                var _fechaActualizacion = DateTime.Now;

                var existeEntidad = VerificarSiExiste(entidad.Descripcion, entidad.EmpresaId);

                if (existeEntidad)
                    return new ResultDTO
                    {
                        Message = "Los datos ingresados ya existen",
                        State = false,
                    };

                var entity = _mapper.Map<Articulo>(entidad);

                entity.User = user;
                entity.EstaEliminado = false;
                entity.EmpresaId = entidad.SeleccionoEmpresa ? entidad.EmpresaId : null;
                entity.PrecioCosto = entidad.PrecioCostoInicial.HasValue ? entidad.PrecioCostoInicial.Value : 0;

                // Aplico la variante por defecto

                var _varianteValorDefault = _context.VarianteValores
                    .AsNoTracking()
                    .Where(x => x.Codigo.ToLower() == VarianteDefecto.VarianteValorCodigo)
                    .ToList();

                if (_varianteValorDefault == null || !_varianteValorDefault.Any())
                {
                    return new ResultDTO { State = false, Message = "Ocurrio un error al obtener la variante por defecto" };
                }

                entity.VarianteValorUnoId = _varianteValorDefault.First().Id;
                entity.VarianteValorDosId = _varianteValorDefault.First().Id;

                _context.Articulos.Add(entity);

                // ======================================================================================================== //
                // ==================                           ASIGNO A PROVEEDORES                    =================== //
                // ======================================================================================================== //

                if (entidad.ArticuloProveedores.Any())
                {
                    foreach (var articuloProveedor in entidad.ArticuloProveedores.ToList())
                    {
                        var _articuloProveedorNuevo = new ArticuloProveedor
                        {
                            ArticuloId = entity.Id,
                            ProveedorId = articuloProveedor.ProveedorId.Value,
                            CodigoProveedor = articuloProveedor.CodigoProveedor,
                            EstaEliminado = false,
                            User = user,
                        };

                        _context.ArticuloProveedores.Add(_articuloProveedorNuevo);
                    }
                }

                // ======================================================================================================== //
                // ==================                           ASIGNO A DEPOSITO                       =================== //
                // ======================================================================================================== //
                
                // Asigno el articulo a todos los depositos de la empresa y solo al que selecciono le aplico el stock inicial

                var _depositoResult = _context.Depositos
                    .AsNoTracking()
                    .Where(x => x.EmpresaId == entidad.EmpresaId)
                    .ToList();

                Parallel.ForEach(_depositoResult, x =>
                {
                    var _articuloDepositoNuevo = new ArticuloDeposito
                    {
                        ArticuloId = entity.Id,
                        DepositoId = entidad.DepositoId.Value,
                        EstaEliminado = false,
                        User = user,
                        Cantidad = x.Id == entidad.DepositoId.Value ? entidad.StockInicial.Value : 0
                    };

                    _context.ArticuloDepositos.Add(_articuloDepositoNuevo);
                });

                _context.SaveChanges();

                // ======================================================================================================== //
                // ==================                           CALCULO  PRECIO                         =================== //
                // ======================================================================================================== //

                var articuloPrecio = new ArticuloPrecioPersistenciaDTO
                {
                    EmpresaId = entidad.EmpresaId.Value,
                    ArticuloId = entity.Id,
                    MarcaId = entidad.MarcaId,
                    FamiliaId = entidad.FamiliaId,
                    PrecioCostoArticulo = entidad.PrecioCostoInicial,
                    RentabilidadArticulo = entidad.Rentabilidad,
                    TieneRentabilidad = entidad.TieneRentabilidad,
                    EsFabricado = false
                };

                _articuloPrecioServicio.AddOrUpdate(articuloPrecio,user);

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
        
        public ResultDTO Delete(ArticuloDeleteDTO deleteDTO, string user)
        {
            using var _context = new DataContext();
            //using var transaction = _context.Database.BeginTransaction();

            try
            {
                var entidad = _context.Articulos.Find(deleteDTO.Id);

                if (entidad == null)
                {
                    return new ResultDTO
                    {
                        Message = "Ocurrio un error al obtener los datos",
                        State = false
                    };
                }

                _context.RemoveLogic(entidad, user);

                _context.SaveChanges();

                return new ResultDTO
                {
                    State = true,
                    Message = !entidad.EstaEliminado ? "Los datos se eliminaron correctamente" : "Los datos se recuperaron correctamente"
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

        public ResultDTO Update(ArticuloPersistenciaDTO entidad, string user)
        {
            using var _context = new DataContext();

            try
            {
                var entityActual = _context.Articulos.Find(entidad.Id);

                if (entityActual == null)
                {
                    return new ResultDTO
                    {
                        Message = "Ocurrio un error al obtener los datos del Articulo",
                        State = false
                    };

                }

                if (entityActual.EstaEliminado)
                {
                    return new ResultDTO
                    {
                        Message = "No se puede Actualizar los datos porque la entidad seleccionada se encuentra eliminada",
                        State = false,
                    };
                }

                var entity = _mapper.Map<Articulo>(entidad);

                entity.User = user;
                entity.Id = entidad.Id;
                entity.VarianteValorUnoId = entityActual.VarianteValorUnoId;
                entity.VarianteValorDosId = entityActual.VarianteValorDosId;
                entity.EmpresaId = entidad.SeleccionoEmpresa ? entidad.EmpresaId : null;
                entity.PrecioCosto = entityActual.PrecioCosto;
                entity.FechaVigenciaKit = entityActual.FechaVigenciaKit;

                _context.Articulos.Update(entity);

                // Elimino lo de la Base de Datos
                foreach (var articuloProveedor in entidad.ArticuloProveedores.Where(x => x.EstaBD && x.Eliminar).ToList())
                {
                    var _artProv = _context.ArticuloProveedores.Find(articuloProveedor.Id.Value);

                    _context.ArticuloProveedores.Remove(_artProv);
                }

                foreach (var articuloProveedor in entidad.ArticuloProveedores.Where(x => x.EstaBD && !x.Eliminar).ToList())
                {
                    var _artProv = _context.ArticuloProveedores.Find(articuloProveedor.Id.Value);

                    _artProv.CodigoProveedor = articuloProveedor.CodigoProveedor;
                    _artProv.User = user;

                    _context.ArticuloProveedores.Update(_artProv);
                }

                foreach (var articuloProveedor in entidad.ArticuloProveedores.Where(x => !x.EstaBD).ToList())
                {
                    var _articuloProveedorNuevo = new ArticuloProveedor
                    {
                        ArticuloId = entity.Id,
                        ProveedorId = articuloProveedor.ProveedorId.Value,
                        CodigoProveedor = articuloProveedor.CodigoProveedor,
                        EstaEliminado = false,
                        User = user,
                    };

                    _context.ArticuloProveedores.Add(_articuloProveedorNuevo);
                }

                _context.SaveChanges();

                return new ResultDTO
                {
                    State = true,
                    Message = "Los datos se actualizaron correctamente"
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
                Expression<Func<Articulo, bool>> filtro = filtro => true;

                filtro = filtro.And(x => x.EmpresaId == empresaId);

                var entities = _context.Articulos
                    .AsNoTracking()
                    .Include(x => x.CondicionIva)
                    .Include(x => x.Marca)
                    .Include(x => x.Familia)
                    .Include(x => x.UnidadMedidaVenta)
                    .Include(x => x.UnidadMedidaCompra)
                    .Include(x => x.VarianteValorUno)
                    .Include(x => x.VarianteValorDos)
                    .Include(x => x.ArticuloBajas)
                    .Include(x => x.ArticuloPrecios).ThenInclude(x => x.ListaPrecio)
                    .Include(x => x.ArticuloFormulas).ThenInclude(x => x.ArticuloSecundario)
                    .Include(x => x.ArticuloPadreKits).ThenInclude(x => x.ArticuloHijo)
                    .Include(x => x.ArticuloDepositos).ThenInclude(x => x.Deposito).ThenInclude(x => x.Empresa)
                    .Include(x => x.ArticuloProveedores).ThenInclude(x => x.Proveedor)
                    .Include(x => x.ArticuloHijoOpcionales)
                    .Where(filtro)
                    .OrderBy(d => d.Descripcion)
                    .ToList();

                return new ResultDTO
                {
                    State = true,
                    Data = _mapper.Map<IEnumerable<ArticuloDTO>>(entities)
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

            try
            {
                var entities = _context.Articulos
                    .AsNoTracking()
                    .Include(x => x.CondicionIva)
                    .Include(x => x.Marca)
                    .Include(x => x.Familia)
                    .Include(x => x.UnidadMedidaVenta)
                    .Include(x => x.UnidadMedidaCompra)
                    .Include(x => x.VarianteValorUno)
                    .Include(x => x.VarianteValorDos)
                    .Include(x => x.ArticuloBajas)
                    .Include(x => x.ArticuloPrecios).ThenInclude(x => x.ListaPrecio)
                    .Include(x => x.ArticuloFormulas).ThenInclude(x => x.ArticuloSecundario)
                    .Include(x => x.ArticuloPadreKits).ThenInclude(x => x.ArticuloHijo)
                    .Include(x => x.ArticuloDepositos).ThenInclude(x => x.Deposito).ThenInclude(x => x.Empresa)
                    .Include(x => x.ArticuloProveedores).ThenInclude(x => x.Proveedor)
                    .Include(x => x.ArticuloHijoOpcionales)
                    .OrderBy(d => d.Descripcion)
                    .ToList();

                return new ResultDTO
                {
                    State = true,
                    Data = _mapper.Map<IEnumerable<ArticuloDTO>>(entities)
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

        public ResultDTO GetByFilter(ArticuloFilterDTO filter)
        {
            using var _context = new DataContext();

            try
            {
                filter.CadenaBuscar = !string.IsNullOrEmpty(filter.CadenaBuscar) ? filter.CadenaBuscar : string.Empty;

                Expression<Func<Articulo, bool>> filtro = filtro => true;

                filtro = filtro.And(x => x.EmpresaId == filter.EmpresaId || !x.EmpresaId.HasValue);


                if (filter.CadenaBuscar.IndexOf(SeparacionFiltroBusqueda.CaracterSeparador) != -1)
                {
                    var primeraPasada = true;

                    var listaCadenas = filter.CadenaBuscar.Split(SeparacionFiltroBusqueda.CaracterSeparador, StringSplitOptions.RemoveEmptyEntries);

                    foreach (var cadena in listaCadenas)
                    {
                        if (primeraPasada)
                        {
                            filtro = filtro.And(x => x.EstaEliminado == filter.VerEliminados
                                                     && (x.Descripcion.ToLower().Contains(cadena.ToLower())
                                                         || x.Codigo == filter.CadenaBuscar
                                                         || x.CodigoBarra == filter.CadenaBuscar
                                                         || x.Abreviatura == filter.CadenaBuscar));

                            primeraPasada = false;
                        }
                        else
                        {
                            filtro = filtro.Or(x => x.EstaEliminado == filter.VerEliminados
                                                       && (x.Descripcion.ToLower().Contains(cadena.ToLower())
                                                        || x.Codigo == filter.CadenaBuscar
                                                        || x.CodigoBarra == filter.CadenaBuscar
                                                        || x.Abreviatura == filter.CadenaBuscar));
                        }
                    }
                }
                else
                {
                    filtro = filtro.And(x => x.EstaEliminado == filter.VerEliminados
                                                && (x.Descripcion.ToLower().Contains(filter.CadenaBuscar.ToLower())
                                                 || x.Codigo == filter.CadenaBuscar
                                                 || x.CodigoBarra == filter.CadenaBuscar
                                                 || x.Abreviatura == filter.CadenaBuscar));
                }

                var entities = _context.Articulos
                    .AsNoTracking()
                    .Include(x => x.CondicionIva)
                    .Include(x => x.Marca)
                    .Include(x => x.Familia)
                    .Include(x => x.UnidadMedidaVenta)
                    .Include(x => x.UnidadMedidaCompra)
                    .Include(x => x.VarianteValorUno)
                    .Include(x => x.VarianteValorDos)
                    .Include(x => x.ArticuloBajas)
                    .Include(x => x.ArticuloPrecios).ThenInclude(x => x.ListaPrecio)
                    .Include(x => x.ArticuloFormulas).ThenInclude(x => x.ArticuloSecundario)
                    .Include(x => x.ArticuloPadreKits).ThenInclude(x => x.ArticuloHijo)
                    .Include(x => x.ArticuloDepositos).ThenInclude(x => x.Deposito).ThenInclude(x => x.Empresa)
                    .Include(x => x.ArticuloProveedores).ThenInclude(x => x.Proveedor)
                    .Include(x => x.ArticuloHijoOpcionales)
                    .Where(filtro)
                    .OrderBy(d => d.Descripcion)
                    .ToList();

                var result = _mapper.Map<IEnumerable<ArticuloDTO>>(entities);

                var _configCore = _context.ConfiguracionCores
                    .AsNoTracking()
                    .Where(x => x.EmpresaId == filter.EmpresaId)
                    .ToList();

                if (_configCore != null)
                {
                    Parallel.ForEach(result.ToList(), x =>
                    {
                        x.PrecioPublico = x.ListaPrecios.Any(lp => lp.ListaPrecioId == _configCore.First().ListaPrecioPorDefectoParaVentaId
                                                                                            && lp.FechaActualizacion == x.ListaPrecios
                                                                                                   .Where(lp2 => lp2.ListaPrecioId == _configCore.First().ListaPrecioPorDefectoParaVentaId)
                                                                                                   .Max(f => f.FechaActualizacion))
                                                        ? x.ListaPrecios.First(lp => lp.ListaPrecioId == _configCore.First().ListaPrecioPorDefectoParaVentaId
                                                                                     && lp.FechaActualizacion == x.ListaPrecios
                                                                                    .Where(lp2 => lp2.ListaPrecioId == _configCore.First().ListaPrecioPorDefectoParaVentaId)
                                                                                    .Max(f => f.FechaActualizacion)).Monto
                                                        : 0;

                        x.Stock = x.Cantidades.Any(d => d.DepositoId == _configCore.First().DepositoPorDefectoParaVentaId)
                                  ? x.Cantidades.First(d => d.DepositoId == _configCore.First().DepositoPorDefectoParaVentaId).Cantidad
                                  : 0;
                    });
                }

                return new ResultDTO
                {
                    State = true,
                    Data = result.ToList(),
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

        public ResultDTO GetByFilterLookUp(ArticuloFilterDTO filter)
        {
            using var _context = new DataContext();

            try
            {
                filter.CadenaBuscar = !string.IsNullOrEmpty(filter.CadenaBuscar) ? filter.CadenaBuscar : string.Empty;

                Expression<Func<Articulo, bool>> filtro = filtro => true;

                filtro = filtro.And(x => x.EmpresaId == filter.EmpresaId || !x.EmpresaId.HasValue);

                filtro = filtro.And(x => x.TipoArticulo != TipoArticulo.Base
                                         && x.TipoArticulo != TipoArticulo.BienUso
                                         && x.TipoArticulo != TipoArticulo.Kit);

                if (filter.CadenaBuscar.IndexOf(SeparacionFiltroBusqueda.CaracterSeparador) != -1)
                {
                    var primeraPasada = true;

                    var listaCadenas = filter.CadenaBuscar.Split(SeparacionFiltroBusqueda.CaracterSeparador, StringSplitOptions.RemoveEmptyEntries);

                    foreach (var cadena in listaCadenas)
                    {
                        if (primeraPasada)
                        {
                            filtro = filtro.And(x => x.EstaEliminado == filter.VerEliminados
                                                     && (x.Descripcion.ToLower().Contains(cadena.ToLower())
                                                         || x.Codigo == filter.CadenaBuscar
                                                         || x.CodigoBarra == filter.CadenaBuscar
                                                         || x.Abreviatura == filter.CadenaBuscar));

                            primeraPasada = false;
                        }
                        else
                        {
                            filtro = filtro.Or(x => x.EstaEliminado == filter.VerEliminados
                                                       && (x.Descripcion.ToLower().Contains(cadena.ToLower())
                                                        || x.Codigo == filter.CadenaBuscar
                                                        || x.CodigoBarra == filter.CadenaBuscar
                                                        || x.Abreviatura == filter.CadenaBuscar));
                        }
                    }
                }
                else
                {
                    filtro = filtro.And(x => x.EstaEliminado == filter.VerEliminados
                                                && (x.Descripcion.ToLower().Contains(filter.CadenaBuscar.ToLower())
                                                 || x.Codigo == filter.CadenaBuscar
                                                 || x.CodigoBarra == filter.CadenaBuscar
                                                 || x.Abreviatura == filter.CadenaBuscar));
                }

                var entities = _context.Articulos
                    .AsNoTracking()
                    .Include(x => x.CondicionIva)
                    .Include(x => x.Marca)
                    .Include(x => x.Familia)
                    .Include(x => x.UnidadMedidaVenta)
                    .Include(x => x.UnidadMedidaCompra)
                    .Include(x => x.VarianteValorUno)
                    .Include(x => x.VarianteValorDos)
                    .Include(x => x.ArticuloBajas)
                    .Include(x => x.ArticuloPrecios).ThenInclude(x => x.ListaPrecio)
                    .Include(x => x.ArticuloFormulas).ThenInclude(x => x.ArticuloSecundario)
                    .Include(x => x.ArticuloPadreKits).ThenInclude(x => x.ArticuloHijo)
                    .Include(x => x.ArticuloDepositos).ThenInclude(x => x.Deposito).ThenInclude(x => x.Empresa)
                    .Include(x => x.ArticuloProveedores).ThenInclude(x => x.Proveedor)
                    .Include(x => x.ArticuloHijoOpcionales)
                    .Where(filtro)
                    .OrderBy(d => d.Descripcion)
                    .ToList();

                var result = _mapper.Map<IEnumerable<ArticuloDTO>>(entities);

                var _configCore = _context.ConfiguracionCores
                    .AsNoTracking()
                    .Where(x => x.EmpresaId == filter.EmpresaId)
                    .ToList();

                if (_configCore != null)
                {
                    Parallel.ForEach(result.ToList(), x =>
                    {
                        x.PrecioPublico = x.ListaPrecios.Any(lp => lp.ListaPrecioId == _configCore.First().ListaPrecioPorDefectoParaVentaId
                                                                                            && lp.FechaActualizacion == x.ListaPrecios
                                                                                                   .Where(lp2 => lp2.ListaPrecioId == _configCore.First().ListaPrecioPorDefectoParaVentaId)
                                                                                                   .Max(f => f.FechaActualizacion))
                                                        ? x.ListaPrecios.First(lp => lp.ListaPrecioId == _configCore.First().ListaPrecioPorDefectoParaVentaId
                                                                                     && lp.FechaActualizacion == x.ListaPrecios
                                                                                    .Where(lp2 => lp2.ListaPrecioId == _configCore.First().ListaPrecioPorDefectoParaVentaId)
                                                                                    .Max(f => f.FechaActualizacion)).Monto
                                                        : 0;

                        x.Stock = x.Cantidades.Any(d => d.DepositoId == _configCore.First().DepositoPorDefectoParaVentaId)
                                  ? x.Cantidades.First(d => d.DepositoId == _configCore.First().DepositoPorDefectoParaVentaId).Cantidad
                                  : 0;
                    });
                }

                return new ResultDTO
                {
                    State = true,
                    Data = result.ToList(),
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

        public ResultDTO GetByFilterLookUp(ArticuloFilterDTO filter, List<TipoArticulo> tipos)
        {
            using var _context = new DataContext();

            try
            {
                filter.CadenaBuscar = !string.IsNullOrEmpty(filter.CadenaBuscar) ? filter.CadenaBuscar : string.Empty;

                Expression<Func<Articulo, bool>> filtro = filtro => true;

                filtro = filtro.And(x => x.EmpresaId == filter.EmpresaId || !x.EmpresaId.HasValue);

                filtro = filtro.And(x => tipos.Contains(x.TipoArticulo));

                if (filter.CadenaBuscar.IndexOf(SeparacionFiltroBusqueda.CaracterSeparador) != -1)
                {
                    var primeraPasada = true;

                    var listaCadenas = filter.CadenaBuscar.Split(SeparacionFiltroBusqueda.CaracterSeparador, StringSplitOptions.RemoveEmptyEntries);

                    foreach (var cadena in listaCadenas)
                    {
                        if (primeraPasada)
                        {
                            filtro = filtro.And(x => x.EstaEliminado == filter.VerEliminados
                                                     && (x.Descripcion.ToLower().Contains(cadena.ToLower())
                                                         || x.Codigo == filter.CadenaBuscar
                                                         || x.CodigoBarra == filter.CadenaBuscar
                                                         || x.Abreviatura == filter.CadenaBuscar));

                            primeraPasada = false;
                        }
                        else
                        {
                            filtro = filtro.Or(x => x.EstaEliminado == filter.VerEliminados
                                                       && (x.Descripcion.ToLower().Contains(cadena.ToLower())
                                                        || x.Codigo == filter.CadenaBuscar
                                                        || x.CodigoBarra == filter.CadenaBuscar
                                                        || x.Abreviatura == filter.CadenaBuscar));
                        }
                    }
                }
                else
                {
                    filtro = filtro.And(x => x.EstaEliminado == filter.VerEliminados
                                                && (x.Descripcion.ToLower().Contains(filter.CadenaBuscar.ToLower())
                                                 || x.Codigo == filter.CadenaBuscar
                                                 || x.CodigoBarra == filter.CadenaBuscar
                                                 || x.Abreviatura == filter.CadenaBuscar));
                }

                var entities = _context.Articulos
                    // .AsNoTracking()
                    .Include(x => x.CondicionIva)
                    .Include(x => x.Marca)
                    .Include(x => x.Familia)
                    .Include(x => x.UnidadMedidaVenta)
                    .Include(x => x.UnidadMedidaCompra)
                    .Include(x => x.VarianteValorUno)
                    .Include(x => x.VarianteValorDos)
                    .Include(x => x.ArticuloBajas)
                    .Include(x => x.ArticuloPrecios).ThenInclude(x => x.ListaPrecio)
                    .Include(x => x.ArticuloFormulas).ThenInclude(x => x.ArticuloSecundario)
                    .Include(x => x.ArticuloPadreKits).ThenInclude(x => x.ArticuloHijo)
                    .Include(x => x.ArticuloDepositos).ThenInclude(x => x.Deposito).ThenInclude(x => x.Empresa)
                    .Include(x => x.ArticuloProveedores).ThenInclude(x => x.Proveedor)
                    .Include(x => x.ArticuloHijoOpcionales)
                    .Where(filtro)
                    .OrderBy(d => d.Descripcion)
                    .ToList();

                var result = _mapper.Map<IEnumerable<ArticuloDTO>>(entities);

                var _configCore = _context.ConfiguracionCores
                   .AsNoTracking()
                   .Where(x => x.EmpresaId == filter.EmpresaId)
                   .ToList();

                if (_configCore != null)
                {
                    Parallel.ForEach(result.ToList(), x =>
                    {
                        x.PrecioPublico = x.ListaPrecios.Any(lp => lp.ListaPrecioId == _configCore.First().ListaPrecioPorDefectoParaVentaId
                                                                                            && lp.FechaActualizacion == x.ListaPrecios
                                                                                                   .Where(lp2 => lp2.ListaPrecioId == _configCore.First().ListaPrecioPorDefectoParaVentaId)
                                                                                                   .Max(f => f.FechaActualizacion))
                                                        ? x.ListaPrecios.First(lp => lp.ListaPrecioId == _configCore.First().ListaPrecioPorDefectoParaVentaId
                                                                                     && lp.FechaActualizacion == x.ListaPrecios
                                                                                    .Where(lp2 => lp2.ListaPrecioId == _configCore.First().ListaPrecioPorDefectoParaVentaId)
                                                                                    .Max(f => f.FechaActualizacion)).Monto
                                                        : 0;

                        x.Stock = x.Cantidades.Any(d => d.DepositoId == _configCore.First().DepositoPorDefectoParaVentaId)
                                  ? x.Cantidades.First(d => d.DepositoId == _configCore.First().DepositoPorDefectoParaVentaId).Cantidad
                                  : 0;
                    });
                }

                return new ResultDTO
                {
                    State = true,
                    Data = result.ToList(),
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

        public ResultDTO GetByIdPivot(Guid empresaId, Guid articuloId)
        {
            using var _context = new DataContext();

            try
            {
                var result = _context.ArticuloDepositos
                    .AsNoTracking()
                    .Include(z => z.Deposito)
                    .Include(z => z.Articulo)
                    .Where(x => x.Deposito.EmpresaId == empresaId && x.ArticuloId == articuloId)
                    .ToList();

                var resultPivot = result.Pivot(rowSelector: d => d.Deposito.Descripcion,
                    columnSelector: d => d.Articulo.Descripcion,
                    valueSelector: d => d.Sum(s => s.Cantidad));

                return new ResultDTO { State = true };
            }
            catch (Exception ex)
            {
                return new ResultDTO
                {
                    State = false,
                    Message = ex.Message,
                    Data = null
                };
            }
        }

        public ResultDTO GetById(Guid id, Guid empresaId)
        {
            using var _context = new DataContext();

            try
            {
                var entity = _context.Articulos
                    .AsNoTracking()
                    .Include(x => x.CondicionIva)
                    .Include(x => x.Marca)
                    .Include(x => x.Familia)
                    .Include(x => x.UnidadMedidaVenta)
                    .Include(x => x.UnidadMedidaCompra)
                    .Include(x => x.VarianteValorUno)
                    .Include(x => x.VarianteValorDos)
                    .Include(x => x.ArticuloBajas)
                    .Include(x => x.ArticuloPrecios).ThenInclude(x => x.ListaPrecio)
                    .Include(x => x.ArticuloFormulas).ThenInclude(x => x.ArticuloSecundario)
                    .Include(x => x.ArticuloPadreKits).ThenInclude(x => x.ArticuloHijo)
                    .Include(x => x.ArticuloDepositos).ThenInclude(x => x.Deposito).ThenInclude(x => x.Empresa)
                    .Include(x => x.ArticuloProveedores).ThenInclude(x => x.Proveedor)
                    .Include(x => x.ArticuloHijoOpcionales)
                    .FirstOrDefault(x=>x.Id == id);

                if (entity == null)
                {
                    return new ResultDTO
                    {
                        State = false,
                        Message = "No se encontro el dato solicitado"
                    };
                }

                var result = _mapper.Map<ArticuloDTO>(entity);

                var _configCore = _context.ConfiguracionCores
                   .AsNoTracking()
                   .Where(x => x.EmpresaId == empresaId)
                   .ToList();

                if (_configCore != null)
                {
                    result.PrecioPublico = result.ListaPrecios.Any(lp => lp.ListaPrecioId == _configCore.First().ListaPrecioPorDefectoParaVentaId
                                                                      && lp.FechaActualizacion == result.ListaPrecios
                                                                           .Where(lp2 => lp2.ListaPrecioId == _configCore.First().ListaPrecioPorDefectoParaVentaId)
                                                                           .Max(f => f.FechaActualizacion))
                                                    ? result.ListaPrecios.First(lp => lp.ListaPrecioId == _configCore.First().ListaPrecioPorDefectoParaVentaId
                                                                    && lp.FechaActualizacion == result.ListaPrecios
                                                                         .Where(lp2 => lp2.ListaPrecioId == _configCore.First().ListaPrecioPorDefectoParaVentaId)
                                                                         .Max(f => f.FechaActualizacion)).Monto
                                                    : 0;

                    result.Stock = result.Cantidades.Any(d => d.DepositoId == _configCore.First().DepositoPorDefectoParaVentaId)
                              ? result.Cantidades.First(d => d.DepositoId == _configCore.First().DepositoPorDefectoParaVentaId).Cantidad
                              : 0;
                }

                return new ResultDTO
                {
                    State = true,
                    Data = result
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

        public ResultDTO GetById(Guid id, Guid empresaId, Guid depositoId)
        {
            using var _context = new DataContext();

            try
            {
                var entity = _context.Articulos
                    .AsNoTracking()
                    .Include(x => x.CondicionIva)
                    .Include(x => x.Marca)
                    .Include(x => x.Familia)
                    .Include(x => x.UnidadMedidaVenta)
                    .Include(x => x.UnidadMedidaCompra)
                    .Include(x => x.VarianteValorUno)
                    .Include(x => x.VarianteValorDos)
                    .Include(x => x.ArticuloBajas)
                    .Include(x => x.ArticuloPrecios).ThenInclude(x => x.ListaPrecio)
                    .Include(x => x.ArticuloFormulas).ThenInclude(x => x.ArticuloSecundario)
                    .Include(x => x.ArticuloPadreKits).ThenInclude(x => x.ArticuloHijo)
                    .Include(x => x.ArticuloDepositos).ThenInclude(x => x.Deposito).ThenInclude(x => x.Empresa)
                    .Include(x => x.ArticuloProveedores).ThenInclude(x => x.Proveedor)
                    .Include(x => x.ArticuloHijoOpcionales)
                    .FirstOrDefault(x => x.Id == id);

                if (entity == null)
                {
                    return new ResultDTO
                    {
                        State = false,
                        Message = "No se encontro el dato solicitado"
                    };
                }

                var result = _mapper.Map<ArticuloDTO>(entity);

                var _configCore = _context.ConfiguracionCores
                    .AsNoTracking()
                    .Where(x => x.EmpresaId == empresaId)
                    .ToList();

                if (_configCore != null)
                {
                    result.PrecioPublico = result.ListaPrecios.Any(lp => lp.ListaPrecioId == _configCore.First().ListaPrecioPorDefectoParaVentaId
                                                                      && lp.FechaActualizacion == result.ListaPrecios
                                                                           .Where(lp2 => lp2.ListaPrecioId == _configCore.First().ListaPrecioPorDefectoParaVentaId)
                                                                           .Max(f => f.FechaActualizacion))
                                                    ? result.ListaPrecios.First(lp => lp.ListaPrecioId == _configCore.First().ListaPrecioPorDefectoParaVentaId
                                                                    && lp.FechaActualizacion == result.ListaPrecios
                                                                         .Where(lp2 => lp2.ListaPrecioId == _configCore.First().ListaPrecioPorDefectoParaVentaId)
                                                                         .Max(f => f.FechaActualizacion)).Monto
                                                    : 0;

                    result.Stock = result.Cantidades.Any(d => d.DepositoId == depositoId)
                              ? result.Cantidades.First(d => d.DepositoId == depositoId).Cantidad
                              : 0;
                }

                return new ResultDTO
                {
                    State = true,
                    Data = result
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

        public ResultDTO GetByIds(List<Guid> ids, Guid empresaId)
        {
            using var _context = new DataContext();

            try
            {
                var entities = _context.Articulos
                    .AsNoTracking()
                    .Include(x => x.CondicionIva)
                    .Include(x => x.Marca)
                    .Include(x => x.Familia)
                    .Include(x => x.UnidadMedidaVenta)
                    .Include(x => x.UnidadMedidaCompra)
                    .Include(x => x.VarianteValorUno)
                    .Include(x => x.VarianteValorDos)
                    .Include(x => x.ArticuloBajas)
                    .Include(x => x.ArticuloPrecios).ThenInclude(x => x.ListaPrecio)
                    .Include(x => x.ArticuloFormulas).ThenInclude(x => x.ArticuloSecundario)
                    .Include(x => x.ArticuloPadreKits).ThenInclude(x => x.ArticuloHijo)
                    .Include(x => x.ArticuloDepositos).ThenInclude(x => x.Deposito).ThenInclude(x => x.Empresa)
                    .Include(x => x.ArticuloProveedores).ThenInclude(x => x.Proveedor)
                    .Include(x => x.ArticuloHijoOpcionales)
                    .Where(x=>ids.Contains(x.Id))
                    .OrderBy(d => d.Descripcion)
                    .ToList();
                                
                var result = _mapper.Map<IEnumerable<ArticuloDTO>>(entities);

                var _configCore = _context.ConfiguracionCores
                    .AsNoTracking()
                    .Where(x => x.EmpresaId == empresaId)
                    .ToList();

                if (_configCore != null)
                {
                    Parallel.ForEach(result.ToList(), x =>
                    {
                        x.PrecioPublico = x.ListaPrecios.Any(lp => lp.ListaPrecioId == _configCore.First().ListaPrecioPorDefectoParaVentaId
                                                                                            && lp.FechaActualizacion == x.ListaPrecios
                                                                                                   .Where(lp2 => lp2.ListaPrecioId == _configCore.First().ListaPrecioPorDefectoParaVentaId)
                                                                                                   .Max(f => f.FechaActualizacion))
                                                        ? x.ListaPrecios.First(lp => lp.ListaPrecioId == _configCore.First().ListaPrecioPorDefectoParaVentaId
                                                                                     && lp.FechaActualizacion == x.ListaPrecios
                                                                                    .Where(lp2 => lp2.ListaPrecioId == _configCore.First().ListaPrecioPorDefectoParaVentaId)
                                                                                    .Max(f => f.FechaActualizacion)).Monto
                                                        : 0;

                        x.Stock = x.Cantidades.Any(d => d.DepositoId == _configCore.First().DepositoPorDefectoParaVentaId)
                                  ? x.Cantidades.First(d => d.DepositoId == _configCore.First().DepositoPorDefectoParaVentaId).Cantidad
                                  : 0;
                    });
                }

                return new ResultDTO
                {
                    State = true,
                    Data = result.ToList()
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

        public ResultDTO GetByIds(List<Guid> ids, Guid empresaId, Guid depositoId)
        {
            using var _context = new DataContext();

            try
            {
                var entities = _context.Articulos
                    .AsNoTracking()
                    .Include(x => x.CondicionIva)
                    .Include(x => x.Marca)
                    .Include(x => x.Familia)
                    .Include(x => x.UnidadMedidaVenta)
                    .Include(x => x.UnidadMedidaCompra)
                    .Include(x => x.VarianteValorUno)
                    .Include(x => x.VarianteValorDos)
                    .Include(x => x.ArticuloBajas)
                    .Include(x => x.ArticuloPrecios).ThenInclude(x => x.ListaPrecio)
                    .Include(x => x.ArticuloFormulas).ThenInclude(x => x.ArticuloSecundario)
                    .Include(x => x.ArticuloPadreKits).ThenInclude(x => x.ArticuloHijo)
                    .Include(x => x.ArticuloDepositos).ThenInclude(x => x.Deposito).ThenInclude(x => x.Empresa)
                    .Include(x => x.ArticuloProveedores).ThenInclude(x => x.Proveedor)
                    .Include(x => x.ArticuloHijoOpcionales)
                    .Where(x => ids.Contains(x.Id))
                    .OrderBy(d => d.Descripcion)
                    .ToList();

                var result = _mapper.Map<IEnumerable<ArticuloDTO>>(entities);

                var _configCore = _context.ConfiguracionCores
                    .AsNoTracking()
                    .Where(x => x.EmpresaId == empresaId)
                    .ToList();

                if (_configCore != null)
                {
                    Parallel.ForEach(result.ToList(), x =>
                    {
                        x.PrecioPublico = x.ListaPrecios.Any(lp => lp.ListaPrecioId == _configCore.First().ListaPrecioPorDefectoParaVentaId
                                                                                            && lp.FechaActualizacion == x.ListaPrecios
                                                                                                   .Where(lp2 => lp2.ListaPrecioId == _configCore.First().ListaPrecioPorDefectoParaVentaId)
                                                                                                   .Max(f => f.FechaActualizacion))
                                                        ? x.ListaPrecios.First(lp => lp.ListaPrecioId == _configCore.First().ListaPrecioPorDefectoParaVentaId
                                                                                     && lp.FechaActualizacion == x.ListaPrecios
                                                                                    .Where(lp2 => lp2.ListaPrecioId == _configCore.First().ListaPrecioPorDefectoParaVentaId)
                                                                                    .Max(f => f.FechaActualizacion)).Monto
                                                        : 0;

                        x.Stock = x.Cantidades.Any(d => d.DepositoId == depositoId)
                                  ? x.Cantidades.First(d => d.DepositoId == depositoId).Cantidad
                                  : 0;
                    });
                }

                return new ResultDTO
                {
                    State = true,
                    Data = result.ToList()
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

        private bool VerificarSiExiste(string descripcion, Guid? empresaId, Guid? id = null)
        {
            using var _context = new DataContext();

            if (id == null)
            {
                if (empresaId.HasValue)
                {
                    return _context.Articulos.Any(x => x.EmpresaId == empresaId.Value && x.Descripcion.ToLower() == descripcion.ToLower());
                }
                else
                {
                    return _context.Articulos.Any(x => x.Descripcion.ToLower() == descripcion.ToLower());
                }
            }
            else
            {
                if (empresaId.HasValue)
                {
                    return _context.Articulos.Any(x => x.Id != id.Value
                        && x.EmpresaId == empresaId
                        && x.Descripcion.ToLower() == descripcion.ToLower());
                }
                else
                {
                    return _context.Articulos.Any(x => x.Id != id.Value
                        && x.Descripcion.ToLower() == descripcion.ToLower());
                }
            }
        }

        public ResultDTO GetByCodigo(Guid listaPrecioId, string cadenaBuscar, Guid empresaId)
        {
            using var _context = new DataContext();

            try
            {
                cadenaBuscar = !string.IsNullOrEmpty(cadenaBuscar) ? cadenaBuscar : string.Empty;

                Expression<Func<Articulo, bool>> filtro = filtro => true;

                filtro = filtro.And(x => x.EmpresaId == empresaId || !x.EmpresaId.HasValue);

                filtro = filtro.And(x => x.TipoArticulo != TipoArticulo.Base && (x.PerfilArticulo == PerfilArticulo.CompraVenta || x.PerfilArticulo == PerfilArticulo.Venta));

                filtro = filtro.And(x => !x.EstaEliminado
                                            && x.Codigo == cadenaBuscar
                                             || x.CodigoBarra == cadenaBuscar
                                             || x.Abreviatura == cadenaBuscar);


                var entities = _context.Articulos
                    .AsNoTracking()
                    .Include(x => x.CondicionIva)
                    .Include(x => x.Marca)
                    .Include(x => x.Familia)
                    .Include(x => x.UnidadMedidaVenta)
                    .Include(x => x.UnidadMedidaCompra)
                    .Include(x => x.VarianteValorUno)
                    .Include(x => x.VarianteValorDos)
                    .Include(x => x.ArticuloBajas)
                    .Include(x => x.ArticuloPrecios).ThenInclude(x => x.ListaPrecio)
                    .Include(x => x.ArticuloFormulas).ThenInclude(x => x.ArticuloSecundario)
                    .Include(x => x.ArticuloPadreKits).ThenInclude(x => x.ArticuloHijo)
                    .Include(x => x.ArticuloDepositos).ThenInclude(x => x.Deposito).ThenInclude(x => x.Empresa)
                    .Include(x => x.ArticuloProveedores).ThenInclude(x => x.Proveedor)
                    .Include(x => x.ArticuloHijoOpcionales)
                    .Where(filtro)
                    .OrderBy(d => d.Descripcion)
                    .ToList();

                var result = _mapper.Map<ArticuloDTO>(entities.FirstOrDefault());

                if (result == null)
                {
                    return new ResultDTO
                    {
                        State = false,
                        Data = null
                    };
                }

                var _configCore = _context.ConfiguracionCores
                    .AsNoTracking()
                    .Where(x => x.EmpresaId == empresaId)
                    .ToList();

                if (_configCore != null)
                {
                    result.PrecioPublico = result.ListaPrecios.Any(lp => lp.ListaPrecioId == listaPrecioId
                                                                                        && lp.FechaActualizacion == result.ListaPrecios
                                                                                               .Where(lp2 => lp2.ListaPrecioId == listaPrecioId)
                                                                                               .Max(f => f.FechaActualizacion))
                                                    ? result.ListaPrecios.First(lp => lp.ListaPrecioId == listaPrecioId
                                                                                 && lp.FechaActualizacion == result.ListaPrecios
                                                                                .Where(lp2 => lp2.ListaPrecioId == listaPrecioId)
                                                                                .Max(f => f.FechaActualizacion)).Monto
                                                    : 0;

                    result.Stock = result.Cantidades.Any(d => d.DepositoId == _configCore.First().DepositoPorDefectoParaVentaId)
                              ? result.Cantidades.First(d => d.DepositoId == _configCore.First().DepositoPorDefectoParaVentaId).Cantidad
                              : 0;
                }

                return new ResultDTO
                {
                    State = true,
                    Data = result,
                };
            }
            catch (Exception)
            {
                return new ResultDTO
                {
                    State = false,
                    Message = "Ocurrio un error al obtener el articulo"
                };
            }
        }

        public ResultDTO GetByCodigoProveedor(Guid? proveedorId, string cadenaBuscar, Guid empresaId)
        {
            using var _context = new DataContext();

            try
            {
                cadenaBuscar = !string.IsNullOrEmpty(cadenaBuscar) ? cadenaBuscar : string.Empty;

                Expression<Func<Articulo, bool>> filtro = filtro => true;

                filtro = filtro.And(x => x.EmpresaId == empresaId || !x.EmpresaId.HasValue);

                if (proveedorId.HasValue && proveedorId.Value != Guid.Empty)
                {
                    filtro = filtro.And(x => x.ArticuloProveedores.Any(p => p.ProveedorId == proveedorId.Value));
                }

                filtro = filtro.And(x => x.PerfilArticulo == PerfilArticulo.CompraVenta || x.PerfilArticulo == PerfilArticulo.Compra);

                filtro = filtro.And(x => x.TipoArticulo == TipoArticulo.Simple);

                if (proveedorId.HasValue && proveedorId.Value != Guid.Empty)
                {
                    filtro = filtro.And(x => !x.EstaEliminado && x.Codigo == cadenaBuscar
                                          || x.CodigoBarra == cadenaBuscar
                                          || x.Abreviatura == cadenaBuscar
                                          || x.ArticuloProveedores.Any(p => p.CodigoProveedor == cadenaBuscar));
                }
                else
                {
                    filtro = filtro.And(x => !x.EstaEliminado && x.Codigo == cadenaBuscar
                                          || x.CodigoBarra == cadenaBuscar
                                          || x.Abreviatura == cadenaBuscar);
                }

                var entities = _context.Articulos
                    .AsNoTracking()
                    .Include(x => x.CondicionIva)
                    .Include(x => x.Marca)
                    .Include(x => x.Familia)
                    .Include(x => x.UnidadMedidaVenta)
                    .Include(x => x.UnidadMedidaCompra)
                    .Include(x => x.VarianteValorUno)
                    .Include(x => x.VarianteValorDos)
                    .Include(x => x.ArticuloBajas)
                    .Include(x => x.ArticuloPrecios).ThenInclude(x => x.ListaPrecio)
                    .Include(x => x.ArticuloFormulas).ThenInclude(x => x.ArticuloSecundario)
                    .Include(x => x.ArticuloPadreKits).ThenInclude(x => x.ArticuloHijo)
                    .Include(x => x.ArticuloDepositos).ThenInclude(x => x.Deposito).ThenInclude(x => x.Empresa)
                    .Include(x => x.ArticuloProveedores).ThenInclude(x => x.Proveedor)
                    .Include(x => x.ArticuloHijoOpcionales)
                    .Where(filtro)
                    .OrderBy(d => d.Descripcion)
                    .ToList();

                var result = _mapper.Map<ArticuloDTO>(entities.FirstOrDefault());

                if (result == null)
                {
                    return new ResultDTO
                    {
                        State = false,
                        Data = null
                    };
                }

                var _configCore = _context.ConfiguracionCores
                    .AsNoTracking()
                    .Where(x => x.EmpresaId == empresaId)
                    .ToList();

                if (_configCore != null)
                {
                    result.Stock = result.Cantidades.Any(d => d.DepositoId == _configCore.First().DepositoPorDefectoParaVentaId)
                                   ? result.Cantidades.First(d => d.DepositoId == _configCore.First().DepositoPorDefectoParaVentaId).Cantidad
                                   : 0;
                }

                return new ResultDTO
                {
                    State = true,
                    Data = result,
                };
            }
            catch (Exception)
            {
                return new ResultDTO
                {
                    State = false,
                    Message = "Ocurrio un error al obtener el articulo"
                };
            }
        }
    }
}
