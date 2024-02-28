using Serilog;
using Sidkenu.AccesoDatos.Constantes;
using Sidkenu.AccesoDatos.Constantes.Enum;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Base;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.Articulo;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.ArticuloFormula;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.ConfiguracionCore;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.Deposito;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.OrdenFabricacion;
using Sidkenu.LogicaNegocio.Servicios.Interface.Core;
using Sidkenu.LogicaNegocio.Servicios.Interface.Seguridad;
using SidkenuWF.Formularios.Base;
using SidkenuWF.Formularios.Base.Constantes;
using SidkenuWF.Formularios.Core.LookUps;

namespace SidkenuWF.Formularios.Core
{
    public partial class _00143_OrdenFabricacion_Abm : FormularioAbm
    {
        private readonly IOrdenFabricacionServicio _ordenFabricacionServicio;
        private readonly IArticuloServicio _articuloServicio;
        private readonly IDepositoServicio _depositoServicio;
        private readonly IConfiguracionCoreServicio _configuracionCoreServicio;

        private ArticuloDTO? _articuloSeleccionado;
        private ConfiguracionCoreDTO _configuracionCore;

        public _00143_OrdenFabricacion_Abm(IOrdenFabricacionServicio ordenFabricacionServicio,
                                           IArticuloServicio articuloServicio,
                                           IDepositoServicio depositoServicio,
                                           ISeguridadServicio seguridadServicio,
                                           IConfiguracionServicio configuracionServicio,
                                           IConfiguracionCoreServicio configuracionCoreServicio,
                                           ILogger logger,
                                           TipoOperacion tipoOperacion,
                                           Guid? entidadId = null,
                                           decimal? cantidadFabricar = null)
                                           : base(seguridadServicio, configuracionServicio, logger, tipoOperacion, entidadId)
        {
            InitializeComponent();

            base.TituloFormulario = FormularioConstantes.Titulo;
            base.Titulo = $"Orden Fabricación / {Enum.GetName(typeof(TipoOperacion), tipoOperacion)}";
            this.Logo = FontAwesome.Sharp.IconChar.BuildingFlag;

            _ordenFabricacionServicio = ordenFabricacionServicio;
            _articuloServicio = articuloServicio;
            _depositoServicio = depositoServicio;
            _configuracionCoreServicio = configuracionCoreServicio;

            _articuloSeleccionado = null;

            nudCantidadFabricar.Value = 0;

            if (cantidadFabricar.HasValue) 
            {
                nudCantidadFabricar.Value = cantidadFabricar.Value;
            }
        }

        public override void CargarDatos(TipoOperacion tipoOperacion, Guid? entidadId, Guid? entidadSecundariaId)
        {
            var configCoreResult = _configuracionCoreServicio.Get(Properties.Settings.Default.EmpresaId);

            if (configCoreResult != null && configCoreResult.State) 
            {
                _configuracionCore = (ConfiguracionCoreDTO)configCoreResult.Data;
            }

            var _resultDeposito = _depositoServicio.GetByFilter(new DepositoFilterDTO
            {
                CadenaBuscar = string.Empty,
                EmpresaId = Properties.Settings.Default.EmpresaId,
                VerEliminados = false
            });

            if (_resultDeposito != null && _resultDeposito.State)
            {
                PoblarComboBox(cmbDepositoOrigen, _resultDeposito.Data, "Descripcion", "Id");
                PoblarComboBox(cmbDepositoDestino, _resultDeposito.Data, "Descripcion", "Id");
            }
            else
            {
                MessageBox.Show("No hay depositos cargados para la empresa Actual", "Atencion", MessageBoxButtons.OK);
                this.Close();
                return;
            }

            if (tipoOperacion == TipoOperacion.Nuevo && entidadId.HasValue)
            {
                CargarDatosSegunArticuloSeleccionado(entidadId.Value);
            }
        }

