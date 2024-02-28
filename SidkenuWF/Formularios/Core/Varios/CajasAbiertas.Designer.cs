namespace SidkenuWF.Formularios.Core.Varios
{
    partial class CajasAbiertas
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
            imgCaja = new FontAwesome.Sharp.IconPictureBox();
            btnAbrirCaja = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            cmbCaja = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)imgCaja).BeginInit();
            SuspendLayout();
            // 
            // imgCaja
            // 
            imgCaja.BackColor = Color.WhiteSmoke;
            imgCaja.BorderStyle = BorderStyle.FixedSingle;
            imgCaja.ForeColor = Color.FromArgb(64, 64, 64);
            imgCaja.IconChar = FontAwesome.Sharp.IconChar.Registered;
            imgCaja.IconColor = Color.FromArgb(64, 64, 64);
            imgCaja.IconFont = FontAwesome.Sharp.IconFont.Auto;
            imgCaja.IconSize = 30;
            imgCaja.Location = new Point(40, 137);
            imgCaja.Name = "imgCaja";
            imgCaja.Size = new Size(40, 30);
            imgCaja.SizeMode = PictureBoxSizeMode.CenterImage;
            imgCaja.TabIndex = 29;
            imgCaja.TabStop = false;
            // 
            // btnAbrirCaja
            // 
            btnAbrirCaja.BackColor = Color.Green;
            btnAbrirCaja.FlatStyle = FlatStyle.Flat;
            btnAbrirCaja.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnAbrirCaja.ForeColor = Color.White;
            btnAbrirCaja.IconChar = FontAwesome.Sharp.IconChar.None;
            btnAbrirCaja.IconColor = Color.Black;
            btnAbrirCaja.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAbrirCaja.Location = new Point(140, 205);
            btnAbrirCaja.Name = "btnAbrirCaja";
            btnAbrirCaja.Size = new Size(174, 45);
            btnAbrirCaja.TabIndex = 28;
            btnAbrirCaja.Text = "Seleccionar Caja";
            btnAbrirCaja.UseVisualStyleBackColor = false;
            btnAbrirCaja.Click += BtnAbrirCaja_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(40, 113);
            label1.Name = "label1";
            label1.Size = new Size(49, 18);
            label1.TabIndex = 27;
            label1.Text = "Cajas";
            // 
            // cmbCaja
            // 
            cmbCaja.BackColor = Color.WhiteSmoke;
            cmbCaja.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCaja.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            cmbCaja.ForeColor = Color.FromArgb(64, 64, 64);
            cmbCaja.FormattingEnabled = true;
            cmbCaja.ItemHeight = 22;
            cmbCaja.Location = new Point(79, 137);
            cmbCaja.MaxDropDownItems = 12;
            cmbCaja.Name = "cmbCaja";
            cmbCaja.Size = new Size(368, 30);
            cmbCaja.TabIndex = 80;
            // 
            // CajasAbiertas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(478, 291);
            Controls.Add(cmbCaja);
            Controls.Add(imgCaja);
            Controls.Add(btnAbrirCaja);
            Controls.Add(label1);
            Name = "CajasAbiertas";
            Text = "CajasAbiertas";
            Load += CajasAbiertas_Load;
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(btnAbrirCaja, 0);
            Controls.SetChildIndex(imgCaja, 0);
            Controls.SetChildIndex(cmbCaja, 0);
            ((System.ComponentModel.ISupportInitialize)imgCaja).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconPictureBox imgCaja;
        private FontAwesome.Sharp.IconButton btnAbrirCaja;
        private Label label1;
        private ComboBox cmbCaja;
    }
}