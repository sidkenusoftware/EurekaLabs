using FontAwesome.Sharp;
using Serilog;
using Sidkenu.AccesoDatos.Constantes.Enum;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.Articulo;
using Sidkenu.LogicaNegocio.Servicios.Interface.Core;
using Sidkenu.LogicaNegocio.Servicios.Interface.Seguridad;
using SidkenuWF.Formularios.Base;
using SidkenuWF.Formularios.Base.Constantes;
using SidkenuWF.Formularios.Core.LookUps;

namespace SidkenuWF.Formularios.Core
{
    public partial class _00122_Articulo : FormularioConsulta
    {
        private readonly IArticuloServicio _articuloServicio;

        public _00122_Articulo(ISeguridadServicio seguridadServicio,
                               IConfiguracionServicio configuracionServicio,
                               ILogger logger,
                               IArticuloServicio articuloServicio)
                               : base(seguridadServicio, configuracionServicio, logger)
        {
            InitializeComponent();

            base.BotoneraLateralVisible = (true, true); // (Panel Botonera, Panel Abrir-Cerrar)
            base.MostrarContadorRegistros = false;
            base.TituloFormulario = FormularioConstantes.Titulo;
            base.Titulo = "Artículos";
            base.Logo = IconChar.BuildingFlag;

            _articuloServicio = articuloServicio;
        }

        public override bool EjecutarComandoNuevo(object sender, EventArgs e)
        {
            var formularioAbm = new _00123_Articulo_Abm(base._seguridadServicio,
                                                         base._configuracionServicio,
                                                         base._logger,
                                                         Program.Container.GetInstance<IArticuloServicio>(),
                                                         Program.Container.GetInstance<IFamiliaServicio>(),
                                                         Program.Container.GetInstance<IUnidadMedidaServicio>(),
                                                         Program.Container.GetInstance<IMarcaServicio>(),
                                                         Program.Container.GetInstance<ICondicionIvaServicio>(),
                                                         Program.Container.GetInstance<IProveedorServicio>(),
                                                         Program.Container.GetInstance<IArticuloProveedorServicio>(),
                                                         Program.Container.GetInstance<IDepositoServicio>(),
                                                         Program.Container.GetInstance<IListaPrecioServicio>(),
                                                         TipoOperacion.Nuevo);

            FormularioSeguridad.VerificarAcceso(formularioAbm, base._seguridadServicio, base._logger, base._configuracionDTO);

            return formularioAbm.RealizoAlgunaOperacion;
        }

        public override bool EjecutarComandoEditar(object sender, EventArgs e)
        {
            var formularioAbm = new _00123_Articulo_Abm(base._seguridadServicio,
                                                        base._configuracionServicio,
                                                        base._logger,
                                                        Program.Container.GetInstance<IArticuloServicio>(),
                                                        Program.Container.GetInstance<IFamiliaServicio>(),
                                                        Program.Container.GetInstance<IUnidadMedidaServicio>(),
                                                        Program.Container.GetInstance<IMarcaServicio>(),
                                                        Program.Container.GetInstance<ICondicionIvaServicio>(),
                                                        Program.Container.GetInstance<IProveedorServicio>(),
                                                        Program.Container.GetInstance<IArticuloProveedorServicio>(),
                                                        Program.Container.GetInstance<IDepositoServicio>(),
                                                        Program.Container.GetInstance<IListaPrecioServicio>(),
                                                        TipoOperacion.Modificar,
                                                        EntidadId);

            FormularioSeguridad.VerificarAcceso(formularioAbm, base._seguridadServicio, base._logger, base._configuracionDTO);

            return formularioAbm.RealizoAlgunaOperacion;
        }

        public override bool EjecutarComandoEliminar(object sender, EventArgs e)
        {
            try
            {
                _articuloServicio.Delete(new ArticuloDeleteDTO { Id = base.EntidadId.Value }, Properties.Settings.Default.UserLogin);

                return true;
            }
            catch
            {
                return false;
            }
        }

        public override void Buscar(string cadenaBuscar, bool verEliminados = false)
        {
            var result = _articuloServicio.GetByFilter(new ArticuloFilterDTO
            {
                CadenaBuscar = cadenaBuscar,
                VerEliminados = verEliminados,
                EmpresaId = Properties.Settings.Default.EmpresaId
            });

            if (result.State)
            {
                this.dgvGrilla.DataSource = result.Data;

                base.Buscar(cadenaBuscar, verEliminados);
            }
            else
            {
                if (base._configuracionDTO != null && base._configuracionDTO.LogError)
                {
                    _logger.Error($"{base.Titulo}: error al obtener los datos. User: {Properties.Settings.Default.PersonaLogin}");
                }

                MessageBox.Show("Ocurrió un error al obtener los datos");
            }
        }

