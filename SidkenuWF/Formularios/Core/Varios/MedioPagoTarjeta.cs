using Sidkenu.AccesoDatos.Constantes;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.PlanTarjeta;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.Tarjeta;
using Sidkenu.LogicaNegocio.Servicios.Interface.Core;
using SidkenuWF.Formularios.Base;
using SidkenuWF.Formularios.Base.Constantes;
using SidkenuWF.Helpers;

namespace SidkenuWF.Formularios.Core.Varios
{
    public partial class MedioPagoTarjeta : FormularioComun
    {
        private readonly ITarjetaServicio _tarjetaServicio;
        private readonly IPlanTarjetaServicio _planTarjetaServicio;

        public bool RealizoAlgunaOperacion { get; private set; }

        public decimal MontoPagar { get; private set; }
        public decimal InteresPagar { get; private set; }
        public Guid PlanTarjetaId { get; private set; }
        public string NumeroCupon { get; private set; }

        public MedioPagoTarjeta(ITarjetaServicio tarjetaServicio,
                                IPlanTarjetaServicio planTarjetaServicio,
                                decimal montoPagar)
        {
            InitializeComponent();

            base.Titulo = "Tarjeta";
            base.Logo = FontAwesome.Sharp.IconChar.CreditCard;
            base.TituloFormulario = FormularioConstantes.Titulo;

            _tarjetaServicio = tarjetaServicio;
            _planTarjetaServicio = planTarjetaServicio;

            MontoPagar = montoPagar;
            InteresPagar = 0m;

            RealizoAlgunaOperacion = false;

            txtNroCupon.KeyPress += Validacion.NoInyeccion;
            txtNroCupon.KeyPress += Validacion.NoLetras;
        }

        private void MedioPagoTarjeta_Load(object sender, EventArgs e)
        {
            nudMontoTarjeta.Value = MontoPagar;

            CargarDatos();
        }

        private void CargarDatos()
        {
            // Tarjeta de Credito / Debito

            var resultTarjeta = _tarjetaServicio.GetAll(Properties.Settings.Default.EmpresaId);

            if (resultTarjeta != null && resultTarjeta.State)
            {
                var datosTarjeta = (List<TarjetaDTO>)resultTarjeta.Data;

                PoblarComboBox(cmbTarjeta, datosTarjeta, "Descripcion", "Id");

                if (datosTarjeta.Count > 0)
                {
                    var resultPlanTarjeta = _planTarjetaServicio.GetAll((Guid)cmbTarjeta.SelectedValue);

                    if (resultPlanTarjeta != null && resultPlanTarjeta.State)
                    {
                        PoblarComboBox(cmbPlanTarjeta, resultPlanTarjeta.Data, "DescripcionCompleta", "Id");
                    }
                }
            }
        }

        private void CmbTarjeta_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var resultPlanTarjeta = _planTarjetaServicio.GetAll((Guid)cmbTarjeta.SelectedValue);

            if (resultPlanTarjeta != null && resultPlanTarjeta.State)
            {
                PoblarComboBox(cmbPlanTarjeta, resultPlanTarjeta.Data, "Descripcion", "Id");
            }
        }

        private void NudMontoTarjeta_ValueChanged(object sender, EventArgs e)
        {
            var _planSeleccionado = (PlanTarjetaDTO)cmbPlanTarjeta.SelectedItem;

            if (_planSeleccionado != null)
            {
                nudInteresTarjeta.Value = Porcentaje.Calcular(nudMontoTarjeta.Value, _planSeleccionado.Alicuota);

                nudTotal.Value = nudMontoTarjeta.Value + nudInteresTarjeta.Value;
            }
        }

        private void BtnEjecutar_Click(object sender, EventArgs e)
        {
            if (nudMontoTarjeta.Value <= 0)
            {
                MessageBox.Show("El monto debe ser mayor a Cero", "Atención");
                return;
            }

            if (string.IsNullOrEmpty(txtNroCupon.Text))
            {
                MessageBox.Show("El Numero de Cupon es un dato Obligatorio", "Atención");
                return;
            }

            MontoPagar = nudMontoTarjeta.Value;
            InteresPagar = nudInteresTarjeta.Value;
            PlanTarjetaId = (Guid)cmbPlanTarjeta.SelectedValue;
            NumeroCupon = txtNroCupon.Text;

            RealizoAlgunaOperacion = true;
            Close();
        }

        private void CmbPlanTarjeta_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var _planSeleccionado = (PlanTarjetaDTO)cmbPlanTarjeta.SelectedItem;

            if (_planSeleccionado != null)
            {
                nudInteresTarjeta.Value = Porcentaje.Calcular(nudMontoTarjeta.Value, _planSeleccionado.Alicuota);

                nudTotal.Value = nudMontoTarjeta.Value + nudInteresTarjeta.Value;
            }
        }

        private void MedioPagoTarjeta_Activated(object sender, EventArgs e)
        {
            txtNroCupon.Focus();
        }
    }
}
