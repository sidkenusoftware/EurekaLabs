using FontAwesome.Sharp;
using Serilog;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Seguridad.Configuracion;
using Sidkenu.LogicaNegocio.Servicios.Interface.Seguridad;

namespace SidkenuWF.Formularios.Base
{
    public partial class FormularioConsulta : Form
    {
        protected readonly ISeguridadServicio _seguridadServicio;
        protected readonly IConfiguracionServicio _configuracionServicio;
        protected readonly ILogger _logger;

        protected ConfiguracionDTO _configuracionDTO;

        public Guid? EntidadId { get; set; }
        public object? Entidad { get; set; }

        public (bool, bool) BotoneraLateralVisible
        {
            set
            {
                this.pnlBotonera.Visible = value.Item1;
                this.pnlCerrarBotoneraLateral.Visible = value.Item2;
            }
        }

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

        public IconChar Logo
        {
            set { this.imgLogo.IconChar = value; }
        }

        private bool _tieneRegistrosCargados;
        public bool TieneRegistrosCargados { get => _tieneRegistrosCargados; }

        public bool MostrarBotonesABM
        {
            set
            {
                this.btnNuevo.Visible = value;
                this.btnEditar.Visible = value;
                this.btnEliminar.Visible = value;
            }
        }

        public bool MostrarBotonAlta
        {
            set
            {
                this.btnNuevo.Visible = value;
            }
        }

        public bool MostrarBotonBaja
        {
            set
            {
                this.btnEliminar.Visible = value;
            }
        }

        public bool MostrarBotonModificar
        {
            set
            {
                this.btnEditar.Visible = value;
            }
        }

        public bool MostrarBotonesSeleccion
        {
            set
            {
                this.btnDesmarcarTodo.Visible = value;
                this.btnMarcarTodo.Visible = value;
            }
        }

        public bool MostrarContadorRegistros
        {
            set
            {
                this.lblCantidadRegistros.Visible = value;
            }
        }

        public FormularioConsulta()
        {
            InitializeComponent();

            this._tieneRegistrosCargados = false;
            this.pnlBotonera.Visible = false;
            this.pnlCerrarBotoneraLateral.Visible = false;

            this.btnNuevo.Visible = true;
            this.btnEditar.Visible = true;
            this.btnEliminar.Visible = true;

            this.btnDesmarcarTodo.Visible = false;
            this.btnMarcarTodo.Visible = false;
            this.MostrarContadorRegistros = true;

            CargarAparienciaFormulario();
        }

