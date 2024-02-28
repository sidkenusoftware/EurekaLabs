namespace Sidkenu.LogicaNegocio.Servicios.DTOs.Core.Comprobante
{
    public class ComprobanteVentaDTO : ComprobanteDTO
    {
        public string ApyNomCliente => $"{Cliente.RazonSocial}";

        public string FechaStr => Fecha.ToShortDateString();

        
    }
}
