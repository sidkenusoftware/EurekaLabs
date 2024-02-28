namespace SidkenuWF.Formularios.Core.Varios
{
    partial class MedioPagoTransferencia
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
            txtNroTransferencia = new TextBox();
            label3 = new Label();
            btnEjecutar = new FontAwesome.Sharp.IconButton();
            label13 = new Label();
            nudMontoPagar = new NumericUpDown();
            label16 = new Label();
            cmbBanco = new ComboBox();
            txtTitular = new TextBox();
            label1 = new Label();
            label2 = new Label();
            nudTotal = new NumericUpDown();
            label4 = new Label();
            nudInteresTransferencia = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)nudMontoPagar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudTotal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudInteresTransferencia).BeginInit();
            SuspendLayout();
            // 
            // txtNroTransferencia
            // 
            txtNroTransferencia.BorderStyle = BorderStyle.FixedSingle;
            txtNroTransferencia.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNroTransferencia.Location = new Point(186, 234);
            txtNroTransferencia.Name = "txtNroTransferencia";
            txtNroTransferencia.Size = new Size(261, 29);
            txtNroTransferencia.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(64, 64, 64);
            label3.Location = new Point(16, 237);
            label3.Name = "label3";
            label3.Size = new Size(161, 24);
            label3.TabIndex = 155;
            label3.Text = "Nro Transferencia";
            // 
            // btnEjecutar
            // 
            btnEjecutar.BackColor = Color.Green;
            btnEjecutar.FlatAppearance.BorderSize = 0;
            btnEjecutar.FlatStyle = FlatStyle.Flat;
            btnEjecutar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnEjecutar.ForeColor = Color.White;
            btnEjecutar.IconChar = FontAwesome.Sharp.IconChar.None;
            btnEjecutar.IconColor = Color.Black;
            btnEjecutar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEjecutar.Location = new Point(146, 318);
            btnEjecutar.Name = "btnEjecutar";
            btnEjecutar.Size = new Size(188, 36);
            btnEjecutar.TabIndex = 150;
            btnEjecutar.Text = "Agregar";
            btnEjecutar.UseVisualStyleBackColor = false;
            btnEjecutar.Click += BtnEjecutar_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(114, 120);
            label13.Name = "label13";
            label13.Size = new Size(63, 24);
            label13.TabIndex = 149;
            label13.Text = "Monto";
            // 
            // nudMontoPagar
            // 
            nudMontoPagar.DecimalPlaces = 2;
            nudMontoPagar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            nudMontoPagar.Location = new Point(186, 117);
            nudMontoPagar.Maximum = new decimal(new int[] { -1530494976, 232830, 0, 0 });
            nudMontoPagar.Name = "nudMontoPagar";
            nudMontoPagar.Size = new Size(188, 33);
            nudMontoPagar.TabIndex = 1;
            nudMontoPagar.ValueChanged += NudMontoPagar_ValueChanged;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.Transparent;
            label16.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label16.ForeColor = Color.FromArgb(64, 64, 64);
            label16.Location = new Point(113, 83);
            label16.Name = "label16";
            label16.Size = new Size(64, 24);
            label16.TabIndex = 145;
            label16.Text = "Banco";
            // 
            // cmbBanco
            // 
            cmbBanco.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBanco.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            cmbBanco.FormattingEnabled = true;
            cmbBanco.Location = new Point(186, 79);
            cmbBanco.Name = "cmbBanco";
            cmbBanco.Size = new Size(261, 32);
            cmbBanco.TabIndex = 0;
            // 
            // txtTitular
            // 
            txtTitular.BorderStyle = BorderStyle.FixedSingle;
            txtTitular.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTitular.Location = new Point(186, 269);
            txtTitular.Name = "txtTitular";
            txtTitular.Size = new Size(261, 29);
            txtTitular.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(116, 269);
            label1.Name = "label1";
            label1.Size = new Size(61, 24);
            label1.TabIndex = 157;
            label1.Text = "Titular";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(105, 196);
            label2.Name = "label2";
            label2.Size = new Size(72, 24);
            label2.TabIndex = 162;
            label2.Text = "TOTAL";
            // 
            // nudTotal
            // 
            nudTotal.DecimalPlaces = 2;
            nudTotal.Enabled = false;
            nudTotal.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            nudTotal.Location = new Point(186, 193);
            nudTotal.Maximum = new decimal(new int[] { -1530494976, 232830, 0, 0 });
            nudTotal.Name = "nudTotal";
            nudTotal.Size = new Size(188, 33);
            nudTotal.TabIndex = 161;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(111, 159);
            label4.Name = "label4";
            label4.Size = new Size(66, 24);
            label4.TabIndex = 160;
            label4.Text = "Interes";
            // 
            // nudInteresTransferencia
            // 
            nudInteresTransferencia.DecimalPlaces = 2;
            nudInteresTransferencia.Enabled = false;
            nudInteresTransferencia.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            nudInteresTransferencia.Location = new Point(186, 156);
            nudInteresTransferencia.Maximum = new decimal(new int[] { -1530494976, 232830, 0, 0 });
            nudInteresTransferencia.Name = "nudInteresTransferencia";
            nudInteresTransferencia.Size = new Size(188, 33);
            nudInteresTransferencia.TabIndex = 159;
            nudInteresTransferencia.ValueChanged += NudInteresTransferencia_ValueChanged;
            // 
            // MedioPagoTransferencia
            // 
            AcceptButton = btnEjecutar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 375);
            Controls.Add(label2);
            Controls.Add(nudTotal);
            Controls.Add(label4);
            Controls.Add(nudInteresTransferencia);
            Controls.Add(txtTitular);
            Controls.Add(label1);
            Controls.Add(txtNroTransferencia);
            Controls.Add(label3);
            Controls.Add(btnEjecutar);
            Controls.Add(label13);
            Controls.Add(nudMontoPagar);
            Controls.Add(label16);
            Controls.Add(cmbBanco);
            KeyPreview = true;
            MaximumSize = new Size(516, 414);
            MinimumSize = new Size(516, 414);
            Name = "MedioPagoTransferencia";
            Text = "Transferencia";
            Activated += MedioPagoCheque_Activated;
            Load += MedioPagoCheque_Load;
            Controls.SetChildIndex(cmbBanco, 0);
            Controls.SetChildIndex(label16, 0);
            Controls.SetChildIndex(nudMontoPagar, 0);
            Controls.SetChildIndex(label13, 0);
            Controls.SetChildIndex(btnEjecutar, 0);
            Controls.SetChildIndex(label3, 0);
            Controls.SetChildIndex(txtNroTransferencia, 0);
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(txtTitular, 0);
            Controls.SetChildIndex(nudInteresTransferencia, 0);
            Controls.SetChildIndex(label4, 0);
            Controls.SetChildIndex(nudTotal, 0);
            Controls.SetChildIndex(label2, 0);
            ((System.ComponentModel.ISupportInitialize)nudMontoPagar).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudTotal).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudInteresTransferencia).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNroTransferencia;
        private Label label3;
        private FontAwesome.Sharp.IconButton btnEjecutar;
        private Label label13;
        private NumericUpDown nudMontoPagar;
        private Label label16;
        private ComboBox cmbBanco;
        private TextBox txtTitular;
        private Label label1;
        private Label label2;
        private NumericUpDown nudTotal;
        private Label label4;
        private NumericUpDown nudInteresTransferencia;
    }
}