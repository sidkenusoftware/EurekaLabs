using Serilog;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Base;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.Articulo;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.ArticuloFormula;
using Sidkenu.LogicaNegocio.Servicios.Interface.Core;
using Sidkenu.LogicaNegocio.Servicios.Interface.Seguridad;
using SidkenuWF.Formularios.Base;
using SidkenuWF.Formularios.Base.Constantes;
using SidkenuWF.Formularios.Core.LookUps;
using SidkenuWF.Formularios.Core.Varios;

namespace SidkenuWF.Formularios.Core
{
    public partial class _00141_ConfeccionarFormula : FormularioComun
    {
        private readonly IArticuloServicio _articuloServicio;
        private readonly IArticuloFormulaServicio _articuloFormulaServicio;

        private readonly ArticuloDTO _articuloSeleccionado;

        private ArticuloDTO? _articuloSeleccionadoLookUp;

        private MyListBaseDTO<ArticuloFormulaDTO> _articulos;

        private ArticuloFormulaDTO? _articuloFormulaSeleccionado;

        public _00141_ConfeccionarFormula(ISeguridadServicio seguridadServicio,
                                      IConfiguracionServicio configuracionServicio,
                                      ILogger logger,
                                      IArticuloServicio articuloServicio,
                                      ArticuloDTO articuloSeleccionado,
                                      IArticuloFormulaServicio articuloFormulaServicio)
                                      : base(seguridadServicio, configuracionServicio, logger)
        {
            InitializeComponent();

            base.TituloFormulario = FormularioConstantes.Titulo;
            base.Titulo = "Confeccionar Formula";
            base.Logo = FontAwesome.Sharp.IconChar.Box;

            _articuloServicio = articuloServicio;
            _articuloSeleccionado = articuloSeleccionado;

            _articuloSeleccionadoLookUp = null;
            _articuloFormulaSeleccionado = null;

            lblEntidadSeleccionada.Text = _articuloSeleccionado.Descripcion;

            _articulos = new MyListBaseDTO<ArticuloFormulaDTO>();
            _articulos.ItemAdded += Articulos_ItemAdded;
            _articulos.ItemRemoved += Articulos_ItemRemoved;

            _articuloFormulaServicio = articuloFormulaServicio;
        }

        private void Actualizar(bool verEliminados)
        {
            dgvGrilla.DataSource = _articulos.Where(x => x.EstaEliminado == verEliminados).ToList();
        }

        private void Articulos_ItemRemoved(object? sender, ItemRemovedEventArgs<ArticuloFormulaDTO> e)
        {
            Actualizar(chkVerEliminados.Checked);
        }

        private void Articulos_ItemAdded(object? sender, ItemAddedEventArgs<ArticuloFormulaDTO> e)
        {
            Actualizar(chkVerEliminados.Checked);
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

            dgvGrilla.Columns["Perdida"].Visible = false;
            dgvGrilla.Columns["Perdida"].DisplayIndex = 7;

            dgvGrilla.Columns["TipoValor"].Visible = false;
            dgvGrilla.Columns["TipoValor"].DisplayIndex = 8;

            dgvGrilla.Columns["Cantidad"].Visible = true;
            dgvGrilla.Columns["Cantidad"].Width = 75;
            dgvGrilla.Columns["Cantidad"].HeaderText = "Cant";
            dgvGrilla.Columns["Cantidad"].DisplayIndex = 9;
            dgvGrilla.Columns["Cantidad"].ReadOnly = true;
            dgvGrilla.Columns["Cantidad"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvGrilla.Columns["Cantidad"].DefaultCellStyle.Format = "N6";
        }

        private void BtnAgregarProveedor_Click(object sender, EventArgs e)
        {
            if (_articuloSeleccionadoLookUp == null)
            {
                MessageBox.Show("No hay un articulo seleccionado", "Atencion");
                return;
            }

            _articulos.Add(new ArticuloFormulaDTO()
            {
                Codigo = _articuloSeleccionadoLookUp.Codigo,
                Descripcion = _articuloSeleccionadoLookUp.Descripcion,
                Id = _articuloSeleccionadoLookUp.Id,
                Cantidad = nudCantidadArticulos.Value,
                ExisteBase = false,
                EstaEliminado = false,
            });

            txtCodigo.Clear();
            txtDescripcion.Clear();
            _articuloSeleccionadoLookUp = null;
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
                _articuloFormulaSeleccionado = (ArticuloFormulaDTO)this.dgvGrilla.Rows[e.RowIndex].DataBoundItem;
            }
            else
            {
                _articuloFormulaSeleccionado = null;
            }
        }

        private void BtnQuitarProveedor_Click(object sender, EventArgs e)
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
                _articulos.Remove(_articuloFormulaSeleccionado);
            }
        }

        private void BtnEjecutar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Esta seguro de Generar el Formula", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    == DialogResult.No)
                {
                    return;
                }

                var result = _articuloFormulaServicio.Add(new ArticuloFormulaPersistenciaDTO
                {
                    ArticuloBaseId = _articuloSeleccionado.Id,
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
            var listaIds = _articuloSeleccionado.ArticuloFormulas.Select(x => x.ArticuloHijoId).ToList();

            var result = _articuloServicio.GetByIds(listaIds, Properties.Settings.Default.EmpresaId);

            if (result.State)
            {
                var listaArthijos = (List<ArticuloDTO>)result.Data;

                foreach (var artFormula in _articuloSeleccionado.ArticuloFormulas.ToList())
                {
                    var artHijo = listaArthijos.First(x => x.Id == artFormula.ArticuloHijoId);

                    _articulos.Add(new ArticuloFormulaDTO
                    {
                        ArticuloHijoId = artFormula.ArticuloHijoId,
                        Cantidad = artFormula.Cantidad,
                        Codigo = artFormula.Codigo,
                        Descripcion = artFormula.Descripcion,
                        Id = artFormula.Id,
                        ExisteBase = true,
                        EstaEliminado = false
                    });
                }
            }
        }

        private void ChkVerEliminados_CheckedChanged(object sender, EventArgs e)
        {
            Actualizar(chkVerEliminados.Checked);
        }

        private void CambiarCantidad_Click(object sender, EventArgs e)
        {
            if (_articulos.Count > 0 && _articuloFormulaSeleccionado != null)
            {
                var fCambiarCantidad = new CambiarCantidadFormula(_articuloFormulaSeleccionado);
                fCambiarCantidad.ShowDialog();

                _articuloFormulaSeleccionado = fCambiarCantidad.ArticuloFormula;

                Actualizar(chkVerEliminados.Checked);
            }
        }

        private void AgregarPerdida_Click(object sender, EventArgs e)
        {
            if (_articulos.Count > 0 && _articuloFormulaSeleccionado != null)
            {
                var fCargarPerdida = new CargarPerdidaPorFabricacion(_articuloFormulaSeleccionado);
                fCargarPerdida.ShowDialog();

                _articuloFormulaSeleccionado = fCargarPerdida.ArticuloFormula;

                Actualizar(chkVerEliminados.Checked);
            }
        }
    }
}
