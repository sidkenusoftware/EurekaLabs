using Serilog;
using Sidkenu.AccesoDatos.Constantes;
using Sidkenu.AccesoDatos.Constantes.Enum;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Base;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.Articulo;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.ArticuloProveedor;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.Proveedor;
using Sidkenu.LogicaNegocio.Servicios.Interface.Core;
using Sidkenu.LogicaNegocio.Servicios.Interface.Seguridad;
using SidkenuWF.Formularios.Base;
using SidkenuWF.Formularios.Base.Constantes;
using SidkenuWF.Formularios.Core.LookUps;
using SidkenuWF.Formularios.Core.Varios;
using SidkenuWF.Helpers;

namespace SidkenuWF.Formularios.Core
{
    public partial class _00123_Articulo_Abm : FormularioAbm
    {
        private readonly IArticuloServicio _articuloServicio;

        private readonly IFamiliaServicio _familiaServicio;
        private readonly IUnidadMedidaServicio _unidadMedidaServicio;
        private readonly IMarcaServicio _marcaServicio;
        private readonly ICondicionIvaServicio _condicionIvaServicio;
        private readonly IProveedorServicio _proveedorServicio;
        private readonly IArticuloProveedorServicio _articuloProveedorServicio;
        private readonly IDepositoServicio _depositoServicio;
        private readonly IListaPrecioServicio _listaPrecioServicio;

        private ProveedorDTO? _proveedorSeleccionadoLookup;

        private List<ArticuloProveedorDTO> _listaProveedores;
        private ArticuloProveedorDTO _articuloProveedorSeleccionado;

        private Guid? _articuloId;

        public _00123_Articulo_Abm(ISeguridadServicio seguridadServicio,
                                    IConfiguracionServicio configuracionServicio,
                                    ILogger logger,
                                    IArticuloServicio articuloServicio,
                                    IFamiliaServicio familiaServicio,
                                    IUnidadMedidaServicio unidadMedidaServicio,
                                    IMarcaServicio marcaServicio,
                                    ICondicionIvaServicio condicionIvaServicio,
                                    IProveedorServicio proveedorServicio,
                                    IArticuloProveedorServicio articuloProveedorServicio,
                                    IDepositoServicio depositoServicio,
                                    IListaPrecioServicio listaPrecioServicio,
                                    TipoOperacion tipoOperacion,
                                    Guid? entidadId = null)
                                    : base(seguridadServicio, configuracionServicio, logger, tipoOperacion, entidadId)
        {
            InitializeComponent();

            base.TituloFormulario = FormularioConstantes.Titulo;
            base.Titulo = $"Productos / {Enum.GetName(typeof(TipoOperacion), tipoOperacion)}";

            _articuloServicio = articuloServicio;
            _familiaServicio = familiaServicio;
            _unidadMedidaServicio = unidadMedidaServicio;
            _marcaServicio = marcaServicio;
            _condicionIvaServicio = condicionIvaServicio;
            _proveedorServicio = proveedorServicio;
            _articuloProveedorServicio = articuloProveedorServicio;
            _depositoServicio = depositoServicio;
            _listaPrecioServicio = listaPrecioServicio;

            AgregarControlesObligatorios(txtDescripcion, "Producto");
            AgregarControlesObligatorios(txtCodigo, "Codigo");
            AgregarControlesObligatorios(txtCodigoBarra, "Codigo de Barras");
            AgregarControlesObligatorios(txtAbreviatura, "Abreviatura");
            AgregarControlesObligatorios(cmbFamilia, "Familia");
            AgregarControlesObligatorios(cmbMarca, "Marca");
            AgregarControlesObligatorios(cmbTipoArticulo, "Tipo de Articulo");
            AgregarControlesObligatorios(cmbPerfilArticulo, "Perfil del Articulo");
            AgregarControlesObligatorios(cmbUnidadMedidaVenta, "Unidad de Medida para la Venta");
            AgregarControlesObligatorios(cmbUnidadMedidaCompra, "Unidad de Medida para la Compra");
            AgregarControlesObligatorios(cmbCondicionIva, "Condición de Iva");

            if (tipoOperacion == TipoOperacion.Nuevo)
            {
                base.AgregarControlesObligatorios(cmbDeposito, "Deposito");
                base.AgregarControlesObligatorios(cmbListaPrecio, "Lista de Precio");
            }

            txtCodigo.KeyPress += Validacion.NoInyeccion;
            txtDescripcion.KeyPress += Validacion.NoInyeccion;
            txtDescripcionAdicional.KeyPress += Validacion.NoInyeccion;
            txtCodigoBarra.KeyPress += Validacion.NoInyeccion;
            txtAbreviatura.KeyPress += Validacion.NoInyeccion;
            txtDetalle.KeyPress += Validacion.NoInyeccion;
            txtProveedor.KeyPress += Validacion.NoInyeccion;

            ctrolFoto.ActivarAvatar = false;

            _listaProveedores = new List<ArticuloProveedorDTO>();
            _proveedorSeleccionadoLookup = null;
            _articuloProveedorSeleccionado = new ArticuloProveedorDTO();

            Inicio();
        }

