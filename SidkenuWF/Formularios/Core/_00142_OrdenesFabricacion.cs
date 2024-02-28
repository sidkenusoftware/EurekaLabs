using FontAwesome.Sharp;
using Serilog;
using Sidkenu.AccesoDatos.CadenaConexion;
using Sidkenu.AccesoDatos.Constantes.Enum;
using Sidkenu.AccesoDatos.Entidades.Core;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.OrdenFabricacion;
using Sidkenu.LogicaNegocio.Servicios.Interface.Core;
using Sidkenu.LogicaNegocio.Servicios.Interface.Seguridad;
using SidkenuWF.Formularios.Base;
using SidkenuWF.Formularios.Base.Constantes;
using SidkenuWF.Formularios.Core.Controles;
using SidkenuWF.Formularios.Core.LookUps;
using SidkenuWF.Helpers;
using System.Media;
using TableDependency.SqlClient;

namespace SidkenuWF.Formularios.Core
{
    public partial class _00142_OrdenesFabricacion : FormularioComun
    {
        private readonly IConexionServicio _conexionServicio;
        private readonly IOrdenFabricacionServicio _ordenFabricacionServicio;

        private SqlTableDependency<OrdenFabricacion> _ordenFabricacionDependency;

        private SoundPlayer player;


        public _00142_OrdenesFabricacion(ISeguridadServicio seguridadServicio,
                                         IConfiguracionServicio configuracionServicio,
                                         ILogger logger,
                                         IOrdenFabricacionServicio ordenFabricacionServicio,
                                         IConexionServicio conexionServicio)
                                        : base(seguridadServicio, configuracionServicio, logger)
        {
            InitializeComponent();

            base.TituloFormulario = FormularioConstantes.Titulo;
            base.Titulo = "Odenes de Fabricación";
            base.Logo = IconChar.BuildingFlag;

            _ordenFabricacionServicio = ordenFabricacionServicio;
            _conexionServicio = conexionServicio;

            player = new SoundPlayer(Properties.Resources.AvisoOrden);
        }

        private void Start_ordenFabricacion_table_dependency()
        {
            _ordenFabricacionDependency = new SqlTableDependency<OrdenFabricacion>(_conexionServicio.ObtenerCadenaConexion(MotoBaseDatos.Obtener), "OrdenFabricaciones");
            _ordenFabricacionDependency.OnChanged += OrdenFabricacionDependency_OnChanged;
            _ordenFabricacionDependency.Start();
        }

        private void Stop_ordenFabricacion_table_dependency()
        {
            if (_ordenFabricacionDependency != null)
            {
                _ordenFabricacionDependency.OnChanged -= OrdenFabricacionDependency_OnChanged;
                _ordenFabricacionDependency.Stop();
            }
        }

        private void OrdenFabricacionDependency_OnChanged(object sender, TableDependency.SqlClient.Base.EventArgs.RecordChangedEventArgs<OrdenFabricacion> e)
        {
            if (e.ChangeType == TableDependency.SqlClient.Base.Enums.ChangeType.Insert)
            {
                EjecutarAvisoSonoro();
                RefreshOrdenes();
            }

            if (e.ChangeType == TableDependency.SqlClient.Base.Enums.ChangeType.Update)
            {
                RefreshOrdenes();
            }
        }

        private void EjecutarAvisoSonoro()
        {            
            player.Play();
        }

        private void RefreshOrdenes()
        {
            var result = _ordenFabricacionServicio.GetByFilter(new OrdenFabricacionFilterDTO
            {
                CadenaBuscar = string.Empty,
                EmpresaId = Properties.Settings.Default.EmpresaId,
                VerEliminados = false
            });

            ThreadSafe(() =>
            {
                if (result != null && result.Data != null)
                {
                    CargarOrdenes((List<OrdenFabricacionDTO>)result.Data);
                }
            });
        }

