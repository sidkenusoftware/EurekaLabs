using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Sidkenu.AccesoDatos.Entidades.Core;
using Sidkenu.Infraestructura;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Base;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.ConfiguracionBalanza;
using Sidkenu.LogicaNegocio.Servicios.Implementacion.Base;
using Sidkenu.LogicaNegocio.Servicios.Interface.Core;
using Sidkenu.LogicaNegocio.Servicios.Interface.Seguridad;

namespace Sidkenu.LogicaNegocio.Servicios.Implementacion.Core
{
    public class ConfiguracionBalanzaServicio : ServicioBase, IConfiguracionBalanzaServicio
    {
        public ConfiguracionBalanzaServicio(IMapper mapper,
                                            IConfiguracionServicio configuracionServicio)
                                            : base(mapper, configuracionServicio)
        {
        }

        public ResultDTO AddOrUpdate(ConfiguracionBalanzaPersistenciaDTO entidad, string userLogin)
        {
            using var _context = new DataContext();

            try
            {
                var entityActual = _context.ConfiguracionBalanzas.Find(entidad.Id);

                var entity = _mapper.Map<ConfiguracionBalanza>(entidad);

                entity.User = userLogin;

                if (entityActual == null)
                {
                    // Insert                    
                    _context.ConfiguracionBalanzas.Add(entity);
                }
                else
                {
                    // Update
                    _context.ConfiguracionBalanzas.Update(entity);
                }

                _context.SaveChanges();

                return new ResultDTO
                {
                    State = true,
                    Data = _mapper.Map<ConfiguracionBalanzaDTO>(entity),
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

        public ResultDTO Get(Guid empresaId)
        {
            using var _context = new DataContext();

            try
            {
                var entity = _context.ConfiguracionBalanzas
                    .AsNoTracking()
                    .FirstOrDefault(x => x.EmpresaId == empresaId);

                if (entity == null)
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
                    Data = _mapper.Map<ConfiguracionBalanzaDTO>(entity)
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
