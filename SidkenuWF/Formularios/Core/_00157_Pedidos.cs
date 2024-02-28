using FontAwesome.Sharp;
using Serilog;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.Pedido;
using Sidkenu.LogicaNegocio.Servicios.Interface.Core;
using Sidkenu.LogicaNegocio.Servicios.Interface.Seguridad;
using SidkenuWF.Formularios.Base;
using SidkenuWF.Formularios.Base.Constantes;

namespace SidkenuWF.Formularios.Core
{
    public partial class _00157_Pedidos : FormularioConsulta
    {
        private readonly IPedidoServicio _pedidoServicio;

        public _00157_Pedidos(ISeguridadServicio seguridadServicio,
                              IConfiguracionServicio configuracionServicio,
                              ILogger logger,
                              IPedidoServicio pedidoServicio)
                              : base(seguridadServicio, configuracionServicio, logger)
        {
            InitializeComponent();

            base.BotoneraLateralVisible = (false, false); // (Panel Botonera, Panel Abrir-Cerrar)
            base.TituloFormulario = Base.Constantes.FormularioConstantes.Titulo;
            base.Titulo = "Pedidos";
            base.Logo = IconChar.Truck;

            base.MostrarBotonBaja = false;
            base.MostrarBotonModificar = false;

            _pedidoServicio = pedidoServicio;
        }

        public override bool EjecutarComandoNuevo(object sender, EventArgs e)
        {
            var formularioAbm = new _00156_PedidoProveedor(base._seguridadServicio,
                                                           base._configuracionServicio,                                                           
                                                           base._logger,
                                                           Program.Container.GetInstance<IArticuloServicio>(),
                                                           Program.Container.GetInstance<IProveedorServicio>(), 
                                                           Program.Container.GetInstance<IPersonaServicio>(),
                                                           Program.Container.GetInstance<IConfiguracionCoreServicio>(),
                                                           Program.Container.GetInstance<IComprobanteServicio>(),
                                                           Program.Container.GetInstance<IArticuloProveedorServicio>());

            FormularioSeguridad.VerificarAcceso(formularioAbm, base._seguridadServicio, base._logger, base._configuracionDTO);

            return true;
        }

        public override void Buscar(string cadenaBuscar, bool verEliminados = false)
        {
            var result = _pedidoServicio.GetByFilter(new PedidoFilterDTO
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

                dgvGrilla.Columns["Numero"].Visible = true;
                dgvGrilla.Columns["Numero"].Width = 150;
                dgvGrilla.Columns["Numero"].HeaderText = "Numero";
                dgvGrilla.Columns["Numero"].DisplayIndex = 0;
                dgvGrilla.Columns["Numero"].ReadOnly = true;

                dgvGrilla.Columns["Fecha"].Visible = true;
                dgvGrilla.Columns["Fecha"].Width = 150;
                dgvGrilla.Columns["Fecha"].HeaderText = "Fecha";
                dgvGrilla.Columns["Fecha"].DisplayIndex = 1;
                dgvGrilla.Columns["Fecha"].ReadOnly = true;

                dgvGrilla.Columns["Proveedor"].Visible = true;
                dgvGrilla.Columns["Proveedor"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvGrilla.Columns["Proveedor"].HeaderText = "Proveedor";
                dgvGrilla.Columns["Proveedor"].DisplayIndex = 2;
                dgvGrilla.Columns["Proveedor"].ReadOnly = true;

                dgvGrilla.Columns["Persona"].Visible = true;
                dgvGrilla.Columns["Persona"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvGrilla.Columns["Persona"].HeaderText = "Apellido y Nombre";
                dgvGrilla.Columns["Persona"].DisplayIndex = 3;
                dgvGrilla.Columns["Persona"].ReadOnly = true;

                dgvGrilla.Columns["Total"].Visible = true;
                dgvGrilla.Columns["Total"].Width = 150;
                dgvGrilla.Columns["Total"].HeaderText = "Total";
                dgvGrilla.Columns["Total"].DisplayIndex = 4;
                dgvGrilla.Columns["Total"].ReadOnly = true;
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
