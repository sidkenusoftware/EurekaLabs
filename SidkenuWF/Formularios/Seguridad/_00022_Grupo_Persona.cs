using Serilog;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Seguridad.Grupo;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Seguridad.GrupoPersona;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Seguridad.Persona;
using Sidkenu.LogicaNegocio.Servicios.Interface.Seguridad;
using System.Data;

namespace SidkenuWF.Formularios.Seguridad
{
    public partial class _00022_Grupo_Persona : Base.FormularioAsignarQuitar
    {
        private readonly IGrupoPersonaServicio _grupoPersonaServicio;
        private readonly IGrupoServicio _grupoServicio;

        public _00022_Grupo_Persona(ISeguridadServicio seguridadServicio,
                                    IConfiguracionServicio configuracionServicio,
                                    ILogger logger,
                                    IGrupoPersonaServicio grupoPersonaServicio,
                                    IGrupoServicio grupoServicio,
                                    Guid entidadSeleccionadaId)
                                    : base(seguridadServicio, configuracionServicio, logger, entidadSeleccionadaId)
        {
            InitializeComponent();

            this.TituloFormulario = Base.Constantes.FormularioConstantes.Titulo;

            this.TituloAsignado = "Personas Asignadas";
            this.TituloNoAsignado = "Personas No Asignadas";
            this.Titulo = "Asignar / Quitar Personas";
            this.LogoTitulo = FontAwesome.Sharp.IconChar.PeopleGroup;

            this._grupoPersonaServicio = grupoPersonaServicio;
            this._grupoServicio = grupoServicio;

            this.TituloEntidadSeleccionada = $"Grupo: {ObtenerLaEntidadSeleccionada(entidadSeleccionadaId)}";
        }

        private string ObtenerLaEntidadSeleccionada(Guid entidadSeleccionadaId)
        {
            var result = _grupoServicio.GetById(entidadSeleccionadaId);

            if (result.State)
            {
                return ((GrupoDTO)result.Data).Descripcion;
            }

            return string.Empty;
        }

        public override void ActualizarDatosAsignado(DataGridView dgvGrilla, string cadenaBuscar)
        {
            var result = _grupoPersonaServicio.GetByPersonasAsignadas(new GrupoPersonaFilterDTO
            {
                GrupoId = base.EntidadId,
                CadenaBuscar = cadenaBuscar
            });

            if (result != null && result.State)
            {
                dgvGrilla.DataSource = result.Data;

                base.ActualizarDatosAsignado(dgvGrilla, cadenaBuscar);
            }
        }

        public override void ActualizarDatosNoAsignado(DataGridView dgvGrilla, string cadenaBuscar)
        {
            var result = _grupoPersonaServicio.GetByPersonasNoAsignadas(new GrupoPersonaFilterDTO
            {
                GrupoId = base.EntidadId,
                CadenaBuscar = cadenaBuscar
            });

            if (result != null && result.State)
            {
                dgvGrilla.DataSource = result.Data;

                base.ActualizarDatosNoAsignado(dgvGrilla, cadenaBuscar);
            }
        }

        public override void FormatearGrilla(DataGridView dgv)
        {
            try
            {
                base.FormatearGrilla(dgv);

                dgv.Columns["EstaSeleccionado"].Visible = true;
                dgv.Columns["EstaSeleccionado"].Width = 70;
                dgv.Columns["EstaSeleccionado"].HeaderText = "Item";
                dgv.Columns["EstaSeleccionado"].ReadOnly = false;
                dgv.Columns["EstaSeleccionado"].DisplayIndex = 0;

                dgv.Columns["NombreCompleto"].Visible = true;
                dgv.Columns["NombreCompleto"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgv.Columns["NombreCompleto"].HeaderText = "Apellido y Nombre";
                dgv.Columns["NombreCompleto"].ReadOnly = true;
                dgv.Columns["NombreCompleto"].DisplayIndex = 1;
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

        public override void EjecutarComandoAgregar(DataGridView dgv)
        {
            _grupoPersonaServicio.AddPersonasGrupo(new GrupoPersonasPersistenciaDTO
            {
                GrupoId = base.EntidadId,
                PersonaIds = ((List<PersonaDTO>)dgv.DataSource).Where(x => x.EstaSeleccionado).Select(x => x.Id).ToList()
            }, Properties.Settings.Default.UserLogin);

            base.EjecutarComandoAgregar(dgv);
        }

        public override void EjecutarComandoQuitar(DataGridView dgv)
        {
            _grupoPersonaServicio.DeletePersonasGrupo(new GrupoPersonasPersistenciaDTO
            {
                GrupoId = base.EntidadId,
                PersonaIds = ((List<PersonaDTO>)dgv.DataSource).Where(x => x.EstaSeleccionado).Select(x => x.Id).ToList()
            }, Properties.Settings.Default.UserLogin);

            base.EjecutarComandoQuitar(dgv);
        }
    }
}