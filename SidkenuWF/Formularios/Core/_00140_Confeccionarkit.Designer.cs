namespace SidkenuWF.Formularios.Core
{
    partial class _00140_Confeccionarkit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            pnlEntidadSeleccionada = new Panel();
            label1 = new Label();
            lblEntidadSeleccionada = new Label();
            pnlBotonera = new Panel();
            btnEjecutar = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            nudPrecioPublico = new NumericUpDown();
            label7 = new Label();
            nudStock = new NumericUpDown();
            label3 = new Label();
            dtpFechaVigencia = new DateTimePicker();
            label2 = new Label();
            panel2 = new Panel();
            label9 = new Label();
            chkVerEliminados = new Base.Controles.SidkenuToggleButton();
            nudCantidadArticulos = new NumericUpDown();
            label8 = new Label();
            btnBuscar = new FontAwesome.Sharp.IconButton();
            label6 = new Label();
            txtCodigo = new TextBox();
            btnQuitarProveedor = new FontAwesome.Sharp.IconButton();
            btnAgregarProveedor = new FontAwesome.Sharp.IconButton();
            label31 = new Label();
            txtDescripcion = new TextBox();
            dgvGrilla = new DataGridView();
            txtPrecioPublico = new TextBox();
            txtPrecioCosto = new TextBox();
            label5 = new Label();
            label4 = new Label();
            pnlEntidadSeleccionada.SuspendLayout();
            pnlBotonera.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudPrecioPublico).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudStock).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudCantidadArticulos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvGrilla).BeginInit();
            SuspendLayout();
            // 
            // pnlEntidadSeleccionada
            // 
            pnlEntidadSeleccionada.BackColor = Color.FromArgb(192, 64, 0);
            pnlEntidadSeleccionada.Controls.Add(label1);
            pnlEntidadSeleccionada.Controls.Add(lblEntidadSeleccionada);
            pnlEntidadSeleccionada.Dock = DockStyle.Top;
            pnlEntidadSeleccionada.Location = new Point(0, 59);
            pnlEntidadSeleccionada.Name = "pnlEntidadSeleccionada";
            pnlEntidadSeleccionada.Size = new Size(784, 48);
            pnlEntidadSeleccionada.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(8, 15);
            label1.Name = "label1";
            label1.Size = new Size(142, 17);
            label1.TabIndex = 2;
            label1.Text = "Producto Seleccionado";
            // 
            // lblEntidadSeleccionada
            // 
            lblEntidadSeleccionada.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblEntidadSeleccionada.BackColor = Color.FromArgb(192, 64, 0);
            lblEntidadSeleccionada.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblEntidadSeleccionada.ForeColor = Color.WhiteSmoke;
            lblEntidadSeleccionada.Location = new Point(171, 6);
            lblEntidadSeleccionada.Name = "lblEntidadSeleccionada";
            lblEntidadSeleccionada.Size = new Size(607, 35);
            lblEntidadSeleccionada.TabIndex = 1;
            lblEntidadSeleccionada.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlBotonera
            // 
            pnlBotonera.BackColor = Color.FromArgb(48, 66, 80);
            pnlBotonera.Controls.Add(btnEjecutar);
            pnlBotonera.Dock = DockStyle.Bottom;
            pnlBotonera.Location = new Point(0, 521);
            pnlBotonera.Name = "pnlBotonera";
            pnlBotonera.Size = new Size(784, 40);
            pnlBotonera.TabIndex = 3;
            // 
            // btnEjecutar
            // 
            btnEjecutar.BackColor = Color.FromArgb(54, 74, 90);
            btnEjecutar.FlatAppearance.BorderColor = Color.WhiteSmoke;
            btnEjecutar.FlatAppearance.BorderSize = 0;
            btnEjecutar.FlatStyle = FlatStyle.Flat;
            btnEjecutar.ForeColor = Color.WhiteSmoke;
            btnEjecutar.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            btnEjecutar.IconColor = Color.WhiteSmoke;
            btnEjecutar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEjecutar.IconSize = 22;
            btnEjecutar.Location = new Point(13, 6);
            btnEjecutar.Name = "btnEjecutar";
            btnEjecutar.Size = new Size(96, 28);
            btnEjecutar.TabIndex = 2;
            btnEjecutar.Text = "Guardar";
            btnEjecutar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEjecutar.UseVisualStyleBackColor = false;
            btnEjecutar.Click += BtnEjecutar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.Controls.Add(nudPrecioPublico);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(nudStock);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(dtpFechaVigencia);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 476);
            panel1.Name = "panel1";
            panel1.Size = new Size(784, 45);
            panel1.TabIndex = 4;
            // 
            // nudPrecioPublico
            // 
            nudPrecioPublico.DecimalPlaces = 2;
            nudPrecioPublico.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            nudPrecioPublico.Location = new Point(581, 6);
            nudPrecioPublico.Maximum = new decimal(new int[] { -559939584, 902409669, 54, 0 });
            nudPrecioPublico.Name = "nudPrecioPublico";
            nudPrecioPublico.Size = new Size(169, 33);
            nudPrecioPublico.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(510, 8);
            label7.Name = "label7";
            label7.Size = new Size(65, 25);
            label7.TabIndex = 4;
            label7.Text = "Precio";
            // 
            // nudStock
            // 
            nudStock.DecimalPlaces = 2;
            nudStock.Location = new Point(353, 11);
            nudStock.Maximum = new decimal(new int[] { -559939584, 902409669, 54, 0 });
            nudStock.Name = "nudStock";
            nudStock.Size = new Size(120, 23);
            nudStock.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(259, 15);
            label3.Name = "label3";
            label3.Size = new Size(88, 15);
            label3.TabIndex = 2;
            label3.Text = "Cantidad de Kit";
            // 
            // dtpFechaVigencia
            // 
            dtpFechaVigencia.Format = DateTimePickerFormat.Short;
            dtpFechaVigencia.Location = new Point(115, 11);
            dtpFechaVigencia.Name = "dtpFechaVigencia";
            dtpFechaVigencia.Size = new Size(104, 23);
            dtpFechaVigencia.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 15);
            label2.Name = "label2";
            label2.Size = new Size(86, 15);
            label2.TabIndex = 0;
            label2.Text = "Fecha Vigencia";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gainsboro;
            panel2.Controls.Add(label9);
            panel2.Controls.Add(chkVerEliminados);
            panel2.Controls.Add(nudCantidadArticulos);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(btnBuscar);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(txtCodigo);
            panel2.Controls.Add(btnQuitarProveedor);
            panel2.Controls.Add(btnAgregarProveedor);
            panel2.Controls.Add(label31);
            panel2.Controls.Add(txtDescripcion);
            panel2.Controls.Add(dgvGrilla);
            panel2.Controls.Add(txtPrecioPublico);
            panel2.Controls.Add(txtPrecioCosto);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 107);
            panel2.Name = "panel2";
            panel2.Size = new Size(784, 369);
            panel2.TabIndex = 5;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(19, 314);
            label9.Name = "label9";
            label9.Size = new Size(84, 15);
            label9.TabIndex = 147;
            label9.Text = "Ver Eliminados";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // chkVerEliminados
            // 
            chkVerEliminados.AutoSize = true;
            chkVerEliminados.Location = new Point(109, 310);
            chkVerEliminados.MinimumSize = new Size(45, 22);
            chkVerEliminados.Name = "chkVerEliminados";
            chkVerEliminados.OffBackColor = Color.Gray;
            chkVerEliminados.OffToggleColor = Color.Gainsboro;
            chkVerEliminados.OnBackColor = Color.Green;
            chkVerEliminados.OnToggleColor = Color.WhiteSmoke;
            chkVerEliminados.Size = new Size(45, 22);
            chkVerEliminados.TabIndex = 146;
            chkVerEliminados.UseVisualStyleBackColor = true;
            chkVerEliminados.CheckedChanged += ChkVerEliminados_CheckedChanged;
            // 
            // nudCantidadArticulos
            // 
            nudCantidadArticulos.DecimalPlaces = 2;
            nudCantidadArticulos.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            nudCantidadArticulos.Location = new Point(510, 30);
            nudCantidadArticulos.Maximum = new decimal(new int[] { -559939584, 902409669, 54, 0 });
            nudCantidadArticulos.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudCantidadArticulos.Name = "nudCantidadArticulos";
            nudCantidadArticulos.Size = new Size(89, 29);
            nudCantidadArticulos.TabIndex = 6;
            nudCantidadArticulos.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(510, 10);
            label8.Name = "label8";
            label8.Size = new Size(55, 15);
            label8.TabIndex = 145;
            label8.Text = "Cantidad";
            // 
            // btnBuscar
            // 
            btnBuscar.Anchor = AnchorStyles.Right;
            btnBuscar.BackColor = Color.FromArgb(54, 74, 90);
            btnBuscar.FlatAppearance.BorderColor = Color.WhiteSmoke;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.ForeColor = Color.WhiteSmoke;
            btnBuscar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            btnBuscar.IconColor = Color.WhiteSmoke;
            btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBuscar.IconSize = 20;
            btnBuscar.Location = new Point(609, 30);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(93, 29);
            btnBuscar.TabIndex = 144;
            btnBuscar.Text = "Buscar";
            btnBuscar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += BtnBuscar_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 10);
            label6.Name = "label6";
            label6.Size = new Size(46, 15);
            label6.TabIndex = 143;
            label6.Text = "Codigo";
            // 
            // txtCodigo
            // 
            txtCodigo.BackColor = Color.WhiteSmoke;
            txtCodigo.BorderStyle = BorderStyle.FixedSingle;
            txtCodigo.Enabled = false;
            txtCodigo.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtCodigo.ForeColor = Color.FromArgb(64, 64, 64);
            txtCodigo.Location = new Point(12, 30);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(123, 29);
            txtCodigo.TabIndex = 142;
            // 
            // btnQuitarProveedor
            // 
            btnQuitarProveedor.FlatAppearance.BorderColor = Color.Gray;
            btnQuitarProveedor.FlatStyle = FlatStyle.Flat;
            btnQuitarProveedor.IconChar = FontAwesome.Sharp.IconChar.Trash;
            btnQuitarProveedor.IconColor = Color.Black;
            btnQuitarProveedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnQuitarProveedor.IconSize = 25;
            btnQuitarProveedor.Location = new Point(742, 30);
            btnQuitarProveedor.Name = "btnQuitarProveedor";
            btnQuitarProveedor.Size = new Size(30, 29);
            btnQuitarProveedor.TabIndex = 141;
            btnQuitarProveedor.UseVisualStyleBackColor = true;
            btnQuitarProveedor.Click += BtnQuitarArticulo_Click;
            // 
            // btnAgregarProveedor
            // 
            btnAgregarProveedor.FlatAppearance.BorderColor = Color.Gray;
            btnAgregarProveedor.FlatStyle = FlatStyle.Flat;
            btnAgregarProveedor.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            btnAgregarProveedor.IconColor = Color.Black;
            btnAgregarProveedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAgregarProveedor.IconSize = 25;
            btnAgregarProveedor.Location = new Point(708, 30);
            btnAgregarProveedor.Name = "btnAgregarProveedor";
            btnAgregarProveedor.Size = new Size(30, 29);
            btnAgregarProveedor.TabIndex = 140;
            btnAgregarProveedor.UseVisualStyleBackColor = true;
            btnAgregarProveedor.Click += BtnAgregarArticulo_Click;
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Location = new Point(141, 10);
            label31.Name = "label31";
            label31.Size = new Size(69, 15);
            label31.TabIndex = 139;
            label31.Text = "Descripcion";
            // 
            // txtDescripcion
            // 
            txtDescripcion.BackColor = Color.WhiteSmoke;
            txtDescripcion.BorderStyle = BorderStyle.FixedSingle;
            txtDescripcion.Enabled = false;
            txtDescripcion.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtDescripcion.ForeColor = Color.FromArgb(64, 64, 64);
            txtDescripcion.Location = new Point(141, 30);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(363, 29);
            txtDescripcion.TabIndex = 138;
            // 
            // dgvGrilla
            // 
            dgvGrilla.AllowUserToAddRows = false;
            dgvGrilla.AllowUserToDeleteRows = false;
            dgvGrilla.BackgroundColor = Color.White;
            dgvGrilla.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvGrilla.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvGrilla.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGrilla.GridColor = Color.FromArgb(64, 64, 64);
            dgvGrilla.Location = new Point(13, 65);
            dgvGrilla.MultiSelect = false;
            dgvGrilla.Name = "dgvGrilla";
            dgvGrilla.RowHeadersVisible = false;
            dgvGrilla.RowTemplate.Height = 25;
            dgvGrilla.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGrilla.Size = new Size(760, 238);
            dgvGrilla.TabIndex = 4;
            dgvGrilla.RowEnter += DgvGrilla_RowEnter;
            dgvGrilla.DoubleClick += DgvGrilla_DoubleClick;
            // 
            // txtPrecioPublico
            // 
            txtPrecioPublico.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            txtPrecioPublico.BackColor = Color.FromArgb(64, 64, 64);
            txtPrecioPublico.BorderStyle = BorderStyle.FixedSingle;
            txtPrecioPublico.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtPrecioPublico.ForeColor = Color.Yellow;
            txtPrecioPublico.Location = new Point(602, 330);
            txtPrecioPublico.Name = "txtPrecioPublico";
            txtPrecioPublico.ReadOnly = true;
            txtPrecioPublico.Size = new Size(174, 33);
            txtPrecioPublico.TabIndex = 3;
            txtPrecioPublico.TextAlign = HorizontalAlignment.Center;
            // 
            // txtPrecioCosto
            // 
            txtPrecioCosto.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            txtPrecioCosto.BackColor = Color.FromArgb(64, 64, 64);
            txtPrecioCosto.BorderStyle = BorderStyle.FixedSingle;
            txtPrecioCosto.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtPrecioCosto.ForeColor = Color.Yellow;
            txtPrecioCosto.Location = new Point(422, 330);
            txtPrecioCosto.Name = "txtPrecioCosto";
            txtPrecioCosto.ReadOnly = true;
            txtPrecioCosto.Size = new Size(174, 33);
            txtPrecioCosto.TabIndex = 2;
            txtPrecioCosto.TextAlign = HorizontalAlignment.Center;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(602, 312);
            label5.Name = "label5";
            label5.Size = new Size(141, 15);
            label5.TabIndex = 1;
            label5.Text = "Precio Publico SUGERIDO";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(422, 312);
            label4.Name = "label4";
            label4.Size = new Size(74, 15);
            label4.TabIndex = 0;
            label4.Text = "Precio Costo";
            // 
            // _00140_Confeccionarkit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pnlEntidadSeleccionada);
            Controls.Add(pnlBotonera);
            MinimumSize = new Size(800, 600);
            Name = "_00140_Confeccionarkit";
            Text = "Confeccionar kit";
            Load += _00140_Confeccionarkit_Load;
            Shown += _00140_Confeccionarkit_Shown;
            Controls.SetChildIndex(pnlBotonera, 0);
            Controls.SetChildIndex(pnlEntidadSeleccionada, 0);
            Controls.SetChildIndex(panel1, 0);
            Controls.SetChildIndex(panel2, 0);
            pnlEntidadSeleccionada.ResumeLayout(false);
            pnlEntidadSeleccionada.PerformLayout();
            pnlBotonera.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudPrecioPublico).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudStock).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudCantidadArticulos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvGrilla).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlEntidadSeleccionada;
        private Label lblEntidadSeleccionada;
        private Label label1;
        private Panel pnlBotonera;
        private FontAwesome.Sharp.IconButton btnEjecutar;
        private Panel panel1;
        private NumericUpDown nudStock;
        private Label label3;
        private DateTimePicker dtpFechaVigencia;
        private Label label2;
        private Panel panel2;
        private TextBox txtPrecioCosto;
        private Label label5;
        private Label label4;
        private TextBox txtPrecioPublico;
        public DataGridView dgvGrilla;
        private Label label6;
        private TextBox txtCodigo;
        private FontAwesome.Sharp.IconButton btnQuitarProveedor;
        private FontAwesome.Sharp.IconButton btnAgregarProveedor;
        private Label label31;
        private TextBox txtDescripcion;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private NumericUpDown nudPrecioPublico;
        private Label label7;
        private NumericUpDown nudCantidadArticulos;
        private Label label8;
        private Label label9;
        private Base.Controles.SidkenuToggleButton chkVerEliminados;
    }
}