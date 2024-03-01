using Sidkenu.AccesoDatos.CadenaConexion.Constantes;

namespace Sidkenu.AccesoDatos.CadenaConexion
{
    public class ConexionSqlServer : Conexion
    {
        protected override string Servidor => ObtenerServidor(Ambiente.Obtener);
        protected override string BaseDatos => ObtenerBaseDatos(Ambiente.Obtener);
        protected override string Usuario => ObtenerUsuario(Ambiente.Obtener);
        protected override string Password => "P$assword";

        //public override string Obtener => $"Data Source={Servidor}; " +
        //    $"Initial Catalog={BaseDatos}; " +
        //    $"User Id={Usuario}; " +
        //    $"Password={Password}; " +
        //    $"MultipleActiveResultSets=False; " +
        //    $"Encrypt=False; " +
        //    $"TrustServerCertificate=False;";

        public override string Obtener => "Server=(localdb)\\mssqllocaldb;Database=EurekaCommerce;Trusted_Connection=True;MultipleActiveResultSets=true";

        private string ObtenerServidor(TipoAmbiente ambiente)
        {
            var servidor = string.Empty;

            switch (ambiente)
            {
                case TipoAmbiente.Desarrollo:
                    servidor = $@"ELOHIM\SIDKENUSQL";
                    // servidor = $@"DESKTOP-46RS64M";
                    // servidor = $@"DIME-CDAUDI7"; 
                    // servidor = @"DESKTOP-U5EMC52";
                    break;
                case TipoAmbiente.DesarrolloBdExterno:
                    servidor = $@"DB_Sidkenu_D.mssql.somee.com";
                    break;
                case TipoAmbiente.Testing:
                    servidor = $@"";
                    break;
                case TipoAmbiente.Produccion:
                    servidor = $@"";
                    break;
            }

            return servidor;
        }

        private string ObtenerBaseDatos(TipoAmbiente ambiente)
        {
            var baseDatos = string.Empty;

            switch (ambiente)
            {
                case TipoAmbiente.Desarrollo:
                    baseDatos = $"{base.BaseDatos}_{Enum.GetName(typeof(TipoAmbiente), Ambiente.Obtener)[..1]}";
                    break;
                case TipoAmbiente.DesarrolloBdExterno:
                    baseDatos = $"{base.BaseDatos}_{Enum.GetName(typeof(TipoAmbiente), Ambiente.Obtener)[..1]}";
                    break;
                case TipoAmbiente.Testing:
                    baseDatos = $@"";
                    break;
                case TipoAmbiente.Produccion:
                    baseDatos = $@"";
                    break;
            }

            return baseDatos;
        }

        private string ObtenerUsuario(TipoAmbiente ambiente)
        {
            var baseDatos = string.Empty;

            switch (ambiente)
            {
                case TipoAmbiente.Desarrollo:
                    baseDatos = $"sa";
                    break;
                case TipoAmbiente.DesarrolloBdExterno:
                    baseDatos = $"sidkenu_SQLLogin_1";
                    break;
                case TipoAmbiente.Testing:
                    baseDatos = $@"";
                    break;
                case TipoAmbiente.Produccion:
                    baseDatos = $@"";
                    break;
            }

            return baseDatos;
        }
    }
}
