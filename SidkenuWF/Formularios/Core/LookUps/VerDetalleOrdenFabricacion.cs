using Serilog;
using Sidkenu.AccesoDatos.Constantes.Enum;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.OrdenFabricacion;
using Sidkenu.LogicaNegocio.Servicios.Interface.Core;
using Sidkenu.LogicaNegocio.Servicios.Interface.Seguridad;
using SidkenuWF.Formularios.Base;
using SidkenuWF.Formularios.Base.Constantes;

namespace SidkenuWF.Formularios.Core.LookUps
{
    public partial class VerDetalleOrdenFabricacion : FormularioComun
    {
        private List<OrdenFabricacionDetalleDTO> _detalles;
        private decimal _cantidadProducir;

        private OrdenFabricacionDetalleDTO? _detalleSeleccionado;

        private EstadoOrdenFabricacion _ordenFabricacion;

        public bool RealizaUnaOrdenFabricacion { get; set; }

        public VerDetalleOrdenFabricacion(ISeguridadServicio seguridadServicio,
                                          IConfiguracionServicio configuracionServicio,
                                          ILogger logger)
                                          : base(seguridadServicio, configuracionServicio, logger)
        {
            InitializeComponent();

            RealizaUnaOrdenFabricacion = false;
        }

        public VerDetalleOrdenFabricacion(ISeguridadServicio seguridadServicio,
                                          IConfiguracionServicio configuracionServicio,
                                          ILogger logger,
                                          EstadoOrdenFabricacion estadoOrden,
                                          List<OrdenFabricacionDetalleDTO> detalles,
                                          decimal cantidadProducir,
                                          string titulo)
                                          : this(seguridadServicio, configuracionServicio, logger)
        {
            this._detalles = detalles;
            this._cantidadProducir = cantidadProducir;
            this.TituloFormulario = FormularioConstantes.Titulo;
            this.Titulo = titulo;
            this.Logo = FontAwesome.Sharp.IconChar.BuildingFlag;
            this._ordenFabricacion = estadoOrden;

            if (estadoOrden != EstadoOrdenFabricacion.Pendiente)
            {
                pnlBotonera.Visible = false;
            }

            _detalleSeleccionado = null;
        }

        private void VerDetalleOrdenFabricacion_Shown(object sender, EventArgs e)
        {
            dgvGrilla.DataSource = _detalles.ToList();

            FormatearGrilla();
        }

