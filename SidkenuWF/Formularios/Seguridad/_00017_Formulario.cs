using FontAwesome.Sharp;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Seguridad.Formulario;
using Sidkenu.LogicaNegocio.Servicios.Interface.Seguridad;
using SidkenuWF.Formularios.Base.Constantes;

namespace SidkenuWF.Formularios.Seguridad
{
    public partial class _00017_Formulario : Base.FormularioConsulta
    {
        private readonly ISeguridadServicio _seguridadServicio;

        private readonly IFormularioServicio _formularioServicio;

        private List<FormularioDTO> _listaFormularios;

        public _00017_Formulario(ISeguridadServicio seguridadServicio,
            IFormularioServicio formularioServicio)
        {
            InitializeComponent();

            base.BotoneraLateralVisible = (true, true); // (Panel Botonera, Panel Abrir-Cerrar)
            base.TituloFormulario = FormularioConstantes.Titulo;
            base.Titulo = "Formularios / Pantallas";
            base.Logo = IconChar.Desktop;

            _seguridadServicio = seguridadServicio;
            _formularioServicio = formularioServicio;

            base.MostrarBotonesABM = false;
            base.MostrarBotonesSeleccion = true;

            _listaFormularios = new List<FormularioDTO>();
        }

        public override void EjecutarComandoLoad(object sender, EventArgs e)
        {
            _listaFormularios = FormularioAssemblie.GetAllFormNames(AppDomain.CurrentDomain.GetAssemblies());

            base.EjecutarComandoLoad(sender, e);
        }

        public override void Buscar(string cadenaBuscar, bool verEliminados = false)
        {
            var result = _formularioServicio.GetAll();

            if (result.State)
            {
                var _listaFormulariosBaseDatos = (List<FormularioDTO>)result.Data;

                foreach (var formularioProyecto in _listaFormularios)
                {
                    formularioProyecto.ExisteBase = _listaFormulariosBaseDatos.Any(x => x.Codigo == formularioProyecto.Codigo);
                }

                dgvGrilla.DataSource = _listaFormularios.Where(x => x.EstaEliminado == verEliminados
                                                                    && x.Codigo.ToLower().Contains(cadenaBuscar.ToLower())
                                                                    || x.Descripcion.ToLower().Contains(cadenaBuscar.ToLower())
                                                                    || x.DescripcionCompleta.ToLower().Contains(cadenaBuscar.ToLower()))
                                                        .ToList();

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

                dgvGrilla.Columns["Codigo"].Visible = true;
                dgvGrilla.Columns["Codigo"].Width = 75;
                dgvGrilla.Columns["Codigo"].HeaderText = "Codigo";
                dgvGrilla.Columns["Codigo"].ReadOnly = true;
                dgvGrilla.Columns["Codigo"].DisplayIndex = 1;

                dgvGrilla.Columns["Descripcion"].Visible = true;
                dgvGrilla.Columns["Descripcion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvGrilla.Columns["Descripcion"].HeaderText = "Nombre";
                dgvGrilla.Columns["Descripcion"].ReadOnly = true;
                dgvGrilla.Columns["Descripcion"].DisplayIndex = 2;

                dgvGrilla.Columns["DescripcionCompleta"].Visible = true;
                dgvGrilla.Columns["DescripcionCompleta"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvGrilla.Columns["DescripcionCompleta"].HeaderText = "Nombre Completo";
                dgvGrilla.Columns["DescripcionCompleta"].ReadOnly = true;
                dgvGrilla.Columns["DescripcionCompleta"].DisplayIndex = 3;

                dgvGrilla.Columns["ExisteBase"].Visible = true;
                dgvGrilla.Columns["ExisteBase"].Width = 50;
                dgvGrilla.Columns["ExisteBase"].HeaderText = "Existe";
                dgvGrilla.Columns["ExisteBase"].ReadOnly = true;
                dgvGrilla.Columns["ExisteBase"].DisplayIndex = 4;
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

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            var listaFormulariosSeleccionados = ((List<FormularioDTO>)base.dgvGrilla.DataSource)
                .Where(x => x.EstaSeleccionado && !x.ExisteBase).ToList();

            if (!listaFormulariosSeleccionados.Any())
            {
                MessageBox.Show("Por favor seleccione un formulario que no exista en la Base de Datos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var result = _formularioServicio
                .Add(listaFormulariosSeleccionados,
                Properties.Settings.Default.UserLogin);

            MessageBox.Show(result.Message, "Atención", MessageBoxButtons.OK);

            Buscar(string.Empty);
        }
    }
}
