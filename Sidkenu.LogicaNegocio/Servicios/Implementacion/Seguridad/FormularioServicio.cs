using AutoMapper;
using Sidkenu.AccesoDatos.Entidades.Seguridad;
using Sidkenu.AccesoDatos.Infraestructura;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Base;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Seguridad.Formulario;
using Sidkenu.LogicaNegocio.Servicios.Implementacion.Base;
using Sidkenu.LogicaNegocio.Servicios.Interface.Seguridad;

namespace Sidkenu.LogicaNegocio.Servicios.Implementacion.Seguridad
{
    public class FormularioServicio : ServicioBase, IFormularioServicio
    {
        public FormularioServicio(IMapper mapper,
                                    IConfiguracionServicio configuracionServicio)
                                    : base(mapper, configuracionServicio)
        {
        }

        public ResultDTO Add(List<FormularioDTO> formularios, string userLogin)
        {
            using var _context = new DataContext();            

            try
            {
                foreach (var formulario in formularios.Where(x => !x.ExisteBase).ToList())
                {
                    var entity = _mapper.Map<Formulario>(formulario);

                    entity.User = userLogin;
                    entity.EstaEliminado = false;

                    _context.Formularios.Add(entity);
                }

                _context.SaveChanges();

                return new ResultDTO
                {
                    State = true,
                    Message = "Los datos se grabaron correctamente"
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

        public ResultDTO GetAll()
        {
            using var _context = new DataContext();

            try
            {
                var result = _context.Formularios.ToList();

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
    }
}
