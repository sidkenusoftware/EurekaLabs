using AutoMapper;
using Sidkenu.AccesoDatos.Constantes;
using Sidkenu.AccesoDatos.Entidades.Core;
using Sidkenu.AccesoDatos.Infraestructura;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Base;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.UnidadMedida;
using Sidkenu.LogicaNegocio.Servicios.Implementacion.Base;
using Sidkenu.LogicaNegocio.Servicios.Interface.Core;
using Sidkenu.LogicaNegocio.Servicios.Interface.Seguridad;
using System.Data.Entity;
using System.Linq.Expressions;

namespace Sidkenu.LogicaNegocio.Servicios.Implementacion.Core
{
    public class UnidadMedidaServicio : ServicioBase, IUnidadMedidaServicio
    {
        public UnidadMedidaServicio(IMapper mapper,
                                 IConfiguracionServicio configuracionServicio)
                                 : base(mapper, configuracionServicio)
        {
        }

        public ResultDTO Add(UnidadMedidaPersistenciaDTO entidad, string user)
        {
            using var _context = new DataContext();

            // using var transaction = _context.Database.BeginTransaction();

            try
            {
                var existeEntidad = VerificarSiExiste(entidad.Descripcion, entidad.EmpresaId);

                if (existeEntidad)
                    return new ResultDTO
                    {
                        Message = "Los datos ingresados ya existen",
                        State = false,
                    };

                var entity = _mapper.Map<UnidadMedida>(entidad);

                entity.User = user;
                entity.EstaEliminado = false;

                _context.UnidadMedidas.Add(entity);

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

        public ResultDTO Update(UnidadMedidaPersistenciaDTO entidad, string user)
        {
            using var _context = new DataContext();

            // using var transaction = _context.Database.BeginTransaction();

            try
            {
                var entityActual = _context.UnidadMedidas.Find(entidad.Id);

                if (entityActual == null)
                {
                    return new ResultDTO
                    {
                        Message = "Ocurrio un error al obtener los datos de la Unidad Medida",
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

                var entity = _mapper.Map<UnidadMedida>(entidad);

                entity.User = user;

                _context.UnidadMedidas.Update(entity);

                _context.SaveChanges();

                return new ResultDTO
                {
                    State = true,
                    Data = _mapper.Map<UnidadMedidaDTO>(entity),
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

        public ResultDTO Delete(UnidadMedidaDeleteDTO deleteDTO, string user)
        {
            using var _context = new DataContext();

            // using var transaction = _context.Database.BeginTransaction();

            try
            {
                var entidad = _context.UnidadMedidas.Find(deleteDTO.Id);

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

            // using var transaction = _context.Database.BeginTransaction();

            try
            {
                var entities = _context.UnidadMedidas
                    .AsNoTracking()
                    .ToList();

                return new ResultDTO
                {
                    State = true,
                    Data = _mapper.Map<IEnumerable<UnidadMedidaDTO>>(entities)
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
                Expression<Func<UnidadMedida, bool>> filtro = filtro => true;

                filtro = filtro.And(x => x.EmpresaId == empresaId || x.EmpresaId == null);

                var entities = _context.UnidadMedidas
                    .AsNoTracking()
                    .Where(filtro)
                    .ToList();

                return new ResultDTO
                {
                    State = true,
                    Data = _mapper.Map<IEnumerable<UnidadMedidaDTO>>(entities)
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

        public ResultDTO GetByFilter(UnidadMedidaFilterDTO filter)
        {
            using var _context = new DataContext();

            // using var transaction = _context.Database.BeginTransaction();

            try
            {
                filter.CadenaBuscar = !string.IsNullOrEmpty(filter.CadenaBuscar) ? filter.CadenaBuscar : string.Empty;

                Expression<Func<UnidadMedida, bool>> filtro = filtro => true;

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

                var entities = _context.UnidadMedidas
                    .AsNoTracking()
                    .Where(filtro)
                    .ToList();

                return new ResultDTO
                {
                    State = true,
                    Data = _mapper.Map<IEnumerable<UnidadMedidaDTO>>(entities)
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
                var entity = _context.UnidadMedidas.Find(id);

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
                    Data = _mapper.Map<UnidadMedidaDTO>(entity)
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

            // using var transaction = _context.Database.BeginTransaction();

            if (id == null)
            {
                if (empresaId.HasValue)
                {
                    return _context.UnidadMedidas.Any(x => x.EmpresaId == empresaId.Value && x.Descripcion.ToLower() == descripcion.ToLower());
                }
                else
                {
                    return _context.UnidadMedidas.Any(x => x.Descripcion.ToLower() == descripcion.ToLower());
                }
            }
            else
            {
                if (empresaId.HasValue)
                {
                    return _context.UnidadMedidas.Any(x => x.Id != id.Value
                                                           && x.EmpresaId == empresaId
                                                           && x.Descripcion.ToLower() == descripcion.ToLower());
                }
                else
                {
                    return _context.UnidadMedidas.Any(x => x.Id != id.Value
                                                           && x.Descripcion.ToLower() == descripcion.ToLower());
                }
            }
        }
    }
}
