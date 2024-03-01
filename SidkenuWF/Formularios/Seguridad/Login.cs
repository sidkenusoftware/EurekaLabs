using Sidkenu.LogicaNegocio.Servicios.DTOs.Seguridad.Cuenta;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Seguridad.Usuario;
using Sidkenu.LogicaNegocio.Servicios.Interface.Seguridad;
using Sidkenu.LogicaNegocio.Servicios.Interfaces.Email;
using SidkenuWF.Formularios.Seguridad.Controles.LoginAvatar;

namespace SidkenuWF.Formularios.Seguridad
{
    public partial class Login : Form
    {
        private readonly ICuentaServicio _cuentaServicio;
        private readonly IUsuarioServicio _usuarioServicio;

        public bool PuedeIngresar { get; set; }

        public UsuarioDTO? UsuarioLogin { get; private set; } = null;


        public Login(ICuentaServicio cuentaServicio,
            IUsuarioServicio usuarioServicio)
        {
            InitializeComponent();

            _cuentaServicio = cuentaServicio;
            _usuarioServicio = usuarioServicio;
        }

        private async void BtnIngresar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsuario.Text))
            {
                MessageBox.Show("El nombre de usuario es Obligatorio");
                this.txtUsuario.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("La contraseña es un dato Obligatorio");
                this.txtPassword.Focus();
                return;
            }

            if (VerificarIngreso(txtUsuario.Text, txtPassword.Text))
            {
                AsignarValoresSetting();

                if (UsuarioLogin.Empresas.Any())
                {
                    if (UsuarioLogin.Empresas.Count > 1)
                    {
                        var fEmpresas = new Empresas(UsuarioLogin.Empresas);
                        fEmpresas.ShowDialog();

                        if (fEmpresas.SeleccionoUnaEmpresa)
                        {
                            this.Close();
                        }
                        else
                        {
                            PuedeIngresar = false;
                            this.Close();
                        }
                    }
                    else // Solo esta asociado a  una empresa
                    {
                        var empresaSeleccionada = UsuarioLogin.Empresas.First();

                        Properties.Settings.Default.EmpresaId = empresaSeleccionada.Id;
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show($"El usuario {UsuarioLogin.ApyNomPersona} no esta asociado a ninguna Empresa", "Atención");
                    this.Close();
                }
            }
            else
            {
                if (!PuedeIngresar)
                {
                    MessageBox.Show("El usuario o la contraseña son incorrectas", "Atención");
                    this.txtPassword.Clear();
                    this.txtPassword.Focus();
                    return;
                }
            }
        }

        private void AsignarValoresSetting()
        {
            Properties.Settings.Default.UserLogin = UsuarioLogin.Nombre;
            Properties.Settings.Default.UserLoginId = UsuarioLogin.Id;
            Properties.Settings.Default.PersonaLoginId = UsuarioLogin.PersonaId;
            Properties.Settings.Default.PersonaLogin = UsuarioLogin.ApyNomPersona;
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
                    PuedeIngresar = result.Item1;
                    UsuarioLogin = result.Item2;
                }
            }

            return result.Item1;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro que desea salir", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                PuedeIngresar = false;
                Application.Exit();
            }
            else
            {
                if (string.IsNullOrEmpty(this.txtUsuario.Text))
                {
                    this.txtUsuario.Focus();
                }
                else
                {
                    this.txtPassword.Focus();
                }
            }
        }

        private void BtnVerPassword_MouseDown(object sender, MouseEventArgs e)
        {
            this.txtPassword.PasswordChar = char.MinValue;
        }

        private void BtnVerPassword_MouseUp(object sender, MouseEventArgs e)
        {
            this.txtPassword.PasswordChar = '*';
        }

        private void LinkOlvidastePassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var result = _usuarioServicio.GetByName(this.txtUsuario.Text);

            if (result != null && result.State)
            {
                var _usuarioSeleccionado = (UsuarioDTO)result.Data;

                var fOlvidastePassword = new OlvidastePassword(Program.Container.GetInstance<ICorreoElectronico>(),
                Program.Container.GetInstance<ICuentaServicio>(),
                _usuarioSeleccionado.Id,
                _usuarioSeleccionado.EmailPersona);

                fOlvidastePassword.ShowDialog();
            }
            else
            {
                MessageBox.Show($"El usuario {txtUsuario.Text} no existe.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtUsuario.Clear();
                this.txtUsuario.Focus();
            }
        }

        private void BtnVerPassword_Click(object sender, EventArgs e)
        {

        }

        private void pnlFondo_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
