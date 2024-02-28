using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Sidkenu.AccesoDatos.Constantes;
using Sidkenu.AccesoDatos.Entidades.Seguridad;
using Sidkenu.Infraestructura;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Base;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Seguridad.PuestoTrabajo;
using Sidkenu.LogicaNegocio.Servicios.Implementacion.Base;
using Sidkenu.LogicaNegocio.Servicios.Interface.Seguridad;
using System.Linq.Expressions;

namespace Sidkenu.LogicaNegocio.Servicios.Implementacion.Seguridad
{
    public class PuestoTrabajoServicio : ServicioBase, IPuestoTrabajoServicio
    {
        private readonly IPasswordServicio _passwordServicio;

        public PuestoTrabajoServicio(IMapper mapper,
                                     IConfiguracionServicio configuracionServicio,
                                     IPasswordServicio passwordServicio)
                                     : base(mapper, configuracionServicio)
        {
            _passwordServicio = passwordServicio;
        }

        public ResultDTO Add(PuestoTrabajoPersistenciaDTO entidad, string user)
        {
            using var _context = new DataContext();

            try
            {
                var existeEntidad = VerificarSiExiste(entidad.EmpresaId, entidad.SerialNumber);

                if (existeEntidad)
                    return new ResultDTO
                    {
                        Message = "Los datos ingresados ya existen",
                        State = false,
                    };

                var entity = _mapper.Map<PuestoTrabajo>(entidad);

                entity.User = user;
                entity.EstaEliminado = false;
                entity.SerialNumber = _passwordServicio.Hash(entidad.SerialNumber);

                _context.PuestosTrabajos.Add(entity);

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

        public ResultDTO Update(PuestoTrabajoPersistenciaDTO entidad, string user)
        {
            using var _context = new DataContext();

            try
            {
                var entityActual = _context.PuestosTrabajos.Find(entidad.Id);    
                
                if (entityActual == null)
                {
                    return new ResultDTO
                    {
                        Message = "Ocurrio un error al obtener los datos del Puesto de Trabajo",
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

                var entity = _mapper.Map<PuestoTrabajo>(entidad);

                entity.User = user;

                _context.PuestosTrabajos.Update(entity);

                _context.SaveChanges();

                return new ResultDTO
                {
                    State = true,
                    Data = _mapper.Map<PuestoTrabajoDTO>(entity),
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

        public ResultDTO Delete(PuestoTrabajoDeleteDTO deleteDTO, string user)
        {
            using var _context = new DataContext();

            try
            {
                var entidad = _context.PuestosTrabajos.Find(deleteDTO.Id);

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
                var entities =_context.PuestosTrabajos.ToList();
                
                return new ResultDTO
                {
                    State = true,
                    Data = _mapper.Map<IEnumerable<PuestoTrabajoDTO>>(entities)
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

        public ResultDTO GetByFilter(PuestoTrabajoFilterDTO filter)
        {
            using var _context = new DataContext();

            try
            {
                filter.CadenaBuscar = !string.IsNullOrEmpty(filter.CadenaBuscar) ? filter.CadenaBuscar : string.Empty;

                Expression<Func<PuestoTrabajo, bool>> filtro = filtro => true;

                filtro = filtro.And(x => x.EmpresaId == filter.EmpresaId);

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

                var entities = _context.PuestosTrabajos
                    .AsNoTracking()
                    .Where(filtro)
                    .ToList();

                return new ResultDTO
                {
                    State = true,
                    Data = _mapper.Map<IEnumerable<PuestoTrabajoDTO>>(entities)
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
                var entity = _context.PuestosTrabajos.Find(id);

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
                    Data = _mapper.Map<PuestoTrabajoDTO>(entity)
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

        public ResultDTO GetByNumeroSerie(string numeroSerie, Guid empresaId)
        {
            using var _context = new DataContext();

            try
            {
                var _puestoTrabajo = new PuestoTrabajo();

                var entities = _context.PuestosTrabajos
                    .AsNoTracking()
                    .Where(x => !x.EstaEliminado && x.EmpresaId == empresaId)
                    .ToList();

                foreach (var entity in entities) 
                {
                    if (_passwordServicio.Check(entity.SerialNumber, numeroSerie))
                    {
                        _puestoTrabajo = entity;
                        break;
                    }
                }

                return new ResultDTO
                {
                    State = true,
                    Data = _mapper.Map<PuestoTrabajoDTO>(_puestoTrabajo)
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

        private bool VerificarSiExiste(Guid empresaId, string numeroSerie, Guid? id = null)
        {
            using var _context = new DataContext();

            var entidades = _context.PuestosTrabajos
                .AsNoTracking()
                .Where(x => x.EmpresaId == empresaId)
                .ToList();

            if (entidades != null && entidades.Any())
            {
                var existe = false;

                foreach (var puesto in entidades)
                {
                    existe = _passwordServicio.Check(puesto.SerialNumber, numeroSerie);

                    if (existe)
                        break;
                }

                return existe;
            }
            else
            {
                return false;
            }
        }
    }
}
