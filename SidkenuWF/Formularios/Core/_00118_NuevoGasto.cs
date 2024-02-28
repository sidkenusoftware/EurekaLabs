using Serilog;
using Sidkenu.AccesoDatos.Constantes.Enum;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.Caja;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.Cliente;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.Gasto;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.Movimiento;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.TipoGasto;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Seguridad.Persona;
using Sidkenu.LogicaNegocio.Servicios.Interface.Core;
using Sidkenu.LogicaNegocio.Servicios.Interface.Seguridad;
using SidkenuWF.Formularios.Base;
using SidkenuWF.Formularios.Base.Constantes;
using SidkenuWF.Helpers;

namespace SidkenuWF.Formularios.Core
{
    public partial class _00118_NuevoGasto : FormularioComun
    {
        private readonly IGastosServicio _gastoServicio;
        private readonly ITipoGastoServicio _tipoGastoServicio;
        private readonly IClienteServicio _clienteServicio;
        private readonly IPersonaServicio _personaServicio;
        private readonly IMovimientoCajaServicio _movimientoCajaServicio;

        private ClienteDTO _cliente;
        private PersonaDTO _empleado;
        private CajaDTO _cajaDto;

        public bool RealizoAlgunaOperacion { get; private set; }

        public _00118_NuevoGasto(ISeguridadServicio seguridadServicio,
                                 IConfiguracionServicio configuracionServicio,
                                 ILogger logger,
                                 IGastosServicio gastoServicio,
                                 ITipoGastoServicio tipoGastoServicio,
                                 IClienteServicio clienteServicio,
                                 IPersonaServicio personaServicio,
                                 IMovimientoCajaServicio movimientoCajaServicio,
                                 CajaDTO cajaDTO)
                                 : base(seguridadServicio, configuracionServicio, logger)
        {
            InitializeComponent();

            base.TituloFormulario = FormularioConstantes.Titulo;
            base.Titulo = $"Nuevo Gasto";

            _gastoServicio = gastoServicio;
            _tipoGastoServicio = tipoGastoServicio;

            _clienteServicio = clienteServicio;
            _personaServicio = personaServicio;
            _movimientoCajaServicio = movimientoCajaServicio;

            _cajaDto = cajaDTO;

            this.lblCajaSeleccionada.Text = $"Caja Seleccionada => {_cajaDto.Descripcion}";

            txtDescripcion.KeyPress += Validacion.NoInyeccion;
        }

        public void EjecutarComandoFormLoad(object sender, EventArgs e)
        {
            CargarDatos();
        }

        public void CargarDatos()
        {
            CargarComboBoxTipoGastos();

            dtpFecha.Value = DateTime.Now;

            nudMonto.Value = 0;
            nudMonto.Minimum = 0;

            txtDescripcion.Clear();

            cmbTipoGasto.Focus();
        }

        private void CargarComboBoxTipoGastos()
        {
            var resultTipoGastos = _tipoGastoServicio.GetByFilter(new TipoGastoFilterDTO
            {
                VerEliminados = false,
                CadenaBuscar = string.Empty
            });

            if (resultTipoGastos != null && resultTipoGastos.State)
            {
                cmbTipoGasto.DataSource = resultTipoGastos.Data;
                cmbTipoGasto.DisplayMember = "Descripcion";
                cmbTipoGasto.ValueMember = "Id";
            }
        }

        private GastosPersistenciaDTO AsignarDatos()
        {
            var _entidad = new GastosPersistenciaDTO
            {
                CajaDetalleId = _cajaDto.CajaDetalleId.Value,
                CajaId = _cajaDto.Id,
                EstaEliminado = false,
                Fecha = dtpFecha.Value,
                TipoGastoId = (Guid)cmbTipoGasto.SelectedValue,
                EmpresaId = Properties.Settings.Default.EmpresaId,                
                Descripcion = txtDescripcion.Text,
                Monto = nudMonto.Value,
                PersonaId = Properties.Settings.Default.PersonaLoginId
            };

            return _entidad;
        }

        private void BtnEjecutar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!((List<TipoGastoDTO>)cmbTipoGasto.DataSource).Any())
                {
                    MessageBox.Show("Por favor seleccione un Tipo de Gasto");
                    return;
                }

                if (string.IsNullOrEmpty(txtDescripcion.Text))
                {
                    MessageBox.Show("La descripcion es un dato Obligatorio", "Atencion");
                    return;
                }

                if (nudMonto.Value <= 0)
                {
                    MessageBox.Show("El monto debe ser mayor a 0 (cero)", "Atención");
                    return;
                }

                if (!VerificarSiTieneSuficienteDinero(_cajaDto, nudMonto.Value))
                {
                    MessageBox.Show($"El gasto que desea hacer supera el monto disponible en la caja seleccionada: {_cajaDto.Descripcion.ToUpper()}.", "Atención");
                    return;
                }

                var registro = AsignarDatos();

                var result = _gastoServicio.Add(registro, Properties.Settings.Default.UserLogin);

                if (result.State)
                {
                    MessageBox.Show(result.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RealizoAlgunaOperacion = true;
                    Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.InnerException == null ? ex.Message : ex.InnerException.Message);
            }
        }

        private bool VerificarSiTieneSuficienteDinero(CajaDTO cajaDto, decimal montoGasto)
        {
            var _tieneDineroSuficiente = true;

            var movimientoResult = _movimientoCajaServicio.ObtenerMovimientos(cajaDto.CajaDetalleId, cajaDto.FechaApertura.Value, DateTime.Now);

            if (movimientoResult != null && movimientoResult.State)
            {
                var _movimientos = (List<MovimientoCajaDTO>)movimientoResult.Data;

                var totalEnCajaDisponible = cajaDto.MontoApertura.HasValue ? cajaDto.MontoApertura.Value : 0;

                var totalEnMovimientos = _movimientos.Where(x => x.TipoOperacion == TipoOperacionMovimiento.Efectivo
                                                                 || x.TipoOperacion == TipoOperacionMovimiento.Gastos
                                                                 || x.TipoOperacion == TipoOperacionMovimiento.TransferenciaCaja)
                                                                     .Sum(x => (x.Capital * (int)x.TipoMovimiento));

                totalEnCajaDisponible = totalEnCajaDisponible + totalEnMovimientos;

                return totalEnCajaDisponible >= montoGasto;
            }
            else
            {
                return false;
            }

            return _tieneDineroSuficiente;
        }

        private void BtnNuevoTipoGasto_Click(object sender, EventArgs e)
        {
            var formularioAbm = new _00107_TipoGasto_Abm(base._seguridadServicio,
                                                         base._configuracionServicio,
                                                         base._logger,
                                                         Program.Container.GetInstance<ITipoGastoServicio>(),
                                                         TipoOperacion.Nuevo);

            FormularioSeguridad.VerificarAcceso(formularioAbm, base._seguridadServicio, base._logger, base._configuracionDTO);

            if (formularioAbm.RealizoAlgunaOperacion)
            {
                CargarComboBoxTipoGastos();
            }
        }
    }
}
