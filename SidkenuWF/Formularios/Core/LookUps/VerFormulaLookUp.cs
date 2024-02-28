using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.ArticuloFormula;
using SidkenuWF.Formularios.Base;
using SidkenuWF.Formularios.Base.Constantes;

namespace SidkenuWF.Formularios.Core.LookUps
{
    public partial class VerFormulaLookUp : FormularioComun
    {
        private List<ArticuloFormulaDTO> _articuloFormulas;

        public VerFormulaLookUp(List<ArticuloFormulaDTO> articuloFormulas)
        {
            InitializeComponent();
            
            _articuloFormulas = articuloFormulas;
            
            base.TituloFormulario = FormularioConstantes.Titulo;
            base.Titulo = "Formula";
        }

        private void VerStockLookUp_Load(object sender, EventArgs e)
        {
            dgvGrilla.DataSource = _articuloFormulas.ToList();

            FormatearGrilla();
        }

        private void FormatearGrilla()
        {
            dgvGrilla.Columns["Id"].Visible = false;
            dgvGrilla.Columns["Id"].DisplayIndex = 0;

            dgvGrilla.Columns["ArticuloHijoId"].Visible = false;
            dgvGrilla.Columns["ArticuloHijoId"].DisplayIndex = 1;

            dgvGrilla.Columns["ExisteBase"].Visible = false;
            dgvGrilla.Columns["ExisteBase"].DisplayIndex = 2;

            dgvGrilla.Columns["EstaSeleccionado"].Visible = false;
            dgvGrilla.Columns["EstaSeleccionado"].DisplayIndex = 3;

            dgvGrilla.Columns["EstaEliminado"].Visible = false;
            dgvGrilla.Columns["EstaEliminado"].DisplayIndex = 4;

            dgvGrilla.Columns["Codigo"].Visible = true;
            dgvGrilla.Columns["Codigo"].Width = 100;
            dgvGrilla.Columns["Codigo"].HeaderText = "Codigo";
            dgvGrilla.Columns["Codigo"].DisplayIndex = 5;
            dgvGrilla.Columns["Codigo"].ReadOnly = true;

            dgvGrilla.Columns["Descripcion"].Visible = true;
            dgvGrilla.Columns["Descripcion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvGrilla.Columns["Descripcion"].HeaderText = "Articulo";
            dgvGrilla.Columns["Descripcion"].DisplayIndex = 6;
            dgvGrilla.Columns["Descripcion"].ReadOnly = true;

            dgvGrilla.Columns["Cantidad"].Visible = true;
            dgvGrilla.Columns["Cantidad"].Width = 100;
            dgvGrilla.Columns["Cantidad"].HeaderText = "Cantidad";
            dgvGrilla.Columns["Cantidad"].DisplayIndex = 7;
            dgvGrilla.Columns["Cantidad"].ReadOnly = true;
            dgvGrilla.Columns["Cantidad"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvGrilla.Columns["Cantidad"].DefaultCellStyle.Format = "N6";

            dgvGrilla.Columns["Perdida"].Visible = false;
            dgvGrilla.Columns["Perdida"].DisplayIndex = 8;

            dgvGrilla.Columns["TipoValor"].Visible = false;
            dgvGrilla.Columns["TipoValor"].DisplayIndex = 9;
        }
    }
}
