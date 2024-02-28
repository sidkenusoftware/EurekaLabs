using FontAwesome.Sharp;
using Serilog;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Seguridad.Configuracion;
using Sidkenu.LogicaNegocio.Servicios.Interface.Seguridad;
using SidkenuWF.Formularios.Base.Constantes;

namespace SidkenuWF.Formularios.Base
{
    public partial class FormularioMenuLateral : Form
    {
        protected readonly ISeguridadServicio _seguridadServicio;
        protected readonly IConfiguracionServicio _configuracionServicio;
        protected readonly ILogger _logger;

        protected ConfiguracionDTO _configuracionDTO;

        protected IconButton botonSeleccionado;
        protected Panel bordeCostadoBotoneraMenu;

        public string TituloModulo
        {
            set { this.lblTitulo.Text = value; }
        }

        public Color ColorTituloModulo 
        {
            set { this.pnlTitulo.BackColor = value; }
        }

        public FormularioMenuLateral()
        {
            InitializeComponent();

            // Borde para resaltar el boton seleccionado
            this.bordeCostadoBotoneraMenu = new Panel
            {
                Size = new Size(2, 45)
            };

            this.pnlMenuLateral.Controls.Add(bordeCostadoBotoneraMenu);

            CargarApariencia();
        }

        public FormularioMenuLateral(ISeguridadServicio seguridadServicio,
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

        private void CargarApariencia()
        {
            this.pnlMenuLateral.BackColor = Base.Constantes.ColorFormulario.ColorPanelBotoneraLateral;
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        protected void BtnBotonSeleccionado_Click(object sender, EventArgs e)
        {
            ActivarBotonPanelBotonera(sender);
        }

        protected void ActivarBotonPanelBotonera(object boton)
        {
            if (boton != null)
            {
                DeshabilitarBotonPanelBotonera();

                botonSeleccionado = (IconButton)boton;

                botonSeleccionado.ForeColor = ColorFormulario.ColorFuenteBotonPanelBotoneraSeleccionado;

                botonSeleccionado.IconColor = ColorFormulario.ColorIconoBotonPanelBotoneraSeleccionado;

                bordeCostadoBotoneraMenu.BackColor = ColorFormulario.ColorIconoBotonPanelBotoneraSeleccionado;

                bordeCostadoBotoneraMenu.Location =
                    new Point(botonSeleccionado.Location.X, botonSeleccionado.Location.Y);

                bordeCostadoBotoneraMenu.Visible = true;

                bordeCostadoBotoneraMenu.BringToFront();
            }
        }

        protected void DeshabilitarBotonPanelBotonera()
        {
            if (botonSeleccionado != null)
            {
                botonSeleccionado.ForeColor = ColorFormulario.ColorFuentePanelBotoneraBotonSinSeleccionar;

                botonSeleccionado.IconColor = ColorFormulario.ColorIconoBotonPanelBotoneraSinSeleccionar;

                bordeCostadoBotoneraMenu.Visible = false;
            }
        }

        private void FormularioMenuLateral_Load(object sender, EventArgs e)
        {

        }

        protected virtual void AbrirFormularioDentroDelPanel(Form formulario, Panel pnlContenedor)
        {
            if (pnlContenedor.Controls.Count > 0)
                pnlContenedor.Controls.RemoveAt(0);

            Form fh = formulario as Form;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            pnlContenedor.Controls.Add(fh);
            pnlContenedor.Tag = fh;
            fh.Show();
            fh.BringToFront();
        }
    }
}
