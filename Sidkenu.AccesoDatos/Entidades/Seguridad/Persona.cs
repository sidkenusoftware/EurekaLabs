using Sidkenu.AccesoDatos.Entidades.Base;
using Sidkenu.AccesoDatos.Entidades.Core;

namespace Sidkenu.AccesoDatos.Entidades.Seguridad
{
    public class Persona : EntidadBase
    {
        public string Apellido { get; set; }

        public string Nombre { get; set; }

        public string Direccion { get; set; }

        public string Telefono { get; set; }

        public string Mail { get; set; }

        public string Cuil { get; set; }

        public DateTime FechaNacimiento { get; set; }

        public byte[] Foto { get; set; }

        // Propiedades de Navegacion
        public virtual List<Usuario> Usuarios { get; set; }
        public virtual List<EmpresaPersona> EmpresaPersonas { get; set; }
        public virtual List<GrupoPersona> GrupoPersonas { get; set; }
        public virtual List<CajaDetalle> CajaDetalleAperturas { get; set; }
        public virtual List<CajaDetalle> CajaDetalleCierres { get; set; }
        public virtual List<Deposito> Depositos { get; set; }
        public virtual List<Comprobante> Comprobantes { get; set; }
    }
}
