using FontAwesome.Sharp;
using Serilog;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.Proveedor;
using Sidkenu.LogicaNegocio.Servicios.Interface.Core;
using Sidkenu.LogicaNegocio.Servicios.Interface.Seguridad;
using SidkenuWF.Formularios.Base;
using SidkenuWF.Formularios.Base.Constantes;

namespace SidkenuWF.Formularios.Core
{
    public partial class _00104_Proveedor : FormularioConsulta
    {
        private readonly IProveedorServicio _proveedorServicio;
        public _00104_Proveedor(ISeguridadServicio seguridadServicio,
                                IConfiguracionServicio configuracionServicio,
                                ILogger logger,
                                IProveedorServicio proveedorServicio)
                                : base(seguridadServicio, configuracionServicio, logger)
        {
            InitializeComponent();

            base.BotoneraLateralVisible = (false, false); // (Panel Botonera, Panel Abrir-Cerrar)
            base.TituloFormulario = FormularioConstantes.Titulo;
            base.Titulo = "Proveedor";
            base.Logo = IconChar.UserGroup;

            _proveedorServicio = proveedorServicio;
        }

        public override bool EjecutarComandoNuevo(object sender, EventArgs e)
        {
            var formularioAbm = new _00105_Proveedor_Abm(base._seguridadServicio,
                                                         base._configuracionServicio,
                                                         base._logger,
                                                         Program.Container.GetInstance<IProveedorServicio>(),
                                                         Program.Container.GetInstance<ITipoResponsabilidadServicio>(),
                                                         TipoOperacion.Nuevo);

            FormularioSeguridad.VerificarAcceso(formularioAbm, base._seguridadServicio, base._logger, base._configuracionDTO);

            return formularioAbm.RealizoAlgunaOperacion;
        }

        public override bool EjecutarComandoEditar(object sender, EventArgs e)
        {
            var formularioAbm = new _00105_Proveedor_Abm(base._seguridadServicio,
                                                         base._configuracionServicio,
                                                         base._logger,
                                                         Program.Container.GetInstance<IProveedorServicio>(),
                                                         Program.Container.GetInstance<ITipoResponsabilidadServicio>(),
                                                         TipoOperacion.Modificar,
                                                         EntidadId);

            FormularioSeguridad.VerificarAcceso(formularioAbm, base._seguridadServicio, base._logger, base._configuracionDTO);

            return formularioAbm.RealizoAlgunaOperacion;
        }

        public override bool EjecutarComandoEliminar(object sender, EventArgs e)
        {
            try
            {
                _proveedorServicio.Delete(new ProveedorDeleteDTO { Id = base.EntidadId.Value }, Properties.Settings.Default.UserLogin);

                return true;
            }
            catch
            {
                return false;
            }
        }

        public override void Buscar(string cadenaBuscar, bool verEliminados = false)
        {
            var result = _proveedorServicio.GetByFilter(new ProveedorFilterDTO
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
                if (base._configuracionDTO != null && base._configuracionDTO != null && base._configuracionDTO.LogError)
                {
                    _logger.Error($"{base.Titulo}: error al obtener los datos. User: {Properties.Settings.Default.UserLogin}");
                }

                MessageBox.Show("Ocurrió un error al obtener los datos");
            }
        }

        public override void FormatearDatos(DataGridView dgvGrilla)
        {
            try
            {
                base.FormatearDatos(dgvGrilla);

                dgvGrilla.Columns["RazonSocial"].Visible = true;
                dgvGrilla.Columns["RazonSocial"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvGrilla.Columns["RazonSocial"].HeaderText = "Razón Social";
                dgvGrilla.Columns["RazonSocial"].DisplayIndex = 0;
                dgvGrilla.Columns["RazonSocial"].ReadOnly = true;

                dgvGrilla.Columns["CUIT"].Visible = true;
                dgvGrilla.Columns["CUIT"].Width = 120;
                dgvGrilla.Columns["CUIT"].HeaderText = "CUIT";
                dgvGrilla.Columns["CUIT"].DisplayIndex = 1;
                dgvGrilla.Columns["CUIT"].ReadOnly = true;

                dgvGrilla.Columns["Telefono"].Visible = true;
                dgvGrilla.Columns["Telefono"].Width = 100;
                dgvGrilla.Columns["Telefono"].HeaderText = "Telefono";
                dgvGrilla.Columns["Telefono"].DisplayIndex = 2;
                dgvGrilla.Columns["Telefono"].ReadOnly = true;

                dgvGrilla.Columns["Mail"].Visible = true;
                dgvGrilla.Columns["Mail"].Width = 200;
                dgvGrilla.Columns["Mail"].HeaderText = "E-Mail";
                dgvGrilla.Columns["Mail"].DisplayIndex = 3;
                dgvGrilla.Columns["Mail"].ReadOnly = true;

                dgvGrilla.Columns["ActivarCuentaCorriente"].Visible = true;
                dgvGrilla.Columns["ActivarCuentaCorriente"].Width = 70;
                dgvGrilla.Columns["ActivarCuentaCorriente"].HeaderText = "Cta-Cte";
                dgvGrilla.Columns["ActivarCuentaCorriente"].DisplayIndex = 4;
                dgvGrilla.Columns["ActivarCuentaCorriente"].ReadOnly = true;
            }
            catch (Exception ex)
            {
                if (base._configuracionDTO != null && base._configuracionDTO != null && base._configuracionDTO.LogError)
                {
                    _logger.Error(ex, $"Error en el formateo de las columnas en {base.Titulo}.");
                }

                MessageBox.Show("Los nombres de las columnas no coinciden");
            }
        }
    }
}
