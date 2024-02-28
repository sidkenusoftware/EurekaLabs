namespace SidkenuWF.Formularios.Base.Controles
{
    partial class CtrolLoginAvatar
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            lblApyNom = new Label();
            imgFoto = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)imgFoto).BeginInit();
            SuspendLayout();
            // 
            // lblApyNom
            // 
            lblApyNom.BackColor = Color.FromArgb(64, 64, 64);
            lblApyNom.Dock = DockStyle.Bottom;
            lblApyNom.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblApyNom.ForeColor = Color.Silver;
            lblApyNom.Location = new Point(0, 143);
            lblApyNom.Name = "lblApyNom";
            lblApyNom.Size = new Size(146, 30);
            lblApyNom.TabIndex = 0;
            lblApyNom.TextAlign = ContentAlignment.BottomCenter;
            lblApyNom.MouseLeave += Control_MouseLeave;
            lblApyNom.MouseMove += Control_MouseMove;
            // 
            // imgFoto
            // 
            imgFoto.BackColor = Color.FromArgb(64, 64, 64);
            imgFoto.Location = new Point(3, 2);
            imgFoto.Name = "imgFoto";
            imgFoto.Size = new Size(140, 138);
            imgFoto.SizeMode = PictureBoxSizeMode.StretchImage;
            imgFoto.TabIndex = 1;
            imgFoto.TabStop = false;
            imgFoto.MouseLeave += Control_MouseLeave;
            imgFoto.MouseMove += Control_MouseMove;
            // 
            // CtrolLoginAvatar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            Controls.Add(imgFoto);
            Controls.Add(lblApyNom);
            Margin = new Padding(10);
            Name = "CtrolLoginAvatar";
            Size = new Size(146, 173);
            MouseLeave += Control_MouseLeave;
            MouseMove += Control_MouseMove;
            ((System.ComponentModel.ISupportInitialize)imgFoto).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public Label lblApyNom;
        public PictureBox imgFoto;
    }
}
