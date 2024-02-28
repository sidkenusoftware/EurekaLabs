using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.Caja;
using SidkenuWF.Formularios.Base;

namespace SidkenuWF.Formularios.Core.Varios
{
    public partial class CajasAbiertas : FormularioComun
    {
        private List<CajaDTO> cajas;

        public CajasAbiertas()
        {
            InitializeComponent();

            Titulo = "Cajas";
            Logo = FontAwesome.Sharp.IconChar.CashRegister;
            imgCaja.IconChar = FontAwesome.Sharp.IconChar.CashRegister;
        }

        public CajasAbiertas(List<CajaDTO> cajas)
            : this()
        {
            this.cajas = cajas;
            this.RealizoAlgunaOperacion = false;
        }

        public bool RealizoAlgunaOperacion { get; private set; }

        private void CajasAbiertas_Load(object sender, EventArgs e)
        {
            PoblarComboBox(cmbCaja, cajas, "Descripcion", "Id");
        }

        private void BtnAbrirCaja_Click(object sender, EventArgs e)
        {
            if (cajas.Count <= 0)
            {
                MessageBox.Show("No hay Cajas cargadas");
                return;
            }

            var _cajaSeleccionada = (CajaDTO)cmbCaja.SelectedItem;

            Properties.Settings.Default.CajaId = _cajaSeleccionada.Id;
            Properties.Settings.Default.CajaDetalleId = _cajaSeleccionada.CajaDetalleId.HasValue ? _cajaSeleccionada.CajaDetalleId.Value : Guid.Empty;
            Properties.Settings.Default.Save();
            RealizoAlgunaOperacion = true;
            this.Close();
        }
    }
}
