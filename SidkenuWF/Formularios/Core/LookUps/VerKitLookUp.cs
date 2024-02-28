using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.ArticuloKit;
using SidkenuWF.Formularios.Base;
using SidkenuWF.Formularios.Base.Constantes;

namespace SidkenuWF.Formularios.Core.LookUps
{
    public partial class VerKitLookUp : FormularioComun
    {
        private List<ArticuloKitDTO> _articuloKits;

        public VerKitLookUp(List<ArticuloKitDTO> articuloKits)
        {
            InitializeComponent();
            
            _articuloKits = articuloKits;
            
            base.TituloFormulario = FormularioConstantes.Titulo;
            base.Titulo = "Kit";
        }

        private void VerStockLookUp_Load(object sender, EventArgs e)
        {
            dgvGrilla.DataSource = _articuloKits.ToList();

            FormatearGrilla();
        }

        private void FormatearGrilla()
        {
            dgvGrilla.Columns["Id"].Visible = false;
            dgvGrilla.Columns["Id"].DisplayIndex = 0;

            dgvGrilla.Columns["SubTotal"].Visible = false;
            dgvGrilla.Columns["SubTotal"].DisplayIndex = 1;

            dgvGrilla.Columns["PrecioCosto"].Visible = false;
            dgvGrilla.Columns["PrecioCosto"].DisplayIndex = 2;

            dgvGrilla.Columns["PrecioPublico"].Visible = false;
            dgvGrilla.Columns["PrecioPublico"].DisplayIndex = 3;

            dgvGrilla.Columns["ArticuloHijoId"].Visible = false;
            dgvGrilla.Columns["ArticuloHijoId"].DisplayIndex = 4;

            dgvGrilla.Columns["ExisteBase"].Visible = false;
            dgvGrilla.Columns["ExisteBase"].DisplayIndex = 5;

            dgvGrilla.Columns["EstaSeleccionado"].Visible = false;
            dgvGrilla.Columns["EstaSeleccionado"].DisplayIndex = 6;

            dgvGrilla.Columns["EstaEliminado"].Visible = false;
            dgvGrilla.Columns["EstaEliminado"].DisplayIndex = 7;

            dgvGrilla.Columns["Codigo"].Visible = true;
            dgvGrilla.Columns["Codigo"].Width = 100;
            dgvGrilla.Columns["Codigo"].HeaderText = "Codigo";
            dgvGrilla.Columns["Codigo"].DisplayIndex = 8;
            dgvGrilla.Columns["Codigo"].ReadOnly = true;

            dgvGrilla.Columns["Descripcion"].Visible = true;
            dgvGrilla.Columns["Descripcion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvGrilla.Columns["Descripcion"].HeaderText = "Articulo";
            dgvGrilla.Columns["Descripcion"].DisplayIndex = 9;
            dgvGrilla.Columns["Descripcion"].ReadOnly = true;

            dgvGrilla.Columns["Cantidad"].Visible = true;
            dgvGrilla.Columns["Cantidad"].Width = 100;
            dgvGrilla.Columns["Cantidad"].HeaderText = "Cantidad";
            dgvGrilla.Columns["Cantidad"].DisplayIndex = 10;
            dgvGrilla.Columns["Cantidad"].ReadOnly = true;
            dgvGrilla.Columns["Cantidad"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvGrilla.Columns["Cantidad"].DefaultCellStyle.Format = "N6";
        }
    }
}
