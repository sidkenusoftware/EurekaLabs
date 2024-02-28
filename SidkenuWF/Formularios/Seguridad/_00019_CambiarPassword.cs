using FontAwesome.Sharp;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Seguridad.Usuario;
using Sidkenu.LogicaNegocio.Servicios.Interface.Seguridad;

namespace SidkenuWF.Formularios.Seguridad
{
    public partial class _00019_CambiarPassword : Form
    {
        private readonly IUsuarioServicio _usuarioServicio;

        public _00019_CambiarPassword()
        {
            InitializeComponent();

            this.Text = Base.Constantes.FormularioConstantes.Titulo;

            CargarAparienciaFormulario();
        }

        public _00019_CambiarPassword(IUsuarioServicio usuarioServicio)
            : this()
        {
            this._usuarioServicio = usuarioServicio;
        }

        private void CargarAparienciaFormulario()
        {
            this.pnlTitulo.BackColor = Base.Constantes.ColorFormulario.ColorPanelTitulo;
            this.pnlLinea.BackColor = Base.Constantes.ColorFormulario.ColorPanelLinea;

            this.pnlBotonera.BackColor = Base.Constantes.ColorFormulario.ColorPanelBotoneraLateral;

            this.lblTitulo.BackColor = Base.Constantes.ColorFormulario.ColorFondoTitulo;
            this.lblTitulo.ForeColor = Base.Constantes.ColorFormulario.ColorFuenteTitulo;

            this.imgLogo.BackColor = Base.Constantes.ColorFormulario.ColorFondologo;
            this.imgLogo.IconColor = Base.Constantes.ColorFormulario.ColorIconoLogo;

            CargarAparienciaBotonMenuLateral(btnSalir, false);

            CargarAparienciaBotonMenuLateral(btnEjecutar, false);
        }

        public virtual void CargarAparienciaBotonMenuLateral(IconButton button, bool mostrarBorde = true)
        {
            button.IconColor = Base.Constantes.ColorFormulario.ColorIconoBotonLateral;
            button.FlatAppearance.BorderColor = Base.Constantes.ColorFormulario.ColorBordeBotonLateral;
            button.FlatAppearance.BorderSize = mostrarBorde ? 1 : 0;
            button.ForeColor = Base.Constantes.ColorFormulario.ColorFuenteBotonLateral;
            button.BackColor = Base.Constantes.ColorFormulario.ColorFondoBotonLateral;
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnPasswordActual_MouseDown(object sender, MouseEventArgs e)
        {
            this.txtPasswordActual.PasswordChar = char.MinValue;
        }

        private void BtnPasswordActual_MouseUp(object sender, MouseEventArgs e)
        {
            this.txtPasswordActual.PasswordChar = '*';
        }

        private void BtnPasswordNueva_MouseDown(object sender, MouseEventArgs e)
        {
            this.txtPaswordNueva.PasswordChar = char.MinValue;
        }

        private void BtnPasswordNueva_MouseUp(object sender, MouseEventArgs e)
        {
            this.txtPaswordNueva.PasswordChar = '*';
        }

        private void BtnRepetirPassword_MouseDown(object sender, MouseEventArgs e)
        {
            this.txtRepetirPassword.PasswordChar = char.MinValue;
        }

        private void BtnRepetirPassword_MouseUp(object sender, MouseEventArgs e)
        {
            this.txtRepetirPassword.PasswordChar = '*';
        }

        private void BtnEjecutar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtPasswordActual.Text))
            {
                MessageBox.Show("La contraseña ACTUAL es Obligatoria", "Atención"
                    , MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPasswordActual.Focus();
                return;
            }

            if (string.IsNullOrEmpty(this.txtPaswordNueva.Text))
            {
                MessageBox.Show("La contraseña NUEVA es Obligatoria", "Atención"
                    , MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPaswordNueva.Focus();
                return;
            }

            if (string.IsNullOrEmpty(this.txtRepetirPassword.Text))
            {
                MessageBox.Show("La contraseña CONFIRMACION es Obligatoria", "Atención"
                    , MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtRepetirPassword.Focus();
                return;
            }

            if (!this.txtPaswordNueva.Text.Equals(this.txtRepetirPassword.Text, StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("La contraseña NUEVA y la de CONFIRMACION no son Iguales", "Atención"
                    , MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtRepetirPassword.Clear();
                txtRepetirPassword.Focus();
                return;
            }

            try
            {
                var result = _usuarioServicio.CambiarPassword(new UsuarioCambioPasswordDTO
                {
                    UserId = Properties.Settings.Default.UserLoginId,
                    PasswordActual = this.txtPasswordActual.Text,
                    PasswordNueva = this.txtPaswordNueva.Text
                }, Properties.Settings.Default.UserLogin);

                MessageBox.Show("Los datos se grabaron correctamente", "Atención");

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
