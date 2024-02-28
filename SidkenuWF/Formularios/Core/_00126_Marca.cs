using FontAwesome.Sharp;
using SidkenuWF.Formularios.Base.Constantes;
using SidkenuWF.Formularios.Base;
using Serilog;
using Sidkenu.LogicaNegocio.Servicios.Interface.Core;
using Sidkenu.LogicaNegocio.Servicios.Interface.Seguridad;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.Marca;

namespace SidkenuWF.Formularios.Core
{
    public partial class _00126_Marca : FormularioConsulta
    {
        private readonly IMarcaServicio _marcaServicio;
       
        public _00126_Marca(ISeguridadServicio seguridadServicio,
                            IConfiguracionServicio configuracionServicio,
                            ILogger logger,
                            IMarcaServicio marcaServicio)
                            : base(seguridadServicio, configuracionServicio, logger)
        {
            InitializeComponent();

            base.BotoneraLateralVisible = (false, false); // (Panel Botonera, Panel Abrir-Cerrar)
            base.TituloFormulario = Base.Constantes.FormularioConstantes.Titulo;
            base.Titulo = "Marca";
            base.Logo = IconChar.BuildingFlag;

            _marcaServicio = marcaServicio;
        }

        public override bool EjecutarComandoNuevo(object sender, EventArgs e)
        {
            var formularioAbm = new _00127_Marca_Abm(base._seguridadServicio,
                                                       base._configuracionServicio,
                                                       base._logger,
                                                       Program.Container.GetInstance<IMarcaServicio>(),
                                                       Program.Container.GetInstance<IConfiguracionCoreServicio>(),
                                                       TipoOperacion.Nuevo);

            FormularioSeguridad.VerificarAcceso(formularioAbm, base._seguridadServicio, base._logger, base._configuracionDTO);

            return formularioAbm.RealizoAlgunaOperacion;
        }

        public override bool EjecutarComandoEditar(object sender, EventArgs e)
        {
            var formularioAbm = new _00127_Marca_Abm(base._seguridadServicio,
                                                       base._configuracionServicio,
                                                       base._logger,
                                                       Program.Container.GetInstance<IMarcaServicio>(),
                                                       Program.Container.GetInstance<IConfiguracionCoreServicio>(),
                                                       TipoOperacion.Modificar, EntidadId);

            FormularioSeguridad.VerificarAcceso(formularioAbm, base._seguridadServicio, base._logger, base._configuracionDTO);

            return formularioAbm.RealizoAlgunaOperacion;
        }

        public override bool EjecutarComandoEliminar(object sender, EventArgs e)
        {
            try
            {
                _marcaServicio.Delete(new MarcaDeleteDTO { Id = base.EntidadId.Value }, Properties.Settings.Default.UserLogin);

                return true;
            }
            catch
            {
                return false;
            }
        }

        public override void Buscar(string cadenaBuscar, bool verEliminados = false)
        {
            var result = _marcaServicio.GetByFilter(new MarcaFilterDTO
            {
                CadenaBuscar = cadenaBuscar,
                VerEliminados = verEliminados,
                EmpresaId = Properties.Settings.Default.EmpresaId
            });

            if (result.State)
            {
                this.dgvGrilla.DataSource = result.Data;

                base.Buscar(cadenaBuscar, verEliminados);
            }
            else
            {
                if (base._configuracionDTO != null && base._configuracionDTO.LogError)
                {
                    _logger.Error($"{base.Titulo}: error al obtener los datos. User: {Properties.Settings.Default.PersonaLogin}");
                }

                MessageBox.Show("Ocurrió un error al obtener los datos");
            }
        }

