using FontAwesome.Sharp;
using SidkenuWF.Formularios.Base.Constantes;
using SidkenuWF.Formularios.Base;
using Serilog;
using Sidkenu.LogicaNegocio.Servicios.Interface.Core;
using Sidkenu.LogicaNegocio.Servicios.Interface.Seguridad;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.Deposito;

namespace SidkenuWF.Formularios.Core
{
    public partial class _00136_Deposito : FormularioConsulta
    {
        private readonly IDepositoServicio _depositoServicio;

        public _00136_Deposito(ISeguridadServicio seguridadServicio,
                              IConfiguracionServicio configuracionServicio,
                              ILogger logger,
                              IDepositoServicio depositoServicio)
                              : base(seguridadServicio, configuracionServicio, logger)
        {
            InitializeComponent();

            base.BotoneraLateralVisible = (true, true); // (Panel Botonera, Panel Abrir-Cerrar)
            base.TituloFormulario = FormularioConstantes.Titulo;
            base.Titulo = "Deposito";
            base.Logo = IconChar.Home;

            _depositoServicio = depositoServicio;
        }

        public override bool EjecutarComandoNuevo(object sender, EventArgs e)
        {
            var formularioAbm = new _00137_Deposito_Abm(base._seguridadServicio,
                                                       base._configuracionServicio,
                                                       base._logger,
                                                       Program.Container.GetInstance<IDepositoServicio>(),
                                                       TipoOperacion.Nuevo);

            FormularioSeguridad.VerificarAcceso(formularioAbm, base._seguridadServicio, base._logger, base._configuracionDTO);

            return formularioAbm.RealizoAlgunaOperacion;
        }

        public override bool EjecutarComandoEditar(object sender, EventArgs e)
        {
            var formularioAbm = new _00137_Deposito_Abm(base._seguridadServicio,
                                                       base._configuracionServicio,
                                                       base._logger,
                                                       Program.Container.GetInstance<IDepositoServicio>(),
                                                       TipoOperacion.Modificar, EntidadId);

            FormularioSeguridad.VerificarAcceso(formularioAbm, base._seguridadServicio, base._logger, base._configuracionDTO);

            return formularioAbm.RealizoAlgunaOperacion;
        }

        public override bool EjecutarComandoEliminar(object sender, EventArgs e)
        {
            try
            {
                _depositoServicio.Delete(new DepositoDeleteDTO { Id = base.EntidadId.Value }, Properties.Settings.Default.UserLogin);

                return true;
            }
            catch
            {
                return false;
            }
        }

        public override void Buscar(string cadenaBuscar, bool verEliminados = false)
        {
            var result = _depositoServicio.GetByFilter(new DepositoFilterDTO
            {
                CadenaBuscar = cadenaBuscar,
                VerEliminados = verEliminados,
                EmpresaId = Properties.Settings.Default.EmpresaId
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

                dgvGrilla.Columns["Abreviatura"].Visible = true;
                dgvGrilla.Columns["Abreviatura"].Width = 150;
                dgvGrilla.Columns["Abreviatura"].HeaderText = "Abreviatura";
                dgvGrilla.Columns["Abreviatura"].DisplayIndex = 0;
                dgvGrilla.Columns["Abreviatura"].ReadOnly = true;

                dgvGrilla.Columns["Descripcion"].Visible = true;
                dgvGrilla.Columns["Descripcion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvGrilla.Columns["Descripcion"].HeaderText = "Deposito";
                dgvGrilla.Columns["Descripcion"].DisplayIndex = 1;
                dgvGrilla.Columns["Descripcion"].ReadOnly = true;

                dgvGrilla.Columns["Direccion"].Visible = true;
                dgvGrilla.Columns["Direccion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvGrilla.Columns["Direccion"].HeaderText = "Direccion";
                dgvGrilla.Columns["Direccion"].DisplayIndex = 2;
                dgvGrilla.Columns["Direccion"].ReadOnly = true;

                dgvGrilla.Columns["TipoDeposito"].Visible = true;
                dgvGrilla.Columns["TipoDeposito"].Width = 700;
                dgvGrilla.Columns["TipoDeposito"].HeaderText = "Tipo";
                dgvGrilla.Columns["TipoDeposito"].DisplayIndex = 3;
                dgvGrilla.Columns["TipoDeposito"].ReadOnly = true;

                dgvGrilla.Columns["Predeterminado"].Visible = true;
                dgvGrilla.Columns["Predeterminado"].Width = 60;
                dgvGrilla.Columns["Predeterminado"].HeaderText = "Default";
                dgvGrilla.Columns["Predeterminado"].DisplayIndex = 4;
                dgvGrilla.Columns["Predeterminado"].ReadOnly = true;
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

        public override void EjecutarComandoRowEnter(object sender, DataGridViewCellEventArgs e)
        {
            base.EjecutarComandoRowEnter(sender, e);

            if (dgvGrilla.Rows.Count > 0)
            {
                var entidadSeleccionada = (DepositoDTO)base.Entidad;

                btnMarcarPredeterminado.Visible = !entidadSeleccionada.Predeterminado;
            }
        }

        private void BtnMarcarPredeterminado_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro de MARCAR como Predeterminado", "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                == DialogResult.Cancel)
            {
                return;
            }

            var entidadSeleccionada = (DepositoDTO)base.Entidad;

            var result = _depositoServicio.MarcarComoPredeterminado(base.EntidadId.Value, Properties.Settings.Default.EmpresaId, entidadSeleccionada.TipoDeposito);

            MessageBox.Show(result.Message, "Atención");

            if (result.State)
            {
                Buscar(txtBuscar.Text);
            }
        }

        private void BtnAsignarPersona_Click(object sender, EventArgs e)
        {

        }
    }
}
