using FontAwesome.Sharp;
using Serilog;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Seguridad.Configuracion;
using Sidkenu.LogicaNegocio.Servicios.Interface.Seguridad;

namespace SidkenuWF.Formularios.Base
{
    public partial class FormularioComun : FormularioBase
    {
        protected readonly ISeguridadServicio _seguridadServicio;
        protected readonly IConfiguracionServicio _configuracionServicio;
        protected readonly ILogger _logger;

        protected ConfiguracionDTO _configuracionDTO;

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

        public FormularioComun()
        {
            InitializeComponent();

            this._tieneRegistrosCargados = false;

            CargarAparienciaFormulario();
        }

        public FormularioComun(ISeguridadServicio seguridadServicio,
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

        public void PoblarComboBox(ComboBox cmb, object data, string displayMember, string valueMember)
        {
            cmb.DataSource = data;
            cmb.DisplayMember = displayMember;
            cmb.ValueMember = valueMember;
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            EjecutarComandoSalir(sender, e);
        }

        private void FormularioConsulta_Load(object sender, EventArgs e)
        {
            EjecutarComandoLoad(sender, e);
        }
        public virtual void EjecutarComandoSalir(object sender, EventArgs e)
        {
            this.Close();
        }

        public virtual void EjecutarComandoLoad(object sender, EventArgs e)
        {
        }

        public virtual bool VerificarAcceso(object sender)
        {
            return true;
        }

        // -------------------------------------------------------------------------------- //
        // -------------------        Metodos Privados        ----------------------------- //
        // -------------------------------------------------------------------------------- //

        private void CargarAparienciaFormulario()
        {
            this.pnlTitulo.BackColor = Constantes.ColorFormulario.ColorPanelTitulo;
            this.pnlLinea.BackColor = Constantes.ColorFormulario.ColorPanelLinea;

            this.lblTitulo.BackColor = Constantes.ColorFormulario.ColorFondoTitulo;
            this.lblTitulo.ForeColor = Constantes.ColorFormulario.ColorFuenteTitulo;

            this.imgLogo.BackColor = Constantes.ColorFormulario.ColorFondologo;
            this.imgLogo.IconColor = Constantes.ColorFormulario.ColorIconoLogo;

            CargarAparienciaBoton(btnSalir, false);
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
