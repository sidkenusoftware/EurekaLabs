using Serilog;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Seguridad.Configuracion;
using Sidkenu.LogicaNegocio.Servicios.Interface.Seguridad;

namespace SidkenuWF.Formularios.Base.Constantes
{
    public static class FormularioSeguridad
    {
        public static void VerificarAcceso(Form formulario, ISeguridadServicio seguridadServicio, ILogger logger, ConfiguracionDTO configuracionSistema)
        {
            if (seguridadServicio.VerificarAcceso(Properties.Settings.Default.PersonaLoginId,
                                Properties.Settings.Default.EmpresaId,
                                formulario.Name))
            {
                formulario.ShowDialog();
            }
            else
            {
                if (configuracionSistema.LogWarning)
                {
                    logger.Warning($"La persona {Properties.Settings.Default.PersonaLogin} intento ingresar a {formulario.Name}");
                }

                MessageBox.Show(Mensajes.AccesoDenegado, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        public static void VerificarAcceso(Form formulario, ISeguridadServicio seguridadServicio)
        {
            if (seguridadServicio.VerificarAcceso(Properties.Settings.Default.PersonaLoginId,
                                Properties.Settings.Default.EmpresaId,
                                formulario.Name))
            {
                formulario.ShowDialog();
            }
            else
            {
                MessageBox.Show(Mensajes.AccesoDenegado, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        public static void VerificarAccesoSolorShow(Form formulario, ISeguridadServicio seguridadServicio)
        {
            if (seguridadServicio.VerificarAcceso(Properties.Settings.Default.PersonaLoginId,
                                Properties.Settings.Default.EmpresaId,
                                formulario.Name))
            {
                formulario.Show();
            }
            else
            {
                MessageBox.Show(Mensajes.AccesoDenegado, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        public static bool VerificarAccesoParaAbrirEnPanel(Form formulario, ISeguridadServicio seguridadServicio, ILogger logger, ConfiguracionDTO configuracionSistema)
        {
            var puedeIngresar = seguridadServicio.VerificarAcceso(Properties.Settings.Default.PersonaLoginId,
                                Properties.Settings.Default.EmpresaId,
                                formulario.Name);

            if (!puedeIngresar)
            {
                if (configuracionSistema.LogWarning)
                {
                    logger.Warning($"La persona {Properties.Settings.Default.PersonaLogin} intento ingresar a {formulario.Name}");
                }

                MessageBox.Show(Mensajes.AccesoDenegado, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

            return puedeIngresar;
        }
    }
}
