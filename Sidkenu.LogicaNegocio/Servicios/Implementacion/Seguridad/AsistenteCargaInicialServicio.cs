using AutoMapper;
using Sidkenu.AccesoDatos.Constantes;
using Sidkenu.AccesoDatos.Entidades.Seguridad;
using Sidkenu.Infraestructura;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Base;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Seguridad.AsistenteCargaInicial;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Seguridad.Configuracion;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Seguridad.Empresa;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Seguridad.EmpresaPersona;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Seguridad.Formulario;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Seguridad.Grupo;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Seguridad.GrupoFormulario;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Seguridad.GrupoPersona;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Seguridad.Persona;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Seguridad.Usuario;
using Sidkenu.LogicaNegocio.Servicios.Implementacion.Base;
using Sidkenu.LogicaNegocio.Servicios.Interface.Seguridad;
using Sidkenu.LogicaNegocio.Servicios.Interfaces.Email;

namespace Sidkenu.LogicaNegocio.Servicios.Implementacion.Seguridad
{
    public class AsistenteCargaInicialServicio : ServicioBase, IAsistenteCargaInicialServicio
    {
        private readonly IEmpresaServicio _empresaServicio;
        private readonly IEmpresaPersonaServicio _empresaPersonaServicio;
        private readonly IConfiguracionServicio _configuracionServicio;
        private readonly IPersonaServicio _personaServicio;
        private readonly IUsuarioServicio _usuarioServicio;
        private readonly IFormularioServicio _formularioServicio;
        private readonly IGrupoServicio _grupoServicio;
        private readonly IGrupoFormularioServicio _grupoFormularioServicio;
        private readonly IGrupoPersonaServicio _grupoPersonaServicio;
        private readonly ICorreoElectronico _correoElectronico;

        private readonly IMapper _mapper;

        public AsistenteCargaInicialServicio(IMapper mapper,
            IEmpresaServicio empresaServicio,
            IConfiguracionServicio configuracionServicio,
            IPersonaServicio personaServicio,
            IUsuarioServicio usuarioServicio,
            IEmpresaPersonaServicio empresaPersonaServicio,
            IFormularioServicio formularioServicio,
            IGrupoServicio grupoServicio,
            IGrupoFormularioServicio grupoFormularioServicio,
            IGrupoPersonaServicio grupoPersonaServicio,
            ICorreoElectronico correoElectronico)
            : base(mapper, configuracionServicio)
        {
            _empresaServicio = empresaServicio;
            _configuracionServicio = configuracionServicio;
            _personaServicio = personaServicio;
            _mapper = mapper;
            _usuarioServicio = usuarioServicio;
            _empresaPersonaServicio = empresaPersonaServicio;
            _formularioServicio = formularioServicio;
            _grupoServicio = grupoServicio;
            _grupoFormularioServicio = grupoFormularioServicio;
            _grupoPersonaServicio = grupoPersonaServicio;
            _correoElectronico = correoElectronico;
        }


