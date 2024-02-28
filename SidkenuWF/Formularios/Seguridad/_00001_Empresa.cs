using FontAwesome.Sharp;
using Serilog;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Seguridad.Empresa;
using Sidkenu.LogicaNegocio.Servicios.Interface.Seguridad;
using SidkenuWF.Formularios.Base;
using SidkenuWF.Formularios.Base.Constantes;

namespace SidkenuWF.Formularios.Seguridad
{
    public partial class _00001_Empresa : FormularioConsulta
    {
        private readonly IEmpresaServicio _empresaServicio;

        public _00001_Empresa(ISeguridadServicio seguridadServicio,
                              IConfiguracionServicio configuracionServicio,
                              ILogger logger,
                              IEmpresaServicio empresaServicio)
                              : base(seguridadServicio, configuracionServicio, logger)
        {
            InitializeComponent();

            base.BotoneraLateralVisible = (false, true); // (Panel Botonera, Panel Abrir-Cerrar)
            base.TituloFormulario = FormularioConstantes.Titulo;
            base.Titulo = "Empresa";
            base.Logo = IconChar.BuildingFlag;

            CargarAparienciaBotonMenuLateral(this.btnAgregarQuitarEmpleados, false);

            _empresaServicio = empresaServicio;
        }

        private void BtnAgregarQuitarEmpleados_Click(object sender, EventArgs e)
        {
            if (base.dgvGrilla.RowCount > 0)
            {
                var fEmpresaPersona = new _00005_Empresa_Persona(base._seguridadServicio,
                                                                 base._configuracionServicio,
                                                                 base._logger,
                                                                 Program.Container.GetInstance<IEmpresaPersonaServicio>(),
                                                                 Program.Container.GetInstance<IEmpresaServicio>(),
                                                                 base.EntidadId.Value);

                FormularioSeguridad.VerificarAcceso(fEmpresaPersona, base._seguridadServicio, base._logger, base._configuracionDTO);
            }
            else
            {
                MessageBox.Show("No hay Empresas cargadas.", "Atención",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public override bool EjecutarComandoNuevo(object sender, EventArgs e)
        {
            var formularioAbm = new _00002_Empresa_Abm(base._seguridadServicio,
                                                       base._configuracionServicio,
                                                       base._logger,
                                                       Program.Container.GetInstance<IEmpresaServicio>(),
                                                       Program.Container.GetInstance<ITipoResponsabilidadServicio>(),
                                                       Program.Container.GetInstance<IProvinciaServicio>(),
                                                       Program.Container.GetInstance<ILocalidadServicio>(),
                                                       Program.Container.GetInstance<IIngresoBrutoServicio>(),
                                                       TipoOperacion.Nuevo);

            FormularioSeguridad.VerificarAcceso(formularioAbm, base._seguridadServicio, base._logger, base._configuracionDTO);

            return formularioAbm.RealizoAlgunaOperacion;
        }

        public override bool EjecutarComandoEditar(object sender, EventArgs e)
        {
            var formularioAbm = new _00002_Empresa_Abm(base._seguridadServicio,
                                                       base._configuracionServicio,
                                                       base._logger,
                                                       Program.Container.GetInstance<IEmpresaServicio>(),
                                                       Program.Container.GetInstance<ITipoResponsabilidadServicio>(),
                                                       Program.Container.GetInstance<IProvinciaServicio>(),
                                                       Program.Container.GetInstance<ILocalidadServicio>(),
                                                       Program.Container.GetInstance<IIngresoBrutoServicio>(),
                                                       TipoOperacion.Modificar, EntidadId);

            FormularioSeguridad.VerificarAcceso(formularioAbm, _seguridadServicio, _logger, _configuracionDTO);

            return formularioAbm.RealizoAlgunaOperacion;
        }

        public override bool EjecutarComandoEliminar(object sender, EventArgs e)
        {
            try
            {
                _empresaServicio.Delete(new EmpresaDeleteDTO { Id = base.EntidadId.Value }, Properties.Settings.Default.UserLogin);

                return true;
            }
            catch
            {
                return false;
            }
        }

        public override void Buscar(string cadenaBuscar, bool verEliminados = false)
        {
            var result = _empresaServicio.GetByFilter(new EmpresaFilterDTO
            {
                CadenaBuscar = cadenaBuscar,
                VerEliminados = verEliminados
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
                dgvGrilla.Columns["Codigo"].Width = 70;
                dgvGrilla.Columns["Codigo"].HeaderText = "Codigo";
                dgvGrilla.Columns["Codigo"].DisplayIndex = 0;
                dgvGrilla.Columns["Codigo"].ReadOnly = true;

                dgvGrilla.Columns["Abreviatura"].Visible = true;
                dgvGrilla.Columns["Abreviatura"].Width = 75;
                dgvGrilla.Columns["Abreviatura"].HeaderText = "Abreviatura";
                dgvGrilla.Columns["Abreviatura"].DisplayIndex = 1;
                dgvGrilla.Columns["Abreviatura"].ReadOnly = true;

                dgvGrilla.Columns["Descripcion"].Visible = true;
                dgvGrilla.Columns["Descripcion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvGrilla.Columns["Descripcion"].HeaderText = "Nombre";
                dgvGrilla.Columns["Descripcion"].DisplayIndex = 2;
                dgvGrilla.Columns["Descripcion"].ReadOnly = true;

                dgvGrilla.Columns["CUIT"].Visible = true;
                dgvGrilla.Columns["CUIT"].Width = 100;
                dgvGrilla.Columns["CUIT"].HeaderText = "CUIT";
                dgvGrilla.Columns["CUIT"].DisplayIndex = 3;
                dgvGrilla.Columns["CUIT"].ReadOnly = true;

                dgvGrilla.Columns["Telefono"].Visible = true;
                dgvGrilla.Columns["Telefono"].Width = 100;
                dgvGrilla.Columns["Telefono"].HeaderText = "Telefono";
                dgvGrilla.Columns["Telefono"].DisplayIndex = 4;
                dgvGrilla.Columns["Telefono"].ReadOnly = true;

                dgvGrilla.Columns["Mail"].Visible = true;
                dgvGrilla.Columns["Mail"].Width = 200;
                dgvGrilla.Columns["Mail"].HeaderText = "E-Mail";
                dgvGrilla.Columns["Mail"].DisplayIndex = 5;
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
