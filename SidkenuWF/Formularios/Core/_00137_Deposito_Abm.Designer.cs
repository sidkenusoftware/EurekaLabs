namespace SidkenuWF.Formularios.Core
{
    partial class _00137_Deposito_Abm
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
            txtAbreviatura = new TextBox();
            label1 = new Label();
            txtDescripcion = new TextBox();
            label5 = new Label();
            cmbTipoDeposito = new ComboBox();
            label6 = new Label();
            txtDireccion = new TextBox();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(64, 64, 64);
            label2.Location = new Point(32, 78);
            label2.Name = "label2";
            label2.Size = new Size(71, 16);
            label2.TabIndex = 110;
            label2.Text = "Abreviatura";
            // 
            // txtAbreviatura
            // 
            txtAbreviatura.BackColor = Color.WhiteSmoke;
            txtAbreviatura.BorderStyle = BorderStyle.FixedSingle;
            txtAbreviatura.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtAbreviatura.ForeColor = Color.FromArgb(64, 64, 64);
            txtAbreviatura.Location = new Point(29, 99);
            txtAbreviatura.Name = "txtAbreviatura";
            txtAbreviatura.Size = new Size(158, 29);
            txtAbreviatura.TabIndex = 107;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(32, 138);
            label1.Name = "label1";
            label1.Size = new Size(107, 16);
            label1.TabIndex = 109;
            label1.Text = "Nombre Deposito";
            // 
            // txtDescripcion
            // 
            txtDescripcion.BackColor = Color.WhiteSmoke;
            txtDescripcion.BorderStyle = BorderStyle.FixedSingle;
            txtDescripcion.Font = new Font("Arial", 24F, FontStyle.Regular, GraphicsUnit.Point);
            txtDescripcion.ForeColor = Color.FromArgb(64, 64, 64);
            txtDescripcion.Location = new Point(29, 159);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(483, 44);
            txtDescripcion.TabIndex = 108;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(29, 280);
            label5.Name = "label5";
            label5.Size = new Size(80, 15);
            label5.TabIndex = 116;
            label5.Text = "Tipo Deposito";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cmbTipoDeposito
            // 
            cmbTipoDeposito.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoDeposito.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            cmbTipoDeposito.FormattingEnabled = true;
            cmbTipoDeposito.Location = new Point(29, 298);
            cmbTipoDeposito.Name = "cmbTipoDeposito";
            cmbTipoDeposito.Size = new Size(213, 28);
            cmbTipoDeposito.TabIndex = 115;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(64, 64, 64);
            label6.Location = new Point(32, 216);
            label6.Name = "label6";
            label6.Size = new Size(61, 16);
            label6.TabIndex = 118;
            label6.Text = "Dirección";
            // 
            // txtDireccion
            // 
            txtDireccion.BackColor = Color.WhiteSmoke;
            txtDireccion.BorderStyle = BorderStyle.FixedSingle;
            txtDireccion.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtDireccion.ForeColor = Color.FromArgb(64, 64, 64);
            txtDireccion.Location = new Point(29, 237);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(483, 29);
            txtDireccion.TabIndex = 117;
            // 
            // _00137_Deposito_Abm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(542, 394);
            Controls.Add(label6);
            Controls.Add(txtDireccion);
            Controls.Add(label5);
            Controls.Add(cmbTipoDeposito);
            Controls.Add(label2);
            Controls.Add(txtAbreviatura);
            Controls.Add(label1);
            Controls.Add(txtDescripcion);
            MaximumSize = new Size(558, 433);
            MinimumSize = new Size(558, 433);
            Name = "_00137_Deposito_Abm";
            Text = "Deposito";
            Controls.SetChildIndex(txtDescripcion, 0);
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(txtAbreviatura, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(cmbTipoDeposito, 0);
            Controls.SetChildIndex(label5, 0);
            Controls.SetChildIndex(txtDireccion, 0);
            Controls.SetChildIndex(label6, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private TextBox txtAbreviatura;
        private Label label1;
        private TextBox txtDescripcion;
        private Label label5;
        private ComboBox cmbTipoDeposito;
        private Label label6;
        private TextBox txtDireccion;
    }
}