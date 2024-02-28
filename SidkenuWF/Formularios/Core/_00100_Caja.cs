using FontAwesome.Sharp;
using Serilog;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.Caja;
using Sidkenu.LogicaNegocio.Servicios.Interface.Core;
using Sidkenu.LogicaNegocio.Servicios.Interface.Seguridad;
using SidkenuWF.Formularios.Base;
using SidkenuWF.Formularios.Base.Constantes;

namespace SidkenuWF.Formularios.Core
{
    public partial class _00100_Caja : FormularioConsulta
    {
        private readonly ICajaServicio _cajaServicio;

        public _00100_Caja(ISeguridadServicio seguridadServicio,
                           IConfiguracionServicio configuracionServicio,
                           ILogger logger,
                           ICajaServicio cajaServicio)
                           : base(seguridadServicio, configuracionServicio, logger)
        {
            InitializeComponent();

            base.BotoneraLateralVisible = (false, true); // (Panel Botonera, Panel Abrir-Cerrar)
            base.TituloFormulario = Base.Constantes.FormularioConstantes.Titulo;
            base.Titulo = "Caja";
            base.Logo = IconChar.BuildingFlag;

            _cajaServicio = cajaServicio;
        }

        public override bool EjecutarComandoNuevo(object sender, EventArgs e)
        {
            var formularioAbm = new _00101_Caja_Abm(base._seguridadServicio,
                                                         base._configuracionServicio,
                                                         base._logger,
                                                         Program.Container.GetInstance<ICajaServicio>(),
                                                         TipoOperacion.Nuevo);

            FormularioSeguridad.VerificarAcceso(formularioAbm, base._seguridadServicio, base._logger, base._configuracionDTO);

            return formularioAbm.RealizoAlgunaOperacion;
        }

        public override bool EjecutarComandoEditar(object sender, EventArgs e)
        {
            var formularioAbm = new _00101_Caja_Abm(base._seguridadServicio,
                                                    base._configuracionServicio,
                                                    base._logger,
                                                    Program.Container.GetInstance<ICajaServicio>(),
                                                    TipoOperacion.Modificar, EntidadId);

            FormularioSeguridad.VerificarAcceso(formularioAbm, base._seguridadServicio, base._logger, base._configuracionDTO);

            return formularioAbm.RealizoAlgunaOperacion;
        }

        public override bool EjecutarComandoEliminar(object sender, EventArgs e)
        {
            try
            {
                _cajaServicio.Delete(new CajaDeleteDTO { Id = base.EntidadId.Value }, Properties.Settings.Default.UserLogin);

                return true;
            }
            catch
            {
                return false;
            }
        }

        public override void Buscar(string cadenaBuscar, bool verEliminados = false)
        {
            var result = _cajaServicio.GetByFilter(new CajaFilterDTO
            {
                CadenaBuscar = cadenaBuscar,
                VerEliminados = verEliminados,
                EmpresaId = Properties.Settings.Default.EmpresaId,
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
                dgvGrilla.Columns["Descripcion"].HeaderText = "Caja";
                dgvGrilla.Columns["Descripcion"].DisplayIndex = 1;
                dgvGrilla.Columns["Descripcion"].ReadOnly = true;

                dgvGrilla.Columns["PermiteGastos"].Visible = true;
                dgvGrilla.Columns["PermiteGastos"].Width = 40;
                dgvGrilla.Columns["PermiteGastos"].HeaderText = "Gtos";
                dgvGrilla.Columns["PermiteGastos"].DisplayIndex = 2;
                dgvGrilla.Columns["PermiteGastos"].ReadOnly = true;

                dgvGrilla.Columns["PermitePagosProveedor"].Visible = true;
                dgvGrilla.Columns["PermitePagosProveedor"].Width = 40;
                dgvGrilla.Columns["PermitePagosProveedor"].HeaderText = "Prov";
                dgvGrilla.Columns["PermitePagosProveedor"].DisplayIndex = 3;
                dgvGrilla.Columns["PermitePagosProveedor"].ReadOnly = true;

                dgvGrilla.Columns["AceptaMedioPagoEfectivo"].Visible = true;
                dgvGrilla.Columns["AceptaMedioPagoEfectivo"].Width = 40;
                dgvGrilla.Columns["AceptaMedioPagoEfectivo"].HeaderText = "Efec";
                dgvGrilla.Columns["AceptaMedioPagoEfectivo"].DisplayIndex = 4;
                dgvGrilla.Columns["AceptaMedioPagoEfectivo"].ReadOnly = true;
                                   
                dgvGrilla.Columns["AceptaMedioPagoCheque"].Visible = true;
                dgvGrilla.Columns["AceptaMedioPagoCheque"].Width = 40;
                dgvGrilla.Columns["AceptaMedioPagoCheque"].HeaderText = "Cheq";
                dgvGrilla.Columns["AceptaMedioPagoCheque"].DisplayIndex = 5;
                dgvGrilla.Columns["AceptaMedioPagoCheque"].ReadOnly = true;
                                   
                dgvGrilla.Columns["AceptaMedioPagoTarjeta"].Visible = true;
                dgvGrilla.Columns["AceptaMedioPagoTarjeta"].Width = 40;
                dgvGrilla.Columns["AceptaMedioPagoTarjeta"].HeaderText = "Tarj";
                dgvGrilla.Columns["AceptaMedioPagoTarjeta"].DisplayIndex = 6;
                dgvGrilla.Columns["AceptaMedioPagoTarjeta"].ReadOnly = true;
                                   
                dgvGrilla.Columns["AceptaMedioPagoTransferencia"].Visible = true;
                dgvGrilla.Columns["AceptaMedioPagoTransferencia"].Width = 40;
                dgvGrilla.Columns["AceptaMedioPagoTransferencia"].HeaderText = "Trans";
                dgvGrilla.Columns["AceptaMedioPagoTransferencia"].DisplayIndex = 7;
                dgvGrilla.Columns["AceptaMedioPagoTransferencia"].ReadOnly = true;
                                   
                dgvGrilla.Columns["AceptaMedioPagoCtaCte"].Visible = true;
                dgvGrilla.Columns["AceptaMedioPagoCtaCte"].Width = 40;
                dgvGrilla.Columns["AceptaMedioPagoCtaCte"].HeaderText = "Cta Cte";
                dgvGrilla.Columns["AceptaMedioPagoCtaCte"].DisplayIndex = 8;
                dgvGrilla.Columns["AceptaMedioPagoCtaCte"].ReadOnly = true;


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

        private void BtnAgregarQuitarPuestosTrabajos_Click(object sender, EventArgs e)
        {
            if (base.dgvGrilla.RowCount > 0)
            {
                var formulario = new _00155_Caja_PuestoTrabajo(base._seguridadServicio,
                                                               base._configuracionServicio,
                                                               base._logger,
                                                               Program.Container.GetInstance<ICajaPuestoTrabajoServicio>(),
                                                               Program.Container.GetInstance<ICajaServicio>(),
                                                               base.EntidadId.Value);

                FormularioSeguridad.VerificarAcceso(formulario, base._seguridadServicio, base._logger, base._configuracionDTO);
            }
            else
            {
                MessageBox.Show("No hay Cajas cargadas.", "Atención",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
