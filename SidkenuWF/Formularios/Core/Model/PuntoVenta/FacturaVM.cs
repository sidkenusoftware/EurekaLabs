using Sidkenu.AccesoDatos.Constantes;

namespace SidkenuWF.Formularios.Core.Model
{
    public class FacturaVM : BaseVM
    {
        public FacturaVM()
        {
            Detalles ??= new MyListViewModel<DetalleVM>();        
        }        

        public MyListViewModel<DetalleVM> Detalles { get; set; }


        public decimal SubTotal => Detalles.Sum(x => x.SubTotal);

        private decimal _descuento;

        public decimal Descuento
        {
            set
            {
                _descuento = Porcentaje.Calcular(SubTotal, value);
            }

            get
            {
                return _descuento;
            }
        }

        public decimal Total => SubTotal - _descuento;
    }
}
