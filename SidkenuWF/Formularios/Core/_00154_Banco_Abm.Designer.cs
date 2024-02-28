namespace SidkenuWF.Formularios.Core
{
    partial class _00154_Banco_Abm
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
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(64, 64, 64);
            label2.Location = new Point(28, 73);
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
            txtCodigo.Location = new Point(25, 94);
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
            label1.Location = new Point(28, 140);
            label1.Name = "label1";
            label1.Size = new Size(93, 16);
            label1.TabIndex = 34;
            label1.Text = "Nombre Banco";
            // 
            // txtDescripcion
            // 
            txtDescripcion.BackColor = Color.WhiteSmoke;
            txtDescripcion.BorderStyle = BorderStyle.FixedSingle;
            txtDescripcion.Font = new Font("Arial", 24F, FontStyle.Regular, GraphicsUnit.Point);
            txtDescripcion.ForeColor = Color.FromArgb(64, 64, 64);
            txtDescripcion.Location = new Point(25, 161);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(516, 44);
            txtDescripcion.TabIndex = 33;
            // 
            // _00154_Banco_Abm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(563, 302);
            Controls.Add(label2);
            Controls.Add(txtCodigo);
            Controls.Add(label1);
            Controls.Add(txtDescripcion);
            MaximumSize = new Size(579, 341);
            MinimumSize = new Size(579, 341);
            Name = "_00154_Banco_Abm";
            Text = "_00154_Banco_Abm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private TextBox txtCodigo;
        private Label label1;
        private TextBox txtDescripcion;
    }
}