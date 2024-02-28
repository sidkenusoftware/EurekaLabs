namespace Sidkenu.AccesoDatos.Constantes
{
    public static class SecretKey
    {
        private const string issuerJwt = @"https://localhost:5001/";

        private const string audienceJwt = @"https://localhost:5001/";

        // ========================================================================================================================= //

        public static string IssuerJwtAuth = issuerJwt;

        public static string AudienceJwtAuth = audienceJwt;
    }
}
