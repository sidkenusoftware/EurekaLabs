using AutoMapper;
using Sidkenu.AccesoDatos.Constantes.Enum;
using Sidkenu.AccesoDatos.Entidades.Core;
using Sidkenu.Infraestructura;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Base;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.Cliente;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.Comprobante;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.Gasto;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Seguridad.Persona;
using Sidkenu.LogicaNegocio.Servicios.Implementacion.Base;
using Sidkenu.LogicaNegocio.Servicios.Interface.Core;
using Sidkenu.LogicaNegocio.Servicios.Interface.Seguridad;
using System.Transactions;

namespace Sidkenu.LogicaNegocio.Servicios.Implementacion.Core
{
    public class GastoServicio : ServicioBase, IGastosServicio
    {
        private readonly IComprobanteServicio _comprobanteServicio;
        private readonly IClienteServicio _clienteServicio;
        private readonly IPersonaServicio _personaServicio;

        public GastoServicio(IMapper mapper,
                             IConfiguracionServicio configuracionServicio,
                             IComprobanteServicio comprobanteServicio,
                             IClienteServicio clienteServicio,
                             IPersonaServicio personaServicio)
                             : base(mapper, configuracionServicio)
        {
            _comprobanteServicio = comprobanteServicio;
            _clienteServicio = clienteServicio;
            _personaServicio = personaServicio;
        }

        public ResultDTO Add(GastosPersistenciaDTO entidad, string user)
        {
            using var _context = new DataContext();            

            try
            {
                var entityGasto = _mapper.Map<Gasto>(entidad);

                entityGasto.User = user;
                entityGasto.EstaEliminado = false;

                _context.Gastos.Add(entityGasto);

                // Comprobante de Gastos

                var _clienteResult = _clienteServicio.GetConsumidorFinal();

                if (_clienteResult == null || !_clienteResult.State) 
                {
                    return new ResultDTO
                    {
                        State = false,
                        Message = "Ocurrió un error al obtener el cliente por defecto para asignarlo al comprobante"
                    };
                }

                var _personaResult = _personaServicio.GetById(entidad.PersonaId);

                if (_personaResult == null || !_personaResult.State)
                {
                    return new ResultDTO
                    {
                        State = false,
                        Message = "Ocurrió un error al obtener la persona que esta registrando el gasto"
                    };
                }

                var _comprobanteGasto = new ComprobanteGastoDTO();

                _comprobanteGasto.CajaDetalleId = entidad.CajaDetalleId;
                _comprobanteGasto.EmpresaId = entidad.EmpresaId;
                _comprobanteGasto.Cliente = (ClienteDTO)_clienteResult.Data;
                _comprobanteGasto.Persona = (PersonaDTO)_personaResult.Data;
                _comprobanteGasto.Fecha = entidad.Fecha;
                _comprobanteGasto.TipoGastoId = entidad.TipoGastoId;
                _comprobanteGasto.CajaId = entidad.CajaId;
                _comprobanteGasto.SubTotal = entidad.Monto;
                _comprobanteGasto.Descuento = 0m;
                _comprobanteGasto.Total = entidad.Monto;
                _comprobanteGasto.TipoComprobante = TipoComprobante.Gastos;
                _comprobanteGasto.Descripcion = entidad.Descripcion;
                                
                var resultDto = _comprobanteServicio.AddOrUpdate(_comprobanteGasto, user);

                var _comprobanteResult = (ComprobanteDTO)resultDto.Data;

                // Movimiento Caja

                var _movimientoCaja = new MovimientoCaja
                {
                    TipoMovimiento = TipoMovimiento.Egreso,
                    TipoOperacion = TipoOperacionMovimiento.Gastos,
                    CajaDetalleId = entidad.CajaDetalleId,
                    Capital = entidad.Monto,
                    Interes = 0m,
                    Descripcion = entidad.Descripcion,
                    Fecha = entidad.Fecha,
                    User = user,
                    ComprobanteId = _comprobanteResult.Id,
                    EstaEliminado = false,                    
                };

                _context.MovimientoCajas.Add(_movimientoCaja);

                _context.SaveChanges();

                return new ResultDTO
                {
                    State = true,
                    Message = "Los datos se grabaron correctamente",
                    Data = entityGasto
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
