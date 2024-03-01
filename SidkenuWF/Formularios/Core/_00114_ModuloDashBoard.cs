using Serilog;
using Sidkenu.AccesoDatos.CadenaConexion;
using Sidkenu.AccesoDatos.Entidades.Core;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.Comprobante;
using Sidkenu.LogicaNegocio.Servicios.Interface.Core;
using Sidkenu.LogicaNegocio.Servicios.Interface.Seguridad;
using SidkenuWF.Formularios.Base;
using SidkenuWF.Formularios.Core.Model.DashBoard;
using SidkenuWF.Helpers;
using System.Windows.Forms.DataVisualization.Charting;
using TableDependency.SqlClient;
using TableDependency.SqlClient.Base.EventArgs;

namespace SidkenuWF.Formularios.Core
{
    public partial class _00114_ModuloDashBoard : FormularioMenuLateral
    {
        private readonly IConexionServicio _conexionServicio;
        private readonly IComprobanteServicio _comprobanteServicio;

        private SqlTableDependency<Comprobante> _comprobanteDependency;

        public _00114_ModuloDashBoard(ISeguridadServicio seguridadServicio,
                                      IConfiguracionServicio configuracionServicio,
                                      ILogger logger,
                                      IConexionServicio conexionServicio,
                                      IComprobanteServicio comprobanteServicio)
                                      : base(seguridadServicio, configuracionServicio, logger)
        {
            InitializeComponent();

            ctrolDashCaja.Titulo = $"Caja ({DateTime.Today.ToShortDateString()})";
            ctrolDashCaja.ColorTitulo = Color.Yellow;
            ctrolDashCaja.Valor = "$ 0,00";
            ctrolDashCaja.Icono = FontAwesome.Sharp.IconChar.SackDollar;

            ctrolDashCantClientes.Titulo = "Cant. Clientes";
            ctrolDashCantClientes.ColorTitulo = Color.Orange;
            ctrolDashCantClientes.Valor = "0";
            ctrolDashCantClientes.Icono = FontAwesome.Sharp.IconChar.Users;

            ctrolDashTotalVentas.Titulo = $"Total Ventas";
            ctrolDashTotalVentas.ColorTitulo = Color.Beige;
            ctrolDashTotalVentas.Valor = "$ 0,00";
            ctrolDashTotalVentas.Icono = FontAwesome.Sharp.IconChar.SackDollar;

            _conexionServicio = conexionServicio;
            _comprobanteServicio = comprobanteServicio;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        #region Comprobantes

        private void Start_comprobante_table_dependency()
        {
            _comprobanteDependency = new SqlTableDependency<Comprobante>(_conexionServicio.ObtenerCadenaConexion(MotoBaseDatos.Obtener), "Comprobantes");
            _comprobanteDependency.OnChanged += ComprobanteDependency_OnChanged;
            _comprobanteDependency.Start();
        }

        private void Stop_comprobante_table_dependency()
        {
            if (_comprobanteDependency != null)
            {
                _comprobanteDependency.OnChanged -= ComprobanteDependency_OnChanged;
                _comprobanteDependency.Stop();
            }
        }

        private void ComprobanteDependency_OnChanged(object sender, RecordChangedEventArgs<Comprobante> e)
        {
            RefreshComprobantes();
        }

        private void RefreshComprobantes()
        {
            var fechaResult = ObtenerPrimerUltimoDiaSemana(DateTime.Now);

            var result = _comprobanteServicio.GetDatosEstadisticos(fechaResult.Item1, fechaResult.Item2, Properties.Settings.Default.EmpresaId);

            ThreadSafe(() =>
            {
                if (result != null && result.Data != null)
                {
                    var comprobantes = (List<ComprobanteVentaDTO>)result.Data;

                    var listaVentasPorDia = new List<VentaPorDiaVM>();

                    for (int i = 0; i < 7; i++)
                    {
                        var _fecha = fechaResult.Item1.AddDays(i);

                        var _fechaInicio = new DateTime(_fecha.Year, _fecha.Month, _fecha.Day, 0, 0, 0);
                        var _fechaFin = new DateTime(_fecha.Year, _fecha.Month, _fecha.Day, 23, 59, 59);

                        var _lista = comprobantes.Where(x => x.Fecha >= _fechaInicio && x.Fecha <= _fechaFin)
                                                   .GroupBy(x => x.Fecha.Date)
                                                   .Select(x => new VentaPorDiaVM
                                                   {
                                                       Dia = x.Key.Date,
                                                       Valor = x.Sum(s => s.Total)
                                                   })
                                                   .ToList();

                        if (_lista.Count > 0)
                        {
                            listaVentasPorDia.AddRange(_lista);
                        }
                        else 
                        {
                            listaVentasPorDia.Add(new VentaPorDiaVM { Dia = _fecha, Valor = 0 });
                        }
                    }

                    chartVentaSemanal.Series[0].ChartType = SeriesChartType.Column;
                    chartVentaSemanal.Series[0].XValueType = ChartValueType.Date;
                    chartVentaSemanal.Series[0].YValueType = ChartValueType.Double;
                    chartVentaSemanal.Series[0].IsVisibleInLegend = false;

                    // Datos para el Chart
                    foreach (var venta in listaVentasPorDia)
                    {
                        var _point = new DataPoint();

                        _point.SetValueXY(venta.Dia.Date, venta.Valor);

                        _point.Color = ColorAleatorio.Obtener(venta.Dia.Day);
                        
                        chartVentaSemanal.Series[0].Points.Add(_point);
                        

                        // chartVentaSemanal.Series[0].Points.AddXY(venta.Dia, venta.Valor);
                    }

                    // Total de Ventas
                    ctrolDashTotalVentas.Valor = listaVentasPorDia
                         .FirstOrDefault(x => x.Dia.Date == DateTime.Today.Date).Valor.ToString("C2");
                }
            });
        }

        #endregion

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

        private void _00114_ModuloDashBoard_Load(object sender, EventArgs e)
        {
            Start_comprobante_table_dependency();
        }

        private void _00114_ModuloDashBoard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Stop_comprobante_table_dependency();
        }

        private (DateTime, DateTime) ObtenerPrimerUltimoDiaSemana(DateTime fechaActual)
        {
            // Calcula la diferencia para obtener el primer día de la semana (lunes)
            DateTime primerDiaSemana = fechaActual.AddDays(-(int)fechaActual.DayOfWeek + (int)DayOfWeek.Monday);

            // Calcula la diferencia para obtener el último día de la semana (domingo)
            DateTime ultimoDiaSemana = primerDiaSemana.AddDays(6);

            return (primerDiaSemana, ultimoDiaSemana);
        }

        private void _00114_ModuloDashBoard_Shown(object sender, EventArgs e)
        {
            RefreshComprobantes();
        }
    }
}
