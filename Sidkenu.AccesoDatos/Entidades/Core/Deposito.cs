using Sidkenu.AccesoDatos.Entidades.Base;
using Sidkenu.AccesoDatos.Entidades.Seguridad;
using Sidkenu.AccesoDatos.Constantes.Enum;

namespace Sidkenu.AccesoDatos.Entidades.Core
{
    public class Deposito : EntidadBase
    {
        // Propiedades
        public Guid EmpresaId { get; set; }
        public Guid? PersonaId { get; set; }

        public string Abreviatura { get; set; }
        public string Descripcion { get; set; }
        public string Direccion { get; set; }
        public TipoDeposito TipoDeposito { get; set; }
        public bool Predeterminado { get; set; }

        // Propiedades de Navegacion
        public virtual Empresa Empresa { get; set; }

        public virtual Persona Persona { get; set; }

        public virtual List<ArticuloDeposito> ArticuloDepositos { get; set; }

        public virtual List<ConfiguracionCore> ConfiguracionCoreDepositoPorDefectoParaVentas { get; set; }
        public virtual List<ConfiguracionCore> ConfiguracionCoreDepositoPorDefectoParaCompras { get; set; }

        public virtual List<OrdenFabricacion> OrdenFabricacionOrigenes { get; set; }
        public virtual List<OrdenFabricacion> OrdenFabricacionDestinos { get; set; }
    }
}
