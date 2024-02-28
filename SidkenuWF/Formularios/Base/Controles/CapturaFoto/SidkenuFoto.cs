using SidkenuWF.Formularios.Base.Controles.CapturaFoto;

namespace SidkenuWF.Formularios.Base.Controles.Foto
{
    public partial class SidkenuFoto : UserControl
    {
        public Image Imagen
        {
            get => imgFoto.Image;
            set => imgFoto.Image = value;
        }

        public bool ActivarAvatar
        {
            set
            {
                btnAvatar.Visible = value;
            }
        }

        public SidkenuFoto()
        {
            InitializeComponent();

            ActivarAvatar = true;
        }

        private void SidkenuFoto_Load(object sender, EventArgs e)
        {
            this.imgFoto.Image = Properties.Resources.ImagenFondo;

            openDialog.Multiselect = false;
        }

        private void BtnWebCam_Click(object sender, EventArgs e)
        {
            var fWebCam = new fCapturarImagenWebCam();
            fWebCam.ShowDialog();

            this.imgFoto.Image = fWebCam.ImagenCapturada ?? Properties.Resources.ImagenFondo;
        }

        private void BtnCamara_Click(object sender, EventArgs e)
        {
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                this.imgFoto.Image = !string.IsNullOrEmpty(openDialog.FileName)
                    ? Image.FromFile(openDialog.FileName)
                    : Properties.Resources.ImagenFondo;
            }
            else
            {
                this.imgFoto.Image = Properties.Resources.ImagenFondo;
            }
        }

        private void BtnAvatar_Click(object sender, EventArgs e)
        {
            var fCapturarAvatar = new fCapturarAvatar();
            fCapturarAvatar.ShowDialog();

            this.imgFoto.Image = fCapturarAvatar.ImagenSeleccionada
                ??= Properties.Resources.ImagenFondo;
        }
    }
}
