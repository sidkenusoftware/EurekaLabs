using AutoMapper;
using Sidkenu.AccesoDatos.Constantes.Enum;
using Sidkenu.AccesoDatos.Constantes;
using Sidkenu.AccesoDatos.Entidades.Core;
using Sidkenu.Infraestructura;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Base;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.ArticuloPrecio;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.ConfiguracionCore;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.CostoFabricacion;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.ListaPrecio;
using Sidkenu.LogicaNegocio.Servicios.Implementacion.Base;
using Sidkenu.LogicaNegocio.Servicios.Interface.Core;
using Sidkenu.LogicaNegocio.Servicios.Interface.Seguridad;
using Microsoft.EntityFrameworkCore;
using System.Transactions;

namespace Sidkenu.LogicaNegocio.Servicios.Implementacion.Core
{
    public class ArticuloPrecioServicio : ServicioBase, IArticuloPrecioServicio
    {
        private readonly IConfiguracionCoreServicio _configuracionCoreServicio;
        private readonly ICostoFabricacionServicio _costoFabricacionServicio;

        public ArticuloPrecioServicio(IMapper mapper,
                                      IConfiguracionServicio configuracionServicio,
                                      IConfiguracionCoreServicio configuracionCoreServicio,
                                      ICostoFabricacionServicio costoFabricacionServicio)
                                      : base(mapper, configuracionServicio)
        {
            _configuracionCoreServicio = configuracionCoreServicio;
            _costoFabricacionServicio = costoFabricacionServicio;
        }
                
