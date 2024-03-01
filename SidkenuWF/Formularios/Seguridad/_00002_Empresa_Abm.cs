using FontAwesome.Sharp;
using Serilog;
using Sidkenu.AccesoDatos.Constantes;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Base;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Seguridad.Empresa;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Seguridad.Localidad;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Seguridad.Provincia;
using Sidkenu.LogicaNegocio.Servicios.Interface.Seguridad;
using SidkenuWF.Formularios.Base;
using SidkenuWF.Formularios.Base.Constantes;
using SidkenuWF.Helpers;

namespace SidkenuWF.Formularios.Seguridad
{
    public partial class _00002_Empresa_Abm : FormularioAbm
    {
        private readonly IEmpresaServicio _empresaServicio;
        private readonly IIngresoBrutoServicio _ingresoBrutoServicio;
        private readonly ITipoResponsabilidadServicio _tipoResponsabilidadServicio;
        private readonly IProvinciaServicio _provinciaServicio;
        private readonly ILocalidadServicio _localidadServicio;

        public _00002_Empresa_Abm(ISeguridadServicio seguridadServicio,
                                  IConfiguracionServicio configuracionServicio,
                                  ILogger logger,
                                  IEmpresaServicio empresaServicio,
                                  ITipoResponsabilidadServicio tipoResponsabilidadServicio,
                                  IProvinciaServicio provinciaServicio,
                                  ILocalidadServicio localidadServicio,
                                  IIngresoBrutoServicio ingresoBrutoServicio,
                                  TipoOperacion tipoOperacion,
                                  Guid? entidadId = null)
                                  : base(seguridadServicio, configuracionServicio, logger, tipoOperacion, entidadId)
        {
            InitializeComponent();

            base.TituloFormulario = FormularioConstantes.Titulo;
            base.Titulo = $"Empresa / {Enum.GetName(typeof(TipoOperacion), tipoOperacion)}";
            base.Logo = IconChar.BuildingFlag;

            _empresaServicio = empresaServicio;
            _tipoResponsabilidadServicio = tipoResponsabilidadServicio;
            _ingresoBrutoServicio = ingresoBrutoServicio;
            _localidadServicio = localidadServicio;
            _provinciaServicio = provinciaServicio;

            AgregarControlesObligatorios(txtCodigo, "Código");
            AgregarControlesObligatorios(txtAbreviatura, "Abreviatura");
            AgregarControlesObligatorios(txtEmpresa, "Compañia");
            AgregarControlesObligatorios(txtCuit, "CUIT");
            AgregarControlesObligatorios(txtDireccion, "Dirección");
            AgregarControlesObligatorios(txtTelefono, "Teléfono");
            AgregarControlesObligatorios(txtCorreoElectronico, "Correo Electronico");
            AgregarControlesObligatorios(txtIngresoBruto, "Ingreso Bruto");
            AgregarControlesObligatorios(cmbProvincia, "Provincia");
            AgregarControlesObligatorios(cmbLocalidad, "Localidad");
            AgregarControlesObligatorios(cmbTipoResponsabilidad, "Condicion de Iva");
            AgregarControlesObligatorios(cmbIngresoBruto, "Ingreso Bruto");

            txtCodigo.KeyPress += Validacion.NoInyeccion;
            txtCodigo.KeyPress += Validacion.NoLetras;

            txtAbreviatura.KeyPress += Validacion.NoInyeccion;

            txtEmpresa.KeyPress += Validacion.NoInyeccion;

            txtDireccion.KeyPress += Validacion.NoInyeccion;

            txtTelefono.KeyPress += Validacion.NoInyeccion;
            txtTelefono.KeyPress += Validacion.NoLetras;

            txtCuit.KeyPress += Validacion.NoInyeccion;
            txtCuit.KeyPress += Validacion.NoLetras;

            txtIngresoBruto.KeyPress += Validacion.NoInyeccion;
            txtIngresoBruto.KeyPress += Validacion.NoLetras;
        }

        public override void EjecutarComandoFormLoad(object sender, EventArgs e)
        {
            CargarDatos(base.TipoOperacion, base.EntidadId, null);
        }

