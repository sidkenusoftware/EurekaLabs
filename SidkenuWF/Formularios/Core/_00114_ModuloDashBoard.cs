using Serilog;
using Sidkenu.LogicaNegocio.Servicios.Interface.Seguridad;
using SidkenuWF.Formularios.Base;
// using System.Windows.Forms.DataVisualization;

namespace SidkenuWF.Formularios.Core
{
    public partial class _00114_ModuloDashboard : FormularioMenuLateral
    {
        public _00114_ModuloDashboard(ISeguridadServicio seguridadServicio,
                                      IConfiguracionServicio configuracionServicio,
                                      ILogger logger)
                                      : base(seguridadServicio, configuracionServicio, logger)
        {
            InitializeComponent();

            ctrolDashCaja.Titulo = "Recaudacion";
            ctrolDashCaja.ColorTitulo = Color.Yellow;
            ctrolDashCaja.Valor = "$ 1500,00";
            ctrolDashCaja.Icono = FontAwesome.Sharp.IconChar.SackDollar;

            ctrolDashCantClientes.Titulo = "Cant. Clientes";
            ctrolDashCantClientes.ColorTitulo = Color.Orange;
            ctrolDashCantClientes.Valor = "$ 150";
            ctrolDashCantClientes.Icono = FontAwesome.Sharp.IconChar.Users;

            ctrolDashTotalVentas.Titulo = "Total Ventas";
            ctrolDashTotalVentas.ColorTitulo = Color.Beige;
            ctrolDashTotalVentas.Valor = "$ 150000000,00";
            ctrolDashTotalVentas.Icono = FontAwesome.Sharp.IconChar.SackDollar;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
