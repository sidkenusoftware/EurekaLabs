using Serilog;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.Articulo;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.ConfiguracionCore;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.Proveedor;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Seguridad.Persona;
using Sidkenu.LogicaNegocio.Servicios.Interface.Core;
using Sidkenu.LogicaNegocio.Servicios.Interface.Seguridad;
using SidkenuWF.Formularios.Base;
using SidkenuWF.Formularios.Base.Constantes;
using SidkenuWF.Formularios.Core.LookUps;
using SidkenuWF.Formularios.Core.Model;
using SidkenuWF.Formularios.Core.Varios;

namespace SidkenuWF.Formularios.Core
{
    public partial class _00156_PedidoProveedor : FormularioComun
    {
        private readonly IArticuloServicio _articuloServicio;
        private readonly IProveedorServicio _proveedorServicio;
        private readonly IPersonaServicio _personaServicio;
        private readonly IConfiguracionCoreServicio _configuracionCoreServicio;
        private readonly IComprobanteServicio _comprobanteServicio;
        private readonly IArticuloProveedorServicio _articuloProveedorServicio;

        private PedidoVM _pedidoVM;

        private ProveedorDTO _proveedor;
        private PersonaDTO _empleado;
        private ArticuloDTO _articulo;
        private ConfiguracionCoreDTO _configuracionCore;

        private DetallePedidoVM? _itemSeleccinado;

        public _00156_PedidoProveedor()
        {
            InitializeComponent();

            Titulo = "Pedidos de Compra";
            TituloFormulario = FormularioConstantes.Titulo;
            Logo = FontAwesome.Sharp.IconChar.Truck;

            txtFecha.Text = DateTime.Now.ToShortDateString();

            this.KeyPreview = true; // Esto es importante para que el formulario capture los eventos de teclado
                                    // antes de que se envíen a los controles individuales
        }

        public _00156_PedidoProveedor(ISeguridadServicio seguridadServicio,
                                      IConfiguracionServicio configuracionServicio,
                                      ILogger logger,
                                      IArticuloServicio articuloServicio,
                                      IProveedorServicio proveedorServicio,
                                      IPersonaServicio personaServicio,
                                      IConfiguracionCoreServicio configuracionCoreServicio,
                                      IComprobanteServicio comprobanteServicio,
                                      IArticuloProveedorServicio articuloProveedorServicio)
                                      : base(seguridadServicio, configuracionServicio, logger)
        {
            InitializeComponent();

            Titulo = "Pedidos";

            TituloFormulario = FormularioConstantes.Titulo;
            Logo = FontAwesome.Sharp.IconChar.Truck;
            txtFecha.Text = DateTime.Now.ToShortDateString();

            _articuloServicio = articuloServicio;
            _proveedorServicio = proveedorServicio;
            _personaServicio = personaServicio;
            _configuracionCoreServicio = configuracionCoreServicio;
            _comprobanteServicio = comprobanteServicio;
            _articuloProveedorServicio = articuloProveedorServicio;

            this.KeyPreview = true;            
        }

        private void CargarDatos()
        {
            _proveedor = null;

            var configResult = _configuracionCoreServicio.Get(Properties.Settings.Default.EmpresaId);

            if (configResult != null && configResult.Data != null)
            {
                _configuracionCore = (ConfiguracionCoreDTO)configResult.Data;
            }
            else
            {
                _configuracionCore = null;
            }

            var resultEmpleado = _personaServicio.GetById(Properties.Settings.Default.PersonaLoginId);

            if (resultEmpleado.State)
            {
                _empleado = (PersonaDTO)resultEmpleado.Data;

                txtApyNomEmpleado.Text = $"{_empleado.NombreCompleto}";
            }
        }

        private void _00156_PedidoProveedor_Shown(object sender, EventArgs e)
        {
            CargarDatos();
            LimpiarParaNuevoPedido(_proveedor == null);
        }

        private void BtnBorrarProveedor_Click(object sender, EventArgs e)
        {
            _proveedor = null;

            txtNombreProveedor.Clear();
            txtCuitProveedor.Clear();
            txtTelefonoProveedor.Clear();
            txtDireccionProveedor.Clear();
        }

