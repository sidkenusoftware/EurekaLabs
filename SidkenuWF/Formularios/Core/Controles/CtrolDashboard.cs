using FontAwesome.Sharp;

namespace SidkenuWF.Formularios.Core.Controles
{
    public partial class CtrolDashboard : UserControl
    {
        public IconChar Icono { set { this.imgLogo.IconChar = value; } }

        public string Titulo { set { this.lblTitulo.Text = value; } }

        public Color ColorTitulo { set { this.lblTitulo.ForeColor = value; } }

        public string Valor { set { this.lblValor.Text = value; } }

        public CtrolDashboard()
        {
            InitializeComponent();
        }
    }
}
