using FontAwesome.Sharp;
using Serilog;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Seguridad.Persona;
using Sidkenu.LogicaNegocio.Servicios.Interface.Seguridad;
using SidkenuWF.Formularios.Base;
using SidkenuWF.Formularios.Base.Constantes;

namespace SidkenuWF.Formularios.Seguridad
{
    public partial class _00003_Persona : FormularioConsulta
    {
        private readonly IPersonaServicio _personaServicio;
        public _00003_Persona(ISeguridadServicio seguridadServicio,
                              IConfiguracionServicio configuracionServicio,
                              ILogger logger,
                              IPersonaServicio personaServicio)
                              : base(seguridadServicio, configuracionServicio, logger)
        {
            InitializeComponent();

            base.BotoneraLateralVisible = (false, false); // (Panel Botonera, Panel Abrir-Cerrar)
            base.TituloFormulario = Base.Constantes.FormularioConstantes.Titulo;
            base.Titulo = "Persona";
            base.Logo = IconChar.UserGroup;

            _personaServicio = personaServicio;
        }

        public override bool EjecutarComandoNuevo(object sender, EventArgs e)
        {
            var formularioAbm = new _00004_Persona_Abm(base._seguridadServicio,
                                                        base._configuracionServicio,
                                                        base._logger,
                                                        Program.Container.GetInstance<IPersonaServicio>(),
                                                        TipoOperacion.Nuevo);

            FormularioSeguridad.VerificarAcceso(formularioAbm, base._seguridadServicio, base._logger, base._configuracionDTO);

            return formularioAbm.RealizoAlgunaOperacion;
        }

        public override bool EjecutarComandoEditar(object sender, EventArgs e)
        {
            var formularioAbm = new _00004_Persona_Abm(base._seguridadServicio,
                                                       base._configuracionServicio,
                                                       base._logger,
                                                       Program.Container.GetInstance<IPersonaServicio>(),
                                                       TipoOperacion.Modificar, EntidadId);

            FormularioSeguridad.VerificarAcceso(formularioAbm, base._seguridadServicio, base._logger, base._configuracionDTO);

            return formularioAbm.RealizoAlgunaOperacion;
        }

        public override bool EjecutarComandoEliminar(object sender, EventArgs e)
        {
            try
            {
                _personaServicio.Delete(new PersonaDeleteDTO { Id = base.EntidadId.Value }, Properties.Settings.Default.UserLogin);

                return true;
            }
            catch
            {
                return false;
            }
        }

        public override void Buscar(string cadenaBuscar, bool verEliminados = false)
        {
            var result = _personaServicio.GetByFilter(new PersonaFilterDTO
            {
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
                if (base._configuracionDTO != null && base._configuracionDTO != null && base._configuracionDTO.LogError)
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

                dgvGrilla.Columns["Mail"].Visible = true;
                dgvGrilla.Columns["Mail"].Width = 200;
                dgvGrilla.Columns["Mail"].HeaderText = "E-Mail";
                dgvGrilla.Columns["Mail"].DisplayIndex = 3;
                dgvGrilla.Columns["Mail"].ReadOnly = true;

                dgvGrilla.Columns["Usuario"].Visible = true;
                dgvGrilla.Columns["Usuario"].Width = 200;
                dgvGrilla.Columns["Usuario"].HeaderText = "Usuario";
                dgvGrilla.Columns["Usuario"].DisplayIndex = 4;
                dgvGrilla.Columns["Usuario"].ReadOnly = true;
            }
            catch (Exception ex)
            {
                if (base._configuracionDTO != null && base._configuracionDTO != null && base._configuracionDTO.LogError)
                {
                    _logger.Error(ex, $"Error en el formateo de las columnas en {base.Titulo}.");
                }

                MessageBox.Show("Los nombres de las columnas no coinciden");
            }
        }
    }
}
