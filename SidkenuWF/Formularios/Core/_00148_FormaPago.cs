using Serilog;
using Sidkenu.AccesoDatos.Constantes.Enum;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.Caja;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.Comprobante;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.ConfiguracionCore;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.MedioPago;
using Sidkenu.LogicaNegocio.Servicios.Interface.Core;
using Sidkenu.LogicaNegocio.Servicios.Interface.Seguridad;
using SidkenuWF.Formularios.Base;
using SidkenuWF.Formularios.Base.Constantes;
using SidkenuWF.Formularios.Core.Model;
using SidkenuWF.Formularios.Core.Model.MediosDePago;
using SidkenuWF.Formularios.Core.Varios;

namespace SidkenuWF.Formularios.Core
{
    public partial class _00148_FormaPago : FormularioComun
    {
        private readonly IConfiguracionCoreServicio _configuracionCoreServicio;
        private readonly IComprobanteServicio _comprobanteServicio;
        private readonly ICajaServicio _cajaServicio;

        private MyListViewModel<MedioPagoVM> _mediosPagos;

        private MedioPagoVM? _medioPagoSeleccionado;

        private ComprobanteVentaDTO _comprobante;

        private ConfiguracionCoreDTO _configuracionCore;

        public bool RealizoAlgunaOperacion { get; set; }


        public _00148_FormaPago()
        {
            InitializeComponent();
        }

        public _00148_FormaPago(ISeguridadServicio seguridadServicio,
                                IConfiguracionServicio configuracionServicio,
                                ILogger logger,
                                ITarjetaServicio tarjetaServicio,
                                IPlanTarjetaServicio planTarjetaServicio,
                                IConfiguracionCoreServicio configuracionCoreServicio,
                                IComprobanteServicio comprobanteServicio,
                                ICajaServicio cajaServicio,
                                ComprobanteVentaDTO comprobante)
                                : base(seguridadServicio, configuracionServicio, logger)
        {
            InitializeComponent();

            base.Titulo = "Medios de Pago";
            base.TituloFormulario = FormularioConstantes.Titulo;
            base.Logo = FontAwesome.Sharp.IconChar.CashRegister;

            _configuracionCoreServicio = configuracionCoreServicio;
            _comprobanteServicio = comprobanteServicio;
            _cajaServicio = cajaServicio;

            _comprobante = comprobante;

            _mediosPagos = new MyListViewModel<MedioPagoVM>();

            _mediosPagos.ItemAdded += MediosPagos_ItemAdded;
            _mediosPagos.ItemRemoved += MediosPagos_ItemRemoved;

            _medioPagoSeleccionado = null;

            RealizoAlgunaOperacion = false;
        }

        private void MediosPagos_ItemRemoved(object? sender, Model.ItemRemovedEventArgs<MedioPagoVM> e)
        {
            ActualizarDatos();
        }

        private void MediosPagos_ItemAdded(object? sender, Model.ItemAddedEventArgs<MedioPagoVM> e)
        {
            ActualizarDatos();
        }

        private void ActualizarDatos()
        {
            dgvGrilla.DataSource = _mediosPagos.ToList();

            txtTotalCapital.Text = _mediosPagos.Sum(x => x.Capital).ToString("C2");
            txtTotalInteres.Text = _mediosPagos.Sum(x => x.Interes).ToString("C2");
            txtTotal.Text = _mediosPagos.Sum(x => x.Capital + x.Interes).ToString("C2");

            txtTotalAPagar.Text = _comprobante.Total.ToString("C2");
        }

