namespace Sidkenu.LogicaNegocio.Servicios.DTOs.Core.Comprobante
{
    public class ComprobanteGastoDTO : ComprobanteDTO
    {
        public Guid TipoGastoId { get; set; }
        public string Descripcion { get; set; }
    }
}
