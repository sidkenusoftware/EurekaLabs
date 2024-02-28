namespace SidkenuWF.Formularios.Core.Varios
{
    partial class CambiarCantidadFormula
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
            pnlTestigo = new Panel();
            lblArticulo = new Label();
            pnlBotonera = new Panel();
            btnEjecutar = new FontAwesome.Sharp.IconButton();
            nudCantidadArticulos = new NumericUpDown();
            label8 = new Label();
            pnlTestigo.SuspendLayout();
            pnlBotonera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudCantidadArticulos).BeginInit();
            SuspendLayout();
            // 
            // pnlTestigo
            // 
            pnlTestigo.BackColor = Color.FromArgb(192, 64, 0);
            pnlTestigo.Controls.Add(lblArticulo);
            pnlTestigo.Dock = DockStyle.Top;
            pnlTestigo.Location = new Point(0, 59);
            pnlTestigo.Name = "pnlTestigo";
            pnlTestigo.Size = new Size(357, 54);
            pnlTestigo.TabIndex = 133;
            // 
            // lblArticulo
            // 
            lblArticulo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblArticulo.BackColor = Color.Transparent;
            lblArticulo.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblArticulo.ForeColor = Color.White;
            lblArticulo.Location = new Point(7, 2);
            lblArticulo.Name = "lblArticulo";
            lblArticulo.Size = new Size(347, 45);
            lblArticulo.TabIndex = 0;
            lblArticulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlBotonera
            // 
            pnlBotonera.BackColor = Color.FromArgb(48, 66, 80);
            pnlBotonera.Controls.Add(btnEjecutar);
            pnlBotonera.Dock = DockStyle.Bottom;
            pnlBotonera.Location = new Point(0, 211);
            pnlBotonera.Name = "pnlBotonera";
            pnlBotonera.Size = new Size(357, 40);
            pnlBotonera.TabIndex = 132;
            // 
            // btnEjecutar
            // 
            btnEjecutar.BackColor = Color.FromArgb(54, 74, 90);
            btnEjecutar.FlatAppearance.BorderColor = Color.WhiteSmoke;
            btnEjecutar.FlatAppearance.BorderSize = 0;
            btnEjecutar.FlatStyle = FlatStyle.Flat;
            btnEjecutar.ForeColor = Color.WhiteSmoke;
            btnEjecutar.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            btnEjecutar.IconColor = Color.WhiteSmoke;
            btnEjecutar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEjecutar.IconSize = 22;
            btnEjecutar.Location = new Point(13, 6);
            btnEjecutar.Name = "btnEjecutar";
            btnEjecutar.Size = new Size(81, 28);
            btnEjecutar.TabIndex = 2;
            btnEjecutar.Text = "Guardar";
            btnEjecutar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEjecutar.UseVisualStyleBackColor = false;
            btnEjecutar.Click += BtnEjecutar_Click;
            // 
            // nudCantidadArticulos
            // 
            nudCantidadArticulos.DecimalPlaces = 2;
            nudCantidadArticulos.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            nudCantidadArticulos.Location = new Point(107, 151);
            nudCantidadArticulos.Maximum = new decimal(new int[] { -559939584, 902409669, 54, 0 });
            nudCantidadArticulos.Minimum = new decimal(new int[] { 1, 0, 0, 131072 });
            nudCantidadArticulos.Name = "nudCantidadArticulos";
            nudCantidadArticulos.Size = new Size(142, 29);
            nudCantidadArticulos.TabIndex = 146;
            nudCantidadArticulos.Value = new decimal(new int[] { 1, 0, 0, 131072 });
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(107, 131);
            label8.Name = "label8";
            label8.Size = new Size(55, 15);
            label8.TabIndex = 147;
            label8.Text = "Cantidad";
            // 
            // CambiarCantidadFormula
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(357, 251);
            Controls.Add(nudCantidadArticulos);
            Controls.Add(label8);
            Controls.Add(pnlTestigo);
            Controls.Add(pnlBotonera);
            MaximumSize = new Size(373, 290);
            MinimumSize = new Size(373, 290);
            Name = "CambiarCantidadFormula";
            Text = "Cambiar Cantidad";
            Controls.SetChildIndex(pnlBotonera, 0);
            Controls.SetChildIndex(pnlTestigo, 0);
            Controls.SetChildIndex(label8, 0);
            Controls.SetChildIndex(nudCantidadArticulos, 0);
            pnlTestigo.ResumeLayout(false);
            pnlBotonera.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nudCantidadArticulos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel pnlTestigo;
        private Label lblArticulo;
        private Panel pnlBotonera;
        private FontAwesome.Sharp.IconButton btnEjecutar;
        private NumericUpDown nudCantidadArticulos;
        private Label label8;
    }
}