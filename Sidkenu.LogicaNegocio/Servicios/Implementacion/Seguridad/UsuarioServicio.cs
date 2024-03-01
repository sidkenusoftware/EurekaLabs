using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Sidkenu.AccesoDatos.Constantes;
using Sidkenu.AccesoDatos.Entidades.Seguridad;
using Sidkenu.AccesoDatos.Infraestructura;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Base;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Seguridad.Usuario;
using Sidkenu.LogicaNegocio.Servicios.Implementacion.Base;
using Sidkenu.LogicaNegocio.Servicios.Interface.Seguridad;
using System.Text.RegularExpressions;

namespace Sidkenu.LogicaNegocio.Servicios.Implementacion.Seguridad
{
    public class UsuarioServicio : ServicioBase, IUsuarioServicio
    {
        private readonly IPasswordServicio _passwordServicio;

        public UsuarioServicio(IMapper mapper,
                               IConfiguracionServicio configuracionServicio,
                               IPasswordServicio passwordService)
                               : base(mapper, configuracionServicio)
        {
            _passwordServicio = passwordService;
        }

        public ResultDTO Crear(UsuarioPersistenciaDTO usuarioPersistenciaDTO, string userLogin)
        {
            using var _context = new DataContext();

            try
            {
                var nombreUsuarioNuevo = CrearNombreUsuario(usuarioPersistenciaDTO.PersonaApellido, usuarioPersistenciaDTO.PersonaNombre);

                var nuevoUsuario = new Usuario
                {
                    EstaEliminado = false,
                    InicioPorPrimeraVez = true,
                    Nombre = nombreUsuarioNuevo,
                    Password = _passwordServicio.Hash(PasswordOptions.PasswordPorDefecto),
                    PersonaId = usuarioPersistenciaDTO.PersonaId,
                    User = userLogin
                };

                _context.Usuarios.Add(nuevoUsuario);

                _context.SaveChanges();

                return new ResultDTO
                {
                    State = true,
                    Message = "El usuario se creo correctamente",
                    Data = _mapper.Map<UsuarioDTO>(nuevoUsuario)
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

        public ResultDTO Crear(UsuarioPersistenciaDTO usuarioPersistenciaDTO, string password, string userLogin)
        {
            using var _context = new DataContext();

            try
            {
                var nombreUsuarioNuevo = CrearNombreUsuario(usuarioPersistenciaDTO.PersonaApellido, usuarioPersistenciaDTO.PersonaNombre);

                var nuevoUsuario = new Usuario
                {
                    EstaEliminado = false,
                    InicioPorPrimeraVez = true,
                    Nombre = nombreUsuarioNuevo,
                    Password = _passwordServicio.Hash(password),
                    PersonaId = usuarioPersistenciaDTO.PersonaId,
                    User = userLogin
                };

                _context.Usuarios.Add(nuevoUsuario);

                _context.SaveChanges();

                return new ResultDTO
                {
                    State = true,
                    Message = "El usuario se creo correctamente",
                    Data = _mapper.Map<UsuarioDTO>(nuevoUsuario)
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

        public ResultDTO Eliminar(UsuarioDeleteDTO usuarioDeleteDTO, string userLogin)
        {
            using var _context = new DataContext();

            try
            {
                var usuario = _context.Usuarios.Find(usuarioDeleteDTO.Id);
                
                if (usuario == null)
                {
                    return new ResultDTO
                    {
                        Data = null,
                        Message = "El usuario seleccionado es inexistente",
                        State = false
                    };
                }

                _context.RemoveLogic(usuario, userLogin);

                _context.SaveChanges();

                return new ResultDTO
                {
                    State = true,
                    Message = !usuario.EstaEliminado ? "El usuario se Eliminó correctamente" : "El usuario se Activo correctamente",
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

        public ResultDTO Bloquear(UsuarioBloquearDTO usuarioBloquearDTO, string userLogin)
        {
            using var _context = new DataContext();

            try
            {
                var usuario = _context.Usuarios.Find(usuarioBloquearDTO.Id);

                if (usuario == null)
                {
                    return new ResultDTO
                    {
                        Data = null,
                        Message = "El usuario seleccionado es inexistente",
                        State = false
                    };
                }

                usuario.User = userLogin;

                _context.Usuarios.Update(usuario);

                _context.SaveChanges();

                return new ResultDTO
                {
                    State = true,
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

        public ResultDTO GetById(Guid id)
        {
            using var _context = new DataContext();

            try
            {
                var resultado = _context.Usuarios
                    .Include(p => p.Persona)
                    .FirstOrDefault(u => u.Id == id);

                if (resultado != null)
                {
                    var usuario = _mapper.Map<UsuarioDTO>(resultado);

                    return new ResultDTO
                    {
                        Data = usuario,
                        State = true
                    };
                }
                else
                {
                    return new ResultDTO
                    {
                        State = false,
                        Message = "El usuario no fue encontrado"
                    };
                }
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

        public ResultDTO GetByName(string nombreUsuario)
        {
            using var _context = new DataContext();

            try
            {
                var resultado = _context.Usuarios
                    .AsNoTracking()
                    .Include(p => p.Persona)
                    .Where(x => x.Nombre.ToLower() == nombreUsuario.ToLower())
                    .ToList();

                if (resultado != null)
                {
                    var usuario = _mapper.Map<UsuarioDTO>(resultado.FirstOrDefault());

                    return new ResultDTO
                    {
                        Data = usuario,
                        State = true
                    };
                }
                else
                {
                    return new ResultDTO
                    {
                        State = false,
                        Message = "El usuario no fue encontrado"
                    };
                }
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

        public ResultDTO GetByFilter(UsuarioFilterDTO filter)
        {
            using var _context = new DataContext();

            try
            {
                filter.CadenaBuscar = !string.IsNullOrEmpty(filter.CadenaBuscar) ? filter.CadenaBuscar : string.Empty;

                var resultado = _context.Personas
                    .AsNoTracking()
                    .Include(u => u.Usuarios)
                    .Where(x => x.Mail != "superUsuario@dime.gov.ar"
                        && x.EstaEliminado == filter.VerEliminados
                        && (x.Nombre.ToLower().Contains(filter.CadenaBuscar.ToLower())
                        || x.Apellido.ToLower().Contains(filter.CadenaBuscar.ToLower())
                        || x.Cuil.ToLower() == filter.CadenaBuscar.ToLower()
                        || x.Usuarios.Any(n => n.Nombre.ToLower().Contains(filter.CadenaBuscar.ToLower()))))
                    .ToList();

                if (resultado != null)
                {
                    var usuarios = _mapper.Map<IEnumerable<UsuarioDTO>>(resultado);

                    return new ResultDTO
                    {
                        Data = usuarios,
                        State = true
                    };
                }
                else
                {
                    return new ResultDTO
                    {
                        State = false,
                        Message = "El usuario no fue encontrado"
                    };
                }
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

        public bool VerificarSiExiste(string usuario)
        {
            using var _context = new DataContext();

            return _context.Usuarios.Any(x => x.Nombre == usuario);
        }

        public bool VerificarSiExiste(Guid personaId)
        {
            using var _context = new DataContext();

            return _context.Usuarios.Any(x => x.PersonaId == personaId);
        }

        public string CrearNombreUsuario(string apellido, string nombre)
        {
            using var _context = new DataContext();

            var _apellido = apellido.ToLower().Replace(" ", string.Empty);
            var _nombre = nombre.ToLower().Replace(" ", string.Empty);

            int contador = 1;
            int cantidadLetras = 1;
            var nombreUsuario = RemoverAcentos($"{_nombre.Substring(0, cantidadLetras)}{_apellido}");

            var existe = _context.Usuarios.AsNoTracking().Where(x => x.Nombre == nombreUsuario).ToList();

            while (VerificarSiExiste(nombreUsuario))
            {
                if (cantidadLetras <= _nombre.Length)
                {
                    cantidadLetras++;
                    nombreUsuario = RemoverAcentos($"{_nombre.Substring(0, cantidadLetras)}{_apellido}");
                }
                else
                {
                    nombreUsuario = RemoverAcentos($"{_nombre.Substring(0, 1)}{_apellido}{contador}");
                    contador++;
                }
            }

            return nombreUsuario.ToLower();
        }

        public ResultDTO CambiarPassword(UsuarioCambioPasswordDTO usuarioCambioPasswordDTO, string userLogin)
        {
            using var _context = new DataContext();

            try
            {
                var usuario = _context.Usuarios.AsNoTracking().FirstOrDefault(x=>x.Id == usuarioCambioPasswordDTO.UserId);

                if (usuario == null)
                {
                    return new ResultDTO
                    {
                        Data = null,
                        Message = "El usuario seleccionado es inexistente",
                        State = false
                    };
                }

                if (!_passwordServicio.Check(usuario.Password, usuarioCambioPasswordDTO.PasswordActual))
                {
                    return new ResultDTO
                    {
                        Data = null,
                        Message = "La contraseña vieja no coincide con la actual",
                        State = false
                    };
                }

                usuario.User = userLogin;

                usuario.Password = _passwordServicio.Hash(usuarioCambioPasswordDTO.PasswordNueva);

                _context.Usuarios.Update(usuario);

                _context.SaveChanges();

                return new ResultDTO
                {
                    State = true,
                    Message = "La contraseña se cambió correctamente",
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

        public ResultDTO ResetPassword(UsuarioResetPasswordDTO usuarioResetPasswordDTO, string userLogin)
        {
            using var _context = new DataContext();

            try
            {
                var usuarios = _context.Usuarios
                    .AsNoTracking()
                    .Where(x => x.PersonaId == usuarioResetPasswordDTO.Id)
                    .ToList();

                if (usuarios == null && !usuarios.Any())
                {
                    return new ResultDTO
                    {
                        Data = null,
                        Message = "El usuario seleccionado es inexistente",
                        State = false
                    };
                }

                var usuario = usuarios.First();

                usuario.User = userLogin;
                usuario.Password = _passwordServicio.Hash(PasswordOptions.PasswordPorDefecto);

                _context.Usuarios.Update(usuario);

                _context.SaveChanges();

                return new ResultDTO
                {
                    State = true,
                    Message = "La contraseña se restauro correctamente",
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

        // ======================================================================================= //
        // =============================   Metodos Privados  ===================================== //
        // ======================================================================================= //

        private string RemoverAcentos(string inputString)
        {
            var replace_a_Accents = new Regex("[á|à|ä|â]", RegexOptions.Compiled);
            var replace_e_Accents = new Regex("[é|è|ë|ê]", RegexOptions.Compiled);
            var replace_i_Accents = new Regex("[í|ì|ï|î]", RegexOptions.Compiled);
            var replace_o_Accents = new Regex("[ó|ò|ö|ô]", RegexOptions.Compiled);
            var replace_u_Accents = new Regex("[ú|ù|ü|û]", RegexOptions.Compiled);

            inputString = replace_a_Accents.Replace(inputString, "a");
            inputString = replace_e_Accents.Replace(inputString, "e");
            inputString = replace_i_Accents.Replace(inputString, "i");
            inputString = replace_o_Accents.Replace(inputString, "o");
            inputString = replace_u_Accents.Replace(inputString, "u");

            return inputString;
        }
    }
}
