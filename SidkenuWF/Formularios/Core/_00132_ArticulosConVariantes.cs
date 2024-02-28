using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.ArticuloVariante;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.Variante;
using Sidkenu.LogicaNegocio.Servicios.Interface.Core;
using SidkenuWF.Formularios.Base;
using SidkenuWF.Formularios.Base.Constantes;
using SidkenuWF.Formularios.Core.Controles;

namespace SidkenuWF.Formularios.Core
{
    public partial class _00132_ArticulosConVariantes : FormularioComun
    {
        private readonly Guid _articuloId;
        private readonly IVarianteServicio _varianteServicio;
        private readonly IArticuloVarianteServicio _articuloVarianteServicio;

        private List<VarianteDTO> _variantes;

        private TableLayoutPanel _tableLayoutPanel;

        private int cantFila = 1;
        private int cantColumna = 1;

        public _00132_ArticulosConVariantes(Guid articuloId, string articulo,
            IVarianteServicio varianteServicio,
            IArticuloVarianteServicio articuloVarianteServicio)
        {
            InitializeComponent();

            this._articuloId = articuloId;

            Titulo = "Variantes";
            TituloFormulario = FormularioConstantes.Titulo;
            Logo = FontAwesome.Sharp.IconChar.Box;

            lblArticuloSeleccionada.Text = $"Articulo Seleccionado => {articulo}";
            _varianteServicio = varianteServicio;

            _variantes = new List<VarianteDTO>();

            chkStockPrecioIndividuales.Checked = false;
            pnlStockPrecioIndividual.Visible = false;

            _articuloVarianteServicio = articuloVarianteServicio;
        }

        private void CrearTableLayoutPanel()
        {
            dpbCombinaciones.Controls.Clear();

            _tableLayoutPanel = new TableLayoutPanel
            {
                AutoScroll = true,
                CellBorderStyle = TableLayoutPanelCellBorderStyle.Single,
                Name = "tabla",
                Dock = DockStyle.Fill,
                GrowStyle = TableLayoutPanelGrowStyle.FixedSize
            };

            dpbCombinaciones.Controls.Add(_tableLayoutPanel);
        }

        private void _00132_ArticulosConVariantes_Load(object sender, EventArgs e)
        {
            var result = _varianteServicio.GetAll(Properties.Settings.Default.EmpresaId);

            if (result != null && result.State)
            {
                _variantes = (List<VarianteDTO>)result.Data;
            }

            PoblarComboVariante(cmbVariante1, _variantes.ToList(), "Descripcion", "Id");
            PoblarComboVariante(cmbVariante2, _variantes.ToList(), "Descripcion", "Id");
        }

        private void PoblarComboVariante(ComboBox cmb, List<VarianteDTO> listaVariantes, string displayMember, string valueMember)
        {
            cmb.DataSource = listaVariantes.ToList();
            cmb.DisplayMember = displayMember;
            cmb.ValueMember = valueMember;
        }

