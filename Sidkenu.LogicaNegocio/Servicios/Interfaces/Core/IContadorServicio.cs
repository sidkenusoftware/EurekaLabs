using Sidkenu.AccesoDatos.Constantes.Enum;

namespace Sidkenu.LogicaNegocio.Servicios.Interface.Core
{
    public interface IContadorServicio
    {
        long ObtenerNumero(TipoContador tipoContador, Guid empresaId, string user);
    }
}
