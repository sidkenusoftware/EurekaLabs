using FontAwesome.Sharp;
using Serilog;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.ConfiguracionCore;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.Deposito;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.ListaPrecio;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Seguridad.Persona;
using Sidkenu.LogicaNegocio.Servicios.Interface.Core;
using Sidkenu.LogicaNegocio.Servicios.Interface.Seguridad;
using SidkenuWF.Formularios.Base;
using SidkenuWF.Formularios.Base.Constantes;
using SidkenuWF.Formularios.Core.LookUps;

namespace SidkenuWF.Formularios.Core
{
    public partial class _00119_ConfiguracionCore : FormularioConfiguracion
    {
        private readonly IDepositoServicio _depositoServicio;
        private readonly IListaPrecioServicio _listaPrecioServicio;
        private readonly IConfiguracionCoreServicio _configuracionCoreServicio;
        private readonly IPersonaServicio _personaServicio;

        private Guid entidadId;

        private Guid empleadoAutorizadId;

        private PersonaDTO _vendedor;

        public _00119_ConfiguracionCore(IConfiguracionCoreServicio configuracionCoreServicio,
            IDepositoServicio depositoServicio,
            IListaPrecioServicio listaPrecioServicio,
            IPersonaServicio personaServicio,
            ISeguridadServicio seguridadServicio,
            IConfiguracionServicio configuracionServicio,
            ILogger logger)
            : base(seguridadServicio, configuracionServicio, logger)
        {
            InitializeComponent();

            base.TituloFormulario = FormularioConstantes.Titulo;
            base.Titulo = "Configuración";
            base.Logo = IconChar.UserGroup;
            _depositoServicio = depositoServicio;
            _listaPrecioServicio = listaPrecioServicio;
            _personaServicio = personaServicio;
            _configuracionCoreServicio = configuracionCoreServicio;
        }

        private void BtnListaPrecioPorDefectoParaVenta_Click(object sender, EventArgs e)
        {
            var formulario = new _00139_ListaPrecio_Abm(base._seguridadServicio,
                                                        base._configuracionServicio,
                                                        base._logger,
                                                        Program.Container.GetInstance<IListaPrecioServicio>(),
                                                        TipoOperacion.Nuevo);

            FormularioSeguridad.VerificarAcceso(formulario, _seguridadServicio, _logger, _configuracionDTO);

            if (formulario.RealizoAlgunaOperacion)
            {
                var resultListaPrecio = _listaPrecioServicio.GetAll(Properties.Settings.Default.EmpresaId);

                if (resultListaPrecio != null && resultListaPrecio.State)
                {
                    PoblarComboBox(cmbListaPrecioPorDefectoParaVenta, resultListaPrecio.Data, "Descripcion", "Id");
                }
            }
        }

        private void BtnDepositoPorDefectoParaCompra_Click(object sender, EventArgs e)
        {
            var formulario = new _00137_Deposito_Abm(base._seguridadServicio,
                                                     base._configuracionServicio,
                                                     base._logger,
                                                     Program.Container.GetInstance<IDepositoServicio>(),
            TipoOperacion.Nuevo);

            FormularioSeguridad.VerificarAcceso(formulario, _seguridadServicio, _logger, _configuracionDTO);

            if (formulario.RealizoAlgunaOperacion)
            {
                var resultDeposito = _depositoServicio.GetAll(Properties.Settings.Default.EmpresaId);

                if (resultDeposito != null && resultDeposito.State)
                {
                    PoblarComboBox(cmbDepositoPorDefectoParaVenta, resultDeposito.Data, "Descripcion", "Id");
                    PoblarComboBox(cmbDepositoPorDefectoParaCompra, resultDeposito.Data, "Descripcion", "Id");
                }
            }
        }

