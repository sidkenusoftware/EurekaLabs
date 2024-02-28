using Serilog;
using Sidkenu.LogicaNegocio.Servicios.Interface.Seguridad;
using SidkenuWF.Formularios.Base;
using SidkenuWF.Formularios.Base.Constantes;

namespace SidkenuWF.Formularios.Seguridad
{
    public partial class _00020_ModuloSeguridad : FormularioMenuLateral
    {
        public _00020_ModuloSeguridad(ISeguridadServicio seguridadServicio,
                                      IConfiguracionServicio configuracionServicio,
                                      ILogger logger)
                                      : base(seguridadServicio, configuracionServicio, logger)
        {
            InitializeComponent();

            this.btnEmprea.Click += BtnBotonSeleccionado_Click;
            this.btnPersona.Click += BtnBotonSeleccionado_Click;
            this.btnConfiguracionGeneral.Click += BtnBotonSeleccionado_Click;
            this.btnUsuario.Click += BtnBotonSeleccionado_Click;
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnEmpresa_Click(object sender, EventArgs e)
        {
            var formulario = new _00001_Empresa(base._seguridadServicio,
                                                base._configuracionServicio,
                                                base._logger,
                                                Program.Container.GetInstance<IEmpresaServicio>());

            if (FormularioSeguridad.VerificarAccesoParaAbrirEnPanel(formulario, base._seguridadServicio, base._logger, base._configuracionDTO))
            {
                AbrirFormularioDentroDelPanel(formulario, this.pnlContenedor);
            }
        }



        private void BtnPersona_Click(object sender, EventArgs e)
        {
            var formulario = new _00003_Persona(base._seguridadServicio,
                                                base._configuracionServicio,
                                                base._logger,
                                                Program.Container.GetInstance<IPersonaServicio>());

            if (FormularioSeguridad.VerificarAccesoParaAbrirEnPanel(formulario, base._seguridadServicio, base._logger, base._configuracionDTO))
            {
                AbrirFormularioDentroDelPanel(formulario, this.pnlContenedor);
            }
        }

        private void BtnConfiguracionGeneral_Click(object sender, EventArgs e)
        {
            var formulario = new _00018_ConfiguracionGeneral(base._seguridadServicio,
                                                             base._configuracionServicio,
                                                             base._logger);

            if (FormularioSeguridad.VerificarAccesoParaAbrirEnPanel(formulario, base._seguridadServicio, base._logger, base._configuracionDTO))
            {
                AbrirFormularioDentroDelPanel(formulario, this.pnlContenedor);
            }
        }

        private void BtnUsuario_Click(object sender, EventArgs e)
        {
            var formulario = new _00006_Usuario(base._seguridadServicio,
                                               base._configuracionServicio,
                                               base._logger,
                                               Program.Container.GetInstance<IUsuarioServicio>());

            if (FormularioSeguridad.VerificarAccesoParaAbrirEnPanel(formulario, base._seguridadServicio, base._logger, base._configuracionDTO))
            {
                AbrirFormularioDentroDelPanel(formulario, this.pnlContenedor);
            }
        }

        private void PnlContenedor_ControlRemoved(object sender, ControlEventArgs e)
        {
            if (this.pnlContenedor.Controls.Count <= 0)
            {
                DeshabilitarBotonPanelBotonera();
            }
        }

        private void ABMEmpresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formulario = new _00002_Empresa_Abm(base._seguridadServicio,
                                                    base._configuracionServicio,
                                                    base._logger,
                                                    Program.Container.GetInstance<IEmpresaServicio>(),
                                                    Program.Container.GetInstance<ITipoResponsabilidadServicio>(),
                                                    Program.Container.GetInstance<IProvinciaServicio>(),
                                                    Program.Container.GetInstance<ILocalidadServicio>(),
                                                    Program.Container.GetInstance<IIngresoBrutoServicio>(),
                                                    TipoOperacion.Nuevo);

            FormularioSeguridad.VerificarAcceso(formulario, _seguridadServicio, _logger, _configuracionDTO);
        }

        private void NuevaPersonaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formulario = new _00004_Persona_Abm(base._seguridadServicio,
                                                        base._configuracionServicio,
                                                        base._logger,
                                                        Program.Container.GetInstance<IPersonaServicio>(),
                                                        TipoOperacion.Nuevo);

            FormularioSeguridad.VerificarAcceso(formulario, _seguridadServicio, _logger, _configuracionDTO);
        }

        private void ABMCondicionDeIvaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formulario = new _00011_TipoResponsabilidad(Program.Container.GetInstance<ISeguridadServicio>(),
                                                     Program.Container.GetInstance<IConfiguracionServicio>(),
                                                     Program.Container.GetInstance<ILogger>(),
                                                     Program.Container.GetInstance<ITipoResponsabilidadServicio>());

            FormularioSeguridad.VerificarAcceso(formulario, _seguridadServicio, _logger, _configuracionDTO);
        }

        private void ABMGrupoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formulario = new _00015_Grupo(Program.Container.GetInstance<ISeguridadServicio>(),
                                              Program.Container.GetInstance<IConfiguracionServicio>(),
                                              Program.Container.GetInstance<ILogger>(),
                                              Program.Container.GetInstance<IGrupoServicio>());

            FormularioSeguridad.VerificarAcceso(formulario, _seguridadServicio, _logger, _configuracionDTO);
        }

        private void IngresoBrutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formulario = new _00013_IngresoBruto(Program.Container.GetInstance<ISeguridadServicio>(),
                                                    Program.Container.GetInstance<IConfiguracionServicio>(),
                                                    Program.Container.GetInstance<ILogger>(),
                                                    Program.Container.GetInstance<IIngresoBrutoServicio>());

            FormularioSeguridad.VerificarAcceso(formulario, _seguridadServicio, _logger, _configuracionDTO);
        }

        private void provinciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formulario = new _00007_Provincia(Program.Container.GetInstance<ISeguridadServicio>(),
                                                  Program.Container.GetInstance<IConfiguracionServicio>(),
                                                  Program.Container.GetInstance<ILogger>(),
                                                  Program.Container.GetInstance<IProvinciaServicio>());

            FormularioSeguridad.VerificarAcceso(formulario, _seguridadServicio, _logger, _configuracionDTO);
        }

        private void localidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formulario = new _00009_Localidad(Program.Container.GetInstance<ISeguridadServicio>(),
                                                  Program.Container.GetInstance<IConfiguracionServicio>(),
                                                  Program.Container.GetInstance<ILogger>(),
                                                  Program.Container.GetInstance<ILocalidadServicio>());

            FormularioSeguridad.VerificarAcceso(formulario, _seguridadServicio, _logger, _configuracionDTO);
        }

        private void formularioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formulario = new _00017_Formulario(Program.Container.GetInstance<ISeguridadServicio>(),
                                                   Program.Container.GetInstance<IFormularioServicio>());

            FormularioSeguridad.VerificarAcceso(formulario, _seguridadServicio, _logger, _configuracionDTO);
        }
    }
}
