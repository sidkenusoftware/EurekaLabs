namespace SidkenuWF.Formularios.Core
{
    partial class _00158_CajaExterna
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            pnlInferior = new Panel();
            btnFacturar = new FontAwesome.Sharp.IconButton();
            pnlComprobantes = new Panel();
            dgvGrillaComprobante = new DataGridView();
            pnlBuscar = new Panel();
            btnBuscar = new FontAwesome.Sharp.IconButton();
            txtBuscar = new TextBox();
            label2 = new Label();
            pnlContenedorDetalle = new Panel();
            dgvDetalleComprobante = new DataGridView();
            panel4 = new Panel();
            pnlBotoneraComprobante = new Panel();
            label1 = new Label();
            txtTotal = new TextBox();
            pnlInferior.SuspendLayout();
            pnlComprobantes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGrillaComprobante).BeginInit();
            pnlBuscar.SuspendLayout();
            pnlContenedorDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetalleComprobante).BeginInit();
            pnlBotoneraComprobante.SuspendLayout();
            SuspendLayout();
            // 
            // pnlInferior
            // 
            pnlInferior.BackColor = Color.WhiteSmoke;
            pnlInferior.Controls.Add(btnFacturar);
            pnlInferior.Dock = DockStyle.Bottom;
            pnlInferior.Location = new Point(0, 517);
            pnlInferior.Name = "pnlInferior";
            pnlInferior.Size = new Size(784, 44);
            pnlInferior.TabIndex = 1;
            // 
            // btnFacturar
            // 
            btnFacturar.BackColor = Color.FromArgb(54, 74, 90);
            btnFacturar.FlatAppearance.BorderColor = Color.WhiteSmoke;
            btnFacturar.FlatAppearance.BorderSize = 0;
            btnFacturar.FlatStyle = FlatStyle.Flat;
            btnFacturar.ForeColor = Color.WhiteSmoke;
            btnFacturar.IconChar = FontAwesome.Sharp.IconChar.MoneyBills;
            btnFacturar.IconColor = Color.WhiteSmoke;
            btnFacturar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnFacturar.IconSize = 22;
            btnFacturar.Location = new Point(7, 7);
            btnFacturar.Name = "btnFacturar";
            btnFacturar.Size = new Size(140, 30);
            btnFacturar.TabIndex = 7;
            btnFacturar.Text = "(F5) Facturar";
            btnFacturar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnFacturar.UseVisualStyleBackColor = false;
            btnFacturar.Click += BtnFacturar_Click;
            // 
            // pnlComprobantes
            // 
            pnlComprobantes.Controls.Add(dgvGrillaComprobante);
            pnlComprobantes.Controls.Add(pnlBuscar);
            pnlComprobantes.Dock = DockStyle.Left;
            pnlComprobantes.Location = new Point(0, 59);
            pnlComprobantes.Name = "pnlComprobantes";
            pnlComprobantes.Size = new Size(457, 458);
            pnlComprobantes.TabIndex = 2;
            // 
            // dgvGrillaComprobante
            // 
            dgvGrillaComprobante.AllowUserToAddRows = false;
            dgvGrillaComprobante.AllowUserToDeleteRows = false;
            dgvGrillaComprobante.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Red;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvGrillaComprobante.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvGrillaComprobante.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGrillaComprobante.Dock = DockStyle.Fill;
            dgvGrillaComprobante.GridColor = Color.SteelBlue;
            dgvGrillaComprobante.Location = new Point(0, 40);
            dgvGrillaComprobante.MultiSelect = false;
            dgvGrillaComprobante.Name = "dgvGrillaComprobante";
            dgvGrillaComprobante.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle2.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = Color.WhiteSmoke;
            dgvGrillaComprobante.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvGrillaComprobante.RowTemplate.Height = 25;
            dgvGrillaComprobante.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGrillaComprobante.Size = new Size(457, 418);
            dgvGrillaComprobante.TabIndex = 5;
            dgvGrillaComprobante.CellContentClick += DgvGrillaComprobante_CellContentClick;
            dgvGrillaComprobante.RowEnter += DgvGrillaComprobante_RowEnter;
            // 
            // pnlBuscar
            // 
            pnlBuscar.BackColor = Color.Gray;
            pnlBuscar.Controls.Add(btnBuscar);
            pnlBuscar.Controls.Add(txtBuscar);
            pnlBuscar.Controls.Add(label2);
            pnlBuscar.Dock = DockStyle.Top;
            pnlBuscar.Location = new Point(0, 0);
            pnlBuscar.Name = "pnlBuscar";
            pnlBuscar.Size = new Size(457, 40);
            pnlBuscar.TabIndex = 3;
            // 
            // btnBuscar
            // 
            btnBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBuscar.FlatAppearance.BorderColor = Color.WhiteSmoke;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.ForeColor = Color.WhiteSmoke;
            btnBuscar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            btnBuscar.IconColor = Color.WhiteSmoke;
            btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBuscar.IconSize = 15;
            btnBuscar.Location = new Point(403, 8);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(41, 23);
            btnBuscar.TabIndex = 2;
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += BtnBuscar_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBuscar.BorderStyle = BorderStyle.FixedSingle;
            txtBuscar.Location = new Point(58, 8);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(339, 23);
            txtBuscar.TabIndex = 1;
            txtBuscar.KeyPress += TxtBuscar_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(10, 11);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 0;
            label2.Text = "Buscar";
            // 
            // pnlContenedorDetalle
            // 
            pnlContenedorDetalle.Controls.Add(dgvDetalleComprobante);
            pnlContenedorDetalle.Controls.Add(pnlBotoneraComprobante);
            pnlContenedorDetalle.Controls.Add(panel4);
            pnlContenedorDetalle.Dock = DockStyle.Fill;
            pnlContenedorDetalle.Location = new Point(457, 59);
            pnlContenedorDetalle.Name = "pnlContenedorDetalle";
            pnlContenedorDetalle.Size = new Size(327, 458);
            pnlContenedorDetalle.TabIndex = 3;
            // 
            // dgvDetalleComprobante
            // 
            dgvDetalleComprobante.AllowUserToAddRows = false;
            dgvDetalleComprobante.AllowUserToDeleteRows = false;
            dgvDetalleComprobante.BackgroundColor = Color.White;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.Red;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvDetalleComprobante.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvDetalleComprobante.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalleComprobante.Dock = DockStyle.Fill;
            dgvDetalleComprobante.GridColor = Color.SteelBlue;
            dgvDetalleComprobante.Location = new Point(2, 0);
            dgvDetalleComprobante.MultiSelect = false;
            dgvDetalleComprobante.Name = "dgvDetalleComprobante";
            dataGridViewCellStyle4.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle4.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = Color.WhiteSmoke;
            dgvDetalleComprobante.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvDetalleComprobante.RowTemplate.Height = 25;
            dgvDetalleComprobante.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDetalleComprobante.Size = new Size(325, 413);
            dgvDetalleComprobante.TabIndex = 6;
            dgvDetalleComprobante.RowPrePaint += DgvDetalleComprobante_RowPrePaint;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(192, 64, 0);
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(2, 458);
            panel4.TabIndex = 1;
            // 
            // pnlBotoneraComprobante
            // 
            pnlBotoneraComprobante.BackColor = Color.Gainsboro;
            pnlBotoneraComprobante.Controls.Add(label1);
            pnlBotoneraComprobante.Controls.Add(txtTotal);
            pnlBotoneraComprobante.Dock = DockStyle.Bottom;
            pnlBotoneraComprobante.Location = new Point(2, 413);
            pnlBotoneraComprobante.Name = "pnlBotoneraComprobante";
            pnlBotoneraComprobante.Size = new Size(325, 45);
            pnlBotoneraComprobante.TabIndex = 7;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(6, 7);
            label1.Name = "label1";
            label1.Size = new Size(72, 30);
            label1.TabIndex = 3;
            label1.Text = "TOTAL";
            // 
            // txtTotal
            // 
            txtTotal.Anchor = AnchorStyles.Right;
            txtTotal.BackColor = Color.FromArgb(64, 64, 64);
            txtTotal.BorderStyle = BorderStyle.FixedSingle;
            txtTotal.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtTotal.ForeColor = Color.Yellow;
            txtTotal.Location = new Point(84, 3);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(238, 39);
            txtTotal.TabIndex = 2;
            txtTotal.TextAlign = HorizontalAlignment.Right;
            // 
            // _00158_CajaExterna
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            ControlBox = true;
            Controls.Add(pnlContenedorDetalle);
            Controls.Add(pnlComprobantes);
            Controls.Add(pnlInferior);
            MaximizeBox = true;
            MinimizeBox = true;
            MinimumSize = new Size(800, 600);
            Name = "_00158_CajaExterna";
            Text = "Sidkenu";
            WindowState = FormWindowState.Maximized;
            FormClosed += _00158_CajaExterna_FormClosed;
            Load += _00158_CajaExterna_Load;
            Shown += _00158_CajaExterna_Shown;
            Controls.SetChildIndex(pnlInferior, 0);
            Controls.SetChildIndex(pnlComprobantes, 0);
            Controls.SetChildIndex(pnlContenedorDetalle, 0);
            pnlInferior.ResumeLayout(false);
            pnlComprobantes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvGrillaComprobante).EndInit();
            pnlBuscar.ResumeLayout(false);
            pnlBuscar.PerformLayout();
            pnlContenedorDetalle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDetalleComprobante).EndInit();
            pnlBotoneraComprobante.ResumeLayout(false);
            pnlBotoneraComprobante.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlInferior;
        private Panel pnlComprobantes;
        private Panel pnlContenedorDetalle;
        private FontAwesome.Sharp.IconButton btnFacturar;
        private Panel pnlBuscar;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private TextBox txtBuscar;
        private Label label2;
        public DataGridView dgvGrillaComprobante;
        private Panel panel4;
        public DataGridView dgvDetalleComprobante;
        private Panel pnlBotoneraComprobante;
        private Label label1;
        private TextBox txtTotal;
    }
}