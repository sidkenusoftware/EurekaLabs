namespace SidkenuWF.Formularios.Core.Varios
{
    partial class MedioPagoTarjeta
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
            label15 = new Label();
            cmbPlanTarjeta = new ComboBox();
            label16 = new Label();
            cmbTarjeta = new ComboBox();
            btnEjecutar = new FontAwesome.Sharp.IconButton();
            label13 = new Label();
            nudMontoTarjeta = new NumericUpDown();
            label1 = new Label();
            nudInteresTarjeta = new NumericUpDown();
            label2 = new Label();
            nudTotal = new NumericUpDown();
            label3 = new Label();
            txtNroCupon = new TextBox();
            ((System.ComponentModel.ISupportInitialize)nudMontoTarjeta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudInteresTarjeta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudTotal).BeginInit();
            SuspendLayout();
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.Transparent;
            label15.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label15.ForeColor = Color.FromArgb(64, 64, 64);
            label15.Location = new Point(23, 117);
            label15.Name = "label15";
            label15.Size = new Size(136, 24);
            label15.TabIndex = 134;
            label15.Text = "Plan de Tarjeta";
            // 
            // cmbPlanTarjeta
            // 
            cmbPlanTarjeta.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPlanTarjeta.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            cmbPlanTarjeta.FormattingEnabled = true;
            cmbPlanTarjeta.Location = new Point(168, 113);
            cmbPlanTarjeta.Name = "cmbPlanTarjeta";
            cmbPlanTarjeta.Size = new Size(261, 32);
            cmbPlanTarjeta.TabIndex = 133;
            cmbPlanTarjeta.SelectionChangeCommitted += CmbPlanTarjeta_SelectionChangeCommitted;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.Transparent;
            label16.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label16.ForeColor = Color.FromArgb(64, 64, 64);
            label16.Location = new Point(92, 79);
            label16.Name = "label16";
            label16.Size = new Size(67, 24);
            label16.TabIndex = 132;
            label16.Text = "Tarjeta";
            // 
            // cmbTarjeta
            // 
            cmbTarjeta.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTarjeta.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            cmbTarjeta.FormattingEnabled = true;
            cmbTarjeta.Location = new Point(168, 75);
            cmbTarjeta.Name = "cmbTarjeta";
            cmbTarjeta.Size = new Size(261, 32);
            cmbTarjeta.TabIndex = 131;
            cmbTarjeta.SelectionChangeCommitted += CmbTarjeta_SelectionChangeCommitted;
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
            btnEjecutar.Location = new Point(118, 332);
            btnEjecutar.Name = "btnEjecutar";
            btnEjecutar.Size = new Size(188, 36);
            btnEjecutar.TabIndex = 137;
            btnEjecutar.Text = "Agregar";
            btnEjecutar.UseVisualStyleBackColor = false;
            btnEjecutar.Click += BtnEjecutar_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(96, 152);
            label13.Name = "label13";
            label13.Size = new Size(63, 24);
            label13.TabIndex = 136;
            label13.Text = "Monto";
            // 
            // nudMontoTarjeta
            // 
            nudMontoTarjeta.DecimalPlaces = 2;
            nudMontoTarjeta.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            nudMontoTarjeta.Location = new Point(168, 149);
            nudMontoTarjeta.Maximum = new decimal(new int[] { -1530494976, 232830, 0, 0 });
            nudMontoTarjeta.Name = "nudMontoTarjeta";
            nudMontoTarjeta.Size = new Size(188, 33);
            nudMontoTarjeta.TabIndex = 135;
            nudMontoTarjeta.ValueChanged += NudMontoTarjeta_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(93, 189);
            label1.Name = "label1";
            label1.Size = new Size(66, 24);
            label1.TabIndex = 139;
            label1.Text = "Interes";
            // 
            // nudInteresTarjeta
            // 
            nudInteresTarjeta.DecimalPlaces = 2;
            nudInteresTarjeta.Enabled = false;
            nudInteresTarjeta.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            nudInteresTarjeta.Location = new Point(168, 186);
            nudInteresTarjeta.Maximum = new decimal(new int[] { -1530494976, 232830, 0, 0 });
            nudInteresTarjeta.Name = "nudInteresTarjeta";
            nudInteresTarjeta.Size = new Size(188, 33);
            nudInteresTarjeta.TabIndex = 138;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(87, 226);
            label2.Name = "label2";
            label2.Size = new Size(72, 24);
            label2.TabIndex = 141;
            label2.Text = "TOTAL";
            // 
            // nudTotal
            // 
            nudTotal.DecimalPlaces = 2;
            nudTotal.Enabled = false;
            nudTotal.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            nudTotal.Location = new Point(168, 223);
            nudTotal.Maximum = new decimal(new int[] { -1530494976, 232830, 0, 0 });
            nudTotal.Name = "nudTotal";
            nudTotal.Size = new Size(188, 33);
            nudTotal.TabIndex = 140;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(64, 64, 64);
            label3.Location = new Point(32, 271);
            label3.Name = "label3";
            label3.Size = new Size(130, 24);
            label3.TabIndex = 142;
            label3.Text = "Nro de Cupon";
            // 
            // txtNroCupon
            // 
            txtNroCupon.BorderStyle = BorderStyle.FixedSingle;
            txtNroCupon.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNroCupon.Location = new Point(168, 269);
            txtNroCupon.Name = "txtNroCupon";
            txtNroCupon.Size = new Size(261, 29);
            txtNroCupon.TabIndex = 143;
            // 
            // MedioPagoTarjeta
            // 
            AcceptButton = btnEjecutar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(468, 380);
            Controls.Add(txtNroCupon);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(nudTotal);
            Controls.Add(label1);
            Controls.Add(nudInteresTarjeta);
            Controls.Add(btnEjecutar);
            Controls.Add(label13);
            Controls.Add(nudMontoTarjeta);
            Controls.Add(label15);
            Controls.Add(cmbPlanTarjeta);
            Controls.Add(label16);
            Controls.Add(cmbTarjeta);
            MaximumSize = new Size(484, 419);
            MinimumSize = new Size(484, 419);
            Name = "MedioPagoTarjeta";
            Text = "Medios de Pagos";
            Activated += MedioPagoTarjeta_Activated;
            Load += MedioPagoTarjeta_Load;
            Controls.SetChildIndex(cmbTarjeta, 0);
            Controls.SetChildIndex(label16, 0);
            Controls.SetChildIndex(cmbPlanTarjeta, 0);
            Controls.SetChildIndex(label15, 0);
            Controls.SetChildIndex(nudMontoTarjeta, 0);
            Controls.SetChildIndex(label13, 0);
            Controls.SetChildIndex(btnEjecutar, 0);
            Controls.SetChildIndex(nudInteresTarjeta, 0);
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(nudTotal, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(label3, 0);
            Controls.SetChildIndex(txtNroCupon, 0);
            ((System.ComponentModel.ISupportInitialize)nudMontoTarjeta).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudInteresTarjeta).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudTotal).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label15;
        private ComboBox cmbPlanTarjeta;
        private Label label16;
        private ComboBox cmbTarjeta;
        private FontAwesome.Sharp.IconButton btnEjecutar;
        private Label label13;
        private NumericUpDown nudMontoTarjeta;
        private Label label1;
        private NumericUpDown nudInteresTarjeta;
        private Label label2;
        private NumericUpDown nudTotal;
        private Label label3;
        private TextBox txtNroCupon;
    }
}