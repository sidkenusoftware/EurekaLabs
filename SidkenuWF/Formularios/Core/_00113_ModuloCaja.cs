using Serilog;
using Sidkenu.LogicaNegocio.Servicios.Interface.Core;
using Sidkenu.LogicaNegocio.Servicios.Interface.Seguridad;
using SidkenuWF.Formularios.Base;
using SidkenuWF.Formularios.Base.Constantes;

namespace SidkenuWF.Formularios.Core
{
    public partial class _00113_ModuloCaja : FormularioMenuLateral
    {
        public _00113_ModuloCaja(ISeguridadServicio seguridadServicio,
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

        private void CajasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formulario = new _00115_Movimientos(base._seguridadServicio,
                                                    base._configuracionServicio,
                                                    base._logger,
                                                    Program.Container.GetInstance<ICajaServicio>(),
                                                    Program.Container.GetInstance<IMovimientoCajaServicio>());

            if (FormularioSeguridad.VerificarAccesoParaAbrirEnPanel(formulario, base._seguridadServicio, base._logger, base._configuracionDTO))
            {
                AbrirFormularioDentroDelPanel(formulario, this.pnlContenedor);
            }
        }

        private void NuevaCajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formulario = new _00101_Caja_Abm(base._seguridadServicio,
                                                 base._configuracionServicio,
                                                 base._logger,
                                                 Program.Container.GetInstance<ICajaServicio>(),
                                                 TipoOperacion.Nuevo);

            FormularioSeguridad.VerificarAcceso(formulario, _seguridadServicio, _logger, _configuracionDTO);
        }

        private void CajaConsultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formulario = new _00100_Caja(base._seguridadServicio,
                                             base._configuracionServicio,
                                             base._logger,
                                             Program.Container.GetInstance<ICajaServicio>());

            if (FormularioSeguridad.VerificarAccesoParaAbrirEnPanel(formulario, base._seguridadServicio, base._logger, base._configuracionDTO))
            {
                AbrirFormularioDentroDelPanel(formulario, this.pnlContenedor);
            }
        }

        private void NuevoTipoGastoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var formulario = new _00107_TipoGasto_Abm(base._seguridadServicio,
                                                      base._configuracionServicio,
                                                      base._logger,
                                                      Program.Container.GetInstance<ITipoGastoServicio>(),
                                                      TipoOperacion.Nuevo);

            FormularioSeguridad.VerificarAcceso(formulario, _seguridadServicio, _logger, _configuracionDTO);
        }

        private void ConsultaTipoGastosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var formulario = new _00106_TipoGasto(base._seguridadServicio,
                                                  base._configuracionServicio,
                                                  base._logger,
                                                  Program.Container.GetInstance<ITipoGastoServicio>());

            if (FormularioSeguridad.VerificarAccesoParaAbrirEnPanel(formulario, base._seguridadServicio, base._logger, base._configuracionDTO))
            {
                AbrirFormularioDentroDelPanel(formulario, this.pnlContenedor);
            }
        }
    }
}
