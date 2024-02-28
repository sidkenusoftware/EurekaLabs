using SidkenuWF.Formularios.Base.Constantes;
using SidkenuWF.Formularios.Base;
using SidkenuWF.Helpers;
using Serilog;
using Sidkenu.LogicaNegocio.Servicios.Interface.Core;
using Sidkenu.LogicaNegocio.Servicios.Interface.Seguridad;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.UnidadMedida;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Base;
using Sidkenu.AccesoDatos.Constantes;

namespace SidkenuWF.Formularios.Core
{
    public partial class _00131_UnidadMedida_Abm : FormularioAbm
    {
        private readonly IUnidadMedidaServicio _unidadMedidaServicio;
        public _00131_UnidadMedida_Abm(ISeguridadServicio seguridadServicio,
                                    IConfiguracionServicio configuracionServicio,
                                    ILogger logger,
                                    IUnidadMedidaServicio unidadMedidaServicio,
                                    TipoOperacion tipoOperacion,
                                    Guid? entidadId = null)
                                    : base(seguridadServicio, configuracionServicio, logger, tipoOperacion, entidadId)
        {
            InitializeComponent();

            base.TituloFormulario = FormularioConstantes.Titulo;
            base.Titulo = $"Unidad de Medida / {Enum.GetName(typeof(TipoOperacion), tipoOperacion)}";

            _unidadMedidaServicio = unidadMedidaServicio;

            AgregarControlesObligatorios(txtCodigo, "Codigo");
            AgregarControlesObligatorios(txtDescripcion, "Unidad de Medida");

            txtCodigo.KeyPress += Validacion.NoInyeccion;
            txtDescripcion.KeyPress += Validacion.NoInyeccion;
        }

        public override void EjecutarComandoFormLoad(object sender, EventArgs e)
        {
            CargarDatos(base.TipoOperacion, base.EntidadId, null);
        }

        public override void CargarDatos(TipoOperacion tipoOperacion, Guid? entidadId, Guid? entidadSecundariaId)
        {
            if (entidadId != null && entidadId.Value != Guid.Empty)
            {
                var resultEntidad = _unidadMedidaServicio.GetById(entidadId.Value);

                if (resultEntidad.State)
                {
                    var _entidad = (UnidadMedidaDTO)resultEntidad.Data;

                    txtDescripcion.Text = _entidad.Descripcion;
                    txtCodigo.Text = _entidad.Codigo;

                    chkEmpresa.Checked = _entidad.EmpresaId.HasValue;

                    nudEquivalencia.Value = _entidad.Equivalencia;
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

                var result = _unidadMedidaServicio.Add(registro, Properties.Settings.Default.UserLogin);

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

                var result = _unidadMedidaServicio.Update(registro, Properties.Settings.Default.UserLogin);

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

        private UnidadMedidaPersistenciaDTO AsignarDatos()
        {
            var _entidad = new UnidadMedidaPersistenciaDTO
            {
                Id = EntidadId ?? Guid.Empty,
                Descripcion = txtDescripcion.Text,
                Codigo = txtCodigo.Text,
                EmpresaId = chkEmpresa.Checked ? Properties.Settings.Default.EmpresaId : null,
                Equivalencia = nudEquivalencia.Value
            };

            this.Entidad = _entidad;

            return _entidad;
        }


        public override void OperacionAdicionalFinalizarInsert()
        {
            chkEmpresa.Checked = false;
            txtDescripcion.Focus();
        }
    }
}
