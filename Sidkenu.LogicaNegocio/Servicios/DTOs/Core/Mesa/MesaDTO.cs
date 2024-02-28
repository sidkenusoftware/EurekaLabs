using Sidkenu.AccesoDatos.Constantes.Enum;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Base;

namespace Sidkenu.LogicaNegocio.Servicios.DTOs.Core.Mesa
{
    public class MesaDTO : EntidadBaseDTO
    {
        public Guid SalonId { get; set; }
        public string Salon { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public EstadoMesa EstadoMesa { get; set; }
    }
}
