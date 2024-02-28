using Sidkenu.LogicaNegocio.Servicios.DTOs.Seguridad.Empresa;
using SidkenuWF.Formularios.Base.Controles;

namespace SidkenuWF.Formularios.Seguridad
{
    public partial class Empresas : Form
    {
        public Empresas(List<EmpresaDTO> empresas)
        {
            InitializeComponent();

            CargarEmpresas(empresas);
        }

        public bool SeleccionoUnaEmpresa { get; private set; }


        private void CargarEmpresas(List<EmpresaDTO> empresas)
        {
            foreach (var empresa in empresas)
            {
                var ctrolEmpresa = new SidkenuEmpresa
                {
                    Id = empresa.Id,
                    Codigo = empresa.Codigo.ToString(),
                    Abreviatura = empresa.Abreviatura,
                    Descripcion = empresa.Descripcion,
                    Direccion = empresa.Direccion,
                    Logo = empresa.Logo,
                };

                ctrolEmpresa.btnSeleccionar.Click += BtnSeleccionar_Click;

                flpContenedor.Controls.Add(ctrolEmpresa);
            }
        }

        private void BtnSeleccionar_Click(object? sender, EventArgs e)
        {
            SeleccionoUnaEmpresa = true;
            this.Close();
        }
    }
}
