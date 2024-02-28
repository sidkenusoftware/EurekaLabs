namespace SidkenuWF.Formularios.Core
{
    partial class _00143_OrdenFabricacion_Abm
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
            pnlMenu = new Panel();
            label4 = new Label();
            txtStockDestino = new TextBox();
            label3 = new Label();
            txtStockOrigen = new TextBox();
            btnBuscar = new FontAwesome.Sharp.IconButton();
            label2 = new Label();
            txtCodigo = new TextBox();
            label31 = new Label();
            txtDescripcion = new TextBox();
            nudCantidadFabricar = new NumericUpDown();
            label1 = new Label();
            panel1 = new Panel();
            btnDepositoDestinoNuevo = new FontAwesome.Sharp.IconButton();
            btnDepositoOrigenNuevo = new FontAwesome.Sharp.IconButton();
            label7 = new Label();
            cmbDepositoDestino = new ComboBox();
            label6 = new Label();
            cmbDepositoOrigen = new ComboBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            dgvGrilla = new DataGridView();
            pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudCantidadFabricar).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGrilla).BeginInit();
            SuspendLayout();
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = Color.WhiteSmoke;
            pnlMenu.Controls.Add(label4);
            pnlMenu.Controls.Add(txtStockDestino);
            pnlMenu.Controls.Add(label3);
            pnlMenu.Controls.Add(txtStockOrigen);
            pnlMenu.Controls.Add(btnBuscar);
            pnlMenu.Controls.Add(label2);
            pnlMenu.Controls.Add(txtCodigo);
            pnlMenu.Controls.Add(label31);
            pnlMenu.Controls.Add(txtDescripcion);
            pnlMenu.Controls.Add(nudCantidadFabricar);
            pnlMenu.Controls.Add(label1);
            pnlMenu.Controls.Add(panel1);
            pnlMenu.Controls.Add(btnDepositoDestinoNuevo);
            pnlMenu.Controls.Add(btnDepositoOrigenNuevo);
            pnlMenu.Controls.Add(label7);
            pnlMenu.Controls.Add(cmbDepositoDestino);
            pnlMenu.Controls.Add(label6);
            pnlMenu.Controls.Add(cmbDepositoOrigen);
            pnlMenu.Dock = DockStyle.Top;
            pnlMenu.Location = new Point(0, 57);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(734, 177);
            pnlMenu.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(523, 114);
            label4.Name = "label4";
            label4.Size = new Size(73, 15);
            label4.TabIndex = 155;
            label4.Text = "Stock Actual";
            // 
            // txtStockDestino
            // 
            txtStockDestino.BackColor = Color.WhiteSmoke;
            txtStockDestino.BorderStyle = BorderStyle.FixedSingle;
            txtStockDestino.Enabled = false;
            txtStockDestino.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtStockDestino.ForeColor = Color.FromArgb(64, 64, 64);
            txtStockDestino.Location = new Point(602, 107);
            txtStockDestino.Name = "txtStockDestino";
            txtStockDestino.ReadOnly = true;
            txtStockDestino.Size = new Size(111, 29);
            txtStockDestino.TabIndex = 154;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(523, 81);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 153;
            label3.Text = "Stock Actual";
            // 
            // txtStockOrigen
            // 
            txtStockOrigen.BackColor = Color.WhiteSmoke;
            txtStockOrigen.BorderStyle = BorderStyle.FixedSingle;
            txtStockOrigen.Enabled = false;
            txtStockOrigen.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtStockOrigen.ForeColor = Color.FromArgb(64, 64, 64);
            txtStockOrigen.Location = new Point(602, 74);
            txtStockOrigen.Name = "txtStockOrigen";
            txtStockOrigen.ReadOnly = true;
            txtStockOrigen.Size = new Size(111, 29);
            txtStockOrigen.TabIndex = 152;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(54, 74, 90);
            btnBuscar.FlatAppearance.BorderColor = Color.WhiteSmoke;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.ForeColor = Color.WhiteSmoke;
            btnBuscar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            btnBuscar.IconColor = Color.WhiteSmoke;
            btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBuscar.IconSize = 20;
            btnBuscar.Location = new Point(620, 32);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(93, 29);
            btnBuscar.TabIndex = 151;
            btnBuscar.Text = "Buscar";
            btnBuscar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += BtnBuscar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 12);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 150;
            label2.Text = "Codigo";
            // 
            // txtCodigo
            // 
            txtCodigo.BackColor = Color.WhiteSmoke;
            txtCodigo.BorderStyle = BorderStyle.FixedSingle;
            txtCodigo.Enabled = false;
            txtCodigo.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtCodigo.ForeColor = Color.FromArgb(64, 64, 64);
            txtCodigo.Location = new Point(16, 32);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(123, 29);
            txtCodigo.TabIndex = 149;
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Location = new Point(145, 12);
            label31.Name = "label31";
            label31.Size = new Size(69, 15);
            label31.TabIndex = 148;
            label31.Text = "Descripcion";
            // 
            // txtDescripcion
            // 
            txtDescripcion.BackColor = Color.WhiteSmoke;
            txtDescripcion.BorderStyle = BorderStyle.FixedSingle;
            txtDescripcion.Enabled = false;
            txtDescripcion.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtDescripcion.ForeColor = Color.FromArgb(64, 64, 64);
            txtDescripcion.Location = new Point(145, 32);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(469, 29);
            txtDescripcion.TabIndex = 147;
            // 
            // nudCantidadFabricar
            // 
            nudCantidadFabricar.DecimalPlaces = 2;
            nudCantidadFabricar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            nudCantidadFabricar.Location = new Point(145, 142);
            nudCantidadFabricar.Maximum = new decimal(new int[] { -1593835520, 466537709, 54210, 0 });
            nudCantidadFabricar.Name = "nudCantidadFabricar";
            nudCantidadFabricar.Size = new Size(129, 27);
            nudCantidadFabricar.TabIndex = 142;
            nudCantidadFabricar.TextAlign = HorizontalAlignment.Right;
            nudCantidadFabricar.ValueChanged += NudCantidadFabricar_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(25, 148);
            label1.Name = "label1";
            label1.Size = new Size(114, 16);
            label1.TabIndex = 114;
            label1.Text = "Cantidad Fabricar";
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGray;
            panel1.Location = new Point(15, 67);
            panel1.Name = "panel1";
            panel1.Size = new Size(698, 1);
            panel1.TabIndex = 113;
            // 
            // btnDepositoDestinoNuevo
            // 
            btnDepositoDestinoNuevo.FlatStyle = FlatStyle.Flat;
            btnDepositoDestinoNuevo.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnDepositoDestinoNuevo.IconChar = FontAwesome.Sharp.IconChar.None;
            btnDepositoDestinoNuevo.IconColor = Color.Black;
            btnDepositoDestinoNuevo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDepositoDestinoNuevo.Location = new Point(478, 109);
            btnDepositoDestinoNuevo.Name = "btnDepositoDestinoNuevo";
            btnDepositoDestinoNuevo.Size = new Size(34, 24);
            btnDepositoDestinoNuevo.TabIndex = 112;
            btnDepositoDestinoNuevo.Text = "...";
            btnDepositoDestinoNuevo.UseVisualStyleBackColor = true;
            // 
            // btnDepositoOrigenNuevo
            // 
            btnDepositoOrigenNuevo.FlatStyle = FlatStyle.Flat;
            btnDepositoOrigenNuevo.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnDepositoOrigenNuevo.IconChar = FontAwesome.Sharp.IconChar.None;
            btnDepositoOrigenNuevo.IconColor = Color.Black;
            btnDepositoOrigenNuevo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDepositoOrigenNuevo.Location = new Point(478, 76);
            btnDepositoOrigenNuevo.Name = "btnDepositoOrigenNuevo";
            btnDepositoOrigenNuevo.Size = new Size(34, 24);
            btnDepositoOrigenNuevo.TabIndex = 111;
            btnDepositoOrigenNuevo.Text = "...";
            btnDepositoOrigenNuevo.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(28, 114);
            label7.Name = "label7";
            label7.Size = new Size(111, 16);
            label7.TabIndex = 110;
            label7.Text = "Deposito Destino";
            // 
            // cmbDepositoDestino
            // 
            cmbDepositoDestino.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDepositoDestino.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            cmbDepositoDestino.FormattingEnabled = true;
            cmbDepositoDestino.Location = new Point(145, 109);
            cmbDepositoDestino.Name = "cmbDepositoDestino";
            cmbDepositoDestino.Size = new Size(327, 24);
            cmbDepositoDestino.TabIndex = 109;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(34, 81);
            label6.Name = "label6";
            label6.Size = new Size(105, 16);
            label6.TabIndex = 108;
            label6.Text = "Deposito Origen";
            // 
            // cmbDepositoOrigen
            // 
            cmbDepositoOrigen.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDepositoOrigen.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            cmbDepositoOrigen.FormattingEnabled = true;
            cmbDepositoOrigen.Location = new Point(145, 76);
            cmbDepositoOrigen.Name = "cmbDepositoOrigen";
            cmbDepositoOrigen.Size = new Size(327, 24);
            cmbDepositoOrigen.TabIndex = 107;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 234);
            tabControl1.Name = "tabControl1";
            tabControl1.Padding = new Point(6, 5);
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(734, 237);
            tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dgvGrilla);
            tabPage1.Location = new Point(4, 28);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(726, 205);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Detalle del Articulo seleccionado";
            tabPage1.UseVisualStyleBackColor = true;
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
            dgvGrilla.Dock = DockStyle.Fill;
            dgvGrilla.GridColor = Color.FromArgb(64, 64, 64);
            dgvGrilla.Location = new Point(3, 3);
            dgvGrilla.MultiSelect = false;
            dgvGrilla.Name = "dgvGrilla";
            dgvGrilla.RowHeadersVisible = false;
            dgvGrilla.RowTemplate.Height = 25;
            dgvGrilla.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGrilla.Size = new Size(720, 199);
            dgvGrilla.TabIndex = 5;
            dgvGrilla.CellFormatting += DgvGrilla_CellFormatting;
            // 
            // _00143_OrdenFabricacion_Abm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(734, 511);
            Controls.Add(tabControl1);
            Controls.Add(pnlMenu);
            MaximumSize = new Size(750, 550);
            MinimumSize = new Size(750, 550);
            Name = "_00143_OrdenFabricacion_Abm";
            Text = "Orden de Fabricación";
            Controls.SetChildIndex(pnlMenu, 0);
            Controls.SetChildIndex(tabControl1, 0);
            pnlMenu.ResumeLayout(false);
            pnlMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudCantidadFabricar).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvGrilla).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlMenu;
        private FontAwesome.Sharp.IconButton btnDepositoDestinoNuevo;
        private FontAwesome.Sharp.IconButton btnDepositoOrigenNuevo;
        private Label label7;
        private ComboBox cmbDepositoDestino;
        private Label label6;
        private ComboBox cmbDepositoOrigen;
        private Label label1;
        private Panel panel1;
        private NumericUpDown nudCantidadFabricar;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private Label label2;
        private TextBox txtCodigo;
        private Label label31;
        private TextBox txtDescripcion;
        private Label label4;
        private TextBox txtStockDestino;
        private Label label3;
        private TextBox txtStockOrigen;
        private TabControl tabControl1;
        private TabPage tabPage1;
        public DataGridView dgvGrilla;
    }
}