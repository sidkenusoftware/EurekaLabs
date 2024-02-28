namespace SidkenuWF.Formularios.Core
{
    partial class _00100_Caja
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
            btnAgregarQuitarPuestosTrabajos = new FontAwesome.Sharp.IconButton();
            pnlBotonera.SuspendLayout();
            SuspendLayout();
            // 
            // pnlInferior
            // 
            pnlInferior.Location = new Point(0, 414);
            pnlInferior.Size = new Size(674, 36);
            // 
            // pnlBotonera
            // 
            pnlBotonera.Controls.Add(btnAgregarQuitarPuestosTrabajos);
            pnlBotonera.Location = new Point(701, 111);
            pnlBotonera.Size = new Size(99, 339);
            // 
            // btnAgregarQuitarPuestosTrabajos
            // 
            btnAgregarQuitarPuestosTrabajos.Dock = DockStyle.Top;
            btnAgregarQuitarPuestosTrabajos.FlatAppearance.BorderSize = 0;
            btnAgregarQuitarPuestosTrabajos.FlatStyle = FlatStyle.Flat;
            btnAgregarQuitarPuestosTrabajos.ForeColor = Color.FromArgb(64, 64, 64);
            btnAgregarQuitarPuestosTrabajos.IconChar = FontAwesome.Sharp.IconChar.Computer;
            btnAgregarQuitarPuestosTrabajos.IconColor = Color.FromArgb(64, 64, 64);
            btnAgregarQuitarPuestosTrabajos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAgregarQuitarPuestosTrabajos.IconSize = 35;
            btnAgregarQuitarPuestosTrabajos.Location = new Point(0, 0);
            btnAgregarQuitarPuestosTrabajos.Name = "btnAgregarQuitarPuestosTrabajos";
            btnAgregarQuitarPuestosTrabajos.Size = new Size(99, 93);
            btnAgregarQuitarPuestosTrabajos.TabIndex = 3;
            btnAgregarQuitarPuestosTrabajos.Text = "Asignar Quitar Puestos de Trabajo";
            btnAgregarQuitarPuestosTrabajos.TextImageRelation = TextImageRelation.ImageAboveText;
            btnAgregarQuitarPuestosTrabajos.UseVisualStyleBackColor = true;
            btnAgregarQuitarPuestosTrabajos.Click += BtnAgregarQuitarPuestosTrabajos_Click;
            // 
            // _00100_Caja
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Name = "_00100_Caja";
            Text = "_00100_Caja";
            pnlBotonera.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FontAwesome.Sharp.IconButton btnAgregarQuitarPuestosTrabajos;
    }
}