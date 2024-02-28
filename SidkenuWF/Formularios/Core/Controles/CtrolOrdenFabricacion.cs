using Serilog;
using Sidkenu.AccesoDatos.Constantes.Enum;
using Sidkenu.LogicaNegocio.Servicios.Interface.Seguridad;
using SidkenuWF.Helpers;

namespace SidkenuWF.Formularios.Core.Controles
{
    public partial class CtrolOrdenFabricacion : UserControl
    {

        private readonly ISeguridadServicio _seguridadServicio;
        private readonly IConfiguracionServicio _configuracionServicio;
        private readonly ILogger _logger;



        private CtrolOrdenFabricacionVM _ordenFabricacionVM;
        public CtrolOrdenFabricacionVM OrdenFabricacionVM
        {
            set
            {
                lblNroRef.Text = value.Numero.ToString().PadLeft(7, '0');
                lblArtBase.Text = value.Descripcion;

                this.btnInformacion.Tag = value;
                this.btnCancelarFabricacion.Tag = value;
                this.btnProcesar.Tag = value;
                this.btnFinalizar.Tag = value;

                btnInformacion.IconColor = value.EstadoOrdenFabricacion == EstadoOrdenFabricacion.Pendiente
                                           ? !value.SePuedeFabricar ? Color.Red : Color.Green
                                           : Color.Green;

                _ordenFabricacionVM = value;

                btnCancelarFabricacion.Visible = value.EstadoOrdenFabricacion == EstadoOrdenFabricacion.EnProceso;

                btnProcesar.Visible = value.EstadoOrdenFabricacion == EstadoOrdenFabricacion.Pendiente
                    && value.SePuedeFabricar;

                btnFinalizar.Visible = value.EstadoOrdenFabricacion == EstadoOrdenFabricacion.EnProceso;

                this.BackColor = value.OrigenFabricacion == OrigenFabricacion.Fabrica
                    ? Color.LightYellow
                    : Color.LightBlue;
            }

            get { return _ordenFabricacionVM; }
        }



        public CtrolOrdenFabricacion(ISeguridadServicio seguridadServicio,
                                     IConfiguracionServicio configuracionServicio,
                                     ILogger logger)
        {
            InitializeComponent();

            this._seguridadServicio = seguridadServicio;
            this._configuracionServicio = configuracionServicio;
            this._logger = logger;
        }
    }
}