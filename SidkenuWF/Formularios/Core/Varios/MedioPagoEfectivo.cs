using SidkenuWF.Formularios.Base;
using SidkenuWF.Formularios.Base.Constantes;

namespace SidkenuWF.Formularios.Core.Varios
{
    public partial class MedioPagoEfectivo : FormularioComun
    {

        public decimal MontoPagar { get; private set; }
        public bool RealizoAlgunaOperacion { get; set; }

        public MedioPagoEfectivo(decimal montoPagar)
        {
            InitializeComponent();

            base.Titulo = "Efectivo";
            base.Logo = FontAwesome.Sharp.IconChar.Dollar;
            base.TituloFormulario = FormularioConstantes.Titulo;

            MontoPagar = montoPagar;
            RealizoAlgunaOperacion = false;
        }

        private void MedioPagoEfectivo_Load(object sender, EventArgs e)
        {
            nudMontoEfectivo.Value = MontoPagar;
        }

        private void BtnEjecutar_Click(object sender, EventArgs e)
        {
            if (nudMontoEfectivo.Value <= 0)
            {
                MessageBox.Show("El monto debe ser mayor a Cero", "Atención");
                return;
            }

            MontoPagar = nudMontoEfectivo.Value;
            RealizoAlgunaOperacion = true;
            Close();
        }

        private void MedioPagoEfectivo_Activated(object sender, EventArgs e)
        {
            nudMontoEfectivo.Focus();
        }
    }
}
