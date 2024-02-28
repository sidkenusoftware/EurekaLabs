using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Sidkenu.AccesoDatos.Entidades.Core;
using Sidkenu.Infraestructura;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Base;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.ArticuloFormula;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.ConfiguracionCore;
using Sidkenu.LogicaNegocio.Servicios.Implementacion.Base;
using Sidkenu.LogicaNegocio.Servicios.Interface.Core;
using System.Transactions;

namespace Sidkenu.LogicaNegocio.Servicios.Implementacion.Core
{
    public class ArticuloFormulaServicio : ServicioBase, IArticuloFormulaServicio
    {
        private readonly IConfiguracionCoreServicio _configuracionCoreServicio;

        public ArticuloFormulaServicio(IMapper mapper,
                                       IConfiguracionCoreServicio configuracionCoreServicio)
                                       : base(mapper)
        {
            _configuracionCoreServicio = configuracionCoreServicio;
        }        

        public ResultDTO Add(ArticuloFormulaPersistenciaDTO articuloFormula, string user)
        {
            using var transaction = new TransactionScope();
            using var _context = new DataContext();            

            try
            {
                var _configCoreResult = _configuracionCoreServicio
                    .Get(articuloFormula.EmpresaId);

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
                    .FirstOrDefault(x=>x.Id == articuloFormula.ArticuloBaseId);
                    
                if(_articulo == null ) 
                {
                    return new ResultDTO
                    {
                        State = false,
                        Message = "Ocurrió un error al obtener el Articulo BASE"
                    };
                }

                var _artFormulas = _context.ArticuloFormulas
                    .AsNoTracking()
                    .Where(x => x.ArticuloId == _articulo.Id)
                    .ToList();

                foreach (var artFormula in articuloFormula.Articulos.ToList())
                {
                    if (artFormula.ExisteBase)
                    {
                        var art = _artFormulas.FirstOrDefault(x => x.ArticuloSecundarioId == artFormula.ArticuloHijoId);

                        if (art == null)
                            return new ResultDTO
                            {
                                State = false,
                                Message = "Ocurrió un error al obtener el Articulo Formula"
                            };

                        if (artFormula.EstaEliminado)
                        {
                            _context.ArticuloFormulas.Remove(art);
                        }
                        else
                        {
                            art.Cantidad = artFormula.Cantidad;

                            _context.ArticuloFormulas.Update(art);
                        }
                    }
                    else
                    {
                        var artFormulaNuevo = new ArticuloFormula
                        {
                            ArticuloSecundarioId = artFormula.Id,
                            ArticuloId = _articulo.Id,
                            Cantidad = artFormula.Cantidad,
                            EstaEliminado = false,
                            User = user,                            
                        };

                        _context.ArticuloFormulas.Add(artFormulaNuevo);
                    }
                }

                _context.Articulos.Update(_articulo);

                _context.SaveChanges();

                transaction.Complete();

                return new ResultDTO
                {
                    State = true,
                    Message = "La Formula se grabo correctamente"
                };
            }
            catch (Exception ex)
            {
                transaction.Dispose();

                return new ResultDTO
                {
                    Message = ex.Message,
                    State = false
                };
            }
        }
    }
}
