using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Sidkenu.AccesoDatos.Entidades.Seguridad;
using Sidkenu.Infraestructura;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Base;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Seguridad.Formulario;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Seguridad.GrupoFormulario;
using Sidkenu.LogicaNegocio.Servicios.Implementacion.Base;
using Sidkenu.LogicaNegocio.Servicios.Interface.Seguridad;
using StructureMap;
using System.Transactions;

namespace Sidkenu.LogicaNegocio.Servicios.Implementacion.Seguridad
{
    public class GrupoFormularioServicio : ServicioBase, IGrupoFormularioServicio
    {
        public GrupoFormularioServicio(IMapper mapper,                                       
                                       IConfiguracionServicio configuracionServicio)
                                       : base(mapper, configuracionServicio)
        {
        }

        public ResultDTO AddFormularioGrupo(GrupoFormularioPersistenciaDTO grupoFormularioPersistenciaDTO, string userLogin)
        {
            using var _context = new DataContext();

            try
            {
                var result = _context.GruposFormularios
                    .AsNoTracking()
                    .Where(x => x.GrupoId == grupoFormularioPersistenciaDTO.GrupoId
                                && x.FormularioId == grupoFormularioPersistenciaDTO.FormularioId)
                    .ToList();

                if (result == null || !result.Any())
                {
                    _context.GruposFormularios
                       .Add(new GrupoFormulario
                       {
                           GrupoId = grupoFormularioPersistenciaDTO.GrupoId,
                           FormularioId = grupoFormularioPersistenciaDTO.FormularioId,
                           User = userLogin,
                           EstaEliminado = false
                       });
                }
                else
                {
                    var grupoFormulario = result.FirstOrDefault();

                    grupoFormulario.EstaEliminado = false;

                    _context.GruposFormularios.Update(grupoFormulario);
                    
                }

                _context.SaveChanges();

                return new ResultDTO
                {
                    State = true,
                    Message = "El formulario se asigno correctamente"
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

        public ResultDTO AddFormulariosGrupo(GrupoFormulariosPersistenciaDTO grupoFormulariosPersistenciaDTO, string userLogin)
        {
            using var _context = new DataContext();

            try
            {
                foreach (var formularioId in grupoFormulariosPersistenciaDTO.FormularioIds)
                {
                    var result = _context.GruposFormularios
                    .AsNoTracking()
                    .Where(x => x.GrupoId == grupoFormulariosPersistenciaDTO.GrupoId
                                          && x.FormularioId == formularioId)
                    .ToList();

                    if (result == null || !result.Any())
                    {
                        _context.GruposFormularios
                           .Add(new GrupoFormulario
                           {
                               GrupoId = grupoFormulariosPersistenciaDTO.GrupoId,
                               FormularioId = formularioId,
                               User = userLogin,
                               EstaEliminado = false
                           });
                    }
                    else
                    {
                        var grupoFormulario = result.FirstOrDefault();

                        grupoFormulario.EstaEliminado = false;

                        _context.GruposFormularios.Update(grupoFormulario);
                    }
                }

                _context.SaveChanges();

                return new ResultDTO
                {
                    State = true,
                    Message = "Los formularios se asignaron correctamente"
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

        public ResultDTO GetByFormulariosAsignadas(GrupoFormularioFilterDTO filterDTO)
        {
            using var _context = new DataContext();

            try
            {
                var result = _context.GruposFormularios
                    .AsNoTracking()
                    .Include(z => z.Formulario)
                    .Where(x => !x.EstaEliminado 
                                && x.GrupoId == filterDTO.GrupoId
                                && x.Formulario.DescripcionCompleta.ToLower().Contains(filterDTO.CadenaBuscar.ToLower()))
                    .OrderBy(r => r.Formulario.Codigo)
                    .ToList();

                return new ResultDTO
                {
                    State = true,
                    Data = _mapper.Map<IEnumerable<FormularioDTO>>(result)
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

        public ResultDTO GetByFormulariosNoAsignadas(GrupoFormularioFilterDTO filterDTO)
        {
            using var _context = new DataContext();

            try
            {
                var result = _context.GruposFormularios
                    .AsNoTracking()
                    .Include(z => z.Formulario)
                    .Where(x => !x.EstaEliminado && x.GrupoId == filterDTO.GrupoId
                                                       && x.Formulario.DescripcionCompleta.ToLower().Contains(filterDTO.CadenaBuscar.ToLower()))
                    .OrderBy(r => r.Formulario.Codigo)
                    .ToList();

                var formulariosAsignadas = result.Select(x => x.Formulario);

                var formularios = _context.Formularios.ToList();

                var formulariosNoAsignados = formularios.Except(formulariosAsignadas, new GenericCompare<Formulario>());

                return new ResultDTO
                {
                    State = true,
                    Data = _mapper.Map<IEnumerable<FormularioDTO>>(formulariosNoAsignados
                                            .Where(x => x.DescripcionCompleta.ToLower().Contains(filterDTO.CadenaBuscar.ToLower()))
                                            .ToList())
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

        public ResultDTO DeleteFormularioGrupo(GrupoFormularioPersistenciaDTO grupoFormularioPersistenciaDTO, string userLogin)
        {
            using var _context = new DataContext();

            try
            {
                var result = _context.GruposFormularios
                    .AsNoTracking()
                    .Where(x => x.GrupoId == grupoFormularioPersistenciaDTO.GrupoId 
                                && x.FormularioId == grupoFormularioPersistenciaDTO.FormularioId)
                    .ToList();

                if (result == null || !result.Any())
                {
                    return new ResultDTO
                    {
                        State = false,
                        Message = "No se encontro el formulario asignado al grupo"
                    };
                }

                var grupoFormulario = result.FirstOrDefault();

                grupoFormulario.EstaEliminado = true;

                _context.GruposFormularios.Update(grupoFormulario);

                _context.SaveChanges();

                return new ResultDTO
                {
                    State = true,
                    Message = "El formulario fue quitado correctamente"
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

        public ResultDTO DeleteFormulariosGrupo(GrupoFormulariosPersistenciaDTO grupoFormulariosPersistenciaDTO, string userLogin)
        {
            using var _context = new DataContext();
            
            try
            {
                foreach (var formularioId in grupoFormulariosPersistenciaDTO.FormularioIds)
                {
                    var result = _context.GruposFormularios
                        .AsNoTracking()
                        .Where(x => x.GrupoId == grupoFormulariosPersistenciaDTO.GrupoId && x.FormularioId == formularioId)
                        .ToList();

                    if (result == null || !result.Any())
                    {
                        return new ResultDTO
                        {
                            State = false,
                            Message = "No se encontro el formulario asignado al grupo"
                        };
                    }

                    var grupoFormulario = result.FirstOrDefault();

                    grupoFormulario.EstaEliminado = true;

                    _context.GruposFormularios.Update(grupoFormulario);
                }

                _context.SaveChanges();

                return new ResultDTO
                {
                    State = true,
                    Message = "Los formularios fueron quitados correctamente"
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
