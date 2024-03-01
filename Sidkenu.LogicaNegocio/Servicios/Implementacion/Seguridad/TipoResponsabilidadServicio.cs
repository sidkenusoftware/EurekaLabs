using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Sidkenu.AccesoDatos.Constantes;
using Sidkenu.AccesoDatos.Entidades.Seguridad;
using Sidkenu.AccesoDatos.Infraestructura;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Base;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Seguridad.TipoResponsabilidad;
using Sidkenu.LogicaNegocio.Servicios.Implementacion.Base;
using Sidkenu.LogicaNegocio.Servicios.Interface.Seguridad;
using System.Linq.Expressions;

namespace Sidkenu.LogicaNegocio.Servicios.Implementacion.Seguridad
{
    public class TipoResponsabilidadServicio : ServicioBase, ITipoResponsabilidadServicio
    {
        public TipoResponsabilidadServicio(IMapper mapper,
                                    IConfiguracionServicio configuracionServicio)
                                    : base(mapper, configuracionServicio)
        {
        }

        public ResultDTO Add(TipoResponsabilidadPersistenciaDTO entidad, string user)
        {
            using var _context = new DataContext();

            try
            {
                var existeEntidad = VerificarSiExiste(entidad.Descripcion);

                if (existeEntidad)
                    return new ResultDTO
                    {
                        Message = "Los datos ingresados ya existen",
                        State = false,
                    };

                var entity = _mapper.Map<TipoResponsabilidad>(entidad);

                entity.User = user;
                entity.EstaEliminado = false;

                _context.TipoResponsabilidades.Add(entity);

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

        public ResultDTO Update(TipoResponsabilidadPersistenciaDTO entidad, string user)
        {
            using var _context = new DataContext();

            try
            {
                var entityActual = _context.TipoResponsabilidades
                    .Find(entidad.Id);

                if (entityActual == null)
                {
                    return new ResultDTO
                    {
                        Message = "Ocurrió un error al obtener los datos del Condición de Iva",
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

                var entity = _mapper.Map<TipoResponsabilidad>(entidad);

                entity.User = user;

                _context.TipoResponsabilidades.Update(entity);

                _context.SaveChanges();

                return new ResultDTO
                {
                    State = true,
                    Data = _mapper.Map<TipoResponsabilidadDTO>(entity),
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

        public ResultDTO Delete(TipoResponsabilidadDeleteDTO deleteDTO, string user)
        {
            using var _context = new DataContext();

            try
            {
                var entidad = _context.TipoResponsabilidades.Find(deleteDTO.Id);    
                
                if (entidad == null)
                {
                    return new ResultDTO
                    {
                        Message = "Ocurrió un error al obtener los datos",
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

        public ResultDTO GetAll()
        {
            using var _context = new DataContext();

            try
            {
                var entities = _context.TipoResponsabilidades.ToList();

                return new ResultDTO
                {
                    State = true,
                    Data = _mapper.Map<IEnumerable<TipoResponsabilidadDTO>>(entities)
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

        public ResultDTO GetByFilter(TipoResponsabilidadFilterDTO filter)
        {
            using var _context = new DataContext();

            try
            {
                filter.CadenaBuscar = !string.IsNullOrEmpty(filter.CadenaBuscar) ? filter.CadenaBuscar : string.Empty;

                Expression<Func<TipoResponsabilidad, bool>> filtro = filtro => true;

                int.TryParse(filter.CadenaBuscar, out int codigo);

                if (filter.CadenaBuscar.IndexOf(SeparacionFiltroBusqueda.CaracterSeparador) != -1)
                {
                    var primeraPasada = true;

                    var listaCadenas = filter.CadenaBuscar.Split(SeparacionFiltroBusqueda.CaracterSeparador, StringSplitOptions.RemoveEmptyEntries);

                    foreach (var cadena in listaCadenas)
                    {
                        if (primeraPasada)
                        {
                            filtro = filtro.And(x => x.EstaEliminado == filter.VerEliminados
                                && x.Descripcion.ToLower().Contains(cadena.ToLower()));

                            primeraPasada = false;
                        }
                        else
                        {
                            filtro = filtro.Or(x => x.EstaEliminado == filter.VerEliminados
                                && x.Descripcion.ToLower().Contains(cadena.ToLower()));
                        }
                    }
                }
                else
                {
                    filtro = filtro.And(x => x.EstaEliminado == filter.VerEliminados
                                && (x.Descripcion.ToLower().Contains(filter.CadenaBuscar.ToLower())
                                || x.Codigo == codigo));
                }

                var entities = _context.TipoResponsabilidades
                    .AsNoTracking()
                    .Where(filtro)
                    .ToList();

                return new ResultDTO
                {
                    State = true,
                    Data = _mapper.Map<IEnumerable<TipoResponsabilidadDTO>>(entities)
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

            try
            {
                var entity = _context.TipoResponsabilidades
                    .Find(id);

                if (entity == null)
                {
                    return new ResultDTO
                    {
                        State = false,
                        Message = "No se encontró el dato solicitado"
                    };
                }

                return new ResultDTO
                {
                    State = true,
                    Data = _mapper.Map<TipoResponsabilidadDTO>(entity)
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
        private bool VerificarSiExiste(string descripcion, Guid? id = null)
        {
            using var _context = new DataContext();

            if (id == null)
                {
                    return _context.TipoResponsabilidades.Any(x => x.Descripcion.ToLower() == descripcion.ToLower());
                }
                else
                {
                    return _context.TipoResponsabilidades.Any(x => x.Id != id.Value
                                                                   && x.Descripcion.ToLower() == descripcion.ToLower());
                }
        }
    }
}
