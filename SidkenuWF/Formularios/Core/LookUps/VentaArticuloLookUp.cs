using FontAwesome.Sharp;
using Serilog;
using Sidkenu.AccesoDatos.Constantes.Enum;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.Articulo;
using Sidkenu.LogicaNegocio.Servicios.Interface.Core;
using Sidkenu.LogicaNegocio.Servicios.Interface.Seguridad;
using SidkenuWF.Formularios.Base;
using SidkenuWF.Formularios.Base.Constantes;
using SidkenuWF.Helpers;

namespace SidkenuWF.Formularios.Core.LookUps
{
    public partial class VentaArticuloLookUp : FormularioLookUpConDetalle
    {
        private readonly IArticuloServicio _articuloServicio;
        private readonly List<TipoArticulo>? _tipos;

        public VentaArticuloLookUp(ISeguridadServicio seguridadServicio,
                                   IConfiguracionServicio configuracionServicio,
                                   ILogger logger,
                                   IArticuloServicio articuloServicio,
                                   List<TipoArticulo>? tipos = null)
                                   : base(seguridadServicio, configuracionServicio, logger)
        {
            InitializeComponent();

            base.TituloFormulario = FormularioConstantes.Titulo;
            base.Titulo = "Artículos";
            base.TituloDetalle = "Detalle";
            base.Logo = IconChar.BuildingFlag;

            _articuloServicio = articuloServicio;
            _tipos = tipos;
        }

