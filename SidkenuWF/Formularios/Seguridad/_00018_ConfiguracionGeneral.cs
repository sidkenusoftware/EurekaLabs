using Serilog;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Seguridad.Configuracion;
using Sidkenu.LogicaNegocio.Servicios.Interface.Seguridad;
using SidkenuWF.Formularios.Base.Constantes;
using SidkenuWF.Formularios.Base.Controles;

namespace SidkenuWF.Formularios.Seguridad
{
    public partial class _00018_ConfiguracionGeneral : Form
    {
        protected readonly ISeguridadServicio _seguridadServicio;
        protected readonly IConfiguracionServicio _configuracionServicio;
        protected readonly ILogger _logger;

        protected ConfiguracionDTO _configuracionDTO;

        public _00018_ConfiguracionGeneral(ISeguridadServicio seguridadServicio,
                                           IConfiguracionServicio configuracionServicio,
                                           ILogger logger)
        {
            InitializeComponent();

            this.Text = Base.Constantes.FormularioConstantes.Titulo;
            this.lblTitulo.Text = "Configuración General";
            this.imgLogo.IconChar = FontAwesome.Sharp.IconChar.Gears;

            this._seguridadServicio = seguridadServicio;
            this._configuracionServicio = configuracionServicio;
            this._logger = logger;

            var result = _configuracionServicio.Get();

            if (result.State)
            {
                _configuracionDTO = (ConfiguracionDTO)result.Data;
            }
            else
            {
                _logger.Error($"Ocurrió un error al obtener la configuracion del sistema. {result.Message}");
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _99900_ConfiguracionGeneral_Load(object sender, EventArgs e)
        {
            CargarAccessosParametricas();
        }

        private void CargarAccessosParametricas()
        {
            var ctrolTipoResponsabilidad = new SidkenuParametrica
            {
                Titulo = "Tipo de Responsabilidad",
            };

            ctrolTipoResponsabilidad.btnIngresar.Click += BtnIngresarTipoResponsabilidad_Click;

            flpContenedorParametricas.Controls.Add(ctrolTipoResponsabilidad);

            // ------------------------------------------------------------------------ //

            var ctrolIngresoBruto = new SidkenuParametrica
            {
                Titulo = "Ingreso Bruto",
            };

            ctrolIngresoBruto.btnIngresar.Click += BtnIngresarIngresoBruto_Click;

            flpContenedorParametricas.Controls.Add(ctrolIngresoBruto);

            // ------------------------------------------------------------------------ //

            var ctrolProvincia = new SidkenuParametrica
            {
                Titulo = "Provincia",
            };

            ctrolProvincia.btnIngresar.Click += BtnIngresarProvincia_Click;

            flpContenedorParametricas.Controls.Add(ctrolProvincia);

            // ------------------------------------------------------------------------ //

            var ctrolLocalidad = new SidkenuParametrica
            {
                Titulo = "Localidad",
            };

            ctrolLocalidad.btnIngresar.Click += BtnIngresarLocalidad_Click;

            flpContenedorParametricas.Controls.Add(ctrolLocalidad);

            // ------------------------------------------------------------------------ //

            var ctrolGrupo = new SidkenuParametrica
            {
                Titulo = "Grupo",
            };

            ctrolGrupo.btnIngresar.Click += BtnGrupo_Click;

            flpContenedorParametricas.Controls.Add(ctrolGrupo);

            // ------------------------------------------------------------------------ //

            var ctrolFormulario = new SidkenuParametrica
            {
                Titulo = "Formulario/Pantalla",
            };

            ctrolFormulario.btnIngresar.Click += BtnFormulario_Click;

            flpContenedorParametricas.Controls.Add(ctrolFormulario);

            // ------------------------------------------------------------------------ //

            var ctrolAjustes = new SidkenuParametrica
            {
                Titulo = "Ajuste / Configuración",
            };

            ctrolAjustes.btnIngresar.Click += BtnAjustes_Click;

            flpContenedorParametricas.Controls.Add(ctrolAjustes);

            // ------------------------------------------------------------------------ //

            var ctrolPuestoTrabajo = new SidkenuParametrica
            {
                Titulo = "Puestos de Trabajos",
            };

            ctrolPuestoTrabajo.btnIngresar.Click += BtnPuestoTrabajo_Click;

            flpContenedorParametricas.Controls.Add(ctrolPuestoTrabajo);

            // ------------------------------------------------------------------------ //
        }

        private void BtnPuestoTrabajo_Click(object? sender, EventArgs e)
        {
            var formulario = new _00024_PuestoTrabajo(_seguridadServicio,
                                                      Program.Container.GetInstance<IConfiguracionServicio>(),
                                                      _logger,
                                                      Program.Container.GetInstance<IPuestoTrabajoServicio>());

            FormularioSeguridad.VerificarAcceso(formulario, _seguridadServicio, _logger, _configuracionDTO);
        }

        private void BtnAjustes_Click(object? sender, EventArgs e)
        {
            var formulario = new _00023_AjusteSeguridad(Program.Container.GetInstance<IConfiguracionServicio>(),
                Program.Container.GetInstance<IModuloServicio>(),
                _seguridadServicio,
                _logger);

            FormularioSeguridad.VerificarAcceso(formulario, _seguridadServicio, _logger, _configuracionDTO);
        }

        private void BtnFormulario_Click(object? sender, EventArgs e)
        {
            var formulario = new _00017_Formulario(
                Program.Container.GetInstance<ISeguridadServicio>(),
                Program.Container.GetInstance<IFormularioServicio>());

            FormularioSeguridad.VerificarAcceso(formulario, _seguridadServicio, _logger, _configuracionDTO);
        }

        private void BtnIngresarLocalidad_Click(object? sender, EventArgs e)
        {
            var formulario = new _00009_Localidad(Program.Container.GetInstance<ISeguridadServicio>(),
                                                  Program.Container.GetInstance<IConfiguracionServicio>(),
                                                  Program.Container.GetInstance<ILogger>(),
                                                  Program.Container.GetInstance<ILocalidadServicio>());

            FormularioSeguridad.VerificarAcceso(formulario, _seguridadServicio, _logger, _configuracionDTO);
        }

        private void BtnIngresarProvincia_Click(object? sender, EventArgs e)
        {
            var formulario = new _00007_Provincia(Program.Container.GetInstance<ISeguridadServicio>(),
                                                  Program.Container.GetInstance<IConfiguracionServicio>(),
                                                  Program.Container.GetInstance<ILogger>(),
                                                  Program.Container.GetInstance<IProvinciaServicio>());

            FormularioSeguridad.VerificarAcceso(formulario, _seguridadServicio, _logger, _configuracionDTO);
        }

        private void BtnIngresarIngresoBruto_Click(object? sender, EventArgs e)
        {
            var formulario = new _00013_IngresoBruto(Program.Container.GetInstance<ISeguridadServicio>(),
                                                     Program.Container.GetInstance<IConfiguracionServicio>(),
                                                     Program.Container.GetInstance<ILogger>(),
                                                     Program.Container.GetInstance<IIngresoBrutoServicio>());

            FormularioSeguridad.VerificarAcceso(formulario, _seguridadServicio, _logger, _configuracionDTO);
        }

        private void BtnIngresarTipoResponsabilidad_Click(object? sender, EventArgs e)
        {
            var formulario = new _00011_TipoResponsabilidad(Program.Container.GetInstance<ISeguridadServicio>(),
                                                     Program.Container.GetInstance<IConfiguracionServicio>(),
                                                     Program.Container.GetInstance<ILogger>(),
                                                     Program.Container.GetInstance<ITipoResponsabilidadServicio>());

            FormularioSeguridad.VerificarAcceso(formulario, _seguridadServicio, _logger, _configuracionDTO);
        }

        private void BtnGrupo_Click(object? sender, EventArgs e)
        {
            var formulario = new _00015_Grupo(Program.Container.GetInstance<ISeguridadServicio>(),
                                              Program.Container.GetInstance<IConfiguracionServicio>(),
                                              Program.Container.GetInstance<ILogger>(),
                                              Program.Container.GetInstance<IGrupoServicio>());

            FormularioSeguridad.VerificarAcceso(formulario, _seguridadServicio, _logger, _configuracionDTO);
        }
    }
}
