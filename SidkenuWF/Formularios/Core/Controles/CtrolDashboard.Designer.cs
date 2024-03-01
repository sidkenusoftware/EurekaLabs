namespace SidkenuWF.Formularios.Core.Controles
{
    partial class CtrolDashboard
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
            imgLogo = new FontAwesome.Sharp.IconPictureBox();
            lblTitulo = new Label();
            lblValor = new Label();
            ((System.ComponentModel.ISupportInitialize)imgLogo).BeginInit();
            SuspendLayout();
            // 
            // imgLogo
            // 
            imgLogo.BackColor = Color.Transparent;
            imgLogo.ForeColor = Color.FromArgb(224, 224, 224);
            imgLogo.IconChar = FontAwesome.Sharp.IconChar.None;
            imgLogo.IconColor = Color.FromArgb(224, 224, 224);
            imgLogo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            imgLogo.IconSize = 77;
            imgLogo.Location = new Point(8, 7);
            imgLogo.Name = "imgLogo";
            imgLogo.Size = new Size(77, 77);
            imgLogo.TabIndex = 0;
            imgLogo.TabStop = false;
            // 
            // lblTitulo
            // 
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.ForeColor = Color.Yellow;
            lblTitulo.Location = new Point(91, 7);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(166, 28);
            lblTitulo.TabIndex = 1;
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblValor
            // 
            lblValor.BackColor = Color.Transparent;
            lblValor.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblValor.ForeColor = Color.White;
            lblValor.Location = new Point(91, 43);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(166, 38);
            lblValor.TabIndex = 2;
            lblValor.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CtrolDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            Controls.Add(lblValor);
            Controls.Add(lblTitulo);
            Controls.Add(imgLogo);
            Name = "CtrolDashboard";
            Size = new Size(265, 91);
            ((System.ComponentModel.ISupportInitialize)imgLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FontAwesome.Sharp.IconPictureBox imgLogo;
        private Label lblTitulo;
        private Label lblValor;
    }
}
