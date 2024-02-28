namespace SidkenuWF.Formularios.Core.Controles
{
    public partial class CtrolVarianteTitulo : UserControl
    {
        public string Titulo 
        {
            set 
            {
                lblTitulo.Text = value;
            } 
        }

        public CtrolVarianteTitulo()
        {
            InitializeComponent();
        }
    }
}
