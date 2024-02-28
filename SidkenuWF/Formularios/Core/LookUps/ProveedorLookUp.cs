using FontAwesome.Sharp;
using Serilog;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.Proveedor;
using Sidkenu.LogicaNegocio.Servicios.Interface.Core;
using Sidkenu.LogicaNegocio.Servicios.Interface.Seguridad;
using SidkenuWF.Formularios.Base;

namespace SidkenuWF.Formularios.Core.LookUps
{
    public partial class ProveedorLookUp : FormularioLookUp
    {
        private readonly IProveedorServicio _proveedorServicio;

        public ProveedorLookUp(ISeguridadServicio seguridadServicio,
                               IConfiguracionServicio configuracionServicio,
                               ILogger logger,
                               IProveedorServicio proveedorServicio)
                               : base(seguridadServicio, configuracionServicio, logger)
        {
            InitializeComponent();

            base.TituloFormulario = Base.Constantes.FormularioConstantes.Titulo;
            base.Titulo = "Proveedores";
            base.Logo = IconChar.BuildingFlag;

            _proveedorServicio = proveedorServicio;
        }

        public override void Buscar(string cadenaBuscar)
        {
            var result = _proveedorServicio.GetByFilter(new ProveedorFilterDTO
            {
                CadenaBuscar = cadenaBuscar,
                VerEliminados = false
            });

            if (result.State)
            {
                this.dgvGrilla.DataSource = result.Data;

                base.Buscar(cadenaBuscar);
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

                dgvGrilla.AllowUserToResizeRows = false;

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
