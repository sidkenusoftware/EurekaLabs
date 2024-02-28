using Serilog;
using Sidkenu.LogicaNegocio.Servicios.Interface.Seguridad;
using SidkenuWF.Formularios.Base;

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
    }
}