        private void BtnCombinarVariantes_Click(object sender, EventArgs e)
        {
            if (cmbVariante1.Items.Count <= 0)
            {
                MessageBox.Show("No hay Variantes Nro 1 cargadas", "Atencion");
                return;
            }

            if (cmbVariante2.Items.Count <= 0)
            {
                MessageBox.Show("No hay Variantes Nro 2 cargadas", "Atencion");
                return;
            }

            cantFila = 1;
            cantColumna = 1;

            var escalaId1 = (Guid)cmbVariante1.SelectedValue;
            var escalaId2 = (Guid)cmbVariante2.SelectedValue;

            if (escalaId1 == escalaId2)
            {
                MessageBox.Show("Las escalas no pueden ser iguales. Por favor seleccione una segunda escala nuevamente.", "Atencion");
                cmbVariante2.Focus();
                return;
            }

            var _escala_1 = _variantes.First(x => x.Id == escalaId1);
            var _escala_2 = _variantes.First(x => x.Id == escalaId2);

            if (!_escala_1.Valores.Any())
            {
                MessageBox.Show($"La escala seleccionada ({_escala_1.Descripcion}) NO tiene valores asignados");
                return;
            }

            if (!_escala_2.Valores.Any())
            {
                MessageBox.Show($"La escala seleccionada ({_escala_2.Descripcion}) NO tiene valores asignados");
                return;
            }

            cantFila = _escala_1.Valores.Count;
            cantColumna = _escala_2.Valores.Count;

            _escala_1.Valores = _escala_1.Valores.OrderBy(x=>x.Descripcion).ToList();
            _escala_2.Valores = _escala_2.Valores.OrderBy(x => x.Descripcion).ToList();

            Control[,] _matrizValores = new Control[cantFila + 1, cantColumna + 1];

            for (int i = 1; i < cantFila + 1; i++)
            {
                if (chkStockPrecioIndividuales.Checked && rdbVariante1.Checked)
                {
                    _matrizValores[i, 0] = new CtrolVarianteTituloConStockPrecio
                    {
                        Dock = DockStyle.Fill,
                        Titulo = _escala_1.Valores[i - 1].Descripcion,
                        Fila = i
                    };
                }
                else
                {
                    _matrizValores[i, 0] = new CtrolVarianteTitulo
                    {
                        Dock = DockStyle.Fill,
                        Titulo = _escala_1.Valores[i - 1].Descripcion,
                    };
                }
            }

            for (int i = 1; i < cantColumna + 1; i++)
            {
                _matrizValores[0, i] = new CtrolVarianteTitulo
                {
                    Dock = DockStyle.Fill,
                    Titulo = _escala_2.Valores[i - 1].Descripcion,
                };
            }

            for (int i = 0; i < cantFila + 1; i++)
            {
                for (int j = 0; j < cantColumna + 1; j++)
                {
                    if (i > 0 && j > 0)
                    {
                        if (chkStockPrecioIndividuales.Checked && rdbIndividual.Checked)
                        {
                            _matrizValores[i, j] = new CtrolVarianteConStockPrecio
                            {
                                Dock = DockStyle.Fill,
                                VarianteValor1Id = _escala_1.Valores[i - 1].Id,
                                VarianteValor2Id = _escala_2.Valores[j - 1].Id,
                                Fila = i
                            };
                        }
                        else
                        {
                            _matrizValores[i, j] = new CtrolVariante
                            {
                                Dock = DockStyle.Fill,
                                VarianteValor1Id = _escala_1.Valores[i - 1].Id,
                                VarianteValor2Id = _escala_2.Valores[j - 1].Id,
                                Fila = i
                            };
                        }
                    }
                }
            }

            _matrizValores[0, 0] = new CtrolVarianteEsquina
            {
                Dock = DockStyle.Fill,
            };

            CrearTableLayoutPanel();
            LimpiarTabla();
            CrearTabla(cantFila, cantColumna, _matrizValores);
        }

        private void LimpiarTabla()
        {
            if (_tableLayoutPanel != null)
            {
                _tableLayoutPanel.SuspendLayout();

                // Elimina los controles anteriores
                for (int row = 1; row < _tableLayoutPanel.RowStyles.Count; row++)
                {
                    for (int col = 1; col < _tableLayoutPanel.ColumnStyles.Count; col++)
                    {
                        Control control = _tableLayoutPanel.GetControlFromPosition(col, row);

                        if (control != null)
                        {
                            _tableLayoutPanel.Controls.Remove(control);
                            control.Dispose(); // Libera los recursos del control
                        }
                    }
                }

                // Elimina las filas y columnas anteriores
                for (int i = _tableLayoutPanel.RowStyles.Count - 1; i >= 0; i--)
                {
                    _tableLayoutPanel.RowStyles.RemoveAt(i);
                }
                for (int i = _tableLayoutPanel.ColumnStyles.Count - 1; i >= 0; i--)
                {
                    _tableLayoutPanel.ColumnStyles.RemoveAt(i);
                }

                _tableLayoutPanel.ResumeLayout();

                _tableLayoutPanel.Controls.Clear();

                _tableLayoutPanel.RowCount = 0;
                _tableLayoutPanel.ColumnCount = 0;

                _tableLayoutPanel.RowStyles.Clear();
                _tableLayoutPanel.ColumnStyles.Clear();
            }
        }

