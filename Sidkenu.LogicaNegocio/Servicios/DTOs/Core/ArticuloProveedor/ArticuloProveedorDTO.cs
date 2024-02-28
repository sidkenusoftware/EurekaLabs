namespace Sidkenu.LogicaNegocio.Servicios.DTOs.Core.ArticuloProveedor
{
    public class ArticuloProveedorDTO
    {
        public Guid? Id { get; set; }
        public Guid? ProveedorId { get; set; }
        public string Proveedor { get; set; }
        public string CodigoProveedor { get; set; }
        public string Cuit { get; set; }

        public bool EstaBD { get; set; }
        public bool Eliminar { get; set; }
    }
}
