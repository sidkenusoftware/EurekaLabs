using Serilog;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.Caja;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.CajaPuestoTrabajo;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Seguridad.PuestoTrabajo;
using Sidkenu.LogicaNegocio.Servicios.Interface.Core;
using Sidkenu.LogicaNegocio.Servicios.Interface.Seguridad;
using SidkenuWF.Formularios.Base;

namespace SidkenuWF.Formularios.Core
{
    public partial class _00155_Caja_PuestoTrabajo : FormularioAsignarQuitar
    {
        private readonly ICajaPuestoTrabajoServicio _cajaPuestoTrabajoServicio;
        private readonly ICajaServicio _cajaServicio;

        public _00155_Caja_PuestoTrabajo(ISeguridadServicio seguridadServicio,
                                         IConfiguracionServicio configuracionServicio,
                                         ILogger logger,
                                         ICajaPuestoTrabajoServicio cajaPuestoTrabajoServicio,
                                         ICajaServicio cajaServicio,
                                         Guid entidadSeleccionadaId)
                                         : base(seguridadServicio, configuracionServicio, logger, entidadSeleccionadaId)
        {
            InitializeComponent();

            this.TituloFormulario = Base.Constantes.FormularioConstantes.Titulo;

            this.TituloAsignado = "Puestos de Trabajos Asignados";
            this.TituloNoAsignado = "Puestos de Trabajos No Asignados";
            this.Titulo = "Asignar / Quitar Puestos de Trabajos";
            this.LogoTitulo = FontAwesome.Sharp.IconChar.PeopleGroup;

            this._cajaPuestoTrabajoServicio = cajaPuestoTrabajoServicio;
            this._cajaServicio = cajaServicio;

            this.TituloEntidadSeleccionada = $"Caja seleccionada: {ObtenerLaEntidadSeleccionada(entidadSeleccionadaId)}";
        }

        private string ObtenerLaEntidadSeleccionada(Guid entidadSeleccionadaId)
        {
            var result = _cajaServicio.GetById(entidadSeleccionadaId);

            if (result.State)
            {
                return ((CajaDTO)result.Data).Descripcion;
            }

            return string.Empty;
        }

        public override void ActualizarDatosAsignado(DataGridView dgvGrilla, string cadenaBuscar)
        {
            var result = _cajaPuestoTrabajoServicio.GetByPuestosTrabajosAsignadas(new CajaPuestoTrabajoFilterDTO
            {
                EmpresaId = Properties.Settings.Default.EmpresaId,
                CajaId = base.EntidadId,
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
            var result = _cajaPuestoTrabajoServicio.GetByPuestosTrabajosNoAsignadas(new CajaPuestoTrabajoFilterDTO
            {
                EmpresaId = Properties.Settings.Default.EmpresaId,
                CajaId = base.EntidadId,
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
            _cajaPuestoTrabajoServicio.AddPuestosTrabajosCaja(new CajaPuestoTrabajosPersistenciaDTO
            {
                CajaId = base.EntidadId,
                PuestoTrabajoIds = ((List<PuestoTrabajoDTO>)dgv.DataSource).Where(x => x.EstaSeleccionado).Select(x => x.Id).ToList()
            }, Properties.Settings.Default.UserLogin);

            base.EjecutarComandoAgregar(dgv);
        }

        public override void EjecutarComandoQuitar(DataGridView dgv)
        {
            _cajaPuestoTrabajoServicio.DeleteCajaPuestosTrabajos(new CajaPuestoTrabajosPersistenciaDTO
            {
                CajaId = base.EntidadId,
                PuestoTrabajoIds = ((List<PuestoTrabajoDTO>)dgv.DataSource).Where(x => x.EstaSeleccionado).Select(x => x.Id).ToList()
            }, Properties.Settings.Default.UserLogin);

            base.EjecutarComandoQuitar(dgv);
        }
    }
}
