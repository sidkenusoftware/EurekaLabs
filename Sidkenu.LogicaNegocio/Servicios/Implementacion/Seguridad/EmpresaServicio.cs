using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Sidkenu.AccesoDatos.Constantes;
using Sidkenu.AccesoDatos.Entidades.Seguridad;
using Sidkenu.AccesoDatos.Infraestructura;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Base;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Seguridad.Empresa;
using Sidkenu.LogicaNegocio.Servicios.Implementacion.Base;
using Sidkenu.LogicaNegocio.Servicios.Interface.Seguridad;
using System.Linq.Expressions;

namespace Sidkenu.LogicaNegocio.Servicios.Implementacion.Seguridad
{
    public class EmpresaServicio : ServicioBase, IEmpresaServicio
    {
        public EmpresaServicio(IMapper mapper,
                               IConfiguracionServicio configuracionServicio)
                               : base(mapper,configuracionServicio)
        {
        }

        public ResultDTO Add(EmpresaPersistenciaDTO entidad, string user)
        {
            using var _context = new DataContext();

            try
            {
                var _existenEmpresasCargadas = _context.Empresas.Any();

                var existeEntidad = VerificarSiExiste(entidad.Descripcion);

                if (existeEntidad)
                    return new ResultDTO
                    {
                        Message = "Los datos ingresados ya existen",
                        State = false,
                    };

                var entity = _mapper.Map<Empresa>(entidad);

                entity.User = user;
                entity.EstaEliminado = false;

                entity.Modulos = new List<Modulo>();

                entity.Modulos.Add(new Modulo
                {
                    Compra = false,
                    Fabricacion = false,
                    Inventario = false,
                    PuntoVenta = false,
                    Seguridad = true,
                    Venta = false,
                    User = user,
                    EstaEliminado = false,
                });

                _context.Empresas.Add(entity);

                if (_existenEmpresasCargadas)
                {
                    var grupoAdmin = new Grupo
                    {
                        Descripcion = "Administrador",
                        PorDefecto = true,
                        User = user,
                        EstaEliminado = false,
                        EmpresaId = entity.Id,
                        GrupoFormularios = new List<GrupoFormulario>()
                    };

                    _context.Grupos.Add(grupoAdmin);

                    foreach (var formulario in _context.Formularios.ToList())
                    {
                        var grupoFormulario = new GrupoFormulario
                        {
                            GrupoId = grupoAdmin.Id,
                            FormularioId = formulario.Id,
                            EstaEliminado = false,
                            User = user,
                        };

                        _context.GruposFormularios.Add(grupoFormulario);
                    }

                    var userLogin = _context.Usuarios.Where(x => x.Nombre == user).ToList();

                    if (userLogin != null)
                    {
                        var grupoPersona = new GrupoPersona
                        {
                            GrupoId = grupoAdmin.Id,
                            EstaEliminado = false,
                            PersonaId = userLogin.First().PersonaId,
                            User = user
                        };

                        _context.GruposPersonas.Add(grupoPersona);
                    }
                }

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

        public ResultDTO Update(EmpresaPersistenciaDTO entidad, string user)
        {
            using var _context = new DataContext();

            try
            {
                var entityActual = _context.Empresas.Find(entidad.Id);

                if (entityActual == null)
                {
                    return new ResultDTO
                    {
                        Message = "Ocurrio un error al obtener los datos del Empresa",
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

                var entity = _mapper.Map<Empresa>(entidad);

                entity.User = user;

                _context.Empresas.Update(entity);

                _context.SaveChanges();

                return new ResultDTO
                {
                    State = true,
                    Data = _mapper.Map<EmpresaDTO>(entity),
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

        public ResultDTO Delete(EmpresaDeleteDTO deleteDTO, string user)
        {
            using var _context = new DataContext();

            try
            {
                var entidad = _context.Empresas.Find(deleteDTO.Id);

                if (entidad == null)
                {
                    return new ResultDTO
                    {
                        Message = "Ocurrio un error al obtener los datos",
                        State = false
                    };
                }

                _context.Empresas.Remove(entidad);

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
                var entities = _context.Empresas
                    .AsNoTracking()
                    .Include(ms => ms.TipoResponsabilidad)
                                     .Include(ib => ib.IngresoBruto)
                                     .Include(ms => ms.Localidad).ThenInclude(ms => ms.Provincia)
                    .ToList();                    
                    
                return new ResultDTO
                {
                    State = true,
                    Data = _mapper.Map<IEnumerable<EmpresaDTO>>(entities)
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

        public ResultDTO GetByFilter(EmpresaFilterDTO filter)
        {
            using var _context = new DataContext();

            try
            {
                filter.CadenaBuscar = !string.IsNullOrEmpty(filter.CadenaBuscar) ? filter.CadenaBuscar : string.Empty;

                Expression<Func<Empresa, bool>> filtro = filtro => true;

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
                                || x.Abreviatura.ToLower().Contains(cadena.ToLower())
                                || x.Localidad.Descripcion.ToLower().Contains(cadena.ToLower())
                                || x.Localidad.Provincia.Descripcion.ToLower().Contains(cadena.ToLower())
                                || x.TipoResponsabilidad.Descripcion.ToLower().Contains(cadena.ToLower())
                                || x.IngresoBruto.Descripcion.ToLower().Contains(cadena.ToLower())
                                || x.Cuit == cadena));

                            primeraPasada = false;
                        }
                        else
                        {
                            filtro = filtro.Or(x => x.EstaEliminado == filter.VerEliminados
                                && (x.Descripcion.ToLower().Contains(cadena.ToLower())
                                || x.Abreviatura.ToLower().Contains(cadena.ToLower())
                                || x.Localidad.Descripcion.ToLower().Contains(cadena.ToLower())
                                || x.Localidad.Provincia.Descripcion.ToLower().Contains(cadena.ToLower())
                                || x.TipoResponsabilidad.Descripcion.ToLower().Contains(cadena.ToLower())
                                || x.IngresoBruto.Descripcion.ToLower().Contains(cadena.ToLower())
                                || x.Cuit == cadena));
                        }
                    }
                }
                else
                {
                    filtro = filtro.And(x => x.EstaEliminado == filter.VerEliminados
                                && (x.Descripcion.ToLower().Contains(filter.CadenaBuscar.ToLower())
                                || x.Abreviatura.ToLower().Contains(filter.CadenaBuscar.ToLower())
                                || x.Localidad.Descripcion.ToLower().Contains(filter.CadenaBuscar.ToLower())
                                || x.Localidad.Provincia.Descripcion.ToLower().Contains(filter.CadenaBuscar.ToLower())
                                || x.TipoResponsabilidad.Descripcion.ToLower().Contains(filter.CadenaBuscar.ToLower())
                                || x.IngresoBruto.Descripcion.ToLower().Contains(filter.CadenaBuscar.ToLower())
                                || x.Cuit == filter.CadenaBuscar));
                }

                var entities = _context.Empresas
                    .AsNoTracking()
                    .Include(ms => ms.TipoResponsabilidad)
                    .Include(ib => ib.IngresoBruto)
                    .Include(ms => ms.Localidad).ThenInclude(ms => ms.Provincia)
                    .Where(filtro)
                    .ToList();
                    
                return new ResultDTO
                {
                    State = true,
                    Data = _mapper.Map<IEnumerable<EmpresaDTO>>(entities)
                };
            }
            catch (Exception ex)
            {
                return new ResultDTO
                {
                    Message = $"Ocurrió un error grave al obener los datos - {ex.Message}",
                    State = false
                };
            }
        }

        public ResultDTO GetById(Guid id)
        {
            using var _context = new DataContext();

            try
            {
                var entity = _context.Empresas
                    .AsNoTracking()
                    .Include(x => x.TipoResponsabilidad)
                    .Include(x => x.IngresoBruto)
                    .Include(x => x.Localidad).ThenInclude(x => x.Provincia)
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
                    Data = _mapper.Map<EmpresaDTO>(entity)
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
                return _context.Empresas.Any(x => x.Descripcion.ToLower() == descripcion.ToLower());
            }
            else
            {
                return _context.Empresas.Any(x => x.Id != id.Value
                    && x.Descripcion.ToLower() == descripcion.ToLower());
            }
        }
    }
}
