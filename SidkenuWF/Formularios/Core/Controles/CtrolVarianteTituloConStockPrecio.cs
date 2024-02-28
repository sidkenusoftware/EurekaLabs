namespace SidkenuWF.Formularios.Core.Controles
{
    public partial class CtrolVarianteTituloConStockPrecio : UserControl
    {
        public string Titulo
        {
            set
            {
                lblTitulo.Text = value;
            }
        }

        public decimal Precio => nudPrecio.Value;

        public decimal Stock => nudStock.Value;

        public int Fila { get; set; }

        public CtrolVarianteTituloConStockPrecio()
        {
            InitializeComponent();
        }
    }
}
