using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.Variante;
using Sidkenu.LogicaNegocio.Servicios.Interface.Core;
using SidkenuWF.Formularios.Base;
using SidkenuWF.Formularios.Base.Constantes;

namespace SidkenuWF.Formularios.Core
{
    public partial class _00135_VarianteValor : FormularioComun
    {
        private readonly IVarianteValorServicio _varianteValorServicio;
        private readonly Guid _escalaId;

        private ValorVarianteDTO _entidadSeleccionada;

        public _00135_VarianteValor(IVarianteValorServicio varianteValorServicio, Guid escalaId, string escala)
        {
            InitializeComponent();

            _varianteValorServicio = varianteValorServicio;
            _escalaId = escalaId;
            Titulo = "Valores";
            TituloFormulario = FormularioConstantes.Titulo;
            Logo = FontAwesome.Sharp.IconChar.Box;

            this.lblVarianteSeleccionada.Text = $"Variante Selecc. => {escala}";

            _entidadSeleccionada = null;
        }

        private void Poblar()
        {
            var result = _varianteValorServicio.GetAll(_escalaId);

            if (result != null && result.State)
            {
                dgvVarianteValor.DataSource = result.Data;
            }
        }

        private void _00135_VarianteValor_Load(object sender, EventArgs e)
        {
            Poblar();
            FormatearGrilla(dgvVarianteValor);
        }

        private void FormatearGrilla(DataGridView dgvGrilla)
        {
            try
            {
                for (int i = 0; i < dgvGrilla.ColumnCount; i++)
                {
                    dgvGrilla.Columns[i].Visible = false;
                }
                
                dgvGrilla.AllowUserToResizeRows = false;

                dgvGrilla.Columns["Codigo"].Visible = true;
                dgvGrilla.Columns["Codigo"].Width = 100;
                dgvGrilla.Columns["Codigo"].HeaderText = "Codigo";
                dgvGrilla.Columns["Codigo"].DisplayIndex = 0;
                dgvGrilla.Columns["Codigo"].ReadOnly = true;

                dgvGrilla.Columns["Descripcion"].Visible = true;
                dgvGrilla.Columns["Descripcion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvGrilla.Columns["Descripcion"].HeaderText = "Descripcion";
                dgvGrilla.Columns["Descripcion"].DisplayIndex = 1;
                dgvGrilla.Columns["Descripcion"].ReadOnly = true;
            }
            catch (Exception ex)
            {
                if (base._configuracionDTO != null && base._configuracionDTO.LogError)
                {
                    _logger.Error(ex, $"Error en el formateo de las columnas en {base.Titulo}.");
                }

                MessageBox.Show("Los nombres de las columnas no coinciden");
            }
        }

        private void BtnAgregarProveedor_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCodigo.Text))
            {
                MessageBox.Show("El codigo es un dato Obligatorio");
                txtCodigo.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtDescripcion.Text))
            {
                MessageBox.Show("La descripcion es un dato Obligatorio");
                txtDescripcion.Focus();
                return;
            }

            try
            {
                var entidad = new ValorVariantePersistenciaDTO
                {
                    VarianteId = _escalaId,
                    Codigo = txtCodigo.Text,
                    Descripcion = txtDescripcion.Text,
                    EstaEliminado = false,
                };

                _varianteValorServicio.Add(entidad, Properties.Settings.Default.UserLogin);

                txtCodigo.Clear();
                txtDescripcion.Clear();

                txtCodigo.Focus();

                Poblar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnQuitarProveedor_Click(object sender, EventArgs e)
        {
            if (dgvVarianteValor.Rows.Count > 0)
            {
                if(MessageBox.Show("Esta seguro de eliminar el valor de la escala", "Atencion", MessageBoxButtons.OKCancel)
                    == DialogResult.OK) 
                {
                    try
                    {
                        _varianteValorServicio.Delete(new ValorVarianteDeleteDTO { Id = _entidadSeleccionada.Id }, 
                            Properties.Settings.Default.UserLogin);

                        Poblar();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else 
            {
                MessageBox.Show("No hay valores de escala cargados");
                txtCodigo.Focus();
            }
        }

        private void DgvVarianteValor_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvVarianteValor.Rows.Count > 0)
            {
                _entidadSeleccionada = (ValorVarianteDTO)dgvVarianteValor.Rows[e.RowIndex].DataBoundItem;
            }
            else
            {
                _entidadSeleccionada = null;
            }
        }
    }
}
