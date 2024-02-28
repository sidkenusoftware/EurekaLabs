using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Sidkenu.AccesoDatos.Entidades.Seguridad;
using Sidkenu.Infraestructura;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Base;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Seguridad.Modulo;
using Sidkenu.LogicaNegocio.Servicios.Implementacion.Base;
using Sidkenu.LogicaNegocio.Servicios.Interface.Seguridad;

namespace Sidkenu.LogicaNegocio.Servicios.Implementacion.Seguridad
{
    public class ModuloServicio : ServicioBase, IModuloServicio
    {
        public ModuloServicio(IMapper mapper,
            IConfiguracionServicio configuracionServicio)
            : base(mapper,configuracionServicio)
        {
        }

        public ResultDTO AddOrUpdate(ModuloPersistenciaDTO entidad, string user)
        {
            using var _context = new DataContext();

            try
            {
                var entity = _mapper.Map<Modulo>(entidad);

                entity.User = user;

                if (entidad.Id != Guid.Empty)
                {
                    _context.Modulos.Update(entity);
                }
                else
                {
                    _context.Modulos.Add(entity);
                }

                _context.SaveChanges();

                return new ResultDTO
                {
                    State = true,
                    Data = _mapper.Map<ModuloDTO>(entity),
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
                var entities = _context.Modulos
                    .AsNoTracking()
                    .Where(x => x.EmpresaId == empresaId)
                    .ToList();

                if (entities == null)
                {
                    return new ResultDTO
                    {
                        State = true,
                        Data = null
                    };
                }

                return new ResultDTO
                {
                    State = true,
                    Data = _mapper.Map<ModuloDTO>(entities.FirstOrDefault())
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
