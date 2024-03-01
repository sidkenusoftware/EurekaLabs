using Sidkenu.LogicaNegocio.Extensiones;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Seguridad.AsistenteCargaInicial;
using SidkenuWF.Helpers;

namespace SidkenuWF.Formularios.Base.Controles
{
    public partial class CtrolAsistentePersona : CtrolAsistente
    {
        public CtrolAsistentePersona()
        {
            InitializeComponent();

            this.lblAnuncio.Text += $" Importante: Al finalizar la registración inicial, se le enviará un correo electrónico con los datos para que pueda ingresar al Sistema {Constantes.FormularioConstantes.Titulo}";
        }

        public override bool VerificarDatosObligatorios()
        {
            if (string.IsNullOrEmpty(txtApellido.Text))
            {
                MessageBox.Show("El Apellido es un dato Obligatorio", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtApellido.Focus();

                return false;
            }

            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("El Nombre es un dato Obligatorio", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNombre.Focus();

                return false;
            }

            if (string.IsNullOrEmpty(txtDireccion.Text))
            {
                MessageBox.Show("La dirección es un dato Obligatorio", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDireccion.Focus();

                return false;
            }

            if (string.IsNullOrEmpty(txtCuil.Text))
            {
                MessageBox.Show("El CUIL es un dato Obligatorio", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCuil.Focus();

                return false;
            }

            if (string.IsNullOrEmpty(txtCorreoElectronico.Text))
            {
                MessageBox.Show("El Correo Electrónico es un dato Obligatorio", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCorreoElectronico.Focus();

                return false;
            }

            if (!txtCorreoElectronico.Text.IsValidEmail())
            {
                MessageBox.Show("Formato de Email inválido", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCorreoElectronico.Focus();

                return false;
            }

            if (string.IsNullOrEmpty(txtTelefono.Text))
            {
                MessageBox.Show("El Teléfono es un dato Obligatorio", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTelefono.Focus();

                return false;
            }

            return true;
        }

        public override object? AsignarDatos()
        {
            var _entidad = new PersonaAsistenteDTO
            {
                Id = Guid.Empty,
                Apellido = txtApellido.Text,
                Nombre = txtNombre.Text,
                Direccion = txtDireccion.Text,
                Foto = ImagenConvert.Convertir_Imagen_Bytes(CtrolFoto.Imagen),
                Mail = txtCorreoElectronico.Text,
                Cuil = txtCuil.Text,
                EstaEliminado = false,
                FechaNacimiento = dtpFechaNacimiento.Value,
                Telefono = txtTelefono.Text,
            };

            return _entidad;
        }
    }
}
