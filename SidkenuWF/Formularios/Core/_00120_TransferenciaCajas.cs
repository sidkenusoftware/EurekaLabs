using FontAwesome.Sharp;
using Sidkenu.AccesoDatos.Constantes.Enum;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.Caja;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Seguridad.Empresa;
using Sidkenu.LogicaNegocio.Servicios.Interface.Core;
using Sidkenu.LogicaNegocio.Servicios.Interface.Seguridad;

namespace SidkenuWF.Formularios.Core
{
    public partial class _00120_TransferenciaCajas : Form
    {
        private Guid _id;
        private ICajaServicio _cajaServicio;
        private IEmpresaServicio _empresaServicio;
        private decimal _montoDisponibleEnCaja;
        public bool RealizoAlgunaOperacion { get; internal set; }

        public _00120_TransferenciaCajas(Guid id, string cajaSeleccionada, ICajaServicio cajaServicio, IEmpresaServicio empresaServicio)
        {
            InitializeComponent();

            this.lblTitulo.Text = $"Transferir ({cajaSeleccionada})";
            this.Text = "Transferir";
            this.imgLogo.IconChar = IconChar.CashRegister;

            this._id = id;

            this._cajaServicio = cajaServicio;
            this._empresaServicio = empresaServicio;

            this.lblMensaje.Text = string.Empty;

            _montoDisponibleEnCaja = 0m;
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            RealizoAlgunaOperacion = false;

            this.Close();
        }

        private void BtnTransferir_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.cmbCaja.DataSource == null)
                {
                    MessageBox.Show("No hay cajas habilitadas para realizar la transferencia"
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

                if (nudMontoTranferir.Value > _montoDisponibleEnCaja)
                {
                    MessageBox.Show("El monto debe ser menor o igual al disponible en caja"
                        , "Atención"
                        , MessageBoxButtons.OK
                        , MessageBoxIcon.Information);
                    return;
                }

                var nuevaTransferencia = new CajaTransferenciaDTO();

                nuevaTransferencia.CajaOrigenId = _id;

                var cajaDestino = (CajaDTO)cmbCaja.SelectedItem;

                if (cajaDestino == null)
                {
                    MessageBox.Show("Ocurrio un error al obtener la caja destino", "Atención");
                }

                nuevaTransferencia.CajaDestinoId = cajaDestino.Id;

                nuevaTransferencia.Monto = nudMontoTranferir.Value;
                nuevaTransferencia.PersonaId = Properties.Settings.Default.PersonaLoginId;
                nuevaTransferencia.EmpresaId = Properties.Settings.Default.EmpresaId;

                var result = _cajaServicio.Transferir(nuevaTransferencia, Properties.Settings.Default.UserLogin);

                if (result != null && result.State)
                {
                    MessageBox.Show(result.Message, "Atención");

                    RealizoAlgunaOperacion = true;
                    this.Close();
                }                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void _00120_Transferir_Load(object sender, EventArgs e)
        {
            nudMontoTranferir.Value = 0m;

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

                    var _caja = cajas.FirstOrDefault(x => x.Id != cajaId);

                    _montoDisponibleEnCaja = ObtenerDisponibilidadEnCaja(cajas.FirstOrDefault(x => x.Id == cajaId));

                    lblMensajeMontoDisponible.Text = $"El monto disponible en {cajas.FirstOrDefault(x => x.Id == cajaId).Descripcion} es de {_montoDisponibleEnCaja.ToString("C")}";                  
                }
                else
                {
                    lblMensaje.Text = "No hay cajas ABIERTAS para realizar Transferencias";
                    nudMontoTranferir.Enabled = false;
                    btnTransferir.Enabled = false;
                }
            }
        }

        private decimal ObtenerDisponibilidadEnCaja(CajaDTO? caja)
        {
            var _montoDisponible = 0m;

            if (caja != null)
            {
                var _cajaDetalle = _cajaServicio.GetDetalle(caja.CajaDetalleId.Value);

                _montoDisponible = caja.MontoApertura.Value;

                if (_cajaDetalle != null)
                {
                    var _detalle = (CajaDetalleDTO)_cajaDetalle.Data;

                    if (_detalle != null)
                    {
                        _montoDisponible += _detalle.Movimientos.Where(x => x.TipoOperacion == TipoOperacionMovimiento.Efectivo
                                                                            || x.TipoOperacion == TipoOperacionMovimiento.Gastos
                                                                            || x.TipoOperacion == TipoOperacionMovimiento.TransferenciaCaja)
                                                     .Sum(x => x.Capital * (int)x.TipoMovimiento);
                    }
                }
            }

            return _montoDisponible;
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
    }
}


