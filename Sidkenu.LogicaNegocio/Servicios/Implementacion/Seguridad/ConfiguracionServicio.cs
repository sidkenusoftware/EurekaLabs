using AutoMapper;
using Sidkenu.AccesoDatos.Entidades.Seguridad;
using Sidkenu.AccesoDatos.Infraestructura;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Base;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Seguridad.Configuracion;
using Sidkenu.LogicaNegocio.Servicios.Implementacion.Base;
using Sidkenu.LogicaNegocio.Servicios.Interface.Seguridad;

namespace Sidkenu.LogicaNegocio.Servicios.Implementacion.Seguridad
{
    public class ConfiguracionServicio : ServicioBase, IConfiguracionServicio
    {
        public ConfiguracionServicio(IMapper mapper)
                                     : base(mapper)
        {

        }

        public ResultDTO AddOrUpdate(ConfiguracionPersistenciaDTO entidad, string user)
        {
            try
            {
                using var _context = new DataContext();

                var entityActual = _context.ConfiguracionesSeguridad.Find(entidad.Id);

                var entity = _mapper.Map<ConfiguracionSeguridad>(entidad);

                entity.User = user;

                if (entityActual == null)
                {
                    // Insert                    
                    _context.ConfiguracionesSeguridad.Add(entity);
                }
                else
                {
                    // Update
                    _context.ConfiguracionesSeguridad.Update(entity);
                }

                _context.SaveChanges();

                return new ResultDTO
                {
                    State = true,
                    Data = _mapper.Map<ConfiguracionDTO>(entity),
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

        public ResultDTO Get()
        {
            try
            {
                using var _context = new DataContext();

                var entities = _context.ConfiguracionesSeguridad.ToList();

                if (entities == null && entities.Any())
                {
                    return new ResultDTO
                    {
                        State = false,
                        Data = null
                    };
                }

                return new ResultDTO
                {
                    State = true,
                    Data = _mapper.Map<ConfiguracionDTO>(entities.FirstOrDefault())
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
