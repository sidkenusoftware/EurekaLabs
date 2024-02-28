using SidkenuWF.Formularios.Base.Constantes;
using SidkenuWF.Formularios.Base;
using SidkenuWF.Helpers;
using Serilog;
using Sidkenu.LogicaNegocio.Servicios.Interface.Core;
using Sidkenu.LogicaNegocio.Servicios.Interface.Seguridad;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.CondicionIva;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Base;
using Sidkenu.AccesoDatos.Constantes;

namespace SidkenuWF.Formularios.Core
{
    public partial class _00129_CondicionIva_Abm : FormularioAbm
    {
        private readonly ICondicionIvaServicio _condicionIvaServicio;
        public _00129_CondicionIva_Abm(ISeguridadServicio seguridadServicio,
                                    IConfiguracionServicio configuracionServicio,
                                    ILogger logger,
                                    ICondicionIvaServicio condicionIvaServicio,
                                    TipoOperacion tipoOperacion,
                                    Guid? entidadId = null)
                                    : base(seguridadServicio, configuracionServicio, logger, tipoOperacion, entidadId)
        {
            InitializeComponent();

            base.TituloFormulario = FormularioConstantes.Titulo;
            base.Titulo = $"Condición de Iva / {Enum.GetName(typeof(TipoOperacion), tipoOperacion)}";

            _condicionIvaServicio = condicionIvaServicio;

            AgregarControlesObligatorios(txtCodigo, "Codigo");
            AgregarControlesObligatorios(txtDescripcion, "Condicion de Iva");

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
                var resultEntidad = _condicionIvaServicio.GetById(entidadId.Value);

                if (resultEntidad.State)
                {
                    var _entidad = (CondicionIvaDTO)resultEntidad.Data;

                    txtDescripcion.Text = _entidad.Descripcion;
                    txtCodigo.Text = _entidad.Codigo;

                    chkEmpresa.Checked = _entidad.EmpresaId.HasValue;

                    nudCondicionIva.Value = _entidad.Valor;

                    chkActivarParaFacturaElectronica.Checked = _entidad.AplicaParaFacturaElectronica;
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

        private CondicionIvaPersistenciaDTO AsignarDatos()
        {
            var _entidad = new CondicionIvaPersistenciaDTO
            {
                Id = EntidadId ?? Guid.Empty,
                Descripcion = txtDescripcion.Text,
                Codigo = txtCodigo.Text,
                EmpresaId = chkEmpresa.Checked ? Properties.Settings.Default.EmpresaId : null,
                AplicaParaFacturaElectronica = chkActivarParaFacturaElectronica.Checked,
                Valor = nudCondicionIva.Value
            };

            this.Entidad = _entidad;

            return _entidad;
        }

        public override void OperacionAdicionalFinalizarInsert()
        {
            chkEmpresa.Checked = false;
            txtDescripcion.Focus();
        }

        private void _00129_CondicionIva_Abm_Load(object sender, EventArgs e)
        {

        }
    }
}
