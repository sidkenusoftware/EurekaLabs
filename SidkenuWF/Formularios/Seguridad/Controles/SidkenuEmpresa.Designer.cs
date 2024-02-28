namespace SidkenuWF.Formularios.Base.Controles
{
    partial class SidkenuEmpresa
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
            lblDescripcion = new Label();
            imgLogo = new PictureBox();
            btnSeleccionar = new Button();
            lblCodigo = new Label();
            lblDireccion = new Label();
            lblAbreviatura = new Label();
            pnlLinea = new Panel();
            pnlSombra = new Panel();
            ((System.ComponentModel.ISupportInitialize)imgLogo).BeginInit();
            SuspendLayout();
            // 
            // lblDescripcion
            // 
            lblDescripcion.BackColor = Color.Transparent;
            lblDescripcion.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDescripcion.ForeColor = Color.FromArgb(64, 64, 64);
            lblDescripcion.Location = new Point(144, 5);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(197, 48);
            lblDescripcion.TabIndex = 0;
            lblDescripcion.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // imgLogo
            // 
            imgLogo.BackColor = Color.WhiteSmoke;
            imgLogo.BorderStyle = BorderStyle.FixedSingle;
            imgLogo.Location = new Point(6, 6);
            imgLogo.Name = "imgLogo";
            imgLogo.Size = new Size(69, 65);
            imgLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            imgLogo.TabIndex = 1;
            imgLogo.TabStop = false;
            // 
            // btnSeleccionar
            // 
            btnSeleccionar.BackColor = Color.LightSeaGreen;
            btnSeleccionar.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            btnSeleccionar.FlatStyle = FlatStyle.Flat;
            btnSeleccionar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSeleccionar.ForeColor = Color.White;
            btnSeleccionar.Location = new Point(218, 90);
            btnSeleccionar.Name = "btnSeleccionar";
            btnSeleccionar.Size = new Size(124, 33);
            btnSeleccionar.TabIndex = 2;
            btnSeleccionar.Text = "Seleccionar";
            btnSeleccionar.UseVisualStyleBackColor = false;
            btnSeleccionar.Click += BtnSeleccionar_Click;
            // 
            // lblCodigo
            // 
            lblCodigo.BackColor = Color.WhiteSmoke;
            lblCodigo.Font = new Font("Arial Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblCodigo.ForeColor = Color.WhiteSmoke;
            lblCodigo.Location = new Point(6, 78);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(69, 43);
            lblCodigo.TabIndex = 3;
            lblCodigo.Text = "1";
            lblCodigo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDireccion
            // 
            lblDireccion.BackColor = Color.Transparent;
            lblDireccion.ForeColor = Color.FromArgb(64, 64, 64);
            lblDireccion.Location = new Point(81, 61);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(260, 23);
            lblDireccion.TabIndex = 4;
            lblDireccion.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblAbreviatura
            // 
            lblAbreviatura.BackColor = Color.Transparent;
            lblAbreviatura.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblAbreviatura.ForeColor = Color.FromArgb(64, 64, 64);
            lblAbreviatura.Location = new Point(81, 5);
            lblAbreviatura.Name = "lblAbreviatura";
            lblAbreviatura.Size = new Size(48, 48);
            lblAbreviatura.TabIndex = 5;
            lblAbreviatura.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlLinea
            // 
            pnlLinea.BackColor = Color.FromArgb(224, 224, 224);
            pnlLinea.Location = new Point(81, 56);
            pnlLinea.Name = "pnlLinea";
            pnlLinea.Size = new Size(260, 2);
            pnlLinea.TabIndex = 6;
            // 
            // pnlSombra
            // 
            pnlSombra.BackColor = Color.FromArgb(224, 224, 224);
            pnlSombra.Location = new Point(9, 9);
            pnlSombra.Name = "pnlSombra";
            pnlSombra.Size = new Size(69, 65);
            pnlSombra.TabIndex = 7;
            // 
            // SidkenuEmpresa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            Controls.Add(pnlLinea);
            Controls.Add(lblAbreviatura);
            Controls.Add(lblDireccion);
            Controls.Add(lblCodigo);
            Controls.Add(btnSeleccionar);
            Controls.Add(imgLogo);
            Controls.Add(lblDescripcion);
            Controls.Add(pnlSombra);
            MaximumSize = new Size(348, 129);
            MinimumSize = new Size(348, 129);
            Name = "SidkenuEmpresa";
            Size = new Size(348, 129);
            ((System.ComponentModel.ISupportInitialize)imgLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblDescripcion;
        private PictureBox imgLogo;
        public Button btnSeleccionar;
        private Label lblCodigo;
        private Label lblDireccion;
        private Label lblAbreviatura;
        private Panel pnlLinea;
        private Panel pnlSombra;
    }
}
