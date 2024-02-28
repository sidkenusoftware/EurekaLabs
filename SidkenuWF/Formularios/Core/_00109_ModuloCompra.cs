using Serilog;
using Sidkenu.LogicaNegocio.Servicios.Interface.Core;
using Sidkenu.LogicaNegocio.Servicios.Interface.Seguridad;
using SidkenuWF.Formularios.Base;
using SidkenuWF.Formularios.Base.Constantes;

namespace SidkenuWF.Formularios.Core
{
    public partial class _00109_ModuloCompra : FormularioMenuLateral
    {
        public _00109_ModuloCompra(ISeguridadServicio seguridadServicio,
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

        private void BtnPedidos_Click(object sender, EventArgs e)
        {
            var formulario = new _00157_Pedidos(base._seguridadServicio,
                                                base._configuracionServicio,
                                                base._logger,
                                                Program.Container.GetInstance<IPedidoServicio>());

            if (FormularioSeguridad.VerificarAccesoParaAbrirEnPanel(formulario, base._seguridadServicio, base._logger, base._configuracionDTO))
            {
                AbrirFormularioDentroDelPanel(formulario, this.pnlContenedor);
            }
        }

        private void NuevoProveedorMenu_Click(object sender, EventArgs e)
        {
            var formulario = new _00105_Proveedor_Abm(base._seguridadServicio,
                                                    base._configuracionServicio,
                                                    base._logger,
                                                    Program.Container.GetInstance<IProveedorServicio>(),
                                                    Program.Container.GetInstance<ITipoResponsabilidadServicio>(),
                                                    TipoOperacion.Nuevo);

            FormularioSeguridad.VerificarAcceso(formulario, _seguridadServicio, _logger, _configuracionDTO);
        }

        private void ConsultaProveedorMenuClick(object sender, EventArgs e)
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

        private void NuevoDepositoMenu_Click(object sender, EventArgs e)
        {
            var formulario = new _00137_Deposito_Abm(base._seguridadServicio,
                                                    base._configuracionServicio,
                                                    base._logger,
                                                    Program.Container.GetInstance<IDepositoServicio>(),
                                                    TipoOperacion.Nuevo);

            FormularioSeguridad.VerificarAcceso(formulario, _seguridadServicio, _logger, _configuracionDTO);
        }

        private void ConsultaDepositoMenu_Click(object sender, EventArgs e)
        {
            var formulario = new _00136_Deposito(base._seguridadServicio,
                                                  base._configuracionServicio,
                                                  base._logger,
                                                  Program.Container.GetInstance<IDepositoServicio>());

            if (FormularioSeguridad.VerificarAccesoParaAbrirEnPanel(formulario, base._seguridadServicio, base._logger, base._configuracionDTO))
            {
                AbrirFormularioDentroDelPanel(formulario, this.pnlContenedor);
            }
        }

        private void NuevoProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formulario = new _00123_Articulo_Abm(base._seguridadServicio,
                                                     base._configuracionServicio,
                                                     base._logger,
                                                     Program.Container.GetInstance<IArticuloServicio>(),
                                                     Program.Container.GetInstance<IFamiliaServicio>(),
                                                     Program.Container.GetInstance<IUnidadMedidaServicio>(),
                                                     Program.Container.GetInstance<IMarcaServicio>(),
                                                     Program.Container.GetInstance<ICondicionIvaServicio>(),
                                                     Program.Container.GetInstance<IProveedorServicio>(),
                                                     Program.Container.GetInstance<IArticuloProveedorServicio>(),
                                                     Program.Container.GetInstance<IDepositoServicio>(),
                                                     Program.Container.GetInstance<IListaPrecioServicio>(),
                                                     TipoOperacion.Nuevo);

            FormularioSeguridad.VerificarAcceso(formulario, _seguridadServicio, _logger, _configuracionDTO);
        }

        private void ConsultaProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formulario = new _00122_Articulo(base._seguridadServicio,
                                                base._configuracionServicio,
                                                base._logger,
                                                Program.Container.GetInstance<IArticuloServicio>());

            if (FormularioSeguridad.VerificarAccesoParaAbrirEnPanel(formulario, base._seguridadServicio, base._logger, base._configuracionDTO))
            {
                AbrirFormularioDentroDelPanel(formulario, this.pnlContenedor);
            }
        }

        private void ConsultaFamiliaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var formulario = new _00124_Familia(base._seguridadServicio,
                                                base._configuracionServicio,
                                                base._logger,
                                                Program.Container.GetInstance<IFamiliaServicio>());