        public override void CargarDatos(TipoOperacion tipoOperacion, Guid? entidadId, Guid? entidadSecundariaId)
        {
            var resultIngresoBruto = _ingresoBrutoServicio.GetAll();

            if (resultIngresoBruto.State)
            {
                PoblarComboBox(cmbIngresoBruto, resultIngresoBruto.Data, "Descripcion", "Id");
            }

            var resultCondicionIva = _tipoResponsabilidadServicio.GetAll();

            if (resultCondicionIva.State)
            {
                PoblarComboBox(cmbTipoResponsabilidad, resultCondicionIva.Data, "Descripcion", "Id");
            }

            var resulProvincias = _provinciaServicio.GetAll();

            if (resulProvincias.State)
            {
                PoblarComboBox(cmbProvincia, resulProvincias.Data, "Descripcion", "Id");
            }

            if (entidadId != null && entidadId.Value != Guid.Empty)
            {
                var resultEmpresa = _empresaServicio.GetById(entidadId.Value);

                if (resultEmpresa.State)
                {
                    var _entidad = (EmpresaDTO)resultEmpresa.Data;

                    cmbProvincia.SelectedValue = _entidad.ProvinciaId;
                    cmbTipoResponsabilidad.SelectedValue = _entidad.TipoResponsabilidadId;
                    cmbIngresoBruto.SelectedItem = _entidad.IngresoBrutoId;

                    txtEmpresa.Text = _entidad.Descripcion;
                    txtCodigo.Text = _entidad.Codigo.ToString();
                    txtAbreviatura.Text = _entidad.Abreviatura;
                    txtCorreoElectronico.Text = _entidad.Mail;
                    txtCuit.Text = _entidad.Cuit;
                    txtDireccion.Text = _entidad.Direccion;
                    txtIngresoBruto.Text = _entidad.IngresoBruto;
                    txtReferente.Text = _entidad.Referente;
                    txtTelefono.Text = _entidad.Telefono;
                    dtpFechaInicioActividades.Value = _entidad.FechaInicioActividad;
                    ctrolFoto.Imagen = ImagenConvert.Convertir_Bytes_Imagen(_entidad.Logo);

                    var resultLocalidad = _localidadServicio
                        .GetByFilter(new LocalidadFilterDTO { ProvinciaId = _entidad.ProvinciaId });

                    if (resultLocalidad.State)
                    {
                        PoblarComboBox(cmbLocalidad, resultLocalidad.Data, "Descripcion", "Id");

                        if (cmbLocalidad.Items.Count > 0)
                        {
                            cmbLocalidad.SelectedValue = _entidad.LocalidadId;
                        }
                    }
                }
            }
            else
            {
                if (cmbProvincia.Items.Count > 0)
                {
                    var provinciaId = (Guid)cmbProvincia.SelectedValue;

                    var resultLocalidad = _localidadServicio
                        .GetByFilter(new LocalidadFilterDTO { ProvinciaId = provinciaId });

                    if (resultLocalidad.State)
                    {
                        PoblarComboBox(cmbLocalidad, resultLocalidad.Data, "Descripcion", "Id");
                    }
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

                if (!Validacion.ValidarEmail(txtCorreoElectronico.Text))
                {
                    return new ResultDTO
                    {
                        State = false,
                        Message = "El Correo Electrónico NO tiene el formato correcto"
                    };
                }

                var registro = AsignarDatos();

                var result = _empresaServicio.Add(registro, Properties.Settings.Default.UserLogin);

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

                if (!Validacion.ValidarEmail(txtCorreoElectronico.Text))
                {
                    return new ResultDTO
                    {
                        State = false,
                        Message = "El Correo Electrónico NO tiene el formato correcto"
                    };
                }

                var registro = AsignarDatos();

                var result = _empresaServicio.Update(registro, Properties.Settings.Default.UserLogin);

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

        private EmpresaPersistenciaDTO AsignarDatos()
        {
            var _entidad = new EmpresaPersistenciaDTO
            {
                Id = EntidadId ?? Guid.Empty,
                LocalidadId = (Guid)cmbLocalidad.SelectedValue,
                IngresoBrutoId = (Guid)cmbIngresoBruto.SelectedValue,
                TipoResponsabilidadId = (Guid)cmbTipoResponsabilidad.SelectedValue,
                Codigo = int.Parse(txtCodigo.Text),
                Abreviatura = txtAbreviatura.Text,
                Descripcion = txtEmpresa.Text,
                Direccion = txtDireccion.Text,
                Logo = ImagenConvert.Convertir_Imagen_Bytes(ctrolFoto.Imagen),
                Mail = txtCorreoElectronico.Text,
                Cuit = txtCuit.Text,
                EstaEliminado = false,
                NroIngresoBruto = txtIngresoBruto.Text,
                FechaInicioActividad = dtpFechaInicioActividades.Value,
                Referente = txtReferente.Text,
                Telefono = txtTelefono.Text,
            };

            this.Entidad = _entidad;

            return _entidad;
        }


        public override void OperacionAdicionalFinalizarInsert()
        {
            txtEmpresa.Focus();
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

                FormularioSeguridad.VerificarAcceso(formularioNuevo, _seguridadServicio, _logger, _configuracionDTO);

                if (formularioNuevo.RealizoAlgunaOperacion)
                {
                    var resul = _provinciaServicio.GetAll();

                    if (resul.State)
                    {
                        PoblarComboBox(cmbProvincia, resul.Data, "Descripcion", "Id");

                        if (((List<ProvinciaDTO>)resul.Data).Any())
                        {
                            var provinciaId = (Guid)cmbProvincia.SelectedValue;

                            var resultLocalidad = _localidadServicio
                                .GetByFilter(new LocalidadFilterDTO { ProvinciaId = provinciaId });

                            if (resultLocalidad.State)
                            {
                                PoblarComboBox(cmbLocalidad, resultLocalidad.Data, "Descripcion", "Id");
                            }
                            else
                            {
                                MessageBox.Show("Ocurrió un error al obtener las localidades", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ocurrió un error al obtener las provincias", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                if (base._configuracionDTO != null && base._configuracionDTO != null && base._configuracionDTO.LogError)
                {
                    _logger.Error(ex, $"Ocurrio un error al generar un nuevo registro en Provincia. User: {Properties.Settings.Default.PersonaLogin}");
                }

                MessageBox.Show("Ocurrio un error al generar un nuevo registro");
            }
        }

        private async void CmbProvincia_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmbProvincia.Items.Count > 0)
            {
                var resultLocalidad = _localidadServicio.GetByFilter(new LocalidadFilterDTO { ProvinciaId = (Guid)cmbProvincia.SelectedValue });

                if (resultLocalidad.State)
                {
                    PoblarComboBox(cmbLocalidad, (List<LocalidadDTO>)resultLocalidad.Data, "Descripcion", "Id");
                }
                else
                {
                    MessageBox.Show("Ocurrió un error al obtener las localidades", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async void BtnNuevaCondicionIva_Click(object sender, EventArgs e)
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
                        MessageBox.Show("Ocurrió un error al obtener las Condiciones de Iva", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                if (base._configuracionDTO != null && base._configuracionDTO != null && base._configuracionDTO.LogError)
                {
                    _logger.Error(ex, $"Ocurrio un error al generar un nuevo registro en Condición de Iva. User: {Properties.Settings.Default.PersonaLogin}");
                }

                MessageBox.Show("Ocurrio un error al generar un nuevo registro");
            }
        }

        private async void BtnNuevaLocalidad_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbProvincia.Items.Count > 0)
                {

                    var formularioNuevo = new _00010_Localidad_Abm(base._seguridadServicio,
                                                                   base._configuracionServicio,
                                                                   base._logger,
                                                                   Program.Container.GetInstance<ILocalidadServicio>(),
                                                                   Program.Container.GetInstance<IProvinciaServicio>(),
                                                                   TipoOperacion.Nuevo, null, (Guid)cmbProvincia.SelectedValue);

                    FormularioSeguridad.VerificarAcceso(formularioNuevo, _seguridadServicio, _logger, _configuracionDTO);

                    if (formularioNuevo != null)
                    {
                        formularioNuevo.ShowDialog();

                        if (formularioNuevo.RealizoAlgunaOperacion)
                        {
                            var resul = _localidadServicio.GetByFilter(new LocalidadFilterDTO { ProvinciaId = (Guid)cmbProvincia.SelectedValue });

                            if (resul.State)
                            {
                                PoblarComboBox(cmbLocalidad, resul.Data, "Descripcion", "Id");
                            }
                            else
                            {
                                MessageBox.Show("Ocurrió un error al obtener las localidades", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }

                }
                else
                {
                    MessageBox.Show("No hay una Provincia seleccionada", "Atención", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                if (base._configuracionDTO != null && base._configuracionDTO != null && base._configuracionDTO.LogError)
                {
                    _logger.Error(ex, $"Ocurrio un error al generar un nuevo registro en Localidad. User: {Properties.Settings.Default.PersonaLogin}");
                }

                MessageBox.Show("Ocurrio un error al generar un nuevo registro");
            }
        }

        private async void BtnNuevoIngresoBruto_Click(object sender, EventArgs e)
        {
            try
            {
                var formularioNuevo = new _00014_IngresoBruto_Abm(base._seguridadServicio,
                                                                  base._configuracionServicio,
                                                                  base._logger,
                                                                  Program.Container.GetInstance<IIngresoBrutoServicio>(),
                                                                  TipoOperacion.Nuevo);

                FormularioSeguridad.VerificarAcceso(formularioNuevo, _seguridadServicio, _logger, _configuracionDTO);

                if (formularioNuevo.RealizoAlgunaOperacion)
                {
                    var resul = _ingresoBrutoServicio.GetAll();

                    if (resul.State)
                    {
                        PoblarComboBox(cmbIngresoBruto, resul.Data, "Descripcion", "Id");
                    }
                    else
                    {
                        MessageBox.Show("Ocurrió un error al obtener los Ingresos Brutos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                if (base._configuracionDTO != null && base._configuracionDTO.LogError)
                {
                    _logger.Error(ex, $"Ocurrio un error al generar un nuevo registro de Empresa. User: {Properties.Settings.Default.PersonaLogin}");
                }

                MessageBox.Show("Ocurrio un error al generar un nuevo registro");
            }
        }
    }
}
