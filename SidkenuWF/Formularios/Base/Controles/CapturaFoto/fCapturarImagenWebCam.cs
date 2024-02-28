using AForge.Video;
using AForge.Video.DirectShow;

namespace SidkenuWF.Formularios.Base.Controles.Foto
{
    public partial class fCapturarImagenWebCam : Form
    {
        // Atributos
        private Image imagenCapturada;
        private VideoCaptureDevice? fuenteVideo;
        private FilterInfoCollection dispositivoDeVideos;
        private List<string> listaDeDispositivos;

        // Propiedades
        public Image ImagenCapturada => imagenCapturada;

        public fCapturarImagenWebCam()
        {
            InitializeComponent();

            listaDeDispositivos = new List<string>();
            fuenteVideo = null;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (!(fuenteVideo == null))
            {
                if (fuenteVideo.IsRunning)
                {
                    fuenteVideo.SignalToStop();
                    fuenteVideo = null;

                    imagenCapturada = null;
                }
            }

            this.Close();
        }



        private void fCapturarImagenWebCam_Load(object sender, EventArgs e)
        {
            CargarDispositivos(ref listaDeDispositivos);

            if (listaDeDispositivos.Count <= 0) return;

            this.cmbDispositivo.DataSource = listaDeDispositivos.Select(x => new
            {
                Descripcion = x
            }).ToList();

            this.cmbDispositivo.DisplayMember = "Descripcion";
            this.cmbDispositivo.ValueMember = "Descripcion";



            fuenteVideo = new VideoCaptureDevice(dispositivoDeVideos[this.cmbDispositivo.SelectedIndex].MonikerString);
            fuenteVideo.NewFrame += Video_NuevoFrame;
            fuenteVideo.Start();
        }

        private void cmbDispositivo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (listaDeDispositivos.Count <= 1) return;

            if (!(fuenteVideo == null))
            {
                if (fuenteVideo.IsRunning)
                {
                    fuenteVideo.SignalToStop();
                    fuenteVideo = null;

                    fuenteVideo = new VideoCaptureDevice(dispositivoDeVideos[this.cmbDispositivo.SelectedIndex].MonikerString);
                    fuenteVideo.NewFrame += new NewFrameEventHandler(Video_NuevoFrame);
                    fuenteVideo.Start();
                }
            }
        }

        private void fCapturarImagenWebCam_FormClosed(object sender, FormClosedEventArgs e)
        {
            Dispose(true);
        }

        // Metodos Privados
        private void CargarDispositivos(ref List<string> lista)
        {
            dispositivoDeVideos = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            if (dispositivoDeVideos.Count > 0)
            {
                for (int i = 0; i < dispositivoDeVideos.Count; i++)
                {
                    listaDeDispositivos.Add(dispositivoDeVideos[i].Name);
                }
            }
        }

        private void Video_NuevoFrame(object sender, NewFrameEventArgs eventArgs)
        {
            var Imagen = (Bitmap)eventArgs.Frame.Clone();
            imgImagenWebCam.Image = Imagen;
        }

        private void btnCapturar_Click(object sender, EventArgs e)
        {
            if (fuenteVideo == null) return;

            if (!fuenteVideo.IsRunning) return;

            fuenteVideo.SignalToStop();
            fuenteVideo = null;

            imagenCapturada = this.imgImagenWebCam.Image;
            this.Close();
        }
    }
}
