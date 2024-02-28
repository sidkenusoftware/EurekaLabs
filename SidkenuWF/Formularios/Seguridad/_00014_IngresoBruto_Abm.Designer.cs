namespace SidkenuWF.Formularios.Seguridad
{
    partial class _00014_IngresoBruto_Abm
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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(35, 108);
            label1.Name = "label1";
            label1.Size = new Size(154, 16);
            label1.TabIndex = 17;
            label1.Text = "Nombre del Ingreso Bruto";
            // 
            // txtDescripcion
            // 
            txtDescripcion.BackColor = Color.WhiteSmoke;
            txtDescripcion.BorderStyle = BorderStyle.FixedSingle;
            txtDescripcion.Font = new Font("Arial", 24F, FontStyle.Regular, GraphicsUnit.Point);
            txtDescripcion.ForeColor = Color.FromArgb(64, 64, 64);
            txtDescripcion.Location = new Point(32, 129);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.PlaceholderText = "Ej: Local";
            txtDescripcion.Size = new Size(408, 44);
            txtDescripcion.TabIndex = 16;
            // 
            // _00014_IngresoBruto_Abm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(473, 281);
            Controls.Add(label1);
            Controls.Add(txtDescripcion);
            MaximumSize = new Size(489, 320);
            MinimumSize = new Size(489, 320);
            Name = "_00014_IngresoBruto_Abm";
            Controls.SetChildIndex(txtDescripcion, 0);
            Controls.SetChildIndex(label1, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtDescripcion;
    }
}