        private void CargarOrdenes(List<OrdenFabricacionDTO> data)
        {
            CargarOrdenesPendientes(data.Where(x => x.EstadoOrdenFabricacion == EstadoOrdenFabricacion.Pendiente).ToList());
            CargarOrdenesEnProcesos(data.Where(x => x.EstadoOrdenFabricacion == EstadoOrdenFabricacion.EnProceso).ToList());
            CargarOrdenesFinalizados(data.Where(x => x.EstadoOrdenFabricacion ==EstadoOrdenFabricacion.Finalizada).ToList());
        }

        private void CargarOrdenesFinalizados(List<OrdenFabricacionDTO> ordenes)
        {
            DateTime _fechaActual = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0);



            flpFinalizado.Controls.Clear();

            foreach (var _orden in ordenes.Where(x=> !x.FechaFinalizacion.HasValue || x.FechaFinalizacion >= _fechaActual))
            {
                flpFinalizado.Controls.Add(GenerarControlOrdenFabricacion(_orden));
            }
        }

        private void CargarOrdenesEnProcesos(List<OrdenFabricacionDTO> ordenes)
        {
            flpEnProceso.Controls.Clear();

            foreach (var _orden in ordenes)
            {
                flpEnProceso.Controls.Add(GenerarControlOrdenFabricacion(_orden));
            }
        }

        private void CargarOrdenesPendientes(List<OrdenFabricacionDTO> ordenes)
        {
            flpPendientes.Controls.Clear();

            foreach (var _orden in ordenes)
            {
                flpPendientes.Controls.Add(GenerarControlOrdenFabricacion(_orden));
            }
        }

        private CtrolOrdenFabricacion GenerarControlOrdenFabricacion(OrdenFabricacionDTO _ordenFabricacion)
        {
            var _ctrolNuevo = new CtrolOrdenFabricacion(base._seguridadServicio, base._configuracionServicio, base._logger)
            {
                OrdenFabricacionVM = new CtrolOrdenFabricacionVM
                {
                    Id = _ordenFabricacion.Id,
                    Fecha = _ordenFabricacion.Fecha,
                    CantidadProducir = _ordenFabricacion.CantidadFabricar,
                    Descripcion = _ordenFabricacion.ArticuloDescripcion,
                    Numero = _ordenFabricacion.Numero,
                    Detalles = _ordenFabricacion.Detalles,
                    EmpresaId = _ordenFabricacion.EmpresaId,
                    DepositoOrigenId = _ordenFabricacion.DepositoOrigenId,
                    DepositoOrigen = _ordenFabricacion.DepositoOrigen,
                    DepositoDestinoId = _ordenFabricacion.DepositoDestinoId,
                    DepositoDestino = _ordenFabricacion.DepositoDestino,
                    EstadoOrdenFabricacion = _ordenFabricacion.EstadoOrdenFabricacion,
                    ActulizarPrecioPublico = _ordenFabricacion.ActulizarPrecioPublico,
                    ArticuloBaseId = _ordenFabricacion.ArticuloBaseId,
                    ArticuloCodigo = _ordenFabricacion.ArticuloCodigo,
                    SePuedeFabricar = _ordenFabricacion.SePuedeFabricar,
                    OrigenFabricacion = _ordenFabricacion.OrigenFabricacion
                },
            };

            _ctrolNuevo.btnInformacion.Click += BtnInformacion_Click;
            _ctrolNuevo.btnCancelarFabricacion.Click += BtnCancelarFabricacion_Click;
            _ctrolNuevo.btnProcesar.Click += BtnProcesar_Click;
            _ctrolNuevo.btnFinalizar.Click += BtnFinalizar_Click;

            return _ctrolNuevo;
        }

        private void ThreadSafe(MethodInvoker method)
        {
            try
            {
                if (InvokeRequired)
                    Invoke(method);
                else
                    method();
            }
            catch (ObjectDisposedException) { }
        }

