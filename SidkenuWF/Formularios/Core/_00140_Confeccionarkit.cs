using Serilog;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Base;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.Articulo;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.ArticuloKit;
using Sidkenu.LogicaNegocio.Servicios.Interface.Core;
using Sidkenu.LogicaNegocio.Servicios.Interface.Seguridad;
using SidkenuWF.Formularios.Base;
using SidkenuWF.Formularios.Base.Constantes;
using SidkenuWF.Formularios.Core.LookUps;
using SidkenuWF.Formularios.Core.Varios;

namespace SidkenuWF.Formularios.Core
{
    public partial class _00140_Confeccionarkit : FormularioComun
    {
        private readonly IArticuloServicio _articuloServicio;
        private readonly IArticuloKitServicio _articuloKitServicio;

        private readonly ArticuloDTO _articuloSeleccionado;

        private ArticuloDTO? _articuloSeleccionadoLookUp;

        private MyListBaseDTO<ArticuloKitDTO> _articulos;

        private ArticuloKitDTO? _articuloKitSeleccionado;

        public _00140_Confeccionarkit(ISeguridadServicio seguridadServicio,
                                      IConfiguracionServicio configuracionServicio,
                                      ILogger logger,
                                      IArticuloServicio articuloServicio,
                                      ArticuloDTO articuloSeleccionado,
                                      IArticuloKitServicio articuloKitServicio)
                                      : base(seguridadServicio, configuracionServicio, logger)
        {
            InitializeComponent();

            base.TituloFormulario = FormularioConstantes.Titulo;
            base.Titulo = "Confeccionar Kit";
            base.Logo = FontAwesome.Sharp.IconChar.Box;

            _articuloServicio = articuloServicio;
            _articuloSeleccionado = articuloSeleccionado;

            _articuloSeleccionadoLookUp = null;
            _articuloKitSeleccionado = null;

            lblEntidadSeleccionada.Text = _articuloSeleccionado.Descripcion;

            _articulos = new MyListBaseDTO<ArticuloKitDTO>();
            _articulos.ItemAdded += Articulos_ItemAdded;
            _articulos.ItemRemoved += Articulos_ItemRemoved;

            _articuloKitServicio = articuloKitServicio;
        }

        private void ActualizarDatos(bool verEliminados)
        {
            txtPrecioCosto.Text = _articulos.Where(x => !x.EstaEliminado).Sum(x => x.PrecioCosto).ToString("C");
            txtPrecioPublico.Text = _articulos.Where(x => !x.EstaEliminado).Sum(x => x.SubTotal).ToString("C");

            nudPrecioPublico.Value = _articulos.Where(x => !x.EstaEliminado).Sum(x => x.SubTotal);

            dgvGrilla.DataSource = _articulos.Where(x => x.EstaEliminado == verEliminados).ToList();
        }

        private void Articulos_ItemRemoved(object? sender, ItemRemovedEventArgs<ArticuloKitDTO> e)
        {
            ActualizarDatos(chkVerEliminados.Checked);
        }

        private void Articulos_ItemAdded(object? sender, ItemAddedEventArgs<ArticuloKitDTO> e)
        {
            ActualizarDatos(chkVerEliminados.Checked);
        }

        private void _00140_Confeccionarkit_Load(object sender, EventArgs e)
        {
            dgvGrilla.DataSource = _articulos.Where(x => !x.EstaEliminado).ToList();

            FormatearGrilla();
        }

