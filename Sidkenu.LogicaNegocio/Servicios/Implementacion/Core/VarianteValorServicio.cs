using AutoMapper;
using Sidkenu.AccesoDatos.Constantes;
using Sidkenu.AccesoDatos.Entidades.Core;
using Sidkenu.AccesoDatos.Infraestructura;
using Sidkenu.Infraestructura;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Base;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.Variante;
using Sidkenu.LogicaNegocio.Servicios.Implementacion.Base;
using Sidkenu.LogicaNegocio.Servicios.Interface.Core;
using Sidkenu.LogicaNegocio.Servicios.Interface.Seguridad;
using System.Data.Entity;

namespace Sidkenu.LogicaNegocio.Servicios.Implementacion.Core
{
    public class VarianteValorServicio : ServicioBase, IVarianteValorServicio
    {
        public VarianteValorServicio(IMapper mapper,
                                     IConfiguracionServicio configuracionServicio)
                                     : base(mapper, configuracionServicio)
        {
        }

        public ResultDTO Add(ValorVariantePersistenciaDTO entidad, string user)
        {
            using var _context = new DataContext();

            // using var transaction = _context.Database.BeginTransaction();

            try
            {
                var existeEntidad = VerificarSiExiste(entidad.Codigo, entidad.Descripcion, entidad.VarianteId);

                if (existeEntidad)
                    return new ResultDTO
                    {
                        Message = "Los datos ingresados ya existen",
                        State = false,
                    };

                var entity = _mapper.Map<VarianteValor>(entidad);

                entity.User = user;
                entity.EstaEliminado = false;

                _context.VarianteValores.Add(entity);

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
        public ResultDTO Delete(ValorVarianteDeleteDTO deleteDTO, string user)
        {
            using var _context = new DataContext();

            // using var transaction = _context.Database.BeginTransaction();

            try
            {
                var entidad = _context.VarianteValores.Find(deleteDTO.Id);

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

        public ResultDTO GetAll(Guid escalaId)
        {
            using var _context = new DataContext();

            // using var transaction = _context.Database.BeginTransaction();

            try
            {
                var entities = _context.VarianteValores
                    .AsNoTracking()
                    .Where(x => x.Codigo.ToLower() != VarianteDefecto.VarianteValorCodigo && x.VarianteId == escalaId)
                    .ToList();

                return new ResultDTO
                {
                    State = true,
                    Data = _mapper.Map<IEnumerable<ValorVarianteDTO>>(entities)
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

        private bool VerificarSiExiste(string codigo, string descripcion, Guid escalaId, Guid? id = null)
        {
            using var _context = new DataContext();

            // using var transaction = _context.Database.BeginTransaction();

            if (id == null)
            {
                return _context.VarianteValores.Any(x => x.VarianteId == escalaId
                                                         && (x.Codigo.ToLower() == codigo.ToLower() || x.Descripcion.ToLower() == descripcion.ToLower()));
            }
            else
            {
                return _context.VarianteValores.Any(x => x.Id != id.Value
                                                         && x.VarianteId == escalaId
                                                         && (x.Codigo.ToLower() == codigo.ToLower() || x.Descripcion.ToLower() == descripcion.ToLower()));
            }
        }
    }
}