        private void Inicio()
        {
            chkEmpresa.Checked = false;

            chkTienePerdida.Checked = false;
            nudPerdida.Enabled = false;
            nudPerdida.Value = 0;

            chkBloquear.Checked = false;

            chkPermiteStockNegativo.Checked = false;

            nudComision.Value = 0;

            chkActivarLimiteVenta.Checked = false;
            nudLimiteVenta.Enabled = false;
            nudLimiteVenta.Value = 0;

            chkBonificacion.Checked = false;
            nudBonificacion.Enabled = false;
            nudBonificacion.Value = 0;
            cmbTipoBonificacion.Enabled = false;
            chkActivarFechaBonificacion.Enabled = false;
            chkActivarFechaBonificacion.Checked = false;
            dtpFechaBonificacionDesde.Enabled = false;
            dtpFechaBonificacionHasta.Enabled = false;

            chkTieneGarantia.Checked = false;
            nudGarantia.Enabled = false;
            nudGarantia.Value = 0;

            nudStockMaximo.Value = 0;
            nudStockMinimo.Value = 0;
            nudPuntoPedido.Value = 0;

            nudPrecioCostoInicial.Value = 0;
            nudStockInicial.Value = 0;

            chkRentabilidad.Checked = false;
            nudRentabilidad.Value = 0;

            chkSolicitarAutorizacion.Checked = false;

            _listaProveedores.Clear();

            dgvProveedor.DataSource = ObtenerProveedores();
        }

        public override void EjecutarComandoFormLoad(object sender, EventArgs e)
        {
            CargarDatos(base.TipoOperacion, base.EntidadId, null);
        }