        private void FormatearGrilla()
        {
            dgvGrilla.Columns["TipoMedioDePagoStr"].Visible = true;
            dgvGrilla.Columns["TipoMedioDePagoStr"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvGrilla.Columns["TipoMedioDePagoStr"].HeaderText = "Tipo";
            dgvGrilla.Columns["TipoMedioDePagoStr"].DisplayIndex = 0;
            dgvGrilla.Columns["TipoMedioDePagoStr"].ReadOnly = true;

            dgvGrilla.Columns["Capital"].Visible = true;
            dgvGrilla.Columns["Capital"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvGrilla.Columns["Capital"].HeaderText = "Capital";
            dgvGrilla.Columns["Capital"].DisplayIndex = 1;
            dgvGrilla.Columns["Capital"].ReadOnly = true;
            dgvGrilla.Columns["Capital"].DefaultCellStyle.Format = "C2";

            dgvGrilla.Columns["Interes"].Visible = true;
            dgvGrilla.Columns["Interes"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvGrilla.Columns["Interes"].HeaderText = "Interes";
            dgvGrilla.Columns["Interes"].DisplayIndex = 2;
            dgvGrilla.Columns["Interes"].ReadOnly = true;
            dgvGrilla.Columns["Interes"].DefaultCellStyle.Format = "C2";

            dgvGrilla.Columns["EstaEliminado"].Visible = false;
            dgvGrilla.Columns["Id"].Visible = false;
            dgvGrilla.Columns["Tipo"].Visible = false;
        }

        private void _00148_FormaPago_Shown(object sender, EventArgs e)
        {
            ActualizarDatos();
        }

        private void _00148_FormaPago_Load(object sender, EventArgs e)
        {
            var configResult = _configuracionCoreServicio.Get(Properties.Settings.Default.EmpresaId);

            if (configResult != null && configResult.Data != null)
            {
                _configuracionCore = (ConfiguracionCoreDTO)configResult.Data;
            }
            else
            {
                _configuracionCore = null;
            }

            var _cajaResult = _cajaServicio.GetById(Properties.Settings.Default.CajaId);

            if (_cajaResult != null) 
            {
                var _caja = (CajaDTO)_cajaResult.Data;

                btnEfectivo.Visible = _caja.AceptaMedioPagoEfectivo;
                btnCheque.Visible = _caja.AceptaMedioPagoCheque;
                btnTarjeta.Visible = _caja.AceptaMedioPagoTarjeta;
                btnTransferencia.Visible = _caja.AceptaMedioPagoTransferencia;
                btnCuentaCorriente.Visible = _caja.AceptaMedioPagoCtaCte;
            }

            CargarDatos();
        }

        private void CargarDatos()
        {
            ActualizarDatos();

            FormatearGrilla();
        }

        private decimal ObtenerRestoParaPagar()
        {
            var montoTotalInicial = _comprobante.Total;
            var montoAcumulado = _mediosPagos.Sum(x => x.Capital);
            var interesAcumulado = _mediosPagos.Sum(x => x.Interes);

            if (_mediosPagos.Count() <= 0)
            {
                return montoTotalInicial;
            }
            else
            {
                return montoTotalInicial - montoAcumulado;
            }
        }

        private void BtnEfectivo_Click(object sender, EventArgs e)
        {
            if (VerificarSiYaCompletoMonto())
            {
                return;
            }

            var fMedioPagoEfectivo = new MedioPagoEfectivo(ObtenerRestoParaPagar());

            fMedioPagoEfectivo.ShowDialog();

            if (fMedioPagoEfectivo.RealizoAlgunaOperacion)
            {
                _mediosPagos.Add(new MedioPagoEfectivoVM
                {
                    Capital = fMedioPagoEfectivo.MontoPagar,
                    Interes = 0,
                    EstaEliminado = false,
                    Tipo = TipoMedioDePago.Efectivo
                });
            }
        }

        private bool VerificarSiYaCompletoMonto()
        {
            var montoTotalInicial = _comprobante.Total;
            var montoAcumulado = _mediosPagos.Sum(x => x.Capital);

            if (montoTotalInicial > montoAcumulado)
            {
                return false;
            }
            else
            {
                MessageBox.Show("El Capital a pagar NO puede ser mayor al Monto a pagar", "Atención");
                return true;
            }
        }

        private void BtnTarjeta_Click(object sender, EventArgs e)
        {
            if (VerificarSiYaCompletoMonto())
            {
                return;
            }

            var fMedioPagoTarjeta = new MedioPagoTarjeta(Program.Container.GetInstance<ITarjetaServicio>(),
                                                         Program.Container.GetInstance<IPlanTarjetaServicio>(),
                                                         ObtenerRestoParaPagar());

            fMedioPagoTarjeta.ShowDialog();

            if (fMedioPagoTarjeta.RealizoAlgunaOperacion)
            {
                _mediosPagos.Add(new MedioPagoTarjetaVM
                {
                    Capital = fMedioPagoTarjeta.MontoPagar,
                    Interes = fMedioPagoTarjeta.InteresPagar,
                    EstaEliminado = false,
                    Tipo = TipoMedioDePago.Tarjeta,
                    NumeroCupon = fMedioPagoTarjeta.NumeroCupon,
                    PlanTarjetaId = fMedioPagoTarjeta.PlanTarjetaId
                });
            }
        }

        private void BtnTransferencia_Click(object sender, EventArgs e)
        {
            if (VerificarSiYaCompletoMonto())
            {
                return;
            }

            var _interesTransferencia = _configuracionCore.ActivarInteresPorTransferencia
                                                          ? _configuracionCore.InteresPorTransferencia.Value
                                                          : 0m;

            var fMedioPagoTransferencia = new MedioPagoTransferencia(base._seguridadServicio,
                                                                     base._configuracionServicio,
                                                                     base._logger,
                                                                     Program.Container.GetInstance<IBancoServicio>(),
                                                                     ObtenerRestoParaPagar(),
                                                                     _interesTransferencia);

            fMedioPagoTransferencia.ShowDialog();

            if (fMedioPagoTransferencia.RealizoAlgunaOperacion)
            {
                _mediosPagos.Add(new MedioPagoTransferenciaVM
                {
                    Capital = fMedioPagoTransferencia.MontoPagar,
                    EstaEliminado = false,
                    Tipo = TipoMedioDePago.Transferencia,
                    BancoId = fMedioPagoTransferencia.BancoId,
                    NumeroTransferencia = fMedioPagoTransferencia.NumeroTransferencia,
                    Interes = fMedioPagoTransferencia.Interes,
                    NombreTitular = fMedioPagoTransferencia.Titular,
                });
            }
        }

        private void BtnCuentaCorriente_Click(object sender, EventArgs e)
        {
            if (VerificarSiYaCompletoMonto())
            {
                return;
            }

            var fMedioPagoCuentaCorriente = _comprobante.ClienteEsConsumidorFinal ? new MedioPagoCuentaCorriente(base._seguridadServicio,
                                                                                                                 base._configuracionServicio,
                                                                                                                 base._logger,
                                                                                                                 Program.Container.GetInstance<IClienteServicio>(),
                                                                                                                 Program.Container.GetInstance<ICuentaCorrienteClienteServicio>(),
                                                                                                                 ObtenerRestoParaPagar())
                                                                                  : new MedioPagoCuentaCorriente(base._seguridadServicio,
                                                                                                                 base._configuracionServicio,
                                                                                                                 base._logger,
                                                                                                                 Program.Container.GetInstance<IClienteServicio>(),
                                                                                                                 Program.Container.GetInstance<ICuentaCorrienteClienteServicio>(),
                                                                                                                 ObtenerRestoParaPagar(),
                                                                                                                 _comprobante.Cliente);

            fMedioPagoCuentaCorriente.ShowDialog();

            if (fMedioPagoCuentaCorriente.RealizoAlgunaOperacion)
            {
                _mediosPagos.Add(new MedioPagoCtaCteVM
                {
                    Capital = fMedioPagoCuentaCorriente.MontoPagar,
                    EstaEliminado = false,
                    Tipo = TipoMedioDePago.CuentaCorriente,
                    Interes = 0,
                    Cliente = fMedioPagoCuentaCorriente.Cliente
                });
            }
        }

        private void DgvGrilla_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvGrilla.RowCount > 0)
            {
                _medioPagoSeleccionado = (MedioPagoVM)dgvGrilla.Rows[e.RowIndex].DataBoundItem;
            }
            else
            {
                _medioPagoSeleccionado = null;
            }
        }

        private void DgvGrilla_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            btnEliminarItem.Visible = dgvGrilla.Rows.Count > 0;
        }

