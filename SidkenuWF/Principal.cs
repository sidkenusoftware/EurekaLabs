using Serilog;
using Sidkenu.AccesoDatos.Constantes;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Seguridad.Configuracion;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Seguridad.Empresa;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Seguridad.Modulo;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Seguridad.Persona;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Seguridad.PuestoTrabajo;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Seguridad.Usuario;
using Sidkenu.LogicaNegocio.Servicios.Interface.Core;
using Sidkenu.LogicaNegocio.Servicios.Interface.Seguridad;
using SidkenuWF.Formularios.Base.Constantes;
using SidkenuWF.Formularios.Base.Controles;
using SidkenuWF.Formularios.Core;
using SidkenuWF.Formularios.Seguridad;
using SidkenuWF.Helpers;

namespace SidkenuWF
{
    public partial class Principal : Form
    {
        private readonly ISeguridadServicio _seguridadServicio;
        private readonly IConfiguracionServicio _configuracionServicio;
        private readonly ILogger _logger;
        private readonly IModuloServicio _moduloServicio;
        private readonly IPuestoTrabajoServicio _puestoTrabajoServicio;

        private ConfiguracionDTO _configuracionDTO;

        private readonly IPersonaServicio _personaServicio;
        private readonly IEmpresaServicio _empresaServicio;

        public UsuarioDTO? UsuarioLogin { get; internal set; }
        public bool CerrarSession { get; private set; }

        public ModuloDTO _moduloDTO { get; private set; }

        public Principal(ISeguridadServicio seguridadServicio,
                         IConfiguracionServicio configuracionServicio,
                         ILogger logger,
                         IPersonaServicio personaServicio,
                         IEmpresaServicio empresaServicio,
                         IModuloServicio moduloServicio,
                         IPuestoTrabajoServicio puestoTrabajoServicio)
        {
            InitializeComponent();

            this.Text = FormularioConstantes.Titulo;

            CargarApariencia();

            this._seguridadServicio = seguridadServicio;
            this._configuracionServicio = configuracionServicio;
            this._logger = logger;

            this._personaServicio = personaServicio;
            this._empresaServicio = empresaServicio;
            this._moduloServicio = moduloServicio;
            this._puestoTrabajoServicio = puestoTrabajoServicio;

            this.CerrarSession = false;

            var result = _configuracionServicio.Get();

            if (result.State)
            {
                _configuracionDTO = (ConfiguracionDTO)result.Data;
            }
            else
            {
                _logger.Error($"Ocurrió un error al obtener la configuracion del sistema. {result.Message}");
            }

            CtrolUserLogin.btnCerrarSesion.Click += BtnCerrarSesion_Click;
            CtrolUserLogin.btnSalir.Click += BtnSalirSistema_Click;


            this.pnlContenedor.Controls.Remove(CtrolUserLogin);

            CargarDatosCtrolUserLogin();
            CargarDatosEmpresa();
            CargarModulos();
            CargarPuestoTrabajo();
        }

        private void CargarPuestoTrabajo()
        {
            var _puestoTrabajoResult = _puestoTrabajoServicio.GetByNumeroSerie(Serial.Obtener(), Properties.Settings.Default.EmpresaId);

            if (_puestoTrabajoResult != null && _puestoTrabajoResult.State)
            {
                var _puestoTrabajo = (PuestoTrabajoDTO)_puestoTrabajoResult.Data;

                Properties.Settings.Default.PuestoTrabajoId = _puestoTrabajo.Id;
                Properties.Settings.Default.Save();
            }
        }

        // ================================================================================================================== //
        // =======================================              Modulos            ========================================== //
        // ================================================================================================================== //

