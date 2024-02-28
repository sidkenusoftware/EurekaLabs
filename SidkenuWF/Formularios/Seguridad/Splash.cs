using Sidkenu.LogicaNegocio.Servicios.DTOs.Seguridad.Configuracion;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Seguridad.Empresa;
using Sidkenu.LogicaNegocio.Servicios.Interface.Seguridad;
using System.ComponentModel;

namespace SidkenuWF.Formularios.Seguridad
{
    public partial class Splash : Form
    {
        private readonly IConectividadServicio _conectividadServicio;
        private readonly IEmpresaServicio _empresaServicio;
        private readonly IConfiguracionServicio _configuracionServicio;

        private bool _ejecutarAsistente;
        private bool _loginNormal;

        public (bool, bool, bool) Resultado { get; private set; } // (Puede Continuar, Ejecutar Asistente, Login Normal)

        public Splash(IConectividadServicio conectividadServicio,
                      IEmpresaServicio empresaServicio,
                      IConfiguracionServicio configuracionServicio)
        {
            InitializeComponent();

            _conectividadServicio = conectividadServicio;
            _empresaServicio = empresaServicio;
            _configuracionServicio = configuracionServicio;

            _ejecutarAsistente = false;
            _loginNormal = true;
        }

        private void BgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                for (int i = 1; i <= 10; i++)
                {
                    if (bgWorker.CancellationPending)
                    {
                        e.Cancel = true;
                        break;
                    }

                    bgWorker.ReportProgress(i * 10);
                    Thread.Sleep(100);
                }
            }
            catch (Exception)
            {
                e.Cancel = true;
            }
        }

        private void BgWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            pgBar.Value = e.ProgressPercentage;

            try
            {
                if (e.ProgressPercentage == 30)
                {
                    this.lblMensaje.Text = "Verificando conexión con la Base de Datos...";
                    if (!_conectividadServicio.VerificarSiBaseDatosEstaOperativa())
                    {
                        bgWorker.CancelAsync();
                        MessageBox.Show("La base de datos no se encuentra accesible. Comuniquese con el Administrador", "Atención");
                    }
                }

                if (e.ProgressPercentage == 50)
                {
                    this.lblMensaje.Text = "Verificando datos...";
                    var empresaResult = _empresaServicio.GetAll();

                    if (empresaResult.State)
                    {
                        if (!((List<EmpresaDTO>)empresaResult.Data).Any())
                        {
                            _ejecutarAsistente = true;
                        }
                    }
                    else
                    {
                        bgWorker.CancelAsync();
                    }
                }

                if (e.ProgressPercentage == 70)
                {
                    this.lblMensaje.Text = "Cargando configuración...";
                    var configuracionResult = _configuracionServicio.Get();

                    if (configuracionResult.State)
                    {
                        var config = (ConfiguracionDTO)configuracionResult.Data;

                        if (config != null)
                        {
                            _loginNormal = config.LoginNormal;
                        }
                        else
                        {
                            _loginNormal = true;
                        }
                    }
                    else
                    {
                        bgWorker.CancelAsync();
                    }
                }
            }
            catch (Exception)
            {
                bgWorker.CancelAsync();
            }
        }

        private void BgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                this.Resultado = (false, false, _loginNormal);
            }
            else
            {
                this.Resultado = (true, _ejecutarAsistente, _loginNormal);
            }

            this.Close();
        }

        private void _99905_Splash_Load(object sender, EventArgs e)
        {
            this.lblMensaje.Text = string.Empty;

            if (!bgWorker.IsBusy)
            {
                bgWorker.RunWorkerAsync();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
