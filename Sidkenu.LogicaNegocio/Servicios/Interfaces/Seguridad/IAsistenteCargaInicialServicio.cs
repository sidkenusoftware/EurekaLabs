using Sidkenu.LogicaNegocio.Servicios.DTOs.Base;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Seguridad.AsistenteCargaInicial;

namespace Sidkenu.LogicaNegocio.Servicios.Interface.Seguridad
{
    public interface IAsistenteCargaInicialServicio
    {
        ResultDTO Add(AsistenteDTO entidad);
    }
}
