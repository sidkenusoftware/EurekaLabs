using FontAwesome.Sharp;
using Serilog;
using Sidkenu.AccesoDatos.Constantes;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Base;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.Proveedor;
using Sidkenu.LogicaNegocio.Servicios.Interface.Core;
using Sidkenu.LogicaNegocio.Servicios.Interface.Seguridad;
using SidkenuWF.Formularios.Base;
using SidkenuWF.Formularios.Base.Constantes;
using SidkenuWF.Formularios.Seguridad;
using SidkenuWF.Helpers;

namespace SidkenuWF.Formularios.Core
{
    public partial class _00105_Proveedor_Abm : FormularioAbm
    {
        private readonly IProveedorServicio _proveedorServicio;
        private readonly ITipoResponsabilidadServicio _tipoResponsabilidadServicio;

        public _00105_Proveedor_Abm(ISeguridadServicio seguridadServicio,
                                  IConfiguracionServicio configuracionServicio,
                                  ILogger logger,
                                  IProveedorServicio proveedorServicio,
                                  ITipoResponsabilidadServicio tipoResponsabilidadServicio,
                                  TipoOperacion tipoOperacion,
                                  Guid? entidadId = null)
                                  : base(seguridadServicio, configuracionServicio, logger, tipoOperacion, entidadId)
        {
            InitializeComponent();

            base.TituloFormulario = FormularioConstantes.Titulo;
            base.Titulo = $"Proveedor / {Enum.GetName(typeof(TipoOperacion), tipoOperacion)}";
            base.Logo = IconChar.BuildingFlag;

            _proveedorServicio = proveedorServicio;
            _tipoResponsabilidadServicio = tipoResponsabilidadServicio;

            AgregarControlesObligatorios(txtRazonSocial, "Razon Social");
            AgregarControlesObligatorios(txtDireccion, "Dirección");
            AgregarControlesObligatorios(txtTelefono, "Teléfono");
            AgregarControlesObligatorios(txtCorreoElectronico, "Correo Electronico");
            AgregarControlesObligatorios(txtCUIT, "CUIT");
            AgregarControlesObligatorios(txtCodigo, "Codigo");
            AgregarControlesObligatorios(cmbTipoDocumento, "Tipo de Documento");
            AgregarControlesObligatorios(cmbTipoResponsabilidad, "Condicion de Iva");

            txtRazonSocial.KeyPress += Validacion.NoInyeccion;

            txtDireccion.KeyPress += Validacion.NoInyeccion;

            txtTelefono.KeyPress += Validacion.NoInyeccion;
            txtTelefono.KeyPress += Validacion.NoLetras;

            txtCUIT.KeyPress += Validacion.NoInyeccion;
            txtCUIT.KeyPress += Validacion.NoLetras;

            txtCodigo.KeyPress += Validacion.NoInyeccion;

            txtCorreoElectronico.KeyPress += Validacion.NoInyeccion;

            txtContacto.KeyPress += Validacion.NoInyeccion;
        }

        public override void EjecutarComandoFormLoad(object sender, EventArgs e)
        {
            CargarDatos(base.TipoOperacion, base.EntidadId, null);
        }

        public override void CargarDatos(TipoOperacion tipoOperacion, Guid? entidadId, Guid? entidadSecundariaId)
        {
            var resultTipoResponsabilidad = _tipoResponsabilidadServicio.GetAll();

            if (resultTipoResponsabilidad.State)
            {
                PoblarComboBox(cmbTipoResponsabilidad, resultTipoResponsabilidad.Data, "Descripcion", "Id");
            }

            if (entidadId != null && entidadId.Value != Guid.Empty)
            {
                var resultProveedor = _proveedorServicio.GetById(entidadId.Value);

                if (resultProveedor.State)
                {
                    var _entidad = (ProveedorDTO)resultProveedor.Data;

                    if (_entidad.EmpresaId.HasValue)
                    {
                        chkEmpresa.Checked = _entidad.EmpresaId.HasValue && _entidad.EmpresaId.Value == Properties.Settings.Default.EmpresaId;
                    }

                    cmbTipoResponsabilidad.SelectedValue = _entidad.TipoResponsabilidadId;

                    txtCodigo.Text = _entidad.Codigo;
                    txtRazonSocial.Text = _entidad.RazonSocial;
                    txtCorreoElectronico.Text = _entidad.Mail;
                    txtContacto.Text = _entidad.Contacto;
                    txtCUIT.Text = _entidad.CUIT;
                    txtDireccion.Text = _entidad.Direccion;
                    txtTelefono.Text = _entidad.Telefono;

                    chkCuentaCorriente.Checked = _entidad.ActivarCuentaCorriente;
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

                var result = _proveedorServicio.Add(registro, Properties.Settings.Default.UserLogin);

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

                var result = _proveedorServicio.Update(registro, Properties.Settings.Default.UserLogin);

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


        private ProveedorPersistenciaDTO AsignarDatos()
        {
            var _entidad = new ProveedorPersistenciaDTO
            {
                Id = EntidadId ?? Guid.Empty,
                EmpresaId = chkEmpresa.Checked ? Properties.Settings.Default.EmpresaId : null,
                TipoResponsabilidadId = (Guid)cmbTipoResponsabilidad.SelectedValue,

                Codigo = txtCodigo.Text,
                RazonSocial = txtRazonSocial.Text,
                Direccion = txtDireccion.Text,
                Mail = txtCorreoElectronico.Text,
                CUIT = txtCUIT.Text,
                Contacto = txtContacto.Text,
                Telefono = txtTelefono.Text,

                ActivarCuentaCorriente = chkCuentaCorriente.Checked,

                EstaEliminado = false,
            };

            this.Entidad = _entidad;

            return _entidad;
        }


        public override void OperacionAdicionalFinalizarInsert()
        {
            txtRazonSocial.Focus();
        }

        private async void BtnNuevoTipoResponsabilidad_Click(object sender, EventArgs e)
        {
            try
            {
                var formularioNuevo = new _00012_TipoResponsabilidad_Abm(base._seguridadServicio,
                                                                  base._configuracionServicio,
                                                                  base._logger,
                                                                  Program.Container.GetInstance<ITipoResponsabilidadServicio>(),
                                                                  TipoOperacion.Nuevo);

                FormularioSeguridad.VerificarAcceso(formularioNuevo, _seguridadServicio, _logger, _configuracionDTO);

                if (formularioNuevo.RealizoAlgunaOperacion)
                {
                    var resul = _tipoResponsabilidadServicio.GetAll();

                    if (resul.State)
                    {
                        PoblarComboBox(cmbTipoResponsabilidad, resul.Data, "Descripcion", "Id");
                    }
                    else
                    {
                        MessageBox.Show("Ocurrió un error al obtener las Tipos de Responsabilidades", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                if (base._configuracionDTO != null && base._configuracionDTO != null && base._configuracionDTO.LogError)
                {
                    _logger.Error(ex, $"Ocurrio un error al generar un nuevo registro en Tipo Responsabilidad. User: {Properties.Settings.Default.PersonaLogin}");
                }

                MessageBox.Show("Ocurrio un error al generar un nuevo registro");
            }
        }

        private void tabPageInformacionGeneral_Click(object sender, EventArgs e)
        {

        }
    }
}
