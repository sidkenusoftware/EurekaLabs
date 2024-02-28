using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Sidkenu.AccesoDatos.Constantes;
using Sidkenu.AccesoDatos.Entidades.Core;
using Sidkenu.Infraestructura;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Base;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.Cliente;
using Sidkenu.LogicaNegocio.Servicios.Implementacion.Base;
using Sidkenu.LogicaNegocio.Servicios.Interface.Core;
using Sidkenu.LogicaNegocio.Servicios.Interface.Seguridad;
using System.Linq.Expressions;

namespace Sidkenu.LogicaNegocio.Servicios.Implementacion.Core
{
    public class ClienteServicio : ServicioBase, IClienteServicio
    {
        public ClienteServicio(IMapper mapper,
                               IConfiguracionServicio configuracionServicio)
                               : base(mapper, configuracionServicio)
        {
        }

        public ResultDTO Add(ClientePersistenciaDTO entidad, string user)
        {
            using var _context = new DataContext();

            try
            {
                var existeEntidad = VerificarSiExiste(entidad.Documento);

                if (existeEntidad)
                    return new ResultDTO
                    {
                        Message = "Los datos ingresados ya existen",
                        State = false,
                    };

                var entity = _mapper.Map<Cliente>(entidad);

                entity.User = user;
                entity.EstaEliminado = false;

                _context.Clientes.Add(entity);

                _context.SaveChanges();

                return new ResultDTO
                {
                    State = true,
                    Message = "Los datos se grabaron correctamente",
                    Data = _mapper.Map<ClienteDTO>(entity)
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

        public ResultDTO Update(ClientePersistenciaDTO entidad, string user)
        {
            using var _context = new DataContext();

            try
            {
                var entityActual = _context.Clientes.Find(entidad.Id);

                if (entityActual == null)
                {
                    return new ResultDTO
                    {
                        Message = "Ocurrió un error al obtener los datos del Cliente",
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

                var entity = _mapper.Map<Cliente>(entidad);

                entity.User = user;

                _context.Clientes.Update(entity);

                _context.SaveChanges();

                return new ResultDTO
                {
                    State = true,
                    Data = _mapper.Map<ClienteDTO>(entity),
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

        public ResultDTO Delete(ClienteDeleteDTO deleteDTO, string user)
        {
            using var _context = new DataContext();

            try
            {
                var entidad = _context.Clientes.Find(deleteDTO.Id);

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
                var entities = _context.Clientes
                    .AsNoTracking()
                    .Include(z => z.TipoDocumento)
                    .Include(z => z.TipoResponsabilidad)
                    .Include(z => z.ListaPrecio)
                    .ToList();
              
                return new ResultDTO
                {
                    State = true,
                    Data = _mapper.Map<IEnumerable<ClienteDTO>>(entities)
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

        public ResultDTO GetByFilter(ClienteFilterDTO filter)
        {
            using var _context = new DataContext();

            try
            {
                filter.CadenaBuscar = !string.IsNullOrEmpty(filter.CadenaBuscar) ? filter.CadenaBuscar : string.Empty;

                Expression<Func<Cliente, bool>> filtro = filtro => true;

                if (filter.CadenaBuscar.IndexOf(SeparacionFiltroBusqueda.CaracterSeparador) != -1)
                {
                    var primeraPasada = true;

                    var listaCadenas = filter.CadenaBuscar.Split(SeparacionFiltroBusqueda.CaracterSeparador, StringSplitOptions.RemoveEmptyEntries);

                    foreach (var cadena in listaCadenas)
                    {
                        if (primeraPasada)
                        {
                            filtro = filtro.And(x => x.EstaEliminado == filter.VerEliminados
                                && (x.RazonSocial.ToLower().Contains(cadena.ToLower())
                                || x.Documento == cadena));

                            primeraPasada = false;
                        }
                        else
                        {
                            filtro = filtro.Or(x => x.EstaEliminado == filter.VerEliminados
                                && (x.RazonSocial.ToLower().Contains(cadena.ToLower())
                                || x.Documento == cadena));
                        }
                    }
                }
                else
                {
                    filtro = filtro.And(x => x.EstaEliminado == filter.VerEliminados
                                && (x.RazonSocial.ToLower().Contains(filter.CadenaBuscar.ToLower())
                                || x.Documento == filter.CadenaBuscar));
                }

                filtro = filtro.And(x => x.Documento != ClientePorDefecto.NumeroDocumentoConsumidorFinal);

                var entities = _context.Clientes
                    .AsNoTracking()
                    .Include(z => z.TipoDocumento)
                    .Include(z => z.TipoResponsabilidad)
                    .Include(z => z.ListaPrecio)
                    .Where(filtro)
                    .ToList();
                
                return new ResultDTO
                {
                    State = true,
                    Data = _mapper.Map<IEnumerable<ClienteDTO>>(entities)
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

        public ResultDTO GetByFilterLookUp(ClienteFilterDTO filter)
        {
            using var _context = new DataContext();

            try
            {
                filter.CadenaBuscar = !string.IsNullOrEmpty(filter.CadenaBuscar) ? filter.CadenaBuscar : string.Empty;

                Expression<Func<Cliente, bool>> filtro = filtro => true;

                if (filter.CadenaBuscar.IndexOf(SeparacionFiltroBusqueda.CaracterSeparador) != -1)
                {
                    var primeraPasada = true;

                    var listaCadenas = filter.CadenaBuscar.Split(SeparacionFiltroBusqueda.CaracterSeparador, StringSplitOptions.RemoveEmptyEntries);

                    foreach (var cadena in listaCadenas)
                    {
                        if (primeraPasada)
                        {
                            filtro = filtro.And(x => x.EstaEliminado == filter.VerEliminados
                                && (x.RazonSocial.ToLower().Contains(cadena.ToLower())
                                || x.Documento == cadena));

                            primeraPasada = false;
                        }
                        else
                        {
                            filtro = filtro.Or(x => x.EstaEliminado == filter.VerEliminados
                                && (x.RazonSocial.ToLower().Contains(cadena.ToLower())
                                || x.Documento == cadena));
                        }
                    }
                }
                else
                {
                    filtro = filtro.And(x => x.EstaEliminado == filter.VerEliminados
                                && (x.RazonSocial.ToLower().Contains(filter.CadenaBuscar.ToLower())
                                || x.Documento == filter.CadenaBuscar));
                }

                filtro = filtro.And(x => x.Documento != ClientePorDefecto.NumeroDocumentoConsumidorFinal);

                var entities = _context.Clientes
                    .AsNoTracking()
                    .Include(z => z.TipoDocumento)
                    .Include(z => z.TipoResponsabilidad)
                    .Where(filtro)
                    .ToList();

                return new ResultDTO
                {
                    State = true,
                    Data = _mapper.Map<IEnumerable<ClienteDTO>>(entities)
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
                var entity = _context.Clientes
                    .Include(z => z.TipoDocumento)
                    .Include(z => z.TipoResponsabilidad)
                    .Include(z => z.ListaPrecio)
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
                    Data = _mapper.Map<ClienteDTO>(entity)
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

        public ResultDTO GetConsumidorFinal()
        {
            using var _context = new DataContext();

            try
            {
                var entity = _context.Clientes
                    .FirstOrDefault(x => x.Documento == ClientePorDefecto.NumeroDocumentoConsumidorFinal);

                if (entity == null)
                {
                    return new ResultDTO
                    {
                        State = false,
                        Message = "Ocurrio un error al obtener el cliente consumidor final"
                    };
                }

                return new ResultDTO
                {
                    State = true,
                    Data = _mapper.Map<ClienteDTO>(entity)
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

        public ResultDTO GetByNumeroDocumento(string numeroDocumento)
        {
            using var _context = new DataContext();

            try
            {
                Expression<Func<Cliente, bool>> filtro = filtro => true;

                filtro = filtro.And(x => x.Documento == numeroDocumento);

                var entities = _context.Clientes
                    .AsNoTracking()
                    .Include(z => z.TipoDocumento)
                    .Include(z => z.TipoResponsabilidad)
                    .Where(filtro)
                    .ToList();  

                var result = _mapper.Map<IEnumerable<ClienteDTO>>(entities);

                return new ResultDTO
                {
                    State = true,
                    Data = result.FirstOrDefault()
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

        // ------------------------------------------------------------------------------------------------------ //
        // ------------------------------             Metodos Privados              ----------------------------- //
        // ------------------------------------------------------------------------------------------------------ //
        
        private bool VerificarSiExiste(string descripcion, Guid? id = null)
        {
            using var _context = new DataContext();

            if (id == null)
            {
                return _context.Clientes.Any(x => x.Documento.ToLower() == descripcion.ToLower());
            }
            else
            {
                return _context.Clientes.Any(x => x.Id != id.Value
                                                  && x.Documento.ToLower() == descripcion.ToLower());
            }
        }
    }
}
