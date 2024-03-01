using Serilog;
using Sidkenu.LogicaNegocio.Extensiones;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Seguridad.AsistenteCargaInicial;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Seguridad.Localidad;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Seguridad.Provincia;
using Sidkenu.LogicaNegocio.Servicios.Interface.Seguridad;
using SidkenuWF.Formularios.Base.Constantes;
using SidkenuWF.Formularios.Seguridad;
using SidkenuWF.Helpers;

namespace SidkenuWF.Formularios.Base.Controles
{
    public partial class CtrolAsistenteEmpresa : CtrolAsistente
    {
        private readonly IIngresoBrutoServicio _ingresoBrutoServicio;
        private readonly ITipoResponsabilidadServicio _condicionIvaServicio;
        private readonly IProvinciaServicio _provinciaServicio;
        private readonly ILocalidadServicio _localidadServicio;

        public CtrolAsistenteEmpresa(IIngresoBrutoServicio ingresoBrutoServicio,
                                     ITipoResponsabilidadServicio condicionIvaServicio,
                                     IProvinciaServicio provinciaServicio,
                                     ILocalidadServicio localidadServicio)
        {
            InitializeComponent();

            _ingresoBrutoServicio = ingresoBrutoServicio;
            _condicionIvaServicio = condicionIvaServicio;
            _provinciaServicio = provinciaServicio;
            _localidadServicio = localidadServicio;

            CargarCombos();
        }

        private void CargarCombos()
        {
            // Condicion de Iva
            var resultCondicionIva = _condicionIvaServicio.GetAll();

            if (resultCondicionIva.State)
            {
                this.cmbCondicionIva.DataSource = resultCondicionIva.Data;
                this.cmbCondicionIva.DisplayMember = "Descripcion";
                this.cmbCondicionIva.ValueMember = "Id";
            }

            // Ingreso Bruto
            var resultIngresoBruto = _ingresoBrutoServicio.GetAll();

            if (resultIngresoBruto.State)
            {
                this.cmbIngresoBruto.DataSource = resultIngresoBruto.Data;
                this.cmbIngresoBruto.DisplayMember = "Descripcion";
                this.cmbIngresoBruto.ValueMember = "Id";
            }

            // Provincia
            var resultProvincia = _provinciaServicio.GetAll();

            if (resultProvincia.State)
            {
                this.cmbProvincia.DataSource = resultProvincia.Data;
                this.cmbProvincia.DisplayMember = "Descripcion";
                this.cmbProvincia.ValueMember = "Id";
            }

            // Localidad
            if (cmbProvincia.Items.Count > 0)
            {
                var resultLocalidad = _localidadServicio.GetByFilter(new LocalidadFilterDTO
                {
                    ProvinciaId = (Guid)this.cmbProvincia.SelectedValue,
                    CadenaBuscar = string.Empty
                });

                if (resultLocalidad.State)
                {
                    this.cmbLocalidad.DataSource = resultLocalidad.Data;
                    this.cmbLocalidad.DisplayMember = "Descripcion";
                    this.cmbLocalidad.ValueMember = "Id";
                }
            }
        }

