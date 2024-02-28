namespace SidkenuWF.Formularios.Base.Controles.CapturaFoto
{
    public partial class fCapturarAvatar : Form
    {
        private bool _seleccionoUnaImagen;
        public Image? ImagenSeleccionada { get; set; }


        public fCapturarAvatar()
        {
            InitializeComponent();

            ImagenSeleccionada = null;
            _seleccionoUnaImagen = false;
        }

        private void ImgAvatar1_DoubleClick(object sender, EventArgs e)
        {
            if (sender is PictureBox)
            {
                ImagenSeleccionada = ((PictureBox)sender).Image;
                _seleccionoUnaImagen = true;
                this.Close();
            }
        }

        private void FCapturarAvatar_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_seleccionoUnaImagen)
            {
                ImagenSeleccionada = null;
            }
        }
    }
}
