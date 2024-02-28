using FontAwesome.Sharp;
using Serilog;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.Cliente;
using Sidkenu.LogicaNegocio.Servicios.Interface.Core;
using Sidkenu.LogicaNegocio.Servicios.Interface.Seguridad;
using SidkenuWF.Formularios.Base;
using SidkenuWF.Formularios.Base.Constantes;

namespace SidkenuWF.Formularios.Core.LookUps
{
    public partial class ClienteLookUp : FormularioLookUp
    {
        private readonly IClienteServicio _clienteServicio;

        public ClienteLookUp(ISeguridadServicio seguridadServicio,
                             IConfiguracionServicio configuracionServicio,
                             ILogger logger,
                             IClienteServicio clienteServicio)
                             : base(seguridadServicio, configuracionServicio, logger)
        {
            InitializeComponent();

            base.TituloFormulario = FormularioConstantes.Titulo;
            base.Titulo = "Artículos";
            base.Logo = IconChar.BuildingFlag;

            _clienteServicio = clienteServicio;
        }

        public override void Buscar(string cadenaBuscar)
        {
            var result = _clienteServicio.GetByFilterLookUp(new ClienteFilterDTO
            {
                CadenaBuscar = cadenaBuscar,
                VerEliminados = false,
                EmpresaId = Properties.Settings.Default.EmpresaId
            });

            if (result.State)
            {
                this.dgvGrilla.DataSource = result.Data;

                base.Buscar(cadenaBuscar);
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

                dgvGrilla.AllowUserToResizeRows = false;

                dgvGrilla.Columns["RazonSocial"].Visible = true;
                dgvGrilla.Columns["RazonSocial"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvGrilla.Columns["RazonSocial"].HeaderText = "Razón Social / Apellido y Nombre";
                dgvGrilla.Columns["RazonSocial"].DisplayIndex = 0;
                dgvGrilla.Columns["RazonSocial"].ReadOnly = true;

                dgvGrilla.Columns["TipoDocumento"].Visible = true;
                dgvGrilla.Columns["TipoDocumento"].Width = 75;
                dgvGrilla.Columns["TipoDocumento"].HeaderText = "Tipo Doc.";
                dgvGrilla.Columns["TipoDocumento"].DisplayIndex = 1;
                dgvGrilla.Columns["TipoDocumento"].ReadOnly = true;

                dgvGrilla.Columns["Documento"].Visible = true;
                dgvGrilla.Columns["Documento"].Width = 90;
                dgvGrilla.Columns["Documento"].HeaderText = "Documento";
                dgvGrilla.Columns["Documento"].DisplayIndex = 2;
                dgvGrilla.Columns["Documento"].ReadOnly = true;

                dgvGrilla.Columns["Telefono"].Visible = true;
                dgvGrilla.Columns["Telefono"].Width = 100;
                dgvGrilla.Columns["Telefono"].HeaderText = "Telefono";
                dgvGrilla.Columns["Telefono"].DisplayIndex = 3;
                dgvGrilla.Columns["Telefono"].ReadOnly = true;
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
