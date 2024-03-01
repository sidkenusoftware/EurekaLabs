using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Sidkenu.AccesoDatos.Constantes;
using Sidkenu.AccesoDatos.Entidades.Core;
using Sidkenu.AccesoDatos.Infraestructura;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Base;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.Articulo;
using Sidkenu.LogicaNegocio.Servicios.Implementacion.Base;
using Sidkenu.LogicaNegocio.Servicios.Interface.Core;
using Sidkenu.LogicaNegocio.Servicios.Interface.Seguridad;
using System.Linq.Expressions;

namespace Sidkenu.LogicaNegocio.Servicios.Implementacion.Core
{
    public class ArticuloTemporalServicio : ServicioBase, IArticuloTemporalServicio
    { 
        public ArticuloTemporalServicio(IMapper mapper,
                                        IConfiguracionServicio configuracionServicio)
                                        : base(mapper, configuracionServicio)
        {
        }

        public ResultDTO Add(ArticuloTemporalPersistenciaDTO entidad, string user)
        {
            using var _context = new DataContext();

            try
            {
                var entity = _mapper.Map<ArticuloTemporal>(entidad);

                entity.User = user;
                entity.EstaEliminado = false;
                entity.EmpresaId = entidad.EmpresaId;

                _context.ArticuloTemporales.Add(entity);

                entidad.Id = entity.Id;

                _context.SaveChanges();

                return new ResultDTO
                {
                    State = true,
                    Message = "Los datos se grabaron correctamente",
                    Data = entidad
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

            try
            {
                Expression<Func<ArticuloTemporal, bool>> filtro = filtro => true;

                filtro = filtro.And(x => x.EmpresaId == empresaId);

                var entities = _context.ArticuloTemporales
                    .AsNoTracking()
                    .Where(filtro)
                    .OrderBy(d => d.Descripcion)
                    .ToList();

                return new ResultDTO
                {
                    State = true,
                    Data = _mapper.Map<IEnumerable<ArticuloTemporalDTO>>(entities)
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

                Expression<Func<ArticuloTemporal, bool>> filtro = filtro => true;

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
                                                         || x.Codigo == filter.CadenaBuscar));

                            primeraPasada = false;
                        }
                        else
                        {
                            filtro = filtro.Or(x => x.EstaEliminado == filter.VerEliminados
                                                       && (x.Descripcion.ToLower().Contains(cadena.ToLower())
                                                        || x.Codigo == filter.CadenaBuscar));
                        }
                    }
                }
                else
                {
                    filtro = filtro.And(x => x.EstaEliminado == filter.VerEliminados
                                                && (x.Descripcion.ToLower().Contains(filter.CadenaBuscar.ToLower())
                                                 || x.Codigo == filter.CadenaBuscar));
                }

                var entities = _context.ArticuloTemporales
                    .AsNoTracking()
                    .Where(filtro)
                    .OrderBy(d => d.Descripcion)
                    .ToList();

                var result = _mapper.Map<IEnumerable<ArticuloTemporalDTO>>(entities);

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

                Expression<Func<ArticuloTemporal, bool>> filtro = filtro => true;

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
                                                         || x.Codigo == filter.CadenaBuscar));

                            primeraPasada = false;
                        }
                        else
                        {
                            filtro = filtro.Or(x => x.EstaEliminado == filter.VerEliminados
                                                       && (x.Descripcion.ToLower().Contains(cadena.ToLower())
                                                        || x.Codigo == filter.CadenaBuscar));
                        }
                    }
                }
                else
                {
                    filtro = filtro.And(x => x.EstaEliminado == filter.VerEliminados
                                                && (x.Descripcion.ToLower().Contains(filter.CadenaBuscar.ToLower())
                                                 || x.Codigo == filter.CadenaBuscar));
                }

                var entities = _context.ArticuloTemporales
                    .AsNoTracking()
                    .Where(filtro)
                    .OrderBy(d => d.Descripcion)
                    .ToList();

                var result = _mapper.Map<IEnumerable<ArticuloTemporalDTO>>(entities);

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

        public ResultDTO GetById(Guid id, Guid empresaId)
        {
            using var _context = new DataContext();

            try
            {
                var entity = _context.ArticuloTemporales.Find(id);

                if (entity == null)
                {
                    return new ResultDTO
                    {
                        State = false,
                        Message = "No se encontro el dato solicitado"
                    };
                }

                var result = _mapper.Map<ArticuloTemporalDTO>(entity);

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
    }
}
