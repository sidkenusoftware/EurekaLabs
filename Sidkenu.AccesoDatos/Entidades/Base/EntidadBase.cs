namespace Sidkenu.AccesoDatos.Entidades.Base
{
    public class EntidadBase
    {
        public Guid Id { get; set; }
        public string User { get; set; } = string.Empty;
        public bool EstaEliminado { get; set; } = false;
    }
}