        public override void CargarDatos(Guid? empresaId = null)
        {
            var _listaResult = _listaPrecioServicio
                .GetByFilter(new ListaPrecioFilterDTO
                {
                    EmpresaId = empresaId.Value,
                });

            PoblarComboBox(cmbListaPrecioPorDefectoParaVenta, _listaResult.Data, "Descripcion", "Id");

            var _depositoResult = _depositoServicio
                .GetByFilter(new DepositoFilterDTO
                {
                    EmpresaId = empresaId.Value,
                });

            PoblarComboBox(cmbDepositoPorDefectoParaVenta, _depositoResult.Data, "Descripcion", "Id");
            PoblarComboBox(cmbDepositoPorDefectoParaCompra, _depositoResult.Data, "Descripcion", "Id");

            var resultConfig = _configuracionCoreServicio
                .Get(empresaId.Value);

            if (resultConfig != null && resultConfig.State)
            {
                var _entidad = (ConfiguracionCoreDTO)resultConfig.Data;

                if (_entidad != null)
                {
                    entidadId = _entidad.Id;

                    chkActivarAumentoPrecioPorFamilia.Checked = _entidad.ActivarAumentoPrecioPorFamilia;
                    chkActivarAumentoPrecioPorFamiliaListaPrecio.Checked = _entidad.ActivarAumentoPrecioPorFamiliaListaPrecio;

                    chkActivarAumentoPrecioPorMarca.Checked = _entidad.ActivarAumentoPrecioPorMarca;
                    chkActivarAumentoPrecioPorMarcaListaPrecio.Checked = _entidad.ActivarAumentoPrecioPorMarcaListaPrecio;

                    chkActivarLoteConVencimiento.Checked = _entidad.ActivarStockPorVencimientoLote;

                    cmbDepositoPorDefectoParaCompra.SelectedValue = _entidad.DepositoPorDefectoParaCompraId;
                    cmbDepositoPorDefectoParaVenta.SelectedValue = _entidad.DepositoPorDefectoParaVentaId;

                    cmbListaPrecioPorDefectoParaVenta.SelectedValue = _entidad.ListaPrecioPorDefectoParaVentaId;

                    chkActualizarPrecioFinalizarFabricacion.Checked = _entidad.ActualizarPrecioFinalizarLaFabricacion;

                    chkActivarCostoFabricacion.Checked = _entidad.IncorporarCostoFabricacion;

                    nudCantidadArticulosProducidos.Value = _entidad.CantidadAproximadaFabricacionArticulos.HasValue
                        ? _entidad.CantidadAproximadaFabricacionArticulos.Value
                        : 0;

                    nudCantidadArticulosProducidos.Enabled = _entidad.IncorporarCostoFabricacion;

                    chkPedirAutorizacion.Enabled = _entidad.PedirAutorizacion;


                    chkPedirAutorizacionPorDescuento.Enabled = _entidad.PedirAutorizacionDescuento;

                    nudDescuento.Value = _entidad.DescuentoAutorizacion;

                    empleadoAutorizadId = _entidad.EmpleadoAutorizaId.HasValue ? _entidad.EmpleadoAutorizaId.Value : Guid.Empty;

                    if (_entidad.EmpleadoAutorizaId.HasValue && _entidad.EmpleadoAutorizaId != Guid.Empty)
                    {
                        var personaResult = _personaServicio.GetById(_entidad.EmpleadoAutorizaId.Value);

                        if (personaResult != null && personaResult.State)
                        {
                            _vendedor = (PersonaDTO)personaResult.Data;

                            txtEmpleadoQueAutoriza.Text = _vendedor.NombreCompleto;
                        }
                    }

                    chkUnificarRenglonesIngresarMismoArticulo.Checked = _entidad.UnificarRenglonesIngresarMismoArticulo;

                    chkSepararPuntoVentaDeCaja.Checked = _entidad.SepararPuntoVentaCaja;
                    chkCobroConTicketCaja.Checked = _entidad.ActivarCobroConTicketCaja;

                    chkActivarInteresPorTransferencia.Checked = _entidad.ActivarInteresPorTransferencia;
                    nudActivarInteresPorTransferencia.Enabled = _entidad.ActivarInteresPorTransferencia;

                    nudActivarInteresPorTransferencia.Value = _entidad.InteresPorTransferencia.HasValue ?
                        _entidad.InteresPorTransferencia.Value : 0;

                    chkActivarInteresPorCheque.Checked = _entidad.ActivarInteresPorCheque;
                    nudActivarInteresPorCheque.Enabled = _entidad.ActivarInteresPorCheque;

                    nudActivarInteresPorCheque.Value = _entidad.InteresPorCheque.HasValue ?
                        _entidad.InteresPorCheque.Value : 0;
                }
            }
            else
            {
                entidadId = Guid.Empty;
            }
        }

        private void _00119_ConfiguracionCore_Load(object sender, EventArgs e)
        {
            CargarDatos(Properties.Settings.Default.EmpresaId);
        }

