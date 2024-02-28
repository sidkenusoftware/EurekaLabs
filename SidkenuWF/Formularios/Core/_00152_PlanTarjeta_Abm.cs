using Serilog;
using Sidkenu.AccesoDatos.Constantes;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Base;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.ConfiguracionCore;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.PlanTarjeta;
using Sidkenu.LogicaNegocio.Servicios.Interface.Core;
using Sidkenu.LogicaNegocio.Servicios.Interface.Seguridad;
using SidkenuWF.Formularios.Base;
using SidkenuWF.Formularios.Base.Constantes;
using SidkenuWF.Helpers;

namespace SidkenuWF.Formularios.Core
{
    public partial class _00152_PlanTarjeta_Abm : FormularioAbm
    {
        private readonly IPlanTarjetaServicio _planTarjetaServicio;
        private readonly ITarjetaServicio _tarjetaServicio;

        private readonly IConfiguracionCoreServicio _configuracionCoreServicio;

        private PlanTarjetaDTO _entidad;

        public _00152_PlanTarjeta_Abm(ISeguridadServicio seguridadServicio,
                                      IConfiguracionServicio configuracionServicio,
                                      IConfiguracionCoreServicio configuracionCoreServicio,
                                      ILogger logger,
                                      ITarjetaServicio tarjetaServicio,
                                      IPlanTarjetaServicio planTarjetaServicio,
                                      TipoOperacion tipoOperacion,
                                      Guid? entidadId = null)
                                      : base(seguridadServicio, configuracionServicio, logger, tipoOperacion, entidadId)
        {
            InitializeComponent();

            base.TituloFormulario = FormularioConstantes.Titulo;
            base.Titulo = $"Plan Tarjeta / {Enum.GetName(typeof(TipoOperacion), tipoOperacion)}";
            base.Logo = FontAwesome.Sharp.IconChar.CreditCard;

            _planTarjetaServicio = planTarjetaServicio;
            _tarjetaServicio = tarjetaServicio;
            _configuracionCoreServicio = configuracionCoreServicio;

            AgregarControlesObligatorios(txtCodigo, "Codigo");
            AgregarControlesObligatorios(txtDescripcion, "Plan Tarjeta");

            txtCodigo.KeyPress += Validacion.NoInyeccion;
            txtDescripcion.KeyPress += Validacion.NoInyeccion;
        }

        public override void EjecutarComandoFormLoad(object sender, EventArgs e)
        {
            CargarDatos(base.TipoOperacion, base.EntidadId, null);
        }

