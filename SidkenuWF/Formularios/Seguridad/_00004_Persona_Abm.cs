using FontAwesome.Sharp;
using Serilog;
using Sidkenu.AccesoDatos.Constantes;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Base;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Seguridad.Persona;
using Sidkenu.LogicaNegocio.Servicios.Interface.Seguridad;
using SidkenuWF.Formularios.Base;
using SidkenuWF.Formularios.Base.Constantes;
using SidkenuWF.Helpers;

namespace SidkenuWF.Formularios.Seguridad
{
    public partial class _00004_Persona_Abm : FormularioAbm
    {
        private readonly IPersonaServicio _personaServicio;

        public _00004_Persona_Abm(ISeguridadServicio seguridadServicio,
                                  IConfiguracionServicio configuracionServicio,
                                  ILogger logger,
                                  IPersonaServicio personaServicio,
                                  TipoOperacion tipoOperacion, Guid? entidadId = null)
            : base(seguridadServicio, configuracionServicio, logger, tipoOperacion, entidadId)
        {
            InitializeComponent();

            this._personaServicio = personaServicio;

            base.TituloFormulario = FormularioConstantes.Titulo;
            base.Titulo = $"Persona - {tipoOperacion.ToString()}";
            base.Logo = IconChar.BuildingFlag;

            AgregarControlesObligatorios(txtApellido, "Apellido");
            AgregarControlesObligatorios(txtNombre, "Nombre");
            AgregarControlesObligatorios(txtCuil, "CUIL");
            AgregarControlesObligatorios(txtDireccion, "Dirección");
            AgregarControlesObligatorios(txtTelefono, "Teléfono");
            AgregarControlesObligatorios(txtCorreoElectronico, "Correo Electronico");
            AgregarControlesObligatorios(dtpFechaNacimiento, "Fecha Nacimiento");

            txtApellido.KeyPress += Validacion.NoInyeccion;

            txtNombre.KeyPress += Validacion.NoInyeccion;

            txtDireccion.KeyPress += Validacion.NoInyeccion;

            txtTelefono.KeyPress += Validacion.NoInyeccion;
            txtTelefono.KeyPress += Validacion.NoLetras;

            txtCuil.KeyPress += Validacion.NoInyeccion;
            txtCuil.KeyPress += Validacion.NoLetras;

        }

        public override void EjecutarComandoFormLoad(object sender, EventArgs e)
        {
            CargarDatos(base.TipoOperacion, base.EntidadId, null);
        }

        public override void CargarDatos(TipoOperacion tipoOperacion, Guid? entidadId, Guid? entidadSecundariaId)
        {
            if (entidadId != null && entidadId.Value != Guid.Empty)
            {
                var resultPersona = _personaServicio.GetById(entidadId.Value);

                if (resultPersona.State)
                {
                    var _entidad = (PersonaDTO)resultPersona.Data;

                    txtApellido.Text = _entidad.Apellido;
                    txtNombre.Text = _entidad.Nombre;
                    txtCorreoElectronico.Text = _entidad.Mail;
                    txtCuil.Text = _entidad.Cuil;
                    txtDireccion.Text = _entidad.Direccion;
                    txtTelefono.Text = _entidad.Telefono;
                    dtpFechaNacimiento.Value = _entidad.FechaNacimiento;
                    ctrolFoto.Imagen = ImagenConvert.Convertir_Bytes_Imagen(_entidad.Foto);
                }
            }
        }

        public override ResultDTO EjecutarComandoInsert()
        {
            try
            {
                if (!VerificarDatosObligatorios())
                {
                    return new ResultDTO
                    {
                        State = false,
                        Message = "Por favor ingrese los campos Obligatorios."
                    };
                }

                if (!Validacion.ValidarEmail(txtCorreoElectronico.Text))
                {
                    return new ResultDTO
                    {
                        State = false,
                        Message = "El Correo Electrónico NO tiene el formato correcto"
                    };
                }

                var registro = AsignarDatos();

                var result = _personaServicio.Add(registro, Properties.Settings.Default.UserLogin);

                if (result.State)
                {
                    if (base._configuracionDTO != null && base._configuracionDTO != null && base._configuracionDTO.LogInformacion)
                    {
                        _logger.Information($"Se INSERTO Datos: {AsignarDatos().GetPropValue()}. User: {Properties.Settings.Default.PersonaLogin}");
                    }
                }

                return result;
            }
            catch (Exception ex)
            {
                if (base._configuracionDTO != null && base._configuracionDTO != null && base._configuracionDTO.LogError)
                {
                    _logger.Error(ex, $"Error al INSERTAR en {base.Titulo}. User: {Properties.Settings.Default.PersonaLogin}. Datos: {AsignarDatos().GetPropValue()}");
                }

                return new ResultDTO
                {
                    State = false,
                    Message = ex.InnerException == null ? ex.Message : ex.InnerException.Message
                };
            }
        }

        public override ResultDTO EjecutarComandoUpdate()
        {
            try
            {
                if (!VerificarDatosObligatorios())
                {
                    return new ResultDTO
                    {
                        State = false,
                        Message = "Por favor ingrese los campos Obligatorios."
                    };
                }

                if (!Validacion.ValidarEmail(txtCorreoElectronico.Text))
                {
                    return new ResultDTO
                    {
                        State = false,
                        Message = "El Correo Electrónico NO tiene el formato correcto"
                    };
                }

                var registro = AsignarDatos();

                var result = _personaServicio.Update(registro, Properties.Settings.Default.UserLogin);

                if (result.State)
                {
                    if (base._configuracionDTO != null && base._configuracionDTO != null && base._configuracionDTO.LogInformacion)
                    {
                        _logger.Information($"Se ACTUALIZO Datos: {AsignarDatos().GetPropValue()}. User: {Properties.Settings.Default.PersonaLogin}");
                    }
                }

                return result;
            }
            catch (Exception ex)
            {
                if (base._configuracionDTO != null && base._configuracionDTO != null && base._configuracionDTO.LogError)
                {
                    _logger.Error(ex, $"Error al ACTUALIZAR en {base.Titulo}. User: {Properties.Settings.Default.PersonaLogin}. Datos: {AsignarDatos().GetPropValue()}");
                }

                return new ResultDTO
                {
                    State = false,
                    Message = ex.InnerException == null ? ex.Message : ex.InnerException.Message
                };
            }
        }

        private PersonaPersistenciaDTO AsignarDatos()
        {
            var _entidad = new PersonaPersistenciaDTO
            {
                Id = EntidadId ?? Guid.Empty,
                Apellido = txtApellido.Text,
                Nombre = txtNombre.Text,
                Direccion = txtDireccion.Text,
                Foto = ImagenConvert.Convertir_Imagen_Bytes(ctrolFoto.Imagen),
                Mail = txtCorreoElectronico.Text,
                Cuil = txtCuil.Text,
                EstaEliminado = false,
                Telefono = txtTelefono.Text,
                FechaNacimiento = dtpFechaNacimiento.Value
            };

            this.Entidad = _entidad;

            return _entidad;
        }


        public override void OperacionAdicionalFinalizarInsert()
        {
            txtApellido.Focus();
        }
    }
}
