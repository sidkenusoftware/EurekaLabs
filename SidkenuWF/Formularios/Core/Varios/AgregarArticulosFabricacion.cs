using Serilog;
using Sidkenu.AccesoDatos.Constantes.Enum;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.Articulo;
using Sidkenu.LogicaNegocio.Servicios.Interface.Core;
using Sidkenu.LogicaNegocio.Servicios.Interface.Seguridad;
using SidkenuWF.Formularios.Base;
using SidkenuWF.Formularios.Base.Constantes;
using SidkenuWF.Formularios.Core.LookUps;
using SidkenuWF.Formularios.Core.Model;
using SidkenuWF.Formularios.Core.Model.PuntoVenta;
using SidkenuWF.Helpers;

namespace SidkenuWF.Formularios.Core.Varios
{
    public partial class AgregarArticulosFabricacion : FormularioComun
    {
        private MyListViewModel<DetalleTemporalVM> Detalles { get; set; }

        private DetalleTemporalVM? _item;

        public DetalleVM Detalle { get; private set; }

        private readonly ISeguridadServicio seguridadServicio;
        private readonly IConfiguracionServicio configuracionServicio;
        private readonly ILogger logger;
        private readonly IContadorServicio _contadorServicio;
        private readonly IArticuloServicio _articuloServicio;
        private Guid _listaPrecioId;

        public bool RealizoAlgunaOperacion { get; set; }

        public AgregarArticulosFabricacion(ISeguridadServicio seguridadServicio,
                                           IConfiguracionServicio configuracionServicio,
                                           ILogger logger,
                                           IContadorServicio contadorServicio,
                                           IArticuloServicio articuloServicio,
                                           Guid listaPrecioId)
            : base(seguridadServicio, configuracionServicio, logger)
        {
            InitializeComponent();

            base.TituloFormulario = FormularioConstantes.Titulo;
            base.Titulo = "Artículos";
            base.Logo = FontAwesome.Sharp.IconChar.BoxOpen;

            Foto.ActivarAvatar = false;

            Detalles ??= new MyListViewModel<DetalleTemporalVM>();

            Detalles.ItemAdded += Detalles_ItemAdded;
            Detalles.ItemRemoved += Detalles_ItemRemoved;

            _item = null;
            _listaPrecioId = listaPrecioId;
            RealizoAlgunaOperacion = false;

            this.seguridadServicio = seguridadServicio;
            this.configuracionServicio = configuracionServicio;
            this.logger = logger;
            this._contadorServicio = contadorServicio;
            _articuloServicio = articuloServicio;

            dtpFechaEntrega.Value = DateTime.Now;
            dtpFechaEntrega.MinDate = DateTime.Now;
        }

        private void Detalles_ItemRemoved(object? sender, ItemRemovedEventArgs<DetalleTemporalVM> e)
        {
            ActualizarDatos();
            CalcularTotal();
        }

        private void Detalles_ItemAdded(object? sender, ItemAddedEventArgs<DetalleTemporalVM> e)
        {
            ActualizarDatos();
            CalcularTotal();
        }

        private void AgregarArticulosFabricacion_Shown(object sender, EventArgs e)
        {
            CalcularTotal();
            ActualizarDatos();
            FormatearGrilla();
        }

