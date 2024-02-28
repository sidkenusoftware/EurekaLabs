namespace Sidkenu.LogicaNegocio.Servicios.DTOs.Core.ArticuloPrecio
{
    public class ArticuloPrecioPersistenciaDTO
    {
        public Guid EmpresaId { get; set; }
        public Guid ArticuloId { get; set; }
        public Guid MarcaId { get; set; }
        public Guid FamiliaId { get; set; }        
        public decimal? PrecioCostoArticulo { get; set; }
        public bool TieneRentabilidad { get; set; }
        public decimal? RentabilidadArticulo { get; set; }

        public bool EsFabricado { get; set; }
    }
}
