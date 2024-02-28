namespace SidkenuWF.Formularios.Base.Controles
{
    public partial class CtrolAsistente : UserControl
    {
        public CtrolAsistente()
        {
            InitializeComponent();
        }

        public virtual bool VerificarDatosObligatorios()
        {
            return false;
        }

        public virtual object? AsignarDatos()
        {
            return null;
        }
    }
}
