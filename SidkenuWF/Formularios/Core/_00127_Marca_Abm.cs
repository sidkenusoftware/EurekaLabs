using SidkenuWF.Formularios.Base.Constantes;
using SidkenuWF.Formularios.Base;
using SidkenuWF.Helpers;
using Serilog;
using Sidkenu.LogicaNegocio.Servicios.Interface.Core;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.Marca;
using Sidkenu.LogicaNegocio.Servicios.Interface.Seguridad;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.ConfiguracionCore;
using Sidkenu.AccesoDatos.Constantes;
using Sidkenu.AccesoDatos.Constantes.Enum;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Base;

namespace SidkenuWF.Formularios.Core
{
    public partial class _00127_Marca_Abm : FormularioAbm
    {
        private readonly IMarcaServicio _marcaServicio;
        private readonly IConfiguracionCoreServicio _configuracionCoreServicio;
        private MarcaDTO _entidad;

        public _00127_Marca_Abm(ISeguridadServicio seguridadServicio,
                                IConfiguracionServicio configuracionServicio,
                                ILogger logger,
                                IMarcaServicio marcaServicio,
                                IConfiguracionCoreServicio configuracionCoreServicio,
                                TipoOperacion tipoOperacion,
                                Guid? entidadId = null)
                                : base(seguridadServicio, configuracionServicio, logger, tipoOperacion, entidadId)
        {
            InitializeComponent();

            base.TituloFormulario = FormularioConstantes.Titulo;
            base.Titulo = $"Marca / {Enum.GetName(typeof(TipoOperacion), tipoOperacion)}";

            _marcaServicio = marcaServicio;

            AgregarControlesObligatorios(txtCodigo, "Codigo");
            AgregarControlesObligatorios(txtDescripcion, "Marca");

            txtCodigo.KeyPress += Validacion.NoInyeccion;
            txtDescripcion.KeyPress += Validacion.NoInyeccion;
            _configuracionCoreServicio = configuracionCoreServicio;
        }

        public override void EjecutarComandoFormLoad(object sender, EventArgs e)
        {
            nudAumentoPrecioPublico.Value = 0;
            nudAumentoPrecioPublico.Enabled = false;
            cmbTipoAumentoPrecioPublico.Enabled = false;
            chkAumentoPrecioPublico.Checked = false;

            nudAumentoPrecioPublicoListaPrecio.Value = 0;
            nudAumentoPrecioPublicoListaPrecio.Enabled = false;
            cmbTipoAumentoPrecioPublicoListaPrecio.Enabled = false;
            chkAumentoPrecioPublicoListaPrecio.Checked = false;

            CargarDatos(base.TipoOperacion, base.EntidadId, null);
        }

