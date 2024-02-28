namespace SidkenuWF.Formularios.Core.Controles
{
    public partial class CtrolVarianteConStockPrecio : UserControl
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

        public decimal Precio => nudPrecio.Value;

        public decimal Stock => nudStock.Value;

        public int Fila { get; set; }

        public CtrolVarianteConStockPrecio()
        {
            InitializeComponent();

            chkValor.Checked = false;
            pnlContenedor.Enabled = false;
            nudPrecio.Value = 0;
            nudStock.Value = 0;
        }

        private void ChkValor_CheckedChanged(object sender, EventArgs e)
        {
            pnlContenedor.Enabled = chkValor.Checked;
            nudPrecio.Value = 0;
            nudStock.Value = 0;
        }
    }
}