            if (FormularioSeguridad.VerificarAccesoParaAbrirEnPanel(formulario, base._seguridadServicio, base._logger, base._configuracionDTO))
            {
                AbrirFormularioDentroDelPanel(formulario, this.pnlContenedor);
            }
        }

        private void NuevaFamiliaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formulario = new _00125_Familia_Abm(base._seguridadServicio,
                                                    base._configuracionServicio,
                                                    Program.Container.GetInstance<IConfiguracionCoreServicio>(),
                                                    base._logger,
                                                    Program.Container.GetInstance<IFamiliaServicio>(),
                                                    TipoOperacion.Nuevo);

            FormularioSeguridad.VerificarAcceso(formulario, _seguridadServicio, _logger, _configuracionDTO);
        }

        private void ConsultaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            var formulario = new _00126_Marca(base._seguridadServicio,
                                               base._configuracionServicio,
                                               base._logger,
                                               Program.Container.GetInstance<IMarcaServicio>());

            if (FormularioSeguridad.VerificarAccesoParaAbrirEnPanel(formulario, base._seguridadServicio, base._logger, base._configuracionDTO))
            {
                AbrirFormularioDentroDelPanel(formulario, this.pnlContenedor);
            }
        }

        private void NuevaMarcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formulario = new _00127_Marca_Abm(base._seguridadServicio,
                                                    base._configuracionServicio,
                                                    base._logger,
                                                    Program.Container.GetInstance<IMarcaServicio>(),
                                                    Program.Container.GetInstance<IConfiguracionCoreServicio>(),
                                                    TipoOperacion.Nuevo);

            FormularioSeguridad.VerificarAcceso(formulario, _seguridadServicio, _logger, _configuracionDTO);
        }

        private void NuevaUnidadDeMedidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formulario = new _00131_UnidadMedida_Abm(base._seguridadServicio,
                                                    base._configuracionServicio,
                                                    base._logger,
                                                    Program.Container.GetInstance<IUnidadMedidaServicio>(),
                                                    TipoOperacion.Nuevo);

            FormularioSeguridad.VerificarAcceso(formulario, _seguridadServicio, _logger, _configuracionDTO);
        }

        private void ConsultaUnidadMedidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formulario = new _00130_UnidadMedida(base._seguridadServicio,
                                               base._configuracionServicio,
                                               base._logger,
                                               Program.Container.GetInstance<IUnidadMedidaServicio>());

            if (FormularioSeguridad.VerificarAccesoParaAbrirEnPanel(formulario, base._seguridadServicio, base._logger, base._configuracionDTO))
            {
                AbrirFormularioDentroDelPanel(formulario, this.pnlContenedor);
            }
        }

        private void NuevaCondicionDeIvaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formulario = new _00129_CondicionIva_Abm(base._seguridadServicio,
                                                    base._configuracionServicio,
                                                    base._logger,
                                                    Program.Container.GetInstance<ICondicionIvaServicio>(),
                                                    TipoOperacion.Nuevo);

            FormularioSeguridad.VerificarAcceso(formulario, _seguridadServicio, _logger, _configuracionDTO);
        }

        private void ConsultaCondicionIvaToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            var formulario = new _00128_CondicionIva(base._seguridadServicio,
                                               base._configuracionServicio,
                                               base._logger,
                                               Program.Container.GetInstance<ICondicionIvaServicio>());

            if (FormularioSeguridad.VerificarAccesoParaAbrirEnPanel(formulario, base._seguridadServicio, base._logger, base._configuracionDTO))
            {
                AbrirFormularioDentroDelPanel(formulario, this.pnlContenedor);
            }
        }

        private void ConsultaProveedorToolStripMenuItem4_Click(object sender, EventArgs e)
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

        private void ConsultaVarianteToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            var formulario = new _00133_Variante(base._seguridadServicio,
                                                  base._configuracionServicio,
                                                  base._logger,
                                                  Program.Container.GetInstance<IVarianteServicio>());

            if (FormularioSeguridad.VerificarAccesoParaAbrirEnPanel(formulario, base._seguridadServicio, base._logger, base._configuracionDTO))
            {
                AbrirFormularioDentroDelPanel(formulario, this.pnlContenedor);
            }
        }

        private void NuevaVarianteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formulario = new _00134_Variante_Abm(base._seguridadServicio,
                                                    base._configuracionServicio,
                                                    base._logger,
                                                    Program.Container.GetInstance<IVarianteServicio>(),
                                                    TipoOperacion.Nuevo);

            FormularioSeguridad.VerificarAcceso(formulario, _seguridadServicio, _logger, _configuracionDTO);
        }

        private void NuevoDepositoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formulario = new _00137_Deposito_Abm(base._seguridadServicio,
                                                    base._configuracionServicio,
                                                    base._logger,
                                                    Program.Container.GetInstance<IDepositoServicio>(),
                                                    TipoOperacion.Nuevo);

            FormularioSeguridad.VerificarAcceso(formulario, _seguridadServicio, _logger, _configuracionDTO);
        }

        private void ConsultaDepositoToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            var formulario = new _00136_Deposito(base._seguridadServicio,
                                                  base._configuracionServicio,
                                                  base._logger,
                                                  Program.Container.GetInstance<IDepositoServicio>());

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

        private void ConsultaListaPrecioToolStripMenuItem7_Click(object sender, EventArgs e)
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
    }
}
