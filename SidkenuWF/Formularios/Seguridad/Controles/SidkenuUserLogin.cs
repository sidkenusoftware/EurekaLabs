using Sidkenu.LogicaNegocio.Servicios.Interface.Seguridad;
using SidkenuWF.Formularios.Seguridad;
using SidkenuWF.Helpers;

namespace SidkenuWF.Formularios.Base.Controles
{
    public partial class SidkenuUserLogin : UserControl
    {
        public string UsuarioLogin
        {
            set
            {
                lblUser.Text = value;
            }
        }

        public string PersonaLogin
        {
            set
            {
                lblApyNomEmpleado.Text = value;
            }
        }


        public byte[] FotoPersonaLogin
        {
            set
            {
                imgFoto.Image = ImagenConvert.Convertir_Bytes_Imagen(value);
            }
        }

        public SidkenuUserLogin()
        {
            InitializeComponent();

            CargarApariencia();
        }

        private void CargarApariencia()
        {
            this.pnlSuperior.BackColor = Constantes.ColorFormulario.ColorPanelSuperior;
        }

        private void BtnCambiarPassword_Click(object sender, EventArgs e)
        {
            var fCambiarPassword = new _00019_CambiarPassword(
                Program.Container.GetInstance<IUsuarioServicio>());

            fCambiarPassword.ShowDialog();
        }
    }
}
