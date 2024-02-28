using Sidkenu.LogicaNegocio.Servicios.DTOs.Seguridad.Cuenta;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Seguridad.Usuario;
using Sidkenu.LogicaNegocio.Servicios.Interface.Seguridad;
using Sidkenu.LogicaNegocio.Servicios.Interfaces.Email;
using SidkenuWF.Formularios.Seguridad.Controles.LoginAvatar;

namespace SidkenuWF.Formularios.Base.Controles.LoginAvatar
{
    public partial class PasswordAvatar : Form
    {
        private readonly ICuentaServicio _cuentaServicio;

        private UsuarioDTO _usuarioSeleccionado;

        public UsuarioDTO? UsuarioLogin { get; set; } = null;

        public bool PuedeAcceder { get; private set; }

        public PasswordAvatar(ICuentaServicio cuentaServicio,
                              UsuarioDTO usuarioSeleccionado)
        {
            InitializeComponent();

            _cuentaServicio = cuentaServicio;

            _usuarioSeleccionado = usuarioSeleccionado;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("La contraseña es un dato Obligatorio");
                this.txtPassword.Focus();
                return;
            }

            if (VerificarIngreso(_usuarioSeleccionado.Nombre, txtPassword.Text))
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("La contraseña es incorrecta", "Atención");

                txtPassword.Clear();
                txtPassword.Focus();
            }
        }

        private bool VerificarIngreso(string usuario, string password)
        {
            var result = _cuentaServicio.GetLoginByCredentials(new UserLoginDTO
            {
                User = usuario,
                Password = password
            });

            if (result.Item1)
            {
                if (result.Item2.EstaBloqueado)
                {
                    MessageBox.Show($"El usuario {result.Item2.ApyNomPersona} esta BLOQUEADO", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
                else
                {
                    PuedeAcceder = result.Item1;
                    UsuarioLogin = result.Item2;
                }
            }

            return result.Item1;
        }

        private void BtnVerPassword_MouseUp(object sender, MouseEventArgs e)
        {
            txtPassword.PasswordChar = '*';
        }

        private void BtnVerPassword_MouseDown(object sender, MouseEventArgs e)
        {
            txtPassword.PasswordChar = char.MinValue;
        }

        private void LinkOlvidastePassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var fOlvidastePassword = new OlvidastePassword(Program.Container.GetInstance<ICorreoElectronico>(),
                Program.Container.GetInstance<ICuentaServicio>(),
                _usuarioSeleccionado.Id,
                _usuarioSeleccionado.EmailPersona);

            fOlvidastePassword.ShowDialog();
        }
    }
}