        public ResultDTO AddOrUpdate(ArticuloPrecioPersistenciaDTO articuloPrecioDTO, string user)
        {
            using var _context = new DataContext();            

            try
            {
                var _fechaActualizacion = DateTime.Now;

                var _configCoreResult = _configuracionCoreServicio
                        .Get(articuloPrecioDTO.EmpresaId);

                if (_configCoreResult == null || !_configCoreResult.State)
                {
                    return new ResultDTO
                    {
                        State = false,
                        Message = "Ocurrió un error al obtener la configuracion del Inventario"
                    };
                }

                var _configCore = (ConfiguracionCoreDTO)_configCoreResult.Data;

                var _montoMarca = 0m;

                var _montoFamilia = 0m;

                // Marca

                if (_configCore.ActivarAumentoPrecioPorMarca)
                {
                    var _marca = _context.Marcas.Find(articuloPrecioDTO.MarcaId);

                    if (_marca == null)
                    {
                        return new ResultDTO
                        {
                            State = false,
                            Message = "Ocurrio un error al obtener la Marca del articulo"
                        };
                    }

                    if (_marca.ActivarAumentoPrecioPublico)
                    {
                        if (_marca.TipoValorPublico == TipoValor.Valor)
                        {
                            _montoMarca += _marca.AumentoPrecioPublico.Value;
                        }
                        else
                        {
                            if (articuloPrecioDTO.PrecioCostoArticulo.HasValue)
                            {
                                _montoMarca += Porcentaje.Calcular(articuloPrecioDTO.PrecioCostoArticulo.Value, _marca.AumentoPrecioPublico.Value);
                            }
                        }
                    }

                    if (_marca.ActivarAumentoPrecioPublicoListaPrecio)
                    {
                        if (_marca.TipoValorPublicoListaPrecio == TipoValor.Valor)
                        {
                            _montoMarca += _marca.AumentoPrecioPublicoListaPrecio.Value;
                        }
                        else
                        {
                            if (articuloPrecioDTO.PrecioCostoArticulo.HasValue)
                            {
                                _montoMarca += Porcentaje.Calcular(articuloPrecioDTO.PrecioCostoArticulo.Value, _marca.AumentoPrecioPublicoListaPrecio.Value);
                            }
                        }
                    }
                }

                // Familia

                if (_configCore.ActivarAumentoPrecioPorFamilia)
                {
                    var _familia = _context.Familias.Find(articuloPrecioDTO.FamiliaId);

                    if (_familia == null)
                    {
                        return new ResultDTO
                        {
                            State = false,
                            Message = "Ocurrio un error al obtener la Familia del articulo"
                        };
                    }

                    if (_familia.ActivarAumentoPrecioPublico)
                    {
                        if (_familia.TipoValorPublico == TipoValor.Valor)
                        {
                            _montoFamilia += _familia.AumentoPrecioPublico.Value;
                        }
                        else
                        {
                            if (articuloPrecioDTO.PrecioCostoArticulo.HasValue)
                            {
                                _montoFamilia += Porcentaje.Calcular(articuloPrecioDTO.PrecioCostoArticulo.Value, _familia.AumentoPrecioPublico.Value);
                            }
                        }
                    }

                    if (_familia.ActivarAumentoPrecioPublicoListaPrecio)
                    {
                        if (_familia.TipoValorPublicoListaPrecio == TipoValor.Valor)
                        {
                            _montoFamilia += _familia.AumentoPrecioPublicoListaPrecio.Value;
                        }
                        else
                        {
                            if (articuloPrecioDTO.PrecioCostoArticulo.HasValue)
                            {
                                _montoFamilia += Porcentaje.Calcular(articuloPrecioDTO.PrecioCostoArticulo.Value, _familia.AumentoPrecioPublicoListaPrecio.Value);
                            }
                        }
                    }
                }

                var _monto = articuloPrecioDTO.PrecioCostoArticulo.HasValue ? articuloPrecioDTO.PrecioCostoArticulo.Value : 0m;

                _monto += _montoMarca;
                _monto += _montoFamilia;

                // Marca - Lista de Precio

                var _montoListaPrecioMarca = 0m;
                var _montoListaPrecioFamilia = 0m;

                var _listaPrecioReult = _context.ListaPrecios
                    .AsNoTracking()
                    .Where(x => x.EmpresaId == articuloPrecioDTO.EmpresaId)
                    .ToList();

                var _listaPreciosParaImpactar = new List<ListaPrecioMarcaOrFamiliaDTO>();

                if (_configCore.ActivarAumentoPrecioPorMarcaListaPrecio)
                {
                    foreach (var _listaPrecio in _listaPrecioReult.ToList())
                    {
                        _montoListaPrecioMarca = 0m;

                        var _listaPrecioMarcaResult = _context.MarcaListaPrecios
                            .AsNoTracking()
                            .Where(x => x.MarcaId == articuloPrecioDTO.MarcaId && x.ListaPrecioId == _listaPrecio.Id)
                            .ToList();

                        var _listaPrecioMarca = _listaPrecioMarcaResult.FirstOrDefault();

                        if (_listaPrecioMarca != null)
                        {
                            if (_listaPrecioMarca.TipoValor == TipoValor.Porcentaje)
                            {
                                _montoListaPrecioMarca += Porcentaje.Calcular(_monto, _listaPrecioMarca.Valor);
                            }
                            else
                            {
                                _montoListaPrecioMarca += _listaPrecioMarca.Valor;
                            }

                            _listaPreciosParaImpactar.Add(new ListaPrecioMarcaOrFamiliaDTO
                            {
                                ListaPrecioId = _listaPrecioMarca.ListaPrecioId,
                                Valor = _montoListaPrecioMarca,
                            });
                        }
                    }
                }

                if (_configCore.ActivarAumentoPrecioPorFamiliaListaPrecio)
                {
                    foreach (var _listaPrecio in _listaPrecioReult.ToList())
                    {
                        _montoListaPrecioFamilia = 0m;

                        var _listaPrecioFamiliaResult = _context.FamiliaListaPrecios
                                                                 .AsNoTracking()
                                                                 .Where(x => x.FamiliaId == articuloPrecioDTO.FamiliaId
                                                                             && x.ListaPrecioId == _listaPrecio.Id)
                                                                 .ToList();

                        var _listaPrecioFamilia = _listaPrecioFamiliaResult.FirstOrDefault();

                        if (_listaPrecioFamilia != null)
                        {
                            if (_listaPrecioFamilia.TipoValor == TipoValor.Porcentaje)
                            {
                                _montoListaPrecioFamilia += Porcentaje.Calcular(_monto, _listaPrecioFamilia.Valor);
                            }
                            else
                            {
                                _montoListaPrecioFamilia += _listaPrecioFamilia.Valor;
                            }

                            _listaPreciosParaImpactar.Add(new ListaPrecioMarcaOrFamiliaDTO
                            {
                                ListaPrecioId = _listaPrecioFamilia.ListaPrecioId,
                                Valor = _montoListaPrecioFamilia,
                            });
                        }
                    }
                }

                foreach (var listaPrecio in _listaPrecioReult.ToList())
                {
                    var montoPorListaPrecio = _listaPreciosParaImpactar
                        .Where(x => x.ListaPrecioId == listaPrecio.Id).Sum(x => x.Valor);

                    var precioCostoTotal = montoPorListaPrecio + _monto;

                    var rentabilidad = articuloPrecioDTO.TieneRentabilidad
                        ? articuloPrecioDTO.RentabilidadArticulo.HasValue ? articuloPrecioDTO.RentabilidadArticulo.Value : listaPrecio.Rentabilidad
                        : listaPrecio.Rentabilidad;

                    var precioPublico = precioCostoTotal + Porcentaje.Calcular(precioCostoTotal, rentabilidad);

                    if (articuloPrecioDTO.EsFabricado)
                    {
                        if (_configCore.IncorporarCostoFabricacion)
                        {
                            var resultCostoFabricacion = _costoFabricacionServicio.GetByFilter(new DTOs.Core.CostoFabricacion.CostoFabricacionFilterDTO
                            {
                                EmpresaId = articuloPrecioDTO.EmpresaId
                            });

                            if (resultCostoFabricacion.Data != null && resultCostoFabricacion.State)
                            {
                                var costosFabricacion = (List<CostoFabricacionDTO>)resultCostoFabricacion.Data;

                                var cant = _configCore.CantidadAproximadaFabricacionArticulos.HasValue ? _configCore.CantidadAproximadaFabricacionArticulos.Value : 1;

                                var costoFab = costosFabricacion.Sum(x => x.Monto) / cant;

                                precioPublico += costoFab;
                            }
                        }
                    }

                    var _articuloListaPrecio = new ArticuloPrecio
                    {
                        ArticuloId = articuloPrecioDTO.ArticuloId,
                        EstaEliminado = false,
                        FechaActualizacion = _fechaActualizacion,
                        ListaPrecioId = listaPrecio.Id,
                        User = user,
                        // Precio Costo total + La Rentabilidad
                        Monto = precioPublico
                    };

                    _context.Precios.Add(_articuloListaPrecio);
                }

                _context.SaveChanges();

                return new ResultDTO
                {
                    State = true,
                    Message = "El precio se guardo correctamente"
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
        
        public ResultDTO AddOrUpdate(ArticuloPrecioPersistenciaDTO articuloPrecioDTO, Articulo articuloNuevo, string user)
        {
            using var _context = new DataContext();            

            try
            {
                var _fechaActualizacion = DateTime.Now;

                var _configCoreResult = _configuracionCoreServicio
                        .Get(articuloPrecioDTO.EmpresaId);

                if (_configCoreResult == null || !_configCoreResult.State)
                {
                    return new ResultDTO
                    {
                        State = false,
                        Message = "Ocurrió un error al obtener la configuracion del Inventario"
                    };
                }

                var _configCore = (ConfiguracionCoreDTO)_configCoreResult.Data;

                var _montoMarca = 0m;

                var _montoFamilia = 0m;

                // Marca

                if (_configCore.ActivarAumentoPrecioPorMarca)
                {
                    var _marca = _context.Marcas.Find(articuloPrecioDTO.MarcaId);

                    if (_marca == null)
                    {
                        return new ResultDTO
                        {
                            State = false,
                            Message = "Ocurrio un error al obtener la Marca del articulo"
                        };
                    }

                    if (_marca.ActivarAumentoPrecioPublico)
                    {
                        if (_marca.TipoValorPublico == TipoValor.Valor)
                        {
                            _montoMarca += _marca.AumentoPrecioPublico.Value;
                        }
                        else
                        {
                            if (articuloPrecioDTO.PrecioCostoArticulo.HasValue)
                            {
                                _montoMarca += Porcentaje.Calcular(articuloPrecioDTO.PrecioCostoArticulo.Value, _marca.AumentoPrecioPublico.Value);
                            }
                        }
                    }

                    if (_marca.ActivarAumentoPrecioPublicoListaPrecio)
                    {
                        if (_marca.TipoValorPublicoListaPrecio == TipoValor.Valor)
                        {
                            _montoMarca += _marca.AumentoPrecioPublicoListaPrecio.Value;
                        }
                        else
                        {
                            if (articuloPrecioDTO.PrecioCostoArticulo.HasValue)
                            {
                                _montoMarca += Porcentaje.Calcular(articuloPrecioDTO.PrecioCostoArticulo.Value, _marca.AumentoPrecioPublicoListaPrecio.Value);
                            }
                        }
                    }
                }

                // Familia

                if (_configCore.ActivarAumentoPrecioPorFamilia)
                {
                    var _familia = _context.Familias.Find(articuloPrecioDTO.FamiliaId);

                    if (_familia == null)
                    {
                        return new ResultDTO
                        {
                            State = false,
                            Message = "Ocurrio un error al obtener la Familia del articulo"
                        };
                    }

                    if (_familia.ActivarAumentoPrecioPublico)
                    {
                        if (_familia.TipoValorPublico == TipoValor.Valor)
                        {
                            _montoFamilia += _familia.AumentoPrecioPublico.Value;
                        }
                        else
                        {
                            if (articuloPrecioDTO.PrecioCostoArticulo.HasValue)
                            {
                                _montoFamilia += Porcentaje.Calcular(articuloPrecioDTO.PrecioCostoArticulo.Value, _familia.AumentoPrecioPublico.Value);
                            }
                        }
                    }

                    if (_familia.ActivarAumentoPrecioPublicoListaPrecio)
                    {
                        if (_familia.TipoValorPublicoListaPrecio == TipoValor.Valor)
                        {
                            _montoFamilia += _familia.AumentoPrecioPublicoListaPrecio.Value;
                        }
                        else
                        {
                            if (articuloPrecioDTO.PrecioCostoArticulo.HasValue)
                            {
                                _montoFamilia += Porcentaje.Calcular(articuloPrecioDTO.PrecioCostoArticulo.Value, _familia.AumentoPrecioPublicoListaPrecio.Value);
                            }
                        }
                    }
                }

                var _monto = articuloPrecioDTO.PrecioCostoArticulo.HasValue ? articuloPrecioDTO.PrecioCostoArticulo.Value : 0m;

                _monto += _montoMarca;
                _monto += _montoFamilia;

                // Marca - Lista de Precio

                var _montoListaPrecioMarca = 0m;
                var _montoListaPrecioFamilia = 0m;

                var _listaPrecioReult = _context.ListaPrecios
                    .AsNoTracking()
                    .Where(x => x.EmpresaId == articuloPrecioDTO.EmpresaId)
                    .ToList();

                var _listaPreciosParaImpactar = new List<ListaPrecioMarcaOrFamiliaDTO>();

                if (_configCore.ActivarAumentoPrecioPorMarcaListaPrecio)
                {
                    foreach (var _listaPrecio in _listaPrecioReult.ToList())
                    {
                        _montoListaPrecioMarca = 0m;

                        var _listaPrecioMarcaResult = _context.MarcaListaPrecios
                            .Where(x => x.MarcaId == articuloPrecioDTO.MarcaId && x.ListaPrecioId == _listaPrecio.Id)
                            .ToList();

                        var _listaPrecioMarca = _listaPrecioMarcaResult.FirstOrDefault();

                        if (_listaPrecioMarca != null)
                        {
                            if (_listaPrecioMarca.TipoValor == TipoValor.Porcentaje)
                            {
                                _montoListaPrecioMarca += Porcentaje.Calcular(_monto, _listaPrecioMarca.Valor);
                            }
                            else
                            {
                                _montoListaPrecioMarca += _listaPrecioMarca.Valor;
                            }

                            _listaPreciosParaImpactar.Add(new ListaPrecioMarcaOrFamiliaDTO
                            {
                                ListaPrecioId = _listaPrecioMarca.ListaPrecioId,
                                Valor = _montoListaPrecioMarca,
                            });
                        }
                    }
                }

                if (_configCore.ActivarAumentoPrecioPorFamiliaListaPrecio)
                {
                    foreach (var _listaPrecio in _listaPrecioReult.ToList())
                    {
                        _montoListaPrecioFamilia = 0m;

                        var _listaPrecioFamiliaResult = _context.FamiliaListaPrecios
                            .AsNoTracking()
                            .Where(x => x.FamiliaId == articuloPrecioDTO.FamiliaId && x.ListaPrecioId == _listaPrecio.Id)
                            .ToList();

                        var _listaPrecioFamilia = _listaPrecioFamiliaResult.FirstOrDefault();

                        if (_listaPrecioFamilia != null)
                        {
                            if (_listaPrecioFamilia.TipoValor == TipoValor.Porcentaje)
                            {
                                _montoListaPrecioFamilia += Porcentaje.Calcular(_monto, _listaPrecioFamilia.Valor);
                            }
                            else
                            {
                                _montoListaPrecioFamilia += _listaPrecioFamilia.Valor;
                            }

                            _listaPreciosParaImpactar.Add(new ListaPrecioMarcaOrFamiliaDTO
                            {
                                ListaPrecioId = _listaPrecioFamilia.ListaPrecioId,
                                Valor = _montoListaPrecioFamilia,
                            });
                        }
                    }
                }

                foreach (var listaPrecio in _listaPrecioReult.ToList())
                {
                    var montoPorListaPrecio = _listaPreciosParaImpactar
                        .Where(x => x.ListaPrecioId == listaPrecio.Id).Sum(x => x.Valor);

                    var precioCostoTotal = montoPorListaPrecio + _monto;

                    var rentabilidad = articuloPrecioDTO.TieneRentabilidad
                        ? articuloPrecioDTO.RentabilidadArticulo.HasValue ? articuloPrecioDTO.RentabilidadArticulo.Value : listaPrecio.Rentabilidad
                        : listaPrecio.Rentabilidad;

                    var precioPublico = precioCostoTotal + Porcentaje.Calcular(precioCostoTotal, rentabilidad);

                    if (articuloPrecioDTO.EsFabricado)
                    {
                        if (_configCore.IncorporarCostoFabricacion)
                        {
                            var resultCostoFabricacion = _costoFabricacionServicio.GetByFilter(new DTOs.Core.CostoFabricacion.CostoFabricacionFilterDTO
                            {
                                EmpresaId = articuloPrecioDTO.EmpresaId
                            });

                            if (resultCostoFabricacion.Data != null && resultCostoFabricacion.State)
                            {
                                var costosFabricacion = (List<CostoFabricacionDTO>)resultCostoFabricacion.Data;

                                var cant = _configCore.CantidadAproximadaFabricacionArticulos.HasValue ? _configCore.CantidadAproximadaFabricacionArticulos.Value : 1;

                                var costoFab = costosFabricacion.Sum(x => x.Monto) / cant;

                                precioPublico += costoFab;
                            }
                        }
                    }

                    var _articuloListaPrecio = new ArticuloPrecio
                    {
                        ArticuloId = articuloNuevo.Id,
                        EstaEliminado = false,
                        FechaActualizacion = _fechaActualizacion,
                        ListaPrecioId = listaPrecio.Id,
                        User = user,
                        // Precio Costo total + La Rentabilidad
                        Monto = precioPublico
                    };

                    _context.Precios.Add(_articuloListaPrecio);
                }

                _context.SaveChanges();

                return new ResultDTO
                {
                    State = true,
                    Message = "El precio se guardo correctamente"
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
