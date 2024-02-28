using FontAwesome.Sharp;
using Serilog;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Seguridad.Grupo;
using Sidkenu.LogicaNegocio.Servicios.Interface.Seguridad;
using SidkenuWF.Formularios.Base;
using SidkenuWF.Formularios.Base.Constantes;

namespace SidkenuWF.Formularios.Seguridad
{
    public partial class _00015_Grupo : FormularioConsulta
    {
        private readonly IGrupoServicio _grupoServicio;

        public _00015_Grupo(ISeguridadServicio seguridadServicio,
                            IConfiguracionServicio configuracionServicio,
                            ILogger logger,
                            IGrupoServicio grupoServicio)
                            : base(seguridadServicio, configuracionServicio, logger)
        {
            InitializeComponent();

            base.BotoneraLateralVisible = (false, true); // (Panel Botonera, Panel Abrir-Cerrar)
            base.TituloFormulario = Base.Constantes.FormularioConstantes.Titulo;
            base.Titulo = "Grupo";
            base.Logo = IconChar.BuildingFlag;

            _grupoServicio = grupoServicio;
        }

        public override bool EjecutarComandoNuevo(object sender, EventArgs e)
        {
            var formularioAbm = new _00016_Grupo_Abm(base._seguridadServicio,
                                                     base._configuracionServicio,
                                                     base._logger,
                                                     Program.Container.GetInstance<IGrupoServicio>(),
                                                     TipoOperacion.Nuevo);

            FormularioSeguridad.VerificarAcceso(formularioAbm, base._seguridadServicio, base._logger, base._configuracionDTO);

            return formularioAbm.RealizoAlgunaOperacion;
        }

        public override bool EjecutarComandoEditar(object sender, EventArgs e)
        {
            var formularioAbm = new _00016_Grupo_Abm(base._seguridadServicio,
                                                     base._configuracionServicio,
                                                     base._logger,
                                                     Program.Container.GetInstance<IGrupoServicio>(),
                                                     TipoOperacion.Modificar, EntidadId);

            FormularioSeguridad.VerificarAcceso(formularioAbm, base._seguridadServicio, base._logger, base._configuracionDTO);

            return formularioAbm.RealizoAlgunaOperacion;
        }

        public override bool EjecutarComandoEliminar(object sender, EventArgs e)
        {
            try
            {
                _grupoServicio.Delete(new GrupoDeleteDTO { Id = base.EntidadId.Value }, Properties.Settings.Default.UserLogin);

                return true;
            }
            catch
            {
                return false;
            }
        }

        public override void Buscar(string cadenaBuscar, bool verEliminados = false)
        {
            var result = _grupoServicio.GetByFilter(new GrupoFilterDTO
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
                dgvGrilla.Columns["Descripcion"].HeaderText = "Grupo";
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

        private void BtnAgregarQuitarEmpleados_Click(object sender, EventArgs e)
        {
            if (base.dgvGrilla.RowCount > 0)
            {
                var formulario = new _00022_Grupo_Persona(base._seguridadServicio,
                                                          base._configuracionServicio,
                                                          base._logger,
                                                          Program.Container.GetInstance<IGrupoPersonaServicio>(),
                                                          Program.Container.GetInstance<IGrupoServicio>(),
                                                          base.EntidadId.Value);

                FormularioSeguridad.VerificarAcceso(formulario, base._seguridadServicio, base._logger, base._configuracionDTO);
            }
            else
            {
                MessageBox.Show("No hay Grupos cargadas.", "Atención",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnAgregarQuitarFormularios_Click(object sender, EventArgs e)
        {
            if (base.dgvGrilla.RowCount > 0)
            {
                var formulario = new _00021_Grupo_Formulario(base._seguridadServicio,
                                                             base._configuracionServicio,
                                                             base._logger,
                                                             Program.Container.GetInstance<IGrupoFormularioServicio>(),
                                                             Program.Container.GetInstance<IGrupoServicio>(),
                                                             base.EntidadId.Value);

                FormularioSeguridad.VerificarAcceso(formulario, base._seguridadServicio, base._logger, base._configuracionDTO);
            }
            else
            {
                MessageBox.Show("No hay Grupos cargadas.", "Atención",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