        private void CargarModulos()
        {
            var resultModulo = _moduloServicio.Get(Properties.Settings.Default.EmpresaId);

            if (resultModulo != null && resultModulo.State)
            {
                var modulo = (ModuloDTO)resultModulo.Data;

                // Modulo de DashBoard

                CtrolModulosSistema.CtrolModuloDashBoard.Visible = modulo.DashBoard;
                CtrolModulosSistema.CtrolModuloDashBoard.btnIngresar.Click += BtnModuloDashBoard_Click;
                CtrolModulosSistema.CtrolModuloDashBoard.Titulo = "DashBoard";
                CtrolModulosSistema.CtrolModuloDashBoard.Descripcion = "Monitor Gerencial";
                CtrolModulosSistema.CtrolModuloDashBoard.Icono = FontAwesome.Sharp.IconChar.ChartPie;

                // Modulo de Seguridad

                CtrolModulosSistema.CtrolModuloSeguridad.Visible = modulo.Seguridad;
                CtrolModulosSistema.CtrolModuloSeguridad.btnIngresar.Click += BtnModuloSeguridad_Click;
                CtrolModulosSistema.CtrolModuloSeguridad.Titulo = "Ajustes";
                CtrolModulosSistema.CtrolModuloSeguridad.Descripcion = "Modulo para Gestionar la Seguridad y configuraciones";
                CtrolModulosSistema.CtrolModuloSeguridad.Icono = FontAwesome.Sharp.IconChar.ScrewdriverWrench;

                // Modulo de Ventas

                CtrolModulosSistema.CtrolModuloVenta.Visible = modulo.Venta;
                CtrolModulosSistema.CtrolModuloVenta.btnIngresar.Click += BtnModuloVenta_Click;
                CtrolModulosSistema.CtrolModuloVenta.Titulo = "Ventas";
                CtrolModulosSistema.CtrolModuloVenta.Descripcion = "Modulo para Gestionar las Ventas";
                CtrolModulosSistema.CtrolModuloVenta.Icono = FontAwesome.Sharp.IconChar.CartShopping;

                // Modulo de Compras

                CtrolModulosSistema.CtrolModuloCompra.Visible = modulo.Compra;
                CtrolModulosSistema.CtrolModuloCompra.btnIngresar.Click += BtnModuloCompra_Click;
                CtrolModulosSistema.CtrolModuloCompra.Titulo = "Compras";
                CtrolModulosSistema.CtrolModuloCompra.Descripcion = "Modulo para Gestionar Compras";
                CtrolModulosSistema.CtrolModuloCompra.Icono = FontAwesome.Sharp.IconChar.TruckLoading;

                // Modulo de Inventarios

                CtrolModulosSistema.CtrolModuloInventario.Visible = modulo.Inventario;
                CtrolModulosSistema.CtrolModuloInventario.btnIngresar.Click += BtnModuloInventario_Click;
                CtrolModulosSistema.CtrolModuloInventario.Titulo = "Inventario";
                CtrolModulosSistema.CtrolModuloInventario.Descripcion = "Modulo para Gestionar Inventario / Stock";
                CtrolModulosSistema.CtrolModuloInventario.Icono = FontAwesome.Sharp.IconChar.Boxes;

                // Modulo de Fabricacion

                CtrolModulosSistema.CtrolModuloFabricacion.Visible = modulo.Fabricacion;
                CtrolModulosSistema.CtrolModuloFabricacion.btnIngresar.Click += BtnModuloFabricacion_Click;
                CtrolModulosSistema.CtrolModuloFabricacion.Titulo = "Fabricación";
                CtrolModulosSistema.CtrolModuloFabricacion.Descripcion = "Modulo para Gestionar la Fabricación de Artículos";
                CtrolModulosSistema.CtrolModuloFabricacion.Icono = FontAwesome.Sharp.IconChar.Industry;

                // Modulo de Caja

                CtrolModulosSistema.CtrolModuloCaja.Visible = modulo.Caja;
                CtrolModulosSistema.CtrolModuloCaja.btnIngresar.Click += BtnModuloCaja_Click;
                CtrolModulosSistema.CtrolModuloCaja.Titulo = "Cajas";
                CtrolModulosSistema.CtrolModuloCaja.Descripcion = "Modulo para Gestionar los movimientos de Cajas";
                CtrolModulosSistema.CtrolModuloCaja.Icono = FontAwesome.Sharp.IconChar.SackDollar;

                // Modulo de Punto de Venta

                CtrolModulosSistema.CtrolModuloPuntoVenta.Visible = modulo.PuntoVenta;
                CtrolModulosSistema.CtrolModuloPuntoVenta.btnIngresar.Click += BtnModuloPuntoVenta_Click;
                CtrolModulosSistema.CtrolModuloPuntoVenta.Titulo = "Punto de Venta";
                CtrolModulosSistema.CtrolModuloPuntoVenta.Descripcion = "Modulo Punto de Venta o Bar";
                CtrolModulosSistema.CtrolModuloPuntoVenta.Icono = FontAwesome.Sharp.IconChar.DesktopAlt;

            }
        }

        // ================================================================================================================== //
        // =======================================              Modulos            ========================================== //
        // ================================================================================================================== //

        private void BtnModuloDashBoard_Click(object? sender, EventArgs e)
        {
            var formulario = new _00114_ModuloDashBoard(_seguridadServicio, _configuracionServicio, _logger)
            {
                TituloModulo = ((Button)sender).Tag.ToString(),
                // ColorTituloModulo = ColorAleatorio.Obtener(((Button)sender).Tag.ToString()[..1])
            };

            if (FormularioSeguridad.VerificarAccesoParaAbrirEnPanel(formulario, _seguridadServicio, _logger, _configuracionDTO))
            {
                AbrirFormularioDentroDelPanel(formulario);
            }
        }