        public override void EjecutarComandoGuardar()
        {
            try
            {
                if (cmbDepositoPorDefectoParaVenta.Items.Count <= 0
                || cmbDepositoPorDefectoParaCompra.Items.Count <= 0)
                {
                    MessageBox.Show("No hay un deposito seleccionado.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }

                if (cmbListaPrecioPorDefectoParaVenta.Items.Count <= 0)
                {
                    MessageBox.Show("No hay una Lista de Precio seleccionada", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }

                var entidad = new ConfiguracionCorePersistenciaDTO
                {
                    EmpresaId = Properties.Settings.Default.EmpresaId,
                    ActivarAumentoPrecioPorFamilia = chkActivarAumentoPrecioPorFamilia.Checked,
                    ActivarAumentoPrecioPorFamiliaListaPrecio = chkActivarAumentoPrecioPorFamiliaListaPrecio.Checked,
                    ActivarAumentoPrecioPorMarca = chkActivarAumentoPrecioPorMarca.Checked,
                    ActivarAumentoPrecioPorMarcaListaPrecio = chkActivarAumentoPrecioPorMarcaListaPrecio.Checked,
                    ActivarStockPorVencimientoLote = chkActivarLoteConVencimiento.Checked,
                    DepositoPorDefectoParaCompraId = (Guid)cmbDepositoPorDefectoParaCompra.SelectedValue,
                    DepositoPorDefectoParaVentaId = (Guid)cmbDepositoPorDefectoParaVenta.SelectedValue,
                    ListaPrecioPorDefectoParaVentaId = (Guid)cmbListaPrecioPorDefectoParaVenta.SelectedValue,
                    ActualizarPrecioFinalizarLaFabricacion = chkActualizarPrecioFinalizarFabricacion.Checked,
                    Id = entidadId,
                    CantidadAproximadaFabricacionArticulos = nudCantidadArticulosProducidos.Value,
                    IncorporarCostoFabricacion = chkActivarCostoFabricacion.Checked,
                    ActivarCobroConTicketCaja = chkCobroConTicketCaja.Checked,
                    PedirAutorizacionParaArticulos = chkPedirAutorizacion.Checked,
                    PersonaQueAutorizaId = chkPedirAutorizacion.Checked ? _vendedor.Id : null,
                    PedirAutorizacionParaDescuentos = chkPedirAutorizacionPorDescuento.Checked,
                    DescuentoMaximo = nudDescuento.Value,
                    UnificarRenglonesIngresarMismoArticulo = chkUnificarRenglonesIngresarMismoArticulo.Checked,
                    SepararPuntoVentaCaja = chkSepararPuntoVentaDeCaja.Checked,

                    ActivarInteresPorTransferencia = chkActivarInteresPorTransferencia.Checked,
                    InteresPorTransferencia = nudActivarInteresPorTransferencia.Value,
                    ActivarInteresPorCheque = chkActivarInteresPorCheque.Checked,
                    InteresPorCheque = nudActivarInteresPorCheque.Value
                };

                var result = _configuracionCoreServicio.AddOrUpdate(entidad, Properties.Settings.Default.UserLogin);

                if (result.State)
                {
                    MessageBox.Show(result.Message, "Atencion", MessageBoxButtons.OK);
                    Close();
                }
                else
                {
                    MessageBox.Show(result.Message, "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void ChkActivarCostoFabricacion_CheckedChanged(object sender, EventArgs e)
        {
            nudCantidadArticulosProducidos.Enabled = chkActivarCostoFabricacion.Checked;
        }

        private void BtnBuscarEmpleado_Click(object sender, EventArgs e)
        {
            var formulario = new EmpleadoLookUp(base._seguridadServicio,
                                               base._configuracionServicio,
                                               base._logger,
                                               Program.Container.GetInstance<IPersonaServicio>());

            formulario.ShowDialog();

            if (formulario.SeleccionoEntidad)
            {
                _vendedor = (PersonaDTO)formulario.Entidad;

                if (_vendedor != null)
                {
                    txtEmpleadoQueAutoriza.Text = _vendedor.NombreCompleto;
                }
            }
        }

        private void ChkActivarInteresPorTransferencia_CheckedChanged(object sender, EventArgs e)
        {
            nudActivarInteresPorTransferencia.Enabled = chkActivarInteresPorTransferencia.Checked;
            nudActivarInteresPorTransferencia.Focus();
        }

        private void ChkActivarInteresPorCheque_CheckedChanged(object sender, EventArgs e)
        {
            nudActivarInteresPorCheque.Enabled = chkActivarInteresPorCheque.Checked;
            nudActivarInteresPorCheque.Focus();
        }

        private void ChkSepararPuntoVentaDeCaja_CheckedChanged(object sender, EventArgs e)
        {
            chkCobroConTicketCaja.Enabled = chkSepararPuntoVentaDeCaja.Checked;

            chkCobroConTicketCaja.Checked = false;
        }
    }
}


