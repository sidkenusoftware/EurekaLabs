using Serilog;
using Sidkenu.AccesoDatos.Constantes;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.Banco;
using Sidkenu.LogicaNegocio.Servicios.Interface.Core;
using Sidkenu.LogicaNegocio.Servicios.Interface.Seguridad;
using SidkenuWF.Formularios.Base;
using SidkenuWF.Formularios.Base.Constantes;
using SidkenuWF.Helpers;

namespace SidkenuWF.Formularios.Core.Varios
{
    public partial class MedioPagoCheque : FormularioComun
    {
        private readonly IBancoServicio _bancoServicio;

        public bool RealizoAlgunaOperacion { get; private set; }

        public decimal MontoPagar { get; private set; }
        public decimal Interes { get; private set; }
        public Guid BancoId { get; private set; }
        public string? NumeroCheque { get; private set; }
        public DateTime FechaVencimiento { get; private set; }

        public MedioPagoCheque(ISeguridadServicio seguridadServicio,
                               IConfiguracionServicio configuracionServicio,
                               ILogger logger,
                               IBancoServicio bancoServicio,
                               decimal montoPagar,
                               decimal interes)
                               : base(seguridadServicio, configuracionServicio, logger)
        {
            InitializeComponent();

            base.Titulo = "Cheque";
            base.Logo = FontAwesome.Sharp.IconChar.MoneyCheckDollar;
            base.TituloFormulario = FormularioConstantes.Titulo;

            _bancoServicio = bancoServicio;

            MontoPagar = montoPagar;

            Interes = interes;

            RealizoAlgunaOperacion = false;

            txtNroCheque.KeyPress += Validacion.NoInyeccion;
            txtNroCheque.KeyPress += Validacion.NoLetras;            
        }

        private void MedioPagoCheque_Load(object sender, EventArgs e)
        {            
            CargarDatos();
        }

        private void CargarDatos()
        {
            // Bancos

            var resultBanco = _bancoServicio.GetAll(Properties.Settings.Default.EmpresaId);

            if (resultBanco != null && resultBanco.State)
            {
                var datosBancos = (List<BancoDTO>)resultBanco.Data;

                PoblarComboBox(cmbBanco, datosBancos, "Descripcion", "Id");
            }

            txtNroCheque.Text = string.Empty;

            dtpFechaVencimiento.Value = DateTime.Now;
            dtpFechaVencimiento.MinDate = DateTime.Now;

            nudMontoPagar.Value = MontoPagar;

            nudInteresCheque.Value = Interes;

            nudTotal.Value = nudMontoPagar.Value + Porcentaje.Calcular(nudMontoPagar.Value, Interes);
        }
        private void BtnEjecutar_Click(object sender, EventArgs e)
        {
            if (nudMontoPagar.Value <= 0)
            {
                MessageBox.Show("El monto debe ser mayor a Cero", "Atención");
                return;
            }

            if (string.IsNullOrEmpty(txtNroCheque.Text))
            {
                MessageBox.Show("El Numero de Cheque es un dato Obligatorio", "Atención");
                return;
            }

            MontoPagar = nudMontoPagar.Value;
            BancoId = (Guid)cmbBanco.SelectedValue;
            NumeroCheque = txtNroCheque.Text;
            FechaVencimiento = dtpFechaVencimiento.Value;
            Interes = Porcentaje.Calcular(nudMontoPagar.Value, Interes);

            RealizoAlgunaOperacion = true;

            Close();
        }

        private void MedioPagoCheque_Activated(object sender, EventArgs e)
        {
            txtNroCheque.Focus();
        }

        private void NudMontoPagar_ValueChanged(object sender, EventArgs e)
        {
            nudTotal.Value = nudMontoPagar.Value + Porcentaje.Calcular(nudMontoPagar.Value, Interes);
        }
    }
}
