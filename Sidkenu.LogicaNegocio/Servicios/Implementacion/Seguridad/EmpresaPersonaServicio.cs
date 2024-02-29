using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Sidkenu.AccesoDatos.Entidades.Seguridad;
using Sidkenu.Infraestructura;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Base;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Seguridad.EmpresaPersona;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Seguridad.Persona;
using Sidkenu.LogicaNegocio.Servicios.Implementacion.Base;
using Sidkenu.LogicaNegocio.Servicios.Interface.Seguridad;
using StructureMap;
using System.Linq;
using System.Transactions;

namespace Sidkenu.LogicaNegocio.Servicios.Implementacion.Seguridad
{
    public class EmpresaPersonaServicio : ServicioBase, IEmpresaPersonaServicio
    {
        public EmpresaPersonaServicio(IMapper mapper,
                                      IConfiguracionServicio configuracionServicio)
                                      : base(mapper, configuracionServicio)
        {
        }

        public ResultDTO AddPersonaEmpresa(EmpresaPersonaPersistenciaDTO empresaPersonaPersistenciaDTO, string userLogin)
        {
            try
            {
                using var _context = new DataContext();

                var result = _context.EmpresasPersonas.Where(x => x.EmpresaId == empresaPersonaPersistenciaDTO.EmpresaId
                                                                  && x.PersonaId == empresaPersonaPersistenciaDTO.PersonaId)
                                                      .ToList();

                if (result == null || !result.Any())
                {
                    _context.EmpresasPersonas.Add(new EmpresaPersona
                    {
                        EmpresaId = empresaPersonaPersistenciaDTO.EmpresaId,
                        PersonaId = empresaPersonaPersistenciaDTO.PersonaId,
                        User = userLogin,
                        EstaEliminado = false
                    });
                }
                else
                {
                    var grupoPersona = result.FirstOrDefault();

                    grupoPersona.EstaEliminado = false;

                    _context.EmpresasPersonas.Update(grupoPersona);
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

        public ResultDTO AddPersonasEmpresa(EmpresaPersonasPersistenciaDTO empresaPersonasPersistenciaDTO, string userLogin)
        {
            using var _context = new DataContext();

            try
            {
                foreach (var personaId in empresaPersonasPersistenciaDTO.PersonaIds)
                {
                    var result = _context.EmpresasPersonas.Where(x => x.EmpresaId == empresaPersonasPersistenciaDTO.EmpresaId
                                                                      && x.PersonaId == personaId)
                                                         .ToList();
                    
                    if (result == null || !result.Any())
                    {
                        _context.EmpresasPersonas.Add(new EmpresaPersona
                        {
                            EmpresaId = empresaPersonasPersistenciaDTO.EmpresaId,
                            PersonaId = personaId,
                            User = userLogin,
                            EstaEliminado = false
                        });
                    }
                    else
                    {
                        var grupoPersona = result.FirstOrDefault();

                        grupoPersona.EstaEliminado = false;

                        _context.EmpresasPersonas.Update(grupoPersona);
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

        public ResultDTO GetByPersonasAsignadas(EmpresaPersonaFilterDTO filterDTO)
        {
            try
            {
                using var _context = new DataContext();

                var result = _context.EmpresasPersonas
                    .AsNoTracking()
                    .Include(r => r.Persona).ThenInclude(x => x.Usuarios)
                    .Where(x => !x.EstaEliminado && x.Persona.Cuil != "99999999999"
                                && x.EmpresaId == filterDTO.EmpresaId
                                && (x.Persona.Apellido.ToLower().Contains(filterDTO.CadenaBuscar.ToLower())
                                || x.Persona.Nombre.ToLower().Contains(filterDTO.CadenaBuscar.ToLower())))
                    .OrderBy(x => x.Persona.Apellido)
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

        public ResultDTO GetByPersonasNoAsignadas(EmpresaPersonaFilterDTO filterDTO)
        {
            try
            {
                using var _context = new DataContext();

                var result = _context.EmpresasPersonas
                    .AsNoTracking()
                    .Include(r => r.Persona).ThenInclude(x => x.Usuarios)
                    .Where(x => !x.EstaEliminado && x.Persona.Cuil != "99999999999"
                                                       && x.EmpresaId == filterDTO.EmpresaId)
                    .OrderBy(r => r.Persona.Apellido).ThenBy(r => r.Persona.Nombre)
                    .ToList();

                var personasAsignadas = result.Select(x => x.Persona);

                var personas = _context.Personas.Where(x => x.Cuil != "99999999999").ToList();

                var personasNoAsignados = personas.Except(personasAsignadas, new GenericCompare<Persona>());

                var _perNoAsigResult = personasNoAsignados.Where(x => x.Apellido.ToLower().Contains(filterDTO.CadenaBuscar.ToLower())
                                                                      || x.Nombre.ToLower().Contains(filterDTO.CadenaBuscar.ToLower())).ToList();

                return new ResultDTO
                {
                    State = true,
                    Data = _mapper.Map<IEnumerable<PersonaDTO>>(_perNoAsigResult)
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

        public ResultDTO DeletePersonaEmpresa(EmpresaPersonaPersistenciaDTO empresaPersonaPersistenciaDTO, string userLogin)
        {
            try
            {
                using var _context = new DataContext();

                var result = _context.EmpresasPersonas
                    .AsNoTracking()
                    .Where(x => x.EmpresaId == empresaPersonaPersistenciaDTO.EmpresaId && x.PersonaId == empresaPersonaPersistenciaDTO.PersonaId)
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

                _context.EmpresasPersonas.Update(grupoPersona);

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

        public ResultDTO DeletePersonasEmpresa(EmpresaPersonasPersistenciaDTO empresaPersonasPersistenciaDTO, string userLogin)
        {
            using var _context = new DataContext();

            try
            {
                foreach (var personaId in empresaPersonasPersistenciaDTO.PersonaIds)
                {
                    var result = _context.EmpresasPersonas
                        .Where(x => x.EmpresaId == empresaPersonasPersistenciaDTO.EmpresaId && x.PersonaId == personaId)
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

                    _context.EmpresasPersonas.Update(grupoPersona);
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
