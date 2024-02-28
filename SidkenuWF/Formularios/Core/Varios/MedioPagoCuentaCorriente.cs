using Serilog;
using Sidkenu.AccesoDatos.Constantes.Enum;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.Cliente;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.CuentaCorrienteCliente;
using Sidkenu.LogicaNegocio.Servicios.Interface.Core;
using Sidkenu.LogicaNegocio.Servicios.Interface.Seguridad;
using SidkenuWF.Formularios.Base;
using SidkenuWF.Formularios.Base.Constantes;
using SidkenuWF.Formularios.Core.LookUps;

namespace SidkenuWF.Formularios.Core.Varios
{
    public partial class MedioPagoCuentaCorriente : FormularioComun
    {
        private readonly IClienteServicio _clienteServicio;
        private readonly ICuentaCorrienteClienteServicio _cuentaCorriente;

        public decimal MontoPagar { get; private set; }
        public bool RealizoAlgunaOperacion { get; private set; }
        public ClienteDTO Cliente { get; private set; }

        private bool _clienteEsConsumidorFinal;

        public MedioPagoCuentaCorriente(ISeguridadServicio seguridadServicio,
                                        IConfiguracionServicio configuracionServicio,
                                        ILogger logger,
                                        IClienteServicio clienteServicio,
                                        ICuentaCorrienteClienteServicio cuentaCorriente,
                                        decimal montoPagar)
                                        : base(seguridadServicio, configuracionServicio, logger)
        {
            InitializeComponent();

            base.Titulo = "Cuenta Corriente";
            base.Logo = FontAwesome.Sharp.IconChar.PersonWalkingArrowLoopLeft;
            base.TituloFormulario = FormularioConstantes.Titulo;

            _clienteServicio = clienteServicio;
            _cuentaCorriente = cuentaCorriente;

            MontoPagar = montoPagar;

            _clienteEsConsumidorFinal = true;

            lblClienteMensaje.Text = string.Empty;
        }

        public MedioPagoCuentaCorriente(ISeguridadServicio seguridadServicio,
                                        IConfiguracionServicio configuracionServicio,
                                        ILogger logger,
                                        IClienteServicio clienteServicio,
                                        ICuentaCorrienteClienteServicio cuentaCorriente,
                                        decimal montoPagar,
                                        ClienteDTO cliente)
                                        : base(seguridadServicio, configuracionServicio, logger)
        {
            InitializeComponent();

            base.Titulo = "Cuenta Corriente";
            base.Logo = FontAwesome.Sharp.IconChar.PersonWalkingArrowLoopLeft;
            base.TituloFormulario = FormularioConstantes.Titulo;

            _clienteServicio = clienteServicio;
            _cuentaCorriente = cuentaCorriente;

            Cliente = cliente;

            MontoPagar = montoPagar;

            _clienteEsConsumidorFinal = false;

            lblClienteMensaje.Text = string.Empty;
        }

        private void BtnBuscarCliente_Click(object sender, EventArgs e)
        {
            var formulario = new ClienteLookUp(base._seguridadServicio,
                                               base._configuracionServicio,
                                               base._logger,
                                               Program.Container.GetInstance<IClienteServicio>());

            formulario.ShowDialog();

            if (formulario.SeleccionoEntidad)
            {
                Cliente = (ClienteDTO)formulario.Entidad;

                if (Cliente != null)
                {
                    AsignarDatosCliente();
                }
            }
        }

