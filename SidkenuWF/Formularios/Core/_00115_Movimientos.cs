using FontAwesome.Sharp;
using Serilog;
using Sidkenu.AccesoDatos.CadenaConexion;
using Sidkenu.AccesoDatos.Constantes.Enum;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.Caja;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.Movimiento;
using Sidkenu.LogicaNegocio.Servicios.Interface.Core;
using Sidkenu.LogicaNegocio.Servicios.Interface.Seguridad;
using SidkenuWF.Formularios.Base;
using SidkenuWF.Formularios.Base.Constantes;
using SidkenuWF.Formularios.Core.Controles;

namespace SidkenuWF.Formularios.Core
{
    public partial class _00115_Movimientos : FormularioComun
    {
        private readonly ICajaServicio _cajaServicio;
        private readonly IMovimientoCajaServicio _movimientoCajaServicio;

        private Guid _cajaSeleccionadaId;
        private decimal _montoAperturaCajaSeleccionada;

        private List<CajaDetalleDTO> _cajaDetalles;

        public TipoMovimiento TipoMovimiento { get; set; }

        private bool MostrarDatos = false;

        public CajaDTO CajaSeleccionada { private get; set; }

        public _00115_Movimientos(ISeguridadServicio seguridadServicio,
                                  IConfiguracionServicio configuracionServicio,
                                  ILogger logger,
                                  ICajaServicio cajaServicio,
                                  IMovimientoCajaServicio movimientoCajaServicio)
                                  : base(seguridadServicio, configuracionServicio, logger)
        {
            InitializeComponent();

            MostrarDatos = false;
            _montoAperturaCajaSeleccionada = 0;

            _cajaServicio = cajaServicio;
            _movimientoCajaServicio = movimientoCajaServicio;

            base.TituloFormulario = Base.Constantes.FormularioConstantes.Titulo;
            base.Titulo = "Movimientos";
            base.Logo = IconChar.SackDollar;

            dtpFechaDesde.Value = DateTime.Now;
            dtpFechaHasta.Value = DateTime.Now;

            _cajaDetalles = new List<CajaDetalleDTO>();
        }

        private void _00115_Movimientos_Load(object sender, EventArgs e)
        {
            var result = _cajaServicio.GetUltimaCajaAbierta(Properties.Settings.Default.EmpresaId);

            if (result != null)
            {
                _cajaDetalles = (List<CajaDetalleDTO>)result.Data;

                if (_cajaDetalles.Any())
                {
                    dtpFechaDesde.Value = _cajaDetalles.Min(x => x.FechaApertura);
                }
            }

            Cargar();
        }

        private void Cargar()
        {
            flpContenedorCajas.Controls.Clear();

            var resultCajas = _cajaServicio.GetByFilter(new CajaFilterDTO
            {
                EmpresaId = Properties.Settings.Default.EmpresaId,
                CadenaBuscar = string.Empty,
                VerEliminados = false
            });

            if (resultCajas != null && resultCajas.State)
            {
                var _listaCajas = (List<CajaDTO>)resultCajas.Data;

                foreach (var caja in _listaCajas.OrderBy(x => x.Descripcion).ToList())
                {
                    var monto = caja.MontoApertura.HasValue
                        ? caja.MontoApertura.Value.ToString("C2")
                        : 0.ToString("C2");

                    var ctrolCajaNuevo = new CtrolCaja
                    {
                        CajaDTO = caja,
                        TieneCajaAbierta = caja.EstaAbierta,

                    };

                    ctrolCajaNuevo.btnAbrirCaja.Click += BtnAbrirCaja_Click;

                    ctrolCajaNuevo.btnCerrarCaja.Click += BtnCerrarCaja_Click;
                    
                    ctrolCajaNuevo.btnVerDetalle.Click += BtnVerDetalle_Click;
                    
                    ctrolCajaNuevo.btnTransferir.Click += BtnTransferirEntreCajas_Click;
                    
                    ctrolCajaNuevo.btnNuevoGasto.Click += BtnNuevoGasto_Click;

                    ctrolCajaNuevo.btnCajaExterna.Click += BtnCajaExterna_Click;

                    flpContenedorCajas.Controls.Add(ctrolCajaNuevo);
                }
            }
        }

