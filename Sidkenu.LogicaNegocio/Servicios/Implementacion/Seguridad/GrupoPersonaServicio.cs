using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Sidkenu.AccesoDatos.Entidades.Seguridad;
using Sidkenu.AccesoDatos.Infraestructura;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Base;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Seguridad.GrupoPersona;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Seguridad.Persona;
using Sidkenu.LogicaNegocio.Servicios.Implementacion.Base;
using Sidkenu.LogicaNegocio.Servicios.Interface.Seguridad;

namespace Sidkenu.LogicaNegocio.Servicios.Implementacion.Seguridad
{
    public class GrupoPersonaServicio : ServicioBase, IGrupoPersonaServicio
    {
        public GrupoPersonaServicio(IMapper mapper,
                                    IConfiguracionServicio configuracionServicio)
                                    : base(mapper, configuracionServicio)
        {
        }

        public ResultDTO AddPersonaGrupo(GrupoPersonaPersistenciaDTO grupoPersonaPersistenciaDTO, string userLogin)
        {
            using var _context = new DataContext();

            try
            {
                var result = _context.GruposPersonas
                    .AsNoTracking()
                    .Where(x => x.GrupoId == grupoPersonaPersistenciaDTO.GrupoId
                                      && x.PersonaId == grupoPersonaPersistenciaDTO.PersonaId)
                    .ToList();

                if (result == null || !result.Any())
                {
                    _context.GruposPersonas
                       .Add(new GrupoPersona
                       {
                           GrupoId = grupoPersonaPersistenciaDTO.GrupoId,
                           PersonaId = grupoPersonaPersistenciaDTO.PersonaId,
                           User = userLogin,
                           EstaEliminado = false
                       });
                }
                else
                {
                    var grupoPersona = result.FirstOrDefault();

                    grupoPersona.EstaEliminado = false;

                    _context.GruposPersonas.Update(grupoPersona);
                }

                _context.SaveChanges();

                return new ResultDTO
                {
                    State = true,
                    Message = "El persona se asigno correctamente"
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

        public ResultDTO AddPersonasGrupo(GrupoPersonasPersistenciaDTO grupoPersonasPersistenciaDTO, string userLogin)
        {
            using var _context = new DataContext();

            try
            {
                foreach (var personaId in grupoPersonasPersistenciaDTO.PersonaIds)
                {
                    var result = _context.GruposPersonas
                        .AsNoTracking()
                        .Where(x => x.GrupoId == grupoPersonasPersistenciaDTO.GrupoId
                                          && x.PersonaId == personaId)
                        .ToList();
                    
                    if (result == null || !result.Any())
                    {
                        _context.GruposPersonas
                           .Add(new GrupoPersona
                           {
                               GrupoId = grupoPersonasPersistenciaDTO.GrupoId,
                               PersonaId = personaId,
                               User = userLogin,
                               EstaEliminado = false
                           });
                    }
                    else
                    {
                        var grupoPersona = result.FirstOrDefault();

                        grupoPersona.EstaEliminado = false;

                        _context.GruposPersonas.Update(grupoPersona);
                    }
                }

                _context.SaveChanges();

                return new ResultDTO
                {
                    State = true,
                    Message = "Los personas se asignaron correctamente"
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

        public ResultDTO GetByPersonasAsignadas(GrupoPersonaFilterDTO filterDTO)
        {
            using var _context = new DataContext();

            try
            {
                var result = _context.GruposPersonas
                    .AsNoTracking()
                    .Include(r => r.Persona).ThenInclude(x => x.Usuarios)
                    .Where(x => !x.EstaEliminado && x.Persona.Cuil != "99999999999"
                                                       && x.GrupoId == filterDTO.GrupoId
                                                       && (x.Persona.Apellido.ToLower().Contains(filterDTO.CadenaBuscar.ToLower())
                                                           || x.Persona.Nombre.ToLower().Contains(filterDTO.CadenaBuscar.ToLower())))
                    .OrderBy(r => r.Persona.Apellido)
                    .ToList();

                return new ResultDTO
                {
                    State = true,
                    Data = _mapper.Map<IEnumerable<PersonaDTO>>(result)
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

        public ResultDTO GetByPersonasNoAsignadas(GrupoPersonaFilterDTO filterDTO)
        {
            using var _context = new DataContext();

            try
            {
                var result = _context.GruposPersonas
                    .AsNoTracking()
                    .Include(r => r.Persona).ThenInclude(x => x.Usuarios)
                    .Where(x => !x.EstaEliminado && x.Persona.Cuil != "99999999999"
                                                       && x.GrupoId == filterDTO.GrupoId)
                    .OrderBy(r => r.Persona.Apellido).ThenBy(r => r.Persona.Nombre)
                    .ToList();

                var personasAsignadas = result.Select(x => x.Persona);

                var personas = _context.Personas.Where(x => x.Cuil != "99999999999").ToList();

                var personasNoAsignados = personas.Except(personasAsignadas, new GenericCompare<Persona>());

                return new ResultDTO
                {
                    State = true,
                    Data = _mapper.Map<IEnumerable<PersonaDTO>>(personasNoAsignados
                                            .Where(x => x.Apellido.ToLower().Contains(filterDTO.CadenaBuscar.ToLower())
                                                       || x.Nombre.ToLower().Contains(filterDTO.CadenaBuscar.ToLower())).ToList())
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

        public ResultDTO DeletePersonaGrupo(GrupoPersonaPersistenciaDTO grupoPersonaPersistenciaDTO, string userLogin)
        {
            using var _context = new DataContext();

            try
            {
                var result = _context.GruposPersonas
                    .AsNoTracking()
                    .Where(x => x.GrupoId == grupoPersonaPersistenciaDTO.GrupoId && x.PersonaId == grupoPersonaPersistenciaDTO.PersonaId)
                    .ToList();

                if (result == null || !result.Any())
                {
                    return new ResultDTO
                    {
                        State = false,
                        Message = "No se encontro el persona asignado al grupo"
                    };
                }

                var grupoPersona = result.FirstOrDefault();

                grupoPersona.EstaEliminado = true;

                _context.GruposPersonas.Update(grupoPersona);

                _context.SaveChanges();

                return new ResultDTO
                {
                    State = true,
                    Message = "El persona fue quitado correctamente"
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

        public ResultDTO DeletePersonasGrupo(GrupoPersonasPersistenciaDTO grupoPersonasPersistenciaDTO, string userLogin)
        {
            using var _context = new DataContext();

            try
            {
                foreach (var personaId in grupoPersonasPersistenciaDTO.PersonaIds)
                {
                    var result = _context.GruposPersonas
                        .AsNoTracking()
                        .Where(x => x.GrupoId == grupoPersonasPersistenciaDTO.GrupoId && x.PersonaId == personaId)
                        .ToList();

                    if (result == null || !result.Any())
                    {
                        return new ResultDTO
                        {
                            State = false,
                            Message = "No se encontro el persona asignado al grupo"
                        };
                    }

                    var grupoPersona = result.FirstOrDefault();

                    grupoPersona.EstaEliminado = true;

                    _context.GruposPersonas.Update(grupoPersona);
                }

                _context.SaveChanges();

                return new ResultDTO
                {
                    State = true,
                    Message = "Los personas fueron quitados correctamente"
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
