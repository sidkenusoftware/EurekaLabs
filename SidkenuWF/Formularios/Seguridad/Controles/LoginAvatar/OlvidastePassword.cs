using Sidkenu.LogicaNegocio.Servicios.Interface.Seguridad;
using Sidkenu.LogicaNegocio.Servicios.Interfaces.Email;

namespace SidkenuWF.Formularios.Seguridad.Controles.LoginAvatar
{
    public partial class OlvidastePassword : Form
    {
        private readonly ICorreoElectronico _correoElectronico;
        private readonly ICuentaServicio _cuentaServicio;
        private Guid _userId;

        public OlvidastePassword(ICorreoElectronico correoElectronico, ICuentaServicio cuentaServicio, Guid userId, string mailPersonaLogin)
        {
            InitializeComponent();

            _correoElectronico = correoElectronico;
            _cuentaServicio = cuentaServicio;
            _userId = userId;

            lblMensaje.Text = $"Para estar seguro que efectivamente sos vos quien está solicitando una nueva clave, " +
                $"vamos a enviarte a la cuenta {correoElectronico.OcultarMailConAsteriscos(mailPersonaLogin)} que " +
                $"ingresaste cuando te registraste en el sistema.";
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            if (_cuentaServicio.GenerarNuevoPassword(_userId))
            {
                MessageBox.Show("El Correo se envió correctamente", "Atención");
            }
            else
            {
                MessageBox.Show("Ocurrió un error al recuperar la contraseña.", "Atención");
            }
        }
    }
}