        private void BtnCajaExterna_Click(object? sender, EventArgs e)
        {
            if (((IconButton)sender).Tag != null)
            {
                var caja = (CajaDTO)((IconButton)sender).Tag;

                var formularioCajaExterna = new _00158_CajaExterna(base._seguridadServicio,
                                                                   base._configuracionServicio,
                                                                   base._logger,
                                                                   Program.Container.GetInstance<IComprobanteServicio>(),
                                                                   Program.Container.GetInstance<IConexionServicio>(),
                                                                   Program.Container.GetInstance<IConfiguracionCoreServicio>(),
                                                                   caja);

                FormularioSeguridad.VerificarAcceso(formularioCajaExterna, base._seguridadServicio, base._logger, base._configuracionDTO);

                if (formularioCajaExterna.RealizoAlgunaOperacion)
                {
                    VerDetalleMovimientos(sender);
                }
            }
        }

        private void BtnVerDetalle_Click(object? sender, EventArgs e)
        {
            VerDetalleMovimientos(sender);
        }

        private void BtnNuevoGasto_Click(object? sender, EventArgs e)
        {
            VerDetalleMovimientos(sender);
        }

        private void BtnTransferirEntreCajas_Click(object? sender, EventArgs e)
        {
            VerDetalleMovimientos(sender);
        }

        private void VerDetalleMovimientos(object? sender)
        {
            MostrarDatos = true;

            if (((IconButton)sender).Tag != null)
            {
                var caja = (CajaDTO)((IconButton)sender).Tag;

                CajaSeleccionada = caja;

                _cajaSeleccionadaId = caja.Id;
                _montoAperturaCajaSeleccionada = caja.MontoApertura.HasValue ? caja.MontoApertura.Value : 0;

                lblCajaSeleccionada.Text = $"Caja Seleccionada => {caja.Descripcion}";

                dtpFechaDesde.Enabled = true;
                dtpFechaHasta.Enabled = true;
                btnBuscar.Enabled = true;

                dtpFechaDesde.Value = caja.FechaApertura.HasValue ? caja.FechaApertura.Value : DateTime.Now;

                var _montoDeAperturaDeCaja = caja.MontoApertura.HasValue ? caja.MontoApertura.Value : 0;

                CargarMovimientos(caja.CajaDetalleId, dtpFechaDesde.Value, dtpFechaHasta.Value, _montoDeAperturaDeCaja);
            }
        }

        private void CargarMovimientos(Guid? cajaDetalleId, DateTime fechaDesde, DateTime fechaHasta, decimal _montoDeAperturaDeCaja)
        {
            var movimientoResult = _movimientoCajaServicio.ObtenerMovimientos(cajaDetalleId, fechaDesde, fechaHasta);

            if (movimientoResult != null && movimientoResult.State)
            {
                var _movimientos = (List<MovimientoCajaDTO>)movimientoResult.Data;

                dgvGrilla.DataSource = _movimientos;

                FormatearGrilla();

                btnVerComprobante.Visible = _movimientos.Any();

                var montoTotal = (_movimientos.Sum(x => (x.Capital * (int)x.TipoMovimiento) + x.Interes) + _montoDeAperturaDeCaja);
                                
                txtTotal.Text = montoTotal.ToString("C2");
            }
            else
            {
                txtTotal.Text = 0.ToString("C2");

                btnVerComprobante.Visible = false;
            }
        }

