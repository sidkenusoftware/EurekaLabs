using Serilog;
using Sidkenu.AccesoDatos.Constantes;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Seguridad.Configuracion;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Seguridad.Modulo;
using Sidkenu.LogicaNegocio.Servicios.Interface.Seguridad;
using SidkenuWF.Formularios.Base;
using SidkenuWF.Helpers;

namespace SidkenuWF.Formularios.Seguridad
{
    public partial class _00023_AjusteSeguridad : FormularioConfiguracion
    {
        private readonly IConfiguracionServicio _configuracionServicio;
        private readonly IModuloServicio _moduloServicio;

        private ConfiguracionDTO _configuracionDTO;
        private ModuloDTO _moduloDTO;

        public _00023_AjusteSeguridad(IConfiguracionServicio configuracionServicio,
                                      IModuloServicio moduloServicio,
                                      ISeguridadServicio seguridadServicio,
                                      ILogger logger)
                                      : base(seguridadServicio, configuracionServicio, logger)
        {
            InitializeComponent();

            _configuracionServicio = configuracionServicio;
            _moduloServicio = moduloServicio;

            lblTitulo.Text = "Ajuste / Configuración";

            txtCredencialPassword.KeyPress += Validacion.NoInyeccion;

            txtCredencialUsuario.KeyPress += Validacion.NoInyeccion;

            txtHost.KeyPress += Validacion.NoInyeccion;

            txtPuerto.KeyPress += Validacion.NoInyeccion;
            txtPuerto.KeyPress += Validacion.NoLetras;

            CargarDatos(Properties.Settings.Default.EmpresaId);
        }

        public override void CargarDatos(Guid? empresaId)
        {
            var resultConfig = _configuracionServicio.Get();

            if (resultConfig != null && resultConfig.State)
            {
                _configuracionDTO = (ConfiguracionDTO)resultConfig.Data;

                if (_configuracionDTO != null)
                {
                    rdbLoginNormal.Checked = _configuracionDTO.LoginNormal;
                    rdbLoginAvatar.Checked = !_configuracionDTO.LoginNormal;

                    chkEnviarMailAlCrearUsuario.Checked = _configuracionDTO.EnviarMailCreateUsuario;

                    txtCredencialPassword.Text = !string.IsNullOrEmpty(_configuracionDTO.PasswordCredencial)
                        ? _configuracionDTO.PasswordCredencial
                        : MailOptions.PasswordCredencialMail;

                    txtCredencialUsuario.Text = !string.IsNullOrEmpty(_configuracionDTO.UsuarioCredencial)
                        ? _configuracionDTO.UsuarioCredencial
                        : MailOptions.UsuarioCredencialMail;

                    txtHost.Text = !string.IsNullOrEmpty(_configuracionDTO.Host)
                        ? _configuracionDTO.Host
                        : MailOptions.Host;

                    txtPuerto.Text = _configuracionDTO.Puerto != 0 ? _configuracionDTO.Puerto.ToString() : MailOptions.Puerto.ToString();

                    chkLogginError.Checked = _configuracionDTO.LogError;
                    chkLogginInformacion.Checked = _configuracionDTO.LogInformacion;
                    chkLogginWarning.Checked = _configuracionDTO.LogWarning;
                }
                else
                {
                    rdbLoginAvatar.Checked = true;

                    chkEnviarMailAlCrearUsuario.Checked = true;

                    txtCredencialPassword.Text = MailOptions.PasswordCredencialMail;

                    txtCredencialUsuario.Text = MailOptions.UsuarioCredencialMail;

                    txtHost.Text = MailOptions.Host;

                    txtPuerto.Text = MailOptions.Puerto.ToString();

                    chkLogginError.Checked = true;
                    chkLogginInformacion.Checked = true;
                    chkLogginWarning.Checked = true;
                }
            }

            if (empresaId != Guid.Empty && empresaId.HasValue)
            {
                var resultModulo = _moduloServicio.Get(empresaId.Value);

                if (resultModulo != null && resultModulo.State)
                {
                    _moduloDTO = (ModuloDTO)resultModulo.Data;

                    chkModuloCompra.Checked = _moduloDTO == null ? false : _moduloDTO.Compra;
                    chkModuloFabricacion.Checked = _moduloDTO == null ? false : _moduloDTO.Fabricacion;
                    chkModuloInventario.Checked = _moduloDTO == null ? false : _moduloDTO.Inventario;
                    chkModuloPuntoVenta.Checked = _moduloDTO == null ? false : _moduloDTO.PuntoVenta;
                    chkModuloSeguridad.Checked = _moduloDTO == null ? true : _moduloDTO.Seguridad;
                    chkModuloVenta.Checked = _moduloDTO == null ? false : _moduloDTO.Venta;
                    chkModuloCaja.Checked = _moduloDTO == null ? false : _moduloDTO.Caja;
                    chkModuloDashBoard.Checked = _moduloDTO == null ? false : _moduloDTO.DashBoard;
                }
            }
        }