        private void CargarDatosSegunArticuloSeleccionado(Guid entidadId)
        {
            var _resultArticuloDepositoOrigen = _articuloServicio
                                .GetById(entidadId, Properties.Settings.Default.EmpresaId, (Guid)cmbDepositoOrigen.SelectedValue);

            if (_resultArticuloDepositoOrigen != null && _resultArticuloDepositoOrigen.State)
            {
                _articuloSeleccionado = (ArticuloDTO)_resultArticuloDepositoOrigen.Data;                

                txtCodigo.Text = _articuloSeleccionado.Codigo;
                txtDescripcion.Text = _articuloSeleccionado.Descripcion;
                txtStockOrigen.Text = _articuloSeleccionado.Stock.ToString("N2");

                // Cargo el Detalle

                var _detalle = _articuloServicio.GetByIds(_articuloSeleccionado.ArticuloFormulas.Select(x => x.ArticuloHijoId).ToList(),
                    Properties.Settings.Default.EmpresaId,
                    (Guid)cmbDepositoOrigen.SelectedValue);

                dgvGrilla.DataSource = CargarDatosDetalle(_articuloSeleccionado.ArticuloFormulas.ToList(), (List<ArticuloDTO>)_detalle.Data, nudCantidadFabricar.Value);

                FormatearGrilla();
            }

            var _resultArticuloDepositoDestino = _articuloServicio
                .GetById(entidadId, Properties.Settings.Default.EmpresaId, (Guid)cmbDepositoDestino.SelectedValue);

            if (_resultArticuloDepositoDestino != null && _resultArticuloDepositoDestino.State)
            {
                var _artDestino = (ArticuloDTO)_resultArticuloDepositoDestino.Data;

                txtStockDestino.Text = _artDestino.Stock.ToString("N2");
            }            
        }

