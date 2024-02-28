namespace SidkenuWF.Formularios.Core.Model
{
    public class DetallePedidoVM : BaseVM
    {
        public event EventHandler CantidadChange;

        public DetallePedidoVM()
        {
        }

        public Guid ArticuloId { get; set; }        
        public string Codigo { get; set; }
        public string Descripcion { get; set; }

        private decimal _cantidad;
        public decimal Cantidad 
        {
            get { return _cantidad; }
            set 
            {
                if (_cantidad != value)
                {
                    _cantidad = value;
                    OnCantidadChange();
                }
            }
        }

        protected virtual void OnCantidadChange()
        {
            CantidadChange?.Invoke(this, EventArgs.Empty);
        }

        public decimal PrecioCosto { get; set; }
        public decimal Impuesto { get; set; }
        public decimal SubTotal => PrecioCosto * Cantidad;
    }
}
