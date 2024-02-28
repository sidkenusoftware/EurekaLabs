using Sidkenu.LogicaNegocio.Servicios.DTOs.Seguridad.AsistenteCargaInicial;
using Sidkenu.LogicaNegocio.Servicios.Interface.Seguridad;
using SidkenuWF.Formularios.Base.Controles;

namespace SidkenuWF.Formularios.Seguridad
{
    public partial class AsistenteInicioSistema : Form
    {
        private readonly IAsistenteCargaInicialServicio _asistenteServicio;

        private readonly CtrolAsistente[] _listaDeControles;

        private int _indice;
        private int _cantidadControles;

        private readonly CtrolAsistenteEmpresa _ctrolAsistenteEmpresa;
        private readonly CtrolAsistentePersona _ctrolAsistentePersona;
        private readonly CtrolAsistenteConfiguracion _ctrolAsistenteConfiguracion;

        public AsistenteInicioSistema(IAsistenteCargaInicialServicio asistenteServicio)
        {
            InitializeComponent();

            _asistenteServicio = asistenteServicio;

            this.Text = Base.Constantes.FormularioConstantes.Titulo;

            _listaDeControles = new CtrolAsistente[3];

            _ctrolAsistenteEmpresa = new CtrolAsistenteEmpresa(Program.Container.GetInstance<IIngresoBrutoServicio>(),
                Program.Container.GetInstance<ITipoResponsabilidadServicio>(),
                Program.Container.GetInstance<IProvinciaServicio>(),
                Program.Container.GetInstance<ILocalidadServicio>());

            _ctrolAsistentePersona = new CtrolAsistentePersona();

            _ctrolAsistenteConfiguracion = new CtrolAsistenteConfiguracion();

            _listaDeControles[0] = _ctrolAsistenteEmpresa;
            _listaDeControles[1] = _ctrolAsistentePersona;
            _listaDeControles[2] = _ctrolAsistenteConfiguracion;

            _indice = 0;
            _cantidadControles = 3;


        }

        private void _AsistenteInicioSistema_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < _cantidadControles; i++)
            {
                _listaDeControles[i].Dock = DockStyle.Fill;
            }

            pnlContenedor.Controls.AddRange(_listaDeControles);

            _listaDeControles[_indice].BringToFront();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro de SALIR del Asistente de Configuración del Sistema", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void BtnSiguiente_Click(object sender, EventArgs e)
        {
            if (_indice < _cantidadControles - 1)
            {
                if (!_listaDeControles[_indice].VerificarDatosObligatorios())
                {
                    return;
                }

                _indice++;

                _listaDeControles[_indice].BringToFront();
            }

            foreach (var ctrol in pnlPasos.Controls)
            {
                if (ctrol is SidkenuCircularPictureBox)
                {
                    if (((SidkenuCircularPictureBox)ctrol).Name.Contains(_indice.ToString()))
                    {
                        ((SidkenuCircularPictureBox)ctrol).BorderColor = Color.Lime;
                        ((SidkenuCircularPictureBox)ctrol).BorderColor2 = Color.Lime;
                    }
                }

                if (ctrol is Panel)
                {
                    if (((Panel)ctrol).Name.Contains(_indice.ToString()))
                    {
                        ((Panel)ctrol).BackColor = Color.Lime;
                    }
                }
            }

            if (_indice == _cantidadControles - 1)
            {
                btnSiguiente.Visible = false;
                btnGrabar.Visible = true;
            }
        }

        private void BtnAnterior_Click(object sender, EventArgs e)
        {
            if (_indice > 0)
            {
                _indice--;

                _listaDeControles[_indice].BringToFront();
            }

            foreach (var ctrol in pnlPasos.Controls)
            {
                if (ctrol is SidkenuCircularPictureBox)
                {
                    if (((SidkenuCircularPictureBox)ctrol).Name.Contains((_indice + 1).ToString()))
                    {
                        ((SidkenuCircularPictureBox)ctrol).BorderColor = Color.WhiteSmoke;
                        ((SidkenuCircularPictureBox)ctrol).BorderColor2 = Color.WhiteSmoke;
                    }
                }

                if (ctrol is Panel)
                {
                    if (((Panel)ctrol).Name.Contains((_indice + 1).ToString()))
                    {
                        ((Panel)ctrol).BackColor = Color.WhiteSmoke;
                    }
                }
            }

            if (_indice == 1)
            {
                btnSiguiente.Visible = true;
                btnGrabar.Visible = false;
            }
        }

        private void BtnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                var asistente = new AsistenteDTO
                {
                    Empresa = (EmpresaAsistenteDTO)_ctrolAsistenteEmpresa.AsignarDatos(),
                    Persona = (PersonaAsistenteDTO)_ctrolAsistentePersona.AsignarDatos(),
                    Configuracion = (ConfiguracionAsistenteDTO)_ctrolAsistenteConfiguracion.AsignarDatos(),
                    Formularios = Base.Constantes.FormularioAssemblie.GetAllFormNames(AppDomain.CurrentDomain.GetAssemblies())
                };

                var result = _asistenteServicio.Add(asistente);

                if (result == null || !result.State)
                {
                    MessageBox.Show($"Ocurrió un error al grabar los datos. Por favor comunicarse con el administrador. {result.Message}", "Atención");
                }

                MessageBox.Show($"{result.Message}. El sistema se cerrará", "Atención");
                Application.Exit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atención");
                Application.Exit();
            }
        }
    }
}
