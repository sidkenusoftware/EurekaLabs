using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.Articulo;

namespace SidkenuWF.Formularios.Core.Controles
{
    public partial class CtrolVerStock : UserControl
    {
        private readonly ArticuloDepositoDTO _articuloDepositoDTO;

        public CtrolVerStock()
        {
            InitializeComponent();
        }

        public CtrolVerStock(ArticuloDepositoDTO articuloDeposito)
            : this()
        {
            _articuloDepositoDTO = articuloDeposito;
        }

        private void CtrolVerStock_Load(object sender, EventArgs e)
        {
            lblDeposito.Text = _articuloDepositoDTO.Deposito;
            lblStock.Text = _articuloDepositoDTO.Cantidad.ToString("N2");
        }
    }
}
