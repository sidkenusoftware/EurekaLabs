using Serilog;
using Sidkenu.AccesoDatos.CadenaConexion;
using Sidkenu.AccesoDatos.Entidades.Core;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.Caja;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.Comprobante;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.ConfiguracionCore;
using Sidkenu.LogicaNegocio.Servicios.Interface.Core;
using Sidkenu.LogicaNegocio.Servicios.Interface.Seguridad;
using SidkenuWF.Formularios.Base;
using SidkenuWF.Formularios.Base.Constantes;
using SidkenuWF.Formularios.Core.Model.Caja;
using TableDependency.SqlClient;
using TableDependency.SqlClient.Base.EventArgs;

namespace SidkenuWF.Formularios.Core
{
    public partial class _00158_CajaExterna : FormularioComun
    {
        private readonly IComprobanteServicio _comprobanteServicio;
        private readonly IConexionServicio _conexionServicio;
        private readonly IConfiguracionCoreServicio _configuracionCoreServicio;
        private CajaDTO _caja;
        private ConfiguracionCoreDTO _configuracionCore;

        public bool RealizoAlgunaOperacion { get; set; }

        private SqlTableDependency<Comprobante> _comprobanteDependency;
        private ComprobanteVentaDTO _comprobanteSeleccionado;

        public _00158_CajaExterna(ISeguridadServicio seguridadServicio,
                                  IConfiguracionServicio configuracionServicio,
                                  ILogger logger,
                                  IComprobanteServicio comprobanteServicio,
                                  IConexionServicio conexionServicio,
                                  IConfiguracionCoreServicio configuracionCoreServicio,
                                  CajaDTO caja)
                                  : base(seguridadServicio, configuracionServicio, logger)
        {
            InitializeComponent();

            base.Titulo = caja.Descripcion;
            base.TituloFormulario = FormularioConstantes.Titulo;
            base.Logo = FontAwesome.Sharp.IconChar.CashRegister;

            _comprobanteServicio = comprobanteServicio;
            _conexionServicio = conexionServicio;
            _caja = caja;

            _comprobanteSeleccionado = null;
            _configuracionCoreServicio = configuracionCoreServicio;
        }

        private void Start_ordenFabricacion_table_dependency()
        {
            _comprobanteDependency = new SqlTableDependency<Comprobante>(_conexionServicio.ObtenerCadenaConexion(MotoBaseDatos.Obtener), "Comprobantes");
            _comprobanteDependency.OnChanged += ComprobanteDependency_OnChanged;
            _comprobanteDependency.Start();
        }

        private void Stop_ordenFabricacion_table_dependency()
        {
            if (_comprobanteDependency != null)
            {
                _comprobanteDependency.OnChanged -= ComprobanteDependency_OnChanged;
                _comprobanteDependency.Stop();
            }
        }

        private void ComprobanteDependency_OnChanged(object sender, RecordChangedEventArgs<Comprobante> e)
        {
            if (e.ChangeType == TableDependency.SqlClient.Base.Enums.ChangeType.Insert)
            {
                RefreshComprobantes();
            }

            if (e.ChangeType == TableDependency.SqlClient.Base.Enums.ChangeType.Update)
            {
                RefreshComprobantes();
            }
        }

        private void RefreshComprobantes()
        {
            var result = _comprobanteServicio.GetComprobantesPendientesCobroVentaMostrador(_caja.Id,
                                                                                           Properties.Settings.Default.EmpresaId);

            ThreadSafe(() =>
            {
                if (result != null && result.Data != null)
                {
                    dgvGrillaComprobante.DataSource = (List<ComprobanteVentaDTO>)result.Data;

                    FormatearGrillaComprobante(dgvGrillaComprobante);

                    if (dgvGrillaComprobante.Rows.Count > 0)
                    {
                        dgvGrillaComprobante.Rows[0].Selected = true;
                    }
                    else 
                    {
                        LimpiarGrillaDetalle(dgvDetalleComprobante);
                    }
                }
            });
        }

        private void LimpiarGrillaDetalle(DataGridView dgvDetalleComprobante)
        {            
            dgvDetalleComprobante.DataSource = new List<ComprobanteDetalleDTO>();

            FormatearGrillaDetalleComprobante(dgvDetalleComprobante);
        }