        private void FormatearGrilla()
        {
            dgvGrilla.Columns["CajaDetalleId"].Visible = false;
            dgvGrilla.Columns["CajaDetalleId"].DisplayIndex = 0;

            dgvGrilla.Columns["ComprobanteId"].Visible = false;
            dgvGrilla.Columns["ComprobanteId"].DisplayIndex = 1;

            dgvGrilla.Columns["Fecha"].Visible = false;
            dgvGrilla.Columns["Fecha"].DisplayIndex = 2;

            dgvGrilla.Columns["TipoOperacion"].Visible = false;

            dgvGrilla.Columns["TipoOperacionStr"].Visible = true;
            dgvGrilla.Columns["TipoOperacionStr"].Width = 70;
            dgvGrilla.Columns["TipoOperacionStr"].HeaderText = "Operación";
            dgvGrilla.Columns["TipoOperacionStr"].DisplayIndex = 3;
            dgvGrilla.Columns["TipoOperacionStr"].ReadOnly = true;
            dgvGrilla.Columns["TipoOperacionStr"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvGrilla.Columns["FechaStr"].Visible = true;
            dgvGrilla.Columns["FechaStr"].Width = 70;
            dgvGrilla.Columns["FechaStr"].HeaderText = "Fecha";
            dgvGrilla.Columns["FechaStr"].DisplayIndex = 4;
            dgvGrilla.Columns["FechaStr"].ReadOnly = true;
            dgvGrilla.Columns["FechaStr"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvGrilla.Columns["HoraStr"].Visible = true;
            dgvGrilla.Columns["HoraStr"].Width = 70;
            dgvGrilla.Columns["HoraStr"].HeaderText = "Hora";
            dgvGrilla.Columns["HoraStr"].DisplayIndex = 5;
            dgvGrilla.Columns["HoraStr"].ReadOnly = true;
            dgvGrilla.Columns["HoraStr"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvGrilla.Columns["Descripcion"].Visible = true;
            dgvGrilla.Columns["Descripcion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvGrilla.Columns["Descripcion"].HeaderText = "Descripcion";
            dgvGrilla.Columns["Descripcion"].DisplayIndex = 6;
            dgvGrilla.Columns["Descripcion"].ReadOnly = true;

            dgvGrilla.Columns["TipoMovimiento"].Visible = true;
            dgvGrilla.Columns["TipoMovimiento"].Width = 75;
            dgvGrilla.Columns["TipoMovimiento"].HeaderText = "Movimiento";
            dgvGrilla.Columns["TipoMovimiento"].DisplayIndex = 7;
            dgvGrilla.Columns["TipoMovimiento"].ReadOnly = true;
            dgvGrilla.Columns["TipoMovimiento"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvGrilla.Columns["Capital"].Visible = true;
            dgvGrilla.Columns["Capital"].Width = 120;
            dgvGrilla.Columns["Capital"].HeaderText = "Monto";
            dgvGrilla.Columns["Capital"].DisplayIndex = 8;
            dgvGrilla.Columns["Capital"].ReadOnly = true;
            dgvGrilla.Columns["Capital"].DefaultCellStyle.Format = "C";
            dgvGrilla.Columns["Capital"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgvGrilla.Columns["Interes"].Visible = true;
            dgvGrilla.Columns["Interes"].Width = 120;
            dgvGrilla.Columns["Interes"].HeaderText = "Interes";
            dgvGrilla.Columns["Interes"].DisplayIndex = 9;
            dgvGrilla.Columns["Interes"].ReadOnly = true;
            dgvGrilla.Columns["Interes"].DefaultCellStyle.Format = "C";
            dgvGrilla.Columns["Interes"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgvGrilla.Columns["EstaEliminado"].Visible = false;
            dgvGrilla.Columns["EstaEliminado"].DisplayIndex = 10;

            dgvGrilla.Columns["Id"].Visible = false;
            dgvGrilla.Columns["Id"].DisplayIndex = 11;

            dgvGrilla.Columns["EstaSeleccionado"].Visible = false;
            dgvGrilla.Columns["EstaSeleccionado"].DisplayIndex = 12;
        }

        private void BtnAbrirCaja_Click(object? sender, EventArgs e)
        {
            Cargar();
        }

        private void BtnCerrarCaja_Click(object? sender, EventArgs e)
        {
            Cargar();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            CargarMovimientos(CajaSeleccionada.CajaDetalleId, dtpFechaDesde.Value, dtpFechaHasta.Value, _montoAperturaCajaSeleccionada);
        }

        private void Control_ValueChanged(object sender, EventArgs e)
        {
            if (!MostrarDatos)
                return;

            CargarMovimientos(CajaSeleccionada.CajaDetalleId, dtpFechaDesde.Value, dtpFechaHasta.Value, _montoAperturaCajaSeleccionada);
        }
    }
}
