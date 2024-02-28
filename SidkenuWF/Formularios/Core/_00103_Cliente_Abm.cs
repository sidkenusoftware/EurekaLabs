using FontAwesome.Sharp;
using Serilog;
using Sidkenu.AccesoDatos.Constantes;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Base;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.Cliente;
using Sidkenu.LogicaNegocio.Servicios.Interface.Core;
using Sidkenu.LogicaNegocio.Servicios.Interface.Seguridad;
using SidkenuWF.Formularios.Base;
using SidkenuWF.Formularios.Base.Constantes;
using SidkenuWF.Formularios.Seguridad;
using SidkenuWF.Helpers;

namespace SidkenuWF.Formularios.Core
{
    public partial class _00103_Cliente_Abm : FormularioAbm
    {
        private readonly IClienteServicio _clienteServicio;
        private readonly ITipoDocumentoServicio _tipoDocumentoServicio;
        private readonly ITipoResponsabilidadServicio _tipoResponsabilidadServicio;
        private readonly IListaPrecioServicio _listaPrecioServicio;

        public _00103_Cliente_Abm(ISeguridadServicio seguridadServicio,
                                  IConfiguracionServicio configuracionServicio,
                                  ILogger logger,
                                  IClienteServicio clienteServicio,
                                  ITipoResponsabilidadServicio tipoResponsabilidadServicio,
                                  ITipoDocumentoServicio tipoDocumentoServicio,
                                  IListaPrecioServicio listaPrecioServicio,
                                  TipoOperacion tipoOperacion,
                                  Guid? entidadId = null)
                                  : base(seguridadServicio, configuracionServicio, logger, tipoOperacion, entidadId)
        {
            InitializeComponent();

            base.TituloFormulario = FormularioConstantes.Titulo;
            base.Titulo = $"Cliente / {Enum.GetName(typeof(TipoOperacion), tipoOperacion)}";
            base.Logo = IconChar.BuildingFlag;

            _clienteServicio = clienteServicio;
            _tipoResponsabilidadServicio = tipoResponsabilidadServicio;
            _tipoDocumentoServicio = tipoDocumentoServicio;
            _listaPrecioServicio = listaPrecioServicio;

            AgregarControlesObligatorios(txtRazonSocial, "Razon Social");
            AgregarControlesObligatorios(txtDireccion, "Dirección");
            AgregarControlesObligatorios(txtTelefono, "Teléfono");
            AgregarControlesObligatorios(txtCorreoElectronico, "Correo Electronico");
            AgregarControlesObligatorios(txtDocumento, "Documento");
            AgregarControlesObligatorios(cmbTipoDocumento, "Tipo de Documento");
            AgregarControlesObligatorios(cmbTipoResponsabilidad, "Condicion de Iva");

            txtRazonSocial.KeyPress += Validacion.NoInyeccion;

            txtDireccion.KeyPress += Validacion.NoInyeccion;

            txtTelefono.KeyPress += Validacion.NoInyeccion;
            txtTelefono.KeyPress += Validacion.NoLetras;

            txtDocumento.KeyPress += Validacion.NoInyeccion;
            txtDocumento.KeyPress += Validacion.NoLetras;
        }

        public override void EjecutarComandoFormLoad(object sender, EventArgs e)
        {
            CargarDatos(base.TipoOperacion, base.EntidadId, null);
        }

