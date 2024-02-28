using SidkenuWF.Formularios.Base.Constantes;
using SidkenuWF.Formularios.Base;
using SidkenuWF.Helpers;
using Serilog;
using Sidkenu.LogicaNegocio.Servicios.Interface.Core;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.Familia;
using Sidkenu.LogicaNegocio.Servicios.Interface.Seguridad;
using Sidkenu.AccesoDatos.Constantes;
using Sidkenu.AccesoDatos.Constantes.Enum;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.ConfiguracionCore;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Base;

namespace SidkenuWF.Formularios.Core
{
    public partial class _00125_Familia_Abm : FormularioAbm
    {
        private readonly IFamiliaServicio _familiaServicio;
        private readonly IConfiguracionCoreServicio _configuracionCoreServicio;

        private FamiliaDTO _entidad;

        public _00125_Familia_Abm(ISeguridadServicio seguridadServicio,
                                    IConfiguracionServicio configuracionServicio,
                                    IConfiguracionCoreServicio configuracionCoreServicio,
                                    ILogger logger,
                                    IFamiliaServicio familiaServicio,
                                    TipoOperacion tipoOperacion,
                                    Guid? entidadId = null)
                                    : base(seguridadServicio, configuracionServicio, logger, tipoOperacion, entidadId)
        {
            InitializeComponent();

            base.TituloFormulario = FormularioConstantes.Titulo;
            base.Titulo = $"Familia - Rubro / {Enum.GetName(typeof(TipoOperacion), tipoOperacion)}";

            _familiaServicio = familiaServicio;
            _configuracionCoreServicio = configuracionCoreServicio;

            AgregarControlesObligatorios(txtCodigo, "Codigo");
            AgregarControlesObligatorios(txtDescripcion, "Familia");

            txtCodigo.KeyPress += Validacion.NoInyeccion;
            txtDescripcion.KeyPress += Validacion.NoInyeccion;
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

            PoblarComboBox(cmbTipoAumentoPrecio, EnumDescription.GetAll<TipoValor>(), "Descripcion", "Valor");
            PoblarComboBox(cmbTipoAumentoPrecioPublico, EnumDescription.GetAll<TipoValor>(), "Descripcion", "Valor");
            PoblarComboBox(cmbTipoAumentoPrecioPublicoListaPrecio, EnumDescription.GetAll<TipoValor>(), "Descripcion", "Valor");

            var _configCore = (ConfiguracionCoreDTO)_configResult.Data;

            if (_configCore == null)
            {
                MessageBox.Show("Antes de continuar deberá cargar la configuracion del Inventario", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                return;
            }

            chkAumentoPrecioPublico.Enabled = _configCore.ActivarAumentoPrecioPorFamilia;
            chkAumentoPrecioPublicoListaPrecio.Enabled = _configCore.ActivarAumentoPrecioPorFamiliaListaPrecio;

            lblActivarIncrementoPrecio.Visible = !_configCore.ActivarAumentoPrecioPorFamilia;
            lblActivarIncrementoPrecioListaPrecio.Visible = !_configCore.ActivarAumentoPrecioPorFamiliaListaPrecio;

            if (entidadId != null && entidadId.Value != Guid.Empty)
            {
                var resultEntidad = _familiaServicio.GetById(entidadId.Value);

                if (resultEntidad.State)
                {
                    _entidad = (FamiliaDTO)resultEntidad.Data;

                    txtDescripcion.Text = _entidad.Descripcion;
                    txtCodigo.Text = _entidad.Codigo;

                    chkEmpresa.Checked = _entidad.EmpresaId.HasValue;

                    chkRestriccionHora.Checked = _entidad.ActivarRestriccionHoraVenta;
                    dtpRestriccionHoraVentaDesde.Value = _entidad.ActivarRestriccionHoraVenta ?
                        DateTime.Parse($"{DateTime.Now.ToShortDateString()}:{_entidad.RestriccionHoraVentaDesde}")
                        : DateTime.Now;
                    dtpRestriccionHoraVentaHasta.Value = _entidad.ActivarRestriccionHoraVenta ?
                        DateTime.Parse($"{DateTime.Now.ToShortDateString()}:{_entidad.RestriccionHoraVentaHasta}")
                        : DateTime.Now;

                    chkAumentoPrecioRangoHora.Checked = _entidad.ActivarAumentoPrecioHoraVenta;
                    nudAumentoPrecio.Value = _entidad.ActivarAumentoPrecioHoraVenta ? _entidad.AumentoPrecioHoraVenta.Value : 0;
                    dtpRestriccionHoraVentaDesde.Value = _entidad.ActivarAumentoPrecioHoraVenta ?
                        DateTime.Parse($"{DateTime.Now.ToShortDateString()}:{_entidad.AumentoPrecioHoraVentaDesde}")
                        : DateTime.Now;
                    dtpRestriccionHoraVentaHasta.Value = _entidad.ActivarAumentoPrecioHoraVenta ?
                        DateTime.Parse($"{DateTime.Now.ToShortDateString()}:{_entidad.AumentoPrecioHoraVentaHasta}")
                        : DateTime.Now;

                    cmbTipoAumentoPrecio.SelectedValue = _entidad.ActivarAumentoPrecioHoraVenta ? _entidad.TipoValor : TipoValor.Valor;

                    chkAumentoPrecioPublico.Checked = _entidad.ActivarAumentoPrecioPublico;
                    cmbTipoAumentoPrecioPublico.SelectedValue = _entidad.ActivarAumentoPrecioPublico ? _entidad.TipoValorPublico : TipoValor.Valor;
                    nudAumentoPrecioPublico.Value = _entidad.ActivarAumentoPrecioPublico ? _entidad.AumentoPrecioPublico.Value : 0;

                    chkAumentoPrecioPublicoListaPrecio.Checked = _entidad.ActivarAumentoPrecioPublicoListaPrecio;
                    cmbTipoAumentoPrecioPublicoListaPrecio.SelectedValue = _entidad.ActivarAumentoPrecioPublicoListaPrecio ? _entidad.TipoValorPublicoListaPrecio : TipoValor.Valor;
                    nudAumentoPrecioPublicoListaPrecio.Value = _entidad.ActivarAumentoPrecioPublicoListaPrecio ? _entidad.AumentoPrecioPublicoListaPrecio.Value : 0;
                }
            }
            else
            {
                chkAumentoPrecioRangoHora.Checked = false;
                chkRestriccionHora.Checked = false;

                nudAumentoPrecio.Enabled = false;
                dtpAumentoPrecioDesde.Enabled = false;
                dtpAumentoPrecioHasta.Enabled = false;

                dtpRestriccionHoraVentaDesde.Enabled = false;
                dtpRestriccionHoraVentaHasta.Enabled = false;
                cmbTipoAumentoPrecio.Enabled = false;
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

                var result = _familiaServicio.Add(registro, Properties.Settings.Default.UserLogin);

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

                var result = _familiaServicio.Update(registro, actualizarPrecio, Properties.Settings.Default.UserLogin);

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

        private FamiliaPersistenciaDTO AsignarDatos()
        {
            var _entidad = new FamiliaPersistenciaDTO
            {
                Id = EntidadId ?? Guid.Empty,
                Descripcion = txtDescripcion.Text,
                Codigo = txtCodigo.Text,
                EmpresaId = chkEmpresa.Checked ? Properties.Settings.Default.EmpresaId : null,

                ActivarAumentoPrecioHoraVenta = chkAumentoPrecioRangoHora.Checked,
                AumentoPrecioHoraVenta = chkAumentoPrecioRangoHora.Checked ? nudAumentoPrecio.Value : null,
                AumentoPrecioHoraVentaDesde = chkAumentoPrecioRangoHora.Checked ? dtpAumentoPrecioDesde.Value.ToShortTimeString() : null,
                AumentoPrecioHoraVentaHasta = chkAumentoPrecioRangoHora.Checked ? dtpAumentoPrecioHasta.Value.ToShortTimeString() : null,

                ActivarRestriccionHoraVenta = chkRestriccionHora.Checked,
                RestriccionHoraVentaDesde = chkRestriccionHora.Checked ? dtpRestriccionHoraVentaDesde.Value.ToShortTimeString() : null,
                RestriccionHoraVentaHasta = chkRestriccionHora.Checked ? dtpRestriccionHoraVentaHasta.Value.ToShortTimeString() : null,
                TipoValor = chkRestriccionHora.Checked ? (TipoValor)cmbTipoAumentoPrecio.SelectedValue : null,

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
            txtDescripcion.Focus();
        }

        private void ChkRestriccionHora_CheckedChanged(object sender, EventArgs e)
        {
            dtpRestriccionHoraVentaDesde.Enabled = chkRestriccionHora.Checked;
            dtpRestriccionHoraVentaHasta.Enabled = chkRestriccionHora.Checked;
        }

        private void ChkAumentoPrecioPublico_CheckedChanged(object sender, EventArgs e)
        {
            nudAumentoPrecioPublico.Enabled = chkAumentoPrecioPublico.Checked;
            cmbTipoAumentoPrecioPublico.Enabled = chkAumentoPrecioPublico.Checked;

            if (base.TipoOperacion == TipoOperacion.Modificar)
            {
                var _entidad = (FamiliaDTO)base.Entidad;

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
                var _entidad = (FamiliaDTO)base.Entidad;

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
