using Sidkenu.AccesoDatos.CadenaConexion.Constantes;

namespace Sidkenu.AccesoDatos.CadenaConexion
{
    public interface IConexionServicio
    {
        // Metodo
        string ObtenerCadenaConexion(TipoMotorBaseDatos tipoMotorBase);
    }
}
