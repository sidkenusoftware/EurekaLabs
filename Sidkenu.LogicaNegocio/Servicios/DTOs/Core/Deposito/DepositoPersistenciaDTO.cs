using Sidkenu.AccesoDatos.Constantes.Enum;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Base;

namespace Sidkenu.LogicaNegocio.Servicios.DTOs.Core.Deposito
{
    public class DepositoPersistenciaDTO : EntidadBaseDTO
    {
        public Guid EmpresaId { get; set; }
        public Guid? PersonaId { get; set; }

        public string Abreviatura { get; set; }
        public string Descripcion { get; set; }
        public string Direccion { get; set; }
        public TipoDeposito TipoDeposito { get; set; }
    }
}
