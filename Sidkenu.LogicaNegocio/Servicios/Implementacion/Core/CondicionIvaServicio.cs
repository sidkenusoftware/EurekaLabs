using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Sidkenu.AccesoDatos.Constantes;
using Sidkenu.AccesoDatos.Entidades.Core;
using Sidkenu.AccesoDatos.Infraestructura;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Base;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.CondicionIva;
using Sidkenu.LogicaNegocio.Servicios.Implementacion.Base;
using Sidkenu.LogicaNegocio.Servicios.Interface.Core;
using Sidkenu.LogicaNegocio.Servicios.Interface.Seguridad;
using System.Linq.Expressions;

namespace Sidkenu.LogicaNegocio.Servicios.Implementacion.Core
{
    public class CondicionIvaServicio : ServicioBase, ICondicionIvaServicio
    {
        public CondicionIvaServicio(IMapper mapper,
                                    IConfiguracionServicio configuracionServicio)
                                    : base(mapper, configuracionServicio)
        {
        }

        public ResultDTO Add(CondicionIvaPersistenciaDTO entidad, string user)
        {
            using var _context = new DataContext();

            try
            {
                var existeEntidad = VerificarSiExiste(entidad.Descripcion, entidad.EmpresaId);

                if (existeEntidad)
                    return new ResultDTO
                    {
                        Message = "Los datos ingresados ya existen",
                        State = false,
                    };

                var entity = _mapper.Map<CondicionIva>(entidad);

                entity.User = user;
                entity.EstaEliminado = false;

                _context.CondicionIvas.Add(entity);

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

        public ResultDTO Update(CondicionIvaPersistenciaDTO entidad, string user)
        {
            using var _context = new DataContext();

            try
            {   
                var entityActual = _context.CondicionIvas.Find(entidad.Id);

                if (entityActual == null)
                {
                    return new ResultDTO
                    {
                        Message = "Ocurrio un error al obtener los datos de la CondicionIva",
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

                var entity = _mapper.Map<CondicionIva>(entidad);

                entity.User = user;

                _context.CondicionIvas.Update(entity);

                _context.SaveChanges();

                return new ResultDTO
                {
                    State = true,
                    Data = _mapper.Map<CondicionIvaDTO>(entity),
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

        public ResultDTO Delete(CondicionIvaDeleteDTO deleteDTO, string user)
        {
            using var _context = new DataContext();

            try
            {
                var entidad = _context.CondicionIvas.Find(deleteDTO.Id);

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

        public ResultDTO GetAll()
        {
            using var _context = new DataContext();

            try
            {
                var entities = _context.CondicionIvas
                    .AsNoTracking()
                    .ToList();

                return new ResultDTO
                {
                    State = true,
                    Data = _mapper.Map<IEnumerable<CondicionIvaDTO>>(entities)
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
                Expression<Func<CondicionIva, bool>> filtro = filtro => true;
                filtro = filtro.And(x => x.EmpresaId == empresaId || x.EmpresaId == null);

                var entities = _context.CondicionIvas
                    .AsNoTracking()
                    .Where(filtro)
                    .OrderBy(x=>x.Descripcion)
                    .ToList();

                return new ResultDTO
                {
                    State = true,
                    Data = _mapper.Map<IEnumerable<CondicionIvaDTO>>(entities)
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

        public ResultDTO GetByFilter(CondicionIvaFilterDTO filter)
        {
            using var _context = new DataContext();

            try
            {
                filter.CadenaBuscar = !string.IsNullOrEmpty(filter.CadenaBuscar) ? filter.CadenaBuscar : string.Empty;

                Expression<Func<CondicionIva, bool>> filtro = filtro => true;

                filtro = filtro.And(x => x.EmpresaId == filter.EmpresaId || x.EmpresaId == null);

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
                    && x.Descripcion.ToLower().Contains(filter.CadenaBuscar.ToLower()));
                }

                var entities = _context.CondicionIvas
                    .AsNoTracking()
                    .Where(filtro)
                    .OrderBy(x=>x.Descripcion)
                    .ToList();

                return new ResultDTO
                {
                    State = true,
                    Data = _mapper.Map<IEnumerable<CondicionIvaDTO>>(entities)
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
                var entity = _context.CondicionIvas.Find(id);

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
                    Data = _mapper.Map<CondicionIvaDTO>(entity)
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
        private bool VerificarSiExiste(string descripcion, Guid? empresaId, Guid? id = null)
        {
            using var _context = new DataContext();

            if (id == null)
            {
                if (empresaId.HasValue)
                {
                    return _context.CondicionIvas
                        .Any(x => x.EmpresaId == empresaId.Value && x.Descripcion.ToLower() == descripcion.ToLower());
                }
                else
                {
                    return _context.CondicionIvas
                        .Any(x => x.Descripcion.ToLower() == descripcion.ToLower());
                }
            }
            else
            {
                if (empresaId.HasValue)
                {
                    return _context.CondicionIvas.Any(x => x.Id != id.Value
                                                           && x.EmpresaId == empresaId
                                                           && x.Descripcion.ToLower() == descripcion.ToLower());
                }
                else
                {
                    return _context.CondicionIvas.Any(x => x.Id != id.Value
                                                           && x.Descripcion.ToLower() == descripcion.ToLower());
                }
            }
        }
    }
}
