using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Sidkenu.AccesoDatos.Constantes.Enum;
using Sidkenu.AccesoDatos.Entidades.Core;
using Sidkenu.Infraestructura;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Base;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.ArticuloVariante;
using Sidkenu.LogicaNegocio.Servicios.Implementacion.Base;
using Sidkenu.LogicaNegocio.Servicios.Interface.Core;
using Sidkenu.LogicaNegocio.Servicios.Interface.Seguridad;
using System.Transactions;

namespace Sidkenu.LogicaNegocio.Servicios.Implementacion.Core
{
    public class ArticuloVarianteServicio : ServicioBase, IArticuloVarianteServicio
    {
        private readonly IArticuloPrecioServicio _articuloPrecioServicio;

        public ArticuloVarianteServicio(IMapper mapper,
                                        IConfiguracionServicio configuracionServicio,
                                        IArticuloPrecioServicio articuloPrecioServicio)
                                        : base(mapper, configuracionServicio)
        {
            _articuloPrecioServicio = articuloPrecioServicio;
        }

        public ResultDTO Add(List<ArticuloVarianteValorPersistenciaDTO> listaVariantesValores, Guid empresaId, string user)
        {
            using var _context = new DataContext();

            try
            {
                var listaVariantesRepetidas = new List<string>();

                var _fechaActualizacion = DateTime.Now;
                
                if (!listaVariantesValores.Any())
                    return new ResultDTO { State = false, Message = "No hay valores cargados" };

                var articuloId = listaVariantesValores.First().ArticuloId;

                var _articuloSeleccionado = _context.Articulos
                    .AsNoTracking()
                    .Include(z => z.ArticuloPrecios)
                    .Include(z => z.ArticuloDepositos)
                    .FirstOrDefault(x => x.Id == articuloId);

                var listaVariantes = _context.VarianteValores
                    .AsNoTracking()
                    .ToList();

                var _marca = _context.Marcas.Find(_articuloSeleccionado.MarcaId);
                
                var _familia = _context.Familias.Find(_articuloSeleccionado.FamiliaId);

                foreach (var variante in listaVariantesValores)
                {
                    var varianteValorUno = listaVariantes.First(x => x.Id == variante.VarianteValor1Id);
                    var varianteValorDos = listaVariantes.First(x => x.Id == variante.VarianteValor2Id);

                    if (VerificarSiExiste(articuloId, varianteValorUno, varianteValorDos)) 
                    {
                        listaVariantesRepetidas.Add($"{_articuloSeleccionado.Descripcion} {varianteValorUno.Descripcion} {varianteValorDos.Descripcion}");
                        continue;
                    }

                    var nuevoArticulo = new Articulo
                    {
                        Abreviatura = _articuloSeleccionado.Abreviatura,
                        ActivarBonificacion = _articuloSeleccionado.ActivarBonificacion,
                        Bonificacion = _articuloSeleccionado.Bonificacion,
                        BonificacionFechaDesde = _articuloSeleccionado.BonificacionFechaDesde,
                        BonificacionFechaHasta = _articuloSeleccionado.BonificacionFechaHasta,
                        Codigo = $"{_articuloSeleccionado.Codigo} {varianteValorUno.Codigo} {varianteValorDos.Codigo}",
                        CodigoBarra = _articuloSeleccionado.CodigoBarra,
                        Comision = _articuloSeleccionado.Comision,
                        CondicionIvaId = _articuloSeleccionado.CondicionIvaId,
                        Descripcion = $"{_articuloSeleccionado.Descripcion} {varianteValorUno.Descripcion} {varianteValorDos.Descripcion}",
                        DescripcionAdicional = _articuloSeleccionado.DescripcionAdicional,
                        Detalle = _articuloSeleccionado.Detalle,
                        EmpresaId = _articuloSeleccionado.EmpresaId,
                        EstaBloqueado = _articuloSeleccionado.EstaBloqueado,
                        EstaEliminado = false,
                        FamiliaId = _articuloSeleccionado.FamiliaId,
                        Foto = _articuloSeleccionado.Foto,
                        Garantia = _articuloSeleccionado.Garantia,
                        LimiteVenta = _articuloSeleccionado.LimiteVenta,
                        MarcaId = _articuloSeleccionado.MarcaId,
                        PerfilArticulo = PerfilArticulo.CompraVenta,
                        PermiteStockNegativo = _articuloSeleccionado.PermiteStockNegativo,
                        PorcentajePerdida = _articuloSeleccionado.PorcentajePerdida,
                        PuntoPedido = _articuloSeleccionado.PuntoPedido,
                        Rentabilidad = _articuloSeleccionado.Rentabilidad,
                        StockMaximo = _articuloSeleccionado.StockMaximo,
                        StockMinimo = _articuloSeleccionado.StockMinimo,
                        TieneGarantia = _articuloSeleccionado.TieneGarantia,
                        ActivarLimiteVenta = _articuloSeleccionado.ActivarLimiteVenta,
                        TienePerdida = _articuloSeleccionado.TienePerdida,
                        TieneRentabilidad = _articuloSeleccionado.TieneRentabilidad,
                        TipoBonificacion = _articuloSeleccionado.TipoBonificacion,
                        UnidadMedidaCompraId = _articuloSeleccionado.UnidadMedidaCompraId,
                        UnidadMedidaVentaId = _articuloSeleccionado.UnidadMedidaVentaId,                        
                        ArticuloPadreId = articuloId,
                        VarianteValorUnoId = variante.VarianteValor1Id,
                        VarianteValorDosId = variante.VarianteValor2Id,
                        User = user,
                        TipoArticulo = TipoArticulo.Variante,                        
                        
                        ArticuloDepositos = new List<ArticuloDeposito>(),
                        ArticuloPrecios = new List<ArticuloPrecio>()
                    };

                    // =================================================================================== //
                    // ==============                     ASIGNO a DEPOSITOS               =============== //
                    // =================================================================================== //

                    foreach (var articuloDeposito in _articuloSeleccionado.ArticuloDepositos)
                    {
                        nuevoArticulo.ArticuloDepositos.Add(new ArticuloDeposito
                        {
                            Cantidad = variante.UtilizaPrecioStockIndividual ? variante.Stock : articuloDeposito.Cantidad,
                            DepositoId = articuloDeposito.DepositoId,
                            EstaEliminado = false,
                            User = user
                        });
                    }

                    // =================================================================================== //
                    // ==============                   CALCULO  PRECIO                    =============== //
                    // =================================================================================== //

                    var _precioCostoArticulo = variante.UtilizaPrecioStockIndividual ? variante.Precio : _articuloSeleccionado.PrecioCosto;

                    nuevoArticulo.PrecioCosto = _precioCostoArticulo;

                    _articuloPrecioServicio.AddOrUpdate(new DTOs.Core.ArticuloPrecio.ArticuloPrecioPersistenciaDTO
                    {
                        ArticuloId = variante.ArticuloId,
                        EmpresaId = empresaId,
                        FamiliaId = _articuloSeleccionado.FamiliaId,
                        MarcaId = _articuloSeleccionado.MarcaId,
                        PrecioCostoArticulo = _precioCostoArticulo,
                        RentabilidadArticulo = _articuloSeleccionado.Rentabilidad,
                        TieneRentabilidad = _articuloSeleccionado.TieneRentabilidad,
                        EsFabricado = false
                    },
                    nuevoArticulo,
                    user);

                    _context.Articulos.Add(nuevoArticulo);                    
                }

                _context.SaveChanges();

                var mensaje = string.Empty;

                mensaje = !listaVariantesRepetidas.Any() ? "Los datos se grabaron correctamente"
                                                         : "Las siguientes variantes no se cargaron porque ya existen:" + Environment.NewLine
                                                           + string.Join(Environment.NewLine, listaVariantesRepetidas) + "." + Environment.NewLine;

                mensaje += listaVariantesRepetidas.Any() && listaVariantesRepetidas.Count < listaVariantesValores.Count
                           ? "El resto de las variantes se grabaron correctamente"
                           : string.Empty;

                return new ResultDTO
                {
                    State = true,
                    Message = mensaje,
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

        private bool VerificarSiExiste(Guid articuloId, VarianteValor varianteValorUno, VarianteValor varianteValorDos)
        {
            using var _context = new DataContext();

            return _context.Articulos.Any(x => x.ArticuloPadreId == articuloId
                                               && x.VarianteValorUnoId == varianteValorUno.Id
                                               && x.VarianteValorDosId == varianteValorDos.Id);
        }
    }
}
