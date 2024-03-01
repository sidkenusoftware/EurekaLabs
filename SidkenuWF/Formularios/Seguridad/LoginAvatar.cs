using Sidkenu.LogicaNegocio.Servicios.DTOs.Seguridad.Usuario;
using Sidkenu.LogicaNegocio.Servicios.Interface.Seguridad;
using SidkenuWF.Formularios.Base.Controles;
using SidkenuWF.Formularios.Base.Controles.LoginAvatar;

namespace SidkenuWF.Formularios.Seguridad
{
    public partial class LoginAvatar : Form
    {
        private readonly IUsuarioServicio _usuarioServicio;

        public bool PuedeIngresar { get; set; }
        public UsuarioDTO? UsuarioLogin { get; private set; }

        public LoginAvatar(IUsuarioServicio usuarioServicio)
        {
            InitializeComponent();

            _usuarioServicio = usuarioServicio;
        }

        private void _99904_LoginAvatar_Load(object sender, EventArgs e)
        {
            CargarAvatars();
        }

        private void CargarAvatars()
        {
            var result = _usuarioServicio.GetByFilter(new UsuarioFilterDTO
            {
                CadenaBuscar = string.Empty,
                VerEliminados = false
            });

            if (result != null && result.State)
            {
                var listaUsuarios = (List<UsuarioDTO>)result.Data;

                foreach (var item in listaUsuarios.Where(x=>x.Existe).ToList())
                {
                    var nuevoAvatar = new CtrolLoginAvatar
                    {
                        Usuario = item,
                    };

                    nuevoAvatar.lblApyNom.Click += Avatar_Click;
                    nuevoAvatar.imgFoto.Click += Avatar_Click;

                    flpContenedor.Controls.Add(nuevoAvatar);
                }
            }
        }

        private void Avatar_Click(object sender, EventArgs e)
        {
            UsuarioDTO usuarioSeleccionado = new UsuarioDTO();

            if (sender is PictureBox)
            {
                usuarioSeleccionado = (UsuarioDTO)((PictureBox)sender).Tag;
            }
            else if (sender is Label)
            {
                usuarioSeleccionado = (UsuarioDTO)((Label)sender).Tag;
            }

            var fPasswordAvatar = new PasswordAvatar(Program.Container.GetInstance<ICuentaServicio>(), usuarioSeleccionado);
            fPasswordAvatar.ShowDialog();

            if (fPasswordAvatar.PuedeAcceder)
            {
                PuedeIngresar = fPasswordAvatar.PuedeAcceder;
                UsuarioLogin = fPasswordAvatar.UsuarioLogin;

                Properties.Settings.Default.UserLogin = usuarioSeleccionado.Nombre;
                Properties.Settings.Default.UserLoginId = usuarioSeleccionado.Id;
                Properties.Settings.Default.PersonaLoginId = usuarioSeleccionado.PersonaId;
                Properties.Settings.Default.PersonaLogin = usuarioSeleccionado.ApyNomPersona;

                if (UsuarioLogin.Empresas.Any())
                {
                    if (UsuarioLogin.Empresas.Count > 1)
                    {
                        var fEmpresas = new Empresas(UsuarioLogin.Empresas);
                        fEmpresas.ShowDialog();

                        if (fEmpresas.SeleccionoUnaEmpresa)
                        {
                            this.Close();
                        }
                        else
                        {
                            PuedeIngresar = false;
                            this.Close();
                        }
                    }
                    else // Solo esta asociado a  una empresa
                    {
                        var empresaSeleccionada = UsuarioLogin.Empresas.First();

                        Properties.Settings.Default.EmpresaId = empresaSeleccionada.Id;
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show($"El usuario {UsuarioLogin.ApyNomPersona} no esta asociado a ninguna Empresa", "Atención");

                    PuedeIngresar = false;
                    UsuarioLogin = null;

                    Properties.Settings.Default.UserLogin = null;
                    Properties.Settings.Default.UserLoginId = Guid.Empty;
                    Properties.Settings.Default.PersonaLoginId = Guid.Empty;
                    Properties.Settings.Default.PersonaLogin = null;

                    Application.Exit();
                }

                this.Close();
            }
            else
            {
                PuedeIngresar = false;
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            PuedeIngresar = false;
            UsuarioLogin = null;

            Properties.Settings.Default.UserLogin = null;
            Properties.Settings.Default.UserLoginId = Guid.Empty;
            Properties.Settings.Default.PersonaLoginId = Guid.Empty;
            Properties.Settings.Default.PersonaLogin = null;

            Application.Exit();
        }
    }
}
