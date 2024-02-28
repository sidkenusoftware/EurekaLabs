namespace Sidkenu.LogicaNegocio.Servicios.DTOs.Core.ArticuloVariante
{
    public class ArticuloVarianteValorPersistenciaDTO
    {
        public Guid ArticuloId { get; set; }
        public Guid VarianteValor1Id { get; set; }
        public Guid VarianteValor2Id { get; set; }

        public bool UtilizaPrecioStockIndividual { get; set; }

        public decimal Precio { get; set; }
        public decimal Stock { get; set; }
    }
}
