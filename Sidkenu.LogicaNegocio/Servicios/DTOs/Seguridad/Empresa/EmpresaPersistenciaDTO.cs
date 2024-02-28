using Sidkenu.LogicaNegocio.Servicios.DTOs.Base;

namespace Sidkenu.LogicaNegocio.Servicios.DTOs.Seguridad.Empresa
{
    public class EmpresaPersistenciaDTO : EntidadBaseDTO
    {
        public Guid LocalidadId { get; set; }
        public Guid TipoResponsabilidadId { get; set; }
        public Guid IngresoBrutoId { get; set; }

        public int Codigo { get; set; }

        public string Abreviatura { get; set; }

        public string Descripcion { get; set; }

        public string Direccion { get; set; }

        public string Telefono { get; set; }

        public string Mail { get; set; }

        public string Referente { get; set; }

        public string Cuit { get; set; }

        public DateTime FechaInicioActividad { get; set; }

        public string NroIngresoBruto { get; set; }

        public byte[] Logo { get; set; }
    }
}
