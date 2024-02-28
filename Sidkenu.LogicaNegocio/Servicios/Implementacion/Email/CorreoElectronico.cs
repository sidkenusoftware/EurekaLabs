using Sidkenu.LogicaNegocio.Servicios.Interfaces.Email;
using System.Net.Mail;
using System.Net;
using System.Text;

namespace Sidkenu.LogicaNegocio.Servicios.Implementacion.Email
{
    public class CorreoElectronico : ICorreoElectronico
    {
        public virtual bool Enviar(string destino,
            string origen,
            string asunto,
            string mensaje,
            string usuarioCredencial,
            string passwordCredencial,
            string host = "smtp.gmail.com",
            int puerto = 587,
            bool contieneContenidoHtml = false)
        {
            var eMailMessage = new MailMessage
            {
                BodyEncoding = Encoding.Default,
                Priority = MailPriority.High,
                IsBodyHtml = contieneContenidoHtml,
                Body = mensaje,
                Subject = asunto,
                From = new MailAddress(usuarioCredencial),
                To = { new MailAddress(destino) }
            };

            var smtp = new SmtpClient(host, puerto)
            {
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(usuarioCredencial, passwordCredencial),
            };

            try
            {
                smtp.Send(eMailMessage);
                eMailMessage.Dispose();
                return true;
            }
            catch
            {
                smtp.SendAsyncCancel();
                return false;
            }
        }

        public string OcultarMailConAsteriscos(string mail)
        {
            var correoElectronico = mail;

            var primeraParte = correoElectronico.Substring(0, 2);

            var segundaParte = correoElectronico.Substring(correoElectronico.IndexOf('@'), correoElectronico.Length - correoElectronico.IndexOf('@'));

            var cantidad = correoElectronico.Length - segundaParte.Length - 2;

            var nuevoCorreo = $"{primeraParte.PadRight(cantidad + 2, '*')}{segundaParte}";

            return nuevoCorreo;
        }
    }
}