        private void TxtDocumentoCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDocumentoCliente.Text)
                && (char)Keys.Enter == e.KeyChar)
            {
                var _clienteResult = _clienteServicio.GetByNumeroDocumento(txtDocumentoCliente.Text);

                if (_clienteResult != null && _clienteResult.Data != null)
                {
                    Cliente = (ClienteDTO)_clienteResult.Data;

                    AsignarDatosCliente();
                }
            }
        }

        private void MedioPagoCuentaCorriente_Load(object sender, EventArgs e)
        {
            nudMonto.Value = MontoPagar;

            if (!_clienteEsConsumidorFinal)
            {
                AsignarDatosCliente();
            }
        }

        private void BtnNuevoCliente_Click(object sender, EventArgs e)
        {
            var fNuevoCliente = new _00103_Cliente_Abm(base._seguridadServicio,
                                                       base._configuracionServicio,
                                                       base._logger,
                                                       Program.Container.GetInstance<IClienteServicio>(),
                                                       Program.Container.GetInstance<ITipoResponsabilidadServicio>(),
                                                       Program.Container.GetInstance<ITipoDocumentoServicio>(),
                                                       Program.Container.GetInstance<IListaPrecioServicio>(),
                                                       TipoOperacion.LlamadaExterna);

            FormularioSeguridad.VerificarAcceso(fNuevoCliente, base._seguridadServicio, base._logger, base._configuracionDTO);

            if (fNuevoCliente.RealizoAlgunaOperacion)
            {
                Cliente = (ClienteDTO)fNuevoCliente.Entidad;

                AsignarDatosCliente();
            }
        }

        private void AsignarDatosCliente()
        {
            txtApyNomCliente.Text = Cliente.RazonSocial;
            txtDocumentoCliente.Text = Cliente.Documento;
            txtTelefonoCliente.Text = Cliente.Telefono;
            txtDireccionCliente.Text = Cliente.Direccion;

            VerificarCuentaCorriente();
        }

        private void VerificarCuentaCorriente()
        {
            if (!Cliente.ActivarCuentaCorriente)
            {
                DesactivarCliente();

                lblClienteMensaje.Text = "El Cliente NO tiene ACTIVA la Cuenta Corriente";
            }
            else
            {
                if (Cliente.MontoMaximoCompra.Value != 0)
                {
                    decimal montoPagado = 0m;

                    decimal montoAdeudado = 0m;

                    var resultCtaCte = _cuentaCorriente.GetByCliente(Cliente.Id);

                    if (resultCtaCte != null && resultCtaCte.Data != null)
                    {
                        var cuentas = (List<CtaCteClienteDTO>)resultCtaCte.Data;

                        montoPagado = cuentas
                            .Where(x => x.TipoMovimiento == TipoMovimiento.Ingreso)
                            .Sum(x => x.Monto);

                        montoAdeudado = cuentas
                            .Where(x => x.TipoMovimiento == TipoMovimiento.Egreso)
                            .Sum(x => x.Monto);

                        txtMontoMaximoCompra.Text = Cliente.MontoMaximoCompra.Value.ToString("C2");

                        txtMontoAdeudado.Text = montoAdeudado.ToString("C2");

                        txtMontoAdeudado.ForeColor = montoAdeudado > 0 ? Color.Red : Color.White;

                        if (Cliente.MontoMaximoCompra.Value <= (montoAdeudado + MontoPagar))
                        {
                            DesactivarCliente();

                            lblClienteMensaje.Text = "El Cliente se ha EXCEDIDO del Monto Máximo Permitido";
                        }
                    }
                }
            }
        }

        private void DesactivarCliente()
        {
            txtApyNomCliente.BackColor = Color.Red;
            txtDocumentoCliente.BackColor = Color.Red;
            txtTelefonoCliente.BackColor = Color.Red;
            txtDireccionCliente.BackColor = Color.Red;

            txtApyNomCliente.ForeColor = Color.White;
            txtDocumentoCliente.ForeColor = Color.White;
            txtTelefonoCliente.ForeColor = Color.White;
            txtDireccionCliente.ForeColor = Color.White;

            txtApyNomCliente.ReadOnly = true;
            txtDocumentoCliente.ReadOnly = true;
            txtTelefonoCliente.ReadOnly = true;
            txtDireccionCliente.ReadOnly = true;

            btnEjecutar.Enabled = false;
            btnBuscarCliente.Enabled = false;
            btnNuevoCliente.Enabled = false;

            nudMonto.Enabled = false;
        }

        private void BtnEjecutar_Click(object sender, EventArgs e)
        {
            if (nudMonto.Value <= 0)
            {
                MessageBox.Show("El monto debe ser mayor a Cero", "Atención");
                return;
            }

            if (Cliente == null)
            {
                MessageBox.Show("El Cliente es un dato Obligatorio", "Atención");
                return;
            }

            MontoPagar = nudMonto.Value;
            RealizoAlgunaOperacion = true;
            Close();
        }
    }
}