        public override void CargarDatos(TipoOperacion tipoOperacion, Guid? entidadId, Guid? entidadSecundariaId)
        {
            var resultTipoDocumento = _tipoDocumentoServicio.GetAll();

            if (resultTipoDocumento.State)
            {
                PoblarComboBox(cmbTipoDocumento, resultTipoDocumento.Data, "Descripcion", "Id");
            }

            var resultTipoResponsabilidad = _tipoResponsabilidadServicio.GetAll();

            if (resultTipoResponsabilidad.State)
            {
                PoblarComboBox(cmbTipoResponsabilidad, resultTipoResponsabilidad.Data, "Descripcion", "Id");
            }

            var resulListaPrecios = _listaPrecioServicio.GetAll();

            if (resulListaPrecios.State)
            {
                PoblarComboBox(cmbListaPrecio, resulListaPrecios.Data, "Descripcion", "Id");
            }

            if (entidadId != null && entidadId.Value != Guid.Empty)
            {
                var resultCliente = _clienteServicio.GetById(entidadId.Value);

                if (resultCliente.State)
                {
                    var _entidad = (ClienteDTO)resultCliente.Data;

                    if (_entidad.EmpresaId.HasValue)
                    {
                        chkEmpresa.Checked = _entidad.EmpresaId.HasValue && _entidad.EmpresaId.Value == Properties.Settings.Default.EmpresaId;
                    }

                    if (_entidad.ListaPrecioId.HasValue)
                    {
                        cmbListaPrecio.SelectedValue = _entidad.ListaPrecioId.Value;
                        chkListaPrecio.Checked = _entidad.ListaPrecioId.HasValue;
                    }

                    cmbTipoResponsabilidad.SelectedValue = _entidad.TipoResponsabilidadId;
                    cmbTipoDocumento.SelectedItem = _entidad.TipoDocumentoId;

                    txtRazonSocial.Text = _entidad.RazonSocial;
                    txtCorreoElectronico.Text = _entidad.Mail;
                    txtDocumento.Text = _entidad.Documento;
                    txtDireccion.Text = _entidad.Direccion;
                    txtTelefono.Text = _entidad.Telefono;
                    dtpFechaNacimiento.Value = _entidad.FechaNacimiento.HasValue ? _entidad.FechaNacimiento.Value : DateTime.Now;

                    nudBonificacion.Value = _entidad.Bonificacion.HasValue ? _entidad.Bonificacion.Value : 0m;
                    nudMontoMaximoCompra.Value = _entidad.MontoMaximoCompra.HasValue ? _entidad.MontoMaximoCompra.Value : 0m;

                    chkBonificacion.Checked = _entidad.ActivarBonificacion;
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

                var result = _clienteServicio.Add(registro, Properties.Settings.Default.UserLogin);

                if (result.State)
                {
                    if (base._configuracionDTO != null && base._configuracionDTO != null && base._configuracionDTO.LogInformacion)
                    {
                        _logger.Information($"Se INSERTO Datos: {AsignarDatos().GetPropValue()}. User: {Properties.Settings.Default.PersonaLogin}");
                    }
                }

                if (base.TipoOperacion == TipoOperacion.LlamadaExterna)
                {
                    base.Entidad =  result.Data;

                    this.Close();
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

                var result = _clienteServicio.Update(registro, Properties.Settings.Default.UserLogin);

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

        private ClientePersistenciaDTO AsignarDatos()
        {
            var _entidad = new ClientePersistenciaDTO
            {
                Id = EntidadId ?? Guid.Empty,
                EmpresaId = chkEmpresa.Checked ? Properties.Settings.Default.EmpresaId : null,
                ListaPrecioId = chkListaPrecio.Checked ? (Guid)cmbListaPrecio.SelectedValue : null,
                TipoResponsabilidadId = (Guid)cmbTipoResponsabilidad.SelectedValue,
                TipoDocumentoId = (Guid)cmbTipoDocumento.SelectedValue,

                RazonSocial = txtRazonSocial.Text,
                Direccion = txtDireccion.Text,
                Mail = txtCorreoElectronico.Text,
                Documento = txtDocumento.Text,
                FechaNacimiento = dtpFechaNacimiento.Value,
                Telefono = txtTelefono.Text,

                ActivarCuentaCorriente = chkCuentaCorriente.Checked,
                MontoMaximoCompra = nudMontoMaximoCompra.Value,

                ActivarBonificacion = chkBonificacion.Checked,
                Bonificacion = nudMontoMaximoCompra.Value,

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

        private void BtnNuevaListaPrecio_Click(object sender, EventArgs e)
        {
            try
            {
                var formularioNuevo = new _00139_ListaPrecio_Abm(base._seguridadServicio,
                                                                 base._configuracionServicio,
                                                                 base._logger,
                                                                 Program.Container.GetInstance<IListaPrecioServicio>(),
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
                        MessageBox.Show("Ocurrió un error al obtener las Listas de Precios", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                if (base._configuracionDTO != null && base._configuracionDTO != null && base._configuracionDTO.LogError)
                {
                    _logger.Error(ex, $"Ocurrio un error al generar un nuevo registro en Lista de Precio. User: {Properties.Settings.Default.PersonaLogin}");
                }

                MessageBox.Show("Ocurrio un error al generar un nuevo registro");
            }
        }
    }
}
