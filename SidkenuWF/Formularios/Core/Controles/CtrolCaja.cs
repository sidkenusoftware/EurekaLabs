using Serilog;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.Caja;
using Sidkenu.LogicaNegocio.Servicios.Interface.Core;
using Sidkenu.LogicaNegocio.Servicios.Interface.Seguridad;
using SidkenuWF.Formularios.Base.Constantes;

namespace SidkenuWF.Formularios.Core.Controles
{
    public partial class CtrolCaja : UserControl
    {
        public bool RealizoUnGasto { get; set; }

        private CajaDTO _cajaDTO;

        private bool _verDetalle;

        public CajaDTO CajaDTO
        {
            set
            {
                this._cajaDTO = value;

                this.Tag = value;

                this.btnVerDetalle.Tag = value;
                
                this.btnCerrarCaja.Tag = value;

                this.btnTransferir.Tag = value;
                
                this.btnNuevoGasto.Tag = value;
                
                this.btnPagarProveedor.Tag = value;

                this.btnCajaExterna.Tag = value;

                var _tituloInterno = value.Descripcion.Length > 13 ? $"{value.Descripcion.Substring(0, 13)}.." : value.Descripcion;

                this.lblCaja.Text = value.EstaAbierta ? $"{_tituloInterno} (Abierta)" : $"{_tituloInterno} (Cerrada)";

                this.lblMontoApertura.Text = "Inicio Caja: " + (value.MontoApertura.HasValue ? value.MontoApertura.Value.ToString("C2") : 0.ToString("C2"));

                this.btnNuevoGasto.Visible = value.CajaDetalleId.HasValue && value.PermiteGastos && value.EstaAbierta;
                this.btnPagarProveedor.Visible = value.CajaDetalleId.HasValue && value.PermitePagosProveedor && value.EstaAbierta;
                this.btnTransferir.Visible = value.CajaDetalleId.HasValue && value.EstaAbierta;
                this.btnVerDetalle.Visible = value.CajaDetalleId.HasValue && value.EstaAbierta;
                this.btnCerrarCaja.Visible = value.CajaDetalleId.HasValue && value.EstaAbierta;
                this.btnCajaExterna.Visible = value.CajaDetalleId.HasValue && value.EstaAbierta;
            }
        }

        public bool TieneCajaAbierta
        {
            set
            {
                btnAbrirCaja.Enabled = !value;
                btnCerrarCaja.Enabled = value;
            }
        }

        public CtrolCaja()
        {
            InitializeComponent();

            _verDetalle = true;
            RealizoUnGasto = false;
        }

        private void BtnAbrirCaja_Click(object sender, EventArgs e)
        {
            var fAbrirCaja = new _00116_AperturaCaja(_cajaDTO.Id, Program.Container.GetInstance<ICajaServicio>());

            fAbrirCaja.ShowDialog();

            if (fAbrirCaja.RealizoAlgunaOperacion)
            {
                btnAbrirCaja.Enabled = false;
                btnCerrarCaja.Enabled = true;
            }
        }

        private void BtnCerrarCaja_Click(object sender, EventArgs e)
        {
            var fCerrarCaja = new _00117_CerrarCaja(_cajaDTO.Id,
                                                    Program.Container.GetInstance<ICajaServicio>(),
                                                    Program.Container.GetInstance<IEmpresaServicio>());

            fCerrarCaja.ShowDialog();

            if (fCerrarCaja.RealizoAlgunaOperacion)
            {
                btnAbrirCaja.Enabled = true;
                btnCerrarCaja.Enabled = false;
            }
        }

        private void BtnNuevoGasto_Click(object sender, EventArgs e)
        {
            var formularioGasto = new _00118_NuevoGasto(Program.Container.GetInstance<ISeguridadServicio>(),
                                                        Program.Container.GetInstance<IConfiguracionServicio>(),
                                                        Program.Container.GetInstance<ILogger>(),
                                                        Program.Container.GetInstance<IGastosServicio>(),
                                                        Program.Container.GetInstance<ITipoGastoServicio>(),
                                                        Program.Container.GetInstance<IClienteServicio>(),
                                                        Program.Container.GetInstance<IPersonaServicio>(),
                                                        Program.Container.GetInstance<IMovimientoCajaServicio>(),
                                                        _cajaDTO);

            FormularioSeguridad.VerificarAcceso(formularioGasto, Program.Container.GetInstance<ISeguridadServicio>());            
        }

        private void BtnTransferir_Click(object sender, EventArgs e)
        {
            var fTransferirEntreCajas = new _00120_TransferenciaCajas(_cajaDTO.Id,
                                                                      _cajaDTO.Descripcion, 
                                                                      Program.Container.GetInstance<ICajaServicio>(),
                                                                      Program.Container.GetInstance<IEmpresaServicio>());

            fTransferirEntreCajas.ShowDialog();            
        }
    }
}

