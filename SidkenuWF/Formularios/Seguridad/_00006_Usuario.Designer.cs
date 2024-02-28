namespace SidkenuWF.Formularios.Seguridad
{
    partial class _00006_Usuario
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
            btnCrear = new FontAwesome.Sharp.IconButton();
            pnlBotonera.SuspendLayout();
            SuspendLayout();
            // 
            // pnlInferior
            // 
            pnlInferior.Location = new Point(0, 423);
            pnlInferior.Size = new Size(696, 27);
            // 
            // pnlBotonera
            // 
            pnlBotonera.Controls.Add(btnCrear);
            pnlBotonera.Location = new Point(722, 111);
            pnlBotonera.Size = new Size(78, 339);
            // 
            // btnCrear
            // 
            btnCrear.Dock = DockStyle.Top;
            btnCrear.FlatAppearance.BorderSize = 0;
            btnCrear.FlatStyle = FlatStyle.Flat;
            btnCrear.ForeColor = Color.FromArgb(64, 64, 64);
            btnCrear.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            btnCrear.IconColor = Color.Gray;
            btnCrear.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCrear.IconSize = 35;
            btnCrear.Location = new Point(0, 0);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(78, 58);
            btnCrear.TabIndex = 0;
            btnCrear.Text = "Crear";
            btnCrear.TextImageRelation = TextImageRelation.ImageAboveText;
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += BtnCrear_Click;
            // 
            // _00006_Usuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Name = "_00006_Usuario";
            Text = "Sidkenu";
            pnlBotonera.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FontAwesome.Sharp.IconButton btnCrear;
    }
}