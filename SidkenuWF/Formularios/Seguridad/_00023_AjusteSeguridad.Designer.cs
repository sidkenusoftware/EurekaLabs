namespace SidkenuWF.Formularios.Seguridad
{
    partial class _00023_AjusteSeguridad
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            groupBox4 = new GroupBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            chkLogginError = new CheckBox();
            chkLogginWarning = new CheckBox();
            chkLogginInformacion = new CheckBox();
            groupBox3 = new GroupBox();
            label9 = new Label();
            btnVerPuerto = new FontAwesome.Sharp.IconButton();
            btnVerHost = new FontAwesome.Sharp.IconButton();
            btnVerCredencialPass = new FontAwesome.Sharp.IconButton();
            btnVerCredencialUsuario = new FontAwesome.Sharp.IconButton();
            chkEnviarMailAlCrearUsuario = new CheckBox();
            panel3 = new Panel();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtPuerto = new TextBox();
            txtHost = new TextBox();
            txtCredencialPassword = new TextBox();
            txtCredencialUsuario = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            chkModuloPuntoVenta = new CheckBox();
            chkModuloFabricacion = new CheckBox();
            chkModuloInventario = new CheckBox();
            chkModuloCompra = new CheckBox();
            chkModuloVenta = new CheckBox();
            chkModuloSeguridad = new CheckBox();
            groupBox1 = new GroupBox();
            imgLoginAvatar = new PictureBox();
            rdbLoginAvatar = new RadioButton();
            rdbLoginNormal = new RadioButton();
            imgLoginNormal = new PictureBox();
            panel1 = new Panel();
            panel2 = new Panel();
            chkModuloDashBoard = new CheckBox();
            chkModuloCaja = new CheckBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgLoginAvatar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgLoginNormal).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 57);
            tabControl1.Name = "tabControl1";
            tabControl1.Padding = new Point(10, 10);
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(784, 464);
            tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(groupBox4);
            tabPage1.Controls.Add(groupBox3);
            tabPage1.Controls.Add(groupBox2);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Location = new Point(4, 38);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(776, 422);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Sistema";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(label8);
            groupBox4.Controls.Add(label7);
            groupBox4.Controls.Add(label6);
            groupBox4.Controls.Add(chkLogginError);
            groupBox4.Controls.Add(chkLogginWarning);
            groupBox4.Controls.Add(chkLogginInformacion);
            groupBox4.Location = new Point(471, 205);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(293, 204);
            groupBox4.TabIndex = 4;
            groupBox4.TabStop = false;
            groupBox4.Text = "[ Loggin ]";
            // 
            // label8
            // 
            label8.BackColor = Color.Beige;
            label8.Location = new Point(2, 151);
            label8.Name = "label8";
            label8.Size = new Size(291, 50);
            label8.TabIndex = 8;
            label8.Text = "Nivel de registro que indica que la aplicación encuentra un problema e impide que funcionen correctamente";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            label7.BackColor = Color.Beige;
            label7.Location = new Point(0, 79);
            label7.Name = "label7";
            label7.Size = new Size(292, 50);
            label7.TabIndex = 7;
            label7.Text = "Nivel de registro que indica que sucedió algo inesperado, un problema o una situación que podría provocar el correcto funcionamiento";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.BackColor = Color.Beige;
            label6.Location = new Point(1, 36);
            label6.Name = "label6";
            label6.Size = new Size(292, 20);
            label6.TabIndex = 6;
            label6.Text = "Nivel de registro puramente informativa";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // chkLogginError
            // 
            chkLogginError.AutoSize = true;
            chkLogginError.Location = new Point(13, 132);
            chkLogginError.Name = "chkLogginError";
            chkLogginError.Size = new Size(51, 19);
            chkLogginError.TabIndex = 5;
            chkLogginError.Text = "Error";
            chkLogginError.UseVisualStyleBackColor = true;
            // 
            // chkLogginWarning
            // 
            chkLogginWarning.AutoSize = true;
            chkLogginWarning.Location = new Point(13, 61);
            chkLogginWarning.Name = "chkLogginWarning";
            chkLogginWarning.Size = new Size(71, 19);
            chkLogginWarning.TabIndex = 4;
            chkLogginWarning.Text = "Warning";
            chkLogginWarning.UseVisualStyleBackColor = true;
            // 
            // chkLogginInformacion
            // 
            chkLogginInformacion.AutoSize = true;
            chkLogginInformacion.Location = new Point(13, 19);
            chkLogginInformacion.Name = "chkLogginInformacion";
            chkLogginInformacion.Size = new Size(91, 19);
            chkLogginInformacion.TabIndex = 3;
            chkLogginInformacion.Text = "Información";
            chkLogginInformacion.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(btnVerPuerto);
            groupBox3.Controls.Add(btnVerHost);
            groupBox3.Controls.Add(btnVerCredencialPass);
            groupBox3.Controls.Add(btnVerCredencialUsuario);
            groupBox3.Controls.Add(chkEnviarMailAlCrearUsuario);
            groupBox3.Controls.Add(panel3);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(txtPuerto);
            groupBox3.Controls.Add(txtHost);
            groupBox3.Controls.Add(txtCredencialPassword);
            groupBox3.Controls.Add(txtCredencialUsuario);
            groupBox3.Controls.Add(label1);
            groupBox3.Location = new Point(10, 205);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(445, 205);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "[ Correo Electrónico ]";
            // 
            // label9
            // 
            label9.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.Red;
            label9.Location = new Point(11, 138);
            label9.Name = "label9";
            label9.Size = new Size(428, 33);
            label9.TabIndex = 15;
            label9.Text = "IMPORTANTE: si no tiene su propio servidor de mail configurado, por favor no toque los datos precargados.";
            // 
            // btnVerPuerto
            // 
            btnVerPuerto.BackColor = Color.Gainsboro;
            btnVerPuerto.FlatAppearance.BorderSize = 0;
            btnVerPuerto.FlatStyle = FlatStyle.Flat;
            btnVerPuerto.IconChar = FontAwesome.Sharp.IconChar.Key;
            btnVerPuerto.IconColor = Color.Gray;
            btnVerPuerto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnVerPuerto.IconSize = 15;
            btnVerPuerto.Location = new Point(218, 108);
            btnVerPuerto.Name = "btnVerPuerto";
            btnVerPuerto.Size = new Size(27, 24);
            btnVerPuerto.TabIndex = 14;
            btnVerPuerto.UseVisualStyleBackColor = false;
            btnVerPuerto.MouseDown += BtnVerPuerto_MouseDown;
            btnVerPuerto.MouseUp += BtnVerPuerto_MouseUp;
            // 
            // btnVerHost
            // 
            btnVerHost.BackColor = Color.Gainsboro;
            btnVerHost.FlatAppearance.BorderSize = 0;
            btnVerHost.FlatStyle = FlatStyle.Flat;
            btnVerHost.IconChar = FontAwesome.Sharp.IconChar.Key;
            btnVerHost.IconColor = Color.Gray;
            btnVerHost.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnVerHost.IconSize = 15;
            btnVerHost.Location = new Point(407, 78);
            btnVerHost.Name = "btnVerHost";
            btnVerHost.Size = new Size(27, 24);
            btnVerHost.TabIndex = 13;
            btnVerHost.UseVisualStyleBackColor = false;
            btnVerHost.MouseDown += BtnVerHost_MouseDown;
            btnVerHost.MouseUp += BtnVerHost_MouseUp;
            // 
            // btnVerCredencialPass
            // 
            btnVerCredencialPass.BackColor = Color.Gainsboro;
            btnVerCredencialPass.FlatAppearance.BorderSize = 0;
            btnVerCredencialPass.FlatStyle = FlatStyle.Flat;
            btnVerCredencialPass.IconChar = FontAwesome.Sharp.IconChar.Key;
            btnVerCredencialPass.IconColor = Color.Gray;
            btnVerCredencialPass.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnVerCredencialPass.IconSize = 15;
            btnVerCredencialPass.Location = new Point(407, 50);
            btnVerCredencialPass.Name = "btnVerCredencialPass";
            btnVerCredencialPass.Size = new Size(27, 24);
            btnVerCredencialPass.TabIndex = 12;
            btnVerCredencialPass.UseVisualStyleBackColor = false;
            btnVerCredencialPass.MouseDown += BtnVerCredencialPass_MouseDown;
            btnVerCredencialPass.MouseUp += BtnVerCredencialPass_MouseUp;
            // 
            // btnVerCredencialUsuario
            // 
            btnVerCredencialUsuario.BackColor = Color.Gainsboro;
            btnVerCredencialUsuario.FlatAppearance.BorderSize = 0;
            btnVerCredencialUsuario.FlatStyle = FlatStyle.Flat;
            btnVerCredencialUsuario.IconChar = FontAwesome.Sharp.IconChar.Key;
            btnVerCredencialUsuario.IconColor = Color.Gray;
            btnVerCredencialUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnVerCredencialUsuario.IconSize = 15;
            btnVerCredencialUsuario.Location = new Point(407, 21);
            btnVerCredencialUsuario.Name = "btnVerCredencialUsuario";
            btnVerCredencialUsuario.Size = new Size(27, 24);
            btnVerCredencialUsuario.TabIndex = 11;
            btnVerCredencialUsuario.UseVisualStyleBackColor = false;
            btnVerCredencialUsuario.MouseDown += BtnVerCredencialUsuario_MouseDown;
            btnVerCredencialUsuario.MouseUp += BtnVerCredencialUsuario_MouseUp;
            // 
            // chkEnviarMailAlCrearUsuario
            // 
            chkEnviarMailAlCrearUsuario.AutoSize = true;
            chkEnviarMailAlCrearUsuario.Location = new Point(14, 182);
            chkEnviarMailAlCrearUsuario.Name = "chkEnviarMailAlCrearUsuario";
            chkEnviarMailAlCrearUsuario.Size = new Size(187, 19);
            chkEnviarMailAlCrearUsuario.TabIndex = 10;
            chkEnviarMailAlCrearUsuario.Text = "Enviar Mail al Crear un Usuario";
            chkEnviarMailAlCrearUsuario.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(224, 224, 224);
            panel3.Location = new Point(14, 176);
            panel3.Name = "panel3";
            panel3.Size = new Size(414, 1);
            panel3.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(93, 111);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 8;
            label5.Text = "Puerto";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(103, 82);
            label4.Name = "label4";
            label4.Size = new Size(32, 15);
            label4.TabIndex = 7;
            label4.Text = "Host";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 50);
            label3.Name = "label3";
            label3.Size = new Size(126, 15);
            label3.TabIndex = 6;
            label3.Text = "Credencial Contraseña";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 24);
            label2.Name = "label2";
            label2.Size = new Size(106, 15);
            label2.TabIndex = 5;
            label2.Text = "Credencial Usuario";
            // 
            // txtPuerto
            // 
            txtPuerto.BorderStyle = BorderStyle.FixedSingle;
            txtPuerto.Location = new Point(141, 108);
            txtPuerto.Name = "txtPuerto";
            txtPuerto.PasswordChar = '*';
            txtPuerto.Size = new Size(71, 23);
            txtPuerto.TabIndex = 4;
            // 
            // txtHost
            // 
            txtHost.BorderStyle = BorderStyle.FixedSingle;
            txtHost.Location = new Point(141, 79);
            txtHost.Name = "txtHost";
            txtHost.PasswordChar = '*';
            txtHost.Size = new Size(260, 23);
            txtHost.TabIndex = 3;
            // 
            // txtCredencialPassword
            // 
            txtCredencialPassword.BorderStyle = BorderStyle.FixedSingle;
            txtCredencialPassword.Location = new Point(141, 50);
            txtCredencialPassword.Name = "txtCredencialPassword";
            txtCredencialPassword.PasswordChar = '*';
            txtCredencialPassword.Size = new Size(260, 23);
            txtCredencialPassword.TabIndex = 2;
            // 
            // txtCredencialUsuario
            // 
            txtCredencialUsuario.BorderStyle = BorderStyle.FixedSingle;
            txtCredencialUsuario.Location = new Point(141, 21);
            txtCredencialUsuario.Name = "txtCredencialUsuario";
            txtCredencialUsuario.PasswordChar = '*';
            txtCredencialUsuario.Size = new Size(260, 23);
            txtCredencialUsuario.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 23);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(chkModuloDashBoard);
            groupBox2.Controls.Add(chkModuloCaja);
            groupBox2.Controls.Add(chkModuloPuntoVenta);
            groupBox2.Controls.Add(chkModuloFabricacion);
            groupBox2.Controls.Add(chkModuloInventario);
            groupBox2.Controls.Add(chkModuloCompra);
            groupBox2.Controls.Add(chkModuloVenta);
            groupBox2.Controls.Add(chkModuloSeguridad);
            groupBox2.Location = new Point(225, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(266, 188);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "[ Módulos ]";
            // 
            // chkModuloPuntoVenta
            // 
            chkModuloPuntoVenta.AutoSize = true;
            chkModuloPuntoVenta.Location = new Point(22, 152);
            chkModuloPuntoVenta.Name = "chkModuloPuntoVenta";
            chkModuloPuntoVenta.Size = new Size(106, 19);
            chkModuloPuntoVenta.TabIndex = 5;
            chkModuloPuntoVenta.Text = "Punto de Venta";
            chkModuloPuntoVenta.UseVisualStyleBackColor = true;
            // 
            // chkModuloFabricacion
            // 
            chkModuloFabricacion.AutoSize = true;
            chkModuloFabricacion.Location = new Point(22, 127);
            chkModuloFabricacion.Name = "chkModuloFabricacion";
            chkModuloFabricacion.Size = new Size(87, 19);
            chkModuloFabricacion.TabIndex = 4;
            chkModuloFabricacion.Text = "Fabricación";
            chkModuloFabricacion.UseVisualStyleBackColor = true;
            // 
            // chkModuloInventario
            // 
            chkModuloInventario.AutoSize = true;
            chkModuloInventario.Location = new Point(22, 102);
            chkModuloInventario.Name = "chkModuloInventario";
            chkModuloInventario.Size = new Size(79, 19);
            chkModuloInventario.TabIndex = 3;
            chkModuloInventario.Text = "Inventario";
            chkModuloInventario.UseVisualStyleBackColor = true;
            // 
            // chkModuloCompra
            // 
            chkModuloCompra.AutoSize = true;
            chkModuloCompra.Location = new Point(22, 77);
            chkModuloCompra.Name = "chkModuloCompra";
            chkModuloCompra.Size = new Size(69, 19);
            chkModuloCompra.TabIndex = 2;
            chkModuloCompra.Text = "Compra";
            chkModuloCompra.UseVisualStyleBackColor = true;
            // 
            // chkModuloVenta
            // 
            chkModuloVenta.AutoSize = true;
            chkModuloVenta.Location = new Point(22, 52);
            chkModuloVenta.Name = "chkModuloVenta";
            chkModuloVenta.Size = new Size(55, 19);
            chkModuloVenta.TabIndex = 1;
            chkModuloVenta.Text = "Venta";
            chkModuloVenta.UseVisualStyleBackColor = true;
            // 
            // chkModuloSeguridad
            // 
            chkModuloSeguridad.AutoSize = true;
            chkModuloSeguridad.Enabled = false;
            chkModuloSeguridad.Location = new Point(22, 26);
            chkModuloSeguridad.Name = "chkModuloSeguridad";
            chkModuloSeguridad.Size = new Size(79, 19);
            chkModuloSeguridad.TabIndex = 0;
            chkModuloSeguridad.Text = "Seguridad";
            chkModuloSeguridad.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(imgLoginAvatar);
            groupBox1.Controls.Add(rdbLoginAvatar);
            groupBox1.Controls.Add(rdbLoginNormal);
            groupBox1.Controls.Add(imgLoginNormal);
            groupBox1.Controls.Add(panel1);
            groupBox1.Controls.Add(panel2);
            groupBox1.Location = new Point(11, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(202, 188);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "[ Tipo de Login ]";
            // 
            // imgLoginAvatar
            // 
            imgLoginAvatar.BorderStyle = BorderStyle.FixedSingle;
            imgLoginAvatar.Image = Properties.Resources.LoginConAvatar;
            imgLoginAvatar.Location = new Point(6, 104);
            imgLoginAvatar.Name = "imgLoginAvatar";
            imgLoginAvatar.Size = new Size(110, 70);
            imgLoginAvatar.SizeMode = PictureBoxSizeMode.StretchImage;
            imgLoginAvatar.TabIndex = 1;
            imgLoginAvatar.TabStop = false;
            // 
            // rdbLoginAvatar
            // 
            rdbLoginAvatar.AutoSize = true;
            rdbLoginAvatar.Location = new Point(129, 131);
            rdbLoginAvatar.Name = "rdbLoginAvatar";
            rdbLoginAvatar.Size = new Size(59, 19);
            rdbLoginAvatar.TabIndex = 3;
            rdbLoginAvatar.Text = "Avatar";
            rdbLoginAvatar.UseVisualStyleBackColor = true;
            // 
            // rdbLoginNormal
            // 
            rdbLoginNormal.AutoSize = true;
            rdbLoginNormal.Checked = true;
            rdbLoginNormal.ImageAlign = ContentAlignment.MiddleLeft;
            rdbLoginNormal.Location = new Point(129, 51);
            rdbLoginNormal.Name = "rdbLoginNormal";
            rdbLoginNormal.Size = new Size(65, 19);
            rdbLoginNormal.TabIndex = 2;
            rdbLoginNormal.TabStop = true;
            rdbLoginNormal.Text = "Normal";
            rdbLoginNormal.UseVisualStyleBackColor = true;
            // 
            // imgLoginNormal
            // 
            imgLoginNormal.BorderStyle = BorderStyle.FixedSingle;
            imgLoginNormal.Image = Properties.Resources.LoginNormal;
            imgLoginNormal.Location = new Point(6, 22);
            imgLoginNormal.Name = "imgLoginNormal";
            imgLoginNormal.Size = new Size(110, 70);
            imgLoginNormal.SizeMode = PictureBoxSizeMode.StretchImage;
            imgLoginNormal.TabIndex = 0;
            imgLoginNormal.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(224, 224, 224);
            panel1.Location = new Point(10, 26);
            panel1.Name = "panel1";
            panel1.Size = new Size(109, 69);
            panel1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(224, 224, 224);
            panel2.Location = new Point(10, 108);
            panel2.Name = "panel2";
            panel2.Size = new Size(109, 69);
            panel2.TabIndex = 5;
            // 
            // chkModuloDashBoard
            // 
            chkModuloDashBoard.AutoSize = true;
            chkModuloDashBoard.Location = new Point(161, 51);
            chkModuloDashBoard.Name = "chkModuloDashBoard";
            chkModuloDashBoard.Size = new Size(83, 19);
            chkModuloDashBoard.TabIndex = 7;
            chkModuloDashBoard.Text = "DashBoard";
            chkModuloDashBoard.UseVisualStyleBackColor = true;
            // 
            // chkModuloCaja
            // 
            chkModuloCaja.AutoSize = true;
            chkModuloCaja.Location = new Point(161, 26);
            chkModuloCaja.Name = "chkModuloCaja";
            chkModuloCaja.Size = new Size(49, 19);
            chkModuloCaja.TabIndex = 6;
            chkModuloCaja.Text = "Caja";
            chkModuloCaja.UseVisualStyleBackColor = true;
            // 
            // _00023_AjusteSeguridad
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(tabControl1);
            MaximumSize = new Size(800, 600);
            MinimumSize = new Size(800, 600);
            Name = "_00023_AjusteSeguridad";
            Controls.SetChildIndex(tabControl1, 0);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imgLoginAvatar).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgLoginNormal).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private GroupBox groupBox1;
        private RadioButton rdbLoginAvatar;
        private RadioButton rdbLoginNormal;
        private PictureBox imgLoginAvatar;
        private PictureBox imgLoginNormal;
        private Panel panel1;
        private Panel panel2;
        private GroupBox groupBox2;
        private CheckBox chkModuloPuntoVenta;
        private CheckBox chkModuloFabricacion;
        private CheckBox chkModuloInventario;
        private CheckBox chkModuloCompra;
        private CheckBox chkModuloVenta;
        private CheckBox chkModuloSeguridad;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private CheckBox chkLogginError;
        private CheckBox chkLogginWarning;
        private CheckBox chkLogginInformacion;
        private Label label2;
        private TextBox txtPuerto;
        private TextBox txtHost;
        private TextBox txtCredencialPassword;
        private TextBox txtCredencialUsuario;
        private Label label1;
        private Panel panel3;
        private Label label5;
        private Label label4;
        private Label label3;
        private CheckBox chkEnviarMailAlCrearUsuario;
        private Label label8;
        private Label label7;
        private Label label6;
        private FontAwesome.Sharp.IconButton btnVerPuerto;
        private FontAwesome.Sharp.IconButton btnVerHost;
        private FontAwesome.Sharp.IconButton btnVerCredencialPass;
        private FontAwesome.Sharp.IconButton btnVerCredencialUsuario;
        private Label label9;
        private CheckBox chkModuloDashBoard;
        private CheckBox chkModuloCaja;
    }
}