        private void BtnBuscarProveedor_Click(object sender, EventArgs e)
        {
            var formulario = new ProveedorLookUp(base._seguridadServicio,
                                                 base._configuracionServicio,
                                                 base._logger,
                                                 Program.Container.GetInstance<IProveedorServicio>());

            formulario.ShowDialog();

            if (formulario.SeleccionoEntidad)
            {
                _proveedor = (ProveedorDTO)formulario.Entidad;

                if (_proveedor != null)
                {
                    if (_pedidoVM.Detalles.Any())
                    {
                        if (MessageBox.Show("Si selecciona un proveedor se borraran los items cargados. Desea SELECCIONARLO ?", "Atencion",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            LimpiarParaNuevoPedido(true);
                        }
                    }

                    txtNombreProveedor.Text = _proveedor.RazonSocial;
                    txtCuitProveedor.Text = _proveedor.CUIT;
                    txtTelefonoProveedor.Text = _proveedor.Telefono;
                    txtDireccionProveedor.Text = _proveedor.Direccion;
                }
            }
        }

        private void LimpiarNuevoItem()
        {
            _articulo = null;

            txtBuscar.Clear();
            txtArticulo.Clear();

            txtBuscar.Clear();
            nudCantidad.Value = 1;

            txtBuscar.Focus();
        }

        private void LimpiarParaNuevoPedido(bool seleccionoProveedor)
        {
            _pedidoVM = new PedidoVM();

            _pedidoVM.Detalles.ItemAdded += Detalles_ItemAdded;
            _pedidoVM.Detalles.ItemRemoved += Detalles_ItemRemoved;

            ActualizarDatos();
            FormatearGrilla(dgvGrilla);
            LimpiarNuevoItem();
        }

        private void FormatearGrilla(DataGridView dgvGrilla)
        {
            dgvGrilla.Columns["ArticuloId"].Visible = false;
            dgvGrilla.Columns["ArticuloId"].DisplayIndex = 0;

            dgvGrilla.Columns["Codigo"].Visible = true;
            dgvGrilla.Columns["Codigo"].Width = 70;
            dgvGrilla.Columns["Codigo"].HeaderText = "Código";
            dgvGrilla.Columns["Codigo"].DisplayIndex = 1;
            dgvGrilla.Columns["Codigo"].ReadOnly = true;

            dgvGrilla.Columns["Descripcion"].Visible = true;
            dgvGrilla.Columns["Descripcion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvGrilla.Columns["Descripcion"].HeaderText = "Articulo";
            dgvGrilla.Columns["Descripcion"].DisplayIndex = 2;
            dgvGrilla.Columns["Descripcion"].ReadOnly = true;

            dgvGrilla.Columns["Cantidad"].Visible = true;
            dgvGrilla.Columns["Cantidad"].Width = 70;
            dgvGrilla.Columns["Cantidad"].HeaderText = "Cantidad";
            dgvGrilla.Columns["Cantidad"].DisplayIndex = 3;
            dgvGrilla.Columns["Cantidad"].ReadOnly = true;
            dgvGrilla.Columns["Cantidad"].DefaultCellStyle.Format = "N3";
            dgvGrilla.Columns["Cantidad"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvGrilla.Columns["PrecioCosto"].Visible = true;
            dgvGrilla.Columns["PrecioCosto"].Width = 120;
            dgvGrilla.Columns["PrecioCosto"].HeaderText = "Precio Costo";
            dgvGrilla.Columns["PrecioCosto"].DisplayIndex = 4;
            dgvGrilla.Columns["PrecioCosto"].ReadOnly = true;
            dgvGrilla.Columns["PrecioCosto"].DefaultCellStyle.Format = "C";
            dgvGrilla.Columns["PrecioCosto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgvGrilla.Columns["Impuesto"].Visible = true;
            dgvGrilla.Columns["Impuesto"].Width = 75;
            dgvGrilla.Columns["Impuesto"].HeaderText = "Imp %";
            dgvGrilla.Columns["Impuesto"].DisplayIndex = 5;
            dgvGrilla.Columns["Impuesto"].ReadOnly = true;
            dgvGrilla.Columns["Impuesto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvGrilla.Columns["Impuesto"].DefaultCellStyle.Format = "N2";

            dgvGrilla.Columns["SubTotal"].Visible = true;
            dgvGrilla.Columns["SubTotal"].Width = 120;
            dgvGrilla.Columns["SubTotal"].HeaderText = "Sub-Total";
            dgvGrilla.Columns["SubTotal"].DisplayIndex = 6;
            dgvGrilla.Columns["SubTotal"].ReadOnly = true;
            dgvGrilla.Columns["SubTotal"].DefaultCellStyle.Format = "C";
            dgvGrilla.Columns["SubTotal"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgvGrilla.Columns["EstaEliminado"].Visible = false;
            dgvGrilla.Columns["EstaEliminado"].DisplayIndex = 7;

            dgvGrilla.Columns["Id"].Visible = false;
            dgvGrilla.Columns["Id"].DisplayIndex = 7;
        }

        private void ActualizarDatos()
        {
            dgvGrilla.DataSource = _pedidoVM.Detalles.ToList();

            CalcularTotalizadores();
        }

        private void CalcularTotalizadores()
        {
            txtTotal.Text = _pedidoVM.Detalles.Sum(x => x.SubTotal).ToString("C");
        }

        private void Detalles_ItemRemoved(object? sender, ItemRemovedEventArgs<DetallePedidoVM> e)
        {
            ActualizarDatos();
        }

        private void Detalles_ItemAdded(object? sender, ItemAddedEventArgs<DetallePedidoVM> e)
        {
            ActualizarDatos();
        }

        private void DgvGrilla_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            btnCambiarCantidad.Visible = dgvGrilla.RowCount > 0;
            btnElimnarItem.Visible = dgvGrilla.RowCount > 0;

            cambiarCantidadMenuItem.Visible = dgvGrilla.RowCount > 0;
            eliminarItemMenuItem.Visible = dgvGrilla.RowCount > 0;
        }

        private void DgvGrilla_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            cambiarCantidadMenuItem.Visible = dgvGrilla.RowCount > 0;
            eliminarItemMenuItem.Visible = dgvGrilla.RowCount > 0;

            btnCambiarCantidad.Visible = dgvGrilla.RowCount > 0;
            btnElimnarItem.Visible = dgvGrilla.RowCount > 0;
        }

        private void DgvGrilla_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvGrilla.RowCount > 0)
            {
                _itemSeleccinado = (DetallePedidoVM)dgvGrilla.Rows[e.RowIndex].DataBoundItem;
            }
            else
            {
                _itemSeleccinado = null;
            }
        }

        private void TxtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
            }
        }

