using Serilog;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Seguridad.Configuracion;
using Sidkenu.LogicaNegocio.Servicios.Interface.Seguridad;

namespace SidkenuWF.Formularios.Base
{
    public partial class FormularioAsignarQuitar : Form
    {
        protected readonly ISeguridadServicio _seguridadServicio;
        protected readonly IConfiguracionServicio _configuracionServicio;
        protected readonly ILogger _logger;

        protected ConfiguracionDTO _configuracionDTO;

        protected Guid EntidadId { get; private set; }

        private string _titulo;
        public string Titulo
        {
            set => this.lblTitulo.Text = !string.IsNullOrEmpty(value)
                ? value
                : string.Empty;

            get { return this._titulo; }
        }

        public string TituloEntidadSeleccionada
        {
            set => this.lblEntidadSeleccionada.Text = !string.IsNullOrEmpty(value)
                ? value
                : string.Empty;
        }

        public string TituloFormulario
        {
            set => this.Text = !string.IsNullOrEmpty(value)
                ? value
                : string.Empty;
        }

        public FontAwesome.Sharp.IconChar LogoTitulo
        {
            set => this.imgLogoTitulo.IconChar = value;
        }

        public string TituloAsignado
        {
            set => this.lblTituloAsignado.Text = !string.IsNullOrEmpty(value)
                ? value
                : string.Empty;
        }

        public string TituloNoAsignado
        {
            set => this.lblTituloNoAsignado.Text = !string.IsNullOrEmpty(value)
                ? value
                : string.Empty;
        }

        public FormularioAsignarQuitar()
        {
            InitializeComponent();
        }

        public FormularioAsignarQuitar(ISeguridadServicio seguridadServicio,
                                       IConfiguracionServicio configuracionServicio,
                                       ILogger logger,
                                       Guid entidadId)
                                       : this()
        {
            EntidadId = entidadId;

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

        private void BtnBuscarNoAsignado_Click(object sender, EventArgs e)
        {
            ActualizarDatosNoAsignado(dgvGrillaNoAsignado, !string.IsNullOrEmpty(txtBuscarNoAsignado.Text) ? txtBuscarNoAsignado.Text : string.Empty);
        }

        private void BtnBuscarAsignado_Click(object sender, EventArgs e)
        {
            ActualizarDatosAsignado(dgvGrillaAsignado, !string.IsNullOrEmpty(txtBuscarAsignado.Text) ? txtBuscarAsignado.Text : string.Empty);
        }

        private void FormularioAsignarQuitar_Load(object sender, EventArgs e)
        {
            EjecutarComandoLoad();
        }

        private void TxtBuscarNoAsignado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                ActualizarDatosNoAsignado(dgvGrillaNoAsignado, !string.IsNullOrEmpty(txtBuscarNoAsignado.Text) ? txtBuscarNoAsignado.Text : string.Empty);
                e.Handled = true;
            }
        }

        private void TxtBuscarAsignado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                ActualizarDatosAsignado(dgvGrillaAsignado, !string.IsNullOrEmpty(txtBuscarAsignado.Text) ? txtBuscarAsignado.Text : string.Empty);
                e.Handled = true;
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            EjecutarComandoAgregar(dgvGrillaNoAsignado);
        }
        private void BtnQuitar_Click(object sender, EventArgs e)
        {
            EjecutarComandoQuitar(dgvGrillaAsignado);
        }

        private void BtnMarcarNoAsignado_Click(object sender, EventArgs e)
        {
            Seleccionar(dgvGrillaNoAsignado, true);
        }

        private void BtnDesmarcarNoAsignado_Click(object sender, EventArgs e)
        {
            Seleccionar(dgvGrillaNoAsignado, false);
        }

        private void BtnMarcarAsignado_Click(object sender, EventArgs e)
        {
            Seleccionar(dgvGrillaAsignado, true);
        }

        private void BtnDesmarcarAsignado_Click(object sender, EventArgs e)
        {
            Seleccionar(dgvGrillaAsignado, false);
        }

        public virtual void ActualizarDatosNoAsignado(DataGridView dgvGrilla, string cadenaBuscar)
        {
            FormatearGrilla(dgvGrilla);
        }

        public virtual void ActualizarDatosAsignado(DataGridView dgvGrilla, string cadenaBuscar)
        {
            FormatearGrilla(dgvGrilla);
        }

        public virtual void FormatearGrilla(DataGridView dgv)
        {
            for (int i = 0; i < dgv.Columns.Count; i++)
            {
                dgv.Columns[i].Visible = false;
            }

            dgv.AllowUserToResizeRows = false;
        }

        private void EjecutarComandoLoad()
        {
            ActualizarDatosNoAsignado(dgvGrillaNoAsignado, !string.IsNullOrEmpty(txtBuscarNoAsignado.Text) ? txtBuscarNoAsignado.Text : string.Empty);
            ActualizarDatosAsignado(dgvGrillaAsignado, !string.IsNullOrEmpty(txtBuscarAsignado.Text) ? txtBuscarAsignado.Text : string.Empty);
        }

        public virtual void EjecutarComandoAgregar(DataGridView dgv)
        {
            ActualizarDatosNoAsignado(dgvGrillaNoAsignado, !string.IsNullOrEmpty(txtBuscarNoAsignado.Text) ? txtBuscarNoAsignado.Text : string.Empty);
            ActualizarDatosAsignado(dgvGrillaAsignado, !string.IsNullOrEmpty(txtBuscarAsignado.Text) ? txtBuscarAsignado.Text : string.Empty);
        }

        public virtual void EjecutarComandoQuitar(DataGridView dgv)
        {
            ActualizarDatosNoAsignado(dgvGrillaNoAsignado, !string.IsNullOrEmpty(txtBuscarNoAsignado.Text) ? txtBuscarNoAsignado.Text : string.Empty);
            ActualizarDatosAsignado(dgvGrillaAsignado, !string.IsNullOrEmpty(txtBuscarAsignado.Text) ? txtBuscarAsignado.Text : string.Empty);
        }

        private void Seleccionar(DataGridView dgv, bool estado)
        {
            for (var i = 0; i < dgv.RowCount; i++)
            {
                dgv["EstaSeleccionado", i].Value = estado;
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