        public override void CargarDatos(TipoOperacion tipoOperacion, Guid? entidadId, Guid? entidadSecundariaId)
        {
            var _configResult = _configuracionCoreServicio
                                .Get(Properties.Settings.Default.EmpresaId);

            var _configCore = (ConfiguracionCoreDTO)_configResult.Data;

            if (_configCore == null)
            {
                MessageBox.Show("Antes de continuar deberá cargar la configuracion del Inventario", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                return;
            }

            // Tarjeta
            var resultTarjeta = _tarjetaServicio.GetAll(Properties.Settings.Default.EmpresaId);

            if (resultTarjeta != null && resultTarjeta.State)
            {
                PoblarComboBox(cmbTarjeta, resultTarjeta.Data, "Descripcion", "Id");
            }

            if (entidadId != null && entidadId.Value != Guid.Empty)
            {
                var resultEntidad = _planTarjetaServicio.GetById(entidadId.Value);

                if (resultEntidad.State)
                {
                    _entidad = (PlanTarjetaDTO)resultEntidad.Data;

                    txtDescripcion.Text = _entidad.Descripcion;
                    txtCodigo.Text = _entidad.Codigo;
                    cmbTarjeta.SelectedValue = _entidad.TarjetaId;
                    nudAlicuota.Value = _entidad.Alicuota;
                }
            }
            else
            {
                nudAlicuota.Value = 0;
            }
        }

        public override ResultDTO EjecutarComandoInsert()
        {
            try
            {
                if (!VerificarDatosObligatorios())
                {
                    return new ResultDTO
                    {
                        State = false,
                        Message = "Por favor ingrese los campos Obligatorios."
                    };
                }

                var registro = AsignarDatos();

                var result = _planTarjetaServicio.Add(registro, Properties.Settings.Default.UserLogin);

                if (result.State)
                {
                    if (base._configuracionDTO != null && base._configuracionDTO != null && base._configuracionDTO.LogInformacion)
                    {
                        _logger.Information($"Se INSERTO Datos: {AsignarDatos().GetPropValue()}. User: {Properties.Settings.Default.PersonaLogin}");
                    }
                }

                return result;
            }
            catch (Exception ex)
            {
                if (base._configuracionDTO != null && base._configuracionDTO != null && base._configuracionDTO.LogError)
                {
                    _logger.Error(ex, $"Error al INSERTAR en {base.Titulo}. User: {Properties.Settings.Default.PersonaLogin}. Datos: {AsignarDatos().GetPropValue()}");
                }

                return new ResultDTO
                {
                    State = false,
                    Message = ex.InnerException == null ? ex.Message : ex.InnerException.Message
                };
            }
        }

        public override ResultDTO EjecutarComandoUpdate()
        {
            try
            {
                var actualizarPrecioPublico = false;
                var actualizarPrecioPublicoImpuesto = false;
                var actualizarPrecio = false;

                if (!VerificarDatosObligatorios())
                {
                    return new ResultDTO
                    {
                        State = false,
                        Message = "Por favor ingrese los campos Obligatorios."
                    };
                }

                var registro = AsignarDatos();

                var result = _planTarjetaServicio.Update(registro, Properties.Settings.Default.UserLogin);

                if (result.State)
                {
                    if (base._configuracionDTO != null && base._configuracionDTO != null && base._configuracionDTO.LogInformacion)
                    {
                        _logger.Information($"Se ACTUALIZO Datos: {AsignarDatos().GetPropValue()}. User: {Properties.Settings.Default.PersonaLogin}");
                    }
                }

                return result;
            }
            catch (Exception ex)
            {
                if (base._configuracionDTO != null && base._configuracionDTO != null && base._configuracionDTO.LogError)
                {
                    _logger.Error(ex, $"Error al ACTUALIZAR en {base.Titulo}. User: {Properties.Settings.Default.PersonaLogin}. Datos: {AsignarDatos().GetPropValue()}");
                }

                return new ResultDTO
                {
                    State = false,
                    Message = ex.InnerException == null ? ex.Message : ex.InnerException.Message
                };
            }
        }

        private PlanTarjetaPersistenciaDTO AsignarDatos()
        {
            var _entidad = new PlanTarjetaPersistenciaDTO
            {
                Id = EntidadId ?? Guid.Empty,
                Descripcion = txtDescripcion.Text,
                Codigo = txtCodigo.Text,
                Alicuota = nudAlicuota.Value,
                TarjetaId = (Guid)cmbTarjeta.SelectedValue,
            };

            this.Entidad = _entidad;

            return _entidad;
        }


        public override void OperacionAdicionalFinalizarInsert()
        {
            txtDescripcion.Focus();
        }

        private void BtnNuevaTarjeta_Click(object sender, EventArgs e)
        {
            var formulario = new _00150_Tarjeta_Abm(base._seguridadServicio,
                                                    base._configuracionServicio,
                                                    Program.Container.GetInstance<IConfiguracionCoreServicio>(),
                                                    base._logger,
                                                    Program.Container.GetInstance<ITarjetaServicio>(),
                                                    TipoOperacion.Nuevo);

            FormularioSeguridad.VerificarAcceso(formulario, _seguridadServicio, _logger, _configuracionDTO);

            if (formulario.RealizoAlgunaOperacion)
            {
                var resultTarjeta = _tarjetaServicio.GetAll(Properties.Settings.Default.EmpresaId);

                if (resultTarjeta != null && resultTarjeta.State)
                {
                    PoblarComboBox(cmbTarjeta, resultTarjeta.Data, "Descripcion", "Id");
                }
            }
        }
    }
}