        public override void FormatearDatos(DataGridView dgvGrilla)
        {
            try
            {
                base.FormatearDatos(dgvGrilla);

                dgvGrilla.Columns["Codigo"].Visible = true;
                dgvGrilla.Columns["Codigo"].Width = 150;
                dgvGrilla.Columns["Codigo"].HeaderText = "Código";
                dgvGrilla.Columns["Codigo"].DisplayIndex = 0;
                dgvGrilla.Columns["Codigo"].ReadOnly = true;
                
                dgvGrilla.Columns["Descripcion"].Visible = true;
                dgvGrilla.Columns["Descripcion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvGrilla.Columns["Descripcion"].HeaderText = "Marca";
                dgvGrilla.Columns["Descripcion"].DisplayIndex = 1;
                dgvGrilla.Columns["Descripcion"].ReadOnly = true;

                dgvGrilla.Columns["ActivarAumentoPrecioPublico"].Visible = true;
                dgvGrilla.Columns["ActivarAumentoPrecioPublico"].Width = 80;
                dgvGrilla.Columns["ActivarAumentoPrecioPublico"].HeaderText = "Aumento";
                dgvGrilla.Columns["ActivarAumentoPrecioPublico"].DisplayIndex = 2;
                dgvGrilla.Columns["ActivarAumentoPrecioPublico"].ReadOnly = true;

                dgvGrilla.Columns["AumentoPrecioPublico"].Visible = true;
                dgvGrilla.Columns["AumentoPrecioPublico"].Width = 100;
                dgvGrilla.Columns["AumentoPrecioPublico"].HeaderText = "Precio";
                dgvGrilla.Columns["AumentoPrecioPublico"].DisplayIndex = 3;
                dgvGrilla.Columns["AumentoPrecioPublico"].ReadOnly = true;

                dgvGrilla.Columns["TipoValorPublico"].Visible = true;
                dgvGrilla.Columns["TipoValorPublico"].Width = 100;
                dgvGrilla.Columns["TipoValorPublico"].HeaderText = "Tipo Aumento";
                dgvGrilla.Columns["TipoValorPublico"].DisplayIndex = 4;
                dgvGrilla.Columns["TipoValorPublico"].ReadOnly = true;

                dgvGrilla.Columns["ActivarAumentoPrecioPublicoListaPrecio"].Visible = true;
                dgvGrilla.Columns["ActivarAumentoPrecioPublicoListaPrecio"].Width = 80;
                dgvGrilla.Columns["ActivarAumentoPrecioPublicoListaPrecio"].HeaderText = "Lista Precio";
                dgvGrilla.Columns["ActivarAumentoPrecioPublicoListaPrecio"].DisplayIndex = 5;
                dgvGrilla.Columns["ActivarAumentoPrecioPublicoListaPrecio"].ReadOnly = true;

                dgvGrilla.Columns["AumentoPrecioPublicoListaPrecio"].Visible = true;
                dgvGrilla.Columns["AumentoPrecioPublicoListaPrecio"].Width = 100;
                dgvGrilla.Columns["AumentoPrecioPublicoListaPrecio"].HeaderText = "Precio Imp";
                dgvGrilla.Columns["AumentoPrecioPublicoListaPrecio"].DisplayIndex = 6;
                dgvGrilla.Columns["AumentoPrecioPublicoListaPrecio"].ReadOnly = true;

                dgvGrilla.Columns["TipoValorPublicoListaPrecio"].Visible = true;
                dgvGrilla.Columns["TipoValorPublicoListaPrecio"].Width = 100;
                dgvGrilla.Columns["TipoValorPublicoListaPrecio"].HeaderText = "Tipo Aumento Imp";
                dgvGrilla.Columns["TipoValorPublicoListaPrecio"].DisplayIndex = 7;
                dgvGrilla.Columns["TipoValorPublicoListaPrecio"].ReadOnly = true;
            }
            catch (Exception ex)
            {
                if (base._configuracionDTO != null && base._configuracionDTO.LogError)
                {
                    _logger.Error(ex, $"Error en el formateo de las columnas en {base.Titulo}.");
                }

                MessageBox.Show("Los nombres de las columnas no coinciden");
            }
        }
    }
}