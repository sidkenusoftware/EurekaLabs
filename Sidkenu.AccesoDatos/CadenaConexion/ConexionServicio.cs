using Sidkenu.AccesoDatos.CadenaConexion.Constantes;

namespace Sidkenu.AccesoDatos.CadenaConexion
{
    public class ConexionServicio : IConexionServicio
    {
        private readonly Dictionary<TipoMotorBaseDatos, string> _diccionarioMotor;

        public ConexionServicio()
        {
            _diccionarioMotor = new Dictionary<TipoMotorBaseDatos, string>();
            CargarDiccionario();
        }

        private void CargarDiccionario()
        {
            _diccionarioMotor.Add(TipoMotorBaseDatos.SqlServer, "Sidkenu.AccesoDatos.CadenaConexion.ConexionSqlServer");
            _diccionarioMotor.Add(TipoMotorBaseDatos.MySql, "Sidkenu.AccesoDatos.CadenaConexion.ConexionMySQL");
        }

        public string ObtenerCadenaConexion(TipoMotorBaseDatos tipoMotorBase)
        {
            // Valida que este en el diccionario
            if (!_diccionarioMotor.TryGetValue(tipoMotorBase, out string valor))
            {
                throw new Exception("No se encontro el Motor de base de datos seleccionado");
            }

            // Valida el tipo de conexion (clase)
            var tipoConexion = Type.GetType(valor) ?? throw new Exception("Ocurrio un error al obtener el tipo de Conexion");

            var conexionResult = Activator.CreateInstance(tipoConexion) as Conexion;

            return conexionResult.Obtener;
        }
    }
}

