using Serilog;
using Sidkenu.AccesoDatos.Constantes;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Base;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.Caja;
using Sidkenu.LogicaNegocio.Servicios.Interface.Core;
using Sidkenu.LogicaNegocio.Servicios.Interface.Seguridad;
using SidkenuWF.Formularios.Base;
using SidkenuWF.Formularios.Base.Constantes;
using SidkenuWF.Helpers;

namespace SidkenuWF.Formularios.Core
{
    public partial class _00101_Caja_Abm : FormularioAbm
    {
        private readonly ICajaServicio _cajaServicio;
        public _00101_Caja_Abm(ISeguridadServicio seguridadServicio,
                               IConfiguracionServicio configuracionServicio,
                               ILogger logger,
                               ICajaServicio cajaServicio,
                               TipoOperacion tipoOperacion,
                               Guid? entidadId = null)
                               : base(seguridadServicio, configuracionServicio, logger, tipoOperacion, entidadId)
        {
            InitializeComponent();

            base.TituloFormulario = FormularioConstantes.Titulo;
            base.Titulo = $"Caja / {Enum.GetName(typeof(TipoOperacion), tipoOperacion)}";
            base.Logo = FontAwesome.Sharp.IconChar.SackDollar;

            _cajaServicio = cajaServicio;

            AgregarControlesObligatorios(txtAbreviatura, "Abreviatura");
            AgregarControlesObligatorios(txtDescripcion, "Caja");

            txtAbreviatura.KeyPress += Validacion.NoInyeccion;
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
                var resultEntidad = _cajaServicio.GetById(entidadId.Value);

                if (resultEntidad.State)
                {
                    var _entidad = (CajaDTO)resultEntidad.Data;

                    txtDescripcion.Text = _entidad.Descripcion;
                    txtAbreviatura.Text = _entidad.Abreviatura;
                    chkPermiteGastos.Checked = _entidad.PermiteGastos;
                    chkPagoProveedor.Checked = _entidad.PermitePagosProveedor;

                    chkEfectivo.Checked = _entidad.AceptaMedioPagoEfectivo;
                    chkCheque.Checked = _entidad.AceptaMedioPagoCheque;
                    chkTarjeta.Checked = _entidad.AceptaMedioPagoTarjeta;
                    chkTransferencia.Checked = _entidad.AceptaMedioPagoTransferencia;
                    chkCtaCte.Checked = _entidad.AceptaMedioPagoCtaCte;
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

                var result =  _cajaServicio.Add(registro, Properties.Settings.Default.UserLogin);

                if (result.State)
                {
                    chkPermiteGastos.Checked = false;
                    chkPagoProveedor.Checked = false;

                    chkEfectivo.Checked = false;
                    chkCheque.Checked = false;
                    chkTarjeta.Checked = false;
                    chkTransferencia.Checked = false;
                    chkCtaCte.Checked = false;

                    txtAbreviatura.Clear();
                    txtDescripcion.Clear();

                    txtAbreviatura.Focus();

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


        

        private CajaPersistenciaDTO AsignarDatos()
        {
            var _entidad = new CajaPersistenciaDTO
            {
                Id = EntidadId ?? Guid.Empty,
                Descripcion = txtDescripcion.Text,
                Abreviatura = txtAbreviatura.Text,
                EmpresaId = Properties.Settings.Default.EmpresaId,
                PermiteGastos = chkPermiteGastos.Checked,
                PermitePagosProveedor = chkPagoProveedor.Checked,

                AceptaMedioPagoEfectivo = chkEfectivo.Checked,
                AceptaMedioPagoTarjeta = chkTarjeta.Checked,
                AceptaMedioPagoCheque = chkCheque.Checked,
                AceptaMedioPagoTransferencia = chkTransferencia.Checked,
                AceptaMedioPagoCtaCte = chkCtaCte.Checked,
            };

            this.Entidad = _entidad;

            return _entidad;
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

                var result = _cajaServicio.Update(registro, Properties.Settings.Default.UserLogin);

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

        public override void OperacionAdicionalFinalizarInsert()
        {
            chkPermiteGastos.Checked = false;
            txtDescripcion.Focus();
        }
    }
}
