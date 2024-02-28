using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Sidkenu.AccesoDatos.Constantes;
using Sidkenu.AccesoDatos.Entidades.Core;
using Sidkenu.Infraestructura;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Base;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.Cliente;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.CuentaCorrienteCliente;
using Sidkenu.LogicaNegocio.Servicios.Implementacion.Base;
using Sidkenu.LogicaNegocio.Servicios.Interface.Core;
using Sidkenu.LogicaNegocio.Servicios.Interface.Seguridad;
using System.Linq.Expressions;

namespace Sidkenu.LogicaNegocio.Servicios.Implementacion.Core
{
    public class CuentaCorrienteClienteServicio : ServicioBase, ICuentaCorrienteClienteServicio
    {
        public CuentaCorrienteClienteServicio(IMapper mapper,
                                              IConfiguracionServicio configuracionServicio)
                                              : base(mapper, configuracionServicio)
        {            
        }

        public ResultDTO Add(CtaCteClientePersistenciaDTO entidad, string user)
        {
            using var _context = new DataContext();

            // using var transaction = _context.Database.BeginTransaction();

            try
            {
                var entity = _mapper.Map<CuentaCorrienteCliente>(entidad);

                entity.User = user;

                _context.CuentaCorrienteClientes.Add(entity);

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

        public ResultDTO GetByCliente(Guid clienteId)
        {
            using var _context = new DataContext();

            // using var transaction = _context.Database.BeginTransaction();

            try
            { 
                Expression<Func<CuentaCorrienteCliente, bool>> filtro = filtro => true;

                filtro = filtro.And(x => x.ClienteId == clienteId);

                var entities = _context.CuentaCorrienteClientes
                    .AsNoTracking()
                    .Include(z => z.Cliente)
                    .Where(filtro)
                    .ToList();

                return new ResultDTO
                {
                    State = true,
                    Data = _mapper.Map<IEnumerable<CtaCteClienteDTO>>(entities)
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
    }
}