        private void FormatearGrilla()
        {
            dgvGrilla.AllowUserToResizeRows = false;

            dgvGrilla.Columns["Id"].Visible = false;
            dgvGrilla.Columns["Id"].DisplayIndex = 0;

            dgvGrilla.Columns["ArticuloId"].Visible = false;
            dgvGrilla.Columns["ArticuloId"].DisplayIndex = 1;

            dgvGrilla.Columns["EstaSeleccionado"].Visible = false;
            dgvGrilla.Columns["EstaSeleccionado"].DisplayIndex = 2;

            dgvGrilla.Columns["EstaEliminado"].Visible = false;
            dgvGrilla.Columns["EstaEliminado"].DisplayIndex = 3;

            dgvGrilla.Columns["Codigo"].Visible = true;
            dgvGrilla.Columns["Codigo"].Width = 70;
            dgvGrilla.Columns["Codigo"].HeaderText = "Codigo";
            dgvGrilla.Columns["Codigo"].DisplayIndex = 4;
            dgvGrilla.Columns["Codigo"].ReadOnly = true;
            dgvGrilla.Columns["Codigo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvGrilla.Columns["Descripcion"].Visible = true;
            dgvGrilla.Columns["Descripcion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvGrilla.Columns["Descripcion"].HeaderText = "Articulo";
            dgvGrilla.Columns["Descripcion"].DisplayIndex = 5;
            dgvGrilla.Columns["Descripcion"].ReadOnly = true;

            dgvGrilla.Columns["Cantidad"].Visible = true;
            dgvGrilla.Columns["Cantidad"].Width = 80;
            dgvGrilla.Columns["Cantidad"].HeaderText = "Cant Form";
            dgvGrilla.Columns["Cantidad"].DisplayIndex = 6;
            dgvGrilla.Columns["Cantidad"].ReadOnly = true;
            dgvGrilla.Columns["Cantidad"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvGrilla.Columns["Cantidad"].DefaultCellStyle.Format = "N6";

            if (_ordenFabricacion == EstadoOrdenFabricacion.Pendiente)
            {
                dgvGrilla.Columns["CantidadFabricar"].Visible = true;
                dgvGrilla.Columns["CantidadFabricar"].Width = 80;
                dgvGrilla.Columns["CantidadFabricar"].HeaderText = "Cant Fab";
                dgvGrilla.Columns["CantidadFabricar"].DisplayIndex = 7;
                dgvGrilla.Columns["CantidadFabricar"].ReadOnly = true;
                dgvGrilla.Columns["CantidadFabricar"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvGrilla.Columns["CantidadFabricar"].DefaultCellStyle.Format = "N6";

                dgvGrilla.Columns["CantidadTotal"].Visible = true;
                dgvGrilla.Columns["CantidadTotal"].Width = 80;
                dgvGrilla.Columns["CantidadTotal"].HeaderText = "Cant Total";
                dgvGrilla.Columns["CantidadTotal"].DisplayIndex = 8;
                dgvGrilla.Columns["CantidadTotal"].ReadOnly = true;
                dgvGrilla.Columns["CantidadTotal"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvGrilla.Columns["CantidadTotal"].DefaultCellStyle.Format = "N6";

                dgvGrilla.Columns["StockActual"].Visible = true;
                dgvGrilla.Columns["StockActual"].Width = 80;
                dgvGrilla.Columns["StockActual"].HeaderText = "Stock";
                dgvGrilla.Columns["StockActual"].DisplayIndex = 9;
                dgvGrilla.Columns["StockActual"].ReadOnly = true;
                dgvGrilla.Columns["StockActual"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvGrilla.Columns["StockActual"].DefaultCellStyle.Format = "N6";

                dgvGrilla.Columns["Faltante"].Visible = true;
                dgvGrilla.Columns["Faltante"].Width = 70;
                dgvGrilla.Columns["Faltante"].HeaderText = "Faltante";
                dgvGrilla.Columns["Faltante"].DisplayIndex = 10;
                dgvGrilla.Columns["Faltante"].ReadOnly = true;
                dgvGrilla.Columns["Faltante"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvGrilla.Columns["Faltante"].DefaultCellStyle.Format = "N6";
            }
            else
            {
                dgvGrilla.Columns["CantidadFabricar"].Visible = false;
                dgvGrilla.Columns["CantidadFabricar"].DisplayIndex = 7;

                dgvGrilla.Columns["CantidadTotal"].Visible = false;
                dgvGrilla.Columns["CantidadTotal"].DisplayIndex = 8;

                dgvGrilla.Columns["StockActual"].Visible = false;
                dgvGrilla.Columns["StockActual"].DisplayIndex = 9;

                dgvGrilla.Columns["Faltante"].Visible = false;
                dgvGrilla.Columns["Faltante"].DisplayIndex = 10;
            }

            dgvGrilla.Columns["HayStock"].Visible = false;
            dgvGrilla.Columns["HayStock"].DisplayIndex = 11;

            dgvGrilla.Columns["EsFormula"].Visible = false;
            dgvGrilla.Columns["EsFormula"].DisplayIndex = 12;
        }

        private void DgvGrilla_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (_ordenFabricacion == EstadoOrdenFabricacion.Pendiente)
                {
                    DataGridViewCell cellToCheck = dgvGrilla.Rows[e.RowIndex].Cells["Faltante"];
                    DataGridViewCell cellToCheckEsFormula = dgvGrilla.Rows[e.RowIndex].Cells["EsFormula"];

                    if (cellToCheck.Value != null && (decimal)cellToCheck.Value > 0)
                    {
                        if ((bool)cellToCheckEsFormula.Value)
                        {
                            dgvGrilla.Rows[e.RowIndex].Cells["Faltante"].Style.BackColor = Color.LightSkyBlue;
                        }
                        else
                        {
                            dgvGrilla.Rows[e.RowIndex].Cells["Faltante"].Style.BackColor = Color.LightSalmon;
                        }
                    }
                    else
                    {
                        dgvGrilla.Rows[e.RowIndex].Cells["Faltante"].Style.BackColor = Color.White;
                    }
                }
            }
        }

        private void DgvGrilla_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (_detalles.Any())
            {
                _detalleSeleccionado = (OrdenFabricacionDetalleDTO)this.dgvGrilla.Rows[e.RowIndex].DataBoundItem;

                if (_ordenFabricacion == EstadoOrdenFabricacion.Pendiente)
                {
                    btnGenerarOrdenFabricacion.Visible = _detalleSeleccionado.EsFormula;
                }
            }
        }

        private void BtnGenerarOrdenFabricacion_Click(object sender, EventArgs e)
        {
            var formulario = new _00143_OrdenFabricacion_Abm(Program.Container.GetInstance<IOrdenFabricacionServicio>(),
                                                             Program.Container.GetInstance<IArticuloServicio>(),
                                                             Program.Container.GetInstance<IDepositoServicio>(),
                                                             base._seguridadServicio,
                                                             base._configuracionServicio,
                                                             Program.Container.GetInstance<IConfiguracionCoreServicio>(),
                                                             base._logger,
                                                             TipoOperacion.Nuevo,
                                                             _detalleSeleccionado.ArticuloId,
                                                             _detalleSeleccionado.CantidadFabricar);

            if (FormularioSeguridad.VerificarAccesoParaAbrirEnPanel(formulario, base._seguridadServicio, base._logger, base._configuracionDTO))
            {
                formulario.ShowDialog();

                this.RealizaUnaOrdenFabricacion = formulario.RealizoAlgunaOperacion;
            }
        }
    }
}