        private void DgvGrilla_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            btnEliminarItem.Visible = dgvGrilla.Rows.Count > 0;
        }

        private void BtnEliminarItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Está seguro de eliminar el medio de pago", "Atención",
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _mediosPagos.Remove(_medioPagoSeleccionado);
            }
        }

        private void _00148_FormaPago_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.F5:
                    if (btnEfectivo.Visible)
                        TeclaF5_Efectivo();
                    break;
                case Keys.F6:
                    if (btnTarjeta.Visible)
                        TeclaF6_Tarjeta();
                    break;
                case Keys.F7:
                    if (btnTransferencia.Visible)
                        TeclaF7_Transferencia();
                    break;
                case Keys.F8:
                    if (btnCuentaCorriente.Visible)
                        TeclaF8_CuentaCorriente();
                    break;
                case Keys.F9:
                    if (btnCheque.Visible)
                        TeclaF9_Cheque();
                    break;
            }
        }

        private void TeclaF9_Cheque()
        {
            btnCheque.PerformClick();
        }

        private void TeclaF8_CuentaCorriente()
        {
            btnCuentaCorriente.PerformClick();
        }

        private void TeclaF7_Transferencia()
        {
            btnTransferencia.PerformClick();
        }

        private void TeclaF6_Tarjeta()
        {
            btnTarjeta.PerformClick();
        }

        private void TeclaF5_Efectivo()
        {
            btnEfectivo.PerformClick();
        }

        private void BtnCheque_Click(object sender, EventArgs e)
        {
            if (VerificarSiYaCompletoMonto())
            {
                return;
            }

            var _interes = _configuracionCore.ActivarInteresPorCheque
                                             ? _configuracionCore.InteresPorCheque.Value
                                             : 0m;

            var fMedioPagoCheque = new MedioPagoCheque(base._seguridadServicio,
                                                       base._configuracionServicio,
                                                       base._logger,
                                                       Program.Container.GetInstance<IBancoServicio>(),
                                                       ObtenerRestoParaPagar(),
                                                       _interes);

            fMedioPagoCheque.ShowDialog();

            if (fMedioPagoCheque.RealizoAlgunaOperacion)
            {
                _mediosPagos.Add(new MedioPagoChequeVM
                {
                    Capital = fMedioPagoCheque.MontoPagar,
                    EstaEliminado = false,
                    Tipo = TipoMedioDePago.Cheque,
                    BancoId = fMedioPagoCheque.BancoId,
                    FechaVencimiento = fMedioPagoCheque.FechaVencimiento,
                    NumeroCheque = fMedioPagoCheque.NumeroCheque,
                    Interes = fMedioPagoCheque.Interes
                });
            }
        }

        private void BtnFacturar_Click(object sender, EventArgs e)
        {
            try
            {
                if (_mediosPagos.Count <= 0)
                {
                    MessageBox.Show("Por favor seleccione un Medio de Pago", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                List<MedioPagoDTO> _mediosDePagos = AsignarMediosDePago(_mediosPagos);

                _comprobante.MedioPagos = _mediosDePagos;
                _comprobante.EmpresaId = Properties.Settings.Default.EmpresaId;
                _comprobante.EstaPagado = true;

                var resultComprobante = _comprobanteServicio.AddOrUpdate(_comprobante, Properties.Settings.Default.UserLogin);

                MessageBox.Show(resultComprobante.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);

                RealizoAlgunaOperacion = true;

                this.Close();
            }
            catch (Exception ex)
            {
                if (base._configuracionDTO != null && base._configuracionDTO != null && base._configuracionDTO.LogError)
                {
                    _logger.Error(ex, $"Error al Efectuar la Factura. User: {Properties.Settings.Default.PersonaLogin}. Datos: {_comprobante}");
                }

                this.Close();
            }
        }

        private List<MedioPagoDTO> AsignarMediosDePago(MyListViewModel<MedioPagoVM> mediosPagos)
        {
            var _listaMediosPagos = new List<MedioPagoDTO>();

            foreach (var medioPago in mediosPagos)
            {
                if (medioPago is MedioPagoEfectivoVM)
                {
                    var _mpEfectivo = (MedioPagoEfectivoVM)medioPago;

                    var nuevoMedioPagoDto = new MedioPagoEfectivoDTO
                    {
                        Capital = _mpEfectivo.Capital,
                        EstaEliminado = false,
                        EstaSeleccionado = false,
                        Id = _mpEfectivo.Id,
                        Interes = _mpEfectivo.Interes,
                        Tipo = _mpEfectivo.Tipo,
                    };

                    _listaMediosPagos.Add(nuevoMedioPagoDto);

                    continue;
                }

                if (medioPago is MedioPagoChequeVM)
                {
                    var _mpCheque = (MedioPagoChequeVM)medioPago;

                    var nuevoMedioPagoDto = new MedioPagoChequeDTO
                    {
                        Capital = _mpCheque.Capital,
                        EstaEliminado = false,
                        EstaSeleccionado = false,
                        Id = _mpCheque.Id,
                        Interes = _mpCheque.Interes,
                        Tipo = _mpCheque.Tipo,
                        BancoId = _mpCheque.BancoId,
                        FechaVencimiento = _mpCheque.FechaVencimiento,
                        NumeroCheque = _mpCheque.NumeroCheque,
                    };

                    _listaMediosPagos.Add(nuevoMedioPagoDto);

                    continue;
                }

                if (medioPago is MedioPagoCtaCteVM)
                {
                    var _mpCtaCte = (MedioPagoCtaCteVM)medioPago;

                    var nuevoMedioPagoDto = new MedioPagoCtaCteDTO
                    {
                        Capital = _mpCtaCte.Capital,
                        EstaEliminado = false,
                        EstaSeleccionado = false,
                        Id = _mpCtaCte.Id,
                        Interes = _mpCtaCte.Interes,
                        Tipo = _mpCtaCte.Tipo,
                        Cliente = _mpCtaCte.Cliente,
                    };

                    _listaMediosPagos.Add(nuevoMedioPagoDto);

                    continue;
                }

                if (medioPago is MedioPagoTarjetaVM)
                {
                    var _mpTarjeta = (MedioPagoTarjetaVM)medioPago;

                    var nuevoMedioPagoDto = new MedioPagoTarjetaDTO
                    {
                        Capital = _mpTarjeta.Capital,
                        EstaEliminado = false,
                        EstaSeleccionado = false,
                        Id = _mpTarjeta.Id,
                        Interes = _mpTarjeta.Interes,
                        Tipo = _mpTarjeta.Tipo,
                        NumeroCupon = _mpTarjeta.NumeroCupon,
                        PlanTarjetaId = _mpTarjeta.PlanTarjetaId,
                    };

                    _listaMediosPagos.Add(nuevoMedioPagoDto);

                    continue;
                }

                if (medioPago is MedioPagoTransferenciaVM)
                {
                    var _mpTransferencia = (MedioPagoTransferenciaVM)medioPago;

                    var nuevoMedioPagoDto = new MedioPagoTransferenciaDTO
                    {
                        Capital = _mpTransferencia.Capital,
                        EstaEliminado = false,
                        EstaSeleccionado = false,
                        Id = _mpTransferencia.Id,
                        Interes = _mpTransferencia.Interes,
                        Tipo = _mpTransferencia.Tipo,
                        BancoId = _mpTransferencia.BancoId,
                        NombreTitular = _mpTransferencia.NombreTitular,
                        NumeroTransferencia = _mpTransferencia.NumeroTransferencia,
                    };

                    _listaMediosPagos.Add(nuevoMedioPagoDto);

                    continue;
                }
            }

            return _listaMediosPagos;
        }
    }
}
