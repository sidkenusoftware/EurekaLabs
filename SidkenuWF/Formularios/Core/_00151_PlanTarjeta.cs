using FontAwesome.Sharp;
using Serilog;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.PlanTarjeta;
using Sidkenu.LogicaNegocio.Servicios.Interface.Core;
using Sidkenu.LogicaNegocio.Servicios.Interface.Seguridad;
using SidkenuWF.Formularios.Base;
using SidkenuWF.Formularios.Base.Constantes;

namespace SidkenuWF.Formularios.Core
{
    public partial class _00151_PlanTarjeta : FormularioConsulta
    {
        private readonly IPlanTarjetaServicio _planTarjetaServicio;

        public _00151_PlanTarjeta(ISeguridadServicio seguridadServicio,
                                  IConfiguracionServicio configuracionServicio,
                                  ILogger logger,
                                  IPlanTarjetaServicio planTarjetaServicio)
                                  : base(seguridadServicio, configuracionServicio, logger)
        {
            InitializeComponent();

            base.BotoneraLateralVisible = (false, false); // (Panel Botonera, Panel Abrir-Cerrar)
            base.TituloFormulario = Base.Constantes.FormularioConstantes.Titulo;
            base.Titulo = "Planes de las Tarjetas";
            base.Logo = IconChar.CreditCard;

            _planTarjetaServicio = planTarjetaServicio;
        }

        public override bool EjecutarComandoNuevo(object sender, EventArgs e)
        {
            var formularioAbm = new _00152_PlanTarjeta_Abm(base._seguridadServicio,
                                                           base._configuracionServicio,
                                                           Program.Container.GetInstance<IConfiguracionCoreServicio>(),
                                                           base._logger,
                                                           Program.Container.GetInstance<ITarjetaServicio>(),
                                                           Program.Container.GetInstance<IPlanTarjetaServicio>(),
                                                           TipoOperacion.Nuevo);

            FormularioSeguridad.VerificarAcceso(formularioAbm, base._seguridadServicio, base._logger, base._configuracionDTO);

            return formularioAbm.RealizoAlgunaOperacion;
        }

        public override bool EjecutarComandoEditar(object sender, EventArgs e)
        {
            var formularioAbm = new _00152_PlanTarjeta_Abm(base._seguridadServicio,
                                                           base._configuracionServicio,
                                                           Program.Container.GetInstance<IConfiguracionCoreServicio>(),
                                                           base._logger,
                                                           Program.Container.GetInstance<ITarjetaServicio>(),
                                                           Program.Container.GetInstance<IPlanTarjetaServicio>(),
                                                           TipoOperacion.Modificar, EntidadId);

            FormularioSeguridad.VerificarAcceso(formularioAbm, base._seguridadServicio, base._logger, base._configuracionDTO);

            return formularioAbm.RealizoAlgunaOperacion;
        }

        public override bool EjecutarComandoEliminar(object sender, EventArgs e)
        {
            try
            {
                _planTarjetaServicio.Delete(new PlanTarjetaDeleteDTO { Id = base.EntidadId.Value }, Properties.Settings.Default.UserLogin);

                return true;
            }
            catch
            {
                return false;
            }
        }

        public override void Buscar(string cadenaBuscar, bool verEliminados = false)
        {
            var result = _planTarjetaServicio.GetByFilter(new PlanTarjetaFilterDTO
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
                dgvGrilla.Columns["Codigo"].Width = 120;
                dgvGrilla.Columns["Codigo"].HeaderText = "Código";
                dgvGrilla.Columns["Codigo"].DisplayIndex = 0;
                dgvGrilla.Columns["Codigo"].ReadOnly = true;

                dgvGrilla.Columns["Tarjeta"].Visible = true;
                dgvGrilla.Columns["Tarjeta"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvGrilla.Columns["Tarjeta"].HeaderText = "Tarjeta";
                dgvGrilla.Columns["Tarjeta"].DisplayIndex = 1;
                dgvGrilla.Columns["Tarjeta"].ReadOnly = true;                

                dgvGrilla.Columns["DescripcionCompleta"].Visible = true;
                dgvGrilla.Columns["DescripcionCompleta"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvGrilla.Columns["DescripcionCompleta"].HeaderText = "Plan Tarjeta";
                dgvGrilla.Columns["DescripcionCompleta"].DisplayIndex = 2;
                dgvGrilla.Columns["DescripcionCompleta"].ReadOnly = true;

                dgvGrilla.Columns["AlicuotaStr"].Visible = true;
                dgvGrilla.Columns["AlicuotaStr"].Width = 100;
                dgvGrilla.Columns["AlicuotaStr"].HeaderText = "Alicuota";
                dgvGrilla.Columns["AlicuotaStr"].DisplayIndex = 3;
                dgvGrilla.Columns["AlicuotaStr"].ReadOnly = true;
                dgvGrilla.Columns["AlicuotaStr"].DefaultCellStyle.Format = "N2";

                dgvGrilla.Columns["Descripcion"].Visible = false;
                dgvGrilla.Columns["Alicuota"].Visible = false;
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
