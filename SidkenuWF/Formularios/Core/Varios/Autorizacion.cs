using Sidkenu.LogicaNegocio.Servicios.DTOs.Seguridad.Cuenta;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Seguridad.Usuario;
using Sidkenu.LogicaNegocio.Servicios.Interface.Seguridad;
using SidkenuWF.Formularios.Base;
using SidkenuWF.Formularios.Base.Constantes;

namespace SidkenuWF.Formularios.Core.Varios
{
    public partial class Autorizacion : FormularioComun
    {
        private readonly ICuentaServicio _cuentaServicio;
        private readonly IUsuarioServicio _usuarioServicio;

        public bool EstaAutorizado { get; set; }

        public UsuarioDTO? UsuarioLogin { get; private set; } = null;

        public Autorizacion()
        {
            InitializeComponent();
            this.TituloFormulario = FormularioConstantes.Titulo;
            this.Titulo = "Autorización";
            this.Logo = FontAwesome.Sharp.IconChar.UnlockKeyhole;
        }

        public Autorizacion(ICuentaServicio cuentaServicio, IUsuarioServicio usuarioServicio)
            : this()
        {
            _cuentaServicio = cuentaServicio;
            _usuarioServicio = usuarioServicio;
        }

        private void BtnVerPassword_MouseDown(object sender, MouseEventArgs e)
        {
            this.txtPassword.PasswordChar = char.MinValue;
        }

        private void BtnVerPassword_MouseUp(object sender, MouseEventArgs e)
        {
            this.txtPassword.PasswordChar = '*';
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
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
                EstaAutorizado = true;
                this.Close();
            }
            else
            {
                if (!EstaAutorizado)
                {
                    MessageBox.Show("El usuario o la contraseña son incorrectas", "Atención");
                    this.txtPassword.Clear();
                    this.txtPassword.Focus();
                    return;
                }
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro que desea salir", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                EstaAutorizado = false;
                this.Close();
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
                    EstaAutorizado = result.Item1;
                    UsuarioLogin = result.Item2;
                }
            }

            return result.Item1;
        }
    }
}
