namespace SidkenuWF.Formularios.Core.Varios
{
    public class MyListUserControl<T> : List<T> where T : UserControl
    {
        public event EventHandler<ItemCtrolAddedEventArgs<T>> ItemAdded;
        public event EventHandler<ItemCtrolRemovedEventArgs<T>> ItemRemoved;

        // Método para agregar elementos a la lista y disparar el evento
        public new void Add(T item)
        {
            base.Add(item);
            OnItemAdded(new ItemCtrolAddedEventArgs<T>(item));
        }

        public new void Remove(T item)
        {
            base.Remove(item);
            OnItemRemoved(new ItemCtrolRemovedEventArgs<T>(item));
        }

        protected virtual void OnItemRemoved(ItemCtrolRemovedEventArgs<T> e)
        {
            ItemRemoved?.Invoke(this, e);
        }

        // Método para disparar el evento
        protected virtual void OnItemAdded(ItemCtrolAddedEventArgs<T> e)
        {
            ItemAdded?.Invoke(this, e);
        }
    }

    public class ItemCtrolAddedEventArgs<T> : EventArgs
    {
        public T Item { get; }

        public ItemCtrolAddedEventArgs(T item)
        {
            Item = item;
        }
    }

    public class ItemCtrolRemovedEventArgs<T> : EventArgs
    {
        public T Item { get; }

        public ItemCtrolRemovedEventArgs(T item)
        {
            Item = item;
        }
    }
}
