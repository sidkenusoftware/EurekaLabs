using Serilog;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.Caja;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.ConfiguracionCore;
using Sidkenu.LogicaNegocio.Servicios.Interface.Core;
using Sidkenu.LogicaNegocio.Servicios.Interface.Seguridad;
using SidkenuWF.Formularios.Base;
using SidkenuWF.Formularios.Base.Constantes;
using SidkenuWF.Formularios.Core.Varios;

namespace SidkenuWF.Formularios.Core
{
    public partial class _00112_ModuloPuntoVenta : FormularioMenuLateral
    {
        private readonly IConfiguracionCoreServicio _configuracionCoreServicio;
        private readonly ICajaServicio _cajaServicio;
        private readonly ICajaPuestoTrabajoServicio _cajaPuestoTrabajoServicio;

        public _00112_ModuloPuntoVenta(ISeguridadServicio seguridadServicio,
                                       IConfiguracionServicio configuracionServicio,
                                       ILogger logger,
                                       IConfiguracionCoreServicio configuracionCoreServicio,
                                       ICajaServicio cajaServicio,
                                       ICajaPuestoTrabajoServicio cajaPuestoTrabajoServicio)
                                       : base(seguridadServicio, configuracionServicio, logger)
        {
            InitializeComponent();

            _configuracionCoreServicio = configuracionCoreServicio;
            _cajaServicio = cajaServicio;
            _cajaPuestoTrabajoServicio = cajaPuestoTrabajoServicio;
        }

        private void BtnPuntoDeVenta_Click(object sender, EventArgs e)
        {
            //var configCoreResult = _configuracionCoreServicio.Get(Properties.Settings.Default.EmpresaId);

            //if (configCoreResult == null || !configCoreResult.State)
            //{
            //    MessageBox.Show("Por favor antes de continuar deberá cargar la configuracion del Sistema", "Atención", MessageBoxButtons.OK);
            //    return;
            //}

            //var _configCore = (ConfiguracionCoreDTO)configCoreResult.Data;

            //if (_configCore.SepararPuntoVentaCaja)
            //{
            //    // La caja esta separada del punto de venta

            //    var formulario = new _00147_PuntoVentaMostrador(base._seguridadServicio,
            //                                                    base._configuracionServicio,
            //                                                    base._logger,
            //                                                    Program.Container.GetInstance<IArticuloServicio>(),
            //                                                    Program.Container.GetInstance<IListaPrecioServicio>(),
            //                                                    Program.Container.GetInstance<IClienteServicio>(),
            //                                                    Program.Container.GetInstance<IPersonaServicio>(),
            //                                                    Program.Container.GetInstance<IConfiguracionCoreServicio>(),
            //                                                    Program.Container.GetInstance<IConfiguracionBalanzaServicio>(),
            //                                                    Program.Container.GetInstance<IComprobanteServicio>());

            //    FormularioSeguridad.VerificarAccesoSolorShow(formulario, base._seguridadServicio);
            //}
            //else
            //{
                // La caja esta junto al punto de venta

                var cajaResult = _cajaPuestoTrabajoServicio.GetByCajasAsignadas(Properties.Settings.Default.PuestoTrabajoId);

                if (cajaResult == null || !cajaResult.State)
                {
                    MessageBox.Show("Ocurrió un error al Obtener los Puestos de Caja Abiertos", "Atencion");
                    return;
                }

                var _cajas = (List<CajaDTO>) cajaResult.Data;

                if (_cajas.Count(x => x.EstaAbierta) == 0)
                {
                    MessageBox.Show("No hay puestos de caja Abiertos", "Atención");
                    return;
                }
                else if (_cajas.Count(x => x.EstaAbierta) == 1)
                {
                    Properties.Settings.Default.CajaId = _cajas.First().Id;
                    Properties.Settings.Default.CajaDetalleId = _cajas.First().CajaDetalleId.Value;
                    Properties.Settings.Default.CajaDetalleId = _cajas.First().CajaDetalleId.HasValue ? _cajas.First().CajaDetalleId.Value : Guid.Empty;
                    Properties.Settings.Default.Save();

                    var formulario = new _00147_PuntoVentaMostrador(base._seguridadServicio,
                                                                base._configuracionServicio,
                                                                base._logger,
                                                                Program.Container.GetInstance<IArticuloServicio>(),
                                                                Program.Container.GetInstance<IListaPrecioServicio>(),
                                                                Program.Container.GetInstance<IClienteServicio>(),
                                                                Program.Container.GetInstance<IPersonaServicio>(),
                                                                Program.Container.GetInstance<IConfiguracionCoreServicio>(),
                                                                Program.Container.GetInstance<IConfiguracionBalanzaServicio>(),
                                                                Program.Container.GetInstance<IComprobanteServicio>());

                    FormularioSeguridad.VerificarAccesoSolorShow(formulario, base._seguridadServicio);
                }
                else if(_cajas.Count(x=>x.EstaAbierta) > 0)
                {
                    var fCajasAbiertas = new CajasAbiertas(_cajas);

                    fCajasAbiertas.ShowDialog();

                    if (fCajasAbiertas.RealizoAlgunaOperacion)
                    {
                        var formulario = new _00147_PuntoVentaMostrador(base._seguridadServicio,
                                                                base._configuracionServicio,
                                                                base._logger,
                                                                Program.Container.GetInstance<IArticuloServicio>(),
                                                                Program.Container.GetInstance<IListaPrecioServicio>(),
                                                                Program.Container.GetInstance<IClienteServicio>(),
                                                                Program.Container.GetInstance<IPersonaServicio>(),
                                                                Program.Container.GetInstance<IConfiguracionCoreServicio>(),
                                                                Program.Container.GetInstance<IConfiguracionBalanzaServicio>(),
                                                                Program.Container.GetInstance<IComprobanteServicio>());

                        FormularioSeguridad.VerificarAccesoSolorShow(formulario, base._seguridadServicio);
                    }

                    return;
                }
            //}
        }

