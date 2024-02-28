using FontAwesome.Sharp;
using Serilog;
using Sidkenu.AccesoDatos.Constantes.Enum;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.Articulo;
using Sidkenu.LogicaNegocio.Servicios.Interface.Core;
using Sidkenu.LogicaNegocio.Servicios.Interface.Seguridad;
using SidkenuWF.Formularios.Base;
using SidkenuWF.Formularios.Base.Constantes;

namespace SidkenuWF.Formularios.Core.LookUps
{
    public partial class ArticuloLookUp : FormularioLookUp
    { 
        private readonly IArticuloServicio _articuloServicio;
        private readonly List<TipoArticulo>? _tipos;

        public ArticuloLookUp(ISeguridadServicio seguridadServicio,
                              IConfiguracionServicio configuracionServicio,
                              ILogger logger,
                              IArticuloServicio articuloServicio,
                              List<TipoArticulo>? tipos = null)
                              : base(seguridadServicio, configuracionServicio, logger)
        {
            InitializeComponent();

            base.TituloFormulario = FormularioConstantes.Titulo;
            base.Titulo = "Artículos";
            base.Logo = IconChar.BuildingFlag;

            _articuloServicio = articuloServicio;
            _tipos = tipos;
        }

        public override void Buscar(string cadenaBuscar)
        {
            if (_tipos == null)
            {
                var result = _articuloServicio.GetByFilterLookUp(new ArticuloFilterDTO
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
            else
            {
                var result = _articuloServicio.GetByFilterLookUp(new ArticuloFilterDTO
                {
                    CadenaBuscar = cadenaBuscar,
                    VerEliminados = false,
                    EmpresaId = Properties.Settings.Default.EmpresaId,                    
                }, _tipos.ToList());

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
        }

        public override void FormatearDatos(DataGridView dgvGrilla)
        {
            try
            {
                base.FormatearDatos(dgvGrilla);

                dgvGrilla.AllowUserToResizeRows = false;

                dgvGrilla.Columns["Codigo"].Visible = true;
                dgvGrilla.Columns["Codigo"].Width = 80;
                dgvGrilla.Columns["Codigo"].HeaderText = "Código";
                dgvGrilla.Columns["Codigo"].DisplayIndex = 0;
                dgvGrilla.Columns["Codigo"].ReadOnly = true;

                dgvGrilla.Columns["Abreviatura"].Visible = true;
                dgvGrilla.Columns["Abreviatura"].Width = 80;
                dgvGrilla.Columns["Abreviatura"].HeaderText = "Abreviatura";
                dgvGrilla.Columns["Abreviatura"].DisplayIndex = 1;
                dgvGrilla.Columns["Abreviatura"].ReadOnly = true;

                dgvGrilla.Columns["CodigoBarra"].Visible = true;
                dgvGrilla.Columns["CodigoBarra"].Width = 100;
                dgvGrilla.Columns["CodigoBarra"].HeaderText = "Código de Barra";
                dgvGrilla.Columns["CodigoBarra"].DisplayIndex = 2;
                dgvGrilla.Columns["CodigoBarra"].ReadOnly = true;

                dgvGrilla.Columns["Descripcion"].Visible = true;
                dgvGrilla.Columns["Descripcion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvGrilla.Columns["Descripcion"].HeaderText = "Articulo";
                dgvGrilla.Columns["Descripcion"].DisplayIndex = 3;
                dgvGrilla.Columns["Descripcion"].ReadOnly = true;

                dgvGrilla.Columns["PrecioCosto"].Visible = true;
                dgvGrilla.Columns["PrecioCosto"].Width = 85;
                dgvGrilla.Columns["PrecioCosto"].HeaderText = "Precio Costo";
                dgvGrilla.Columns["PrecioCosto"].DisplayIndex = 7;
                dgvGrilla.Columns["PrecioCosto"].ReadOnly = true;
                dgvGrilla.Columns["PrecioCosto"].DefaultCellStyle.Format = "C";
                dgvGrilla.Columns["PrecioCosto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                dgvGrilla.Columns["PrecioPublico"].Visible = true;
                dgvGrilla.Columns["PrecioPublico"].Width = 85;
                dgvGrilla.Columns["PrecioPublico"].HeaderText = "Precio Publico";
                dgvGrilla.Columns["PrecioPublico"].DisplayIndex = 8;
                dgvGrilla.Columns["PrecioPublico"].ReadOnly = true;
                dgvGrilla.Columns["PrecioPublico"].DefaultCellStyle.Format = "C";
                dgvGrilla.Columns["PrecioPublico"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
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