        private void BtnBuscarEmpleado_Click(object sender, EventArgs e)
        {
            var formulario = new EmpleadoLookUp(base._seguridadServicio,
                                                base._configuracionServicio,
                                                base._logger,
                                                Program.Container.GetInstance<IPersonaServicio>());

            formulario.ShowDialog();

            if (formulario.SeleccionoEntidad)
            {
                _empleado = (PersonaDTO)formulario.Entidad;

                if (_empleado != null)
                {
                    txtApyNomEmpleado.Text = _empleado.NombreCompleto;
                }
            }
        }

        private void Formulario_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.F7:
                    TeclaF7();
                    break;
                case Keys.F8:
                    TeclaF8();
                    break;
                case Keys.Enter:
                    TeclaEnter();
                    break;
            }
        }

        private void TeclaF8()
        {
            btnLimpiarPedido.PerformClick();
        }

        private void TeclaF7()
        {
            btnArticuloSugerido.PerformClick();
        }

        private void TeclaEnter()
        {
            if (txtBuscar.Focused) // Pregtunto si este control es el que tiene el foco
            {
                if (string.IsNullOrEmpty(txtBuscar.Text))
                {
                    MessageBox.Show("Ingrese un codigo por favor");
                    return;
                }

                var resultArticulo = _articuloServicio.GetByCodigoProveedor(_proveedor != null ? _proveedor.Id : Guid.Empty,
                                                                            txtBuscar.Text,
                                                                            Properties.Settings.Default.EmpresaId);

                if (resultArticulo != null && resultArticulo.Data != null)
                {
                    _articulo = (ArticuloDTO)resultArticulo.Data;

                    AgregarItemAlDetalle(_articulo);
                }
                else
                {
                    var formulario = new VentaArticuloLookUp(base._seguridadServicio,
                                                             base._configuracionServicio,
                                                             base._logger,
                                                             Program.Container.GetInstance<IArticuloServicio>());

                    formulario.ShowDialog();

                    if (formulario.SeleccionoEntidad)
                    {
                        if (formulario.Entidad != null)
                        {
                            _articulo = (ArticuloDTO)formulario.Entidad;

                            AgregarItemAlDetalle(_articulo);
                        }
                        else
                        {
                            MessageBox.Show("El articulo no EXISTE", "Atención");
                            LimpiarNuevoItem();
                            return;
                        }
                    }
                }
            }
        }

        private DetallePedidoVM? VerificarSiExisteItem(string codigo)
        {
            return _pedidoVM.Detalles.FirstOrDefault(x => x.Codigo == codigo);
        }

        private void BtnAgregarItem_Click(object sender, EventArgs e)
        {
            if (_articulo != null)
            {
                AddNewItem(_articulo, nudCantidad.Value);
            }
            else
            {
                MessageBox.Show("No selecciono ningun articulo");
                txtBuscar.Focus();
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            var formulario = new VentaArticuloLookUp(base._seguridadServicio,
                                                     base._configuracionServicio,
                                                     base._logger,
                                                     Program.Container.GetInstance<IArticuloServicio>());

            formulario.ShowDialog();

            if (formulario.SeleccionoEntidad)
            {
                _articulo = (ArticuloDTO)formulario.Entidad;

                AgregarItemAlDetalle(_articulo);
            }
        }

        private void NudCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnAgregarItem.PerformClick();
            }
        }

        private void CambiarCantidadItem_Click(object sender, EventArgs e)
        {
            if (dgvGrilla.RowCount > 0)
            {
                var fCambiarCantidad = new CambiarCantidadPuntoVenta(_itemSeleccinado.Descripcion, _itemSeleccinado.Cantidad);
                fCambiarCantidad.ShowDialog();

                if (fCambiarCantidad.RealizoAlgunCambio)
                {
                    _itemSeleccinado.Cantidad = fCambiarCantidad.Cantidad;
                    ActualizarDatos();
                }
            }
        }

        private void EliminarItem_Click(object sender, EventArgs e)
        {
            if (dgvGrilla.RowCount > 0)
            {
                if (MessageBox.Show("Esta seguro de Eliminar el Item seleccionado", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    == DialogResult.Yes)
                {
                    if (_itemSeleccinado != null)
                    {
                        var itemEliminar = _pedidoVM.Detalles.First(x => x.Id == _itemSeleccinado.Id);

                        _pedidoVM.Detalles.Remove(itemEliminar);

                        LimpiarNuevoItem();
                    }
                    else
                    {
                        MessageBox.Show("No hay ningun Item seleccionado", "Atención");
                        return;
                    }
                }
            }
        }


        private void AgregarItemAlDetalle(ArticuloDTO? articulo)
        {
            txtBuscar.Text = articulo.Codigo;
            txtArticulo.Text = articulo.Descripcion;

            nudCantidad.Select(0, nudCantidad.Text.Length);
            nudCantidad.Focus();
        }

        private void AddNewItem(ArticuloDTO articulo, decimal cantidad)
        {
            var detalle = VerificarSiExisteItem(articulo.Codigo);

            if (detalle != null)
            {
                detalle.Cantidad += cantidad;
            }
            else
            {
                CrearNuevoItem(articulo, cantidad);
            }

            ActualizarDatos();
            LimpiarNuevoItem();
        }


        private void CrearNuevoItem(ArticuloDTO articulo, decimal cantidadPrecio)
        {
            var newItem = new DetallePedidoVM
            {
                Id = Guid.NewGuid(),
                ArticuloId = articulo.Id,
                Cantidad = cantidadPrecio,
                Codigo = articulo.Codigo,
                Descripcion = articulo.Descripcion,
                EstaEliminado = false,
                Impuesto = articulo.PorcentajeCondicionIva,
                PrecioCosto = articulo.PrecioCosto,
            };

            _pedidoVM.Detalles.Add(newItem);
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void LimpiarPedido_Click(object sender, EventArgs e)
        {
            if (_pedidoVM.Detalles.Count != 0)
            {
                if (MessageBox.Show("Esta seguro de Borrar los articulos cargados en el Pedido", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    == DialogResult.Yes)
                {
                    LimpiarParaNuevoPedido(_proveedor == null);
                }
            }
        }

        private void ObtenerProductosSugeridos_Click(object sender, EventArgs e)
        {
            var result = _articuloProveedorServicio.GetArticulosSugeridos(_proveedor != null ? _proveedor.Id : null,
                Properties.Settings.Default.EmpresaId);

            if (result != null && result.State)
            {
                var listaResult = (List<ArticuloDTO>)result.Data;

                foreach (var articulo in listaResult.ToList())
                {
                    decimal cantidad = 1m;

                    if (articulo.StockMaximo > 0)
                    {
                        if (articulo.StockMaximo > articulo.PuntoPedido)
                        {
                            cantidad = articulo.StockMaximo - articulo.PuntoPedido;
                        }
                        else 
                        {
                            cantidad = articulo.StockMaximo;
                        }
                    }
                    else if (articulo.StockMinimo > 0)
                    {
                        cantidad = articulo.StockMinimo;
                    }

                    AddNewItem(articulo, cantidad);
                }
            }
        }

        private void BtnNuevoProveedor_Click(object sender, EventArgs e)
        {
            var fNuevoProveedor = new _00105_Proveedor_Abm(base._seguridadServicio,
                                                           base._configuracionServicio,
                                                           base._logger,
                                                           Program.Container.GetInstance<IProveedorServicio>(),
                                                           Program.Container.GetInstance<ITipoResponsabilidadServicio>(),
                                                           TipoOperacion.LlamadaExterna);

            FormularioSeguridad.VerificarAcceso(fNuevoProveedor, base._seguridadServicio, base._logger, base._configuracionDTO);

            if (fNuevoProveedor.RealizoAlgunaOperacion)
            {
                _proveedor = (ProveedorDTO)fNuevoProveedor.Entidad;

                txtNombreProveedor.Text = _proveedor.RazonSocial;
                txtCuitProveedor.Text = _proveedor.CUIT;
                txtTelefonoProveedor.Text = _proveedor.Telefono;
                txtDireccionProveedor.Text = _proveedor.Direccion;
            }
        }
    }
}
