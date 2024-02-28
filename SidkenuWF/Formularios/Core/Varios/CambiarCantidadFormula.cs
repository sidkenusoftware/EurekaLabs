using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.ArticuloFormula;
using SidkenuWF.Formularios.Base;

namespace SidkenuWF.Formularios.Core.Varios
{
    public partial class CambiarCantidadFormula : FormularioComun
    {
        public ArticuloFormulaDTO ArticuloFormula { get; set; }

        public CambiarCantidadFormula(ArticuloFormulaDTO articuloFormula)
            : this()
        {
            this.ArticuloFormula = articuloFormula;
            nudCantidadArticulos.Value = articuloFormula.Cantidad;
        }

        public CambiarCantidadFormula()
        {
            InitializeComponent();
        }

        private void BtnEjecutar_Click(object sender, EventArgs e)
        {
            this.ArticuloFormula.Cantidad = nudCantidadArticulos.Value;
            this.Close();
        }
    }
}
