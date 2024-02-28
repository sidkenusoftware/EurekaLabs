namespace SidkenuWF.Formularios.Base.Controles
{
    partial class SidkenuUserLogin
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
            pnlSuperior = new Panel();
            lblUser = new Label();
            imgFoto = new SidkenuCircularPictureBox();
            lblApyNomEmpleado = new Label();
            btnCambiarPassword = new FontAwesome.Sharp.IconButton();
            btnCerrarSesion = new FontAwesome.Sharp.IconButton();
            btnSalir = new FontAwesome.Sharp.IconButton();
            pnlSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgFoto).BeginInit();
            SuspendLayout();
            // 
            // pnlSuperior
            // 
            pnlSuperior.BackColor = Color.FromArgb(48, 66, 80);
            pnlSuperior.Controls.Add(lblUser);
            pnlSuperior.Dock = DockStyle.Top;
            pnlSuperior.Location = new Point(0, 0);
            pnlSuperior.Name = "pnlSuperior";
            pnlSuperior.Size = new Size(204, 98);
            pnlSuperior.TabIndex = 0;
            // 
            // lblUser
            // 
            lblUser.Dock = DockStyle.Top;
            lblUser.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblUser.ForeColor = Color.WhiteSmoke;
            lblUser.Location = new Point(0, 0);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(204, 39);
            lblUser.TabIndex = 0;
            lblUser.Text = "Usuario Login";
            lblUser.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // imgFoto
            // 
            imgFoto.Anchor = AnchorStyles.Top;
            imgFoto.BackColor = Color.White;
            imgFoto.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            imgFoto.BorderColor = Color.White;
            imgFoto.BorderColor2 = Color.White;
            imgFoto.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            imgFoto.BorderSize = 2;
            imgFoto.GradientAngle = 50F;
            imgFoto.Image = Properties.Resources.ImagenFondo;
            imgFoto.Location = new Point(51, 47);
            imgFoto.Name = "imgFoto";
            imgFoto.Size = new Size(100, 100);
            imgFoto.SizeMode = PictureBoxSizeMode.StretchImage;
            imgFoto.TabIndex = 1;
            imgFoto.TabStop = false;
            // 
            // lblApyNomEmpleado
            // 
            lblApyNomEmpleado.BackColor = Color.White;
            lblApyNomEmpleado.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblApyNomEmpleado.ForeColor = Color.FromArgb(64, 64, 64);
            lblApyNomEmpleado.Location = new Point(6, 156);
            lblApyNomEmpleado.Name = "lblApyNomEmpleado";
            lblApyNomEmpleado.Size = new Size(192, 27);
            lblApyNomEmpleado.TabIndex = 2;
            lblApyNomEmpleado.Text = "Empleado Login";
            lblApyNomEmpleado.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnCambiarPassword
            // 
            btnCambiarPassword.BackColor = Color.FromArgb(224, 224, 224);
            btnCambiarPassword.FlatAppearance.BorderColor = Color.Gray;
            btnCambiarPassword.FlatAppearance.BorderSize = 0;
            btnCambiarPassword.FlatStyle = FlatStyle.Flat;
            btnCambiarPassword.IconChar = FontAwesome.Sharp.IconChar.Key;
            btnCambiarPassword.IconColor = Color.Gray;
            btnCambiarPassword.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCambiarPassword.IconSize = 25;
            btnCambiarPassword.Location = new Point(9, 199);
            btnCambiarPassword.Name = "btnCambiarPassword";
            btnCambiarPassword.Size = new Size(40, 31);
            btnCambiarPassword.TabIndex = 3;
            btnCambiarPassword.UseVisualStyleBackColor = false;
            btnCambiarPassword.Click += BtnCambiarPassword_Click;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.BackColor = Color.FromArgb(224, 224, 224);
            btnCerrarSesion.FlatAppearance.BorderColor = Color.Gray;
            btnCerrarSesion.FlatAppearance.BorderSize = 0;
            btnCerrarSesion.FlatStyle = FlatStyle.Flat;
            btnCerrarSesion.ForeColor = Color.Gray;
            btnCerrarSesion.IconChar = FontAwesome.Sharp.IconChar.None;
            btnCerrarSesion.IconColor = Color.Black;
            btnCerrarSesion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCerrarSesion.Location = new Point(55, 199);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(138, 31);
            btnCerrarSesion.TabIndex = 4;
            btnCerrarSesion.Text = "Cerrar Sesion";
            btnCerrarSesion.UseVisualStyleBackColor = false;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.FromArgb(224, 224, 224);
            btnSalir.FlatAppearance.BorderColor = Color.Gray;
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.ForeColor = Color.Gray;
            btnSalir.IconChar = FontAwesome.Sharp.IconChar.None;
            btnSalir.IconColor = Color.Black;
            btnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSalir.Location = new Point(9, 236);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(184, 31);
            btnSalir.TabIndex = 5;
            btnSalir.Text = "Salir del Sistema";
            btnSalir.UseVisualStyleBackColor = false;
            // 
            // SidkenuUserLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(btnSalir);
            Controls.Add(btnCerrarSesion);
            Controls.Add(btnCambiarPassword);
            Controls.Add(lblApyNomEmpleado);
            Controls.Add(imgFoto);
            Controls.Add(pnlSuperior);
            MaximumSize = new Size(204, 275);
            MinimumSize = new Size(204, 275);
            Name = "SidkenuUserLogin";
            Size = new Size(204, 275);
            pnlSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)imgFoto).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlSuperior;
        private Label lblUser;
        private SidkenuCircularPictureBox imgFoto;
        private Label lblApyNomEmpleado;
        private FontAwesome.Sharp.IconButton btnCambiarPassword;
        public FontAwesome.Sharp.IconButton btnCerrarSesion;
        public FontAwesome.Sharp.IconButton btnSalir;
    }
}
