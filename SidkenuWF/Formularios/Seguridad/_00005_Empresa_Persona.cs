using Serilog;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Seguridad.Empresa;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Seguridad.EmpresaPersona;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Seguridad.Persona;
using Sidkenu.LogicaNegocio.Servicios.Interface.Seguridad;
using SidkenuWF.Formularios.Base;

namespace SidkenuWF.Formularios.Seguridad
{
    public partial class _00005_Empresa_Persona : FormularioAsignarQuitar
    {
        private readonly IEmpresaPersonaServicio _empresaPersonaServicio;
        private readonly IEmpresaServicio _empresaServicio;

        public _00005_Empresa_Persona(ISeguridadServicio seguridadServicio,
                                      IConfiguracionServicio configuracionServicio,
                                      ILogger logger,
                                      IEmpresaPersonaServicio empresaPersonaServicio,
                                      IEmpresaServicio empresaServicio,
                                      Guid entidadSeleccionadaId)
                                      : base(seguridadServicio, configuracionServicio, logger, entidadSeleccionadaId)
        {
            InitializeComponent();

            this.TituloFormulario = Base.Constantes.FormularioConstantes.Titulo;

            this.TituloAsignado = "Personas Asignadas";
            this.TituloNoAsignado = "Personas No Asignadas";
            this.Titulo = "Asignar / Quitar Personas";
            this.LogoTitulo = FontAwesome.Sharp.IconChar.PeopleGroup;

            this._empresaPersonaServicio = empresaPersonaServicio;
            this._empresaServicio = empresaServicio;

            this.TituloEntidadSeleccionada = $"Empresa: {ObtenerLaEntidadSeleccionada(entidadSeleccionadaId)}";
        }

        private string ObtenerLaEntidadSeleccionada(Guid entidadSeleccionadaId)
        {
            var result = _empresaServicio.GetById(entidadSeleccionadaId);

            if (result.State)
            {
                return ((EmpresaDTO)result.Data).Descripcion;
            }

            return string.Empty;
        }

        public override void ActualizarDatosAsignado(DataGridView dgvGrilla, string cadenaBuscar)
        {
            var result = _empresaPersonaServicio.GetByPersonasAsignadas(new EmpresaPersonaFilterDTO
            {
                EmpresaId = base.EntidadId,
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
            var result = _empresaPersonaServicio.GetByPersonasNoAsignadas(new EmpresaPersonaFilterDTO
            {
                EmpresaId = base.EntidadId,
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
            _empresaPersonaServicio.AddPersonasEmpresa(new EmpresaPersonasPersistenciaDTO
            {
                EmpresaId = base.EntidadId,
                PersonaIds = ((List<PersonaDTO>)dgv.DataSource).Where(x => x.EstaSeleccionado).Select(x => x.Id).ToList()
            }, Properties.Settings.Default.UserLogin);

            base.EjecutarComandoAgregar(dgv);
        }

        public override void EjecutarComandoQuitar(DataGridView dgv)
        {
            _empresaPersonaServicio.DeletePersonasEmpresa(new EmpresaPersonasPersistenciaDTO
            {
                EmpresaId = base.EntidadId,
                PersonaIds = ((List<PersonaDTO>)dgv.DataSource).Where(x => x.EstaSeleccionado).Select(x => x.Id).ToList()
            }, Properties.Settings.Default.UserLogin);

            base.EjecutarComandoQuitar(dgv);
        }
    }
}
