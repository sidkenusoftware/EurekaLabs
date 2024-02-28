using Serilog;
using Sidkenu.LogicaNegocio.Servicios.Interface.Core;
using Sidkenu.LogicaNegocio.Servicios.Interface.Seguridad;
using SidkenuWF.Formularios.Base;
using SidkenuWF.Formularios.Base.Constantes;

namespace SidkenuWF.Formularios.Core
{
    public partial class _00108_ModuloVenta : FormularioMenuLateral
    {
        public _00108_ModuloVenta(ISeguridadServicio seguridadServicio,
                                  IConfiguracionServicio configuracionServicio,
                                  ILogger logger)
                                  : base(seguridadServicio, configuracionServicio, logger)
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void ConsultaCajasToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void BtnMovimiento_Click(object sender, EventArgs e)
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

        private void NuevoTipoDeGastosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formulario = new _00107_TipoGasto_Abm(base._seguridadServicio,
                                                        base._configuracionServicio,
                                                        base._logger,
                                                        Program.Container.GetInstance<ITipoGastoServicio>(),
                                                        TipoOperacion.Nuevo);

            FormularioSeguridad.VerificarAcceso(formulario, _seguridadServicio, _logger, _configuracionDTO);
        }

        private void ConsultaTipoGastosToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void ConsultaDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formulario = new _00102_Cliente(base._seguridadServicio,
                                                  base._configuracionServicio,
                                                  base._logger,
                                                  Program.Container.GetInstance<IClienteServicio>());

            if (FormularioSeguridad.VerificarAccesoParaAbrirEnPanel(formulario, base._seguridadServicio, base._logger, base._configuracionDTO))
            {
                AbrirFormularioDentroDelPanel(formulario, this.pnlContenedor);
            }
        }

        private void NuevoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formulario = new _00103_Cliente_Abm(base._seguridadServicio,
                                                        base._configuracionServicio,
                                                        base._logger,
                                                        Program.Container.GetInstance<IClienteServicio>(),
                                                        Program.Container.GetInstance<ITipoResponsabilidadServicio>(),
                                                        Program.Container.GetInstance<ITipoDocumentoServicio>(),
                                                        Program.Container.GetInstance<IListaPrecioServicio>(),
                                                        TipoOperacion.Nuevo);

            FormularioSeguridad.VerificarAcceso(formulario, _seguridadServicio, _logger, _configuracionDTO);
        }

        private void ConsultaDeListasDePreciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formulario = new _00138_ListaPrecio(base._seguridadServicio,
                                                    base._configuracionServicio,
                                                    base._logger,
                                                    Program.Container.GetInstance<IListaPrecioServicio>());

            if (FormularioSeguridad.VerificarAccesoParaAbrirEnPanel(formulario, base._seguridadServicio, base._logger, base._configuracionDTO))
            {
                AbrirFormularioDentroDelPanel(formulario, this.pnlContenedor);
            }
        }

        private void NuevaListaDePrecioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formulario = new _00139_ListaPrecio_Abm(base._seguridadServicio,
                                                        base._configuracionServicio,
                                                        base._logger,
                                                        Program.Container.GetInstance<IListaPrecioServicio>(),
                                                        TipoOperacion.Nuevo);

            FormularioSeguridad.VerificarAcceso(formulario, _seguridadServicio, _logger, _configuracionDTO);
        }

        private void ConsultaDeProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formulario = new _00104_Proveedor(base._seguridadServicio,
                                                  base._configuracionServicio,
                                                  base._logger,
                                                  Program.Container.GetInstance<IProveedorServicio>());

            if (FormularioSeguridad.VerificarAccesoParaAbrirEnPanel(formulario, base._seguridadServicio, base._logger, base._configuracionDTO))
            {
                AbrirFormularioDentroDelPanel(formulario, this.pnlContenedor);
            }
        }

        private void NuevoProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formulario = new _00105_Proveedor_Abm(base._seguridadServicio,
                                                        base._configuracionServicio,
                                                        base._logger,
                                                        Program.Container.GetInstance<IProveedorServicio>(),
                                                        Program.Container.GetInstance<ITipoResponsabilidadServicio>(),
                                                        TipoOperacion.Nuevo);

            FormularioSeguridad.VerificarAcceso(formulario, _seguridadServicio, _logger, _configuracionDTO);
        }
    }
}
