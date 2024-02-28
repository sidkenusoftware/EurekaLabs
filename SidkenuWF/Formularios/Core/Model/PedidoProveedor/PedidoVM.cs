namespace SidkenuWF.Formularios.Core.Model
{
    public class PedidoVM : BaseVM
    {
        public PedidoVM()
        {
            Detalles ??= new MyListViewModel<DetallePedidoVM>();
        }

        public MyListViewModel<DetallePedidoVM> Detalles { get; set; }
    }
}
