using FontAwesome.Sharp;
using Serilog;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Seguridad.PuestoTrabajo;
using Sidkenu.LogicaNegocio.Servicios.Interface.Seguridad;
using SidkenuWF.Formularios.Base;
using SidkenuWF.Formularios.Base.Constantes;

namespace SidkenuWF.Formularios.Seguridad
{
    public partial class _00024_PuestoTrabajo : FormularioConsulta
    {
        private readonly IPuestoTrabajoServicio _puestoTrabajoServicio;

        public _00024_PuestoTrabajo(ISeguridadServicio seguridadServicio,
                                    IConfiguracionServicio configuracionServicio,
                                    ILogger logger,
                                    IPuestoTrabajoServicio puestoTrabajoServicio)
                                    : base(seguridadServicio, configuracionServicio, logger)
        {
            InitializeComponent();

            base.BotoneraLateralVisible = (false, true); // (Panel Botonera, Panel Abrir-Cerrar)
            base.MostrarBotonBaja = false;

            base.TituloFormulario = Base.Constantes.FormularioConstantes.Titulo;
            base.Titulo = "Puesto de Trabajo";
            base.Logo = IconChar.Computer;

            _puestoTrabajoServicio = puestoTrabajoServicio;
        }

        public override bool EjecutarComandoNuevo(object sender, EventArgs e)
        {
            var formularioAbm = new _00025_PuestoTrabajo_Abm(base._seguridadServicio,
                                                             base._configuracionServicio,
                                                             base._logger,
                                                             Program.Container.GetInstance<IPuestoTrabajoServicio>(), 
                                                             TipoOperacion.Nuevo);

            FormularioSeguridad.VerificarAcceso(formularioAbm, base._seguridadServicio, base._logger, base._configuracionDTO);

            return formularioAbm.RealizoAlgunaOperacion;
        }

        public override bool EjecutarComandoEditar(object sender, EventArgs e)
        {
            var formularioAbm = new _00025_PuestoTrabajo_Abm(base._seguridadServicio,
                                                             base._configuracionServicio,
                                                             base._logger,
                                                             Program.Container.GetInstance<IPuestoTrabajoServicio>(),
                                                             TipoOperacion.Modificar, EntidadId);

            FormularioSeguridad.VerificarAcceso(formularioAbm, base._seguridadServicio, base._logger, base._configuracionDTO);

            return formularioAbm.RealizoAlgunaOperacion;
        }

        public override bool EjecutarComandoEliminar(object sender, EventArgs e)
        {
            try
            {
                _puestoTrabajoServicio.Delete(new PuestoTrabajoDeleteDTO { Id = base.EntidadId.Value }, Properties.Settings.Default.UserLogin);

                return true;
            }
            catch
            {
                return false;
            }
        }

        public override void Buscar(string cadenaBuscar, bool verEliminados = false)
        {
            var result = _puestoTrabajoServicio.GetByFilter(new PuestoTrabajoFilterDTO
            {
                EmpresaId = Properties.Settings.Default.EmpresaId,
                CadenaBuscar = cadenaBuscar,
                VerEliminados = verEliminados
            });

            if (result.State)
            {
                this.dgvGrilla.DataSource = result.Data;

                base.Buscar(cadenaBuscar, verEliminados);
            }
            else
            {
                if (base._configuracionDTO != null && base._configuracionDTO.LogError)
                {
                    _logger.Error($"{base.Titulo}: error al obtener los datos. User: {Properties.Settings.Default.PersonaLogin}");
                }

                MessageBox.Show("Ocurrió un error al obtener los datos");
            }
        }

        public override void FormatearDatos(DataGridView dgvGrilla)
        {
            try
            {
                base.FormatearDatos(dgvGrilla);

                dgvGrilla.Columns["Descripcion"].Visible = true;
                dgvGrilla.Columns["Descripcion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvGrilla.Columns["Descripcion"].HeaderText = "Puesto de Trabajo";
                dgvGrilla.Columns["Descripcion"].DisplayIndex = 0;
                dgvGrilla.Columns["Descripcion"].ReadOnly = true;
            }
            catch (Exception ex)
            {
                if (base._configuracionDTO != null && base._configuracionDTO.LogError)
                {
                    _logger.Error(ex, $"Error en el formateo de las columnas en {base.Titulo}.");
                }

                MessageBox.Show("Los nombres de las columnas no coinciden");
            }
        }
    }
}
