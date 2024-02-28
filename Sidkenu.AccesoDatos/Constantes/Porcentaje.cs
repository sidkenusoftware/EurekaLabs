namespace Sidkenu.AccesoDatos.Constantes
{
    public static class Porcentaje
    {
        public static decimal Calcular(decimal monto, decimal porcentaje)
        {
            porcentaje = porcentaje / 100.0m;

            decimal resultado = monto * porcentaje;

            return resultado;
        }
    }
}
