namespace SidkenuWF.Formularios.Seguridad.Controles
{
    partial class SidkenuModulo
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
            pnlLinea = new Panel();
            btnIngresar = new FontAwesome.Sharp.IconButton();
            lblTitulo = new Label();
            lblDescripcion = new Label();
            pnlSombra = new Panel();
            pnlLateral = new Panel();
            ((System.ComponentModel.ISupportInitialize)imgLogo).BeginInit();
            SuspendLayout();
            // 
            // imgLogo
            // 
            imgLogo.BackColor = Color.Red;
            imgLogo.IconChar = FontAwesome.Sharp.IconChar.None;
            imgLogo.IconColor = Color.White;
            imgLogo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            imgLogo.IconSize = 70;
            imgLogo.Location = new Point(10, 10);
            imgLogo.Name = "imgLogo";
            imgLogo.Size = new Size(70, 70);
            imgLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            imgLogo.TabIndex = 0;
            imgLogo.TabStop = false;
            imgLogo.MouseEnter += ImgLogo_MouseEnter;
            imgLogo.MouseLeave += ImgLogo_MouseLeave;
            // 
            // pnlLinea
            // 
            pnlLinea.BackColor = Color.LightGray;
            pnlLinea.Location = new Point(10, 90);
            pnlLinea.Name = "pnlLinea";
            pnlLinea.Size = new Size(269, 1);
            pnlLinea.TabIndex = 1;
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.Teal;
            btnIngresar.FlatStyle = FlatStyle.Flat;
            btnIngresar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnIngresar.ForeColor = Color.White;
            btnIngresar.IconChar = FontAwesome.Sharp.IconChar.PersonWalking;
            btnIngresar.IconColor = Color.White;
            btnIngresar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnIngresar.IconSize = 20;
            btnIngresar.ImageAlign = ContentAlignment.MiddleLeft;
            btnIngresar.Location = new Point(189, 93);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(90, 34);
            btnIngresar.TabIndex = 2;
            btnIngresar.Text = "Ingresar";
            btnIngresar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnIngresar.UseVisualStyleBackColor = false;
            // 
            // lblTitulo
            // 
            lblTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.Location = new Point(86, 10);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(199, 32);
            lblTitulo.TabIndex = 3;
            lblTitulo.Text = "Titulo";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDescripcion
            // 
            lblDescripcion.Location = new Point(86, 42);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(199, 38);
            lblDescripcion.TabIndex = 4;
            lblDescripcion.Text = "Descripcion";
            lblDescripcion.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlSombra
            // 
            pnlSombra.BackColor = Color.Gainsboro;
            pnlSombra.Location = new Point(12, 13);
            pnlSombra.Name = "pnlSombra";
            pnlSombra.Size = new Size(71, 70);
            pnlSombra.TabIndex = 5;
            // 
            // pnlLateral
            // 
            pnlLateral.BackColor = Color.FromArgb(192, 64, 0);
            pnlLateral.Dock = DockStyle.Left;
            pnlLateral.Location = new Point(0, 0);
            pnlLateral.Name = "pnlLateral";
            pnlLateral.Size = new Size(4, 132);
            pnlLateral.TabIndex = 6;
            // 
            // SidkenuModulo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(pnlLateral);
            Controls.Add(lblDescripcion);
            Controls.Add(lblTitulo);
            Controls.Add(btnIngresar);
            Controls.Add(pnlLinea);
            Controls.Add(imgLogo);
            Controls.Add(pnlSombra);
            Name = "SidkenuModulo";
            Size = new Size(288, 132);
            ((System.ComponentModel.ISupportInitialize)imgLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel pnlLinea;
        private Label lblTitulo;
        private Label lblDescripcion;
        public FontAwesome.Sharp.IconButton btnIngresar;
        private Panel pnlSombra;
        private Panel pnlLateral;
        public FontAwesome.Sharp.IconPictureBox imgLogo;
    }
}
