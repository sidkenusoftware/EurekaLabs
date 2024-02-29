using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Sidkenu.AccesoDatos.Constantes;
using Sidkenu.AccesoDatos.Constantes.Enum;
using Sidkenu.AccesoDatos.Entidades.Core;
using Sidkenu.Infraestructura;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Base;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.Deposito;
using Sidkenu.LogicaNegocio.Servicios.Implementacion.Base;
using Sidkenu.LogicaNegocio.Servicios.Interface.Core;
using Sidkenu.LogicaNegocio.Servicios.Interface.Seguridad;
using System.Linq;
using System.Linq.Expressions;
using System.Transactions;

namespace Sidkenu.LogicaNegocio.Servicios.Implementacion.Core
{
    public class DepositoServicio : ServicioBase, IDepositoServicio
    {
        public DepositoServicio(IMapper mapper,
                                IConfiguracionServicio configuracionServicio)
                                : base( mapper, configuracionServicio)
        {
        }

        public ResultDTO Add(DepositoPersistenciaDTO entidad, string user)
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

                var entity = _mapper.Map<Deposito>(entidad);

                entity.User = user;
                entity.EstaEliminado = false;

                var depositos = _context.Depositos
                    .AsNoTracking()
                    .Where(x => x.EmpresaId == entidad.EmpresaId && x.TipoDeposito == entidad.TipoDeposito)
                    .ToList();

                if (!depositos.Any())
                {
                    entity.Predeterminado = true;
                }
                else
                {
                    entity.Predeterminado = false;
                }

                _context.Depositos.Add(entity);

                var _articulos = _context.Articulos
                    .Where(x => !x.EstaEliminado && (x.EmpresaId == entidad.EmpresaId || x.EmpresaId == null));

                var _listaArticuloDeposito = new List<ArticuloDeposito>();

                _listaArticuloDeposito.AddRange(_articulos.Select(x => new ArticuloDeposito
                {
                    Id = Guid.NewGuid(),
                    ArticuloId = x.Id,
                    DepositoId = entity.Id,
                    Cantidad = 0m,
                    User = user,
                    EstaEliminado = false
                }));

                _context.ArticuloDepositos.AddRange(_listaArticuloDeposito);

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

        public ResultDTO Update(DepositoPersistenciaDTO entidad, string user)
        {
            using var _context = new DataContext();

            // using var transaction = _context.Database.BeginTransaction();

            try
            {
                var entityActual = _context.Depositos.Find(entidad.Id);

                if (entityActual == null)
                {
                    return new ResultDTO
                    {
                        Message = "Ocurrio un error al obtener los datos de la Deposito",
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

                var entity = _mapper.Map<Deposito>(entidad);

                entity.User = user;

                _context.Depositos.Update(entity);

                _context.SaveChanges();

                return new ResultDTO
                {
                    State = true,
                    Data = _mapper.Map<DepositoDTO>(entity),
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

        public ResultDTO Delete(DepositoDeleteDTO deleteDTO, string user)
        {
            using var _context = new DataContext();

            // using var transaction = _context.Database.BeginTransaction();

            try
            {
                var entidad = _context.Depositos.Find(deleteDTO.Id);

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
                var entities = _context.Depositos
                    .AsNoTracking()
                    .ToList();

                return new ResultDTO
                {
                    State = true,
                    Data = _mapper.Map<IEnumerable<DepositoDTO>>(entities)
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
                Expression<Func<Deposito, bool>> filtro = filtro => true;

                filtro = filtro.And(x => x.EmpresaId == empresaId);

                var entities = _context.Depositos
                    .AsNoTracking()
                    .Where(filtro)
                    .ToList();

                return new ResultDTO
                {
                    State = true,
                    Data = _mapper.Map<IEnumerable<DepositoDTO>>(entities)
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

        public ResultDTO GetByFilter(DepositoFilterDTO filter)
        {
            using var _context = new DataContext();

            // using var transaction = _context.Database.BeginTransaction();

            try
            {
                filter.CadenaBuscar = !string.IsNullOrEmpty(filter.CadenaBuscar) ? filter.CadenaBuscar : string.Empty;

                Expression<Func<Deposito, bool>> filtro = filtro => true;

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

                var entities = _context.Depositos
                    .AsNoTracking()
                    .Where(filtro)
                    .ToList();

                return new ResultDTO
                {
                    State = true,
                    Data = _mapper.Map<IEnumerable<DepositoDTO>>(entities)
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
                var entity = _context.Depositos.Find(id);

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
                    Data = _mapper.Map<DepositoDTO>(entity)
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

        // ========================================================================================================= //

        public ResultDTO MarcarComoPredeterminado(Guid depositoId, Guid empresaId, TipoDeposito tipoDeposito)
        {
            using var _context = new DataContext();            

            try
            {
                Expression<Func<Deposito, bool>> filtro = filtro => true;
                                
                filtro = filtro.And(x => (x.EmpresaId == empresaId || x.EmpresaId == null) && x.TipoDeposito == tipoDeposito);                

                var entities = _context.Depositos
                    .Where(filtro)
                    .ToList();

                if (entities.Any())
                {
                    foreach (var entity in entities)
                    {
                        if (entity.Id == depositoId)
                        {
                            entity.Predeterminado = true;
                        }
                        else
                        {
                            entity.Predeterminado = false;
                        }

                        _context.Depositos.Update(entity);
                    }
                }

                _context.SaveChanges();

                return new ResultDTO
                {
                    State = true,
                    Message = "Se marco como predeterminado el depósito correctamente"
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

        private bool VerificarSiExiste(string descripcion, Guid empresaId, Guid? id = null)
        {
            using var _context = new DataContext();

            // using var transaction = _context.Database.BeginTransaction();

            if (id == null)
            {

                return _context.Depositos.Any(x => x.EmpresaId == empresaId && x.Descripcion.ToLower() == descripcion.ToLower());
            }
            else
            {

                return _context.Depositos.Any(x => x.Id != id.Value
                                                   && x.EmpresaId == empresaId
                                                   && x.Descripcion.ToLower() == descripcion.ToLower());
            }
        }
    }
}