        public override void CargarDatos(TipoOperacion tipoOperacion, Guid? entidadId, Guid? entidadSecundariaId)
        {
            // Familias
            var resultFamilia = _familiaServicio.GetAll(Properties.Settings.Default.EmpresaId);

            if (resultFamilia != null && resultFamilia.State)
            {
                PoblarComboBox(cmbFamilia, resultFamilia.Data, "Descripcion", "Id");
            }

            // Unidad de Medidas
            var resultUnidadMedidaVenta = _unidadMedidaServicio.GetAll(Properties.Settings.Default.EmpresaId);

            if (resultUnidadMedidaVenta != null && resultUnidadMedidaVenta.State)
            {
                PoblarComboBox(cmbUnidadMedidaVenta, resultUnidadMedidaVenta.Data, "Descripcion", "Id");
            }

            var resultUnidadMedidaCompra = _unidadMedidaServicio.GetAll(Properties.Settings.Default.EmpresaId);

            if (resultUnidadMedidaCompra != null && resultUnidadMedidaCompra.State)
            {
                PoblarComboBox(cmbUnidadMedidaCompra, resultUnidadMedidaCompra.Data, "Descripcion", "Id");
            }

            // Marca
            var resultMarca = _marcaServicio.GetAll(Properties.Settings.Default.EmpresaId);

            if (resultMarca != null && resultMarca.State)
            {
                PoblarComboBox(cmbMarca, resultMarca.Data, "Descripcion", "Id");
            }

            var listaDeTiposParaExcluir = new List<EnumDTO>
            {
                new EnumDTO
                {
                    Valor = TipoArticulo.Variante,
                    Descripcion = "Variante"
                }
            };

            PoblarComboBox(cmbPerfilArticulo, EnumDescription.GetAll<PerfilArticulo>(), "Descripcion", "Valor");

            // Condicion de Iva
            var resultCondicionIva = _condicionIvaServicio.GetAll(Properties.Settings.Default.EmpresaId);

            if (resultCondicionIva != null && resultCondicionIva.State)
            {
                PoblarComboBox(cmbCondicionIva, resultCondicionIva.Data, "Descripcion", "Id");
            }

            // Deposito
            var resultDeposito = _depositoServicio.GetAll(Properties.Settings.Default.EmpresaId);

            if (resultDeposito != null && resultDeposito.State)
            {
                PoblarComboBox(cmbDeposito, resultDeposito.Data, "Descripcion", "Id");
            }

            // Condicion de Iva
            var resultListaPrecio = _listaPrecioServicio.GetAll(Properties.Settings.Default.EmpresaId);

            if (resultListaPrecio != null && resultListaPrecio.State)
            {
                PoblarComboBox(cmbListaPrecio, resultListaPrecio.Data, "Descripcion", "Id");
            }

            PoblarComboBox(cmbTipoBonificacion, EnumDescription.GetAll<TipoValor>(), "Descripcion", "Valor");


            if (entidadId != null && entidadId.Value != Guid.Empty)
            {
                tabControlArticulo.TabPages.Remove(pageInventario);

                var resultEntidad = _articuloServicio.GetById(entidadId.Value, Properties.Settings.Default.EmpresaId);

                if (resultEntidad.State)
                {
                    pageInventario.Hide();

                    base.Entidad = (ArticuloDTO)resultEntidad.Data;
                    var _entidad = (ArticuloDTO)resultEntidad.Data;

                    if (_entidad.TipoArticulo == TipoArticulo.Variante)
                    {
                        PoblarComboBox(cmbTipoArticulo, EnumDescription.GetAll<TipoArticulo>(), "Descripcion", "Valor");
                    }
                    else
                    {
                        PoblarComboBox(cmbTipoArticulo, EnumDescription.GetAll<TipoArticulo>(listaDeTiposParaExcluir), "Descripcion", "Valor");
                    }

                    _articuloId = _entidad.ArticuloId;

                    txtDescripcion.Text = _entidad.Descripcion;
                    txtDescripcionAdicional.Text = _entidad.DescripcionAdicional;

                    chkEmpresa.Checked = _entidad.EmpresaId.HasValue;

                    // Datos Generales
                    txtCodigo.Text = _entidad.Codigo;
                    txtCodigoBarra.Text = _entidad.CodigoBarra;
                    txtAbreviatura.Text = _entidad.Abreviatura;
                    ctrolFoto.Imagen = ImagenConvert.Convertir_Bytes_Imagen(_entidad.Foto);

                    if (cmbFamilia.Items.Count > 0)
                    {
                        cmbFamilia.SelectedValue = _entidad.FamiliaId;
                    }

                    if (cmbMarca.Items.Count > 0)
                    {
                        cmbMarca.SelectedValue = _entidad.MarcaId;
                    }

                    cmbTipoArticulo.SelectedValue = _entidad.TipoArticulo;

                    cmbPerfilArticulo.SelectedValue = _entidad.PerfilArticulo;



                    chkTienePerdida.Checked = _entidad.TienePerdida;
                    nudPerdida.Enabled = _entidad.TienePerdida;
                    nudPerdida.Value = _entidad.TienePerdida
                        && _entidad.PorcentajePerdida.HasValue
                        ? _entidad.PorcentajePerdida.Value
                        : 0;

                    chkBloquear.Checked = _entidad.EstaBloqueado;

                    chkEmpresa.Checked = _entidad.EmpresaId.HasValue;

                    chkFacturacionPorImporte.Checked = _entidad.FacturacionPorImporte;

                    // Detalle

                    txtDetalle.Text = _entidad.Detalle;

                    // Venta 

                    if (cmbCondicionIva.Items.Count > 0)
                    {
                        cmbCondicionIva.SelectedValue = _entidad.CondicionIvaId;
                    }

                    if (cmbUnidadMedidaVenta.Items.Count > 0)
                    {
                        cmbUnidadMedidaVenta.SelectedValue = _entidad.UnidadMedidaVentaId;
                    }

                    chkPermiteStockNegativo.Checked = _entidad.PermiteStockNegativo;

                    nudComision.Value = _entidad.Comision.HasValue ? _entidad.Comision.Value : 0;

                    chkActivarLimiteVenta.Checked = _entidad.ActivarLimiteVenta;
                    nudLimiteVenta.Enabled = _entidad.ActivarLimiteVenta;
                    nudLimiteVenta.Value = _entidad.ActivarLimiteVenta && _entidad.LimiteVenta.HasValue ? _entidad.LimiteVenta.Value : 0;

                    chkBonificacion.Checked = _entidad.ActivarBonificacion;
                    nudBonificacion.Enabled = _entidad.ActivarBonificacion;
                    nudBonificacion.Value = _entidad.ActivarBonificacion && _entidad.Bonificacion.HasValue ? _entidad.Bonificacion.Value : 0;
                    cmbTipoBonificacion.SelectedValue = _entidad.ActivarBonificacion && _entidad.TipoBonificacion.HasValue ? _entidad.TipoBonificacion.Value : TipoValor.Valor;
                    chkActivarFechaBonificacion.Checked = _entidad.BonificacionFechaDesde.HasValue;

                    dtpFechaBonificacionDesde.Enabled = _entidad.BonificacionFechaDesde.HasValue;
                    dtpFechaBonificacionDesde.Value = _entidad.BonificacionFechaDesde.HasValue ? _entidad.BonificacionFechaDesde.Value : DateTime.Now;

                    dtpFechaBonificacionHasta.Enabled = _entidad.BonificacionFechaHasta.HasValue;
                    dtpFechaBonificacionHasta.Value = _entidad.BonificacionFechaHasta.HasValue ? _entidad.BonificacionFechaHasta.Value : DateTime.Now;

                    chkTieneGarantia.Checked = _entidad.TieneGarantia;
                    nudGarantia.Enabled = _entidad.TieneGarantia;
                    nudGarantia.Value = _entidad.TieneGarantia && _entidad.Garantia.HasValue ? _entidad.Garantia.Value : 0;

                    chkRentabilidad.Checked = _entidad.TieneRentabilidad;
                    nudRentabilidad.Value = _entidad.TieneRentabilidad ? _entidad.Rentabilidad.Value : 0;

                    chkSolicitarAutorizacion.Checked = _entidad.NecesitaAutorizacion;

                    // Compras

                    if (cmbUnidadMedidaCompra.Items.Count > 0)
                    {
                        cmbUnidadMedidaCompra.SelectedValue = _entidad.UnidadMedidaCompraId;
                    }

                    nudStockMaximo.Value = _entidad.StockMaximo;
                    nudStockMinimo.Value = _entidad.StockMinimo;
                    nudPuntoPedido.Value = _entidad.PuntoPedido;

                    _listaProveedores = _entidad.ArticuloProveedores;

                    chkPermiteMostrarLaFormula.Checked = _entidad.PermiteMostrarFormula;
                    chkPermiteMostrarLaFormula.Visible = _entidad.TipoArticulo == TipoArticulo.Formula;
                    lblPermiteVerFormula.Visible = _entidad.TipoArticulo == TipoArticulo.Formula;
                }
            }
            else
            {
                chkPermiteMostrarLaFormula.Visible = false;
                lblPermiteVerFormula.Visible = false;

                PoblarComboBox(cmbTipoArticulo, EnumDescription.GetAll<TipoArticulo>(listaDeTiposParaExcluir), "Descripcion", "Valor");
            }

            dgvProveedor.DataSource = ObtenerProveedores();

            FormatearGrillaProveedores(dgvProveedor);
        }

