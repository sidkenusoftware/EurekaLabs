using FontAwesome.Sharp;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.Caja;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Seguridad.Empresa;
using Sidkenu.LogicaNegocio.Servicios.Interface.Core;
using Sidkenu.LogicaNegocio.Servicios.Interface.Seguridad;

namespace SidkenuWF.Formularios.Core
{
    public partial class _00117_CerrarCaja : Form
    {
        private Guid _id;
        private ICajaServicio _cajaServicio;
        private IEmpresaServicio _empresaServicio;

        public bool RealizoAlgunaOperacion { get; internal set; }

        public _00117_CerrarCaja(Guid id, ICajaServicio cajaServicio, IEmpresaServicio empresaServicio)
        {
            InitializeComponent();

            this.lblTitulo.Text = "Cerrar de Caja";
            this.Text = "Cerrar de Caja";
            this.imgLogo.IconChar = IconChar.CashRegister;

            this._id = id;

            this._cajaServicio = cajaServicio;
            this._empresaServicio = empresaServicio;

            this.txtDiferencia.BackColor = Color.Gray;

            this.lblMensaje.Text = string.Empty;
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            RealizoAlgunaOperacion = false;

            this.Close();
        }

        private void BtnCerrarCaja_Click(object sender, EventArgs e)
        {
            try
            {
                if (chkTransferirDinero.Checked)
                {
                    if (this.cmbCaja.DataSource == null)
                    {
                        MessageBox.Show("No hay cajas habilitadas para realizar la transferencia"
                            , "Atención"
                            , MessageBoxButtons.OK
                            , MessageBoxIcon.Information);
                        return;
                    }

                    if (nudMontoCierre.Value <= 0)
                    {
                        MessageBox.Show("Debe declarar cuanto fue la recaudacion antes de realziar la transferencia."
                            , "Atención"
                            , MessageBoxButtons.OK
                            , MessageBoxIcon.Information);
                        return;
                    }

                    if (nudMontoTranferir.Value <= 0)
                    {
                        MessageBox.Show("El monto a transferir debe ser mayor a CERO."
                            , "Atención"
                            , MessageBoxButtons.OK
                            , MessageBoxIcon.Information);
                        return;
                    }
                }

                var _cerrarCaja = new CajaCerrarDTO
                {
                    Id = _id,
                    MontoCierre = nudMontoCierre.Value,
                    PersonaCierreId = Properties.Settings.Default.PersonaLoginId,
                    MontoProximoTurno = nudMontoProximoTurno.Value,
                    MontoSistema = nudSistema.Value,
                    Diferencia = decimal.Parse(txtDiferencia.Text),
                    CajaDetalleId = (Guid)cmbCaja.SelectedValue,
                    EmpresaId = (Guid)cmbEmpresa.SelectedValue,
                    MontoTransferir = nudMontoTranferir.Value,
                    EstaPorTransferirDinero = chkTransferirDinero.Checked,
                };

                var result = _cajaServicio.CerrarCaja(_cerrarCaja, Properties.Settings.Default.UserLogin);

                RealizoAlgunaOperacion = true;

                if (result != null && result.State)
                {
                    MessageBox.Show(result.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void _00117_CerrarCaja_Load(object sender, EventArgs e)
        {
            nudMontoCierre.Value = 0m;
            nudMontoProximoTurno.Value = 0m;
            nudMontoTranferir.Value = 0m;
            nudSistema.Value = ObtenerMontoSistema(_id);
            txtDiferencia.Text = 0.ToString("N2");

            var result = _empresaServicio.GetAll();

            if (result != null)
            {
                var empresas = (List<EmpresaDTO>)result.Data;

                cmbEmpresa.DataSource = empresas;
                cmbEmpresa.DisplayMember = "RazonSocial";
                cmbEmpresa.ValueMember = "Id";

                if (empresas.Any())
                {

                    var primeraEmpresa = empresas.FirstOrDefault();

                    CargarCajas(primeraEmpresa.Id, _id);
                }
            }
        }

        private decimal ObtenerMontoSistema(Guid cajaId)
        {
            return 100m;
        }

        private void CargarCajas(Guid empresaId, Guid cajaId)
        {
            lblMensaje.Text = string.Empty;

            var resultCajas = _cajaServicio.GetCajasParaHacerTransferencia(empresaId);

            if (resultCajas != null)
            {
                var cajas = (List<CajaDTO>)resultCajas.Data;

                if (cajas.Any(x => x.Id != cajaId))
                {
                    cmbCaja.DataSource = cajas.Where(x => x.Id != cajaId).ToList();
                    cmbCaja.DisplayMember = "Descripcion";
                    cmbCaja.ValueMember = "CajaDetalleId";
                }
                else
                {
                    lblMensaje.Text = "No hay cajas ABIERTAS para realizar Transferencias";
                }
            }
        }

        private void ChkTransferirDinero_CheckedChanged(object sender, EventArgs e)
        {
            this.cmbEmpresa.Enabled = chkTransferirDinero.Checked;
            this.cmbCaja.Enabled = chkTransferirDinero.Checked;
            this.nudMontoTranferir.Enabled = chkTransferirDinero.Checked;
        }

        private void CmbEmpresa_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CargarCajas((Guid)cmbEmpresa.SelectedValue, _id);
        }

        private void NudMontoProximoTurno_ValueChanged(object sender, EventArgs e)
        {
            nudMontoCierre.Value -= nudMontoProximoTurno.Value;
        }

        private void NudMontoCierre_ValueChanged(object sender, EventArgs e)
        {
            nudMontoProximoTurno.Maximum = nudMontoCierre.Value;
            nudMontoTranferir.Maximum = nudMontoCierre.Value;

            txtDiferencia.Text = ((nudMontoCierre.Value + nudMontoProximoTurno.Value) - nudSistema.Value).ToString("N2");

            txtDiferencia.BackColor = decimal.Parse(txtDiferencia.Text) >= 0 ? Color.Green : Color.Red;

        }
    }
}
