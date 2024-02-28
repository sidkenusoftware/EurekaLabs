using Sidkenu.AccesoDatos.CadenaConexion.Constantes;

namespace Sidkenu.AccesoDatos.CadenaConexion
{
    public class ConexionMySQL : Conexion
    {
        protected override string Servidor => ObtenerServidor(Ambiente.Obtener);
        protected override string BaseDatos => $"{base.BaseDatos}_{Enum.GetName(typeof(TipoAmbiente), Ambiente.Obtener)[..1]}";
        protected override string Usuario => "sa";
        protected override string Password => "P$assword";

        private readonly string _port = "3306";

        public override string Obtener => $"server={Servidor};" +
            $"port={_port}; " +
            $"database={BaseDatos}; " +
            $"user={Usuario}" +
            $"password={Password}";

        private string ObtenerServidor(TipoAmbiente ambiente)
        {
            var servidor = string.Empty;

            switch (ambiente)
            {
                case TipoAmbiente.Desarrollo:
                    servidor = @"localhost";
                    break;
                case TipoAmbiente.Testing:
                    servidor = @"localhost";
                    break;
                case TipoAmbiente.Produccion:
                    servidor = @"localhost";
                    break;
            }

            return servidor;
        }
    }
}
