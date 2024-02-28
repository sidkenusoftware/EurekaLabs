using Serilog;
using Sidkenu.AccesoDatos.Constantes;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Base;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Seguridad.Localidad;
using Sidkenu.LogicaNegocio.Servicios.Interface.Seguridad;
using SidkenuWF.Formularios.Base;
using SidkenuWF.Formularios.Base.Constantes;
using SidkenuWF.Helpers;

namespace SidkenuWF.Formularios.Seguridad
{
    public partial class _00010_Localidad_Abm : FormularioAbm
    {
        private readonly ILocalidadServicio _localidadServicio;
        private readonly IProvinciaServicio _provinciaServicio;

        public _00010_Localidad_Abm(ISeguridadServicio seguridadServicio,
                                    IConfiguracionServicio configuracionServicio,
                                    ILogger logger,
                                    ILocalidadServicio localidadServicio,
                                    IProvinciaServicio provinciaServicio,
                                    TipoOperacion tipoOperacion,
                                    Guid? entidadId = null,
                                    Guid? entidadSecundariaId = null)
                                    : base(seguridadServicio, configuracionServicio, logger, tipoOperacion, entidadId, entidadSecundariaId)
        {
            InitializeComponent();

            base.TituloFormulario = Base.Constantes.FormularioConstantes.Titulo;
            base.Titulo = $"Localidad / {Enum.GetName(typeof(TipoOperacion), tipoOperacion)}";

            _localidadServicio = localidadServicio;
            _provinciaServicio = provinciaServicio;

            AgregarControlesObligatorios(txtDescripcion, "Provincia");

            txtDescripcion.KeyPress += Validacion.NoInyeccion;
        }

        public override void EjecutarComandoFormLoad(object sender, EventArgs e)
        {
            CargarDatos(base.TipoOperacion, base.EntidadId, null);
        }

        public override void CargarDatos(TipoOperacion tipoOperacion, Guid? entidadId, Guid? entidadSecundariaId)
        {
            var resulProvincias = _provinciaServicio.GetAll();

            if (resulProvincias.State)
            {
                PoblarComboBox(cmbProvincia, resulProvincias.Data, "Descripcion", "Id");
            }

            if (entidadId != null && entidadId.Value != Guid.Empty)
            {
                var resultEntidad = _localidadServicio.GetById(entidadId.Value);

                if (resultEntidad.State)
                {
                    var _entidad = (LocalidadDTO)resultEntidad.Data;

                    txtDescripcion.Text = _entidad.Descripcion;
                    cmbProvincia.SelectedValue = _entidad.ProvinciaId;
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

                var result = _localidadServicio.Add(registro, Properties.Settings.Default.UserLogin);

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

                var result = _localidadServicio.Update(registro, Properties.Settings.Default.UserLogin);

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

        private LocalidadPersistenciaDTO AsignarDatos()
        {
            var _entidad = new LocalidadPersistenciaDTO
            {
                Id = EntidadId ?? Guid.Empty,
                Descripcion = txtDescripcion.Text,
                ProvinciaId = (Guid)cmbProvincia.SelectedValue
            };

            this.Entidad = _entidad;

            return _entidad;
        }
        

        public override void OperacionAdicionalFinalizarInsert()
        {
            txtDescripcion.Focus();
        }

        private async void BtnNuevaProvincia_Click(object sender, EventArgs e)
        {
            try
            {
                var formularioNuevo = new _00008_Provincia_Abm(base._seguridadServicio,
                                                               base._configuracionServicio,
                                                               base._logger,
                                                               Program.Container.GetInstance<IProvinciaServicio>(),
                                                               TipoOperacion.Nuevo);

                FormularioSeguridad.VerificarAcceso(formularioNuevo, base._seguridadServicio, base._logger, base._configuracionDTO);

                if (formularioNuevo.RealizoAlgunaOperacion)
                {
                    var resul = _provinciaServicio.GetAll();

                    if (resul.State)
                    {
                        PoblarComboBox(cmbProvincia, resul.Data, "Descripcion", "Id");
                    }
                    else
                    {
                        MessageBox.Show("Ocurrió un error al obtener las provincias", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error al generar un nuevo registro");
            }
        }
    }
}