        private void BtnModuloPuntoVenta_Click(object? sender, EventArgs e)
        {
            var formulario = new _00112_ModuloPuntoVenta(_seguridadServicio,
                                                         _configuracionServicio,
                                                         _logger,
                                                         Program.Container.GetInstance<IConfiguracionCoreServicio>(),
                                                         Program.Container.GetInstance<ICajaServicio>(),
                                                         Program.Container.GetInstance<ICajaPuestoTrabajoServicio>())
            {
                TituloModulo = ((Button)sender).Tag.ToString(),
                // ColorTituloModulo = ColorAleatorio.Obtener(((Button)sender).Tag.ToString()[..1])
            };

            if (FormularioSeguridad.VerificarAccesoParaAbrirEnPanel(formulario, _seguridadServicio, _logger, _configuracionDTO))
            {
                AbrirFormularioDentroDelPanel(formulario);
            }
        }

        private void BtnModuloCaja_Click(object? sender, EventArgs e)
        {
            var formulario = new _00113_ModuloCaja(_seguridadServicio, _configuracionServicio, _logger)
            {
                TituloModulo = ((Button)sender).Tag.ToString(),
                // ColorTituloModulo = ColorAleatorio.Obtener(((Button)sender).Tag.ToString()[..1])
            };

            if (FormularioSeguridad.VerificarAccesoParaAbrirEnPanel(formulario, _seguridadServicio, _logger, _configuracionDTO))
            {
                AbrirFormularioDentroDelPanel(formulario);
            }
        }

        private void BtnModuloFabricacion_Click(object? sender, EventArgs e)
        {
            var formulario = new _00111_ModuloFabricacion(_seguridadServicio, _configuracionServicio, _logger)
            {
                TituloModulo = ((Button)sender).Tag.ToString(),
                // ColorTituloModulo = ColorAleatorio.Obtener(((Button)sender).Tag.ToString()[..1])
            };

            if (FormularioSeguridad.VerificarAccesoParaAbrirEnPanel(formulario, _seguridadServicio, _logger, _configuracionDTO))
            {
                AbrirFormularioDentroDelPanel(formulario);
            }
        }

        private void BtnModuloInventario_Click(object? sender, EventArgs e)
        {
            var formulario = new _00110_ModuloInventario(_seguridadServicio, _configuracionServicio, _logger)
            {
                TituloModulo = ((Button)sender).Tag.ToString(),
                // ColorTituloModulo = ColorAleatorio.Obtener(((Button)sender).Tag.ToString()[..1])
            };

            if (FormularioSeguridad.VerificarAccesoParaAbrirEnPanel(formulario, _seguridadServicio, _logger, _configuracionDTO))
            {
                AbrirFormularioDentroDelPanel(formulario);
            }
        }

        private void BtnModuloCompra_Click(object? sender, EventArgs e)
        {
            var formulario = new _00109_ModuloCompra(_seguridadServicio, _configuracionServicio, _logger)
            {
                TituloModulo = ((Button)sender).Tag.ToString(),
                // ColorTituloModulo = ColorAleatorio.Obtener(((Button)sender).Tag.ToString()[..1])
            };

            if (FormularioSeguridad.VerificarAccesoParaAbrirEnPanel(formulario, _seguridadServicio, _logger, _configuracionDTO))
            {
                AbrirFormularioDentroDelPanel(formulario);
            }
        }


        private void BtnModuloSeguridad_Click(object? sender, EventArgs e)
        {
            var formulario = new _00020_ModuloSeguridad(_seguridadServicio, _configuracionServicio, _logger)
            {
                TituloModulo = ((Button)sender).Tag.ToString(),
                // ColorTituloModulo = ColorAleatorio.Obtener(((Button)sender).Tag.ToString()[..1])
            };

            if (FormularioSeguridad.VerificarAccesoParaAbrirEnPanel(formulario, _seguridadServicio, _logger, _configuracionDTO))
            {
                formulario.salirToolStripMenuItem.Click += BtnModulo;

                AbrirFormularioDentroDelPanel(formulario);
            }
        }

        private void BtnModulo(object? sender, EventArgs e)
        {
            CargarModulos();
        }

        private void BtnModuloVenta_Click(object? sender, EventArgs e)
        {
            var formulario = new _00108_ModuloVenta(_seguridadServicio, _configuracionServicio, _logger)
            {
                TituloModulo = ((Button)sender).Tag.ToString()
            };

            if (FormularioSeguridad.VerificarAccesoParaAbrirEnPanel(formulario, _seguridadServicio, _logger, _configuracionDTO))
            {
                AbrirFormularioDentroDelPanel(formulario);
            }
        }

        // ================================================================================================================== //