        private void FormatearGrilla()
        {
            dgvGrilla.AllowUserToResizeRows = false;

            dgvGrilla.Columns["Id"].Visible = false;
            dgvGrilla.Columns["Id"].DisplayIndex = 0;

            dgvGrilla.Columns["ArticuloHijoId"].Visible = false;
            dgvGrilla.Columns["ArticuloHijoId"].DisplayIndex = 1;

            dgvGrilla.Columns["ExisteBase"].Visible = false;
            dgvGrilla.Columns["ExisteBase"].DisplayIndex = 2;

            dgvGrilla.Columns["EstaSeleccionado"].Visible = false;
            dgvGrilla.Columns["EstaSeleccionado"].DisplayIndex = 3;

            dgvGrilla.Columns["EstaEliminado"].Visible = false;
            dgvGrilla.Columns["EstaEliminado"].DisplayIndex = 4;

            dgvGrilla.Columns["Codigo"].Visible = true;
            dgvGrilla.Columns["Codigo"].Width = 80;
            dgvGrilla.Columns["Codigo"].HeaderText = "Código";
            dgvGrilla.Columns["Codigo"].DisplayIndex = 5;
            dgvGrilla.Columns["Codigo"].ReadOnly = true;

            dgvGrilla.Columns["Descripcion"].Visible = true;
            dgvGrilla.Columns["Descripcion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvGrilla.Columns["Descripcion"].HeaderText = "Articulo";
            dgvGrilla.Columns["Descripcion"].DisplayIndex = 6;
            dgvGrilla.Columns["Descripcion"].ReadOnly = true;

            dgvGrilla.Columns["PrecioCosto"].Visible = true;
            dgvGrilla.Columns["PrecioCosto"].Width = 100;
            dgvGrilla.Columns["PrecioCosto"].HeaderText = "Precio Costo";
            dgvGrilla.Columns["PrecioCosto"].DisplayIndex = 7;
            dgvGrilla.Columns["PrecioCosto"].ReadOnly = true;
            dgvGrilla.Columns["PrecioCosto"].DefaultCellStyle.Format = "C";
            dgvGrilla.Columns["PrecioCosto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgvGrilla.Columns["PrecioPublico"].Visible = true;
            dgvGrilla.Columns["PrecioPublico"].Width = 100;
            dgvGrilla.Columns["PrecioPublico"].HeaderText = "Precio Publico";
            dgvGrilla.Columns["PrecioPublico"].DisplayIndex = 8;
            dgvGrilla.Columns["PrecioPublico"].ReadOnly = true;
            dgvGrilla.Columns["PrecioPublico"].DefaultCellStyle.Format = "C";
            dgvGrilla.Columns["PrecioPublico"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgvGrilla.Columns["Cantidad"].Visible = true;
            dgvGrilla.Columns["Cantidad"].Width = 75;
            dgvGrilla.Columns["Cantidad"].HeaderText = "Cant";
            dgvGrilla.Columns["Cantidad"].DisplayIndex = 9;
            dgvGrilla.Columns["Cantidad"].ReadOnly = true;
            dgvGrilla.Columns["Cantidad"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvGrilla.Columns["Cantidad"].DefaultCellStyle.Format = "N6";

            dgvGrilla.Columns["SubTotal"].Visible = true;
            dgvGrilla.Columns["SubTotal"].Width = 100;
            dgvGrilla.Columns["SubTotal"].HeaderText = "Sub-Total";
            dgvGrilla.Columns["SubTotal"].DisplayIndex = 10;
            dgvGrilla.Columns["SubTotal"].ReadOnly = true;
            dgvGrilla.Columns["SubTotal"].DefaultCellStyle.Format = "C";
            dgvGrilla.Columns["SubTotal"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        private void BtnAgregarArticulo_Click(object sender, EventArgs e)
        {
            if (_articuloSeleccionadoLookUp == null)
            {
                MessageBox.Show("No hay un articulo seleccionado", "Atencion");
                return;
            }

            if (!VerificarSiExiste(_articuloSeleccionadoLookUp.Codigo))
            {
                _articulos.Add(new ArticuloKitDTO()
                {
                    Codigo = _articuloSeleccionadoLookUp.Codigo,
                    Descripcion = _articuloSeleccionadoLookUp.Descripcion,
                    Id = _articuloSeleccionadoLookUp.Id,
                    PrecioCosto = _articuloSeleccionadoLookUp.PrecioCosto,
                    PrecioPublico = _articuloSeleccionadoLookUp.PrecioPublico,
                    Cantidad = nudCantidadArticulos.Value,
                    ExisteBase = false,
                    EstaEliminado = false,
                });
            }
            else 
            {
                var _art = _articulos.First(x => x.Codigo == _articuloSeleccionadoLookUp.Codigo);

                _art.Cantidad += nudCantidadArticulos.Value;
            }

            txtCodigo.Clear();
            txtDescripcion.Clear();
            _articuloSeleccionadoLookUp = null;

            ActualizarDatos(chkVerEliminados.Checked);
        }

        private bool VerificarSiExiste(string codigo)
        {
            return _articulos.Any(x=>x.Codigo == codigo);
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            var formulario = new ArticuloLookUp(base._seguridadServicio,
                                                base._configuracionServicio,
                                                base._logger,
                                                Program.Container.GetInstance<IArticuloServicio>());

            formulario.ShowDialog();

            if (formulario.SeleccionoEntidad)
            {
                _articuloSeleccionadoLookUp = (ArticuloDTO)formulario.Entidad;

                if (_articuloSeleccionadoLookUp != null)
                {
                    this.txtDescripcion.Text = _articuloSeleccionadoLookUp.Descripcion;
                    this.txtCodigo.Text = _articuloSeleccionadoLookUp.Codigo;
                    nudCantidadArticulos.Value = 1;
                    nudCantidadArticulos.Focus();
                }
            }
        }

        private void DgvGrilla_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (_articulos.Any())
            {
                _articuloKitSeleccionado = (ArticuloKitDTO)this.dgvGrilla.Rows[e.RowIndex].DataBoundItem;
            }
            else
            {
                _articuloKitSeleccionado = null;
            }
        }

        private void BtnQuitarArticulo_Click(object sender, EventArgs e)
        {
            var mensaje = chkVerEliminados.Checked
                ? "Esta seguro de Activar el Articulo seleccionado del KIT"
                : "Esta seguro de Eliminar el Articulo seleccionado del KIT";

            if (MessageBox.Show(mensaje,
                "Atencion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question)
                == DialogResult.Yes)
            {
                _articulos.Remove(_articuloKitSeleccionado);
            }
        }

        private void BtnEjecutar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtpFechaVigencia.Value.Date == DateTime.Today)
                {
                    MessageBox.Show("La Fecha de Vigencia debe ser Mayor a la Fecha Actual", "Atención");
                    return;
                }

                if (nudPrecioPublico.Value <= 0)
                {
                    MessageBox.Show("El Precio Publico no puede ser CERO.", "Atención");
                    return;
                }

                if (MessageBox.Show("Esta seguro de Generar el Kit", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    == DialogResult.No)
                {
                    return;
                }

                var result = _articuloKitServicio.Add(new ArticuloKitPersistenciaDTO
                {
                    ArticuloBaseId = _articuloSeleccionado.Id,
                    FechaVigencia = dtpFechaVigencia.Value,
                    PrecioCosto = _articulos.Sum(x => x.PrecioCosto),
                    PrecioPublico = nudPrecioPublico.Value,
                    Stock = nudStock.Value,
                    EmpresaId = Properties.Settings.Default.EmpresaId,
                    Articulos = _articulos
                }, Properties.Settings.Default.UserLogin);

                if (result.State)
                {
                    MessageBox.Show(result.Message, "Atencion");

                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atencion");
            }
        }

        private void _00140_Confeccionarkit_Shown(object sender, EventArgs e)
        {
            var listaIds = _articuloSeleccionado.ArticuloKits.Select(x => x.ArticuloHijoId).ToList();

            var result = _articuloServicio.GetByIds(listaIds, Properties.Settings.Default.EmpresaId);

            if (result.State)
            {
                var listaArthijos = (List<ArticuloDTO>)result.Data;

                foreach (var artKit in _articuloSeleccionado.ArticuloKits.ToList())
                {
                    var artHijo = listaArthijos.First(x => x.Id == artKit.ArticuloHijoId);

                    _articulos.Add(new ArticuloKitDTO
                    {
                        ArticuloHijoId = artKit.ArticuloHijoId,
                        Cantidad = artKit.Cantidad,
                        Codigo = artKit.Codigo,
                        Descripcion = artKit.Descripcion,
                        Id = artKit.Id,
                        PrecioCosto = artHijo.PrecioCosto,
                        PrecioPublico = artHijo.PrecioPublico,
                        ExisteBase = true,
                        EstaEliminado = false
                    });
                }
            }

            dtpFechaVigencia.Value = _articuloSeleccionado.FechaVigenciaKit.HasValue ? _articuloSeleccionado.FechaVigenciaKit.Value : DateTime.Now;
            dtpFechaVigencia.MinDate = DateTime.Now;
            nudPrecioPublico.Value = _articuloSeleccionado.PrecioPublico;
            nudStock.Value = _articuloSeleccionado.Stock;
        }

        private void ChkVerEliminados_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarDatos(chkVerEliminados.Checked);
        }

        private void DgvGrilla_DoubleClick(object sender, EventArgs e)
        {
            if (_articulos.Count > 0 && _articuloKitSeleccionado != null)
            {
                var fCambiarCantidad = new CambiarCantidadKit(_articuloKitSeleccionado);
                fCambiarCantidad.ShowDialog();

                _articuloKitSeleccionado = fCambiarCantidad.ArticuloKit;

                ActualizarDatos(chkVerEliminados.Checked);
            }
        }
    }
}
