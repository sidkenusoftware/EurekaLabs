using Sidkenu.AccesoDatos.Constantes;
using Sidkenu.AccesoDatos.Constantes.Enum;
using SidkenuWF.Formularios.Core.Model.PuntoVenta;

namespace SidkenuWF.Formularios.Core.Model
{
    public class DetalleVM : BaseVM
    {
        public event EventHandler CantidadChange;

        public MyListViewModel<DetalleTemporalVM> DetalleItems { get; set; }

        public DetalleVM()
        {
            DetalleItems ??= new MyListViewModel<DetalleTemporalVM>();
        }

        public Guid? ArticuloId { get; set; }
        public Guid? ListaPrecioId { get; set; }
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

        public decimal PrecioPublico { get; set; }
        public decimal Descuento { get; set; }
        public decimal Impuesto { get; set; }                        
        public decimal SubTotal => (PrecioPublico * Cantidad) - Porcentaje.Calcular((PrecioPublico * Cantidad), Descuento);

        public TipoItemFactura TipoItem { get; set; }

        public byte[] Foto { get; set; }

        public DateTime FechaEntrega { get; set; }

        public string CodigoFabricacion { get; set; }
    }
}
