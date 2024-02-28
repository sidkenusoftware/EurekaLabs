namespace Sidkenu.AccesoDatos.Constantes
{
    public static class ErrorException
    {
        public static string Mensaje(Exception ex)
        {
            if (ex.Message.ToUpper().Contains("DUPLICATE"))
            {
                return "Los datos ingresados ya existen";
            }

            if (ex.InnerException != null && ex.InnerException.Message.ToUpper().Contains("DUPLICATE"))
            {
                return "Los datos ingresados ya existen";
            }

            var mensajeExcepction = ex.InnerException != null ? ex.InnerException.Message : ex.Message;

            return $"Ocurrio un error grave. Comuniquese con el Administrador. - {mensajeExcepction}";
        }
    }
}
