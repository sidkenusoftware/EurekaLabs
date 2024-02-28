namespace SidkenuWF.Formularios.Core
{
    partial class _00135_VarianteValor
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
            pnlTestigo = new Panel();
            lblVarianteSeleccionada = new Label();
            dgvVarianteValor = new DataGridView();
            btnQuitarProveedor = new FontAwesome.Sharp.IconButton();
            btnAgregarProveedor = new FontAwesome.Sharp.IconButton();
            label31 = new Label();
            txtDescripcion = new TextBox();
            label1 = new Label();
            txtCodigo = new TextBox();
            pnlTestigo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVarianteValor).BeginInit();
            SuspendLayout();
            // 
            // pnlTestigo
            // 
            pnlTestigo.BackColor = Color.FromArgb(192, 64, 0);
            pnlTestigo.Controls.Add(lblVarianteSeleccionada);
            pnlTestigo.Dock = DockStyle.Top;
            pnlTestigo.Location = new Point(0, 59);
            pnlTestigo.Name = "pnlTestigo";
            pnlTestigo.Size = new Size(502, 47);
            pnlTestigo.TabIndex = 4;
            // 
            // lblVarianteSeleccionada
            // 
            lblVarianteSeleccionada.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblVarianteSeleccionada.BackColor = Color.Transparent;
            lblVarianteSeleccionada.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblVarianteSeleccionada.ForeColor = Color.White;
            lblVarianteSeleccionada.Location = new Point(19, 6);
            lblVarianteSeleccionada.Name = "lblVarianteSeleccionada";
            lblVarianteSeleccionada.Size = new Size(471, 36);
            lblVarianteSeleccionada.TabIndex = 0;
            lblVarianteSeleccionada.Text = "Variante Selecc. => ";
            lblVarianteSeleccionada.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvVarianteValor
            // 
            dgvVarianteValor.BackgroundColor = Color.White;
            dgvVarianteValor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVarianteValor.Location = new Point(12, 174);
            dgvVarianteValor.Name = "dgvVarianteValor";
            dgvVarianteValor.ReadOnly = true;
            dgvVarianteValor.RowTemplate.Height = 25;
            dgvVarianteValor.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVarianteValor.Size = new Size(479, 264);
            dgvVarianteValor.TabIndex = 135;
            dgvVarianteValor.RowEnter += DgvVarianteValor_RowEnter;
            // 
            // btnQuitarProveedor
            // 
            btnQuitarProveedor.FlatAppearance.BorderColor = Color.Gray;
            btnQuitarProveedor.FlatStyle = FlatStyle.Flat;
            btnQuitarProveedor.IconChar = FontAwesome.Sharp.IconChar.Trash;
            btnQuitarProveedor.IconColor = Color.Black;
            btnQuitarProveedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnQuitarProveedor.IconSize = 25;
            btnQuitarProveedor.Location = new Point(461, 139);
            btnQuitarProveedor.Name = "btnQuitarProveedor";
            btnQuitarProveedor.Size = new Size(30, 29);
            btnQuitarProveedor.TabIndex = 134;
            btnQuitarProveedor.UseVisualStyleBackColor = true;
            btnQuitarProveedor.Click += BtnQuitarProveedor_Click;
            // 
            // btnAgregarProveedor
            // 
            btnAgregarProveedor.FlatAppearance.BorderColor = Color.Gray;
            btnAgregarProveedor.FlatStyle = FlatStyle.Flat;
            btnAgregarProveedor.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            btnAgregarProveedor.IconColor = Color.Black;
            btnAgregarProveedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAgregarProveedor.IconSize = 25;
            btnAgregarProveedor.Location = new Point(427, 139);
            btnAgregarProveedor.Name = "btnAgregarProveedor";
            btnAgregarProveedor.Size = new Size(30, 29);
            btnAgregarProveedor.TabIndex = 133;
            btnAgregarProveedor.UseVisualStyleBackColor = true;
            btnAgregarProveedor.Click += BtnAgregarProveedor_Click;
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Location = new Point(141, 121);
            label31.Name = "label31";
            label31.Size = new Size(69, 15);
            label31.TabIndex = 131;
            label31.Text = "Descripcion";
            // 
            // txtDescripcion
            // 
            txtDescripcion.BackColor = Color.WhiteSmoke;
            txtDescripcion.BorderStyle = BorderStyle.FixedSingle;
            txtDescripcion.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtDescripcion.ForeColor = Color.FromArgb(64, 64, 64);
            txtDescripcion.Location = new Point(141, 139);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(280, 29);
            txtDescripcion.TabIndex = 130;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 120);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 137;
            label1.Text = "Codigo";
            // 
            // txtCodigo
            // 
            txtCodigo.BackColor = Color.WhiteSmoke;
            txtCodigo.BorderStyle = BorderStyle.FixedSingle;
            txtCodigo.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtCodigo.ForeColor = Color.FromArgb(64, 64, 64);
            txtCodigo.Location = new Point(12, 138);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(123, 29);
            txtCodigo.TabIndex = 136;
            // 
            // _00135_VarianteValor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(502, 450);
            Controls.Add(label1);
            Controls.Add(txtCodigo);
            Controls.Add(dgvVarianteValor);
            Controls.Add(btnQuitarProveedor);
            Controls.Add(btnAgregarProveedor);
            Controls.Add(label31);
            Controls.Add(txtDescripcion);
            Controls.Add(pnlTestigo);
            MaximumSize = new Size(518, 489);
            MinimumSize = new Size(518, 489);
            Name = "_00135_VarianteValor";
            Text = "Valores";
            Load += _00135_VarianteValor_Load;
            Controls.SetChildIndex(pnlTestigo, 0);
            Controls.SetChildIndex(txtDescripcion, 0);
            Controls.SetChildIndex(label31, 0);
            Controls.SetChildIndex(btnAgregarProveedor, 0);
            Controls.SetChildIndex(btnQuitarProveedor, 0);
            Controls.SetChildIndex(dgvVarianteValor, 0);
            Controls.SetChildIndex(txtCodigo, 0);
            Controls.SetChildIndex(label1, 0);
            pnlTestigo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvVarianteValor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlTestigo;
        private Label lblVarianteSeleccionada;
        private DataGridView dgvVarianteValor;
        private FontAwesome.Sharp.IconButton btnQuitarProveedor;
        private FontAwesome.Sharp.IconButton btnAgregarProveedor;
        private Label label31;
        private TextBox txtDescripcion;
        private Label label1;
        private TextBox txtCodigo;
    }
}