        private void _00142_OrdenesFabricacion_Shown(object sender, EventArgs e)
        {
            RefreshOrdenes();
            Start_ordenFabricacion_table_dependency();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            var formulario = new _00143_OrdenFabricacion_Abm(Program.Container.GetInstance<IOrdenFabricacionServicio>(),
                                                             Program.Container.GetInstance<IArticuloServicio>(),
                                                             Program.Container.GetInstance<IDepositoServicio>(),
                                                             base._seguridadServicio,
                                                             base._configuracionServicio,
                                                             Program.Container.GetInstance<IConfiguracionCoreServicio>(),
                                                             base._logger,
                                                             TipoOperacion.Nuevo);

            if (FormularioSeguridad.VerificarAccesoParaAbrirEnPanel(formulario, base._seguridadServicio, base._logger, base._configuracionDTO))
            {
                formulario.ShowDialog();
            }
        }

        private void BtnProcesar_Click(object? sender, EventArgs e)
        {
            if (sender is IconButton)
            {
                var ordenVM = (CtrolOrdenFabricacionVM)((IconButton)sender).Tag;

                if (MessageBox.Show("Esta seguro de Procesar la Orden de Fabricación", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    == DialogResult.Yes)
                {
                    var result = _ordenFabricacionServicio.CambiarEstadoEnProceso(ordenVM.Id, Properties.Settings.Default.UserLogin);

                    if (result.State)
                    {
                        RefreshOrdenes();
                    }
                    else
                    {
                        MessageBox.Show(result.Message, "Atención");
                    }
                }
            }
        }

        private void BtnCancelarFabricacion_Click(object? sender, EventArgs e)
        {
            if (sender is IconButton)
            {
                var ordenVM = (CtrolOrdenFabricacionVM)((IconButton)sender).Tag;

                if (MessageBox.Show("Esta seguro de Cancelar la Fabricacion del Articulo", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    == DialogResult.Yes)
                {
                    var result = _ordenFabricacionServicio.CancelarOrdenFabricacion(ordenVM.Id, Properties.Settings.Default.UserLogin);
                    
                    if (result.State)
                    {
                        RefreshOrdenes();
                    }
                    else
                    {
                        MessageBox.Show(result.Message, "Atención");
                    }
                }
            }
        }

        private void BtnInformacion_Click(object? sender, EventArgs e)
        {
            if (sender is IconButton)
            {
                var ordenVM = (CtrolOrdenFabricacionVM)((IconButton)sender).Tag;

                var fVerDetalleOrdenFabricacion = new VerDetalleOrdenFabricacion(_seguridadServicio,
                                                                                 _configuracionServicio,
                                                                                 _logger,
                                                                                 ordenVM.EstadoOrdenFabricacion,
                                                                                 ordenVM.Detalles,
                                                                                 ordenVM.CantidadProducir,
                                                                                 $"{ordenVM.Descripcion} (Ref:{ordenVM.Numero.ToString().PadLeft(7, '0')})");

                fVerDetalleOrdenFabricacion.ShowDialog();
            }
        }

        private void BtnFinalizar_Click(object? sender, EventArgs e)
        {
            if (sender is IconButton)
            {
                var ordenVM = (CtrolOrdenFabricacionVM)((IconButton)sender).Tag;

                if (MessageBox.Show("Esta seguro de Finalizar la Fabricación del Articulo", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    == DialogResult.Yes)
                {
                    var result = _ordenFabricacionServicio.FinalizarOrdenFabricacion(ordenVM.Id, Properties.Settings.Default.UserLogin);

                    if (result.State)
                    {
                        RefreshOrdenes();
                    }
                    else
                    {
                        MessageBox.Show(result.Message, "Atención");
                    }
                }
            }
        }

        private void _00142_OrdenesFabricacion_FormClosing(object sender, FormClosingEventArgs e)
        {
            Stop_ordenFabricacion_table_dependency();
        }
    }
}