        public override void FormatearDatos(DataGridView dgvGrilla)
        {
            try
            {
                base.FormatearDatos(dgvGrilla);

                dgvGrilla.Columns["Codigo"].Visible = true;
                dgvGrilla.Columns["Codigo"].Width = 80;
                dgvGrilla.Columns["Codigo"].HeaderText = "Código";
                dgvGrilla.Columns["Codigo"].DisplayIndex = 0;
                dgvGrilla.Columns["Codigo"].ReadOnly = true;

                dgvGrilla.Columns["Abreviatura"].Visible = true;
                dgvGrilla.Columns["Abreviatura"].Width = 80;
                dgvGrilla.Columns["Abreviatura"].HeaderText = "Abreviatura";
                dgvGrilla.Columns["Abreviatura"].DisplayIndex = 1;
                dgvGrilla.Columns["Abreviatura"].ReadOnly = true;

                dgvGrilla.Columns["CodigoBarra"].Visible = true;
                dgvGrilla.Columns["CodigoBarra"].Width = 100;
                dgvGrilla.Columns["CodigoBarra"].HeaderText = "Código de Barra";
                dgvGrilla.Columns["CodigoBarra"].DisplayIndex = 2;
                dgvGrilla.Columns["CodigoBarra"].ReadOnly = true;

                dgvGrilla.Columns["Descripcion"].Visible = true;
                dgvGrilla.Columns["Descripcion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvGrilla.Columns["Descripcion"].HeaderText = "Articulo";
                dgvGrilla.Columns["Descripcion"].DisplayIndex = 3;
                dgvGrilla.Columns["Descripcion"].ReadOnly = true;

                dgvGrilla.Columns["Marca"].Visible = true;
                dgvGrilla.Columns["Marca"].Width = 120;
                dgvGrilla.Columns["Marca"].HeaderText = "Marca";
                dgvGrilla.Columns["Marca"].DisplayIndex = 4;
                dgvGrilla.Columns["Marca"].ReadOnly = true;

                dgvGrilla.Columns["TipoArticulo"].Visible = true;
                dgvGrilla.Columns["TipoArticulo"].Width = 85;
                dgvGrilla.Columns["TipoArticulo"].HeaderText = "Tipo";
                dgvGrilla.Columns["TipoArticulo"].DisplayIndex = 5;
                dgvGrilla.Columns["TipoArticulo"].ReadOnly = true;

                dgvGrilla.Columns["PerfilArticulo"].Visible = true;
                dgvGrilla.Columns["PerfilArticulo"].Width = 85;
                dgvGrilla.Columns["PerfilArticulo"].HeaderText = "Perfil";
                dgvGrilla.Columns["PerfilArticulo"].DisplayIndex = 6;
                dgvGrilla.Columns["PerfilArticulo"].ReadOnly = true;

                dgvGrilla.Columns["PrecioCosto"].Visible = true;
                dgvGrilla.Columns["PrecioCosto"].Width = 85;
                dgvGrilla.Columns["PrecioCosto"].HeaderText = "Precio Costo";
                dgvGrilla.Columns["PrecioCosto"].DisplayIndex = 7;
                dgvGrilla.Columns["PrecioCosto"].ReadOnly = true;
                dgvGrilla.Columns["PrecioCosto"].DefaultCellStyle.Format = "C";
                dgvGrilla.Columns["PrecioCosto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                dgvGrilla.Columns["PrecioPublico"].Visible = true;
                dgvGrilla.Columns["PrecioPublico"].Width = 85;
                dgvGrilla.Columns["PrecioPublico"].HeaderText = "Precio Publico";
                dgvGrilla.Columns["PrecioPublico"].DisplayIndex = 8;
                dgvGrilla.Columns["PrecioPublico"].ReadOnly = true;
                dgvGrilla.Columns["PrecioPublico"].DefaultCellStyle.Format = "C";
                dgvGrilla.Columns["PrecioPublico"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                dgvGrilla.Columns["Stock"].Visible = true;
                dgvGrilla.Columns["Stock"].Width = 80;
                dgvGrilla.Columns["Stock"].HeaderText = "Stock";
                dgvGrilla.Columns["Stock"].DisplayIndex = 9;
                dgvGrilla.Columns["Stock"].ReadOnly = true;
                dgvGrilla.Columns["Stock"].DefaultCellStyle.Format = "N2";
                dgvGrilla.Columns["Stock"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                dgvGrilla.Columns["TieneProveedor"].Visible = true;
                dgvGrilla.Columns["TieneProveedor"].Width = 50;
                dgvGrilla.Columns["TieneProveedor"].HeaderText = "Prov";
                dgvGrilla.Columns["TieneProveedor"].DisplayIndex = 10;
                dgvGrilla.Columns["TieneProveedor"].ReadOnly = true;

                dgvGrilla.Columns["EstaBloqueado"].Visible = true;
                dgvGrilla.Columns["EstaBloqueado"].Width = 50;
                dgvGrilla.Columns["EstaBloqueado"].HeaderText = "Bloq";
                dgvGrilla.Columns["EstaBloqueado"].DisplayIndex = 11;
                dgvGrilla.Columns["EstaBloqueado"].ReadOnly = true;
            }
            catch (Exception ex)
            {
                if (base._configuracionDTO != null && base._configuracionDTO.LogError)
                {
                    _logger.Error(ex, $"Error en el formateo de las columnas en {base.Titulo}.");
                }

                MessageBox.Show("Los nombres de las columnas no coinciden");
            }
        }

        public override void EjecutarComandoRowEnter(object sender, DataGridViewCellEventArgs e)
        {
            base.EjecutarComandoRowEnter(sender, e);

            if (base.Entidad != null)
            {
                var _artSeleccionado = (ArticuloDTO)base.Entidad;

                btnVariantes.Visible = _artSeleccionado.TipoArticulo == TipoArticulo.Base;

                btnConfeccionarKit.Visible = _artSeleccionado.TipoArticulo == TipoArticulo.Kit;

                btnVerKit.Visible = _artSeleccionado.TipoArticulo == TipoArticulo.Kit
                                    && _artSeleccionado.ArticuloKits.Any();

                btnConfeccionarFormula.Visible = _artSeleccionado.TipoArticulo == TipoArticulo.Formula;

                btnVerFormula.Visible = _artSeleccionado.TipoArticulo == TipoArticulo.Formula
                                        && _artSeleccionado.ArticuloFormulas.Any();
            }
        }

        private void BtnVariantes_Click(object sender, EventArgs e)
        {
            if (dgvGrilla.Rows.Count > 0 && base.EntidadId.HasValue)
            {
                var _entidadSeleccionada = (ArticuloDTO)base.Entidad;

                var formulario = new _00132_ArticulosConVariantes(_entidadSeleccionada.Id,
                                                                  _entidadSeleccionada.Descripcion,
                                                                  Program.Container.GetInstance<IVarianteServicio>(),
                                                                  Program.Container.GetInstance<IArticuloVarianteServicio>());

                if (FormularioSeguridad.VerificarAccesoParaAbrirEnPanel(formulario, base._seguridadServicio, base._logger, base._configuracionDTO))
                {
                    formulario.ShowDialog();
                }

                Buscar(txtBuscar.Text);
            }
        }

        private void BtnVerStock_Click(object sender, EventArgs e)
        {
            if (base.Entidad != null)
            {
                var _artSeleccionado = (ArticuloDTO)base.Entidad;

                var fVerStock = new VerStockLookUp(_artSeleccionado);
                fVerStock.ShowDialog();
            }
        }

        private void BtnVerListaPrecio_Click(object sender, EventArgs e)
        {
            if (base.Entidad != null)
            {
                var _artSeleccionado = (ArticuloDTO)base.Entidad;

                var fVerListaPrecio = new VerListaPrecioLookUp(_artSeleccionado.ListaPrecios);
                fVerListaPrecio.ShowDialog();
            }
        }

        private void BtnConfeccionarKit_Click(object sender, EventArgs e)
        {
            if (base.Entidad != null)
            {
                var _artSeleccionado = (ArticuloDTO)base.Entidad;

                var formulario = new _00140_Confeccionarkit(base._seguridadServicio,
                                                            base._configuracionServicio,
                                                            base._logger,
                                                            Program.Container.GetInstance<IArticuloServicio>(),
                                                            _artSeleccionado,
                                                            Program.Container.GetInstance<IArticuloKitServicio>());

                if (FormularioSeguridad.VerificarAccesoParaAbrirEnPanel(formulario, base._seguridadServicio, base._logger, base._configuracionDTO))
                {
                    formulario.ShowDialog();
                }

                Buscar(txtBuscar.Text);
            }
        }

        private void BtnVerKit_Click(object sender, EventArgs e)
        {
            if (base.Entidad != null)
            {
                var _artSeleccionado = (ArticuloDTO)base.Entidad;

                var fVerKit = new VerKitLookUp(_artSeleccionado.ArticuloKits);
                fVerKit.ShowDialog();
            }
        }

        private void BtnConfeccionarFormula_Click(object sender, EventArgs e)
        {
            if (base.Entidad != null)
            {
                var _artSeleccionado = (ArticuloDTO)base.Entidad;

                var formulario = new _00141_ConfeccionarFormula(base._seguridadServicio,
                                                                base._configuracionServicio,
                                                                base._logger,
                                                                Program.Container.GetInstance<IArticuloServicio>(),
                                                                _artSeleccionado,
                                                                Program.Container.GetInstance<IArticuloFormulaServicio>());

                if (FormularioSeguridad.VerificarAccesoParaAbrirEnPanel(formulario, base._seguridadServicio, base._logger, base._configuracionDTO))
                {
                    formulario.ShowDialog();
                }

                Buscar(txtBuscar.Text);
            }
        }

        private void BtnVerFormula_Click(object sender, EventArgs e)
        {
            if (base.Entidad != null)
            {
                var _artSeleccionado = (ArticuloDTO)base.Entidad;

                var fVerKit = new VerFormulaLookUp(_artSeleccionado.ArticuloFormulas);
                fVerKit.ShowDialog();
            }
        }
    }
}
