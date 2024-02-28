namespace SidkenuWF.Formularios.Core.Varios
{
    partial class MedioPagoCheque
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
            txtNroCheque = new TextBox();
            label3 = new Label();
            btnEjecutar = new FontAwesome.Sharp.IconButton();
            label13 = new Label();
            nudMontoPagar = new NumericUpDown();
            label16 = new Label();
            cmbBanco = new ComboBox();
            label1 = new Label();
            dtpFechaVencimiento = new DateTimePicker();
            label2 = new Label();
            nudTotal = new NumericUpDown();
            label4 = new Label();
            nudInteresCheque = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)nudMontoPagar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudTotal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudInteresCheque).BeginInit();
            SuspendLayout();
            // 
            // txtNroCheque
            // 
            txtNroCheque.BorderStyle = BorderStyle.FixedSingle;
            txtNroCheque.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNroCheque.Location = new Point(202, 240);
            txtNroCheque.Name = "txtNroCheque";
            txtNroCheque.Size = new Size(261, 29);
            txtNroCheque.TabIndex = 156;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(64, 64, 64);
            label3.Location = new Point(55, 240);
            label3.Name = "label3";
            label3.Size = new Size(141, 24);
            label3.TabIndex = 155;
            label3.Text = "Nro de Cheque";
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
            btnEjecutar.Location = new Point(139, 312);
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
            label13.Location = new Point(130, 128);
            label13.Name = "label13";
            label13.Size = new Size(63, 24);
            label13.TabIndex = 149;
            label13.Text = "Monto";
            // 
            // nudMontoPagar
            // 
            nudMontoPagar.DecimalPlaces = 2;
            nudMontoPagar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            nudMontoPagar.Location = new Point(202, 125);
            nudMontoPagar.Maximum = new decimal(new int[] { -1530494976, 232830, 0, 0 });
            nudMontoPagar.Name = "nudMontoPagar";
            nudMontoPagar.Size = new Size(188, 33);
            nudMontoPagar.TabIndex = 148;
            nudMontoPagar.ValueChanged += NudMontoPagar_ValueChanged;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.Transparent;
            label16.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label16.ForeColor = Color.FromArgb(64, 64, 64);
            label16.Location = new Point(126, 91);
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
            cmbBanco.Location = new Point(202, 87);
            cmbBanco.Name = "cmbBanco";
            cmbBanco.Size = new Size(261, 32);
            cmbBanco.TabIndex = 144;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(18, 276);
            label1.Name = "label1";
            label1.Size = new Size(175, 24);
            label1.TabIndex = 157;
            label1.Text = "Fecha Vencimiento";
            // 
            // dtpFechaVencimiento
            // 
            dtpFechaVencimiento.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtpFechaVencimiento.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtpFechaVencimiento.Format = DateTimePickerFormat.Short;
            dtpFechaVencimiento.Location = new Point(202, 275);
            dtpFechaVencimiento.Name = "dtpFechaVencimiento";
            dtpFechaVencimiento.Size = new Size(188, 29);
            dtpFechaVencimiento.TabIndex = 158;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(121, 204);
            label2.Name = "label2";
            label2.Size = new Size(72, 24);
            label2.TabIndex = 166;
            label2.Text = "TOTAL";
            // 
            // nudTotal
            // 
            nudTotal.DecimalPlaces = 2;
            nudTotal.Enabled = false;
            nudTotal.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            nudTotal.Location = new Point(202, 201);
            nudTotal.Maximum = new decimal(new int[] { -1530494976, 232830, 0, 0 });
            nudTotal.Name = "nudTotal";
            nudTotal.Size = new Size(188, 33);
            nudTotal.TabIndex = 165;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(127, 167);
            label4.Name = "label4";
            label4.Size = new Size(66, 24);
            label4.TabIndex = 164;
            label4.Text = "Interes";
            // 
            // nudInteresCheque
            // 
            nudInteresCheque.DecimalPlaces = 2;
            nudInteresCheque.Enabled = false;
            nudInteresCheque.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            nudInteresCheque.Location = new Point(202, 164);
            nudInteresCheque.Maximum = new decimal(new int[] { -1530494976, 232830, 0, 0 });
            nudInteresCheque.Name = "nudInteresCheque";
            nudInteresCheque.Size = new Size(188, 33);
            nudInteresCheque.TabIndex = 163;
            // 
            // MedioPagoCheque
            // 
            AcceptButton = btnEjecutar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 369);
            Controls.Add(label2);
            Controls.Add(nudTotal);
            Controls.Add(label4);
            Controls.Add(nudInteresCheque);
            Controls.Add(dtpFechaVencimiento);
            Controls.Add(label1);
            Controls.Add(txtNroCheque);
            Controls.Add(label3);
            Controls.Add(btnEjecutar);
            Controls.Add(label13);
            Controls.Add(nudMontoPagar);
            Controls.Add(label16);
            Controls.Add(cmbBanco);
            KeyPreview = true;
            MaximumSize = new Size(516, 408);
            MinimumSize = new Size(516, 408);
            Name = "MedioPagoCheque";
            Text = "Cheque";
            Activated += MedioPagoCheque_Activated;
            Load += MedioPagoCheque_Load;
            Controls.SetChildIndex(cmbBanco, 0);
            Controls.SetChildIndex(label16, 0);
            Controls.SetChildIndex(nudMontoPagar, 0);
            Controls.SetChildIndex(label13, 0);
            Controls.SetChildIndex(btnEjecutar, 0);
            Controls.SetChildIndex(label3, 0);
            Controls.SetChildIndex(txtNroCheque, 0);
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(dtpFechaVencimiento, 0);
            Controls.SetChildIndex(nudInteresCheque, 0);
            Controls.SetChildIndex(label4, 0);
            Controls.SetChildIndex(nudTotal, 0);
            Controls.SetChildIndex(label2, 0);
            ((System.ComponentModel.ISupportInitialize)nudMontoPagar).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudTotal).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudInteresCheque).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNroCheque;
        private Label label3;
        private FontAwesome.Sharp.IconButton btnEjecutar;
        private Label label13;
        private NumericUpDown nudMontoPagar;
        private Label label16;
        private ComboBox cmbBanco;
        private Label label1;
        private DateTimePicker dtpFechaVencimiento;
        private Label label2;
        private NumericUpDown nudTotal;
        private Label label4;
        private NumericUpDown nudInteresCheque;
    }
}