        private void BtnClientes_Click(object sender, EventArgs e)
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

        private void SalirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void NuevaTarjeta_Click(object sender, EventArgs e)
        {
            var formulario = new _00150_Tarjeta_Abm(base._seguridadServicio,
                                                    base._configuracionServicio,
                                                    Program.Container.GetInstance<IConfiguracionCoreServicio>(),
                                                    base._logger,
                                                    Program.Container.GetInstance<ITarjetaServicio>(),
                                                    TipoOperacion.Nuevo);

            FormularioSeguridad.VerificarAcceso(formulario, _seguridadServicio, _logger, _configuracionDTO);
        }

        private void ConsultaTarjeta_Click(object sender, EventArgs e)
        {
            var formulario = new _00149_Tarjeta(base._seguridadServicio,
                                                base._configuracionServicio,
                                                base._logger,
                                                Program.Container.GetInstance<ITarjetaServicio>());

            if (FormularioSeguridad.VerificarAccesoParaAbrirEnPanel(formulario, base._seguridadServicio, base._logger, base._configuracionDTO))
            {
                AbrirFormularioDentroDelPanel(formulario, this.pnlContenedor);
            }
        }

        private void NuevoPlanDeTarjeta_Click(object sender, EventArgs e)
        {
            var formulario = new _00152_PlanTarjeta_Abm(base._seguridadServicio,
                                                        base._configuracionServicio,
                                                        Program.Container.GetInstance<IConfiguracionCoreServicio>(),
                                                        base._logger,
                                                        Program.Container.GetInstance<ITarjetaServicio>(),
                                                        Program.Container.GetInstance<IPlanTarjetaServicio>(),
                                                        TipoOperacion.Nuevo);

            FormularioSeguridad.VerificarAcceso(formulario, _seguridadServicio, _logger, _configuracionDTO);
        }

        private void ConsultaPlanTarjeta_Click(object sender, EventArgs e)
        {
            var formulario = new _00151_PlanTarjeta(base._seguridadServicio,
                                                    base._configuracionServicio,
                                                    base._logger,
                                                    Program.Container.GetInstance<IPlanTarjetaServicio>());

            if (FormularioSeguridad.VerificarAccesoParaAbrirEnPanel(formulario, base._seguridadServicio, base._logger, base._configuracionDTO))
            {
                AbrirFormularioDentroDelPanel(formulario, this.pnlContenedor);
            }
        }

        private void NuevoBanco_Click(object sender, EventArgs e)
        {
            var formulario = new _00154_Banco_Abm(base._seguridadServicio,
                                                  base._configuracionServicio,
                                                  Program.Container.GetInstance<IConfiguracionCoreServicio>(),
                                                  base._logger,
                                                  Program.Container.GetInstance<IBancoServicio>(),
                                                  TipoOperacion.Nuevo);

            FormularioSeguridad.VerificarAcceso(formulario, _seguridadServicio, _logger, _configuracionDTO);
        }

        private void ConsultaBanco_Click(object sender, EventArgs e)
        {
            var formulario = new _00153_Banco(base._seguridadServicio,
                                              base._configuracionServicio,
                                              base._logger,
                                              Program.Container.GetInstance<IBancoServicio>());

            if (FormularioSeguridad.VerificarAccesoParaAbrirEnPanel(formulario, base._seguridadServicio, base._logger, base._configuracionDTO))
            {
                AbrirFormularioDentroDelPanel(formulario, this.pnlContenedor);
            }
        }
    }
}
