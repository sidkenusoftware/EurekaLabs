using Sidkenu.LogicaNegocio.Servicios.DTOs.Base;

namespace Sidkenu.LogicaNegocio.Servicios.DTOs.Seguridad.Persona
{
    public class PersonaDTO : EntidadBaseDTO
    {
        // Propiedades
        public string Apellido { get; set; }

        public string Nombre { get; set; }

        public string NombreCompleto => $"{Apellido} {Nombre}";

        public string Direccion { get; set; }

        public string Telefono { get; set; }

        public string Mail { get; set; }

        public string Cuil { get; set; }

        public DateTime FechaNacimiento { get; set; }

        public byte[] Foto { get; set; }

        public string Usuario { get; set; }

        public bool TieneUsuario { get; set; }
    }
}
