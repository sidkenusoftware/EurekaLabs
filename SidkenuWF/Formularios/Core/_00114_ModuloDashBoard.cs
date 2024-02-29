using Serilog;
using Sidkenu.LogicaNegocio.Servicios.Interface.Seguridad;
using SidkenuWF.Formularios.Base;
// using System.Windows.Forms.DataVisualization;

namespace SidkenuWF.Formularios.Core
{
    public partial class _00114_ModuloDashBoard : FormularioMenuLateral
    {
        public _00114_ModuloDashBoard(ISeguridadServicio seguridadServicio,
                                      IConfiguracionServicio configuracionServicio,
                                      ILogger logger)
                                      : base(seguridadServicio, configuracionServicio, logger)
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void RefreshVentas()
        {
            this.chart1.Series[0].Points.Clear();
            this.chart1.Series[0].LegendText = "Hola";

            this.chart1.ChartAreas[0].AxisX.Interval = 1;


        }
    }
}
