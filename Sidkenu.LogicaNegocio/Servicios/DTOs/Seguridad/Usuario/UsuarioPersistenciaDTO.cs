namespace Sidkenu.LogicaNegocio.Servicios.DTOs.Seguridad.Usuario
{
    public class UsuarioPersistenciaDTO
    {
        public Guid PersonaId { get; set; }

        public string PersonaNombre { get; set; }

        public string PersonaApellido { get; set; }

        public bool InicioPorPrimeraVez { get; set; }
    }
}
