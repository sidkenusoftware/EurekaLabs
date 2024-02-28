using FontAwesome.Sharp;
using Serilog;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Seguridad.Configuracion;
using Sidkenu.LogicaNegocio.Servicios.Interface.Seguridad;

namespace SidkenuWF.Formularios.Base
{
    public partial class FormularioConfiguracion : FormularioBase
    {
        protected readonly ISeguridadServicio _seguridadServicio;

        protected readonly IConfiguracionServicio _configuracionServicio;

        protected readonly ILogger _logger;

        protected ConfiguracionDTO _configuracionDTO;

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

        public FormularioConfiguracion()
        {
            InitializeComponent();
        }

        public FormularioConfiguracion(ISeguridadServicio seguridadServicio, 
            IConfiguracionServicio configuracionServicio, 
            ILogger logger)
            : this()
        {
            _seguridadServicio = seguridadServicio;
            _configuracionServicio = configuracionServicio;
            _logger = logger;

        }

        private void FormularioSetting_Load(object sender, EventArgs e)
        {

        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnEjecutar_Click(object sender, EventArgs e)
        {
            EjecutarComandoGuardar();
        }

        public virtual void EjecutarComandoGuardar()
        {

        }

        public virtual void CargarDatos(Guid? empresaId)
        {

        }
    }
}