        public FormularioConsulta(ISeguridadServicio seguridadServicio,
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

        private void ChkEliminados_CheckedChanged(object? sender, EventArgs e)
        {
            EjecutarComandoCheckedChanged();
        }

        public virtual void EjecutarComandoCheckedChanged()
        {
            this.btnEditar.Enabled = !this.chkVerEliminados.Checked;

            Buscar(this.txtBuscar.Text, this.chkVerEliminados.Checked);
        }

        private void BtnBuscar_Click(object? sender, EventArgs e)
        {
            Buscar(txtBuscar.Text, chkVerEliminados.Checked);
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            EjecutarComandoSalir(sender, e);
        }

        public virtual void DgvGrilla_DataSourceChanged(object sender, EventArgs e)
        {
            var mensaje = "Cantidad de Registros";
            this.lblCantidadRegistros.Text = this.dgvGrilla.DataSource != null
                && dgvGrilla.Rows.Count > 0
                ? this.lblCantidadRegistros.Text = $"{mensaje}: {this.dgvGrilla.Rows.Count}"
                : this.lblCantidadRegistros.Text = $"{mensaje}: {0}";

            this._tieneRegistrosCargados = this.dgvGrilla.RowCount > 0;
        }

        private void BtnCerraMenuLateral_Click(object sender, EventArgs e)
        {
            this.pnlBotonera.Visible = !this.pnlBotonera.Visible;
        }

        private void FormularioConsulta_Load(object sender, EventArgs e)
        {
            EjecutarComandoLoad(sender, e);
        }

        private void FormularioConsulta_Shown(object sender, EventArgs e)
        {
            EjecutarComandoShow(sender, e);
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                if (VerificarAcceso(sender))
                {
                    if (EjecutarComandoNuevo(sender, e))
                    {
                        Buscar(string.Empty, chkVerEliminados.Checked);
                    }
                }
                else
                {
                    MessageBox.Show(Constantes.Mensajes.AccesoDenegado, "Atención",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atención",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            }
        }



        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (dgvGrilla.RowCount <= 0)
            {
                MessageBox.Show("No hay registros cargados.", "Atención",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                if (VerificarAcceso(sender))
                {
                    if (EjecutarComandoEditar(sender, e))
                    {
                        Buscar(string.Empty, chkVerEliminados.Checked);
                    }
                }
                else
                {
                    MessageBox.Show(Constantes.Mensajes.AccesoDenegado, "Atención",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atención",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvGrilla.RowCount <= 0)
            {
                MessageBox.Show("No hay registros cargados.", "Atención",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                if (VerificarAcceso(sender))
                {
                    var mensaje = !this.chkVerEliminados.Checked
                    ? "¿Esta seguro de ELIMINAR el registro seleccionado ?"
                    : "¿Esta seguro de ACTIVAR el registro seleccionado ?";

                    if (MessageBox.Show(mensaje, "Atención",
                                        MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (EjecutarComandoEliminar(sender, e))
                        {
                            Buscar(string.Empty, chkVerEliminados.Checked);
                        }
                    }
                }
                else
                {
                    MessageBox.Show(Constantes.Mensajes.AccesoDenegado, "Atención",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atención",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            }
        }

        private void TxtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            EjecutarComandoKeyPress(sender, e);
        }
        private void DgvGrilla_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            EjecutarComandoRowEnter(sender, e);
        }

        private void BtnMarcarTodo_Click(object sender, EventArgs e)
        {
            SeleccionarRows(true);
        }

        private void BtnDesmarcarTodo_Click(object sender, EventArgs e)
        {
            SeleccionarRows(false);
        }

        public virtual void EjecutarComandoRowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvGrilla.RowCount > 0)
            {
                Entidad = this.dgvGrilla.Rows[e.RowIndex].DataBoundItem;
                EntidadId = (Guid)this.dgvGrilla["Id", e.RowIndex].Value;
            }
        }

        public virtual void DgvGrilla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                ((DataGridView)sender).EndEdit();
            }
        }

        public virtual void Buscar(string cadenaBuscar, bool verEliminados = false)
        {
            FormatearDatos(this.dgvGrilla);
        }

        public virtual void EjecutarComandoSalir(object sender, EventArgs e)
        {
            this.Close();
        }

        public virtual void EjecutarComandoLoad(object sender, EventArgs e)
        {
            // txtBuscar.Clear();
            //Buscar(txtBuscar.Text, chkVerEliminados.Checked);
        }

        public virtual void EjecutarComandoShow(object sender, EventArgs e)
        {
            txtBuscar.Clear();
            Buscar(txtBuscar.Text, chkVerEliminados.Checked);
        }

        public virtual void EjecutarComandoKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                Buscar(txtBuscar.Text, chkVerEliminados.Checked);
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

        public virtual bool EjecutarComandoNuevo(object sender, EventArgs e)
        {
            return false;
        }

        public virtual bool EjecutarComandoEditar(object sender, EventArgs e)
        {
            return false;
        }

        public virtual bool EjecutarComandoEliminar(object sender, EventArgs e)
        {
            return false;
        }

        public virtual void EjecutarComandoColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
        {
            
        }

        public virtual void FormatearDatos(DataGridView dgvGrilla)
        {
            dgvGrilla.ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle
            {
                Alignment = DataGridViewContentAlignment.MiddleCenter,
            };

            for (int i = 0; i < dgvGrilla.ColumnCount; i++)
            {
                dgvGrilla.Columns[i].Visible = false;
            }

            SeleccionarRows(false);

            dgvGrilla.AllowUserToResizeRows = false;
        }

        public virtual void SeleccionarRows(bool estado)
        {
            for (var i = 0; i < dgvGrilla.RowCount; i++)
            {
                dgvGrilla["EstaSeleccionado", i].Value = estado;
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

            this.pnlBotonera.BackColor = Constantes.ColorFormulario.ColorPanelBotoneraLateral;
            this.pnlCerrarBotoneraLateral.BackColor = Constantes.ColorFormulario.ColorPanelBotoneraLateral;
            this.pnlLineaLateral.BackColor = Constantes.ColorFormulario.ColorPanelLineaLateral;

            this.pnlLineaInferior.BackColor = Constantes.ColorFormulario.ColorPanelLinea;

            this.lblTitulo.BackColor = Constantes.ColorFormulario.ColorFondoTitulo;
            this.lblTitulo.ForeColor = Constantes.ColorFormulario.ColorFuenteTitulo;

            this.lblVerEliminado.BackColor = Constantes.ColorFormulario.ColorFondoTitulo;
            this.lblVerEliminado.ForeColor = Constantes.ColorFormulario.ColorFuenteTitulo;

            this.imgLogo.BackColor = Constantes.ColorFormulario.ColorFondologo;
            this.imgLogo.IconColor = Constantes.ColorFormulario.ColorIconoLogo;

            CargarAparienciaBoton(btnSalir, false);
            CargarAparienciaBoton(btnBuscar);

            CargarAparienciaBotonAbm(btnNuevo, false);
            CargarAparienciaBotonAbm(btnEditar, false);
            CargarAparienciaBotonAbm(btnEliminar, false);

            CargarAparienciaBotonMenuLateral(btnCerraMenuLateral, false);
        }

        private void CargarAparienciaBoton(IconButton button, bool mostrarBorde = true)
        {
            button.IconColor = Constantes.ColorFormulario.ColorIconoBoton;
            button.FlatAppearance.BorderColor = Constantes.ColorFormulario.ColorBordeBoton;
            button.FlatAppearance.BorderSize = mostrarBorde ? 1 : 0;
            button.ForeColor = Constantes.ColorFormulario.ColorFuenteBoton;
            button.BackColor = Constantes.ColorFormulario.ColorFondoBoton;
        }

        public virtual void CargarAparienciaBotonMenuLateral(IconButton button, bool mostrarBorde = true)
        {
            button.IconColor = Constantes.ColorFormulario.ColorIconoBotonLateral;
            button.FlatAppearance.BorderColor = Constantes.ColorFormulario.ColorBordeBotonLateral;
            button.FlatAppearance.BorderSize = mostrarBorde ? 1 : 0;
            button.ForeColor = Constantes.ColorFormulario.ColorFuenteBotonLateral;
            button.BackColor = Constantes.ColorFormulario.ColorFondoBotonLateral;
        }

        private void CargarAparienciaBotonAbm(IconButton button, bool mostrarBorde = true)
        {
            button.IconColor = Constantes.ColorFormulario.ColorIconoBotonAbm;
            button.FlatAppearance.BorderColor = Constantes.ColorFormulario.ColorBordeBotonAbm;
            button.FlatAppearance.BorderSize = mostrarBorde ? 1 : 0;
            button.ForeColor = Constantes.ColorFormulario.ColorFuenteBotonAbm;
            button.BackColor = Constantes.ColorFormulario.ColorFondoBotonAbm;
        }

        private void DgvGrilla_Paint(object sender, PaintEventArgs e)
        {
            EjecutarComandoPaint(sender, e);
        }

        public virtual void EjecutarComandoPaint(object sender, PaintEventArgs e)
        {
        }

        private void dgvGrilla_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
        {
            EjecutarComandoColumnWidthChanged(sender, e);
        }

        
    }
}
