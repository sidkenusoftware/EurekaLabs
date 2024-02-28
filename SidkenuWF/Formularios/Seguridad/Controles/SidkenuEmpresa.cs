using SidkenuWF.Helpers;

namespace SidkenuWF.Formularios.Base.Controles
{
    public partial class SidkenuEmpresa : UserControl
    {
        public Guid Id { get; set; }

        public string Codigo
        {
            set
            {
                this.lblCodigo.Text = value;

                Random random = new Random();
                var numeroLetra = random.Next(65, 90);

                this.lblCodigo.BackColor = ColorAleatorio.Obtener(((char)numeroLetra).ToString());
            }
        }

        public string Abreviatura
        {
            set
            {
                this.lblAbreviatura.Text = value;
            }
        }

        public string Descripcion
        {
            set
            {
                this.lblDescripcion.Text = value;
            }
        }

        public string Direccion
        {
            set
            {
                this.lblDireccion.Text = value;
            }
        }

        public byte[] Logo
        {
            set
            {
                this.imgLogo.Image = ImagenConvert.Convertir_Bytes_Imagen(value);
            }
        }

        public SidkenuEmpresa()
        {
            InitializeComponent();
        }

        private void BtnSeleccionar_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.EmpresaId = Id;
            Properties.Settings.Default.Save();
        }
    }
}
