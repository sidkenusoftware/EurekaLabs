using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Sidkenu.AccesoDatos.Infraestructura;
using Sidkenu.Infraestructura;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Seguridad.Cuenta;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Seguridad.Usuario;
using Sidkenu.LogicaNegocio.Servicios.Implementacion.Base;
using Sidkenu.LogicaNegocio.Servicios.Interface.Seguridad;
using Sidkenu.LogicaNegocio.Servicios.Interfaces.Email;
using StructureMap;

namespace Sidkenu.LogicaNegocio.Servicios.Implementacion.Seguridad
{
    public class CuentaServicio : ServicioBase, ICuentaServicio
    {
        private readonly IPasswordServicio _passwordService;
        private readonly ICorreoElectronico _correoElectronico;

        public CuentaServicio(IMapper mapper,
                              IConfiguracionServicio configuracionServicio,
                              IPasswordServicio passwordService,
                              ICorreoElectronico correoElectronico)
                              : base(mapper, configuracionServicio)
        {
            _passwordService = passwordService;
            _correoElectronico = correoElectronico;
        }

        public (bool, UsuarioDTO) GetLoginByCredentials(UserLoginDTO login)
        {
            using var _context = new DataContext();

            var users = _context.Usuarios
                .AsNoTracking()
                .Include(p => p.Persona)
                .ThenInclude(mp => mp.EmpresaPersonas)
                .ThenInclude(m => m.Empresa)
                .Where(x => x.Nombre == login.User)
                .ToList();
            
            var user = users.FirstOrDefault();

            if (user == null)
            {
                return (false, null);
            }

            // Comprueba si la contraseña es correcta
            var isValid = _passwordService.Check(users.First().Password, login.Password);

            if (!isValid)
            {
                return (false, null);
            }

            var userDTO = _mapper.Map<UsuarioDTO>(users.FirstOrDefault());

            return (true, userDTO);
        }

        public bool GenerarNuevoPassword(Guid userId)
        {
            try
            {
                using var _context = new DataContext();

                var user = _context.Usuarios.Include(p => p.Persona)
                                         .ThenInclude(mp => mp.EmpresaPersonas)
                                         .ThenInclude(m => m.Empresa)
                                         .FirstOrDefault(x => x.Id == userId);

                var nuevoPass = _passwordService.Generar(10);

                user.Password = _passwordService.Hash(nuevoPass);

                _context.Usuarios.Update(user);


                // ------------------------------------------------------------------------------------- //

                _context.SaveChanges();

                var asunto = "Recuperación de Contraseña";

                var mensaje = $"Ud. a solicitado la recuperación de la contraseña." + Environment.NewLine + Environment.NewLine +
                    $"La nueva contraseña es {nuevoPass}." + Environment.NewLine +
                    $"Saludos.";

                _correoElectronico.Enviar(user.Persona.Mail,
                                          _configuracionDTO.UsuarioCredencial,
                                          asunto,
                                          mensaje,
                                          _configuracionDTO.UsuarioCredencial,
                                          _configuracionDTO.PasswordCredencial,
                                          _configuracionDTO.Host, _configuracionDTO.Puerto,
                                          false);

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
