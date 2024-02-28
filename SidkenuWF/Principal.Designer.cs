namespace SidkenuWF
{
    partial class Principal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlSuperior = new Panel();
            imgLogoEmpresa = new PictureBox();
            lblDatosEmpresa = new Label();
            lblEmpresa = new Label();
            btnUserLogin = new FontAwesome.Sharp.IconButton();
            pnlContenedor = new Panel();
            CtrolModulosSistema = new Formularios.Base.Controles.SidkenuContenedorModulos();
            CtrolUserLogin = new Formularios.Base.Controles.SidkenuUserLogin();
            pnlSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgLogoEmpresa).BeginInit();
            pnlContenedor.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSuperior
            // 
            pnlSuperior.BackColor = Color.FromArgb(192, 64, 0);
            pnlSuperior.Controls.Add(imgLogoEmpresa);
            pnlSuperior.Controls.Add(lblDatosEmpresa);
            pnlSuperior.Controls.Add(lblEmpresa);
            pnlSuperior.Controls.Add(btnUserLogin);
            pnlSuperior.Dock = DockStyle.Top;
            pnlSuperior.Location = new Point(0, 0);
            pnlSuperior.Name = "pnlSuperior";
            pnlSuperior.Size = new Size(1097, 62);
            pnlSuperior.TabIndex = 0;
            // 
            // imgLogoEmpresa
            // 
            imgLogoEmpresa.Location = new Point(12, 4);
            imgLogoEmpresa.Name = "imgLogoEmpresa";
            imgLogoEmpresa.Size = new Size(55, 54);
            imgLogoEmpresa.SizeMode = PictureBoxSizeMode.StretchImage;
            imgLogoEmpresa.TabIndex = 4;
            imgLogoEmpresa.TabStop = false;
            // 
            // lblDatosEmpresa
            // 
            lblDatosEmpresa.BackColor = Color.Transparent;
            lblDatosEmpresa.ForeColor = Color.LightGray;
            lblDatosEmpresa.Location = new Point(83, 39);
            lblDatosEmpresa.Name = "lblDatosEmpresa";
            lblDatosEmpresa.Size = new Size(528, 19);
            lblDatosEmpresa.TabIndex = 3;
            lblDatosEmpresa.Text = "Datos empresa";
            lblDatosEmpresa.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblEmpresa
            // 
            lblEmpresa.BackColor = Color.Transparent;
            lblEmpresa.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblEmpresa.ForeColor = Color.WhiteSmoke;
            lblEmpresa.Location = new Point(73, 4);
            lblEmpresa.Name = "lblEmpresa";
            lblEmpresa.Size = new Size(552, 33);
            lblEmpresa.TabIndex = 2;
            lblEmpresa.Text = "Empresa";
            lblEmpresa.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnUserLogin
            // 
            btnUserLogin.Dock = DockStyle.Right;
            btnUserLogin.FlatAppearance.BorderSize = 0;
            btnUserLogin.FlatStyle = FlatStyle.Flat;
            btnUserLogin.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            btnUserLogin.IconColor = Color.WhiteSmoke;
            btnUserLogin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnUserLogin.IconSize = 30;
            btnUserLogin.Location = new Point(1038, 0);
            btnUserLogin.Name = "btnUserLogin";
            btnUserLogin.Size = new Size(59, 62);
            btnUserLogin.TabIndex = 0;
            btnUserLogin.UseVisualStyleBackColor = true;
            btnUserLogin.Click += BtnUserLogin_Click;
            // 
            // pnlContenedor
            // 
            pnlContenedor.BackColor = Color.White;
            pnlContenedor.Controls.Add(CtrolModulosSistema);
            pnlContenedor.Controls.Add(CtrolUserLogin);
            pnlContenedor.Dock = DockStyle.Fill;
            pnlContenedor.Location = new Point(0, 62);
            pnlContenedor.Name = "pnlContenedor";
            pnlContenedor.Size = new Size(1097, 687);
            pnlContenedor.TabIndex = 1;
            pnlContenedor.ControlRemoved += PnlContenedor_ControlRemoved;
            // 
            // CtrolModulosSistema
            // 
            CtrolModulosSistema.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CtrolModulosSistema.AutoScroll = true;
            CtrolModulosSistema.AutoSize = true;
            CtrolModulosSistema.BackColor = Color.FromArgb(255, 255, 192);
            CtrolModulosSistema.Location = new Point(39, 32);
            CtrolModulosSistema.Name = "CtrolModulosSistema";
            CtrolModulosSistema.Size = new Size(1022, 609);
            CtrolModulosSistema.TabIndex = 1;
            // 
            // CtrolUserLogin
            // 
            CtrolUserLogin.BackColor = Color.White;
            CtrolUserLogin.BorderStyle = BorderStyle.FixedSingle;
            CtrolUserLogin.Dock = DockStyle.Right;
            CtrolUserLogin.Location = new Point(893, 0);
            CtrolUserLogin.MaximumSize = new Size(204, 275);
            CtrolUserLogin.MinimumSize = new Size(204, 275);
            CtrolUserLogin.Name = "CtrolUserLogin";
            CtrolUserLogin.Size = new Size(204, 275);
            CtrolUserLogin.TabIndex = 0;
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1097, 749);
            Controls.Add(pnlContenedor);
            Controls.Add(pnlSuperior);
            Name = "Principal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sidkenu - Software de Gestión";
            WindowState = FormWindowState.Maximized;
            FormClosed += Principal_FormClosed;
            pnlSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)imgLogoEmpresa).EndInit();
            pnlContenedor.ResumeLayout(false);
            pnlContenedor.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlSuperior;
        private Panel pnlContenedor;
        private Formularios.Base.Controles.SidkenuUserLogin CtrolUserLogin;
        private FontAwesome.Sharp.IconButton btnUserLogin;
        private Formularios.Base.Controles.SidkenuContenedorModulos CtrolModulosSistema;
        private Label lblEmpresa;
        private Label lblDatosEmpresa;
        private PictureBox imgLogoEmpresa;
    }
}