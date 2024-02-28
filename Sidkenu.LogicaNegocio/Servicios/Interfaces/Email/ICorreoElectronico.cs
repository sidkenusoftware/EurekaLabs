namespace Sidkenu.LogicaNegocio.Servicios.Interfaces.Email
{
    public interface ICorreoElectronico
    {
        bool Enviar(string destino,
            string origen,
            string asunto,
            string mensaje,
            string usuarioCredencial,
            string passwordCredencial,
            string host,
            int puerto,
            bool contieneContenidoHtml = false);

        string OcultarMailConAsteriscos(string mail);
    }
}
