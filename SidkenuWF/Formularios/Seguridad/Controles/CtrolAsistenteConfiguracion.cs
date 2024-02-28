using Sidkenu.LogicaNegocio.Servicios.DTOs.Seguridad.AsistenteCargaInicial;

namespace SidkenuWF.Formularios.Base.Controles
{
    public partial class CtrolAsistenteConfiguracion : CtrolAsistente
    {
        public CtrolAsistenteConfiguracion()
        {
            InitializeComponent();
        }

        public override bool VerificarDatosObligatorios()
        {
            return true;
        }

        public override object? AsignarDatos()
        {
            return new ConfiguracionAsistenteDTO
            {
                LoginNormal = rdbLoginAvatar.Checked ? false : true,
            };
        }
    }
}
