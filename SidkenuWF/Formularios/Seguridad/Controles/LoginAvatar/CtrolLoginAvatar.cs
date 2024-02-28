using Sidkenu.LogicaNegocio.Servicios.DTOs.Seguridad.Usuario;
using SidkenuWF.Helpers;

namespace SidkenuWF.Formularios.Base.Controles
{
    public partial class CtrolLoginAvatar : UserControl
    {
        public UsuarioDTO Usuario
        {
            set
            {
                lblApyNom.Text = value.ApyNomPersona.Length <= 16
                    ? value.ApyNomPersona
                    : $"{value.ApyNomPersona.Substring(0, 16)}..";

                imgFoto.Image = ImagenConvert.Convertir_Bytes_Imagen(value.FotoPersona);

                lblApyNom.Tag = value;
                imgFoto.Tag = value;
            }
        }

        public CtrolLoginAvatar()
        {
            InitializeComponent();
        }

        private void Control_MouseMove(object sender, MouseEventArgs e)
        {
            this.BackColor = Color.Gray;

            lblApyNom.ForeColor = Color.White;
            lblApyNom.Font = new Font("Arial", 10, FontStyle.Bold);
        }

        private void Control_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(64, 64, 64);

            lblApyNom.ForeColor = Color.Silver;
            lblApyNom.Font = new Font("Arial", 10, FontStyle.Regular);
        }
    }
}
