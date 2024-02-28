using SidkenuWF.Formularios.Base.Constantes;
using SidkenuWF.Formularios.Base;
using SidkenuWF.Helpers;
using Serilog;
using Sidkenu.LogicaNegocio.Servicios.Interface.Seguridad;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Seguridad.PuestoTrabajo;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Base;
using Sidkenu.AccesoDatos.Constantes;

namespace SidkenuWF.Formularios.Seguridad
{
    public partial class _00025_PuestoTrabajo_Abm : FormularioAbm
    {
        private readonly IPuestoTrabajoServicio _puestoTrabajoServicio;
        public _00025_PuestoTrabajo_Abm(ISeguridadServicio seguridadServicio,
                                        IConfiguracionServicio configuracionServicio,
                                        ILogger logger,
                                        IPuestoTrabajoServicio puestoTrabajoServicio,
                                        TipoOperacion tipoOperacion,
                                        Guid? entidadId = null)
                                        : base(seguridadServicio, configuracionServicio, logger, tipoOperacion, entidadId)
        {
            InitializeComponent();

            base.TituloFormulario = Base.Constantes.FormularioConstantes.Titulo;
            base.Titulo = $"Puesto de Trabajo / {Enum.GetName(typeof(TipoOperacion), tipoOperacion)}";
            base.Logo = FontAwesome.Sharp.IconChar.Computer;

            _puestoTrabajoServicio = puestoTrabajoServicio;

            AgregarControlesObligatorios(txtDescripcion, "Puesto de Trabajo");
            AgregarControlesObligatorios(txtNumeroSerie, "Numero de Serie");

            txtDescripcion.KeyPress += Validacion.NoInyeccion;
        }

        public override void EjecutarComandoFormLoad(object sender, EventArgs e)
        {
            base.CargarDatos(base.TipoOperacion, base.EntidadId, null);
        }

        public override void CargarDatos(TipoOperacion tipoOperacion, Guid? entidadId, Guid? entidadSecundariaId)
        {
            if (entidadId != null && entidadId.Value != Guid.Empty)
            {
                var resultEntidad = _puestoTrabajoServicio.GetById(entidadId.Value);

                if (resultEntidad.State)
                {
                    var _entidad = (PuestoTrabajoDTO)resultEntidad.Data;

                    txtDescripcion.Text = _entidad.Descripcion;
                    txtNumeroSerie.Text = _entidad.SerialNumber;
                    btnNumeroSerie.Enabled = false;
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

                var result = _puestoTrabajoServicio.Add(registro, Properties.Settings.Default.UserLogin);

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
                if (!VerificarDatosObligatorios())
                {
                    return new ResultDTO
                    {
                        State = false,
                        Message = "Por favor ingrese los campos Obligatorios."
                    };
                }

                var registro = AsignarDatos();

                var result = _puestoTrabajoServicio.Update(registro, Properties.Settings.Default.UserLogin);

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

        private PuestoTrabajoPersistenciaDTO AsignarDatos()
        {
            var _entidad = new PuestoTrabajoPersistenciaDTO
            {
                Id = EntidadId ?? Guid.Empty,
                Descripcion = txtDescripcion.Text,
                EmpresaId = Properties.Settings.Default.EmpresaId,
                SerialNumber = txtNumeroSerie.Text,
            };

            this.Entidad = _entidad;

            return _entidad;
        }

        public override void OperacionAdicionalFinalizarInsert()
        {
            txtDescripcion.Focus();
        }

        private void BtnBorrarCliente_Click(object sender, EventArgs e)
        {
            txtNumeroSerie.Text = Serial.Obtener();
        }
    }
}