        public override void CargarDatos(TipoOperacion tipoOperacion, Guid? entidadId, Guid? entidadSecundariaId)
        {
            var _configResult = _configuracionCoreServicio
                                .Get(Properties.Settings.Default.EmpresaId);

            if (_configResult == null && !_configResult.State)
            {
                MessageBox.Show("Ocurrió un error al obtener la configuración del sistema. Por favor verifique que se encuentre cargada.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            PoblarComboBox(cmbTipoAumentoPrecioPublico, EnumDescription.GetAll<TipoValor>(), "Descripcion", "Valor");
            PoblarComboBox(cmbTipoAumentoPrecioPublicoListaPrecio, EnumDescription.GetAll<TipoValor>(), "Descripcion", "Valor");

            var _configCore = (ConfiguracionCoreDTO)_configResult.Data;

            if (_configCore == null)
            {
                MessageBox.Show("Antes de continuar deberá cargar la configuración del Inventario", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                return;
            }
                        
            chkAumentoPrecioPublico.Enabled = _configCore.ActivarAumentoPrecioPorMarca;
            chkAumentoPrecioPublicoListaPrecio.Enabled = _configCore.ActivarAumentoPrecioPorMarcaListaPrecio;

            lblActivarIncrementoPrecio.Visible = !_configCore.ActivarAumentoPrecioPorMarca;
            lblActivarIncrementoPrecioListaPrecio.Visible = !_configCore.ActivarAumentoPrecioPorMarcaListaPrecio;

            if (entidadId != null && entidadId.Value != Guid.Empty)
            {
                var resultEntidad = _marcaServicio.GetById(entidadId.Value);

                if (resultEntidad.State)
                {
                    _entidad = (MarcaDTO)resultEntidad.Data;

                    txtDescripcion.Text = _entidad.Descripcion;
                    txtCodigo.Text = _entidad.Codigo;
                    chkEmpresa.Checked = _entidad.EmpresaId.HasValue;

                    chkAumentoPrecioPublico.Checked = _entidad.ActivarAumentoPrecioPublico;

                    cmbTipoAumentoPrecioPublico.SelectedValue = _entidad.ActivarAumentoPrecioPublico
                        ? _entidad.TipoValorPublico
                        : TipoValor.Valor;

                    nudAumentoPrecioPublico.Value = _entidad.ActivarAumentoPrecioPublico
                        ? _entidad.AumentoPrecioPublico.Value
                        : 0;

                    chkAumentoPrecioPublicoListaPrecio.Checked = _entidad.ActivarAumentoPrecioPublicoListaPrecio;

                    cmbTipoAumentoPrecioPublicoListaPrecio.SelectedValue = _entidad.ActivarAumentoPrecioPublicoListaPrecio
                        ? _entidad.TipoValorPublicoListaPrecio
                        : TipoValor.Valor;

                    nudAumentoPrecioPublicoListaPrecio.Value = _entidad.ActivarAumentoPrecioPublicoListaPrecio
                        ? _entidad.AumentoPrecioPublicoListaPrecio.Value
                        : 0;
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

                if (chkAumentoPrecioPublico.Checked
                    && nudAumentoPrecioPublico.Value == 0)
                {
                    return new ResultDTO
                    {
                        State = false,
                        Message = "Por favor ingrese un incremento de precio."
                    };
                }

                if (chkAumentoPrecioPublicoListaPrecio.Checked
                    && nudAumentoPrecioPublicoListaPrecio.Value == 0)
                {
                    return new ResultDTO
                    {
                        State = false,
                        Message = "Por favor ingrese un incremento de precio por Impuesto."
                    };
                }

                var registro = AsignarDatos();

                var result = _marcaServicio.Add(registro, Properties.Settings.Default.UserLogin);

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
                var actualizarPrecioPublico = false;
                var actualizarPrecioPublicoImpuesto = false;
                var actualizarPrecio = false;

                if (!VerificarDatosObligatorios())
                {
                    return new ResultDTO
                    {
                        State = false,
                        Message = "Por favor ingrese los campos Obligatorios."
                    };
                }

                if (chkAumentoPrecioPublico.Checked
                    && nudAumentoPrecioPublico.Value == 0)
                {
                    return new ResultDTO
                    {
                        State = false,
                        Message = "Por favor ingrese un incremento de precio."
                    };
                }

                if (chkAumentoPrecioPublicoListaPrecio.Checked
                    && nudAumentoPrecioPublicoListaPrecio.Value == 0)
                {
                    return new ResultDTO
                    {
                        State = false,
                        Message = "Por favor ingrese un incremento de precio por Impuesto."
                    };
                }

                var registro = AsignarDatos();

                if (chkAumentoPrecioPublico.Checked != _entidad.ActivarAumentoPrecioPublico
                    || nudAumentoPrecioPublico.Value != _entidad.AumentoPrecioPublico
                    || (TipoValor)cmbTipoAumentoPrecioPublico.SelectedValue != _entidad.TipoValorPublico)
                {
                    actualizarPrecioPublico = true;
                }

                if (chkAumentoPrecioPublicoListaPrecio.Checked != _entidad.ActivarAumentoPrecioPublicoListaPrecio
                    || nudAumentoPrecioPublicoListaPrecio.Value != _entidad.AumentoPrecioPublicoListaPrecio
                    || (TipoValor)cmbTipoAumentoPrecioPublicoListaPrecio.SelectedValue != _entidad.TipoValorPublicoListaPrecio)
                {
                    actualizarPrecioPublicoImpuesto = true;
                }

                if (actualizarPrecioPublico || actualizarPrecioPublicoImpuesto)
                {
                    var mensaje = "Algunos valores de la actualizacion de Precio cambiaron." + Environment.NewLine
                        + "¿Desea actualizar los PRECIOS de los Articulos?";

                    if (MessageBox.Show(mensaje, "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                        == DialogResult.OK)
                    {
                        actualizarPrecio = true;
                    }
                }

                var result = _marcaServicio.Update(registro, actualizarPrecio, Properties.Settings.Default.UserLogin);

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

        private MarcaPersistenciaDTO AsignarDatos()
        {
            var _entidad = new MarcaPersistenciaDTO
            {
                Id = EntidadId ?? Guid.Empty,
                Descripcion = txtDescripcion.Text,
                Codigo = txtCodigo.Text,
                EmpresaId = chkEmpresa.Checked ? Properties.Settings.Default.EmpresaId : null,

                ActivarAumentoPrecioPublico = chkAumentoPrecioPublico.Checked,
                AumentoPrecioPublico = chkAumentoPrecioPublico.Checked ? nudAumentoPrecioPublico.Value : null,
                TipoValorPublico = chkAumentoPrecioPublico.Checked ? (TipoValor)cmbTipoAumentoPrecioPublico.SelectedValue : null,

                ActivarAumentoPrecioPublicoListaPrecio = chkAumentoPrecioPublicoListaPrecio.Checked,
                AumentoPrecioPublicoListaPrecio = chkAumentoPrecioPublicoListaPrecio.Checked ? nudAumentoPrecioPublicoListaPrecio.Value : null,
                TipoValorPublicoListaPrecio = chkAumentoPrecioPublicoListaPrecio.Checked ? (TipoValor)cmbTipoAumentoPrecioPublicoListaPrecio.SelectedValue : null,
            };

            this.Entidad = _entidad;

            return _entidad;
        }


        public override void OperacionAdicionalFinalizarInsert()
        {
            chkEmpresa.Checked = false;

            nudAumentoPrecioPublico.Value = 0;
            nudAumentoPrecioPublico.Enabled = false;
            cmbTipoAumentoPrecioPublico.Enabled = false;
            chkAumentoPrecioPublico.Checked = false;

            nudAumentoPrecioPublicoListaPrecio.Value = 0;
            nudAumentoPrecioPublicoListaPrecio.Enabled = false;
            cmbTipoAumentoPrecioPublicoListaPrecio.Enabled = false;
            chkAumentoPrecioPublicoListaPrecio.Checked = false;

            txtDescripcion.Focus();
        }

        private void ChkAumentoPrecioPublico_CheckedChanged(object sender, EventArgs e)
        {
            nudAumentoPrecioPublico.Enabled = chkAumentoPrecioPublico.Checked;
            cmbTipoAumentoPrecioPublico.Enabled = chkAumentoPrecioPublico.Checked;

            if (base.TipoOperacion == TipoOperacion.Modificar)
            {
                var _entidad = (MarcaDTO)base.Entidad;

                if (_entidad != null)
                {
                    nudAumentoPrecioPublico.Value = chkAumentoPrecioPublico.Checked
                        ? _entidad.AumentoPrecioPublico ?? 0
                        : 0;
                }
            }
            else
            {
                nudAumentoPrecioPublico.Value = 0;
            }
        }

        private void ChkAumentoPrecioPublicoImpuesto_CheckedChanged(object sender, EventArgs e)
        {
            nudAumentoPrecioPublicoListaPrecio.Enabled = chkAumentoPrecioPublicoListaPrecio.Checked;
            cmbTipoAumentoPrecioPublicoListaPrecio.Enabled = chkAumentoPrecioPublicoListaPrecio.Checked;

            if (base.TipoOperacion == TipoOperacion.Modificar)
            {
                var _entidad = (MarcaDTO)base.Entidad;

                if (_entidad != null)
                {
                    nudAumentoPrecioPublicoListaPrecio.Value = chkAumentoPrecioPublicoListaPrecio.Checked
                        ? _entidad.AumentoPrecioPublicoListaPrecio ?? 0
                        : 0;
                }
            }
            else
            {
                nudAumentoPrecioPublicoListaPrecio.Value = 0;
            }
        }
    }
}