        public ResultDTO Add(AsistenteDTO entidad)
        {
            try
            {
                var entidadEmpresaDTO = _mapper.Map<EmpresaPersistenciaDTO>(entidad.Empresa);
                var entidadPersonaDTO = _mapper.Map<PersonaPersistenciaDTO>(entidad.Persona);
                var entidadConfiguracionDTO = _mapper.Map<ConfiguracionPersistenciaDTO>(entidad.Configuracion);

                var userAsistente = "CargaPorAsistente";

                var empresaResult = _empresaServicio.Add(entidadEmpresaDTO, userAsistente);

                if (!empresaResult.State || empresaResult.Data == null)
                {
                    throw new Exception($"Ocurrió un error al grabar la Empresa. {empresaResult.Message}");
                }

                var empresaEntity = (Empresa)empresaResult.Data;

                var personaResult = _personaServicio.Add(entidadPersonaDTO, userAsistente);

                if (!personaResult.State || personaResult.Data == null)
                {
                    throw new Exception($"Ocurrió un error al grabar la Persona. {personaResult.Message}");
                }

                var personaEntity = (Persona)personaResult.Data;

                var usuarioDto = new DTOs.Seguridad.Usuario.UsuarioPersistenciaDTO
                {
                    InicioPorPrimeraVez = true,
                    PersonaApellido = personaEntity.Apellido,
                    PersonaNombre = personaEntity.Nombre,
                    PersonaId = personaEntity.Id,
                };

                var usuarioResult = _usuarioServicio.Crear(usuarioDto, userAsistente);

                if (!usuarioResult.State || usuarioResult.Data == null)
                {
                    throw new Exception($"Ocurrió un error al Crear el Usuario. {usuarioResult.Message}");
                }

                var empresaPersonaDto = new EmpresaPersonaPersistenciaDTO
                {
                    EmpresaId = empresaEntity.Id,
                    PersonaId = personaEntity.Id
                };

                var empresaPersonaResult = _empresaPersonaServicio.AddPersonaEmpresa(empresaPersonaDto, userAsistente);

                if (!empresaPersonaResult.State)
                {
                    throw new Exception("Ocurrió un error al grabar la Persona en una Empresa");
                }

                var grupoAdmin = new GrupoPersistenciaDTO
                {
                    EmpresaId = empresaEntity.Id,
                    Descripcion = "Administrador",
                };

                var grupoResult = _grupoServicio.Add(grupoAdmin, userAsistente);

                if (!grupoResult.State)
                {
                    throw new Exception("Ocurrió un error al grabar el grupo Administrador");
                }

                var formularioResult = _formularioServicio.Add(entidad.Formularios, userAsistente);

                if (!formularioResult.State)
                {
                    throw new Exception("Ocurrió un error al grabar los formularios/pantallas");
                }

                var grupoPersona = new GrupoPersonaPersistenciaDTO
                {
                    GrupoId = ((Grupo)grupoResult.Data).Id,
                    PersonaId = ((Persona)personaResult.Data).Id
                };

                var grupoPersonaResult = _grupoPersonaServicio.AddPersonaGrupo(grupoPersona, userAsistente);

                if (!grupoPersonaResult.State)
                {
                    throw new Exception("Ocurrió un error al asignar la persona al grupo de administrador");
                }

                var formularioBdResult = _formularioServicio.GetAll();

                if (formularioBdResult.State)
                {
                    foreach (var formulario in (List<FormularioDTO>)formularioBdResult.Data)
                    {
                        var grupoFormulario = new GrupoFormularioPersistenciaDTO
                        {
                            GrupoId = ((Grupo)grupoResult.Data).Id,
                            FormularioId = formulario.Id
                        };

                        _grupoFormularioServicio.AddFormularioGrupo(grupoFormulario, userAsistente);
                    }
                }

                // Envio de Mail

                var configResult = _configuracionServicio.Get();

                if (configResult.State)
                {
                    var config = (ConfiguracionDTO)configResult.Data;

                    var asunto = $"Bienvenido al Sistema de Gestión Tsidkenu";

                    var mensaje = $"Hola {personaEntity.Apellido}, {personaEntity.Nombre}" + Environment.NewLine + Environment.NewLine;

                    mensaje += $"El usuario para ingresar al sistema es: {((UsuarioDTO)usuarioResult.Data).Nombre} " +
                               $"y la contraseña es: {PasswordOptions.PasswordPorDefecto}." + Environment.NewLine + Environment.NewLine +
                               $"Gracias por elegir la plataforma Tsidkenu, la cual transformara todas tus actividades";

                    _correoElectronico.Enviar(personaEntity.Mail,
                        empresaEntity.Mail,
                        asunto,
                        mensaje,
                        config.UsuarioCredencial,
                        config.PasswordCredencial,
                        config.Host,
                        config.Puerto);
                }

                return new ResultDTO
                {
                    State = true,
                    Message = "Los datos se grabaron correctamente",
                };
            }
            catch (Exception ex)
            {

                return new ResultDTO
                {
                    State = false,
                    Message = "Ocurrió un error al Grabar los Datos"
                };
            }
        }
    }
}