        private void FormatearGrilla()
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
            dgvGrilla.Columns["PrecioPublico"].Width = 100;
            dgvGrilla.Columns["PrecioPublico"].HeaderText = "Precio Publico";
            dgvGrilla.Columns["PrecioPublico"].DisplayIndex = 4;
            dgvGrilla.Columns["PrecioPublico"].ReadOnly = true;
            dgvGrilla.Columns["PrecioPublico"].DefaultCellStyle.Format = "C";
            dgvGrilla.Columns["PrecioPublico"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgvGrilla.Columns["SubTotal"].Visible = true;
            dgvGrilla.Columns["SubTotal"].Width = 120;
            dgvGrilla.Columns["SubTotal"].HeaderText = "Sub-Total";
            dgvGrilla.Columns["SubTotal"].DisplayIndex = 5;
            dgvGrilla.Columns["SubTotal"].ReadOnly = true;
            dgvGrilla.Columns["SubTotal"].DefaultCellStyle.Format = "C";
            dgvGrilla.Columns["SubTotal"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgvGrilla.Columns["EstaEliminado"].Visible = false;
            dgvGrilla.Columns["EstaEliminado"].DisplayIndex = 6;

            dgvGrilla.Columns["Id"].Visible = false;
            dgvGrilla.Columns["Id"].DisplayIndex = 7;
        }

        private void ActualizarDatos()
        {
            dgvGrilla.DataSource = Detalles.ToList();
        }

        private void CalcularTotal()
        {
            nudTotal.Value = Detalles.Sum(x => x.SubTotal);
        }

        private void BtnBuscarArticulo_Click(object sender, EventArgs e)
        {
            var formulario = new VentaArticuloLookUp(base._seguridadServicio,
                                                     base._configuracionServicio,
                                                     base._logger,
                                                     Program.Container.GetInstance<IArticuloServicio>());
            formulario.ShowDialog();

            if (formulario.SeleccionoEntidad)
            {
                var _articulo = (ArticuloDTO)formulario.Entidad;

                _item = new DetalleTemporalVM
                {
                    Id = Guid.NewGuid(),
                    ArticuloId = _articulo.Id,
                    Cantidad = 0,
                    Codigo = _articulo.Codigo,
                    Descripcion = _articulo.Descripcion,
                    EstaEliminado = false,
                    PrecioPublico = _articulo.PrecioPublico
                };

                txtCodigo.Text = _articulo.Codigo.ToString();
                txtDescripcion.Text = _articulo.Descripcion;
                nudCantidad.Value = 1;
                nudCantidad.Focus();
            }
        }

        private void BtnAgregarArticulo_Click(object sender, EventArgs e)
        {
            if (_item == null)
            {
                MessageBox.Show("Por fravor seleccione un articulo", "Atención");
                return;
            }

            if (nudCantidad.Value == 0)
            {
                MessageBox.Show("Por favor ingrese una cantidad", "Atención");
                nudCantidad.Focus();
                return;
            }

            _item.Cantidad = nudCantidadTotal.Value * nudCantidad.Value;

            Detalles.Add(_item);

            LimpiarNuevoItem();
        }

        private void LimpiarNuevoItem()
        {
            _item = null;
            txtCodigo.Clear();
            txtDescripcion.Clear();
            nudCantidad.Value = 0;
            txtCodigo.Focus();
        }

        private void BtnEjecutar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCodigoTemp.Text))
            {
                MessageBox.Show("El codigo es un dato Obligatorio", "Atención");
                txtCodigoTemp.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtDescripcionTemp.Text))
            {
                MessageBox.Show("La Descripcion es un dato Obligatorio", "Atención");
                txtDescripcionTemp.Focus();
                return;
            }

            if (nudCantidadTotal.Value == 0)
            {
                MessageBox.Show("Por favor ingrese el Precio del Artículo", "Atención");
                nudCantidadTotal.Focus();
                return;
            }

            Detalle = new DetalleVM
            {
                DetalleItems = Detalles,
                ArticuloId = null,
                Cantidad = 1,
                Codigo = txtCodigoTemp.Text,
                Descripcion = txtDescripcionTemp.Text,
                Descuento = 0,
                EstaEliminado = false,
                Id = Guid.NewGuid(),
                Impuesto = 0,
                PrecioPublico = nudTotal.Value,
                TipoItem = TipoItemFactura.Fabricacion,
                ListaPrecioId = _listaPrecioId,
                Foto = ImagenConvert.Convertir_Imagen_Bytes(Foto.Imagen),
                FechaEntrega = dtpFechaEntrega.Value,
                CodigoFabricacion = txtCodigoTemp.Text,                 
            };

            RealizoAlgunaOperacion = true;

            this.Close();
        }

        private void AgregarArticulosFabricacion_Load(object sender, EventArgs e)
        {
            var proximoNumero = _contadorServicio.ObtenerNumero(TipoContador.ArticuloTemporal,
                Properties.Settings.Default.EmpresaId,
                Properties.Settings.Default.UserLogin);

            txtCodigoTemp.Text = proximoNumero.ToString();
        }

        private void BtnAgregarItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDescripcionTemp.Text))
            {
                MessageBox.Show("Por favor ingrese un NOMBRE DE ARTICULo antes de agregar los Items", "Atención");
                txtDescripcionTemp.Focus();
                return;
            }

            if (nudCantidadTotal.Value <= 0)
            {
                MessageBox.Show("Por favor ingrese una CANTIDAD antes de agregar los Items", "Atención");
                nudCantidadTotal.Focus();
                return;
            }

            tabControlDetalle.Enabled = !tabControlDetalle.Enabled;
            LimpiarNuevoItem();
        }

        private void TxtCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.F6:
                    TeclaF6_Buscar();
                    break;
                case Keys.Enter:
                    TeclaEnter_AgregarArticulo();
                    break;
            }
        }

        private void TeclaEnter_AgregarArticulo()
        {
            if (string.IsNullOrEmpty(txtCodigo.Text))
            {
                TeclaF6_Buscar();
            }

            var resultArticulo = _articuloServicio.GetByCodigo(_listaPrecioId, txtCodigo.Text, Properties.Settings.Default.EmpresaId);

            if (resultArticulo != null
                && resultArticulo.Data != null)
            {
                var _articulo = (ArticuloDTO)resultArticulo.Data;

                _item = new DetalleTemporalVM
                {
                    Id = Guid.NewGuid(),
                    ArticuloId = _articulo.Id,
                    Cantidad = 0,
                    Codigo = _articulo.Codigo,
                    Descripcion = _articulo.Descripcion,
                    EstaEliminado = false,
                    PrecioPublico = _articulo.PrecioPublico
                };

                txtCodigo.Text = _articulo.Codigo.ToString();
                txtDescripcion.Text = _articulo.Descripcion;
                nudCantidad.Value = 1;
                nudCantidad.Focus();
            }
            else
            {
                TeclaF6_Buscar();
            }
        }

        private void TeclaF6_Buscar()
        {
            btnBuscarArticulo.PerformClick();
        }

        private void TxtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
            }
        }

        private void NudCantidad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                btnAgregarArticulo.PerformClick();
            }
        }

        private void NudCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
            }
        }
    }
}
