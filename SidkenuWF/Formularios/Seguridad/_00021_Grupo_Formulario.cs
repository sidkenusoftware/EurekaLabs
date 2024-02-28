using Serilog;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Seguridad.Formulario;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Seguridad.Grupo;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Seguridad.GrupoFormulario;
using Sidkenu.LogicaNegocio.Servicios.Interface.Seguridad;
using SidkenuWF.Formularios.Base;

namespace SidkenuWF.Formularios.Seguridad
{
    public partial class _00021_Grupo_Formulario : FormularioAsignarQuitar
    {
        private readonly IGrupoFormularioServicio _grupoFormularioServicio;
        private readonly IGrupoServicio _grupoServicio;

        public _00021_Grupo_Formulario(ISeguridadServicio seguridadServicio,
                                       IConfiguracionServicio configuracionServicio,
                                       ILogger logger,
                                       IGrupoFormularioServicio grupoFormularioServicio,
                                       IGrupoServicio grupoServicio,
                                       Guid entidadSeleccionadaId)
                                       : base(seguridadServicio, configuracionServicio, logger, entidadSeleccionadaId)
        {
            InitializeComponent();

            this.TituloFormulario = Base.Constantes.FormularioConstantes.Titulo;

            this.TituloAsignado = "Formularios Asignadas";
            this.TituloNoAsignado = "Formularios No Asignadas";
            this.Titulo = "Asignar / Quitar Formularios";
            this.LogoTitulo = FontAwesome.Sharp.IconChar.PeopleGroup;

            this._grupoFormularioServicio = grupoFormularioServicio;
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
            var result = _grupoFormularioServicio.GetByFormulariosAsignadas(new GrupoFormularioFilterDTO
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
            var result = _grupoFormularioServicio.GetByFormulariosNoAsignadas(new GrupoFormularioFilterDTO
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

                dgv.Columns["Descripcion"].Visible = true;
                dgv.Columns["Descripcion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgv.Columns["Descripcion"].HeaderText = "Nombre";
                dgv.Columns["Descripcion"].ReadOnly = true;
                dgv.Columns["Descripcion"].DisplayIndex = 1;
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
            _grupoFormularioServicio.AddFormulariosGrupo(new GrupoFormulariosPersistenciaDTO
            {
                GrupoId = base.EntidadId,
                FormularioIds = ((List<FormularioDTO>)dgv.DataSource).Where(x => x.EstaSeleccionado).Select(x => x.Id).ToList()
            }, Properties.Settings.Default.UserLogin);

            base.EjecutarComandoAgregar(dgv);
        }

        public override void EjecutarComandoQuitar(DataGridView dgv)
        {
            _grupoFormularioServicio.DeleteFormulariosGrupo(new GrupoFormulariosPersistenciaDTO
            {
                GrupoId = base.EntidadId,
                FormularioIds = ((List<FormularioDTO>)dgv.DataSource).Where(x => x.EstaSeleccionado).Select(x => x.Id).ToList()
            }, Properties.Settings.Default.UserLogin);

            base.EjecutarComandoQuitar(dgv);
        }
    }
}
