using SidkenuWF.Helpers;

namespace SidkenuWF.Formularios.Base.Controles
{
    public partial class SidkenuParametrica : UserControl
    {
        public string Titulo
        {
            set
            {
                this.lblTitulo.Text = value;

                this.lblLetra.Text = value[..1];
                this.lblLetra.BackColor = ColorAleatorio.Obtener(value[..1]);
            }
        }

        public SidkenuParametrica()
        {
            InitializeComponent();
        }
    }
}
