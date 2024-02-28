using SidkenuWF.Formularios.Base.Constantes;
using SidkenuWF.Formularios.Base;
using SidkenuWF.Helpers;
using Serilog;
using Sidkenu.LogicaNegocio.Servicios.Interface.Core;
using Sidkenu.LogicaNegocio.Servicios.Interface.Seguridad;
using Sidkenu.AccesoDatos.Constantes;
using Sidkenu.AccesoDatos.Constantes.Enum;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.Deposito;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Base;

namespace SidkenuWF.Formularios.Core
{
    public partial class _00137_Deposito_Abm : FormularioAbm
    {
        private readonly IDepositoServicio _depositoServicio;
        public _00137_Deposito_Abm(ISeguridadServicio seguridadServicio,
                                   IConfiguracionServicio configuracionServicio,
                                   ILogger logger,
                                   IDepositoServicio depositoServicio,
                                   TipoOperacion tipoOperacion,
                                   Guid? entidadId = null)
                                   : base(seguridadServicio, configuracionServicio, logger, tipoOperacion, entidadId)
        {
            InitializeComponent();

            base.TituloFormulario = FormularioConstantes.Titulo;
            base.Titulo = $"Deposito / {Enum.GetName(typeof(TipoOperacion), tipoOperacion)}";

            _depositoServicio = depositoServicio;

            AgregarControlesObligatorios(txtAbreviatura, "Abreviatura");
            AgregarControlesObligatorios(txtDescripcion, "Deposito");
            AgregarControlesObligatorios(cmbTipoDeposito, "Tipo Deposito");

            txtAbreviatura.KeyPress += Validacion.NoInyeccion;
            txtDescripcion.KeyPress += Validacion.NoInyeccion;
        }

        public override void EjecutarComandoFormLoad(object sender, EventArgs e)
        {
            CargarDatos(base.TipoOperacion, base.EntidadId, null);
        }

        public override void CargarDatos(TipoOperacion tipoOperacion, Guid? entidadId, Guid? entidadSecundariaId)
        {
            var listaTipoDepositos = EnumDescription.GetAll<TipoDeposito>();

            PoblarComboBox(cmbTipoDeposito, listaTipoDepositos, "Descripcion", "Valor");

            if (entidadId != null && entidadId.Value != Guid.Empty)
            {
                var resultEntidad = _depositoServicio.GetById(entidadId.Value);

                if (resultEntidad.State)
                {
                    var _entidad = (DepositoDTO)resultEntidad.Data;

                    txtDescripcion.Text = _entidad.Descripcion;
                    txtAbreviatura.Text = _entidad.Abreviatura;
                    txtDireccion.Text = _entidad.Direccion;                    
                    cmbTipoDeposito.SelectedValue = _entidad.TipoDeposito;
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

                var result = _depositoServicio.Add(registro, Properties.Settings.Default.UserLogin);

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

                var result = _depositoServicio.Update(registro, Properties.Settings.Default.UserLogin);

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

        private DepositoPersistenciaDTO AsignarDatos()
        {
            var _entidad = new DepositoPersistenciaDTO
            {
                Id = EntidadId ?? Guid.Empty,
                Descripcion = txtDescripcion.Text,
                Abreviatura = txtAbreviatura.Text,
                Direccion = txtDireccion.Text,
                TipoDeposito = (TipoDeposito)cmbTipoDeposito.SelectedValue,
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

