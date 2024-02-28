using FontAwesome.Sharp;
using Sidkenu.AccesoDatos.Entidades.Core;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.Caja;
using Sidkenu.LogicaNegocio.Servicios.Interface.Core;
using SidkenuWF.Formularios.Base;
using SidkenuWF.Helpers;

namespace SidkenuWF.Formularios.Core
{
    public partial class _00116_AperturaCaja : FormularioBase
    {
        private Guid _cajaId;
        private readonly ICajaServicio _cajaServicio;

        public bool RealizoAlgunaOperacion { get; set; }
        public Guid DetalleId { get; private set; }

        public _00116_AperturaCaja(Guid cajaId, ICajaServicio cajaServicio)
        {
            InitializeComponent();

            this.lblTitulo.Text = "Apertura de Caja";
            this.Text = "Apertura de Caja";
            this.imgLogo.IconChar = IconChar.CashRegister;

            _cajaServicio = cajaServicio;

            txtMonto.KeyPress += Validacion.NoInyeccion;
            txtMonto.KeyPress += Validacion.NoLetras;

            _cajaId = cajaId;

            RealizoAlgunaOperacion = false;
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            RealizoAlgunaOperacion = false;
            this.Close();
        }

        private void BtnAbrirCaja_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMonto.Text))
            {
                MessageBox.Show("El monto es un dato Obligatorio", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMonto.Focus();
            }

            try
            {
                var result = _cajaServicio.AbrirCaja(new CajaAperturaDTO
                {
                    Id = _cajaId,
                    Monto = decimal.Parse(txtMonto.Text),
                    PersonaAperturaId = Properties.Settings.Default.PersonaLoginId
                }, Properties.Settings.Default.UserLogin);

                if (result != null && result.State)
                {
                    var detalle = (CajaDetalle)result.Data;

                    btnAbrirCaja.Tag = detalle.Id;
                    DetalleId = detalle.Id;

                    MessageBox.Show(result.Message);

                    RealizoAlgunaOperacion = true;

                    this.Close();
                }
                else
                {
                    MessageBox.Show($"{result.Message}");

                    txtMonto.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrio un error al Abrir la Caja." + Environment.NewLine + ex.Message);
            }
        }
    }
}
