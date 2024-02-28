namespace SidkenuWF.Formularios.Base.Controles.Foto
{
    partial class SidkenuFoto
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
            pnlInferior = new Panel();
            btnAvatar = new FontAwesome.Sharp.IconButton();
            btnWebCam = new FontAwesome.Sharp.IconButton();
            btnCamara = new FontAwesome.Sharp.IconButton();
            pnlSuperior = new Panel();
            lblTitulo = new Label();
            pnlContenedor = new Panel();
            imgFoto = new PictureBox();
            openDialog = new OpenFileDialog();
            pnlInferior.SuspendLayout();
            pnlSuperior.SuspendLayout();
            pnlContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgFoto).BeginInit();
            SuspendLayout();
            // 
            // pnlInferior
            // 
            pnlInferior.BackColor = Color.Silver;
            pnlInferior.Controls.Add(btnAvatar);
            pnlInferior.Controls.Add(btnWebCam);
            pnlInferior.Controls.Add(btnCamara);
            pnlInferior.Dock = DockStyle.Bottom;
            pnlInferior.Location = new Point(0, 153);
            pnlInferior.Name = "pnlInferior";
            pnlInferior.Size = new Size(130, 35);
            pnlInferior.TabIndex = 0;
            // 
            // btnAvatar
            // 
            btnAvatar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            btnAvatar.FlatAppearance.BorderColor = Color.DimGray;
            btnAvatar.FlatStyle = FlatStyle.Flat;
            btnAvatar.ForeColor = Color.WhiteSmoke;
            btnAvatar.IconChar = FontAwesome.Sharp.IconChar.Paw;
            btnAvatar.IconColor = Color.FromArgb(64, 64, 64);
            btnAvatar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAvatar.IconSize = 15;
            btnAvatar.Location = new Point(92, 5);
            btnAvatar.Name = "btnAvatar";
            btnAvatar.Size = new Size(32, 26);
            btnAvatar.TabIndex = 2;
            btnAvatar.UseVisualStyleBackColor = true;
            btnAvatar.Click += BtnAvatar_Click;
            // 
            // btnWebCam
            // 
            btnWebCam.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            btnWebCam.FlatAppearance.BorderColor = Color.DimGray;
            btnWebCam.FlatStyle = FlatStyle.Flat;
            btnWebCam.ForeColor = Color.WhiteSmoke;
            btnWebCam.IconChar = FontAwesome.Sharp.IconChar.VideoCamera;
            btnWebCam.IconColor = Color.FromArgb(64, 64, 64);
            btnWebCam.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnWebCam.IconSize = 15;
            btnWebCam.Location = new Point(42, 5);
            btnWebCam.Name = "btnWebCam";
            btnWebCam.Size = new Size(32, 26);
            btnWebCam.TabIndex = 1;
            btnWebCam.UseVisualStyleBackColor = true;
            btnWebCam.Click += BtnWebCam_Click;
            // 
            // btnCamara
            // 
            btnCamara.FlatAppearance.BorderColor = Color.DimGray;
            btnCamara.FlatStyle = FlatStyle.Flat;
            btnCamara.ForeColor = Color.WhiteSmoke;
            btnCamara.IconChar = FontAwesome.Sharp.IconChar.Camera;
            btnCamara.IconColor = Color.FromArgb(64, 64, 64);
            btnCamara.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCamara.IconSize = 15;
            btnCamara.Location = new Point(5, 5);
            btnCamara.Name = "btnCamara";
            btnCamara.Size = new Size(32, 26);
            btnCamara.TabIndex = 0;
            btnCamara.UseVisualStyleBackColor = true;
            btnCamara.Click += BtnCamara_Click;
            // 
            // pnlSuperior
            // 
            pnlSuperior.BackColor = Color.Gainsboro;
            pnlSuperior.Controls.Add(lblTitulo);
            pnlSuperior.Dock = DockStyle.Top;
            pnlSuperior.ForeColor = Color.Black;
            pnlSuperior.Location = new Point(0, 0);
            pnlSuperior.Name = "pnlSuperior";
            pnlSuperior.Size = new Size(130, 25);
            pnlSuperior.TabIndex = 1;
            // 
            // lblTitulo
            // 
            lblTitulo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblTitulo.BackColor = Color.Gainsboro;
            lblTitulo.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.ForeColor = Color.Black;
            lblTitulo.Location = new Point(6, 4);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(118, 17);
            lblTitulo.TabIndex = 4;
            lblTitulo.Text = "Capturar Imagen";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlContenedor
            // 
            pnlContenedor.BackColor = Color.Silver;
            pnlContenedor.Controls.Add(imgFoto);
            pnlContenedor.Dock = DockStyle.Fill;
            pnlContenedor.Location = new Point(0, 25);
            pnlContenedor.Name = "pnlContenedor";
            pnlContenedor.Size = new Size(130, 128);
            pnlContenedor.TabIndex = 2;
            // 
            // imgFoto
            // 
            imgFoto.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            imgFoto.BackColor = Color.WhiteSmoke;
            imgFoto.Location = new Point(6, 4);
            imgFoto.Name = "imgFoto";
            imgFoto.Size = new Size(118, 118);
            imgFoto.SizeMode = PictureBoxSizeMode.StretchImage;
            imgFoto.TabIndex = 0;
            imgFoto.TabStop = false;
            // 
            // openDialog
            // 
            openDialog.FileName = "openFileDialog1";
            // 
            // SidkenuFoto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            Controls.Add(pnlContenedor);
            Controls.Add(pnlSuperior);
            Controls.Add(pnlInferior);
            MinimumSize = new Size(130, 157);
            Name = "SidkenuFoto";
            Size = new Size(130, 188);
            Load += SidkenuFoto_Load;
            pnlInferior.ResumeLayout(false);
            pnlSuperior.ResumeLayout(false);
            pnlContenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)imgFoto).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlInferior;
        private Panel pnlSuperior;
        private Panel pnlContenedor;
        private FontAwesome.Sharp.IconButton btnWebCam;
        private FontAwesome.Sharp.IconButton btnCamara;
        private Label lblTitulo;
        private OpenFileDialog openDialog;
        public PictureBox imgFoto;
        private FontAwesome.Sharp.IconButton btnAvatar;
    }
}
