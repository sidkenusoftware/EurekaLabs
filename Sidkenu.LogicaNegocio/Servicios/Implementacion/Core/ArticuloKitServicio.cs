using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Sidkenu.AccesoDatos.Entidades.Core;
using Sidkenu.AccesoDatos.Infraestructura;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Base;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.ArticuloKit;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.ConfiguracionCore;
using Sidkenu.LogicaNegocio.Servicios.Implementacion.Base;
using Sidkenu.LogicaNegocio.Servicios.Interface.Core;

namespace Sidkenu.LogicaNegocio.Servicios.Implementacion.Core
{
    public class ArticuloKitServicio : ServicioBase, IArticuloKitServicio
    {
        private readonly IConfiguracionCoreServicio _configuracionCoreServicio;

        public ArticuloKitServicio(IMapper mapper,
                                   IConfiguracionCoreServicio configuracionCoreServicio)
                                   : base(mapper)
        {
            _configuracionCoreServicio = configuracionCoreServicio;
        }        

        public ResultDTO Add(ArticuloKitPersistenciaDTO articuloKit, string user)
        {
            using var _context = new DataContext();
            
            try
            {
                var _configCoreResult = _configuracionCoreServicio
                    .Get(articuloKit.EmpresaId);

                if (_configCoreResult == null || !_configCoreResult.State)
                {
                    return new ResultDTO
                    {
                        State = false,
                        Message = "Ocurrió un error al obtener la configuracion del Inventario"
                    };
                }

                var _configCore = (ConfiguracionCoreDTO)_configCoreResult.Data;

                var _articulo = _context.Articulos
                    .Include(i => i.ArticuloDepositos)
                    .Include(i => i.ArticuloPrecios)
                    .FirstOrDefault(x => x.Id == articuloKit.ArticuloBaseId);  

                if(_articulo == null ) 
                {
                    return new ResultDTO
                    {
                        State = false,
                        Message = "Ocurrió un error al obtener el Articulo BASE"
                    };
                }

                var _artKits = _context.ArticuloKits
                    .AsNoTracking()
                    .Where(x => x.ArticuloPadreId == _articulo.Id)
                    .ToList();

                foreach (var artKit in articuloKit.Articulos.ToList())
                {
                    if (artKit.ExisteBase)
                    {
                        var art = _artKits.FirstOrDefault(x => x.ArticuloHijoId == artKit.ArticuloHijoId);

                        if (art == null)
                            return new ResultDTO
                            {
                                State = false,
                                Message = "Ocurrió un error al obtener el Articulo Kit"
                            };

                        if (artKit.EstaEliminado)
                        {
                            _context.ArticuloKits.Remove(art);
                        }
                        else
                        {
                            art.Cantidad = artKit.Cantidad;

                            _context.ArticuloKits.Update(art);
                        }
                    }
                    else
                    {
                        var artKitNuevo = new ArticuloKit
                        {
                            ArticuloHijoId = artKit.Id,
                            ArticuloPadreId = _articulo.Id,
                            Cantidad = artKit.Cantidad,
                            EstaEliminado = false,
                            User = user,                            
                        };

                        _context.ArticuloKits.Add(artKitNuevo);
                    }
                }
                
                // Actualizo el Precio Publico a TODAS las Listas
                foreach (var artPrecio in _articulo.ArticuloPrecios.ToList())
                {
                    artPrecio.Monto = articuloKit.PrecioPublico;
                }

                // Actualizo el Stock al deposito por defecto para la venta
                foreach (var artDepo in _articulo.ArticuloDepositos.Where(x=>x.DepositoId == _configCore.DepositoPorDefectoParaVentaId).ToList())
                {
                    artDepo.Cantidad = articuloKit.Stock;
                }

                // Actualizo el Precio costo y la Fecha de Vigencia
                _articulo.PrecioCosto = articuloKit.PrecioCosto;
                _articulo.FechaVigenciaKit = articuloKit.FechaVigencia;

                _context.Articulos.Update(_articulo);

                _context.SaveChanges();

                return new ResultDTO
                {
                    State = true,
                    Message = "El kit se grabo correctamente"
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
