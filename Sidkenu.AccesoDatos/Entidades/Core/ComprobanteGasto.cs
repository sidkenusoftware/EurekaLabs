namespace Sidkenu.AccesoDatos.Entidades.Core
{
    public class ComprobanteGasto : Comprobante
    {
        // Propiedades
        public Guid TipoGastoId { get; set; }
        public string Descripcion { get; set; }


        // Propiedades de Navegacion
        public virtual TipoGasto TipoGasto { get; set; }
    }
}
