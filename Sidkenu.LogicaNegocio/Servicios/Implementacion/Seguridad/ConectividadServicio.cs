using Microsoft.Data.SqlClient;
using MySqlConnector;
using Sidkenu.AccesoDatos.CadenaConexion;
using Sidkenu.AccesoDatos.CadenaConexion.Constantes;
using Sidkenu.LogicaNegocio.Servicios.Interface.Seguridad;

namespace Sidkenu.LogicaNegocio.Servicios.Implementacion.Seguridad
{
    public class ConectividadServicio : IConectividadServicio
    {
        private readonly IConexionServicio _conexionServicio;

        public ConectividadServicio()
        {
            _conexionServicio = new ConexionServicio();
        }

        public bool VerificarSiBaseDatosEstaOperativa()
        {
            switch (MotoBaseDatos.Obtener)
            {
                case TipoMotorBaseDatos.SqlServer:
                    {
                        try
                        {
                            SqlConnection sqlConnection = new SqlConnection(
                                _conexionServicio.ObtenerCadenaConexion(TipoMotorBaseDatos.SqlServer));

                            sqlConnection.Open();

                            if (sqlConnection.State == System.Data.ConnectionState.Open)
                            {
                                sqlConnection.Close();
                                return true;
                            }
                        }
                        catch (SqlException sqlEx)
                        {
                            return false;
                        }
                    }
                    break;
                case TipoMotorBaseDatos.MySql:
                    {
                        try
                        {
                            MySqlConnection mySqlConnection = new MySqlConnection(
                            _conexionServicio.ObtenerCadenaConexion(TipoMotorBaseDatos.SqlServer));

                            mySqlConnection.Open();

                            if (mySqlConnection.State == System.Data.ConnectionState.Open)
                            {
                                mySqlConnection.Close();
                                return true;
                            }
                        }
                        catch (MySqlException ex)
                        {
                            return false;
                        }
                    }
                    break;
                default:
                    return false;
            }

            return false;
        }
    }
}
