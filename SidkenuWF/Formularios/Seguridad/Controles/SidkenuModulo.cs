using FontAwesome.Sharp;
using SidkenuWF.Helpers;

namespace SidkenuWF.Formularios.Seguridad.Controles
{
    public partial class SidkenuModulo : UserControl
    {
        public string Titulo
        {
            set
            {
                this.lblTitulo.Text = value;
                imgLogo.BackColor = ColorAleatorio.Obtener(value[..1]);
                btnIngresar.Tag = value;
            }
        }

        public string Descripcion
        {
            set
            {
                this.lblDescripcion.Text = value;
            }
        }

        public IconChar Icono
        {
            set
            {
                imgLogo.IconChar = value;
            }
        }

        public SidkenuModulo()
        {
            InitializeComponent();
        }

        private void ImgLogo_MouseEnter(object sender, EventArgs e)
        {
            imgLogo.Size = new Size(76, 76);
            imgLogo.Location = new Point(7, 7);
        }

        private void ImgLogo_MouseLeave(object sender, EventArgs e)
        {
            imgLogo.Size = new Size(70, 70);
            imgLogo.Location = new Point(10, 10);
        }
    }
}
