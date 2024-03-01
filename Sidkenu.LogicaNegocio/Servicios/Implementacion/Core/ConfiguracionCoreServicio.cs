using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Sidkenu.AccesoDatos.Entidades.Core;
using Sidkenu.AccesoDatos.Infraestructura;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Base;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.ConfiguracionCore;
using Sidkenu.LogicaNegocio.Servicios.Implementacion.Base;
using Sidkenu.LogicaNegocio.Servicios.Interface.Core;
using Sidkenu.LogicaNegocio.Servicios.Interface.Seguridad;

namespace Sidkenu.LogicaNegocio.Servicios.Implementacion.Core
{
    public class ConfiguracionCoreServicio : ServicioBase, IConfiguracionCoreServicio
    {
        public ConfiguracionCoreServicio(IMapper mapper,
                                         IConfiguracionServicio configuracionServicio)
                                         : base(mapper, configuracionServicio)
        {
        }

        public ResultDTO AddOrUpdate(ConfiguracionCorePersistenciaDTO entidad, string userLogin)
        {
            using var _context = new DataContext();

            try
            {
                var entityActual = _context.ConfiguracionCores.Find(entidad.Id);

                var entity = _mapper.Map<ConfiguracionCore>(entidad);

                entity.User = userLogin;

                if (entityActual == null)
                {
                    // Insert                    
                    _context.ConfiguracionCores.Add(entity);
                }
                else
                {
                    // Update
                    _context.ConfiguracionCores.Update(entity);
                }

                _context.SaveChanges();

                return new ResultDTO
                {
                    State = true,
                    Data = _mapper.Map<ConfiguracionCoreDTO>(entity),
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
                var entity = _context.ConfiguracionCores
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
                    Data = _mapper.Map<ConfiguracionCoreDTO>(entity)
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