        private void CargarDatosEmpresa()
        {
            var resultEmpresa = _empresaServicio.GetById(Properties.Settings.Default.EmpresaId);

            if (resultEmpresa != null && resultEmpresa.State)
            {
                var empresaSeleccionada = (EmpresaDTO)resultEmpresa.Data;

                this.lblEmpresa.Text = empresaSeleccionada.Descripcion;
                this.lblDatosEmpresa.Text = $"Dir: {empresaSeleccionada.Direccion} - Tel: {empresaSeleccionada.Telefono}";
                this.imgLogoEmpresa.Image = ImagenConvert.Convertir_Bytes_Imagen(empresaSeleccionada.Logo);
            }
        }

        private void CargarDatosCtrolUserLogin()
        {
            var resultPersonaLogin = _personaServicio.GetById(Properties.Settings.Default.PersonaLoginId);

            if (resultPersonaLogin != null && resultPersonaLogin.State)
            {
                var personaLog = (PersonaDTO)resultPersonaLogin.Data;

                CtrolUserLogin.UsuarioLogin = Properties.Settings.Default.UserLogin;
                CtrolUserLogin.PersonaLogin = $"{personaLog.Apellido} {personaLog.Nombre}";
                CtrolUserLogin.FotoPersonaLogin = personaLog.Foto;
            }
        }

        private void BtnSalirSistema_Click(object? sender, EventArgs e)
        {
            if (MessageBox.Show("¿ Esta seguro que desea Salir del Sistema ?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes)
            {
                this.CerrarSession = false;
                Application.Exit();
            }
            else
            {
                pnlContenedor.Controls.Remove(CtrolUserLogin);
            }
        }




        private void BtnCerrarSesion_Click(object? sender, EventArgs e)
        {
            if (MessageBox.Show("¿ Esta seguro de Cerrar Sesión para cambiar de usuario ?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes)
            {
                this.CerrarSession = true;
                this.Close();
            }
            else
            {
                pnlContenedor.Controls.Remove(CtrolUserLogin);
            }
        }


        private void CargarApariencia()
        {
            this.pnlSuperior.BackColor = Formularios.Base.Constantes.ColorFormulario.ColorPanelPrincipal;            
        }

        private void BtnUserLogin_Click(object sender, EventArgs e)
        {
            if (VerificarSiExistePanelUsuarioLoginCargado(CtrolUserLogin))
            {
                pnlContenedor.Controls.Remove(CtrolUserLogin);
            }
            else
            {
                pnlContenedor.Controls.Add(CtrolUserLogin);
                CtrolUserLogin.BringToFront();
            }
        }

        // ===================================================================== //
        // ==============             Metodos Privados            ============== //
        // ===================================================================== //

        private void AbrirFormularioDentroDelPanel(Form formulario)
        {
            if (this.pnlContenedor.Controls.Count > 0)
                this.pnlContenedor.Controls.RemoveAt(0);

            Form fh = formulario as Form;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.pnlContenedor.Controls.Add(fh);
            this.pnlContenedor.Tag = fh;
            fh.Show();
            fh.BringToFront();
        }

        private bool VerificarSiExistePanelUsuarioLoginCargado(SidkenuUserLogin panel)
        {
            return pnlContenedor.Controls.OfType<SidkenuUserLogin>()
                .Any(p => p.Name == panel.Name);
        }

        private bool VerificarSiExistePanelModulosSistemas(SidkenuContenedorModulos panel)
        {
            return pnlContenedor.Controls.OfType<SidkenuContenedorModulos>()
                .Any(p => p.Name == panel.Name);
        }

        private void PnlContenedor_ControlRemoved(object sender, ControlEventArgs e)
        {
            if (VerificarSiExistePanelModulosSistemas(CtrolModulosSistema))
            {
                pnlContenedor.Controls.Remove(CtrolModulosSistema);
            }
            else
            {
                if (pnlContenedor.Controls.Count <= 0)
                {
                    pnlContenedor.Controls.Add(CtrolModulosSistema);
                    CtrolModulosSistema.BringToFront();
                }
            }
        }

        private void Principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            LimpiarSetting();
        }

        private void LimpiarSetting()
        {
            Properties.Settings.Default.UserLogin = string.Empty;
            Properties.Settings.Default.PersonaLogin = string.Empty;

            Properties.Settings.Default.UserLoginId = Guid.Empty;
            Properties.Settings.Default.EmpresaId = Guid.Empty;
            Properties.Settings.Default.PersonaLoginId = Guid.Empty;
            Properties.Settings.Default.PuestoTrabajoId = Guid.Empty;
            Properties.Settings.Default.CajaId = Guid.Empty;
            Properties.Settings.Default.CajaDetalleId = Guid.Empty;
        }
    }
}