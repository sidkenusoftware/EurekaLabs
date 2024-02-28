using FontAwesome.Sharp;
using SidkenuWF.Formularios.Base.Constantes;
using SidkenuWF.Formularios.Base;
using Serilog;
using Sidkenu.LogicaNegocio.Servicios.Interface.Core;
using Sidkenu.LogicaNegocio.Servicios.Interface.Seguridad;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.Banco;

namespace SidkenuWF.Formularios.Core
{
    public partial class _00153_Banco : FormularioConsulta
    {
        private readonly IBancoServicio _bancoServicio;

        public _00153_Banco(ISeguridadServicio seguridadServicio,
                            IConfiguracionServicio configuracionServicio,
                            ILogger logger,
                            IBancoServicio bancoServicio)
                            : base(seguridadServicio, configuracionServicio, logger)
        {
            InitializeComponent();

            base.BotoneraLateralVisible = (false, false); // (Panel Botonera, Panel Abrir-Cerrar)
            base.TituloFormulario = Base.Constantes.FormularioConstantes.Titulo;
            base.Titulo = "Bancos";
            base.Logo = IconChar.CreditCard;

            _bancoServicio = bancoServicio;
        }

        public override bool EjecutarComandoNuevo(object sender, EventArgs e)
        {
            var formularioAbm = new _00154_Banco_Abm(base._seguridadServicio,
                                                       base._configuracionServicio,
                                                       Program.Container.GetInstance<IConfiguracionCoreServicio>(),
                                                       base._logger,
                                                       Program.Container.GetInstance<IBancoServicio>(),
                                                       TipoOperacion.Nuevo);

            FormularioSeguridad.VerificarAcceso(formularioAbm, base._seguridadServicio, base._logger, base._configuracionDTO);

            return formularioAbm.RealizoAlgunaOperacion;
        }

        public override bool EjecutarComandoEditar(object sender, EventArgs e)
        {
            var formularioAbm = new _00154_Banco_Abm(base._seguridadServicio,
                                                       base._configuracionServicio,
                                                       Program.Container.GetInstance<IConfiguracionCoreServicio>(),
                                                       base._logger,
                                                       Program.Container.GetInstance<IBancoServicio>(),
                                                       TipoOperacion.Modificar, EntidadId);

            FormularioSeguridad.VerificarAcceso(formularioAbm, base._seguridadServicio, base._logger, base._configuracionDTO);

            return formularioAbm.RealizoAlgunaOperacion;
        }

        public override bool EjecutarComandoEliminar(object sender, EventArgs e)
        {
            try
            {
                _bancoServicio.Delete(new BancoDeleteDTO { Id = base.EntidadId.Value }, Properties.Settings.Default.UserLogin);

                return true;
            }
            catch
            {
                return false;
            }
        }

        public override void Buscar(string cadenaBuscar, bool verEliminados = false)
        {
            var result = _bancoServicio.GetByFilter(new BancoFilterDTO
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

                dgvGrilla.Columns["Codigo"].Visible = true;
                dgvGrilla.Columns["Codigo"].Width = 150;
                dgvGrilla.Columns["Codigo"].HeaderText = "Código";
                dgvGrilla.Columns["Codigo"].DisplayIndex = 0;
                dgvGrilla.Columns["Codigo"].ReadOnly = true;

                dgvGrilla.Columns["Descripcion"].Visible = true;
                dgvGrilla.Columns["Descripcion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvGrilla.Columns["Descripcion"].HeaderText = "Banco";
                dgvGrilla.Columns["Descripcion"].DisplayIndex = 1;
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
    }
}
