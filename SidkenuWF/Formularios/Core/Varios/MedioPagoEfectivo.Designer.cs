namespace SidkenuWF.Formularios.Core.Varios
{
    partial class MedioPagoEfectivo
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
            label13 = new Label();
            nudMontoEfectivo = new NumericUpDown();
            btnEjecutar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)nudMontoEfectivo).BeginInit();
            SuspendLayout();
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(39, 103);
            label13.Name = "label13";
            label13.Size = new Size(75, 30);
            label13.TabIndex = 11;
            label13.Text = "Monto";
            // 
            // nudMontoEfectivo
            // 
            nudMontoEfectivo.DecimalPlaces = 2;
            nudMontoEfectivo.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            nudMontoEfectivo.Location = new Point(125, 101);
            nudMontoEfectivo.Maximum = new decimal(new int[] { -1530494976, 232830, 0, 0 });
            nudMontoEfectivo.Name = "nudMontoEfectivo";
            nudMontoEfectivo.Size = new Size(188, 35);
            nudMontoEfectivo.TabIndex = 10;
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
            btnEjecutar.Location = new Point(84, 166);
            btnEjecutar.Name = "btnEjecutar";
            btnEjecutar.Size = new Size(188, 36);
            btnEjecutar.TabIndex = 12;
            btnEjecutar.Text = "Agregar";
            btnEjecutar.UseVisualStyleBackColor = false;
            btnEjecutar.Click += BtnEjecutar_Click;
            // 
            // MedioPagoEfectivo
            // 
            AcceptButton = btnEjecutar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(354, 232);
            Controls.Add(btnEjecutar);
            Controls.Add(label13);
            Controls.Add(nudMontoEfectivo);
            KeyPreview = true;
            MaximumSize = new Size(370, 271);
            MinimumSize = new Size(370, 271);
            Name = "MedioPagoEfectivo";
            Text = "Efectivo";
            Activated += MedioPagoEfectivo_Activated;
            Load += MedioPagoEfectivo_Load;
            Controls.SetChildIndex(nudMontoEfectivo, 0);
            Controls.SetChildIndex(label13, 0);
            Controls.SetChildIndex(btnEjecutar, 0);
            ((System.ComponentModel.ISupportInitialize)nudMontoEfectivo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label13;
        private NumericUpDown nudMontoEfectivo;
        private FontAwesome.Sharp.IconButton btnEjecutar;
    }
}