        private void FormatearGrillaProveedores(DataGridView dgvGrilla)
        {
            try
            {
                for (int i = 0; i < dgvGrilla.ColumnCount; i++)
                {
                    dgvGrilla.Columns[i].Visible = false;
                }

                dgvGrilla.Columns["Proveedor"].Visible = true;
                dgvGrilla.Columns["Proveedor"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvGrilla.Columns["Proveedor"].HeaderText = "Proveedor";
                dgvGrilla.Columns["Proveedor"].DisplayIndex = 0;
                dgvGrilla.Columns["Proveedor"].ReadOnly = true;

                dgvGrilla.Columns["Cuit"].Visible = true;
                dgvGrilla.Columns["Cuit"].Width = 150;
                dgvGrilla.Columns["Cuit"].HeaderText = "CUIT";
                dgvGrilla.Columns["Cuit"].DisplayIndex = 1;
                dgvGrilla.Columns["Cuit"].ReadOnly = true;

                dgvGrilla.Columns["CodigoProveedor"].Visible = true;
                dgvGrilla.Columns["CodigoProveedor"].Width = 100;
                dgvGrilla.Columns["CodigoProveedor"].HeaderText = "Codigo";
                dgvGrilla.Columns["CodigoProveedor"].DisplayIndex = 2;
                dgvGrilla.Columns["CodigoProveedor"].ReadOnly = true;
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

        public override ResultDTO EjecutarComandoInsert()
        {
            try
            {
                if (!VerificarDatosObligatorios())
                {
                    return new ResultDTO
                    {
                        State = false,
                        Message = "Por favor ingrese los campos Obligatorios."
                    };
                }
                var registro = AsignarDatos();

                var result = _articuloServicio.Add(registro, Properties.Settings.Default.UserLogin);

                return result;
            }
            catch (Exception ex)
            {
                if (base._configuracionDTO != null && base._configuracionDTO != null && base._configuracionDTO.LogError)
                {
                    _logger.Error(ex, $"Error al INSERTAR en {base.Titulo}. User: {Properties.Settings.Default.PersonaLogin}. Datos: {AsignarDatos().GetPropValue()}");
                }

                return new ResultDTO
                {
                    State = false,
                    Message = ex.InnerException == null ? ex.Message : ex.InnerException.Message
                };
            }
        }

        public override ResultDTO EjecutarComandoUpdate()
        {
            try
            {
                if (!VerificarDatosObligatorios())
                {
                    return new ResultDTO
                    {
                        State = false,
                        Message = "Por favor ingrese los campos Obligatorios."
                    };
                }
                var registro = AsignarDatos();

                var result = _articuloServicio.Update(registro, Properties.Settings.Default.UserLogin);

                if (result.State)
                {
                    if (base._configuracionDTO != null && base._configuracionDTO != null && base._configuracionDTO.LogInformacion)
                    {
                        _logger.Information($"Se ACTUALIZO Datos: {AsignarDatos().GetPropValue()}. User: {Properties.Settings.Default.PersonaLogin}");
                    }
                }

                return result;
            }
            catch (Exception ex)
            {
                if (base._configuracionDTO != null && base._configuracionDTO != null && base._configuracionDTO.LogError)
                {
                    _logger.Error(ex, $"Error al ACTUALIZAR en {base.Titulo}. User: {Properties.Settings.Default.PersonaLogin}. Datos: {AsignarDatos().GetPropValue()}");
                }

                return new ResultDTO
                {
                    State = false,
                    Message = ex.InnerException == null ? ex.Message : ex.InnerException.Message
                };
            }
        }

        private ArticuloPersistenciaDTO AsignarDatos()
        {
            var _entidad = new ArticuloPersistenciaDTO
            {
                Id = EntidadId ?? Guid.Empty,

                ArticuloId = TipoOperacion == TipoOperacion.Modificar ? _articuloId.Value : Guid.Empty,

                EmpresaId = Properties.Settings.Default.EmpresaId,
                SeleccionoEmpresa = chkEmpresa.Checked,

                // Datos Generales

                Descripcion = txtDescripcion.Text,
                DescripcionAdicional = txtDescripcionAdicional.Text,
                Codigo = txtCodigo.Text,
                CodigoBarra = txtCodigoBarra.Text,
                Abreviatura = txtAbreviatura.Text,
                Foto = ImagenConvert.Convertir_Imagen_Bytes(ctrolFoto.Imagen),
                FamiliaId = (Guid)cmbFamilia.SelectedValue,
                MarcaId = (Guid)cmbMarca.SelectedValue,
                TipoArticulo = (TipoArticulo)cmbTipoArticulo.SelectedValue,
                PerfilArticulo = (PerfilArticulo)cmbPerfilArticulo.SelectedValue,
                TienePerdida = chkTienePerdida.Checked,
                PorcentajePerdida = chkTienePerdida.Checked ? nudPerdida.Value : null,
                EstaBloqueado = chkBloquear.Checked,
                FacturacionPorImporte = chkFacturacionPorImporte.Checked,
                PermiteMostrarFormula = chkPermiteMostrarLaFormula.Checked,

                // Detalle

                Detalle = txtDetalle.Text,

                // Venta

                CondicionIvaId = (Guid)cmbCondicionIva.SelectedValue,
                UnidadMedidaVentaId = (Guid)cmbUnidadMedidaVenta.SelectedValue,
                Comision = nudComision.Value,
                PermiteStockNegativo = chkPermiteStockNegativo.Checked,
                ActivarLimiteVenta = chkActivarLimiteVenta.Checked,
                LimiteVenta = chkActivarLimiteVenta.Checked ? nudLimiteVenta.Value : null,

                ActivarBonificacion = chkBonificacion.Checked,
                Bonificacion = chkBonificacion.Checked ? nudBonificacion.Value : null,
                BonificacionFechaDesde = chkBonificacion.Checked ? (chkActivarFechaBonificacion.Checked ? dtpFechaBonificacionDesde.Value : null) : null,
                BonificacionFechaHasta = chkBonificacion.Checked ? (chkActivarFechaBonificacion.Checked ? dtpFechaBonificacionHasta.Value : null) : null,
                TipoBonificacion = (TipoValor)cmbTipoBonificacion.SelectedValue,
                TieneGarantia = chkTieneGarantia.Checked,
                Garantia = chkTieneGarantia.Checked ? (int)nudGarantia.Value : null,
                TieneRentabilidad = chkRentabilidad.Checked,
                Rentabilidad = nudRentabilidad.Value,
                NecesitaAutorizacion = chkSolicitarAutorizacion.Checked,

                // Compra

                UnidadMedidaCompraId = (Guid)cmbUnidadMedidaCompra.SelectedValue,
                StockMaximo = nudStockMaximo.Value,
                StockMinimo = nudStockMinimo.Value,
                PuntoPedido = nudPuntoPedido.Value,

                // Compra - Proveedores

                ArticuloProveedores = _listaProveedores,
            };

            // Inventario

            if (base.TipoOperacion == TipoOperacion.Nuevo)
            {
                _entidad.DepositoId = (Guid)cmbDeposito.SelectedValue;
                _entidad.StockInicial = nudStockInicial.Value;
                _entidad.ListaPrecioId = (Guid)cmbListaPrecio.SelectedValue;
                _entidad.PrecioCostoInicial = nudPrecioCostoInicial.Value;
            }

            this.Entidad = _entidad;

            return _entidad;
        }

        public override void OperacionAdicionalFinalizarInsert()
        {
            Inicio();
            tabControlArticulo.SelectedIndex = 0;
            txtDescripcion.Focus();
        }

        private void _00123_Articulo_Abm_Load(object sender, EventArgs e)
        {

        }

        private void BtnNuevaFamilia_Click(object sender, EventArgs e)
        {
            var formulario = new _00125_Familia_Abm(base._seguridadServicio,
                                                    base._configuracionServicio,
                                                    Program.Container.GetInstance<IConfiguracionCoreServicio>(),
                                                    base._logger,
                                                    Program.Container.GetInstance<IFamiliaServicio>(),
                                                    TipoOperacion.Nuevo);

            FormularioSeguridad.VerificarAcceso(formulario, _seguridadServicio, _logger, _configuracionDTO);

            if (formulario.RealizoAlgunaOperacion)
            {
                var resultFamilia = _familiaServicio.GetAll(Properties.Settings.Default.EmpresaId);

                if (resultFamilia != null && resultFamilia.State)
                {
                    PoblarComboBox(cmbFamilia, resultFamilia.Data, "Descripcion", "Id");
                }
            }
        }

        private void BtnNuevaMarca_Click(object sender, EventArgs e)
        {
            var formulario = new _00127_Marca_Abm(base._seguridadServicio,
                                                    base._configuracionServicio,
                                                    base._logger,
                                                    Program.Container.GetInstance<IMarcaServicio>(),
                                                    Program.Container.GetInstance<IConfiguracionCoreServicio>(),
                                                    TipoOperacion.Nuevo);

            FormularioSeguridad.VerificarAcceso(formulario, _seguridadServicio, _logger, _configuracionDTO);

            if (formulario.RealizoAlgunaOperacion)
            {
                var resultMarca = _marcaServicio.GetAll(Properties.Settings.Default.EmpresaId);

                if (resultMarca != null && resultMarca.State)
                {
                    PoblarComboBox(cmbMarca, resultMarca.Data, "Descripcion", "Id");
                }
            }
        }

        private void BtnNuevaCondicionIva_Click(object sender, EventArgs e)
        {
            var formulario = new _00129_CondicionIva_Abm(base._seguridadServicio,
                                                    base._configuracionServicio,
                                                    base._logger,
                                                    Program.Container.GetInstance<ICondicionIvaServicio>(),
                                                    TipoOperacion.Nuevo);

            FormularioSeguridad.VerificarAcceso(formulario, _seguridadServicio, _logger, _configuracionDTO);

            if (formulario.RealizoAlgunaOperacion)
            {
                var resultCondicionIva = _condicionIvaServicio.GetAll(Properties.Settings.Default.EmpresaId);

                if (resultCondicionIva != null && resultCondicionIva.State)
                {
                    PoblarComboBox(cmbMarca, resultCondicionIva.Data, "Descripcion", "Id");
                }
            }
        }

        private void BtnNuevaUnidadMedida_Click(object sender, EventArgs e)
        {
            var formulario = new _00131_UnidadMedida_Abm(base._seguridadServicio,
                                                    base._configuracionServicio,
                                                    base._logger,
                                                    Program.Container.GetInstance<IUnidadMedidaServicio>(),
                                                    TipoOperacion.Nuevo);

            FormularioSeguridad.VerificarAcceso(formulario, _seguridadServicio, _logger, _configuracionDTO);

            if (formulario.RealizoAlgunaOperacion)
            {
                var resultUnidadMedidaVenta = _unidadMedidaServicio.GetAll(Properties.Settings.Default.EmpresaId);

                if (resultUnidadMedidaVenta != null && resultUnidadMedidaVenta.State)
                {
                    PoblarComboBox(cmbUnidadMedidaVenta, resultUnidadMedidaVenta.Data, "Descripcion", "Id");
                }

                var resultUnidadMedidaCompra = _unidadMedidaServicio.GetAll(Properties.Settings.Default.EmpresaId);

                if (resultUnidadMedidaCompra != null && resultUnidadMedidaCompra.State)
                {
                    PoblarComboBox(cmbUnidadMedidaCompra, resultUnidadMedidaCompra.Data, "Descripcion", "Id");
                }
            }
        }

        private void ChkTienePerdida_CheckedChanged(object sender, EventArgs e)
        {
            nudPerdida.Enabled = chkTienePerdida.Checked;
            nudPerdida.Value = 0;

            if (base.TipoOperacion != TipoOperacion.Nuevo && chkTienePerdida.Checked)
            {
                nudPerdida.Value = ((ArticuloDTO)base.Entidad).PorcentajePerdida.HasValue
                    ? ((ArticuloDTO)base.Entidad).PorcentajePerdida.Value : 0;
            }

            nudPerdida.Focus();
        }

        private void ChkActivarLimiteVenta_CheckedChanged(object sender, EventArgs e)
        {
            nudLimiteVenta.Enabled = chkActivarLimiteVenta.Checked;

            nudLimiteVenta.Value = 0;

            if (base.TipoOperacion != TipoOperacion.Nuevo && chkActivarLimiteVenta.Checked)
            {
                nudLimiteVenta.Value = ((ArticuloDTO)base.Entidad).LimiteVenta.HasValue
                    ? ((ArticuloDTO)base.Entidad).LimiteVenta.Value : 0;
            }

            nudLimiteVenta.Focus();
        }

        private void ChkBonificacion_CheckedChanged(object sender, EventArgs e)
        {
            nudBonificacion.Enabled = chkBonificacion.Checked;

            nudBonificacion.Value = 0;

            if (base.TipoOperacion != TipoOperacion.Nuevo && chkBonificacion.Checked)
            {
                nudBonificacion.Value = ((ArticuloDTO)base.Entidad).Bonificacion.HasValue
                    ? ((ArticuloDTO)base.Entidad).Bonificacion.Value : 0;
            }

            nudBonificacion.Focus();

            cmbTipoBonificacion.Enabled = chkBonificacion.Checked;
            chkActivarFechaBonificacion.Enabled = chkBonificacion.Checked;
        }

        private void ChkTieneGarantia_CheckedChanged(object sender, EventArgs e)
        {
            nudGarantia.Enabled = chkTieneGarantia.Checked;

            nudGarantia.Value = 0;

            if (base.TipoOperacion != TipoOperacion.Nuevo && chkTieneGarantia.Checked)
            {
                nudGarantia.Value = ((ArticuloDTO)base.Entidad).Garantia.HasValue
                    ? ((ArticuloDTO)base.Entidad).Garantia.Value : 0;
            }

            nudGarantia.Focus();
        }

        private void ChkActivarFechaBonificacion_CheckedChanged(object sender, EventArgs e)
        {
            dtpFechaBonificacionDesde.Enabled = chkActivarFechaBonificacion.Checked;
            dtpFechaBonificacionHasta.Enabled = chkActivarFechaBonificacion.Checked;

            dtpFechaBonificacionDesde.Value = DateTime.Now;
            dtpFechaBonificacionHasta.Value = DateTime.Now;

            if (base.TipoOperacion != TipoOperacion.Nuevo && chkActivarFechaBonificacion.Checked)
            {
                dtpFechaBonificacionDesde.Value = ((ArticuloDTO)base.Entidad).BonificacionFechaDesde.HasValue
                    ? ((ArticuloDTO)base.Entidad).BonificacionFechaDesde.Value : DateTime.Now;

                dtpFechaBonificacionHasta.Value = ((ArticuloDTO)base.Entidad).BonificacionFechaHasta.HasValue
                    ? ((ArticuloDTO)base.Entidad).BonificacionFechaHasta.Value : DateTime.Now;
            }

            dtpFechaBonificacionDesde.Focus();
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
                _proveedorSeleccionadoLookup = (ProveedorDTO)formulario.Entidad;

                if (_proveedorSeleccionadoLookup != null)
                {
                    this.txtProveedor.Text = $"{_proveedorSeleccionadoLookup.RazonSocial} - ( CUIT: {_proveedorSeleccionadoLookup.CUIT} )";
                    this.txtCodigoProveedor.Clear();
                    this.txtCodigoProveedor.Focus();
                }
            }
        }

        private List<ArticuloProveedorDTO> ObtenerProveedores()
        {
            return _listaProveedores.Where(x => !x.Eliminar).ToList();
        }

        private void BtnAgregarProveedor_Click(object sender, EventArgs e)
        {
            if (_proveedorSeleccionadoLookup != null || !string.IsNullOrEmpty(txtProveedor.Text))
            {
                var resultArtProv = _listaProveedores.FirstOrDefault(x => x.ProveedorId == _proveedorSeleccionadoLookup.Id);

                if (resultArtProv == null)
                {
                    _listaProveedores.Add(new ArticuloProveedorDTO
                    {
                        CodigoProveedor = txtCodigoProveedor.Text,
                        ProveedorId = _proveedorSeleccionadoLookup.Id,
                        Proveedor = _proveedorSeleccionadoLookup.RazonSocial,
                        Cuit = _proveedorSeleccionadoLookup.CUIT,
                        Eliminar = false,
                        EstaBD = false,
                    });
                }
                else
                {
                    if (resultArtProv.Eliminar)
                    {
                        resultArtProv.CodigoProveedor = txtCodigoProveedor.Text;
                        resultArtProv.Eliminar = false;
                    }
                    else
                    {
                        MessageBox.Show($"El proveedor seleccionado ({_proveedorSeleccionadoLookup.RazonSocial}) ya se encuentra cargado");
                    }
                }

                this.dgvProveedor.DataSource = ObtenerProveedores();

                _proveedorSeleccionadoLookup = null;

                txtProveedor.Clear();
                txtCodigoProveedor.Clear();
                txtProveedor.Focus();
            }
            else
            {
                MessageBox.Show("No hay un proveedor seleccionado");
            }
        }

        private void DgvProveedor_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvProveedor.RowCount > 0)
            {
                _articuloProveedorSeleccionado = (ArticuloProveedorDTO)this.dgvProveedor.Rows[e.RowIndex].DataBoundItem;
            }
            else
            {
                _articuloProveedorSeleccionado = null;
            }
        }

