using FontAwesome.Sharp;
using SidkenuWF.Formularios.Base.Constantes;
using SidkenuWF.Formularios.Base;
using Serilog;
using Sidkenu.LogicaNegocio.Servicios.Interface.Seguridad;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Seguridad.Persona;

namespace SidkenuWF.Formularios.Core.LookUps
{
    public partial class EmpleadoLookUp : FormularioLookUp
    {
        private readonly IPersonaServicio _personaServicio;

        public EmpleadoLookUp(ISeguridadServicio seguridadServicio,
                             IConfiguracionServicio configuracionServicio,
                             ILogger logger,
                             IPersonaServicio personaServicio)
                             : base(seguridadServicio, configuracionServicio, logger)
        {
            InitializeComponent();

            base.TituloFormulario = FormularioConstantes.Titulo;
            base.Titulo = "Artículos";
            base.Logo = IconChar.BuildingFlag;

            _personaServicio = personaServicio;
        }

        public override void Buscar(string cadenaBuscar)
        {
            var result = _personaServicio.GetByFilterLookUp(new PersonaFilterDTO
            {
                CadenaBuscar = cadenaBuscar,
                VerEliminados = false,
                EmpresaId = Properties.Settings.Default.EmpresaId
            });

            if (result.State)
            {
                this.dgvGrilla.DataSource = result.Data;

                base.Buscar(cadenaBuscar);
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

                dgvGrilla.AllowUserToResizeRows = false;

                dgvGrilla.Columns["NombreCompleto"].Visible = true;
                dgvGrilla.Columns["NombreCompleto"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvGrilla.Columns["NombreCompleto"].HeaderText = "Apellido y Nombre";
                dgvGrilla.Columns["NombreCompleto"].DisplayIndex = 0;
                dgvGrilla.Columns["NombreCompleto"].ReadOnly = true;

                dgvGrilla.Columns["CUIL"].Visible = true;
                dgvGrilla.Columns["CUIL"].Width = 100;
                dgvGrilla.Columns["CUIL"].HeaderText = "CUIL";
                dgvGrilla.Columns["CUIL"].DisplayIndex = 1;
                dgvGrilla.Columns["CUIL"].ReadOnly = true;

                dgvGrilla.Columns["Telefono"].Visible = true;
                dgvGrilla.Columns["Telefono"].Width = 100;
                dgvGrilla.Columns["Telefono"].HeaderText = "Telefono";
                dgvGrilla.Columns["Telefono"].DisplayIndex = 2;
                dgvGrilla.Columns["Telefono"].ReadOnly = true;
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
