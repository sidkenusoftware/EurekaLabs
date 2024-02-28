namespace SidkenuWF.Formularios.Seguridad
{
    partial class _00012_TipoResponsabilidad_Abm
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
            label1 = new Label();
            txtDescripcion = new TextBox();
            txtCodigo = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(32, 137);
            label1.Name = "label1";
            label1.Size = new Size(211, 16);
            label1.TabIndex = 17;
            label1.Text = "Nombre de la Tipo Responsabilidad";
            // 
            // txtDescripcion
            // 
            txtDescripcion.BackColor = Color.WhiteSmoke;
            txtDescripcion.BorderStyle = BorderStyle.FixedSingle;
            txtDescripcion.Font = new Font("Arial", 24F, FontStyle.Regular, GraphicsUnit.Point);
            txtDescripcion.ForeColor = Color.FromArgb(64, 64, 64);
            txtDescripcion.Location = new Point(29, 158);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.PlaceholderText = "Ej: Monotributo";
            txtDescripcion.Size = new Size(408, 44);
            txtDescripcion.TabIndex = 16;
            // 
            // txtCodigo
            // 
            txtCodigo.BackColor = Color.WhiteSmoke;
            txtCodigo.BorderStyle = BorderStyle.FixedSingle;
            txtCodigo.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtCodigo.ForeColor = Color.FromArgb(64, 64, 64);
            txtCodigo.Location = new Point(29, 98);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.PlaceholderText = "Ej: 123";
            txtCodigo.Size = new Size(169, 25);
            txtCodigo.TabIndex = 77;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(64, 64, 64);
            label3.Location = new Point(32, 79);
            label3.Name = "label3";
            label3.Size = new Size(47, 16);
            label3.TabIndex = 76;
            label3.Text = "Código";
            // 
            // _00012_TipoResponsabilidad_Abm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(473, 281);
            Controls.Add(txtCodigo);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(txtDescripcion);
            MaximumSize = new Size(489, 320);
            MinimumSize = new Size(489, 320);
            Name = "_00012_TipoResponsabilidad_Abm";
            Controls.SetChildIndex(txtDescripcion, 0);
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(label3, 0);
            Controls.SetChildIndex(txtCodigo, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtDescripcion;
        private TextBox txtCodigo;
        private Label label3;
    }
}