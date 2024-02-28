namespace Sidkenu.AccesoDatos.CadenaConexion
{
    public class Conexion
    {
        // Sql => Servidor - BD - US - PASS
        // MySQL => Servidor - BD - US - PASS - Puerto

        protected virtual string Servidor => ""; // Get
        protected virtual string BaseDatos => "DB_Sidkenu";
        protected virtual string Usuario => "";
        protected virtual string Password => "";

        public virtual string Obtener => "";

        
    }
}
