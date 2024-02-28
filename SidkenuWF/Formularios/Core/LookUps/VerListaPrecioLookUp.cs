using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.Articulo;
using SidkenuWF.Formularios.Base;
using SidkenuWF.Formularios.Base.Constantes;

namespace SidkenuWF.Formularios.Core.LookUps
{
    public partial class VerListaPrecioLookUp : FormularioComun
    {
        private List<ArticuloPrecioDTO> _precios;

        public VerListaPrecioLookUp(List<ArticuloPrecioDTO> precios)
        {
            InitializeComponent();

            _precios = precios;

            base.TituloFormulario = FormularioConstantes.Titulo;
            base.Titulo = "Lista de Precios";
        }

        private void VerListaPrecioLookUp_Load(object sender, EventArgs e)
        {
            dgvGrilla.DataSource = _precios.ToList();

            FormatearGrilla();
        }

        private void FormatearGrilla()
        {
            dgvGrilla.Columns["Id"].Visible = false;
            dgvGrilla.Columns["ListaPrecioId"].Visible = false;
            dgvGrilla.Columns["FechaActualizacion"].Visible = false;

            dgvGrilla.Columns["ListaPrecio"].Visible = true;
            dgvGrilla.Columns["ListaPrecio"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvGrilla.Columns["ListaPrecio"].HeaderText = "Lista de Precio";
            dgvGrilla.Columns["ListaPrecio"].DisplayIndex = 0;
            dgvGrilla.Columns["ListaPrecio"].ReadOnly = true;

            dgvGrilla.Columns["Monto"].Visible = true;
            dgvGrilla.Columns["Monto"].Width = 150;
            dgvGrilla.Columns["Monto"].HeaderText = "Monto";
            dgvGrilla.Columns["Monto"].DisplayIndex = 1;
            dgvGrilla.Columns["Monto"].ReadOnly = true;
            dgvGrilla.Columns["Monto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvGrilla.Columns["Monto"].DefaultCellStyle.Format = "C";
        }
    }
}