        public override bool VerificarDatosObligatorios()
        {
            if (string.IsNullOrEmpty(txtCodigo.Text))
            {
                MessageBox.Show("El codigo es un dato Obligatorio", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCodigo.Focus();

                return false;
            }

            if (string.IsNullOrEmpty(txtAbreviatura.Text))
            {
                MessageBox.Show("La abreviatura es un dato Obligatorio", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtAbreviatura.Focus();

                return false;
            }

            if (string.IsNullOrEmpty(txtDescripcion.Text))
            {
                MessageBox.Show("El Nombre de la Compañia es un dato Obligatorio", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDescripcion.Focus();

                return false;
            }

            if (string.IsNullOrEmpty(txtDireccion.Text))
            {
                MessageBox.Show("La dirección es un dato Obligatorio", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDireccion.Focus();

                return false;
            }

            if (string.IsNullOrEmpty(txtCuit.Text))
            {
                MessageBox.Show("El CUIT es un dato Obligatorio", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCuit.Focus();

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

            if (string.IsNullOrEmpty(txtIngresoBruto.Text))
            {
                MessageBox.Show("El Nro de Ingreso Bruto es un dato Obligatorio", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtIngresoBruto.Focus();

                return false;
            }

            if (this.cmbCondicionIva.Items.Count <= 0)
            {
                MessageBox.Show("La Condicion de Iva es un dato Obligatorio", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbCondicionIva.Focus();

                return false;
            }

            if (this.cmbIngresoBruto.Items.Count <= 0)
            {
                MessageBox.Show("El Ingreso Bruto es un dato Obligatorio", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbIngresoBruto.Focus();

                return false;
            }

            if (this.cmbLocalidad.Items.Count <= 0)
            {
                MessageBox.Show("La localidad es un dato Obligatorio", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbLocalidad.Focus();

                return false;
            }

            if (this.cmbProvincia.Items.Count <= 0)
            {
                MessageBox.Show("La provincia es un dato Obligatorio", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbProvincia.Focus();

                return false;
            }

            return true;
        }

        public override object? AsignarDatos()
        {
            var _entidad = new EmpresaAsistenteDTO
            {
                Id = Guid.Empty,
                LocalidadId = (Guid)cmbLocalidad.SelectedValue,
                IngresoBrutoId = (Guid)cmbIngresoBruto.SelectedValue,
                TipoResponsabilidadId = (Guid)cmbCondicionIva.SelectedValue,
                Codigo = int.Parse(txtCodigo.Text),
                Abreviatura = txtAbreviatura.Text,
                Descripcion = txtDescripcion.Text,
                Direccion = txtDireccion.Text,
                Logo = ImagenConvert.Convertir_Imagen_Bytes(CtrolFoto.Imagen),
                Mail = txtCorreoElectronico.Text,
                Cuit = txtCuit.Text,
                EstaEliminado = false,
                NroIngresoBruto = txtIngresoBruto.Text,
                FechaInicioActividad = dtpFechaInicioActividades.Value,
                Referente = txtReferente.Text,
                Telefono = txtTelefono.Text,
            };

            return _entidad;
        }

        private void BtnNuevoIngresoBruto_Click(object sender, EventArgs e)
        {
            try
            {
                var formularioNuevo = new _00014_IngresoBruto_Abm(Program.Container.GetInstance<ISeguridadServicio>(),
                                                                  Program.Container.GetInstance<IConfiguracionServicio>(),
                                                                  Program.Container.GetInstance<ILogger>(),
                                                                  Program.Container.GetInstance<IIngresoBrutoServicio>(),
                                                                  TipoOperacion.Nuevo);

                if (formularioNuevo != null)
                {
                    formularioNuevo.ShowDialog();

                    if (formularioNuevo.RealizoAlgunaOperacion)
                    {
                        var resul = _ingresoBrutoServicio.GetAll();

                        if (resul.State)
                        {
                            this.cmbIngresoBruto.DataSource = resul.Data;
                            this.cmbIngresoBruto.DisplayMember = "Descripcion";
                            this.cmbIngresoBruto.ValueMember = "Id";
                        }
                        else
                        {
                            MessageBox.Show("Ocurrió un error al obtener los Ingresos Brutos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error al generar un nuevo registro");
            }
        }

        private void BtnNuevaCondicionIva_Click(object sender, EventArgs e)
        {
            try
            {
                var formularioNuevo = new _00012_TipoResponsabilidad_Abm(Program.Container.GetInstance<ISeguridadServicio>(),
                                                                         Program.Container.GetInstance<IConfiguracionServicio>(),
                                                                         Program.Container.GetInstance<ILogger>(),
                                                                         Program.Container.GetInstance<ITipoResponsabilidadServicio>(),
                                                                         TipoOperacion.Nuevo);

                if (formularioNuevo != null)
                {
                    formularioNuevo.ShowDialog();

                    if (formularioNuevo.RealizoAlgunaOperacion)
                    {
                        var resul = _condicionIvaServicio.GetAll();

                        if (resul.State)
                        {
                            this.cmbCondicionIva.DataSource = resul.Data;
                            this.cmbCondicionIva.DisplayMember = "Descripcion";
                            this.cmbCondicionIva.ValueMember = "Id";
                        }
                        else
                        {
                            MessageBox.Show("Ocurrió un error al obtener las Condiciones de Iva", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error al generar un nuevo registro");
            }
        }

        private void BtnNuevaProvincia_Click(object sender, EventArgs e)
        {
            try
            {
                var formularioNuevo = new _00008_Provincia_Abm(Program.Container.GetInstance<ISeguridadServicio>(),
                                                               Program.Container.GetInstance<IConfiguracionServicio>(),
                                                               Program.Container.GetInstance<ILogger>(),
                                                               Program.Container.GetInstance<IProvinciaServicio>(),
                                                               TipoOperacion.Nuevo);

                if (formularioNuevo != null)
                {
                    formularioNuevo.ShowDialog();

                    if (formularioNuevo.RealizoAlgunaOperacion)
                    {
                        var resul = _provinciaServicio.GetAll();

                        if (resul.State)
                        {
                            this.cmbProvincia.DataSource = resul.Data;
                            this.cmbProvincia.DisplayMember = "Descripcion";
                            this.cmbProvincia.ValueMember = "Id";

                            if (((List<ProvinciaDTO>)resul.Data).Any())
                            {
                                var provinciaId = (Guid)cmbProvincia.SelectedValue;

                                var resultLocalidad = _localidadServicio
                                    .GetByFilter(new LocalidadFilterDTO { ProvinciaId = provinciaId });

                                if (resultLocalidad.State)
                                {
                                    this.cmbLocalidad.DataSource = resultLocalidad.Data;
                                    this.cmbLocalidad.DisplayMember = "Descripcion";
                                    this.cmbLocalidad.ValueMember = "Id";
                                }
                                else
                                {
                                    MessageBox.Show("Ocurrió un error al obtener las localidades", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Ocurrió un error al obtener las provincias", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error al generar un nuevo registro");
            }
        }

        private void BtnNuevaLocalidad_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbProvincia.Items.Count > 0)
                {
                    var formularioNuevo = new _00010_Localidad_Abm(Program.Container.GetInstance<ISeguridadServicio>(),
                                                                   Program.Container.GetInstance<IConfiguracionServicio>(),
                                                                   Program.Container.GetInstance<ILogger>(),
                                                                   Program.Container.GetInstance<ILocalidadServicio>(),
                                                                   Program.Container.GetInstance<IProvinciaServicio>(),
                                                                   TipoOperacion.Nuevo, null, (Guid)cmbProvincia.SelectedValue);

                    if (formularioNuevo != null)
                    {
                        formularioNuevo.ShowDialog();

                        if (formularioNuevo.RealizoAlgunaOperacion)
                        {
                            var resul = _localidadServicio.GetByFilter(new LocalidadFilterDTO { ProvinciaId = (Guid)cmbProvincia.SelectedValue });

                            if (resul.State)
                            {
                                this.cmbLocalidad.DataSource = resul.Data;
                                this.cmbLocalidad.DisplayMember = "Descripcion";
                                this.cmbLocalidad.ValueMember = "Id";
                            }
                            else
                            {
                                MessageBox.Show("Ocurrió un error al obtener las localidades", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No hay una Provincia seleccionada", "Atención", MessageBoxButtons.OK);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error al generar un nuevo registro");
            }
        }
    }
}