        public override void EjecutarComandoGuardar()
        {
            if (string.IsNullOrEmpty(txtCredencialUsuario.Text))
            {
                MessageBox.Show("El usuario de Mail es Obligatoria", "Atención");
                txtCredencialUsuario.Focus();
            }

            if (string.IsNullOrEmpty(txtCredencialPassword.Text))
            {
                MessageBox.Show("La Contraseña de Mail es Obligatoria", "Atención");
                txtCredencialPassword.Focus();
            }

            if (string.IsNullOrEmpty(txtHost.Text))
            {
                MessageBox.Show("El Host es Obligatoria", "Atención");
                txtHost.Focus();
            }

            if (string.IsNullOrEmpty(txtPuerto.Text))
            {
                MessageBox.Show("El Puerto es Obligatoria", "Atención");
                txtPuerto.Focus();
            }

            var configuracion = AsignarDatosConfiguracion();
            var modulo = AsignarDatosModulos();

            try
            {
                _configuracionServicio.AddOrUpdate(configuracion, Properties.Settings.Default.UserLogin);
                _moduloServicio.AddOrUpdate(modulo, Properties.Settings.Default.UserLogin);

                MessageBox.Show("Los datos se grabaron correctamente");

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException == null ? ex.Message : ex.InnerException.Message, "Error");
            }
        }

        private ModuloPersistenciaDTO AsignarDatosModulos()
        {
            return new ModuloPersistenciaDTO
            {
                Id = _moduloDTO != null ? _moduloDTO.Id : Guid.Empty,
                EmpresaId = Properties.Settings.Default.EmpresaId,
                Compra = chkModuloCompra.Checked,
                Venta = chkModuloVenta.Checked,
                PuntoVenta = chkModuloPuntoVenta.Checked,
                Fabricacion = chkModuloFabricacion.Checked,
                Inventario = chkModuloInventario.Checked,
                Seguridad = chkModuloSeguridad.Checked,
                Caja = chkModuloCaja.Checked,
                DashBoard = chkModuloDashBoard.Checked,
                EstaEliminado = false,
            };
        }

        private ConfiguracionPersistenciaDTO AsignarDatosConfiguracion()
        {
            return new ConfiguracionPersistenciaDTO
            {
                Id = _configuracionDTO != null ? _configuracionDTO.Id : Guid.Empty,
                EnviarMailCreateUsuario = chkEnviarMailAlCrearUsuario.Checked,
                Host = txtHost.Text,
                LogError = chkLogginError.Checked,
                LogInformacion = chkLogginInformacion.Checked,
                LogWarning = chkLogginWarning.Checked,
                LoginNormal = rdbLoginNormal.Checked,
                PasswordCredencial = txtCredencialPassword.Text,
                UsuarioCredencial = txtCredencialUsuario.Text,
                Puerto = int.Parse(txtPuerto.Text),
                EstaEliminado = false,
            };
        }

        private void BtnVerCredencialUsuario_MouseDown(object sender, MouseEventArgs e)
        {
            txtCredencialUsuario.PasswordChar = char.MinValue;
        }

        private void BtnVerCredencialPass_MouseDown(object sender, MouseEventArgs e)
        {
            txtCredencialPassword.PasswordChar = char.MinValue;
        }

        private void BtnVerHost_MouseDown(object sender, MouseEventArgs e)
        {
            txtHost.PasswordChar = char.MinValue;
        }

        private void BtnVerPuerto_MouseDown(object sender, MouseEventArgs e)
        {
            txtPuerto.PasswordChar = char.MinValue;
        }

        private void BtnVerPuerto_MouseUp(object sender, MouseEventArgs e)
        {
            txtPuerto.PasswordChar = '*';
        }

        private void BtnVerHost_MouseUp(object sender, MouseEventArgs e)
        {
            txtHost.PasswordChar = '*';
        }

        private void BtnVerCredencialPass_MouseUp(object sender, MouseEventArgs e)
        {
            txtCredencialPassword.PasswordChar = '*';
        }

        private void BtnVerCredencialUsuario_MouseUp(object sender, MouseEventArgs e)
        {
            txtCredencialUsuario.PasswordChar = '*';
        }
    }
}