        private void CrearTabla(int cantFila, int cantColumna, Control[,] _matrizValores)
        {
            _tableLayoutPanel.SuspendLayout();

            int rowCount = cantFila + 1;
            int columCount = cantColumna + 1;

            _tableLayoutPanel.RowCount = rowCount;
            _tableLayoutPanel.ColumnCount = columCount;

            float rowSize = 100f / rowCount;
            float columSize = 100f / columCount;

            // Agrega las filas y columnas nuevas

            for (int i = 0; i < rowCount; i++)
            {
                if (chkStockPrecioIndividuales.Checked)
                {
                    _tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 55));
                }
                else
                {
                    if (i == 0)
                    {
                        _tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 50));
                    }
                    else
                    {
                        if (rowCount < 6)
                        {
                            _tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, rowSize));
                        }
                        else
                        {
                            _tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 40));
                        }
                    }
                }
            }

            for (int i = 0; i < columCount; i++)
            {
                if (i == 0)
                {
                    if (chkStockPrecioIndividuales.Checked && rdbIndividual.Checked)
                    {
                        _tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100));
                    }
                    else if (chkStockPrecioIndividuales.Checked && rdbVariante1.Checked)
                    {
                        _tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 240));
                    }
                    else
                    {
                        _tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100));
                    }
                }
                else
                {
                    if (chkStockPrecioIndividuales.Checked && rdbIndividual.Checked)
                    {
                        _tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 179));
                    }
                    else
                    {
                        _tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, columSize));
                    }
                }
            }

            // Agrega nuevos controles
            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < columCount; j++)
                {
                    var control = _matrizValores[i, j];

                    _tableLayoutPanel.Controls.Add(control, j, i);
                }
            }

            _tableLayoutPanel.ResumeLayout();
        }

        private void BtnEjecutar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Esta seguro de generar las variantes seleccionadas", "Atencion",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question)
                == DialogResult.Cancel)
                {
                    return;
                }

                var _listaVariantes = new List<ArticuloVarianteValorPersistenciaDTO>();

                if (!chkStockPrecioIndividuales.Checked)
                {
                    foreach (var ctrol in _tableLayoutPanel.Controls.OfType<CtrolVariante>().Where(x => x.EstaSeleccionado).ToList())
                    {
                        var nuevaEntidad = new ArticuloVarianteValorPersistenciaDTO
                        {
                            ArticuloId = _articuloId,
                            VarianteValor1Id = ctrol.VarianteValor1Id,
                            VarianteValor2Id = ctrol.VarianteValor2Id,
                            UtilizaPrecioStockIndividual = false,
                            Precio = 0,
                            Stock = 0
                        };

                        _listaVariantes.Add(nuevaEntidad);
                    }
                }
                else
                {
                    if (rdbVariante1.Checked)
                    {
                        var listaControles = _tableLayoutPanel.Controls.OfType<CtrolVarianteTituloConStockPrecio>().ToList();

                        foreach (var ctrol in listaControles)
                        {
                            foreach (var ctrolVar in _tableLayoutPanel.Controls.OfType<CtrolVariante>()
                                .Where(x => x.Fila == ctrol.Fila && x.EstaSeleccionado).ToList())
                            {
                                var nuevaEntidad = new ArticuloVarianteValorPersistenciaDTO
                                {
                                    ArticuloId = _articuloId,
                                    VarianteValor1Id = ctrolVar.VarianteValor1Id,
                                    VarianteValor2Id = ctrolVar.VarianteValor2Id,
                                    UtilizaPrecioStockIndividual = true,
                                    Precio = ctrol.Precio,
                                    Stock = ctrol.Stock
                                };

                                _listaVariantes.Add(nuevaEntidad);
                            }
                        }
                    }
                    else
                    {
                        foreach (var ctrolVar in _tableLayoutPanel.Controls.OfType<CtrolVarianteConStockPrecio>()
                                .Where(x => x.EstaSeleccionado).ToList())
                        {
                            var nuevaEntidad = new ArticuloVarianteValorPersistenciaDTO
                            {
                                ArticuloId = _articuloId,
                                VarianteValor1Id = ctrolVar.VarianteValor1Id,
                                VarianteValor2Id = ctrolVar.VarianteValor2Id,
                                UtilizaPrecioStockIndividual = true,
                                Precio = ctrolVar.Precio,
                                Stock = ctrolVar.Stock
                            };

                            _listaVariantes.Add(nuevaEntidad);
                        }
                    }
                }

                var result = _articuloVarianteServicio.Add(_listaVariantes, Properties.Settings.Default.EmpresaId, Properties.Settings.Default.UserLogin);

                MessageBox.Show(result.Message, "Atencion");

                if (result.State)
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ChkStockPrecioIndividuales_CheckedChanged(object sender, EventArgs e)
        {
            pnlStockPrecioIndividual.Visible = chkStockPrecioIndividuales.Checked;

            LimpiarTabla();
        }

        private void RdbVariante1_CheckedChanged(object sender, EventArgs e)
        {
            LimpiarTabla();
        }
    }
}
