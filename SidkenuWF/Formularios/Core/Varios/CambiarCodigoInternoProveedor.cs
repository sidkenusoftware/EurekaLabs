using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.ArticuloProveedor;
using SidkenuWF.Formularios.Base;

namespace SidkenuWF.Formularios.Core.Varios
{
    public partial class CambiarCodigoInternoProveedor : FormularioComun
    {
        public CambiarCodigoInternoProveedor()
        {
            InitializeComponent();
        }

        public CambiarCodigoInternoProveedor(ArticuloProveedorDTO articuloProveedor)
            : this()
        {
            ArticuloProveedor = articuloProveedor;
            this.Titulo = "Proveedor";
            this.Logo = FontAwesome.Sharp.IconChar.Truck;
            this.lblProveedor.Text = articuloProveedor.Proveedor;
            txtCodigoProveedor.Text = articuloProveedor.CodigoProveedor;
            
        }

        public ArticuloProveedorDTO ArticuloProveedor { get; set; }

        private void BtnEjecutar_Click(object sender, EventArgs e)
        {
            ArticuloProveedor.CodigoProveedor = txtCodigoProveedor.Text;

            this.Close();
        }

        private void CambiarCodigoInternoProveedor_Activated(object sender, EventArgs e)
        {
            txtCodigoProveedor.SelectAll();
            txtCodigoProveedor.Focus();
        }
    }
}
