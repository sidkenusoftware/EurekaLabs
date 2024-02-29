using Serilog;
using Sidkenu.AccesoDatos.Constantes;
using Sidkenu.AccesoDatos.Constantes.Enum;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.Articulo;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.Cliente;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.Comprobante;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.ConfiguracionBalanza;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.ConfiguracionCore;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.ListaPrecio;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.MedioPago;
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
    public partial class _00147_PuntoVentaMostrador : FormularioComun
    {
        private readonly IArticuloServicio _articuloServicio;
        private readonly IListaPrecioServicio _listaPrecioServicio;
        private readonly IClienteServicio _clienteServicio;
        private readonly IPersonaServicio _personaServicio;
        private readonly IConfiguracionCoreServicio _configuracionCoreServicio;
        private readonly IConfiguracionBalanzaServicio _configuracionBalanzaServicio;
        private readonly IComprobanteServicio _comprobanteServicio;

        private FacturaVM _facturaVM;

        private ClienteDTO _cliente;
        private PersonaDTO _vendedor;
        private ArticuloDTO _articulo;
        private ConfiguracionCoreDTO _configuracionCore;
        private ConfiguracionBalanzaDTO _configuracionBalanza;

        private bool _agregarItemModoManual;
        private bool _usaBalanza;

        private DetalleVM? _itemSeleccinado;

        private bool _clienteEsConsumidorFinal;

        private Thread relojThread;
        private bool relojActivo;

        public _00147_PuntoVentaMostrador()
        {
            InitializeComponent();

            Titulo = "Punto de Venta";
            TituloFormulario = FormularioConstantes.Titulo;
            Logo = FontAwesome.Sharp.IconChar.ShoppingCart;

            txtFecha.Text = DateTime.Now.ToShortDateString();

            this.KeyPreview = true; // Esto es importante para que el formulario capture los eventos de teclado
                                    // antes de que se envíen a los controles individuales

            _agregarItemModoManual = false;
            _usaBalanza = false;

            _clienteEsConsumidorFinal = true;
        }


        public _00147_PuntoVentaMostrador(ISeguridadServicio seguridadServicio,
                                          IConfiguracionServicio configuracionServicio,
                                          ILogger logger,
                                          IArticuloServicio articuloServicio,                                          
                                          IListaPrecioServicio listaPrecioServicio,
                                          IClienteServicio clienteServicio,
                                          IPersonaServicio personaServicio,
                                          IConfiguracionCoreServicio configuracionCoreServicio,
                                          IConfiguracionBalanzaServicio configuracionBalanzaServicio,
                                          IComprobanteServicio comprobanteServicio)
                                          : base(seguridadServicio, configuracionServicio, logger)
        {
            InitializeComponent();

            Titulo = "Punto de Venta";

            TituloFormulario = FormularioConstantes.Titulo;
            Logo = FontAwesome.Sharp.IconChar.ShoppingCart;
            txtFecha.Text = DateTime.Now.ToShortDateString();

            _articuloServicio = articuloServicio;
            _listaPrecioServicio = listaPrecioServicio;
            _clienteServicio = clienteServicio;
            _personaServicio = personaServicio;
            _configuracionCoreServicio = configuracionCoreServicio;
            _configuracionBalanzaServicio = configuracionBalanzaServicio;
            _comprobanteServicio = comprobanteServicio;

            _agregarItemModoManual = false;
        }


        private void CargarDatos()
        {
            nudDescuento.Enabled = true;

            var configResult = _configuracionCoreServicio.Get(Properties.Settings.Default.EmpresaId);

            if (configResult != null && configResult.Data != null)
            {
                _configuracionCore = (ConfiguracionCoreDTO)configResult.Data;
            }
            else
            {
                _configuracionCore = null;
            }

            var configBalanzaResult = _configuracionBalanzaServicio.Get(Properties.Settings.Default.EmpresaId);

            if (configBalanzaResult != null && configBalanzaResult.Data != null)
            {
                _configuracionBalanza = (ConfiguracionBalanzaDTO)configBalanzaResult.Data;
            }
            else
            {
                _configuracionBalanza = null;
            }

            var resultCliente = _clienteServicio.GetConsumidorFinal();

            if (resultCliente.State)
            {
                _cliente = (ClienteDTO)resultCliente.Data;

                txtApyNomCliente.Text = _cliente.RazonSocial;

                txtTelefonoCliente.Clear();
                txtDireccionCliente.Clear();
                txtDocumentoCliente.Clear();
            }

            var resultEmpleado = _personaServicio.GetById(Properties.Settings.Default.PersonaLoginId);

            if (resultEmpleado.State)
            {
                _vendedor = (PersonaDTO)resultEmpleado.Data;

                txtApyNomVendedor.Text = $"{_vendedor.NombreCompleto}";
            }

            var resultListaPrecio = _listaPrecioServicio.GetByFilter(new ListaPrecioFilterDTO
            {
                VerEliminados = false,
                CadenaBuscar = string.Empty,
                EmpresaId = Properties.Settings.Default.EmpresaId
            });

            if (resultListaPrecio == null || !resultListaPrecio.State)
            {
                MessageBox.Show("Ocurrio un error al Obtener las lista de precios", "Atención");
            }

            var _listaPrecios = (List<ListaPrecioDTO>)resultListaPrecio.Data;

            PoblarComboBox(cmbListaPrecio, _listaPrecios, "Descripcion", "Id");

            lblUltimoItem.Text = string.Empty;

            if (_listaPrecios.Count <= 0)
            {
                MessageBox.Show("No hay lista de Precios CARGADAS", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                ActivarControles(this, false);
            }
        }

        private void _00147_PuntoVentaMostrador_Load(object sender, EventArgs e)
        {
            LimpiarParaNuevaFactura();
        }

        private void LimpiarNuevoItem()
        {
            txtBuscar.Clear();

            txtArticulo.Clear();
            nudCantidad.Value = 1;

            _usaBalanza = false;
            imgOperacion.Visible = _usaBalanza;

            _agregarItemModoManual = false;
            pnlModoManual.Visible = false;

            txtBuscar.Focus();
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

            dgvGrilla.Columns["PrecioPublico"].Visible = true;
            dgvGrilla.Columns["PrecioPublico"].Width = 120;
            dgvGrilla.Columns["PrecioPublico"].HeaderText = "Precio Publico";
            dgvGrilla.Columns["PrecioPublico"].DisplayIndex = 4;
            dgvGrilla.Columns["PrecioPublico"].ReadOnly = true;
            dgvGrilla.Columns["PrecioPublico"].DefaultCellStyle.Format = "C";
            dgvGrilla.Columns["PrecioPublico"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgvGrilla.Columns["Descuento"].Visible = true;
            dgvGrilla.Columns["Descuento"].Width = 75;
            dgvGrilla.Columns["Descuento"].HeaderText = "Dto";
            dgvGrilla.Columns["Descuento"].DisplayIndex = 5;
            dgvGrilla.Columns["Descuento"].ReadOnly = true;
            dgvGrilla.Columns["Descuento"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvGrilla.Columns["Descuento"].DefaultCellStyle.Format = "N2";

            dgvGrilla.Columns["Impuesto"].Visible = true;
            dgvGrilla.Columns["Impuesto"].Width = 75;
            dgvGrilla.Columns["Impuesto"].HeaderText = "Imp %";
            dgvGrilla.Columns["Impuesto"].DisplayIndex = 6;
            dgvGrilla.Columns["Impuesto"].ReadOnly = true;
            dgvGrilla.Columns["Impuesto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvGrilla.Columns["Impuesto"].DefaultCellStyle.Format = "N2";

            dgvGrilla.Columns["SubTotal"].Visible = true;
            dgvGrilla.Columns["SubTotal"].Width = 120;
            dgvGrilla.Columns["SubTotal"].HeaderText = "Sub-Total";
            dgvGrilla.Columns["SubTotal"].DisplayIndex = 7;
            dgvGrilla.Columns["SubTotal"].ReadOnly = true;
            dgvGrilla.Columns["SubTotal"].DefaultCellStyle.Format = "C";
            dgvGrilla.Columns["SubTotal"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgvGrilla.Columns["EstaEliminado"].Visible = false;
            dgvGrilla.Columns["EstaEliminado"].DisplayIndex = 8;

            dgvGrilla.Columns["ListaPrecioId"].Visible = false;
            dgvGrilla.Columns["ListaPrecioId"].DisplayIndex = 9;

            dgvGrilla.Columns["TipoItem"].Visible = true;
            dgvGrilla.Columns["TipoItem"].Width = 70;
            dgvGrilla.Columns["TipoItem"].HeaderText = "Tipo";
            dgvGrilla.Columns["TipoItem"].DisplayIndex = 10;
            dgvGrilla.Columns["TipoItem"].ReadOnly = true;

            dgvGrilla.Columns["Id"].Visible = false;
            dgvGrilla.Columns["Id"].DisplayIndex = 11;
        }

        private void CalcularTotalizadores()
        {
            _facturaVM.Descuento = nudDescuento.Value;
            txtSubTotal.Text = _facturaVM.SubTotal.ToString("C");
            txtTotal.Text = _facturaVM.Total.ToString("C");
        }

        private void Detalles_ItemAdded(object sender, Model.ItemAddedEventArgs<DetalleVM> e)
        {
            lblUltimoItem.Text = $"{e.Item.Descripcion}  x  {e.Item.Cantidad.ToString("N3")}  =  {e.Item.SubTotal.ToString("C2")}";

            ActualizarDatos();
        }

        private void Detalles_ItemRemoved(object? sender, Model.ItemRemovedEventArgs<DetalleVM> e)
        {
            lblUltimoItem.Text = string.Empty;

            ActualizarDatos();
        }

        private void ActualizarDatos()
        {
            dgvGrilla.DataSource = _facturaVM.Detalles.ToList();

            CalcularTotalizadores();

            btnCambiarCantidad.Visible = false;
        }

        private void BtnAgregarItem_Click(object sender, EventArgs e)
        {
            _agregarItemModoManual = false;
            nudCantidad.Enabled = false;
            pnlModoManual.Visible = false;

            if (_articulo != null)
            {
                AgregarItemAlDetalle(_articulo, (Guid)cmbListaPrecio.SelectedValue, nudCantidad.Value, TipoItemFactura.Normal);
            }
        }

        private void NudDescuento_ValueChanged(object sender, EventArgs e)
        {
            CalcularTotalizadores();
        }
        private void BtnNuevoCliente_Click(object sender, EventArgs e)
        {
            var fNuevoCliente = new _00103_Cliente_Abm(base._seguridadServicio,
                                                       base._configuracionServicio,
                                                       base._logger,
                                                       Program.Container.GetInstance<IClienteServicio>(),
                                                       Program.Container.GetInstance<ITipoResponsabilidadServicio>(),
                                                       Program.Container.GetInstance<ITipoDocumentoServicio>(),
                                                       Program.Container.GetInstance<IListaPrecioServicio>(),
                                                       TipoOperacion.LlamadaExterna);

            FormularioSeguridad.VerificarAcceso(fNuevoCliente, base._seguridadServicio, base._logger, base._configuracionDTO);

            if (fNuevoCliente.RealizoAlgunaOperacion)
            {
                _cliente = (ClienteDTO)fNuevoCliente.Entidad;

                txtApyNomCliente.Text = _cliente.RazonSocial;
                txtDocumentoCliente.Text = _cliente.Documento;
                txtTelefonoCliente.Text = _cliente.Telefono;
                txtDireccionCliente.Text = _cliente.Direccion;

                if (_cliente.ListaPrecioId.HasValue)
                {
                    cmbListaPrecio.SelectedValue = _cliente.ListaPrecioId.Value;
                }

                if (_cliente.ActivarBonificacion)
                {
                    nudDescuento.Value = _cliente.Bonificacion.Value;
                }
            }
        }

        private void BtnBuscarCliente_Click(object sender, EventArgs e)
        {
            var formulario = new ClienteLookUp(base._seguridadServicio,
                                               base._configuracionServicio,
                                               base._logger,
                                               Program.Container.GetInstance<IClienteServicio>());

            formulario.ShowDialog();

            if (formulario.SeleccionoEntidad)
            {
                _cliente = (ClienteDTO)formulario.Entidad;

                if (_cliente != null)
                {
                    txtApyNomCliente.Text = _cliente.RazonSocial;
                    txtDocumentoCliente.Text = _cliente.Documento;
                    txtTelefonoCliente.Text = _cliente.Telefono;
                    txtDireccionCliente.Text = _cliente.Direccion;

                    _clienteEsConsumidorFinal = false;

                    if (_cliente.ListaPrecioId.HasValue)
                    {
                        cmbListaPrecio.SelectedValue = _cliente.ListaPrecioId.Value;
                    }

                    if (_cliente.ActivarBonificacion)
                    {
                        nudDescuento.Value = _cliente.Bonificacion.Value;
                    }
                }
            }
        }

        private void BtnBuscarVendedor_Click(object sender, EventArgs e)
        {
            var formulario = new EmpleadoLookUp(base._seguridadServicio,
                                               base._configuracionServicio,
                                               base._logger,
                                               Program.Container.GetInstance<IPersonaServicio>());

            formulario.ShowDialog();

            if (formulario.SeleccionoEntidad)
            {
                _vendedor = (PersonaDTO)formulario.Entidad;

                if (_vendedor != null)
                {
                    txtApyNomVendedor.Text = _vendedor.NombreCompleto;
                }
            }
        }

        private void _00147_PuntoVentaMostrador_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.F1:
                    TeclaF1();
                    break;
                case Keys.F2:
                    TeclaF2();
                    break;
                case Keys.F3:
                    TeclaF3();
                    break;
                case Keys.F4:
                    TeclaF4();
                    break;
                case Keys.F5:
                    TeclaF5_Facturar();
                    break;
                case Keys.F6:
                    TeclaF6_BuscarArticulo();
                    break;
                case Keys.F7:
                    TeclaF7_ArticulosNoExistentes();
                    break;
                case Keys.F8:
                    TeclaF8();
                    break;
                case Keys.F9:
                    TeclaF9_UsaBalanza();
                    break;
                case Keys.F10:
                    TeclaF10();
                    break;
                case Keys.F11:
                    TeclaF11_ActivarModoManual();
                    break;
                case Keys.F12:
                    TeclaF12();
                    break;
                case Keys.Enter:
                    TeclaEnter();
                    break;
            }
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

                // Balanza
                if (_usaBalanza)
                {
                    if (_configuracionBalanza != null && txtBuscar.Text.Length == _configuracionBalanza.LongitudTotal)
                    {
                        var datosBalanza = ParcearCodigoDeBarraBalanza(_configuracionBalanza, txtBuscar.Text);

                        var resultArticuloBalanza = _articuloServicio.GetByCodigo((Guid)cmbListaPrecio.SelectedValue,
                                                                       datosBalanza.Item1,
                                                                       Properties.Settings.Default.EmpresaId);

                        if (resultArticuloBalanza != null && resultArticuloBalanza.Data != null)
                        {
                            _articulo = (ArticuloDTO)resultArticuloBalanza.Data;

                            AgregarItemAlDetalle(_articulo, (Guid)cmbListaPrecio.SelectedValue, datosBalanza.Item2, TipoItemFactura.Balanza, datosBalanza.Item3);
                        }

                        return;
                    }
                }
                else
                {
                    // Sin Balanza

                    var resultArticulo = _articuloServicio.GetByCodigo((Guid)cmbListaPrecio.SelectedValue,
                                                                       txtBuscar.Text,
                                                                       Properties.Settings.Default.EmpresaId);

                    if (resultArticulo != null && resultArticulo.Data != null)
                    {
                        _articulo = (ArticuloDTO)resultArticulo.Data;

                        AgregarItemAlDetalle(_articulo, (Guid)cmbListaPrecio.SelectedValue, nudCantidad.Value, TipoItemFactura.Normal);
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

                                AgregarItemAlDetalle(_articulo, (Guid)cmbListaPrecio.SelectedValue, nudCantidad.Value, TipoItemFactura.Normal);
                            }
                            else
                            {
                                MessageBox.Show("El articulo no EXISTE", "Atención");
                                LimpiarNuevoItem();
                                return;
                            }
                        }
                        else
                        {
                            LimpiarNuevoItem();
                            return;
                        }
                    }
                }
            }
        }

        private (string, decimal, bool) ParcearCodigoDeBarraBalanza(ConfiguracionBalanzaDTO configuracionBalanza, string codigoBarra)
        {
            var tipo = codigoBarra.Substring(configuracionBalanza.InicioIdentificarTipo, configuracionBalanza.CantidadIdentificarTipo);
            var codigo = codigoBarra.Substring(configuracionBalanza.InicioIdentificarCodigoArcitulo, configuracionBalanza.CantidadIdentificarCodigoArcitulo).TrimStart('0');
            var precioPeso = codigoBarra.Substring(configuracionBalanza.InicioIdentificarImportePrecio, configuracionBalanza.CantidadIdentificarImportePrecio);

            if (tipo == configuracionBalanza.CodigoIdentificarImporte.ToString())
            {
                // Codigo de barra por Importe
                return (codigo, DecimalConvert.Parse(precioPeso, configuracionBalanza.DecimalesImporte), false);
            }

            if (tipo == configuracionBalanza.CodigoIdentificarPeso.ToString())
            {
                // Codigo de barra por Peso
                if (configuracionBalanza.ConvierteUnidadPeso)
                {
                    return (codigo, DecimalConvert.Parse(precioPeso, configuracionBalanza.DecimalPeso) * configuracionBalanza.Equivalencia, true);
                }
                else
                {
                    return (codigo, DecimalConvert.Parse(precioPeso, configuracionBalanza.DecimalPeso), true);
                }
            }

            return (string.Empty, 0, false);
        }



        private void AgregarItemAlDetalle(ArticuloDTO? articulo, Guid listaPrecioId, decimal cantidadPrecio, TipoItemFactura tipoItem, bool esCantidad = true)
        {
            if (articulo.EstaBloqueado)
            {
                MessageBox.Show($"El Articulo {articulo.Descripcion.ToUpper()} no se encuentra disponible para la Venta en este Momento", "Atención",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarNuevoItem();
                return;
            }

            if (articulo.NecesitaAutorizacion)
            {
                var fAuto = new Autorizacion(Program.Container.GetInstance<ICuentaServicio>(),
                    Program.Container.GetInstance<IUsuarioServicio>());

                fAuto.ShowDialog();

                if (!fAuto.EstaAutorizado)
                {
                    MessageBox.Show("No se pudo Autorizar el Articulo", "Atención");
                    LimpiarNuevoItem();
                    return;
                }
            }

            if (articulo.FamiliaActivarRestriccionHoraVenta
                && !VerificarRestriccionHoraVentaPorFamilia(articulo))
            {
                MessageBox.Show($"El Articulo {articulo.Descripcion} tiene RESTRICCION HORARIA DE VENTA");
                LimpiarNuevoItem();
                return;
            }

            if (!_agregarItemModoManual)
            {
                AddNewItem(_articulo, cantidadPrecio, listaPrecioId, tipoItem, esCantidad);
            }
            else
            {
                txtArticulo.Text = articulo.Descripcion;

                nudCantidad.Enabled = _agregarItemModoManual;
                nudCantidad.Select(0, nudCantidad.Value.ToString().Length);
                nudCantidad.Focus();
            }
        }

        private bool VerificarRestriccionHoraVentaPorFamilia(ArticuloDTO articulo)
        {
            var puedeVender = true;

            if (articulo.FamiliaRestriccionHoraVentaDesde.HasValue
                && articulo.FamiliaRestriccionHoraVentaHasta.HasValue)
            {
                if (articulo.FamiliaRestriccionHoraVentaHasta.Value.Date
                    > articulo.FamiliaRestriccionHoraVentaDesde.Value.Date)
                {
                    // Fecha Fin en distintos dias
                    var _dateTimeInicio = new DateTime(articulo.FamiliaRestriccionHoraVentaDesde.Value.Date.Year,
                                                       articulo.FamiliaRestriccionHoraVentaDesde.Value.Date.Month,
                                                       articulo.FamiliaRestriccionHoraVentaDesde.Value.Date.Day, 0, 0, 0);

                    var _dateTimeFin = new DateTime(articulo.FamiliaRestriccionHoraVentaHasta.Value.Date.Year,
                                                    articulo.FamiliaRestriccionHoraVentaHasta.Value.Date.Month,
                                                    articulo.FamiliaRestriccionHoraVentaHasta.Value.Date.Day, 23, 59, 59);

                    if ((DateTime.Now >= articulo.FamiliaRestriccionHoraVentaDesde.Value
                        && DateTime.Now <= _dateTimeFin)
                        || (DateTime.Now >= _dateTimeInicio
                        && DateTime.Now <= _articulo.FamiliaRestriccionHoraVentaHasta.Value))
                    {
                        puedeVender = false;
                    }
                }
                else
                {
                    // Fecha Fin Mismo dia
                    if (DateTime.Now >= articulo.FamiliaRestriccionHoraVentaDesde.Value
                        && DateTime.Now <= articulo.FamiliaRestriccionHoraVentaHasta.Value)
                    {
                        puedeVender = false;
                    }
                }
            }

            return puedeVender;
        }

        private bool VerificarAumentoPrecioHoraVentaPorFamilia(ArticuloDTO articulo)
        {
            var tieneAumentoPrecio = true;

            if (articulo.FamiliaAumentoPrecioHoraVentaDesde.HasValue
                && articulo.FamiliaAumentoPrecioHoraVentaHasta.HasValue)
            {
                if (articulo.FamiliaAumentoPrecioHoraVentaHasta.Value.Date
                    > articulo.FamiliaAumentoPrecioHoraVentaDesde.Value.Date)
                {
                    // Fecha Fin en distintos dias
                    var _dateTimeInicio = new DateTime(articulo.FamiliaAumentoPrecioHoraVentaDesde.Value.Date.Year,
                                                       articulo.FamiliaAumentoPrecioHoraVentaDesde.Value.Date.Month,
                                                       articulo.FamiliaAumentoPrecioHoraVentaDesde.Value.Date.Day, 0, 0, 0);

                    var _dateTimeFin = new DateTime(articulo.FamiliaAumentoPrecioHoraVentaHasta.Value.Date.Year,
                                                    articulo.FamiliaAumentoPrecioHoraVentaHasta.Value.Date.Month,
                                                    articulo.FamiliaAumentoPrecioHoraVentaHasta.Value.Date.Day, 23, 59, 59);

                    if ((DateTime.Now >= articulo.FamiliaAumentoPrecioHoraVentaDesde.Value
                        && DateTime.Now <= _dateTimeFin)
                        || (DateTime.Now >= _dateTimeInicio
                        && DateTime.Now <= _articulo.FamiliaAumentoPrecioHoraVentaHasta.Value))
                    {
                        tieneAumentoPrecio = false;
                    }
                }
                else
                {
                    // Fecha Fin Mismo dia
                    if (DateTime.Now >= articulo.FamiliaAumentoPrecioHoraVentaDesde.Value
                        && DateTime.Now <= articulo.FamiliaAumentoPrecioHoraVentaHasta.Value)
                    {
                        tieneAumentoPrecio = false;
                    }
                }
            }

            return tieneAumentoPrecio;
        }

        private void AddNewItem(ArticuloDTO articulo, decimal cantidadPrecio, Guid listaPrecioId, TipoItemFactura tipoItem, bool esCantidad = true)
        {
            var cantidad = esCantidad ? cantidadPrecio : 1;

            if (!articulo.PermiteStockNegativo)
            {
                if (!VerificarSiTieneStock(articulo, cantidad))
                {
                    MessageBox.Show("NO hay Stock suficiente", "Atención");

                    if (articulo.TipoArticulo == TipoArticulo.Formula)
                    {
                        if (MessageBox.Show($"Desea Fabricar el Articulo {articulo.Descripcion}", "Atención",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            CrearNuevoItem(articulo, cantidadPrecio, listaPrecioId, TipoItemFactura.Fabricacion, esCantidad);
                            ActualizarDatos();
                        }
                    }

                    LimpiarNuevoItem();
                    return;
                }
            }

            if (articulo.ActivarLimiteVenta
                && articulo.LimiteVenta.HasValue)
            {
                if (VerificarSiSobrepasaLimiteVenta(articulo, cantidad))
                {
                    MessageBox.Show($"El articulo {articulo.Descripcion} tiene un LIMITE de VENTA{Environment.NewLine}por FACTURA de {articulo.LimiteVenta.Value.ToString("N2")}", "Atención");
                    LimpiarNuevoItem();
                    return;
                }
            }

            if (!_configuracionCore.UnificarRenglonesIngresarMismoArticulo)
            {
                CrearNuevoItem(articulo, cantidadPrecio, listaPrecioId, tipoItem, esCantidad);
            }
            else
            {
                if (!_usaBalanza)
                {
                    var detalle = VerificarSiExisteItem(articulo.Codigo, listaPrecioId);

                    if (detalle != null)
                    {
                        detalle.Cantidad += cantidad;
                    }
                    else
                    {
                        CrearNuevoItem(articulo, cantidadPrecio, listaPrecioId, tipoItem, esCantidad);
                    }
                }
                else
                {
                    CrearNuevoItem(articulo, cantidadPrecio, listaPrecioId, tipoItem, esCantidad);
                }
            }

            ActualizarDatos();
            LimpiarNuevoItem();
        }

        private bool VerificarSiSobrepasaLimiteVenta(ArticuloDTO articulo, decimal cantidad)
        {
            var cantidadEnDetalleFactura = _facturaVM.Detalles.Where(x => x.Codigo == articulo.Codigo).Sum(x => x.Cantidad);

            return cantidad + cantidadEnDetalleFactura > articulo.LimiteVenta.Value;
        }

        private bool VerificarSiTieneStock(ArticuloDTO articulo, decimal cantidad)
        {
            var cantidadEnDetalleFactura = _facturaVM.Detalles.Where(x => x.Codigo == articulo.Codigo).Sum(x => x.Cantidad);

            return articulo.Stock >= (cantidadEnDetalleFactura + cantidad);
        }

        private void CrearNuevoItem(ArticuloDTO articulo, decimal cantidadPrecio, Guid listaPrecioId, TipoItemFactura tipoItem, bool esCantidad = true)
        {
            var precioVenta = esCantidad ? articulo.PrecioPublico : cantidadPrecio;

            if (articulo.FamiliaActivarAumentoPrecioHoraVenta
                && articulo.FamiliaAumentoPrecioHoraVenta.HasValue
                && VerificarAumentoPrecioHoraVentaPorFamilia(articulo))
            {
                precioVenta = articulo.FamiliaTipoValorHoraVenta.HasValue
                    ? articulo.FamiliaTipoValorHoraVenta.Value == TipoValor.Valor
                      ? precioVenta + articulo.FamiliaAumentoPrecioHoraVenta.Value
                      : precioVenta + Porcentaje.Calcular(precioVenta, articulo.FamiliaAumentoPrecioHoraVenta.Value)
                    : precioVenta;
            }

            if (articulo.FamiliaActivarAumentoPrecioVenta
                && articulo.FamiliaAumentoPrecioVenta.HasValue)
            {
                precioVenta = articulo.FamiliaTipoValorVenta.HasValue
                    ? articulo.FamiliaTipoValorVenta.Value == TipoValor.Valor
                      ? precioVenta + articulo.FamiliaAumentoPrecioVenta.Value
                      : precioVenta + Porcentaje.Calcular(precioVenta, articulo.FamiliaAumentoPrecioVenta.Value)
                    : precioVenta;
            }

            if (articulo.MarcaActivarAumentoPrecioVenta
                && articulo.MarcaAumentoPrecioVenta.HasValue)
            {
                precioVenta = articulo.MarcaTipoValorVenta.HasValue
                    ? articulo.MarcaTipoValorVenta.Value == TipoValor.Valor
                      ? precioVenta + articulo.MarcaAumentoPrecioVenta.Value
                      : precioVenta + Porcentaje.Calcular(precioVenta, articulo.MarcaAumentoPrecioVenta.Value)
                    : precioVenta;
            }

            var newItem = new DetalleVM
            {
                Id = Guid.NewGuid(),
                ArticuloId = articulo.Id,
                Cantidad = esCantidad ? cantidadPrecio : 1,
                Codigo = articulo.Codigo,
                Descripcion = articulo.Descripcion,
                Descuento = articulo.ActivarBonificacion && VerificarRangoFechaBonificacion(articulo.BonificacionFechaDesde, articulo.BonificacionFechaHasta)
                            ? articulo.Bonificacion.Value : 0,
                EstaEliminado = false,
                Impuesto = articulo.PorcentajeCondicionIva,
                ListaPrecioId = listaPrecioId,
                PrecioPublico = precioVenta,
                TipoItem = tipoItem,
                DetalleItems = new MyListViewModel<Model.PuntoVenta.DetalleTemporalVM>()
            };

            foreach (var _articuloFormula in articulo.ArticuloFormulas.ToList())
            {
                newItem.DetalleItems.Add(new Model.PuntoVenta.DetalleTemporalVM
                {
                    ArticuloId = _articuloFormula.ArticuloHijoId,
                    Cantidad = _articuloFormula.Cantidad,
                    Codigo = _articuloFormula.Codigo,
                    Descripcion = _articuloFormula.Descripcion,
                    EstaEliminado = false,
                    Id = _articuloFormula.Id,
                    PrecioPublico = 0,
                });
            }

            _facturaVM.Detalles.Add(newItem);
        }

        private bool VerificarRangoFechaBonificacion(DateTime? bonificacionFechaDesde, DateTime? bonificacionFechaHasta)
        {
            var tieneBonificacion = false;

            if (bonificacionFechaDesde.HasValue
                && bonificacionFechaHasta.HasValue)
            {
                if (bonificacionFechaDesde.Value.Date >= DateTime.Now.Date
                    && bonificacionFechaHasta.Value.Date <= DateTime.Now.Date)
                {
                    tieneBonificacion = true;
                }
            }
            else
            {
                tieneBonificacion = true;
            }

            return tieneBonificacion;
        }

        private DetalleVM? VerificarSiExisteItem(string codigo, Guid listaPrecioId)
        {
            return _facturaVM.Detalles.FirstOrDefault(x => x.Codigo == codigo && x.ListaPrecioId == listaPrecioId
                                                      && (x.TipoItem != TipoItemFactura.Balanza
                                                          || x.TipoItem != TipoItemFactura.Fabricacion));
        }

        private void TeclaF1()
        {

        }

        private void TeclaF2()
        {

        }

        private void TeclaF3()
        {

        }

        private void TeclaF4()
        {

        }

        private void TeclaF5_Facturar()
        {
            btnFacturar.PerformClick();
        }

        private void TeclaF6_BuscarArticulo()
        {
            btnBuscar.PerformClick();
        }

        private void TeclaF7_ArticulosNoExistentes()
        {
            var fNuevoProductoInexistente = new AgregarArticulosFabricacion(base._seguridadServicio,
                                                                            base._configuracionServicio,
                                                                            base._logger,
                                                                            Program.Container.GetInstance<IContadorServicio>(),
                                                                            Program.Container.GetInstance<IArticuloServicio>(),
                                                                            (Guid)cmbListaPrecio.SelectedValue);

            fNuevoProductoInexistente.ShowDialog();

            if (fNuevoProductoInexistente.RealizoAlgunaOperacion)
            {
                _facturaVM.Detalles.Add(fNuevoProductoInexistente.Detalle);
            }
        }

        private void TeclaF8()
        {

        }

        private void TeclaF9_UsaBalanza()
        {
            if (!_agregarItemModoManual)
            {
                _usaBalanza = !_usaBalanza;
                imgOperacion.Visible = _usaBalanza;
                txtBuscar.Focus();
            }
            else
            {
                MessageBox.Show("Si esta activo el Modo Manual NO se puede usar la Balanza");
            }
        }

        private void TeclaF10()
        {

        }

        private void TeclaF11_ActivarModoManual()
        {
            if (!_usaBalanza)
            {
                _agregarItemModoManual = !_agregarItemModoManual;
                pnlModoManual.Visible = _agregarItemModoManual;
                nudCantidad.Enabled = _agregarItemModoManual;
            }
            else
            {
                MessageBox.Show("Si esta activo el Modo Balanza NO se puede Ingresar Manualmente la Cantidad");
            }
        }

        private void TeclaF12()
        {
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

                AgregarItemAlDetalle(_articulo, (Guid)cmbListaPrecio.SelectedValue, nudCantidad.Value, TipoItemFactura.Normal);
            }
        }

        private void NudCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                AgregarItemAlDetalle(_articulo, (Guid)cmbListaPrecio.SelectedValue, nudCantidad.Value, TipoItemFactura.Normal);
            }
        }

        private void CambiarCantidadToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void DgvGrilla_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            cambiarCantidadMenuItem.Visible = dgvGrilla.RowCount > 0;
            eliminarItemMenuItem.Visible = dgvGrilla.RowCount > 0;
        }

        private void DgvGrilla_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            cambiarCantidadMenuItem.Visible = dgvGrilla.RowCount > 0;
            eliminarItemMenuItem.Visible = dgvGrilla.RowCount > 0;

            btnCambiarCantidad.Visible = dgvGrilla.RowCount > 0;
            btnElimnarItem.Visible = dgvGrilla.RowCount > 0;
            btnVerDetalle.Visible = dgvGrilla.RowCount > 0;
        }

        private void DgvGrilla_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            btnElimnarItem.Visible = dgvGrilla.RowCount > 0;

            if (dgvGrilla.RowCount > 0)
            {
                _itemSeleccinado = (DetalleVM)dgvGrilla.Rows[e.RowIndex].DataBoundItem;

                cambiarCantidadMenuItem.Visible = _itemSeleccinado.TipoItem != TipoItemFactura.Balanza;

                btnCambiarCantidad.Visible = _itemSeleccinado.TipoItem != TipoItemFactura.Balanza
                    && _itemSeleccinado.TipoItem != TipoItemFactura.Fabricacion;

                btnVerDetalle.Visible = _itemSeleccinado.TipoItem == TipoItemFactura.Fabricacion;
            }
            else
            {
                _itemSeleccinado = null;

                cambiarCantidadMenuItem.Visible = false;
                btnCambiarCantidad.Visible = false;
            }
        }

        private void EliminarItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvGrilla.RowCount > 0)
            {
                if (MessageBox.Show("Esta seguro de Eliminar el Item seleccionado", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    == DialogResult.Yes)
                {
                    if (_itemSeleccinado != null)
                    {
                        var itemEliminar = _facturaVM.Detalles.First(x => x.Id == _itemSeleccinado.Id);

                        _facturaVM.Detalles.Remove(itemEliminar);

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

        private void TxtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
            }
        }

        private void BtnVerDetalle_Click(object sender, EventArgs e)
        {
            if (_itemSeleccinado != null)
            {
                var fVerDetalleItem = new VerDetalleItem(_itemSeleccinado.DetalleItems);
                fVerDetalleItem.ShowDialog();
            }
        }

        private void BtnFacturar_Click(object sender, EventArgs e)
        {
            var cajaaaa = Properties.Settings.Default.CajaId;

            if (_facturaVM.Detalles.Count <= 0)
            {
                MessageBox.Show($"Debe ingreser al menos un Articulo para poder Facturar", "Atención",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBuscar.Clear();
                txtBuscar.Focus();
                return;
            }

            if (_configuracionCore.PedirAutorizacionDescuento)
            {
                if (_configuracionCore.DescuentoAutorizacion >= nudDescuento.Value)
                {
                    MessageBox.Show($"El descuento ingresado {nudDescuento.Value.ToString("P")} debe ser autorizado.", "Atención",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    var fAutorizacion = new Autorizacion(Program.Container.GetInstance<ICuentaServicio>(),
                        Program.Container.GetInstance<IUsuarioServicio>());

                    fAutorizacion.ShowDialog();

                    if (!fAutorizacion.EstaAutorizado)
                    {
                        return;
                    }
                }
            }

            var _comprobante = AsignarDatos();

            if (!_configuracionCore.SepararPuntoVentaCaja)
            {
                var fMediosDePagos = new _00148_FormaPago(base._seguridadServicio,
                                                          base._configuracionServicio,
                                                          base._logger,
                                                          Program.Container.GetInstance<ITarjetaServicio>(),
                                                          Program.Container.GetInstance<IPlanTarjetaServicio>(),
                                                          Program.Container.GetInstance<IConfiguracionCoreServicio>(),
                                                          Program.Container.GetInstance<IComprobanteServicio>(),
                                                          Program.Container.GetInstance<ICajaServicio>(),
                                                          _comprobante);

                fMediosDePagos.ShowDialog();

                if (fMediosDePagos.RealizoAlgunaOperacion)
                {
                    LimpiarParaNuevaFactura();
                }
            }
            else
            {
                try
                {
                    _comprobante.EmpresaId = Properties.Settings.Default.EmpresaId;

                    _comprobante.MedioPagos.Add(new MedioPagoDTO
                    {
                        Capital = 0m,
                        EstaEliminado = false,
                        EstaSeleccionado = false,
                        Interes = 0m,
                        Tipo = TipoMedioDePago.PendienteDePago
                    });

                    var resultComprobante = _comprobanteServicio.AddOrUpdate(_comprobante, Properties.Settings.Default.UserLogin);

                    if (resultComprobante != null && resultComprobante.State)
                    {
                        MessageBox.Show(resultComprobante.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LimpiarParaNuevaFactura();
                    }
                }
                catch (Exception ex)
                {
                    if (base._configuracionDTO != null && base._configuracionDTO != null && base._configuracionDTO.LogError)
                    {
                        _logger.Error(ex, $"Error al Insertar Factura. User: {Properties.Settings.Default.PersonaLogin}. Datos: {AsignarDatos().GetPropValue()}");
                    }
                }
            }
        }

        private void LimpiarParaNuevaFactura()
        {
            CargarDatos();

            _facturaVM = new FacturaVM();

            _facturaVM.Detalles.ItemAdded += Detalles_ItemAdded;
            _facturaVM.Detalles.ItemRemoved += Detalles_ItemRemoved;

            ActualizarDatos();
            CalcularTotalizadores();
            FormatearGrilla(dgvGrilla);
            LimpiarNuevoItem();
        }

        private ComprobanteVentaDTO AsignarDatos()
        {
            var _comprobanteNuevo = new ComprobanteVentaDTO
            {
                Cliente = _cliente,
                Persona = _vendedor,
                Fecha = DateTime.Now,
                SubTotal = _facturaVM.SubTotal,
                Descuento = _facturaVM.Descuento,
                Total = _facturaVM.Total,
                EstaEliminado = false,
                EstaPagado = false,
                TipoComprobante = TipoComprobante.Venta,
                CajaId = Properties.Settings.Default.CajaId,
                CajaDetalleId = Properties.Settings.Default.CajaDetalleId,
            };

            foreach (var detalle in _facturaVM.Detalles)
            {
                var _detalleNuevo = new ComprobanteDetalleDTO
                {
                    ArticuloId = detalle.ArticuloId,
                    ListaPrecioId = detalle.ListaPrecioId,
                    Codigo = detalle.Codigo,
                    Descripcion = detalle.Descripcion,
                    Cantidad = detalle.Cantidad,
                    PrecioPublico = detalle.PrecioPublico,
                    Descuento = detalle.Descuento,
                    Impuesto = detalle.Impuesto,
                    SubTotal = detalle.SubTotal,
                    TipoItem = detalle.TipoItem,
                    Foto = detalle.Foto,
                    FechaEntrega = detalle.FechaEntrega,
                    CodigoFabricacion = detalle.CodigoFabricacion,
                };

                if (detalle.TipoItem == TipoItemFactura.Fabricacion)
                {
                    foreach (var item in detalle.DetalleItems)
                    {
                        var _itemNuevo = new ComprobanteDetalleFabricacionDTO
                        {
                            ArticuloId = item.ArticuloId,
                            Cantidad = item.Cantidad,
                            Codigo = item.Codigo,
                            Descripcion = item.Descripcion,
                            EstaEliminado = item.EstaEliminado,
                            PrecioPublico = item.PrecioPublico,
                            SubTotal = item.SubTotal,
                            Id = item.Id,
                        };

                        _detalleNuevo.FabricacionDetalles.Add(_itemNuevo);
                    }
                }

                _comprobanteNuevo.Detalles.Add(_detalleNuevo);
            }

            return _comprobanteNuevo;
        }

        private void BtnBorrarCliente_Click(object sender, EventArgs e)
        {
            var resultCliente = _clienteServicio.GetConsumidorFinal();

            if (resultCliente.State)
            {
                _cliente = (ClienteDTO)resultCliente.Data;

                txtApyNomCliente.Text = _cliente.RazonSocial;

                txtTelefonoCliente.Clear();
                txtDireccionCliente.Clear();
                txtDocumentoCliente.Clear();

                _clienteEsConsumidorFinal = true;
            }
        }

        private void BtnCargarArticuloFabricacion_Click(object sender, EventArgs e)
        {
            TeclaF7_ArticulosNoExistentes();
        }

        private void BtnActivarBalanza_Click(object sender, EventArgs e)
        {
            TeclaF9_UsaBalanza();
        }

        private void BtnActivarModoManual_Click(object sender, EventArgs e)
        {
            TeclaF11_ActivarModoManual();
        }
    }
}