        public override void Buscar(string cadenaBuscar)
        {
            if (_tipos == null)
            {
                var result = _articuloServicio.GetByFilterLookUp(new ArticuloFilterDTO
                {
                    CadenaBuscar = cadenaBuscar,
                    VerEliminados = false,
                    EmpresaId = Properties.Settings.Default.EmpresaId
                }, new List<TipoArticulo>
                {
                    TipoArticulo.Variante,
                    TipoArticulo.Simple,
                    TipoArticulo.Formula,
                    TipoArticulo.Servicio,
                    TipoArticulo.Kit,
                });

                if (result.State)
                {
                    this.dgvGrilla.DataSource = result.Data;

                    base.Buscar(cadenaBuscar);
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
            else
            {
                var result = _articuloServicio.GetByFilterLookUp(new ArticuloFilterDTO
                {
                    CadenaBuscar = cadenaBuscar,
                    VerEliminados = false,
                    EmpresaId = Properties.Settings.Default.EmpresaId,
                }, _tipos.ToList());

                if (result.State)
                {
                    this.dgvGrilla.DataSource = result.Data;

                    base.Buscar(cadenaBuscar);
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
        }

        public override void FormatearDatos(DataGridView dgvGrilla)
        {
            try
            {
                base.FormatearDatos(dgvGrilla);

                dgvGrilla.AllowUserToResizeRows = false;

                dgvGrilla.Columns["Codigo"].Visible = true;
                dgvGrilla.Columns["Codigo"].Width = 70;
                dgvGrilla.Columns["Codigo"].HeaderText = "Código";
                dgvGrilla.Columns["Codigo"].DisplayIndex = 0;
                dgvGrilla.Columns["Codigo"].ReadOnly = true;

                dgvGrilla.Columns["CodigoBarra"].Visible = true;
                dgvGrilla.Columns["CodigoBarra"].Width = 90;
                dgvGrilla.Columns["CodigoBarra"].HeaderText = "Cód. Barra";
                dgvGrilla.Columns["CodigoBarra"].DisplayIndex = 1;
                dgvGrilla.Columns["CodigoBarra"].ReadOnly = true;

                dgvGrilla.Columns["Descripcion"].Visible = true;
                dgvGrilla.Columns["Descripcion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvGrilla.Columns["Descripcion"].HeaderText = "Articulo";
                dgvGrilla.Columns["Descripcion"].DisplayIndex = 2;
                dgvGrilla.Columns["Descripcion"].ReadOnly = true;

                dgvGrilla.Columns["Stock"].Visible = true;
                dgvGrilla.Columns["Stock"].Width = 70;
                dgvGrilla.Columns["Stock"].HeaderText = "Stock";
                dgvGrilla.Columns["Stock"].DisplayIndex = 3;
                dgvGrilla.Columns["Stock"].ReadOnly = true;
                dgvGrilla.Columns["Stock"].DefaultCellStyle.Format = "N2";

                dgvGrilla.Columns["PrecioCosto"].Visible = true;
                dgvGrilla.Columns["PrecioCosto"].Width = 110;
                dgvGrilla.Columns["PrecioCosto"].HeaderText = "Precio Costo";
                dgvGrilla.Columns["PrecioCosto"].DisplayIndex = 4;
                dgvGrilla.Columns["PrecioCosto"].ReadOnly = true;
                dgvGrilla.Columns["PrecioCosto"].DefaultCellStyle.Format = "C2";
                dgvGrilla.Columns["PrecioCosto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                dgvGrilla.Columns["PrecioPublico"].Visible = true;
                dgvGrilla.Columns["PrecioPublico"].Width = 110;
                dgvGrilla.Columns["PrecioPublico"].HeaderText = "Precio Publico";
                dgvGrilla.Columns["PrecioPublico"].DisplayIndex = 5;
                dgvGrilla.Columns["PrecioPublico"].ReadOnly = true;
                dgvGrilla.Columns["PrecioPublico"].DefaultCellStyle.Format = "C2";
                dgvGrilla.Columns["PrecioPublico"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;


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

            var _articuloSeleccionado = (ArticuloDTO)base.Entidad;

            // Foto
            imgFotoArticulo.Image = ImagenConvert.Convertir_Bytes_Imagen(_articuloSeleccionado.Foto);

            //Detalle
            rtbDetalle.Text = _articuloSeleccionado.Detalle;
            txtDatoAdicional.Text = _articuloSeleccionado.DescripcionAdicional;

            // Stock
            dgvGrillaStock.DataSource = _articuloSeleccionado.Cantidades
                .Where(x => x.EmpresaId == Properties.Settings.Default.EmpresaId).ToList();

            FormatearDatosStock(dgvGrillaStock);

            dgvGrillaStockSucursales.DataSource = _articuloSeleccionado.Cantidades
                .Where(x => x.EmpresaId != Properties.Settings.Default.EmpresaId).ToList();

            FormatearDatosStockSucursales(dgvGrillaStockSucursales);

            // Precios
            dgvGrillaListaPrecios.DataSource = _articuloSeleccionado.ListaPrecios.ToList();

            FormatearDatosListaPrecio(dgvGrillaListaPrecios);

            // Formula
            if (_articuloSeleccionado.PermiteMostrarFormula)
            {
                dgvGrillaFormula.DataSource = _articuloSeleccionado.ArticuloFormulas.ToList();

                FormatearDatosFormulas(dgvGrillaFormula);
            }
            else
            {
                lblRestringidoFormula.Visible = true;
                dgvGrillaFormula.Visible = false;
            }

            // Kit
            dgvGrillaKit.DataSource = _articuloSeleccionado.ArticuloKits.ToList();

            FormatearDatosKit(dgvGrillaKit);
        }

        private void FormatearDatosKit(DataGridView dgvGrillaKit)
        {
            base.FormatearDatos(dgvGrillaKit);

            dgvGrillaKit.AllowUserToResizeRows = false;

            dgvGrillaKit.Columns["Descripcion"].Visible = true;
            dgvGrillaKit.Columns["Descripcion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvGrillaKit.Columns["Descripcion"].HeaderText = "Articulo";
            dgvGrillaKit.Columns["Descripcion"].DisplayIndex = 1;
            dgvGrillaKit.Columns["Descripcion"].ReadOnly = true;
            dgvGrillaKit.Columns["Descripcion"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvGrillaKit.Columns["Cantidad"].Visible = true;
            dgvGrillaKit.Columns["Cantidad"].Width = 100;
            dgvGrillaKit.Columns["Cantidad"].HeaderText = "Cantidad";
            dgvGrillaKit.Columns["Cantidad"].DisplayIndex = 2;
            dgvGrillaKit.Columns["Cantidad"].ReadOnly = true;
            dgvGrillaKit.Columns["Cantidad"].DefaultCellStyle.Format = "N2";
            dgvGrillaKit.Columns["Cantidad"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void FormatearDatosFormulas(DataGridView dgvGrillaFormula)
        {
            lblRestringidoFormula.Visible = false;
            dgvGrillaFormula.Visible = true;

            base.FormatearDatos(dgvGrillaFormula);

            dgvGrillaFormula.AllowUserToResizeRows = false;

            dgvGrillaFormula.Columns["Descripcion"].Visible = true;
            dgvGrillaFormula.Columns["Descripcion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvGrillaFormula.Columns["Descripcion"].HeaderText = "Articulo";
            dgvGrillaFormula.Columns["Descripcion"].DisplayIndex = 1;
            dgvGrillaFormula.Columns["Descripcion"].ReadOnly = true;
            dgvGrillaFormula.Columns["Descripcion"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvGrillaFormula.Columns["Cantidad"].Visible = true;
            dgvGrillaFormula.Columns["Cantidad"].Width = 100;
            dgvGrillaFormula.Columns["Cantidad"].HeaderText = "Cantidad";
            dgvGrillaFormula.Columns["Cantidad"].DisplayIndex = 2;
            dgvGrillaFormula.Columns["Cantidad"].ReadOnly = true;
            dgvGrillaFormula.Columns["Cantidad"].DefaultCellStyle.Format = "N2";
            dgvGrillaFormula.Columns["Cantidad"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void FormatearDatosStock(DataGridView dgvGrillaStock)
        {
            base.FormatearDatos(dgvGrillaStock);

            dgvGrillaStock.AllowUserToResizeRows = false;

            dgvGrillaStock.Columns["Deposito"].Visible = true;
            dgvGrillaStock.Columns["Deposito"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvGrillaStock.Columns["Deposito"].HeaderText = "Depósito";
            dgvGrillaStock.Columns["Deposito"].DisplayIndex = 1;
            dgvGrillaStock.Columns["Deposito"].ReadOnly = true;
            dgvGrillaStock.Columns["Deposito"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvGrillaStock.Columns["Cantidad"].Visible = true;
            dgvGrillaStock.Columns["Cantidad"].Width = 100;
            dgvGrillaStock.Columns["Cantidad"].HeaderText = "Stock";
            dgvGrillaStock.Columns["Cantidad"].DisplayIndex = 2;
            dgvGrillaStock.Columns["Cantidad"].ReadOnly = true;
            dgvGrillaStock.Columns["Cantidad"].DefaultCellStyle.Format = "N2";
            dgvGrillaStock.Columns["Cantidad"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void FormatearDatosStockSucursales(DataGridView dgvGrillaStock)
        {
            base.FormatearDatos(dgvGrillaStock);

            dgvGrillaStock.AllowUserToResizeRows = false;

            dgvGrillaStock.Columns["Empresa"].Visible = true;
            dgvGrillaStock.Columns["Empresa"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvGrillaStock.Columns["Empresa"].HeaderText = "Empresa";
            dgvGrillaStock.Columns["Empresa"].DisplayIndex = 1;
            dgvGrillaStock.Columns["Empresa"].ReadOnly = true;
            dgvGrillaStock.Columns["Empresa"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvGrillaStock.Columns["Deposito"].Visible = true;
            dgvGrillaStock.Columns["Deposito"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvGrillaStock.Columns["Deposito"].HeaderText = "Depósito";
            dgvGrillaStock.Columns["Deposito"].DisplayIndex = 2;
            dgvGrillaStock.Columns["Deposito"].ReadOnly = true;
            dgvGrillaStock.Columns["Deposito"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvGrillaStock.Columns["Cantidad"].Visible = true;
            dgvGrillaStock.Columns["Cantidad"].Width = 100;
            dgvGrillaStock.Columns["Cantidad"].HeaderText = "Stock";
            dgvGrillaStock.Columns["Cantidad"].DisplayIndex = 3;
            dgvGrillaStock.Columns["Cantidad"].ReadOnly = true;
            dgvGrillaStock.Columns["Cantidad"].DefaultCellStyle.Format = "N2";
            dgvGrillaStock.Columns["Cantidad"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void FormatearDatosListaPrecio(DataGridView dgvGrillaListaPrecio)
        {
            base.FormatearDatos(dgvGrillaListaPrecio);

            dgvGrillaListaPrecio.AllowUserToResizeRows = false;

            dgvGrillaListaPrecio.Columns["ListaPrecio"].Visible = true;
            dgvGrillaListaPrecio.Columns["ListaPrecio"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvGrillaListaPrecio.Columns["ListaPrecio"].HeaderText = "Lista Precio";
            dgvGrillaListaPrecio.Columns["ListaPrecio"].DisplayIndex = 1;
            dgvGrillaListaPrecio.Columns["ListaPrecio"].ReadOnly = true;
            dgvGrillaListaPrecio.Columns["ListaPrecio"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvGrillaListaPrecio.Columns["Monto"].Visible = true;
            dgvGrillaListaPrecio.Columns["Monto"].Width = 100;
            dgvGrillaListaPrecio.Columns["Monto"].HeaderText = "Precio";
            dgvGrillaListaPrecio.Columns["Monto"].DisplayIndex = 2;
            dgvGrillaListaPrecio.Columns["Monto"].ReadOnly = true;
            dgvGrillaListaPrecio.Columns["Monto"].DefaultCellStyle.Format = "C2";
            dgvGrillaListaPrecio.Columns["Monto"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
    }
}
