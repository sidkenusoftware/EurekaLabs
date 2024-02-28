using Serilog;
using Sidkenu.AccesoDatos.CadenaConexion;
using Sidkenu.LogicaNegocio.IoC;
using Sidkenu.LogicaNegocio.Servicios.Interface.Seguridad;
using SidkenuWF.Formularios.Seguridad;
using StructureMap;

namespace SidkenuWF
{
    internal static class Program
    {
        public static IConexionServicio conexionServicio;
        public static Container Container;

        [STAThread]
        static void Main()
        {
            conexionServicio = new ConexionServicio();

            // Logger - Serilog            
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Verbose()
                .WriteTo.MSSqlServer(conexionServicio.ObtenerCadenaConexion(MotoBaseDatos.Obtener), "Logs", autoCreateSqlTable: true)
                .CreateLogger();

            // Register StructureMap
            Container = new Container(cfg =>
            {
                cfg.AddRegistry(new StructureMapRegistry());
                cfg.AddRegistry(new StructureMapRegistryMapper());
                cfg.AddRegistry(new StructureMapRegistrySeguridad());
                cfg.AddRegistry(new StructureMapRegistryCore());
                cfg.For<ILogger>().Use(Log.Logger);
            });

            try
            {
                ApplicationConfiguration.Initialize();

                var fSplash = new Splash(Container.GetInstance<IConectividadServicio>(),
                                         Container.GetInstance<IEmpresaServicio>(),
                                         Container.GetInstance<IConfiguracionServicio>());

                fSplash.ShowDialog();

                // fSplash.Resultado => (Puede Continuar, Ejecutar Asistente, Tipo de Login)

                if (fSplash.Resultado.Item1) // Puede Continuar
                {
                    if (fSplash.Resultado.Item2) // Ejecutar Asistente
                    {
                        var fAsistente = new AsistenteInicioSistema(Container.GetInstance<IAsistenteCargaInicialServicio>());
                        fAsistente.ShowDialog();
                    }
                    else
                    {
                        // Llama al Login
                        if (fSplash.Resultado.Item3)
                        {
                            var fLogin = new Login(Container.GetInstance<ICuentaServicio>(), Container.GetInstance<IUsuarioServicio>());
                            fLogin.ShowDialog();

                            if (fLogin.PuedeIngresar)
                            {
                                var fPrincipal = new Principal(Container.GetInstance<ISeguridadServicio>(),
                                                               Container.GetInstance<IConfiguracionServicio>(),
                                                               Container.GetInstance<ILogger>(),
                                                               Container.GetInstance<IPersonaServicio>(),
                                                               Container.GetInstance<IEmpresaServicio>(),
                                                               Container.GetInstance<IModuloServicio>(),
                                                               Container.GetInstance<IPuestoTrabajoServicio>())
                                {
                                    UsuarioLogin = fLogin.UsuarioLogin
                                };

                                Application.Run(fPrincipal);
                            }
                            else
                            {
                                Application.Exit();
                            }
                        }
                        else
                        {
                            EjecutarConLoginDeAvatar();
                        }
                    }
                }
                else
                {
                    Application.Exit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrio un error {ex.Message}");
            }
            finally
            {
                Log.Information("Cierre de sistema");
            }
        }

        private static void EjecutarConLoginDeAvatar()
        {
            var fLogin = new LoginAvatar(Container.GetInstance<IUsuarioServicio>());
            fLogin.ShowDialog();

            if (fLogin.PuedeIngresar)
            {
                var fPrincipal = new Principal(Container.GetInstance<ISeguridadServicio>(),
                                               Container.GetInstance<IConfiguracionServicio>(),
                                               Container.GetInstance<ILogger>(),
                                               Container.GetInstance<IPersonaServicio>(),
                                               Container.GetInstance<IEmpresaServicio>(),
                                               Container.GetInstance<IModuloServicio>(),
                                               Container.GetInstance<IPuestoTrabajoServicio>())
                {
                    UsuarioLogin = fLogin.UsuarioLogin
                };

                Application.Run(fPrincipal);

                if (fPrincipal.CerrarSession)
                {
                    EjecutarConLoginDeAvatar();
                }
            }
            else
            {
                Application.Exit();
            }
        }
    }
}
