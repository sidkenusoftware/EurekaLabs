using FontAwesome.Sharp;
using SidkenuWF.Formularios.Base.Constantes;
using SidkenuWF.Formularios.Base;
using Serilog;
using Sidkenu.LogicaNegocio.Servicios.Interface.Core;
using Sidkenu.LogicaNegocio.Servicios.Interface.Seguridad;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.Familia;

namespace SidkenuWF.Formularios.Core
{
    public partial class _00124_Familia : FormularioConsulta
    {
        private readonly IFamiliaServicio _familiaServicio;

        public _00124_Familia(ISeguridadServicio seguridadServicio,
                              IConfiguracionServicio configuracionServicio,
                              ILogger logger,
                              IFamiliaServicio familiaServicio)
                              : base(seguridadServicio, configuracionServicio, logger)
        {
            InitializeComponent();

            base.BotoneraLateralVisible = (false, false); // (Panel Botonera, Panel Abrir-Cerrar)
            base.TituloFormulario = Base.Constantes.FormularioConstantes.Titulo;
            base.Titulo = "Familia / Rubro";
            base.Logo = IconChar.BuildingFlag;

            _familiaServicio = familiaServicio;
        }

        public override bool EjecutarComandoNuevo(object sender, EventArgs e)
        {
            var formularioAbm = new _00125_Familia_Abm(base._seguridadServicio,
                                                       base._configuracionServicio,
                                                       Program.Container.GetInstance<IConfiguracionCoreServicio>(),
                                                       base._logger,
                                                       Program.Container.GetInstance<IFamiliaServicio>(),
                                                       TipoOperacion.Nuevo);

            FormularioSeguridad.VerificarAcceso(formularioAbm, base._seguridadServicio, base._logger, base._configuracionDTO);

            return formularioAbm.RealizoAlgunaOperacion;
        }

        public override bool EjecutarComandoEditar(object sender, EventArgs e)
        {
            var formularioAbm = new _00125_Familia_Abm(base._seguridadServicio,
                                                       base._configuracionServicio,
                                                       Program.Container.GetInstance<IConfiguracionCoreServicio>(),
                                                       base._logger,
                                                       Program.Container.GetInstance<IFamiliaServicio>(),
                                                       TipoOperacion.Modificar, EntidadId);

            FormularioSeguridad.VerificarAcceso(formularioAbm, base._seguridadServicio, base._logger, base._configuracionDTO);

            return formularioAbm.RealizoAlgunaOperacion;
        }

        public override bool EjecutarComandoEliminar(object sender, EventArgs e)
        {
            try
            {
                _familiaServicio.Delete(new FamiliaDeleteDTO { Id = base.EntidadId.Value }, Properties.Settings.Default.UserLogin);

                return true;
            }
            catch
            {
                return false;
            }
        }

        public override void Buscar(string cadenaBuscar, bool verEliminados = false)
        {
            var result = _familiaServicio.GetByFilter(new FamiliaFilterDTO
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
                dgvGrilla.Columns["Descripcion"].HeaderText = "Familia / Rubro";
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
