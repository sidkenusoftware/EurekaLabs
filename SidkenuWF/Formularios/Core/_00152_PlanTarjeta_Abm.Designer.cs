namespace SidkenuWF.Formularios.Core
{
    partial class _00152_PlanTarjeta_Abm
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
            label2 = new Label();
            txtCodigo = new TextBox();
            label1 = new Label();
            txtDescripcion = new TextBox();
            btnNuevaTarjeta = new Button();
            label9 = new Label();
            cmbTarjeta = new ComboBox();
            label29 = new Label();
            nudAlicuota = new NumericUpDown();
            label30 = new Label();
            ((System.ComponentModel.ISupportInitialize)nudAlicuota).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(64, 64, 64);
            label2.Location = new Point(18, 139);
            label2.Name = "label2";
            label2.Size = new Size(47, 16);
            label2.TabIndex = 35;
            label2.Text = "Codigo";
            // 
            // txtCodigo
            // 
            txtCodigo.BackColor = Color.WhiteSmoke;
            txtCodigo.BorderStyle = BorderStyle.FixedSingle;
            txtCodigo.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtCodigo.ForeColor = Color.FromArgb(64, 64, 64);
            txtCodigo.Location = new Point(15, 160);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(158, 29);
            txtCodigo.TabIndex = 32;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(18, 206);
            label1.Name = "label1";
            label1.Size = new Size(94, 16);
            label1.TabIndex = 34;
            label1.Text = "Nombre Tarjeta";
            // 
            // txtDescripcion
            // 
            txtDescripcion.BackColor = Color.WhiteSmoke;
            txtDescripcion.BorderStyle = BorderStyle.FixedSingle;
            txtDescripcion.Font = new Font("Arial", 24F, FontStyle.Regular, GraphicsUnit.Point);
            txtDescripcion.ForeColor = Color.FromArgb(64, 64, 64);
            txtDescripcion.Location = new Point(15, 227);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(516, 44);
            txtDescripcion.TabIndex = 33;
            // 
            // btnNuevaTarjeta
            // 
            btnNuevaTarjeta.FlatAppearance.BorderColor = Color.Gray;
            btnNuevaTarjeta.FlatStyle = FlatStyle.Flat;
            btnNuevaTarjeta.Location = new Point(493, 95);
            btnNuevaTarjeta.Name = "btnNuevaTarjeta";
            btnNuevaTarjeta.Size = new Size(38, 29);
            btnNuevaTarjeta.TabIndex = 125;
            btnNuevaTarjeta.Text = "...";
            btnNuevaTarjeta.UseVisualStyleBackColor = true;
            btnNuevaTarjeta.Click += BtnNuevaTarjeta_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.FromArgb(64, 64, 64);
            label9.Location = new Point(15, 76);
            label9.Name = "label9";
            label9.Size = new Size(45, 16);
            label9.TabIndex = 124;
            label9.Text = "Tarjeta";
            // 
            // cmbTarjeta
            // 
            cmbTarjeta.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTarjeta.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbTarjeta.FormattingEnabled = true;
            cmbTarjeta.Location = new Point(15, 95);
            cmbTarjeta.Name = "cmbTarjeta";
            cmbTarjeta.Size = new Size(472, 29);
            cmbTarjeta.TabIndex = 123;
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.BackColor = Color.Transparent;
            label29.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label29.ForeColor = Color.FromArgb(64, 64, 64);
            label29.Location = new Point(138, 316);
            label29.Name = "label29";
            label29.Size = new Size(35, 16);
            label29.TabIndex = 161;
            label29.Text = "[ % ]";
            // 
            // nudAlicuota
            // 
            nudAlicuota.DecimalPlaces = 2;
            nudAlicuota.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            nudAlicuota.Location = new Point(15, 311);
            nudAlicuota.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            nudAlicuota.Name = "nudAlicuota";
            nudAlicuota.Size = new Size(117, 27);
            nudAlicuota.TabIndex = 160;
            nudAlicuota.TextAlign = HorizontalAlignment.Right;
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.BackColor = Color.Transparent;
            label30.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label30.ForeColor = Color.FromArgb(64, 64, 64);
            label30.Location = new Point(15, 292);
            label30.Name = "label30";
            label30.Size = new Size(46, 16);
            label30.TabIndex = 159;
            label30.Text = "Interés";
            // 
            // _00152_PlanTarjeta_Abm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(551, 408);
            Controls.Add(label29);
            Controls.Add(nudAlicuota);
            Controls.Add(label30);
            Controls.Add(btnNuevaTarjeta);
            Controls.Add(label9);
            Controls.Add(cmbTarjeta);
            Controls.Add(label2);
            Controls.Add(txtCodigo);
            Controls.Add(label1);
            Controls.Add(txtDescripcion);
            MaximumSize = new Size(567, 447);
            MinimumSize = new Size(567, 447);
            Name = "_00152_PlanTarjeta_Abm";
            Text = "Plan Tarjeta";
            Controls.SetChildIndex(txtDescripcion, 0);
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(txtCodigo, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(cmbTarjeta, 0);
            Controls.SetChildIndex(label9, 0);
            Controls.SetChildIndex(btnNuevaTarjeta, 0);
            Controls.SetChildIndex(label30, 0);
            Controls.SetChildIndex(nudAlicuota, 0);
            Controls.SetChildIndex(label29, 0);
            ((System.ComponentModel.ISupportInitialize)nudAlicuota).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private TextBox txtCodigo;
        private Label label1;
        private TextBox txtDescripcion;
        private Button btnNuevaTarjeta;
        private Label label9;
        private ComboBox cmbTarjeta;
        private Label label29;
        private NumericUpDown nudAlicuota;
        private Label label30;
    }
}