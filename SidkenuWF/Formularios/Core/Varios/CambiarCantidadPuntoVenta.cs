using SidkenuWF.Formularios.Base;

namespace SidkenuWF.Formularios.Core.Varios
{
    public partial class CambiarCantidadPuntoVenta : FormularioComun
    {
        public decimal Cantidad => nudCantidadArticulos.Value;
        public bool RealizoAlgunCambio { get; private set; }

        public CambiarCantidadPuntoVenta(string articulo, decimal cantidad)
            : this()
        {
            lblArticulo.Text = articulo;
            nudCantidadArticulos.Value = cantidad;
        }

        public CambiarCantidadPuntoVenta()
        {
            InitializeComponent();

            RealizoAlgunCambio = false;
        }

        private void BtnEjecutar_Click(object sender, EventArgs e)
        {
            if (nudCantidadArticulos.Value == 0)
            {
                MessageBox.Show("La cantidad no puede ser CERO", "Atención");
                return;
            }

            RealizoAlgunCambio = true;

            this.Close();
        }
    }
}
