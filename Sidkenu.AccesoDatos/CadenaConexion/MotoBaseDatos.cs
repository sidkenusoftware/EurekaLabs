using Sidkenu.AccesoDatos.CadenaConexion.Constantes;

namespace Sidkenu.AccesoDatos.CadenaConexion
{
    public static class MotoBaseDatos
    {
        public static TipoMotorBaseDatos Obtener => TipoMotorBaseDatos.SqlServer;
    }
}