        private List<OrdenFabricacionDetalleDTO> CargarDatosDetalle(List<ArticuloFormulaDTO> articuloFormulas, List<ArticuloDTO> _articulosDelDetalle, decimal cantidadFabricar)
        {
            var detalles = new List<OrdenFabricacionDetalleDTO>();

            Parallel.ForEach(_articulosDelDetalle, x =>
            {
                detalles.Add(new OrdenFabricacionDetalleDTO
                {
                    ArticuloId = x.Id,
                    Codigo = x.Codigo,
                    Descripcion = x.Descripcion,
                    CantidadFabricar = cantidadFabricar,
                    EsFormula = x.TipoArticulo == TipoArticulo.Formula,
                    EstaEliminado = false,
                    EstaSeleccionado = false,
                    StockActual = x.Stock,
                    Cantidad = articuloFormulas.First(af => af.ArticuloHijoId == x.Id).Cantidad
                });
            });

            return detalles.ToList();
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
            dgvGrilla.Columns["Cantidad"].DefaultCellStyle.Format = "N3";

            dgvGrilla.Columns["CantidadFabricar"].Visible = true;
            dgvGrilla.Columns["CantidadFabricar"].Width = 80;
            dgvGrilla.Columns["CantidadFabricar"].HeaderText = "Cant Fab";
            dgvGrilla.Columns["CantidadFabricar"].DisplayIndex = 7;
            dgvGrilla.Columns["CantidadFabricar"].ReadOnly = true;
            dgvGrilla.Columns["CantidadFabricar"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvGrilla.Columns["CantidadFabricar"].DefaultCellStyle.Format = "N3";

            dgvGrilla.Columns["CantidadTotal"].Visible = true;
            dgvGrilla.Columns["CantidadTotal"].Width = 80;
            dgvGrilla.Columns["CantidadTotal"].HeaderText = "Cant Total";
            dgvGrilla.Columns["CantidadTotal"].DisplayIndex = 8;
            dgvGrilla.Columns["CantidadTotal"].ReadOnly = true;
            dgvGrilla.Columns["CantidadTotal"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvGrilla.Columns["CantidadTotal"].DefaultCellStyle.Format = "N3";

            dgvGrilla.Columns["StockActual"].Visible = true;
            dgvGrilla.Columns["StockActual"].Width = 80;
            dgvGrilla.Columns["StockActual"].HeaderText = "Stock";
            dgvGrilla.Columns["StockActual"].DisplayIndex = 9;
            dgvGrilla.Columns["StockActual"].ReadOnly = true;
            dgvGrilla.Columns["StockActual"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvGrilla.Columns["StockActual"].DefaultCellStyle.Format = "N3";

            dgvGrilla.Columns["Faltante"].Visible = true;
            dgvGrilla.Columns["Faltante"].Width = 70;
            dgvGrilla.Columns["Faltante"].HeaderText = "Faltante";
            dgvGrilla.Columns["Faltante"].DisplayIndex = 10;
            dgvGrilla.Columns["Faltante"].ReadOnly = true;
            dgvGrilla.Columns["Faltante"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvGrilla.Columns["Faltante"].DefaultCellStyle.Format = "N3";

            dgvGrilla.Columns["HayStock"].Visible = false;
            dgvGrilla.Columns["HayStock"].DisplayIndex = 11;

            dgvGrilla.Columns["EsFormula"].Visible = false;
            dgvGrilla.Columns["EsFormula"].DisplayIndex = 12;
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            var tipos = new List<TipoArticulo>
            {
                TipoArticulo.Formula
            };

            var formulario = new ArticuloLookUp(base._seguridadServicio,
                                                base._configuracionServicio,
                                                base._logger,
                                                Program.Container.GetInstance<IArticuloServicio>(),
                                                tipos);

            formulario.ShowDialog();

            if (formulario.SeleccionoEntidad)
            {
                _articuloSeleccionado = (ArticuloDTO)formulario.Entidad;

                if (_articuloSeleccionado != null)
                {
                    this.txtDescripcion.Text = _articuloSeleccionado.Descripcion;
                    this.txtCodigo.Text = _articuloSeleccionado.Codigo;

                    CargarDatosSegunArticuloSeleccionado(_articuloSeleccionado.Id);
                }
            }
        }

        private void DgvGrilla_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
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

        private void NudCantidadFabricar_ValueChanged(object sender, EventArgs e)
        {
            if (_articuloSeleccionado != null)
            {
                CargarDatosSegunArticuloSeleccionado(_articuloSeleccionado.Id);
            }
        }

        public override bool VerificarDatosObligatorios()
        {
            if (nudCantidadFabricar.Value <= 0) 
            {
                MessageBox.Show("La cantidad a fabricar debe ser mayor a 0 (Cero)", "Atención");
                return false;
            }

            if(((List<DepositoDTO>)cmbDepositoDestino.DataSource).Count <= 0) 
            {
                MessageBox.Show("No hay depositos seleccionados", "Atención");
                return false;
            }

            return true;
        }

        public override ResultDTO EjecutarComandoInsert()
        {
            try
            {
                var registro = AsignarDatos();

                registro.OrigenFabricacion = OrigenFabricacion.Fabrica;
                registro.ActulizarPrecioPublico = _configuracionCore.ActualizarPrecioFinalizarLaFabricacion;

                var result = _ordenFabricacionServicio.Add(registro, Properties.Settings.Default.UserLogin);

                if (result.State)
                {
                    if (base._configuracionDTO != null && base._configuracionDTO != null && base._configuracionDTO.LogInformacion)
                    {
                        _logger.Information($"Se INSERTO Datos: {AsignarDatos().GetPropValue()}. User: {Properties.Settings.Default.PersonaLogin}");
                    }
                }

                return result;
            }
            catch (Exception ex)
            {
                return new ResultDTO
                {
                    State = false,
                    Message = ex.Message,
                };
            }
        }

        private OrdenFabricacionPersistenciaDTO AsignarDatos()
        {
            return new OrdenFabricacionPersistenciaDTO
            {
                ArticuloId = _articuloSeleccionado.Id,
                Cantidad = nudCantidadFabricar.Value,
                DepositoDestinoId = (Guid)cmbDepositoDestino.SelectedValue,
                DepositoOrigenId = (Guid)cmbDepositoOrigen.SelectedValue,
                EmpresaId = Properties.Settings.Default.EmpresaId,
                Detalles = (List<OrdenFabricacionDetalleDTO>)dgvGrilla.DataSource
            };
        }
    }
}
