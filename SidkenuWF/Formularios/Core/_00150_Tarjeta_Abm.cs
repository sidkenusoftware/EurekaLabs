using Serilog;
using Sidkenu.AccesoDatos.Constantes;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Base;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.ConfiguracionCore;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.Tarjeta;
using Sidkenu.LogicaNegocio.Servicios.Interface.Core;
using Sidkenu.LogicaNegocio.Servicios.Interface.Seguridad;
using SidkenuWF.Formularios.Base;
using SidkenuWF.Formularios.Base.Constantes;
using SidkenuWF.Helpers;

namespace SidkenuWF.Formularios.Core
{
    public partial class _00150_Tarjeta_Abm : FormularioAbm
    {
        private readonly ITarjetaServicio _tarjetaServicio;
        private readonly IConfiguracionCoreServicio _configuracionCoreServicio;

        private TarjetaDTO _entidad;

        public _00150_Tarjeta_Abm(ISeguridadServicio seguridadServicio,
                                  IConfiguracionServicio configuracionServicio,
                                  IConfiguracionCoreServicio configuracionCoreServicio,
                                  ILogger logger,
                                  ITarjetaServicio tarjetaServicio,
                                  TipoOperacion tipoOperacion,
                                  Guid? entidadId = null)
                                  : base(seguridadServicio, configuracionServicio, logger, tipoOperacion, entidadId)
        {
            InitializeComponent();

            base.TituloFormulario = FormularioConstantes.Titulo;
            base.Titulo = $"Tarjeta / {Enum.GetName(typeof(TipoOperacion), tipoOperacion)}";
            base.Logo = FontAwesome.Sharp.IconChar.CreditCard;

            _tarjetaServicio = tarjetaServicio;
            _configuracionCoreServicio = configuracionCoreServicio;

            AgregarControlesObligatorios(txtCodigo, "Codigo");
            AgregarControlesObligatorios(txtDescripcion, "Tarjeta");

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

            if (entidadId != null && entidadId.Value != Guid.Empty)
            {
                var resultEntidad = _tarjetaServicio.GetById(entidadId.Value);

                if (resultEntidad.State)
                {
                    _entidad = (TarjetaDTO)resultEntidad.Data;

                    txtDescripcion.Text = _entidad.Descripcion;
                    txtCodigo.Text = _entidad.Codigo;
                }
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

                var result = _tarjetaServicio.Add(registro, Properties.Settings.Default.UserLogin);

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

                var result = _tarjetaServicio.Update(registro, Properties.Settings.Default.UserLogin);

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

        private TarjetaPersistenciaDTO AsignarDatos()
        {
            var _entidad = new TarjetaPersistenciaDTO
            {
                Id = EntidadId ?? Guid.Empty,
                Descripcion = txtDescripcion.Text,
                Codigo = txtCodigo.Text,
                EmpresaId = Properties.Settings.Default.EmpresaId,
            };

            this.Entidad = _entidad;

            return _entidad;
        }


        public override void OperacionAdicionalFinalizarInsert()
        {
            txtDescripcion.Focus();
        }
    }
}
