namespace SidkenuWF.Formularios.Core.Model
{
    public class MyListViewModel<T> : List<T> where T : BaseVM
    {
        public event EventHandler<ItemAddedEventArgs<T>> ItemAdded;
        public event EventHandler<ItemRemovedEventArgs<T>> ItemRemoved;

        // Método para agregar elementos a la lista y disparar el evento
        public new void Add(T item)
        {
            base.Add(item);
            OnItemAdded(new ItemAddedEventArgs<T>(item));
        }

        public new void Remove(T item)
        {
            base.Remove(item);
            OnItemRemoved(new ItemRemovedEventArgs<T>(item));
        }

        protected virtual void OnItemRemoved(ItemRemovedEventArgs<T> e)
        {
            ItemRemoved?.Invoke(this, e);
        }

        // Método para disparar el evento
        protected virtual void OnItemAdded(ItemAddedEventArgs<T> e)
        {
            ItemAdded?.Invoke(this, e);
        }
    }

    public class ItemAddedEventArgs<T> : EventArgs
    {
        public T Item { get; }

        public ItemAddedEventArgs(T item)
        {
            Item = item;
        }
    }

    public class ItemRemovedEventArgs<T> : EventArgs
    {
        public T Item { get; }

        public ItemRemovedEventArgs(T item)
        {
            Item = item;
        }
    }
}