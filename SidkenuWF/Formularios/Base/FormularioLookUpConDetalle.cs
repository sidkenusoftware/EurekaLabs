using FontAwesome.Sharp;
using Serilog;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Seguridad.Configuracion;
using Sidkenu.LogicaNegocio.Servicios.Interface.Seguridad;

namespace SidkenuWF.Formularios.Base
{
    public partial class FormularioLookUpConDetalle : Form
    {
        protected readonly ISeguridadServicio _seguridadServicio;
        protected readonly IConfiguracionServicio _configuracionServicio;
        protected readonly ILogger _logger;

        protected ConfiguracionDTO _configuracionDTO;

        public Guid? EntidadId { get; set; }
        public object? Entidad { get; set; }

        public bool SeleccionoEntidad { get; set; } = false;

        public string TituloFormulario
        {
            set
            {
                this.Text = string.IsNullOrEmpty(value)
                    ? Constantes.FormularioConstantes.Titulo
                    : value;
            }
        }

        private string _titulo;
        public string Titulo
        {
            set { this.lblTitulo.Text = value; this._titulo = value; }
            get { return _titulo; }
        }

        private string _tituloDetalle;
        public string TituloDetalle
        {
            set { this.lblTituloDetalle.Text = value; this._tituloDetalle = value; }
            get { return _tituloDetalle; }
        }

        public IconChar Logo
        {
            set { this.imgLogo.IconChar = value; }
        }

        private bool _tieneRegistrosCargados;
        public bool TieneRegistrosCargados { get => _tieneRegistrosCargados; }

        public FormularioLookUpConDetalle()
        {
            InitializeComponent();

            this._tieneRegistrosCargados = false;
            this.SeleccionoEntidad = false;

            CargarAparienciaFormulario();
        }

        public FormularioLookUpConDetalle(ISeguridadServicio seguridadServicio,
                                          IConfiguracionServicio configuracionServicio,
                                          ILogger logger)
                                          : this()
        {
            this._seguridadServicio = seguridadServicio;
            this._configuracionServicio = configuracionServicio;
            this._logger = logger;

            var result = _configuracionServicio.Get();

            if (result.State)
            {
                _configuracionDTO = (ConfiguracionDTO)result.Data;
            }
            else
            {
                _logger.Error($"Ocurrió un error al obtener la configuracion del sistema. {result.Message}");
            }
        }

        private void BtnBuscar_Click(object? sender, EventArgs e)
        {
            Buscar(txtBuscar.Text);
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            EjecutarComandoSalir(sender, e);
        }

        private void FormularioConsulta_Load(object sender, EventArgs e)
        {
            EjecutarComandoLoad(sender, e);
        }

        private void TxtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            EjecutarComandoKeyPress(sender, e);
        }

        private void DgvGrilla_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            EjecutarComandoRowEnter(sender, e);
        }

        public virtual void EjecutarComandoRowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvGrilla.RowCount > 0)
            {
                Entidad = this.dgvGrilla.Rows[e.RowIndex].DataBoundItem;
                EntidadId = (Guid)this.dgvGrilla["Id", e.RowIndex].Value;
            }
        }

        public virtual void Buscar(string cadenaBuscar)
        {
            FormatearDatos(this.dgvGrilla);
        }

        public virtual void EjecutarComandoSalir(object sender, EventArgs e)
        {
            this.Close();
        }

        public virtual void EjecutarComandoLoad(object sender, EventArgs e)
        {
            txtBuscar.Clear();
            Buscar(txtBuscar.Text);
        }

        public virtual void EjecutarComandoKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                Buscar(txtBuscar.Text);
            }
        }

        public virtual bool VerificarAcceso(object sender)
        {
            return true;
        }

        private void FormularioConsulta_Activated(object sender, EventArgs e)
        {
            this.txtBuscar.Clear();
            this.txtBuscar.Focus();
        }

        public virtual void FormatearDatos(DataGridView dgvGrilla)
        {
            for (int i = 0; i < dgvGrilla.ColumnCount; i++)
            {
                dgvGrilla.Columns[i].Visible = false;
            }

            dgvGrilla.AllowUserToResizeRows = false;
        }

        private void DgvGrilla_DoubleClick(object sender, EventArgs e)
        {
            if (this.dgvGrilla.RowCount > 0)
            {
                SeleccionoEntidad = true;
                this.Close();
            }
        }

        // -------------------------------------------------------------------------------- //
        // -------------------        Metodos Privados        ----------------------------- //
        // -------------------------------------------------------------------------------- //

        private void CargarAparienciaFormulario()
        {
            this.pnlTitulo.BackColor = Constantes.ColorFormulario.ColorPanelTitulo;
            this.pnlLinea.BackColor = Constantes.ColorFormulario.ColorPanelLinea;
            this.pnlSuperior.BackColor = Constantes.ColorFormulario.ColorPanelSuperior;

            this.lblTitulo.BackColor = Constantes.ColorFormulario.ColorFondoTitulo;
            this.lblTitulo.ForeColor = Constantes.ColorFormulario.ColorFuenteTitulo;

            this.imgLogo.BackColor = Constantes.ColorFormulario.ColorFondologo;
            this.imgLogo.IconColor = Constantes.ColorFormulario.ColorIconoLogo;

            CargarAparienciaBoton(btnSalir, false);
            CargarAparienciaBoton(btnBuscar);
        }

        private void CargarAparienciaBoton(IconButton button, bool mostrarBorde = true)
        {
            button.IconColor = Constantes.ColorFormulario.ColorIconoBoton;
            button.FlatAppearance.BorderColor = Constantes.ColorFormulario.ColorBordeBoton;
            button.FlatAppearance.BorderSize = mostrarBorde ? 1 : 0;
            button.ForeColor = Constantes.ColorFormulario.ColorFuenteBoton;
            button.BackColor = Constantes.ColorFormulario.ColorFondoBoton;
        }
    }
}
