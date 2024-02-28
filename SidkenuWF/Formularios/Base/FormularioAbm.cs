using FontAwesome.Sharp;
using Serilog;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Base;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Seguridad.Configuracion;
using Sidkenu.LogicaNegocio.Servicios.Interface.Seguridad;
using SidkenuWF.Formularios.Base.Constantes;
using SidkenuWF.Formularios.Base.Controles;
using SidkenuWF.Formularios.Base.DTOs;

namespace SidkenuWF.Formularios.Base
{
    public partial class FormularioAbm : FormularioBase
    {
        private readonly List<ControlObligatorioDTO> _listaControlesObligatorios;

        protected readonly ISeguridadServicio _seguridadServicio;

        protected readonly IConfiguracionServicio _configuracionServicio;

        protected readonly ILogger _logger;

        protected ConfiguracionDTO _configuracionDTO;

        protected Guid? EntidadId { get; set; }
        protected Guid? EntidadSecundariaId { get; set; }
        public object? Entidad { get; set; } = null;
        public TipoOperacion TipoOperacion { get; set; }
        public bool RealizoAlgunaOperacion { get; set; } = false;

        public string TituloFormulario
        {
            set
            {
                this.Text = !string.IsNullOrEmpty(value)
                    ? value
                    : Constantes.FormularioConstantes.Titulo;
            }
        }

        private string _titulo;
        public string Titulo
        {
            set { this.lblTitulo.Text = value; this._titulo = value; }
            get { return this._titulo; }
        }

        public IconChar Logo
        {
            set { this.imgLogo.IconChar = value; }
        }

        public FormularioAbm()
        {
            InitializeComponent();

            CargarAparienciaFormulario();

            this.RealizoAlgunaOperacion = false;
            this._listaControlesObligatorios = new();
        }

        public FormularioAbm(ISeguridadServicio seguridadServicio, 
            IConfiguracionServicio configuracionServicio, 
            ILogger logger, 
            TipoOperacion tipoOperacion, 
            Guid? entidadId = null, 
            Guid? entidadSecundariaId = null)
            : this()
        {
            this.TipoOperacion = tipoOperacion;
            this.EntidadId = entidadId;
            this.EntidadSecundariaId = entidadSecundariaId;

            this._seguridadServicio = seguridadServicio;
            this._configuracionServicio = configuracionServicio;
            this._logger = logger;
        }

        private void FormularioAbm_Load(object sender, EventArgs e)
        {
            EjecutarComandoFormLoad(sender, e);
        }

        private void FormularioAbm_FormClosing(object sender, FormClosingEventArgs e)
        {
            EjecutarComandoFormClosing(sender, e);
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            EjecutarComandoSalir(sender, e);
        }

