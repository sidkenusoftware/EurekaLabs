using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Sidkenu.AccesoDatos.Entidades.Core;
using Sidkenu.AccesoDatos.Entidades.Seguridad;
using Sidkenu.Infraestructura;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Base;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.Caja;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.CajaPuestoTrabajo;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Seguridad.PuestoTrabajo;
using Sidkenu.LogicaNegocio.Servicios.Implementacion.Base;
using Sidkenu.LogicaNegocio.Servicios.Interface.Core;
using Sidkenu.LogicaNegocio.Servicios.Interface.Seguridad;

namespace Sidkenu.LogicaNegocio.Servicios.Implementacion.Core
{
    public class CajaPuestoTrabajoServicio : ServicioBase, ICajaPuestoTrabajoServicio
    {
        public CajaPuestoTrabajoServicio(IMapper mapper,
                                         IConfiguracionServicio configuracionServicio)
                                         : base(mapper, configuracionServicio)
        {
        }

        public ResultDTO AddPuestoTrabajoCaja(CajaPuestoTrabajoPersistenciaDTO cajaPuestoTrabajoPersistenciaDTO, string userLogin)
        {
            using var _context = new DataContext();

            try
            {
                var result = _context.CajasPuestoTrabajos
                    .AsNoTracking()
                    .Where(x=>x.CajaId == cajaPuestoTrabajoPersistenciaDTO.CajaId
                              && x.PuestoTrabajoId == cajaPuestoTrabajoPersistenciaDTO.PuestoTrabajoId)
                    .ToList();

                if (result == null || !result.Any())
                {
                    _context.CajasPuestoTrabajos.Add(new CajaPuestoTrabajo
                    {
                        CajaId = cajaPuestoTrabajoPersistenciaDTO.CajaId,
                        PuestoTrabajoId = cajaPuestoTrabajoPersistenciaDTO.PuestoTrabajoId,
                        User = userLogin,
                        EstaEliminado = false
                    });
                }
                else
                {
                    var cajaPuestoTrabajo = result.FirstOrDefault();

                    cajaPuestoTrabajo.EstaEliminado = false;

                    _context.CajasPuestoTrabajos.Update(cajaPuestoTrabajo);
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

        public ResultDTO AddPuestosTrabajosCaja(CajaPuestoTrabajosPersistenciaDTO cajaPuestoTrabajosPersistenciaDTO, string userLogin)
        {
            using var _context = new DataContext();

            try
            {
                foreach (var formularioId in cajaPuestoTrabajosPersistenciaDTO.PuestoTrabajoIds)
                {
                    var result = _context.CajasPuestoTrabajos
                        .AsNoTracking()
                        .Where(x => x.CajaId == cajaPuestoTrabajosPersistenciaDTO.CajaId
                                    && x.PuestoTrabajoId == formularioId)
                        .ToList();

                    if (result == null || !result.Any())
                    {
                        _context.CajasPuestoTrabajos.Add(new CajaPuestoTrabajo
                        {
                            CajaId = cajaPuestoTrabajosPersistenciaDTO.CajaId,
                            PuestoTrabajoId = formularioId,
                            User = userLogin,
                            EstaEliminado = false
                        });
                    }
                    else
                    {
                        var cajaPuestoTrabajo = result.FirstOrDefault();

                        cajaPuestoTrabajo.EstaEliminado = false;

                        _context.CajasPuestoTrabajos.Update(cajaPuestoTrabajo);
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

        public ResultDTO GetByPuestosTrabajosAsignadas(CajaPuestoTrabajoFilterDTO filterDTO)
        {
            using var _context = new DataContext();

            try
            {
                var result = _context.CajasPuestoTrabajos
                    .AsNoTracking()
                    .Include(z => z.PuestoTrabajo)
                    .Where(x => !x.EstaEliminado && x.CajaId == filterDTO.CajaId
                                && x.PuestoTrabajo.Descripcion.ToLower().Contains(filterDTO.CadenaBuscar.ToLower()))
                    .OrderBy(r => r.PuestoTrabajo.Descripcion)
                    .ToList();

                return new ResultDTO
                {
                    State = true,
                    Data = _mapper.Map<IEnumerable<PuestoTrabajoDTO>>(result)
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

        public ResultDTO GetByPuestosTrabajosNoAsignadas(CajaPuestoTrabajoFilterDTO filterDTO)
        {
            using var _context = new DataContext();

            try
            {
                var result = _context.CajasPuestoTrabajos
                    .AsNoTracking()
                    .Include(z => z.PuestoTrabajo)
                    .Where(x => !x.EstaEliminado && x.CajaId == filterDTO.CajaId
                                                       && x.Caja.EmpresaId == filterDTO.EmpresaId
                                                       && x.PuestoTrabajo.Descripcion.ToLower().Contains(filterDTO.CadenaBuscar.ToLower()))
                    .OrderBy(r => r.PuestoTrabajo.Descripcion)
                    .ToList();

                var puestosTrabajosAsignadas = result.Select(x => x.PuestoTrabajo);

                var puestosTrabajos = _context.PuestosTrabajos
                    .AsNoTracking()
                    .Where(x => x.EmpresaId == filterDTO.EmpresaId)
                    .ToList();

                var puestosTrabajosNoAsignados = puestosTrabajos.Except(puestosTrabajosAsignadas, new GenericCompare<PuestoTrabajo>());

                return new ResultDTO
                {
                    State = true,
                    Data = _mapper.Map<IEnumerable<PuestoTrabajoDTO>>(puestosTrabajosNoAsignados
                                            .Where(x => x.Descripcion.ToLower().Contains(filterDTO.CadenaBuscar.ToLower()))
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

        public ResultDTO GetByCajasAsignadas(Guid puestoTrabajoId)
        {
            using var _context = new DataContext();

            try
            {
                var result = _context.CajasPuestoTrabajos
                    .Include(z => z.Caja).ThenInclude(z => z.CajaDetalles)
                    .Where(x => !x.EstaEliminado && x.PuestoTrabajoId == puestoTrabajoId)
                    .OrderBy(r => r.Caja.Descripcion)
                    .ToList();
                
                return new ResultDTO
                {
                    State = true,
                    Data = _mapper.Map<IEnumerable<CajaDTO>>(result)
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

        public ResultDTO DeleteCajaPuestoTrabajo(CajaPuestoTrabajoPersistenciaDTO cajaPuestoTrabajoPersistenciaDTO, string userLogin)
        {
            using var _context = new DataContext();

            try
            {
                var cajaPuestoTrabajo = _context.CajasPuestoTrabajos
                    .FirstOrDefault(x => x.CajaId == cajaPuestoTrabajoPersistenciaDTO.CajaId
                                         && x.PuestoTrabajoId == cajaPuestoTrabajoPersistenciaDTO.PuestoTrabajoId);

                if (cajaPuestoTrabajo == null)
                {
                    return new ResultDTO
                    {
                        State = false,
                        Message = "No se encontro el Puesto de Trabajo asignado a la caja"
                    };
                }

                cajaPuestoTrabajo.EstaEliminado = true;

                _context.CajasPuestoTrabajos.Update(cajaPuestoTrabajo);

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

        public ResultDTO DeleteCajaPuestosTrabajos(CajaPuestoTrabajosPersistenciaDTO cajaPuestoTrabajosPersistenciaDTO, string userLogin)
        {
            using var _context = new DataContext();

            try
            {
                foreach (var formularioId in cajaPuestoTrabajosPersistenciaDTO.PuestoTrabajoIds)
                {
                    var cajaPuestoTrabajo = _context.CajasPuestoTrabajos
                        .FirstOrDefault(x => x.CajaId == cajaPuestoTrabajosPersistenciaDTO.CajaId
                                             && x.PuestoTrabajoId == formularioId);

                    if (cajaPuestoTrabajo == null)
                    {
                        return new ResultDTO
                        {
                            State = false,
                            Message = "No se encontro el formulario asignado al grupo"
                        };
                    }

                    cajaPuestoTrabajo.EstaEliminado = true;

                    _context.CajasPuestoTrabajos.Update(cajaPuestoTrabajo);
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
