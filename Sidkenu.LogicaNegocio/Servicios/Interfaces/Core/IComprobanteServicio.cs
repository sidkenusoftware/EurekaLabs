using Sidkenu.LogicaNegocio.Servicios.DTOs.Base;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.Comprobante;

namespace Sidkenu.LogicaNegocio.Servicios.Interface.Core
{
    public interface IComprobanteServicio 
    {
        ResultDTO AddOrUpdate(ComprobanteDTO comprobante, string userLogin);
        ResultDTO GetComprobantesPendientesCobroVentaMostrador(Guid id, Guid empresaId);
        ResultDTO GetComprobantesPendientesCobroVentaMostrador(Guid id, Guid empresaId, string cuit);
    }
}
