namespace SidkenuWF.Formularios.Core.Controles
{
    public partial class CtrolVariante : UserControl
    {
        private Guid _escalaValor1Id;
        public Guid VarianteValor1Id
        {
            get { return _escalaValor1Id; }
            set
            {
                _escalaValor1Id = value;
            }
        }

        private Guid _escalaValor2Id;
        public Guid VarianteValor2Id
        {
            get { return _escalaValor2Id; }
            set
            {
                _escalaValor2Id = value;
            }
        }
        
        public bool EstaSeleccionado => chkValor.Checked;

        public int Fila { get; set; }

        public CtrolVariante()
        {
            InitializeComponent();
        }
    }
}
