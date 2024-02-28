using Sidkenu.AccesoDatos.Constantes;
using Sidkenu.AccesoDatos.Constantes.Enum;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.ArticuloFormula;
using SidkenuWF.Formularios.Base;

namespace SidkenuWF.Formularios.Core.Varios
{
    public partial class CargarPerdidaPorFabricacion : FormularioComun
    {
        public ArticuloFormulaDTO ArticuloFormula { get; set; }

        public CargarPerdidaPorFabricacion(ArticuloFormulaDTO articuloFormula)
            : this()
        {
            this.ArticuloFormula = articuloFormula;

            nudCantidadActual.Value = articuloFormula.Cantidad;
            nudPerdida.Value = articuloFormula.Perdida;
            nudCantidadFinal.Value = articuloFormula.Cantidad;
            cmbTipoPerdida.SelectedValue = articuloFormula.TipoValor;
        }

        public CargarPerdidaPorFabricacion()
        {
            InitializeComponent();

            PoblarComboBox(cmbTipoPerdida, EnumDescription.GetAll<TipoValor>(), "Descripcion", "Valor");
        }


        private void BtnEjecutar_Click(object sender, EventArgs e)
        {
            this.ArticuloFormula.Cantidad = nudCantidadFinal.Value;
            this.ArticuloFormula.Perdida = nudPerdida.Value;
            this.ArticuloFormula.TipoValor = (TipoValor)cmbTipoPerdida.SelectedValue;

            this.Close();
        }

        private void NudPerdida_ValueChanged(object sender, EventArgs e)
        {
            var tipo = (TipoValor)cmbTipoPerdida.SelectedValue;

            nudCantidadFinal.Value = tipo == TipoValor.Porcentaje
                ? nudCantidadActual.Value + Porcentaje.Calcular(nudCantidadActual.Value, nudPerdida.Value)
                : nudCantidadActual.Value + nudPerdida.Value;
        }
    }
}
