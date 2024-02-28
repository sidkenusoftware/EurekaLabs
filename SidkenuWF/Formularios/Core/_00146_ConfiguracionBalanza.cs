using FontAwesome.Sharp;
using Serilog;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.ConfiguracionBalanza;
using Sidkenu.LogicaNegocio.Servicios.Interface.Core;
using Sidkenu.LogicaNegocio.Servicios.Interface.Seguridad;
using SidkenuWF.Formularios.Base;
using SidkenuWF.Formularios.Base.Constantes;

namespace SidkenuWF.Formularios.Core
{
    public partial class _00146_ConfiguracionBalanza : FormularioConfiguracion
    {
        private readonly IConfiguracionBalanzaServicio _configuracionBalanzaServicio;
        private Guid entidadId;

        public _00146_ConfiguracionBalanza(IConfiguracionBalanzaServicio configuracionBalanzaServicio,
                                           ISeguridadServicio seguridadServicio,
                                           IConfiguracionServicio configuracionServicio,
                                           ILogger logger)
                                           : base(seguridadServicio, configuracionServicio, logger)
        {
            InitializeComponent();

            base.TituloFormulario = FormularioConstantes.Titulo;
            base.Titulo = "Parametrización Balanza";
            base.Logo = IconChar.UserGroup;
            _configuracionBalanzaServicio = configuracionBalanzaServicio;
        }

        public override void CargarDatos(Guid? empresaId = null)
        {
            var resultConfig = _configuracionBalanzaServicio
                .Get(empresaId.Value);

            if (resultConfig != null && resultConfig.State)
            {
                var _entidad = (ConfiguracionBalanzaDTO)resultConfig.Data;

                if (_entidad != null)
                {
                    entidadId = _entidad.Id;

                    nudCodigoPeso.Value = _entidad.CodigoIdentificarPeso;
                    nudDecimalPeso.Value = _entidad.DecimalPeso;

                    nudCodigoImporte.Value = _entidad.CodigoIdentificarImporte;
                    nudDecimalImporte.Value = _entidad.DecimalesImporte;

                    chkConvierteUnidadPeso.Checked = _entidad.ConvierteUnidadPeso;
                    nudEquivalencia.Value = _entidad.Equivalencia;

                    nudLongitudTotal.Value = _entidad.LongitudTotal;

                    nudIdentTipoCodigoDesde.Value = _entidad.InicioIdentificarTipo;
                    nudIdentTipoCodigoHasta.Value = _entidad.CantidadIdentificarTipo;

                    nudIdentCodigoArticuloDesde.Value = _entidad.InicioIdentificarCodigoArcitulo;
                    nudIdentCodigoArticuloHasta.Value = _entidad.CantidadIdentificarCodigoArcitulo;

                    nudIdentImportePesoDesde.Value = _entidad.InicioIdentificarImportePrecio;
                    nudIdentImportePesoHasta.Value = _entidad.CantidadIdentificarImportePrecio;
                }
                else
                {
                    entidadId = Guid.Empty;

                    nudCodigoPeso.Value = 0;
                    nudDecimalPeso.Value = 0;

                    nudCodigoImporte.Value = 0;
                    nudDecimalImporte.Value = 0;

                    chkConvierteUnidadPeso.Checked = false;
                    nudEquivalencia.Value = 0;

                    nudLongitudTotal.Value = 0;

                    nudIdentTipoCodigoDesde.Value = 0;
                    nudIdentTipoCodigoHasta.Value = 0;

                    nudIdentCodigoArticuloDesde.Value = 0;
                    nudIdentCodigoArticuloHasta.Value = 0;

                    nudIdentImportePesoDesde.Value = 0;
                    nudIdentImportePesoHasta.Value = 0;
                }
            }
        }

        private void _00146_ConfiguracionBalanza_Load(object sender, EventArgs e)
        {
            CargarDatos(Properties.Settings.Default.EmpresaId);
        }

        public override void EjecutarComandoGuardar()
        {
            try
            {
                if (chkConvierteUnidadPeso.Checked && nudEquivalencia.Value == 0)
                {
                    MessageBox.Show("La equivalencia no puede ser Cero", "Atención");
                    return;
                }

                var entidad = new ConfiguracionBalanzaPersistenciaDTO
                {
                    EmpresaId = Properties.Settings.Default.EmpresaId,
                    Id = entidadId,
                    CodigoIdentificarPeso = (int)nudCodigoPeso.Value,
                    DecimalPeso = (int)nudDecimalPeso.Value,

                    CodigoIdentificarImporte = (int)nudCodigoImporte.Value,
                    DecimalesImporte = (int)nudDecimalImporte.Value,

                    ConvierteUnidadPeso = chkConvierteUnidadPeso.Checked,

                    Equivalencia = nudEquivalencia.Value,

                    LongitudTotal = (int)nudLongitudTotal.Value,

                    InicioIdentificarTipo = (int)nudIdentTipoCodigoDesde.Value,
                    CantidadIdentificarTipo = (int)nudIdentTipoCodigoHasta.Value,

                    InicioIdentificarCodigoArcitulo = (int)nudIdentCodigoArticuloDesde.Value,
                    CantidadIdentificarCodigoArcitulo = (int)nudIdentCodigoArticuloHasta.Value,

                    InicioIdentificarImportePrecio = (int)nudIdentImportePesoDesde.Value,
                    CantidadIdentificarImportePrecio = (int)nudIdentImportePesoHasta.Value
                };

                var result = _configuracionBalanzaServicio.AddOrUpdate(entidad, Properties.Settings.Default.UserLogin);

                if (result.State)
                {
                    MessageBox.Show(result.Message, "Atencion", MessageBoxButtons.OK);
                    Close();
                }
                else
                {
                    MessageBox.Show(result.Message, "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void ChkConvierteUnidadPeso_CheckedChanged(object sender, EventArgs e)
        {
            nudEquivalencia.Enabled = chkConvierteUnidadPeso.Checked;
        }
    }
}