        private void BtnEjecutar_Click(object sender, EventArgs e)
        {
            try
            {
                if (TipoOperacion == TipoOperacion.Nuevo)
                {
                    if (VerificarDatosObligatorios())
                    {
                        var result = EjecutarComandoInsert();

                        if (result.State)
                        {
                            LimpiarControles(this);
                            OperacionAdicionalFinalizarInsert();
                            RealizoAlgunaOperacion = true;
                            MessageBox.Show(result.Message, @"Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show(result.Message, @"Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    return;
                }

                if (TipoOperacion == TipoOperacion.Modificar)
                {
                    if (VerificarDatosObligatorios())
                    {
                        var result = EjecutarComandoUpdate();

                        if (result.State)
                        {
                            RealizoAlgunaOperacion = true;
                            MessageBox.Show(result.Message, @"Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show(result.Message, @"Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        Close();
                    }
                }

                if (TipoOperacion == TipoOperacion.LlamadaExterna)
                {
                    if (VerificarDatosObligatorios())
                    {
                        var result = EjecutarComandoInsert();

                        if (result.State)
                        {                            
                            RealizoAlgunaOperacion = true;
                            MessageBox.Show(result.Message, @"Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show(result.Message, @"Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        Close();
                    }
                }
            }
            catch (Exception ex)
            {
                if (_configuracionDTO != null)
                {
                    if (_configuracionDTO.LogError)
                    {
                        _logger.Error($"Error al ejecutar la acción {this.TipoOperacion} en {this.Titulo}. Excep: {ex.Message}");
                    }

                    MessageBox.Show(ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        // ----------------------------------------------------------------- //
        // ---------         Metodos Publicos - Virtuales          --------- //
        // ----------------------------------------------------------------- //

        public virtual ResultDTO EjecutarComandoInsert()
        {
            return new ResultDTO { State = false };
        }

        public virtual void OperacionAdicionalFinalizarInsert()
        {
        }

        public virtual ResultDTO EjecutarComandoUpdate()
        {
            return new ResultDTO { State = false };
        }

        public virtual void CargarDatos(TipoOperacion tipoOperacion,
            Guid? entidadId,
            Guid? entidadSecundariaId)
        {
        }

        public virtual bool VerificarDatosObligatorios()
        {
            foreach (var objeto in _listaControlesObligatorios)
            {
                if (objeto.Control is TextBox)
                {
                    if (string.IsNullOrEmpty(((TextBox)objeto.Control).Text))
                    {
                        MessageBox.Show($"El campo {objeto.NombreControl} es Obligatorio", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return false;
                    }
                }
                else if (objeto.Control is RichTextBox)
                {
                    if (string.IsNullOrEmpty(((RichTextBox)objeto.Control).Text))
                    {
                        MessageBox.Show($"El campo {objeto.NombreControl} es Obligatorio", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return false;
                    }
                }
                else if (objeto.Control is NumericUpDown)
                {
                    if (string.IsNullOrEmpty(((NumericUpDown)objeto.Control).Text))
                    {
                        MessageBox.Show($"El campo {objeto.NombreControl} es Obligatorio", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return false;
                    }
                }
                else if (objeto.Control is ComboBox)
                {
                    if (((ComboBox)objeto.Control).Items.Count <= 0)
                    {
                        MessageBox.Show($"El campo {objeto.NombreControl} es Obligatorio", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return false;
                    }
                }
                else if (objeto.Control is SidkenuTextBox)
                {
                    if (string.IsNullOrEmpty(((SidkenuTextBox)objeto.Control).Texts))
                    {
                        MessageBox.Show($"El campo {objeto.NombreControl} es Obligatorio", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return false;
                    }
                }
                else if (objeto.Control is SidkenuComboBox)
                {
                    if (((SidkenuComboBox)objeto.Control).Items.Count <= 0)
                    {
                        MessageBox.Show($"El campo {objeto.NombreControl} es Obligatorio", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return false;
                    }
                }
            }

            return true;
        }

        public bool VerificarDatosParaCerrarLimpiarFormulario()
        {
            foreach (var objeto in _listaControlesObligatorios)
            {
                if (objeto.Control is TextBox)
                {
                    if (!string.IsNullOrEmpty(((TextBox)objeto.Control).Text))
                    {
                        return true;
                    }
                }
                else if (objeto.Control is RichTextBox)
                {
                    if (!string.IsNullOrEmpty(((RichTextBox)objeto.Control).Text))
                    {
                        return true;
                    }
                }
                else if (objeto.Control is NumericUpDown)
                {
                    if (!string.IsNullOrEmpty(((NumericUpDown)objeto.Control).Text))
                    {
                        return true;
                    }
                }
                else if (objeto.Control is ComboBox)
                {
                    if (((ComboBox)objeto.Control).Items.Count <= 0)
                    {
                        return true;
                    }
                }
                if (objeto.Control is SidkenuTextBox)
                {
                    if (!string.IsNullOrEmpty(((SidkenuTextBox)objeto.Control).Texts))
                    {
                        return true;
                    }
                }
                else if (objeto.Control is SidkenuComboBox)
                {
                    if (((SidkenuComboBox)objeto.Control).Items.Count <= 0)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public virtual void AgregarControlesObligatorios(object control, string nombreControl)
        {
            _listaControlesObligatorios.Add(new ControlObligatorioDTO
            {
                Control = control,
                NombreControl = nombreControl
            });
        }

        public virtual void EjecutarComandoSalir(object sender, EventArgs e)
        {
            this.Close();
        }

        public virtual void EjecutarComandoFormLoad(object sender, EventArgs e)
        {
            CargarDatos(TipoOperacion, EntidadId, EntidadSecundariaId);
        }

        public virtual void EjecutarComandoFormClosing(object sender, FormClosingEventArgs e)
        {
            if (VerificarDatosParaCerrarLimpiarFormulario()
                && TipoOperacion != TipoOperacion.Eliminar
                && TipoOperacion != TipoOperacion.LlamadaExterna
                && !RealizoAlgunaOperacion)
            {
                if (MessageBox.Show(@"Exiten Datos que aun no fueron guardados. ¿Desea Salir?",
                        @"Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        // ----------------------------------------------------------------- //
        // ----------------         Metodos privados          -------------- //
        // ----------------------------------------------------------------- //

        private void CargarAparienciaFormulario()
        {
            this.pnlTitulo.BackColor = Constantes.ColorFormulario.ColorPanelTitulo;
            this.pnlLinea.BackColor = Constantes.ColorFormulario.ColorPanelLinea;

            this.pnlBotonera.BackColor = Constantes.ColorFormulario.ColorPanelBotoneraLateral;

            this.lblTitulo.BackColor = Constantes.ColorFormulario.ColorFondoTitulo;
            this.lblTitulo.ForeColor = Constantes.ColorFormulario.ColorFuenteTitulo;

            this.imgLogo.BackColor = Constantes.ColorFormulario.ColorFondologo;
            this.imgLogo.IconColor = Constantes.ColorFormulario.ColorIconoLogo;

            CargarAparienciaBoton(btnSalir, false);

            CargarAparienciaBotonMenuLateral(btnEjecutar, false);
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
    }
}