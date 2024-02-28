using FontAwesome.Sharp;
using SidkenuWF.Formularios.Base.Constantes;
using SidkenuWF.Formularios.Base;
using Serilog;
using Sidkenu.LogicaNegocio.Servicios.Interface.Core;
using Sidkenu.LogicaNegocio.Servicios.Interface.Seguridad;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.ListaPrecio;

namespace SidkenuWF.Formularios.Core
{
    public partial class _00138_ListaPrecio : FormularioConsulta
    {
        private readonly IListaPrecioServicio _listaPrecioServicio;

        public _00138_ListaPrecio(ISeguridadServicio seguridadServicio,
                                  IConfiguracionServicio configuracionServicio,
                                  ILogger logger,
                                  IListaPrecioServicio listaPrecioServicio)
                                  : base(seguridadServicio, configuracionServicio, logger)
        {
            InitializeComponent();

            base.BotoneraLateralVisible = (false, false); // (Panel Botonera, Panel Abrir-Cerrar)
            base.TituloFormulario = FormularioConstantes.Titulo;
            base.Titulo = "Lista de Precio";
            base.Logo = IconChar.ListNumeric;

            _listaPrecioServicio = listaPrecioServicio;
        }

        public override bool EjecutarComandoNuevo(object sender, EventArgs e)
        {
            var formularioAbm = new _00139_ListaPrecio_Abm(base._seguridadServicio,
                                                           base._configuracionServicio,
                                                           base._logger,
                                                           Program.Container.GetInstance<IListaPrecioServicio>(),
                                                           TipoOperacion.Nuevo);

            FormularioSeguridad.VerificarAcceso(formularioAbm, base._seguridadServicio, base._logger, base._configuracionDTO);

            return formularioAbm.RealizoAlgunaOperacion;
        }

        public override bool EjecutarComandoEditar(object sender, EventArgs e)
        {
            var formularioAbm = new _00139_ListaPrecio_Abm(base._seguridadServicio,
                                                           base._configuracionServicio,
                                                           base._logger,
                                                           Program.Container.GetInstance<IListaPrecioServicio>(),
                                                           TipoOperacion.Modificar, EntidadId);

            FormularioSeguridad.VerificarAcceso(formularioAbm, base._seguridadServicio, base._logger, base._configuracionDTO);

            return formularioAbm.RealizoAlgunaOperacion;
        }

        public override bool EjecutarComandoEliminar(object sender, EventArgs e)
        {
            try
            {
                _listaPrecioServicio.Delete(new ListaPrecioDeleteDTO { Id = base.EntidadId.Value }, Properties.Settings.Default.UserLogin);

                return true;
            }
            catch
            {
                return false;
            }
        }

        public override void Buscar(string cadenaBuscar, bool verEliminados = false)
        {
            var result = _listaPrecioServicio.GetByFilter(new ListaPrecioFilterDTO
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
                dgvGrilla.Columns["Descripcion"].HeaderText = "ListaPrecio";
                dgvGrilla.Columns["Descripcion"].DisplayIndex = 1;
                dgvGrilla.Columns["Descripcion"].ReadOnly = true;

                dgvGrilla.Columns["Rentabilidad"].Visible = true;
                dgvGrilla.Columns["Rentabilidad"].Width = 150;
                dgvGrilla.Columns["Rentabilidad"].HeaderText = "Rentabilidad";
                dgvGrilla.Columns["Rentabilidad"].DisplayIndex = 2;
                dgvGrilla.Columns["Rentabilidad"].ReadOnly = true;
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