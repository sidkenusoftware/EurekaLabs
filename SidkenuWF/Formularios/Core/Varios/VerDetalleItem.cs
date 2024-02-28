using SidkenuWF.Formularios.Base;
using SidkenuWF.Formularios.Base.Constantes;
using SidkenuWF.Formularios.Core.Model;
using SidkenuWF.Formularios.Core.Model.PuntoVenta;

namespace SidkenuWF.Formularios.Core.Varios
{
    public partial class VerDetalleItem : FormularioComun
    {
        private readonly MyListViewModel<DetalleTemporalVM> _lista;

        public VerDetalleItem()
        {
            InitializeComponent();

            base.Titulo = "Detalle";
            base.TituloFormulario = FormularioConstantes.Titulo;
            base.Logo = FontAwesome.Sharp.IconChar.List;
        }

        public VerDetalleItem(MyListViewModel<DetalleTemporalVM> lista)
            : this()
        {
            _lista = lista;
        }

        private void VerDetalleItem_Load(object sender, EventArgs e)
        {
            dgvGrilla.DataSource = _lista.ToList();

            FormatearGrilla(dgvGrilla);
        }

        private void FormatearGrilla(DataGridView dgvGrilla)
        {
            dgvGrilla.Columns["ArticuloId"].Visible = false;
            dgvGrilla.Columns["ArticuloId"].DisplayIndex = 0;

            dgvGrilla.Columns["Codigo"].Visible = true;
            dgvGrilla.Columns["Codigo"].Width = 70;
            dgvGrilla.Columns["Codigo"].HeaderText = "Código";
            dgvGrilla.Columns["Codigo"].DisplayIndex = 1;
            dgvGrilla.Columns["Codigo"].ReadOnly = true;

            dgvGrilla.Columns["Descripcion"].Visible = true;
            dgvGrilla.Columns["Descripcion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvGrilla.Columns["Descripcion"].HeaderText = "Articulo";
            dgvGrilla.Columns["Descripcion"].DisplayIndex = 2;
            dgvGrilla.Columns["Descripcion"].ReadOnly = true;

            dgvGrilla.Columns["Cantidad"].Visible = true;
            dgvGrilla.Columns["Cantidad"].Width = 70;
            dgvGrilla.Columns["Cantidad"].HeaderText = "Cantidad";
            dgvGrilla.Columns["Cantidad"].DisplayIndex = 3;
            dgvGrilla.Columns["Cantidad"].ReadOnly = true;
            dgvGrilla.Columns["Cantidad"].DefaultCellStyle.Format = "N3";
            dgvGrilla.Columns["Cantidad"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvGrilla.Columns["PrecioPublico"].Visible = true;
            dgvGrilla.Columns["PrecioPublico"].Width = 100;
            dgvGrilla.Columns["PrecioPublico"].HeaderText = "Precio Publico";
            dgvGrilla.Columns["PrecioPublico"].DisplayIndex = 4;
            dgvGrilla.Columns["PrecioPublico"].ReadOnly = true;
            dgvGrilla.Columns["PrecioPublico"].DefaultCellStyle.Format = "C";
            dgvGrilla.Columns["PrecioPublico"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgvGrilla.Columns["SubTotal"].Visible = true;
            dgvGrilla.Columns["SubTotal"].Width = 120;
            dgvGrilla.Columns["SubTotal"].HeaderText = "Sub-Total";
            dgvGrilla.Columns["SubTotal"].DisplayIndex = 5;
            dgvGrilla.Columns["SubTotal"].ReadOnly = true;
            dgvGrilla.Columns["SubTotal"].DefaultCellStyle.Format = "C";
            dgvGrilla.Columns["SubTotal"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgvGrilla.Columns["EstaEliminado"].Visible = false;
            dgvGrilla.Columns["EstaEliminado"].DisplayIndex = 6;

            dgvGrilla.Columns["Id"].Visible = false;
            dgvGrilla.Columns["Id"].DisplayIndex = 7;
        }
    }
}
