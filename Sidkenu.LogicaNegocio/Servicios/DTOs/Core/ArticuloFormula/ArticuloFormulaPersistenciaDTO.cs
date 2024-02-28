namespace Sidkenu.LogicaNegocio.Servicios.DTOs.Core.ArticuloFormula
{
    public class ArticuloFormulaPersistenciaDTO
    {
        public Guid EmpresaId { get; set; }
        public Guid ArticuloBaseId { get; set; }
        public DateTime FechaVigencia { get; set; }
        public List<ArticuloFormulaDTO> Articulos { get; set; }
    }
}
