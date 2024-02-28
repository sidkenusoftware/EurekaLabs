using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.ArticuloKit;
using SidkenuWF.Formularios.Base;

namespace SidkenuWF.Formularios.Core.Varios
{
    public partial class CambiarCantidadKit : FormularioComun
    {
        public ArticuloKitDTO ArticuloKit { get; set; }

        public CambiarCantidadKit()
        {
            InitializeComponent();
        }

        public CambiarCantidadKit(ArticuloKitDTO articuloKit)
            : this()
        {
            this.ArticuloKit = articuloKit;
            nudCantidadArticulos.Value = articuloKit.Cantidad;
        }

        private void BtnEjecutar_Click(object sender, EventArgs e)
        {
            this.ArticuloKit.Cantidad = nudCantidadArticulos.Value;
            this.Close();
        }
    }
}
