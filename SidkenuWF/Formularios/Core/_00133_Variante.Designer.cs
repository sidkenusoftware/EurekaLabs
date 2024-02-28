namespace SidkenuWF.Formularios.Core
{
    partial class _00133_Variante
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
            btnVariantes = new FontAwesome.Sharp.IconButton();
            pnlBotonera.SuspendLayout();
            SuspendLayout();
            // 
            // pnlInferior
            // 
            pnlInferior.Location = new Point(0, 414);
            pnlInferior.Size = new Size(696, 36);
            // 
            // pnlBotonera
            // 
            pnlBotonera.Controls.Add(btnVariantes);
            pnlBotonera.Location = new Point(722, 111);
            pnlBotonera.Size = new Size(78, 339);
            // 
            // btnVariantes
            // 
            btnVariantes.Dock = DockStyle.Top;
            btnVariantes.FlatAppearance.BorderSize = 0;
            btnVariantes.FlatStyle = FlatStyle.Flat;
            btnVariantes.ForeColor = Color.FromArgb(64, 64, 64);
            btnVariantes.IconChar = FontAwesome.Sharp.IconChar.Box;
            btnVariantes.IconColor = Color.FromArgb(192, 64, 0);
            btnVariantes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnVariantes.IconSize = 35;
            btnVariantes.Location = new Point(0, 0);
            btnVariantes.Name = "btnVariantes";
            btnVariantes.Size = new Size(78, 68);
            btnVariantes.TabIndex = 2;
            btnVariantes.Text = "Ingresar Valores";
            btnVariantes.TextImageRelation = TextImageRelation.ImageAboveText;
            btnVariantes.UseVisualStyleBackColor = true;
            btnVariantes.Click += BtnVariantes_Click;
            // 
            // _00133_Variante
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Name = "_00133_Variante";
            Text = "_00133_Variante";
            pnlBotonera.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FontAwesome.Sharp.IconButton btnVariantes;
    }
}