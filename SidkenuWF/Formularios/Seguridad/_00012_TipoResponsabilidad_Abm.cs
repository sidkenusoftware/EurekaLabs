using Serilog;
using Sidkenu.AccesoDatos.Constantes;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Base;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Seguridad.TipoResponsabilidad;
using Sidkenu.LogicaNegocio.Servicios.Interface.Seguridad;
using SidkenuWF.Formularios.Base;
using SidkenuWF.Formularios.Base.Constantes;
using SidkenuWF.Helpers;

namespace SidkenuWF.Formularios.Seguridad
{
    public partial class _00012_TipoResponsabilidad_Abm : FormularioAbm
    {
        private readonly ITipoResponsabilidadServicio _condicionIvaServicio;

        public _00012_TipoResponsabilidad_Abm(ISeguridadServicio seguridadServicio,
                                              IConfiguracionServicio configuracionServicio,
                                              ILogger logger,
                                              ITipoResponsabilidadServicio condicionIvaServicio,
                                              TipoOperacion tipoOperacion,
                                              Guid? entidadId = null)
                                              : base(seguridadServicio, configuracionServicio, logger, tipoOperacion, entidadId)
        {
            InitializeComponent();

            base.TituloFormulario = Base.Constantes.FormularioConstantes.Titulo;
            base.Titulo = $"Tipo Responsabilidad / {Enum.GetName(typeof(TipoOperacion), tipoOperacion)}";

            _condicionIvaServicio = condicionIvaServicio;

            AgregarControlesObligatorios(txtDescripcion, "Tipo Responsabilidad");
            AgregarControlesObligatorios(txtCodigo, "Codigo");

            txtDescripcion.KeyPress += Validacion.NoInyeccion;

            txtCodigo.KeyPress += Validacion.NoInyeccion;
            txtCodigo.KeyPress += Validacion.NoLetras;
        }

        public override void EjecutarComandoFormLoad(object sender, EventArgs e)
        {
            CargarDatos(base.TipoOperacion, base.EntidadId, null);
        }

        public override void CargarDatos(TipoOperacion tipoOperacion, Guid? entidadId, Guid? entidadSecundariaId)
        {
            if (entidadId != null && entidadId.Value != Guid.Empty)
            {
                var resultEntidad = _condicionIvaServicio.GetById(entidadId.Value);

                if (resultEntidad.State)
                {
                    var _entidad = (TipoResponsabilidadDTO)resultEntidad.Data;

                    txtDescripcion.Text = _entidad.Descripcion;

                    txtCodigo.Text = _entidad.Codigo.ToString();
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

                var result = _condicionIvaServicio.Add(registro, Properties.Settings.Default.UserLogin);

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

                var result = _condicionIvaServicio.Update(registro, Properties.Settings.Default.UserLogin);

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


        private TipoResponsabilidadPersistenciaDTO AsignarDatos()
        {
            var _entidad = new TipoResponsabilidadPersistenciaDTO
            {
                Id = EntidadId ?? Guid.Empty,
                Descripcion = txtDescripcion.Text,
                Codigo = int.Parse(txtCodigo.Text)
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
