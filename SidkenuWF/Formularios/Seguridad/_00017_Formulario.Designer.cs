namespace SidkenuWF.Formularios.Seguridad
{
    partial class _00017_Formulario
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
            btnAgregar = new FontAwesome.Sharp.IconButton();
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
            pnlBotonera.Controls.Add(btnAgregar);
            pnlBotonera.Location = new Point(722, 111);
            pnlBotonera.Size = new Size(78, 339);
            // 
            // btnAgregar
            // 
            btnAgregar.Dock = DockStyle.Top;
            btnAgregar.FlatAppearance.BorderSize = 0;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.ForeColor = Color.FromArgb(64, 64, 64);
            btnAgregar.IconChar = FontAwesome.Sharp.IconChar.FileEdit;
            btnAgregar.IconColor = Color.FromArgb(64, 64, 64);
            btnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAgregar.IconSize = 25;
            btnAgregar.Location = new Point(0, 0);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(78, 58);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "Agregar";
            btnAgregar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += BtnAgregar_Click;
            // 
            // _00017_Formulario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Name = "_00017_Formulario";
            Text = "Tsidkenu";
            pnlBotonera.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FontAwesome.Sharp.IconButton btnAgregar;
    }
}