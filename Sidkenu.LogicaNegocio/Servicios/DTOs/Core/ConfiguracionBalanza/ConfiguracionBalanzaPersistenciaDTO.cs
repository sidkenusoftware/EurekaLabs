using Sidkenu.LogicaNegocio.Servicios.DTOs.Base;

namespace Sidkenu.LogicaNegocio.Servicios.DTOs.Core.ConfiguracionBalanza
{
    public class ConfiguracionBalanzaPersistenciaDTO : EntidadBaseDTO
    {
        // Propiedades
        public Guid EmpresaId { get; set; }

        public int CodigoIdentificarImporte { get; set; }
        public int DecimalesImporte { get; set; }

        public int CodigoIdentificarPeso { get; set; }
        public int DecimalPeso { get; set; }

        public bool ConvierteUnidadPeso { get; set; }
        public decimal Equivalencia { get; set; }

        public int LongitudTotal { get; set; }
        public int InicioIdentificarTipo { get; set; }
        public int CantidadIdentificarTipo { get; set; }
        public int InicioIdentificarCodigoArcitulo { get; set; }
        public int CantidadIdentificarCodigoArcitulo { get; set; }
        public int InicioIdentificarImportePrecio { get; set; }
        public int CantidadIdentificarImportePrecio { get; set; }
    }
}
