using Sidkenu.LogicaNegocio.Servicios.DTOs.Base;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Seguridad.Empresa;

namespace Sidkenu.LogicaNegocio.Servicios.Interface.Seguridad
{
    public interface IEmpresaServicio
    {
        ResultDTO Add(EmpresaPersistenciaDTO entidad, string user);
        ResultDTO Update(EmpresaPersistenciaDTO entidad, string user);
        ResultDTO Delete(EmpresaDeleteDTO deleteDTO, string user);

        // ================================================================= //

        ResultDTO GetById(Guid id);
        ResultDTO GetByFilter(EmpresaFilterDTO filter);
        ResultDTO GetAll();
    }
}
