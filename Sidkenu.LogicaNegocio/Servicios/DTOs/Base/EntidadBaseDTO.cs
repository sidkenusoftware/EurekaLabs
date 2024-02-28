namespace Sidkenu.LogicaNegocio.Servicios.DTOs.Base
{
    public abstract class EntidadBaseDTO
    {
        public Guid Id { get; set; }

        public bool EstaEliminado { get; set; } = false;

        public bool EstaSeleccionado { get; set; } = false;
    }
}
