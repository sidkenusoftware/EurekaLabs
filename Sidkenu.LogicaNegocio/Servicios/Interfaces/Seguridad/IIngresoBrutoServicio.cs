using Sidkenu.LogicaNegocio.Servicios.DTOs.Base;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Seguridad.IngresoBruto;

namespace Sidkenu.LogicaNegocio.Servicios.Interface.Seguridad
{
    public interface IIngresoBrutoServicio
    {
        ResultDTO Add(IngresoBrutoPersistenciaDTO entidad, string user);
        ResultDTO Update(IngresoBrutoPersistenciaDTO entidad, string user);
        ResultDTO Delete(IngresoBrutoDeleteDTO deleteDTO, string user);

        // ================================================================= //

        ResultDTO GetById(Guid id);
        ResultDTO GetByFilter(IngresoBrutoFilterDTO filter);
        ResultDTO GetAll();
    }
}
