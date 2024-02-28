using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.Articulo;
using SidkenuWF.Formularios.Base;
using SidkenuWF.Formularios.Base.Constantes;
using SidkenuWF.Formularios.Core.Controles;

namespace SidkenuWF.Formularios.Core.LookUps
{
    public partial class VerStockLookUp : FormularioComun
    {
        private ArticuloDTO _articulo;

        public VerStockLookUp()
        {
            InitializeComponent();

            base.TituloFormulario = FormularioConstantes.Titulo;
            base.Titulo = "Stock Actual";
            base.Logo = FontAwesome.Sharp.IconChar.Box;
        }

        public VerStockLookUp(ArticuloDTO articulo)
            : this()
        {
            _articulo = articulo;
        }

        private void VerStockLookUp_Shown(object sender, EventArgs e)
        {
            CargarDatos(_articulo);
        }

        private void CargarDatos(ArticuloDTO articulo)
        {
            var tabControlStock = new TabControl
            {
                Dock = DockStyle.Fill,
                Location = new Point(0, 59),
                Name = "tabControlStock",
                Padding = new Point(10, 10),
                SelectedIndex = 0,
                Size = new Size(634, 352),
                TabIndex = 1
            };

            var listaEmpresasPorId = articulo.Cantidades.GroupBy(x => x.EmpresaId).Select(x => x.Key).ToList();

            foreach (var empresaId in listaEmpresasPorId.ToList())
            {
                var artDepEmp = articulo.Cantidades.First(x => x.EmpresaId == empresaId);

                var tabPageEmpresa = new TabPage
                {
                    Location = new Point(4, 38),
                    Name = $"tp{empresaId}",
                    Padding = new Padding(3),
                    Size = new Size(626, 310),
                    TabIndex = 0,
                    Text = $"{artDepEmp.Empresa}",
                    UseVisualStyleBackColor = true,
                    BackColor = Color.White,
                };

                var flpStock = new FlowLayoutPanel
                {
                    Dock = DockStyle.Fill,
                    BackColor = Color.WhiteSmoke,
                    Location = new Point(3, 3),
                    Name = $"flpe{empresaId}",
                    Size = new Size(620, 304),                  
                    TabIndex = 0,
                };

                foreach (var artDep in articulo.Cantidades.Where(x => x.EmpresaId == empresaId).ToList())
                {
                    flpStock.Controls.Add(new CtrolVerStock(artDep) { Width = flpStock.Width - 10 });
                }

                tabPageEmpresa.Controls.Add(flpStock);  

                tabControlStock.Controls.Add(tabPageEmpresa);
            }

            pnlContenedor.Controls.Add(tabControlStock);
        }
    }
}
