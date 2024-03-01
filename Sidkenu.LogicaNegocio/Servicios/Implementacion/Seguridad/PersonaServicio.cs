using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Sidkenu.AccesoDatos.Constantes;
using Sidkenu.AccesoDatos.Entidades.Seguridad;
using Sidkenu.AccesoDatos.Infraestructura;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Base;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Seguridad.Persona;
using Sidkenu.LogicaNegocio.Servicios.Implementacion.Base;
using Sidkenu.LogicaNegocio.Servicios.Interface.Seguridad;
using System.Linq.Expressions;

namespace Sidkenu.LogicaNegocio.Servicios.Implementacion.Seguridad
{
    public class PersonaServicio : ServicioBase, IPersonaServicio
    {
        public PersonaServicio(IMapper mapper,
                               IConfiguracionServicio configuracionServicio)
                               : base(mapper, configuracionServicio)
        {
        }

        public ResultDTO Add(PersonaPersistenciaDTO entidad, string user)
        {
            using var _context = new DataContext();

            try
            {
                var existeEntidad = VerificarSiExiste(entidad.Cuil);

                if (existeEntidad)
                    return new ResultDTO
                    {
                        Message = "Los datos ingresados ya existen",
                        State = false,
                    };

                var entity = _mapper.Map<Persona>(entidad);

                entity.User = user;
                entity.EstaEliminado = false;

                _context.Personas.Add(entity);

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

        public ResultDTO Update(PersonaPersistenciaDTO entidad, string user)
        {
            using var _context = new DataContext();

            try
            {
                var entityActual = _context.Personas.Find(entidad.Id);
                
                if (entityActual == null)
                {
                    return new ResultDTO
                    {
                        Message = "Ocurrió un error al obtener los datos del Persona",
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

                var entity = _mapper.Map<Persona>(entidad);

                entity.User = user;

                _context.Personas.Update(entity);

                _context.SaveChanges();

                return new ResultDTO
                {
                    State = true,
                    Data = _mapper.Map<PersonaDTO>(entity),
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

        public ResultDTO Delete(PersonaDeleteDTO deleteDTO, string user)
        {
            using var _context = new DataContext();

            try
            {
                var entidad = _context.Personas.Find(deleteDTO.Id);

                if (entidad == null)
                {
                    return new ResultDTO
                    {
                        Message = "Ocurrió un error al obtener los datos",
                        State = false
                    };
                }

                _context.RemoveLogic(entidad, user);

                _context.SaveChanges(true);

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
                var entities = _context.Personas
                    .Include(u => u.Usuarios)
                    .ToList();
                
                return new ResultDTO
                {
                    State = true,
                    Data = _mapper.Map<IEnumerable<PersonaDTO>>(entities)
                };
            }
            catch (Exception ex)
            {
                return new ResultDTO
                {
                    Message = ErrorException.Mensaje(ex),
                    State = false
                };
            }
        }

        public ResultDTO GetByFilter(PersonaFilterDTO filter)
        {
            using var _context = new DataContext();

            try
            {
                filter.CadenaBuscar = !string.IsNullOrEmpty(filter.CadenaBuscar) ? filter.CadenaBuscar : string.Empty;

                Expression<Func<Persona, bool>> filtro = filtro => true;

                if (filter.CadenaBuscar.IndexOf(SeparacionFiltroBusqueda.CaracterSeparador) != -1)
                {
                    var primeraPasada = true;

                    var listaCadenas = filter.CadenaBuscar.Split(SeparacionFiltroBusqueda.CaracterSeparador, StringSplitOptions.RemoveEmptyEntries);

                    foreach (var cadena in listaCadenas)
                    {
                        if (primeraPasada)
                        {
                            filtro = filtro.And(x => x.EstaEliminado == filter.VerEliminados
                                && (x.Apellido.ToLower().Contains(cadena.ToLower())
                                || x.Nombre.ToLower().Contains(cadena.ToLower())
                                || x.Cuil == cadena));

                            primeraPasada = false;
                        }
                        else
                        {
                            filtro = filtro.Or(x => x.EstaEliminado == filter.VerEliminados
                                && (x.Apellido.ToLower().Contains(cadena.ToLower())
                                || x.Nombre.ToLower().Contains(cadena.ToLower())
                                || x.Cuil == cadena));
                        }
                    }
                }
                else
                {
                    filtro = filtro.And(x => x.EstaEliminado == filter.VerEliminados
                                && (x.Apellido.ToLower().Contains(filter.CadenaBuscar.ToLower())
                                || x.Nombre.ToLower().Contains(filter.CadenaBuscar.ToLower())
                                || x.Cuil == filter.CadenaBuscar));
                }

                var entities = _context.Personas
                    .AsNoTracking()
                    .Include(u => u.Usuarios)
                    .Where(filtro)
                    .ToList();

                return new ResultDTO
                {
                    State = true,
                    Data = _mapper.Map<IEnumerable<PersonaDTO>>(entities)
                };
            }
            catch (Exception ex)
            {
                return new ResultDTO
                {
                    Message = $"Ocurrió un error grave al obtener los datos - {ex.Message}",
                    State = false
                };
            }
        }

        public ResultDTO GetByFilterLookUp(PersonaFilterDTO filter)
        {
            using var _context = new DataContext();

            try
            {
                filter.CadenaBuscar = !string.IsNullOrEmpty(filter.CadenaBuscar) ? filter.CadenaBuscar : string.Empty;

                Expression<Func<Persona, bool>> filtro = filtro => true;

                if (filter.CadenaBuscar.IndexOf(SeparacionFiltroBusqueda.CaracterSeparador) != -1)
                {
                    var primeraPasada = true;

                    var listaCadenas = filter.CadenaBuscar.Split(SeparacionFiltroBusqueda.CaracterSeparador, StringSplitOptions.RemoveEmptyEntries);

                    foreach (var cadena in listaCadenas)
                    {
                        if (primeraPasada)
                        {
                            filtro = filtro.And(x => x.EstaEliminado == filter.VerEliminados
                                && (x.Apellido.ToLower().Contains(cadena.ToLower())
                                || x.Nombre.ToLower().Contains(cadena.ToLower())
                                || x.Cuil == cadena));

                            primeraPasada = false;
                        }
                        else
                        {
                            filtro = filtro.Or(x => x.EstaEliminado == filter.VerEliminados
                                && (x.Apellido.ToLower().Contains(cadena.ToLower())
                                || x.Nombre.ToLower().Contains(cadena.ToLower())
                                || x.Cuil == cadena));
                        }
                    }
                }
                else
                {
                    filtro = filtro.And(x => x.EstaEliminado == filter.VerEliminados
                                && (x.Apellido.ToLower().Contains(filter.CadenaBuscar.ToLower())
                                || x.Nombre.ToLower().Contains(filter.CadenaBuscar.ToLower())
                                || x.Cuil == filter.CadenaBuscar));
                }

                var entities = _context.Personas
                    .AsNoTracking()
                    .Include(u => u.Usuarios)
                    .Where(filtro)
                    .ToList();

                return new ResultDTO
                {
                    State = true,
                    Data = _mapper.Map<IEnumerable<PersonaDTO>>(entities)
                };
            }
            catch (Exception ex)
            {
                return new ResultDTO
                {
                    Message = $"Ocurrió un error grave al obtener los datos - {ex.Message}",
                    State = false
                };
            }
        }

        public ResultDTO GetById(Guid id)
        {
            using var _context = new DataContext();

            try
            {
                var entity = _context.Personas
                    .AsNoTracking()
                    .Include(u => u.Usuarios)
                    .FirstOrDefault(x => x.Id == id);

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
                    Data = _mapper.Map<PersonaDTO>(entity)
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
                return _context.Personas.Any(x => x.Cuil.ToLower() == descripcion.ToLower());
            }
            else
            {
                return _context.Personas.Any(x => x.Id != id.Value
                                              && x.Cuil.ToLower() == descripcion.ToLower());
            }
        }
    }
}
