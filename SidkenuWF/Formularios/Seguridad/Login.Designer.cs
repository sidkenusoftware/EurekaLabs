namespace SidkenuWF.Formularios.Seguridad
{
    partial class Login
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
            pnlDerecho = new Panel();
            pnlLogin = new Panel();
            linkOlvidastePassword = new LinkLabel();
            btnIngresar = new Button();
            btnCancelar = new Button();
            btnVerPassword = new FontAwesome.Sharp.IconButton();
            txtPassword = new TextBox();
            label2 = new Label();
            txtUsuario = new TextBox();
            label1 = new Label();
            lblLogin = new Label();
            pnlDerecho.SuspendLayout();
            pnlLogin.SuspendLayout();
            SuspendLayout();
            // 
            // pnlDerecho
            // 
            pnlDerecho.BackColor = Color.FromArgb(64, 64, 64);
            pnlDerecho.Controls.Add(pnlLogin);
            pnlDerecho.Dock = DockStyle.Right;
            pnlDerecho.Location = new Point(486, 0);
            pnlDerecho.Name = "pnlDerecho";
            pnlDerecho.Size = new Size(314, 450);
            pnlDerecho.TabIndex = 0;
            // 
            // pnlLogin
            // 
            pnlLogin.Anchor = AnchorStyles.None;
            pnlLogin.Controls.Add(linkOlvidastePassword);
            pnlLogin.Controls.Add(btnIngresar);
            pnlLogin.Controls.Add(btnCancelar);
            pnlLogin.Controls.Add(btnVerPassword);
            pnlLogin.Controls.Add(txtPassword);
            pnlLogin.Controls.Add(label2);
            pnlLogin.Controls.Add(txtUsuario);
            pnlLogin.Controls.Add(label1);
            pnlLogin.Controls.Add(lblLogin);
            pnlLogin.Location = new Point(14, 49);
            pnlLogin.Name = "pnlLogin";
            pnlLogin.Size = new Size(288, 359);
            pnlLogin.TabIndex = 0;
            // 
            // linkOlvidastePassword
            // 
            linkOlvidastePassword.AutoSize = true;
            linkOlvidastePassword.LinkColor = Color.FromArgb(224, 224, 224);
            linkOlvidastePassword.Location = new Point(69, 335);
            linkOlvidastePassword.Name = "linkOlvidastePassword";
            linkOlvidastePassword.Size = new Size(147, 15);
            linkOlvidastePassword.TabIndex = 16;
            linkOlvidastePassword.TabStop = true;
            linkOlvidastePassword.Text = "¿ Olvidaste la Contraseña ?";
            linkOlvidastePassword.LinkClicked += LinkOlvidastePassword_LinkClicked;
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.Green;
            btnIngresar.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            btnIngresar.FlatStyle = FlatStyle.Flat;
            btnIngresar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnIngresar.ForeColor = Color.WhiteSmoke;
            btnIngresar.Location = new Point(17, 264);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(115, 35);
            btnIngresar.TabIndex = 7;
            btnIngresar.Text = "Ingresar";
            btnIngresar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += BtnIngresar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Maroon;
            btnCancelar.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.ForeColor = Color.WhiteSmoke;
            btnCancelar.Location = new Point(152, 264);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(115, 35);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += BtnCancelar_Click;
            // 
            // btnVerPassword
            // 
            btnVerPassword.BackColor = Color.Gainsboro;
            btnVerPassword.FlatAppearance.BorderSize = 0;
            btnVerPassword.FlatStyle = FlatStyle.Flat;
            btnVerPassword.IconChar = FontAwesome.Sharp.IconChar.Key;
            btnVerPassword.IconColor = Color.Gray;
            btnVerPassword.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnVerPassword.IconSize = 20;
            btnVerPassword.Location = new Point(235, 182);
            btnVerPassword.Name = "btnVerPassword";
            btnVerPassword.Size = new Size(32, 29);
            btnVerPassword.TabIndex = 5;
            btnVerPassword.UseVisualStyleBackColor = false;
            btnVerPassword.Click += BtnVerPassword_Click;
            btnVerPassword.MouseDown += BtnVerPassword_MouseDown;
            btnVerPassword.MouseUp += BtnVerPassword_MouseUp;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(17, 182);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(212, 29);
            txtPassword.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(17, 158);
            label2.Name = "label2";
            label2.Size = new Size(89, 21);
            label2.TabIndex = 3;
            label2.Text = "Contraseña";
            // 
            // txtUsuario
            // 
            txtUsuario.BorderStyle = BorderStyle.FixedSingle;
            txtUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsuario.Location = new Point(17, 111);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(250, 29);
            txtUsuario.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(17, 87);
            label1.Name = "label1";
            label1.Size = new Size(64, 21);
            label1.TabIndex = 1;
            label1.Text = "Usuario";
            // 
            // lblLogin
            // 
            lblLogin.Dock = DockStyle.Top;
            lblLogin.Font = new Font("Arial", 27.75F, FontStyle.Italic, GraphicsUnit.Point);
            lblLogin.ForeColor = Color.White;
            lblLogin.Location = new Point(0, 0);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(288, 51);
            lblLogin.TabIndex = 0;
            lblLogin.Text = "Login";
            // 
            // Login
            // 
            AcceptButton = btnIngresar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancelar;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlDerecho);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            WindowState = FormWindowState.Maximized;
            pnlDerecho.ResumeLayout(false);
            pnlLogin.ResumeLayout(false);
            pnlLogin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlDerecho;
        private Panel pnlLogin;
        private Label lblLogin;
        private Button btnIngresar;
        private Button btnCancelar;
        private FontAwesome.Sharp.IconButton btnVerPassword;
        private TextBox txtPassword;
        private Label label2;
        private TextBox txtUsuario;
        private Label label1;
        private LinkLabel linkOlvidastePassword;
    }
}