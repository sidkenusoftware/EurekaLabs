using FontAwesome.Sharp;
using Serilog;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Seguridad.Usuario;
using Sidkenu.LogicaNegocio.Servicios.Interface.Seguridad;
using SidkenuWF.Formularios.Base;

namespace SidkenuWF.Formularios.Seguridad
{
    public partial class _00006_Usuario : FormularioConsulta
    {
        private readonly IUsuarioServicio _usuarioServicio;

        public _00006_Usuario(ISeguridadServicio seguridadServicio,
                              IConfiguracionServicio configuracionServicio,
                              ILogger logger,
                              IUsuarioServicio usuarioServicio)
                              : base(seguridadServicio, configuracionServicio, logger)
        {
            InitializeComponent();

            base.BotoneraLateralVisible = (false, true); // (Panel Botonera, Panel Abrir-Cerrar)
            base.TituloFormulario = Base.Constantes.FormularioConstantes.Titulo;
            base.Titulo = "Usuario";
            base.Logo = IconChar.PeopleGroup;
            base.MostrarBotonesABM = false;
            base.MostrarBotonesSeleccion = true;

            _usuarioServicio = usuarioServicio;
        }

        public override void Buscar(string cadenaBuscar, bool verEliminados = false)
        {
            var result = _usuarioServicio.GetByFilter(new UsuarioFilterDTO
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

                dgvGrilla.Columns["EstaSeleccionado"].Visible = true;
                dgvGrilla.Columns["EstaSeleccionado"].HeaderText = "Item";
                dgvGrilla.Columns["EstaSeleccionado"].Width = 50;
                dgvGrilla.Columns["EstaSeleccionado"].ReadOnly = false;
                dgvGrilla.Columns["EstaSeleccionado"].DisplayIndex = 0;

                dgvGrilla.Columns["ApyNomPersona"].Visible = true;
                dgvGrilla.Columns["ApyNomPersona"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvGrilla.Columns["ApyNomPersona"].HeaderText = "Apellido y Nombre";
                dgvGrilla.Columns["ApyNomPersona"].ReadOnly = true;
                dgvGrilla.Columns["ApyNomPersona"].DisplayIndex = 1;

                dgvGrilla.Columns["Nombre"].Visible = true;
                dgvGrilla.Columns["Nombre"].Width = 150;
                dgvGrilla.Columns["Nombre"].HeaderText = "Usuario";
                dgvGrilla.Columns["Nombre"].ReadOnly = true;
                dgvGrilla.Columns["Nombre"].DisplayIndex = 2;

                dgvGrilla.Columns["EstaBloqueado"].Visible = true;
                dgvGrilla.Columns["EstaBloqueado"].Width = 80;
                dgvGrilla.Columns["EstaBloqueado"].HeaderText = "Bloqueado";
                dgvGrilla.Columns["EstaBloqueado"].ReadOnly = true;
                dgvGrilla.Columns["EstaBloqueado"].DisplayIndex = 3;

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

        private void BtnCrear_Click(object sender, EventArgs e)
        {
            try
            {

                if (base.dgvGrilla.RowCount > 0)
                {
                    var personasSeleccionados = ((List<UsuarioDTO>)dgvGrilla.DataSource)
                        .Where(x => x.EstaSeleccionado && !x.Existe)
                        .ToList();

                    foreach (var persona in personasSeleccionados)
                    {
                        var usuarioNuevoDto = new UsuarioPersistenciaDTO
                        {
                            PersonaId = persona.PersonaId,
                            PersonaApellido = persona.ApellidoPersona,
                            PersonaNombre = persona.NombrePersona,
                            InicioPorPrimeraVez = true
                        };

                        _usuarioServicio.Crear(usuarioNuevoDto, Properties.Settings.Default.UserLogin);
                    }

                    Buscar(string.Empty);
                }
                else
                {
                    MessageBox.Show("No hay datos Cargados");
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrió un error al Crear el/los Usuario/s.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                SeleccionarRows(false);
            }
        }
    }
}
