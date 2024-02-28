namespace SidkenuWF.Formularios.Core
{
    partial class _00115_Movimientos
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
            flpContenedorCajas = new FlowLayoutPanel();
            pnlSeparador1 = new Panel();
            pnlFiltro = new Panel();
            lblCajaSeleccionada = new Label();
            pnlLineaFiltroCaja = new Panel();
            btnBuscar = new FontAwesome.Sharp.IconButton();
            dtpFechaHasta = new DateTimePicker();
            dtpFechaDesde = new DateTimePicker();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            btnVerComprobante = new FontAwesome.Sharp.IconButton();
            panel3 = new Panel();
            panel4 = new Panel();
            label3 = new Label();
            txtTotal = new TextBox();
            dgvGrilla = new DataGridView();
            pnlFiltro.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGrilla).BeginInit();
            SuspendLayout();
            // 
            // flpContenedorCajas
            // 
            flpContenedorCajas.AutoScroll = true;
            flpContenedorCajas.BackColor = Color.White;
            flpContenedorCajas.Dock = DockStyle.Top;
            flpContenedorCajas.Location = new Point(0, 59);
            flpContenedorCajas.Name = "flpContenedorCajas";
            flpContenedorCajas.Size = new Size(800, 140);
            flpContenedorCajas.TabIndex = 1;
            // 
            // pnlSeparador1
            // 
            pnlSeparador1.BackColor = Color.FromArgb(192, 64, 0);
            pnlSeparador1.Dock = DockStyle.Top;
            pnlSeparador1.Location = new Point(0, 199);
            pnlSeparador1.Name = "pnlSeparador1";
            pnlSeparador1.Size = new Size(800, 2);
            pnlSeparador1.TabIndex = 2;
            // 
            // pnlFiltro
            // 
            pnlFiltro.BackColor = Color.WhiteSmoke;
            pnlFiltro.Controls.Add(lblCajaSeleccionada);
            pnlFiltro.Controls.Add(pnlLineaFiltroCaja);
            pnlFiltro.Controls.Add(btnBuscar);
            pnlFiltro.Controls.Add(dtpFechaHasta);
            pnlFiltro.Controls.Add(dtpFechaDesde);
            pnlFiltro.Controls.Add(label2);
            pnlFiltro.Controls.Add(label1);
            pnlFiltro.Dock = DockStyle.Top;
            pnlFiltro.Location = new Point(0, 201);
            pnlFiltro.Name = "pnlFiltro";
            pnlFiltro.Size = new Size(800, 85);
            pnlFiltro.TabIndex = 3;
            // 
            // lblCajaSeleccionada
            // 
            lblCajaSeleccionada.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblCajaSeleccionada.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblCajaSeleccionada.ForeColor = Color.SteelBlue;
            lblCajaSeleccionada.Location = new Point(10, 6);
            lblCajaSeleccionada.Name = "lblCajaSeleccionada";
            lblCajaSeleccionada.Size = new Size(783, 29);
            lblCajaSeleccionada.TabIndex = 6;
            lblCajaSeleccionada.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlLineaFiltroCaja
            // 
            pnlLineaFiltroCaja.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlLineaFiltroCaja.BackColor = Color.Gainsboro;
            pnlLineaFiltroCaja.Location = new Point(8, 40);
            pnlLineaFiltroCaja.Name = "pnlLineaFiltroCaja";
            pnlLineaFiltroCaja.Size = new Size(785, 3);
            pnlLineaFiltroCaja.TabIndex = 5;
            // 
            // btnBuscar
            // 
            btnBuscar.Enabled = false;
            btnBuscar.FlatAppearance.BorderColor = Color.Gray;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.ForeColor = Color.DimGray;
            btnBuscar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            btnBuscar.IconColor = Color.DimGray;
            btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBuscar.IconSize = 20;
            btnBuscar.Location = new Point(453, 49);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(90, 29);
            btnBuscar.TabIndex = 4;
            btnBuscar.Text = "Buscar";
            btnBuscar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += BtnBuscar_Click;
            // 
            // dtpFechaHasta
            // 
            dtpFechaHasta.Enabled = false;
            dtpFechaHasta.Format = DateTimePickerFormat.Short;
            dtpFechaHasta.Location = new Point(315, 52);
            dtpFechaHasta.Name = "dtpFechaHasta";
            dtpFechaHasta.Size = new Size(124, 23);
            dtpFechaHasta.TabIndex = 3;
            dtpFechaHasta.ValueChanged += Control_ValueChanged;
            // 
            // dtpFechaDesde
            // 
            dtpFechaDesde.Enabled = false;
            dtpFechaDesde.Format = DateTimePickerFormat.Short;
            dtpFechaDesde.Location = new Point(94, 52);
            dtpFechaDesde.Name = "dtpFechaDesde";
            dtpFechaDesde.Size = new Size(124, 23);
            dtpFechaDesde.TabIndex = 2;
            dtpFechaDesde.ValueChanged += Control_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Enabled = false;
            label2.Location = new Point(232, 56);
            label2.Name = "label2";
            label2.Size = new Size(71, 15);
            label2.TabIndex = 1;
            label2.Text = "Fecha Hasta";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Enabled = false;
            label1.Location = new Point(15, 56);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 0;
            label1.Text = "Fecha Desde";
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightGray;
            panel2.Controls.Add(btnVerComprobante);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(711, 286);
            panel2.Name = "panel2";
            panel2.Size = new Size(89, 338);
            panel2.TabIndex = 5;
            // 
            // btnVerComprobante
            // 
            btnVerComprobante.BackColor = Color.FromArgb(64, 64, 64);
            btnVerComprobante.Dock = DockStyle.Top;
            btnVerComprobante.FlatAppearance.BorderSize = 0;
            btnVerComprobante.FlatStyle = FlatStyle.Flat;
            btnVerComprobante.ForeColor = Color.White;
            btnVerComprobante.IconChar = FontAwesome.Sharp.IconChar.FileInvoice;
            btnVerComprobante.IconColor = Color.FromArgb(255, 128, 0);
            btnVerComprobante.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnVerComprobante.IconSize = 30;
            btnVerComprobante.Location = new Point(0, 0);
            btnVerComprobante.Name = "btnVerComprobante";
            btnVerComprobante.Size = new Size(89, 73);
            btnVerComprobante.TabIndex = 17;
            btnVerComprobante.Text = "Ver Comprobante";
            btnVerComprobante.TextImageRelation = TextImageRelation.ImageAboveText;
            btnVerComprobante.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(txtTotal);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 573);
            panel3.Name = "panel3";
            panel3.Size = new Size(711, 51);
            panel3.TabIndex = 6;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(192, 64, 0);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(711, 2);
            panel4.TabIndex = 7;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(441, 14);
            label3.Name = "label3";
            label3.Size = new Size(68, 25);
            label3.TabIndex = 6;
            label3.Text = "TOTAL";
            // 
            // txtTotal
            // 
            txtTotal.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtTotal.BackColor = Color.FromArgb(64, 64, 64);
            txtTotal.BorderStyle = BorderStyle.FixedSingle;
            txtTotal.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtTotal.ForeColor = Color.White;
            txtTotal.Location = new Point(515, 8);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(190, 35);
            txtTotal.TabIndex = 5;
            txtTotal.TextAlign = HorizontalAlignment.Right;
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
            dgvGrilla.Location = new Point(0, 286);
            dgvGrilla.MultiSelect = false;
            dgvGrilla.Name = "dgvGrilla";
            dgvGrilla.RowHeadersVisible = false;
            dgvGrilla.RowTemplate.Height = 25;
            dgvGrilla.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGrilla.Size = new Size(711, 287);
            dgvGrilla.TabIndex = 7;
            // 
            // _00115_Movimientos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 624);
            Controls.Add(dgvGrilla);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(pnlFiltro);
            Controls.Add(pnlSeparador1);
            Controls.Add(flpContenedorCajas);
            Name = "_00115_Movimientos";
            Text = "Movimientos";
            Load += _00115_Movimientos_Load;
            Controls.SetChildIndex(flpContenedorCajas, 0);
            Controls.SetChildIndex(pnlSeparador1, 0);
            Controls.SetChildIndex(pnlFiltro, 0);
            Controls.SetChildIndex(panel2, 0);
            Controls.SetChildIndex(panel3, 0);
            Controls.SetChildIndex(dgvGrilla, 0);
            pnlFiltro.ResumeLayout(false);
            pnlFiltro.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGrilla).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flpContenedorCajas;
        private Panel pnlSeparador1;
        private Panel pnlFiltro;
        private DateTimePicker dtpFechaHasta;
        private Label label2;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private Label lblCajaSeleccionada;
        private Panel pnlLineaFiltroCaja;
        private Panel panel2;
        private Panel panel3;
        public DataGridView dgvGrilla;
        private Label label3;
        private TextBox txtTotal;
        private FontAwesome.Sharp.IconButton btnVerComprobante;
        private Panel panel4;
        private DateTimePicker dtpFechaDesde;
        private Label label1;
    }
}