        private void BtnQuitarProveedor_Click(object sender, EventArgs e)
        {
            if (dgvProveedor.RowCount > 0 && _articuloProveedorSeleccionado != null)
            {
                if (MessageBox.Show($"Esta seguro de eliminar el proveedor seleccionado ({_articuloProveedorSeleccionado.Proveedor}) ?",
                    "Atencion", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    // Eliminar de la Base y Memoria
                    _articuloProveedorSeleccionado.Eliminar = true;
                    dgvProveedor.DataSource = ObtenerProveedores();
                }
            }
            else
            {
                MessageBox.Show("No hay proveedores cargados", "Atención");
            }
        }


        private void DgvProveedor_DoubleClick(object sender, EventArgs e)
        {
            if (dgvProveedor.RowCount > 0 && _articuloProveedorSeleccionado != null)
            {
                var fCambiarCodigo = new CambiarCodigoInternoProveedor(_articuloProveedorSeleccionado);
                fCambiarCodigo.ShowDialog();

                dgvProveedor.DataSource = ObtenerProveedores();
            }
        }

        private void BtnNuevoDeposito_Click(object sender, EventArgs e)
        {
            var formulario = new _00137_Deposito_Abm(base._seguridadServicio,
                                                     base._configuracionServicio,
                                                     base._logger,
                                                     Program.Container.GetInstance<IDepositoServicio>(),
                                                     TipoOperacion.Nuevo);

            FormularioSeguridad.VerificarAcceso(formulario, _seguridadServicio, _logger, _configuracionDTO);

            if (formulario.RealizoAlgunaOperacion)
            {
                var resultDeposito = _depositoServicio.GetAll(Properties.Settings.Default.EmpresaId);

                if (resultDeposito != null && resultDeposito.State)
                {
                    PoblarComboBox(cmbDeposito, resultDeposito.Data, "Descripcion", "Id");
                }
            }
        }

        private void BtnNuevaListaInicial_Click(object sender, EventArgs e)
        {
            var formulario = new _00139_ListaPrecio_Abm(base._seguridadServicio,
                                                        base._configuracionServicio,
                                                        base._logger,
                                                        Program.Container.GetInstance<IListaPrecioServicio>(),
                                                        TipoOperacion.Nuevo);

            FormularioSeguridad.VerificarAcceso(formulario, _seguridadServicio, _logger, _configuracionDTO);

            if (formulario.RealizoAlgunaOperacion)
            {
                var resultListaPrecio = _listaPrecioServicio.GetAll(Properties.Settings.Default.EmpresaId);

                if (resultListaPrecio != null && resultListaPrecio.State)
                {
                    PoblarComboBox(cmbListaPrecio, resultListaPrecio.Data, "Descripcion", "Id");
                }
            }
        }

        private void ChkRentabilidad_CheckedChanged(object sender, EventArgs e)
        {
            nudRentabilidad.Enabled = chkRentabilidad.Checked;
            nudRentabilidad.Value = 0;

            if (base.TipoOperacion == TipoOperacion.Modificar)
            {
                if (base.Entidad != null)
                {
                    nudRentabilidad.Value = chkRentabilidad.Checked
                        ? ((ArticuloDTO)base.Entidad).TieneRentabilidad ? ((ArticuloDTO)base.Entidad).Rentabilidad.Value : 0 : 0;
                }
            }
        }

        private void CmbTipoArticulo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var _tipoSeleccionado = (TipoArticulo)cmbTipoArticulo.SelectedValue;

            chkPermiteMostrarLaFormula.Visible = _tipoSeleccionado == TipoArticulo.Formula;
            lblPermiteVerFormula.Visible = _tipoSeleccionado == TipoArticulo.Formula;
        }
    }
}