        private void RefreshComprobantesPorEmpleado()
        {
            var result = _comprobanteServicio.GetComprobantesPendientesCobroVentaMostrador(_caja.Id,
                                                                                           Properties.Settings.Default.EmpresaId,
                                                                                           txtBuscar.Text);

            if (result != null && result.Data != null)
            {
                dgvGrillaComprobante.DataSource = (List<ComprobanteVentaDTO>)result.Data;

                FormatearGrillaComprobante(dgvGrillaComprobante);

                CargarDetalleComprobante();
            }
        }

        private void FormatearGrillaComprobante(DataGridView dgv)
        {
            for (int i = 0; i < dgv.Columns.Count; i++)
            {
                dgv.Columns[i].Visible = false;
            }

            dgv.AllowUserToResizeRows = false;

            dgv.Columns["FechaStr"].Visible = true;
            dgv.Columns["FechaStr"].Width = 80;
            dgv.Columns["FechaStr"].HeaderText = "Fecha";
            dgv.Columns["FechaStr"].ReadOnly = true;
            dgv.Columns["FechaStr"].DisplayIndex = 0;

            dgv.Columns["ApyNomCliente"].Visible = true;
            dgv.Columns["ApyNomCliente"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv.Columns["ApyNomCliente"].HeaderText = "Cliente";
            dgv.Columns["ApyNomCliente"].ReadOnly = true;
            dgv.Columns["ApyNomCliente"].DisplayIndex = 1;

            dgv.Columns["Observacion"].Visible = true;
            dgv.Columns["Observacion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv.Columns["Observacion"].HeaderText = "Observacion";
            dgv.Columns["Observacion"].ReadOnly = true;
            dgv.Columns["Observacion"].DisplayIndex = 2;

            dgv.Columns["Total"].Visible = true;
            dgv.Columns["Total"].Width = 100;
            dgv.Columns["Total"].HeaderText = "Total";
            dgv.Columns["Total"].ReadOnly = true;
            dgv.Columns["Total"].DisplayIndex = 3;
            dgv.Columns["Total"].DefaultCellStyle.Format = "C2";
            dgv.Columns["Total"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        private void ThreadSafe(MethodInvoker method)
        {
            try
            {
                if (InvokeRequired)
                    Invoke(method);
                else
                    method();
            }
            catch (ObjectDisposedException) { }
        }

        private void _00158_CajaExterna_Shown(object sender, EventArgs e)
        {
            if (!_configuracionCore.ActivarCobroConTicketCaja)
            {
                RefreshComprobantes();
                Start_ordenFabricacion_table_dependency();
            }
        }

        private void BtnFacturar_Click(object sender, EventArgs e)
        {
            if (_comprobanteSeleccionado == null)
            {
                MessageBox.Show("Por favor seleccione una Factura para cobrar", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            _comprobanteSeleccionado.CajaId = _caja.Id;
            _comprobanteSeleccionado.CajaDetalleId = _caja.CajaDetalleId.Value;
            _comprobanteSeleccionado.EmpresaId = Properties.Settings.Default.EmpresaId;
            _comprobanteSeleccionado.VieneDeCajaExterna = true;

            var fMediosDePagos = new _00148_FormaPago(base._seguridadServicio,
                                                      base._configuracionServicio,
                                                      base._logger,
                                                      Program.Container.GetInstance<ITarjetaServicio>(),
                                                      Program.Container.GetInstance<IPlanTarjetaServicio>(),
                                                      Program.Container.GetInstance<IConfiguracionCoreServicio>(),
                                                      Program.Container.GetInstance<IComprobanteServicio>(),
                                                      Program.Container.GetInstance<ICajaServicio>(),
                                                      _comprobanteSeleccionado);

            fMediosDePagos.ShowDialog();

            _comprobanteSeleccionado = null;

            if (fMediosDePagos.RealizoAlgunaOperacion)
            {
                if (_configuracionCore.ActivarCobroConTicketCaja)
                {
                    RefreshComprobantesPorEmpleado();
                }
                else
                {
                    RefreshComprobantes();
                }
            }
        }

        private void _00158_CajaExterna_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!_configuracionCore.ActivarCobroConTicketCaja)
            {
                Stop_ordenFabricacion_table_dependency();
            }
        }

        private void DgvGrillaComprobante_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar si se hizo clic en una celda de la columna DataGridViewCheckBoxColumn
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0 && dgvGrillaComprobante.Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn)
            {
                // Si la celda actual es un CheckBox, marcarla como editada
                dgvGrillaComprobante.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void CargarDetalleComprobante()
        {
            dgvDetalleComprobante.DataSource = _comprobanteSeleccionado.Detalles.ToList();

            FormatearGrillaDetalleComprobante(dgvDetalleComprobante);

            CalcularTotalizador();
        }

        private void FormatearGrillaDetalleComprobante(DataGridView dgv)
        {
            for (int i = 0; i < dgv.Columns.Count; i++)
            {
                dgv.Columns[i].Visible = false;
            }

            dgv.AllowUserToResizeRows = false;

            dgv.Columns["Codigo"].Visible = true;
            dgv.Columns["Codigo"].Width = 80;
            dgv.Columns["Codigo"].HeaderText = "Codigo";
            dgv.Columns["Codigo"].ReadOnly = false;
            dgv.Columns["Codigo"].DisplayIndex = 0;

            dgv.Columns["Descripcion"].Visible = true;
            dgv.Columns["Descripcion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv.Columns["Descripcion"].HeaderText = "Descripcion";
            dgv.Columns["Descripcion"].ReadOnly = true;
            dgv.Columns["Descripcion"].DisplayIndex = 1;

            dgv.Columns["Cantidad"].Visible = true;
            dgv.Columns["Cantidad"].Width = 100;
            dgv.Columns["Cantidad"].HeaderText = "Cantidad";
            dgv.Columns["Cantidad"].ReadOnly = true;
            dgv.Columns["Cantidad"].DisplayIndex = 2;
            dgv.Columns["Cantidad"].DefaultCellStyle.Format = "N2";

            dgv.Columns["SubTotal"].Visible = true;
            dgv.Columns["SubTotal"].Width = 100;
            dgv.Columns["SubTotal"].HeaderText = "Sub-Total";
            dgv.Columns["SubTotal"].ReadOnly = true;
            dgv.Columns["SubTotal"].DisplayIndex = 3;
            dgv.Columns["SubTotal"].DefaultCellStyle.Format = "C2";
        }

        private void CalcularTotalizador()
        {
            txtTotal.Text = _comprobanteSeleccionado.Total.ToString("C2");
        }

        private void DgvDetalleComprobante_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            //// Obtener la fila actual
            //DataGridViewRow row = dgvDetalleComprobante.Rows[e.RowIndex];

            //// Cambiar el color de fondo de la fila
            //row.DefaultCellStyle.BackColor = ((DetalleComprobanteVM)row.DataBoundItem).ColorRow;
        }

        private void _00158_CajaExterna_Load(object sender, EventArgs e)
        {
            var _configResult = _configuracionCoreServicio
                                .Get(Properties.Settings.Default.EmpresaId);

            if (_configResult == null && !_configResult.State)
            {
                MessageBox.Show("Ocurrió un error al obtener la configuración del sistema. Por favor verifique que se encuentre cargada.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            _configuracionCore = (ConfiguracionCoreDTO)_configResult.Data;

            if (_configuracionCore != null)
            {
                btnBuscar.Enabled = _configuracionCore.ActivarCobroConTicketCaja;
                txtBuscar.Enabled = _configuracionCore.ActivarCobroConTicketCaja;
            }
        }

        private void TxtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (!string.IsNullOrEmpty(txtBuscar.Text))
                {
                    btnBuscar.PerformClick();
                }
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            RefreshComprobantesPorEmpleado();
        }

        private void DgvGrillaComprobante_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvGrillaComprobante.Rows.Count > 0) 
            {
                _comprobanteSeleccionado = (ComprobanteVentaDTO)dgvGrillaComprobante.Rows[e.RowIndex].DataBoundItem;

                CargarDetalleComprobante();
            }
            else 
            { 
                _comprobanteSeleccionado = null; 
            }
        }
    }
}
