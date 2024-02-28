namespace SidkenuWF.Formularios.Seguridad
{
    partial class _00019_CambiarPassword
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
            pnlBotonera = new Panel();
            btnSalir = new FontAwesome.Sharp.IconButton();
            btnEjecutar = new FontAwesome.Sharp.IconButton();
            pnlTitulo = new Panel();
            pnlLinea = new Panel();
            imgLogo = new FontAwesome.Sharp.IconPictureBox();
            lblTitulo = new Label();
            label1 = new Label();
            txtPasswordActual = new TextBox();
            txtPaswordNueva = new TextBox();
            label2 = new Label();
            txtRepetirPassword = new TextBox();
            lblRepetir = new Label();
            btnPasswordActual = new FontAwesome.Sharp.IconButton();
            btnPasswordNueva = new FontAwesome.Sharp.IconButton();
            btnRepetirPassword = new FontAwesome.Sharp.IconButton();
            pnlBotonera.SuspendLayout();
            pnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgLogo).BeginInit();
            SuspendLayout();
            // 
            // pnlBotonera
            // 
            pnlBotonera.BackColor = Color.FromArgb(48, 66, 80);
            pnlBotonera.Controls.Add(btnSalir);
            pnlBotonera.Controls.Add(btnEjecutar);
            pnlBotonera.Dock = DockStyle.Bottom;
            pnlBotonera.Location = new Point(0, 319);
            pnlBotonera.Name = "pnlBotonera";
            pnlBotonera.Size = new Size(307, 40);
            pnlBotonera.TabIndex = 2;
            // 
            // btnSalir
            // 
            btnSalir.Anchor = AnchorStyles.Right;
            btnSalir.BackColor = Color.FromArgb(54, 74, 90);
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.ForeColor = Color.WhiteSmoke;
            btnSalir.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            btnSalir.IconColor = Color.WhiteSmoke;
            btnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSalir.IconSize = 22;
            btnSalir.Location = new Point(231, 6);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(66, 28);
            btnSalir.TabIndex = 3;
            btnSalir.Text = "Salir";
            btnSalir.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += BtnSalir_Click;
            // 
            // btnEjecutar
            // 
            btnEjecutar.BackColor = Color.FromArgb(54, 74, 90);
            btnEjecutar.FlatAppearance.BorderColor = Color.WhiteSmoke;
            btnEjecutar.FlatAppearance.BorderSize = 0;
            btnEjecutar.FlatStyle = FlatStyle.Flat;
            btnEjecutar.ForeColor = Color.WhiteSmoke;
            btnEjecutar.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            btnEjecutar.IconColor = Color.WhiteSmoke;
            btnEjecutar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEjecutar.IconSize = 22;
            btnEjecutar.Location = new Point(13, 6);
            btnEjecutar.Name = "btnEjecutar";
            btnEjecutar.Size = new Size(81, 28);
            btnEjecutar.TabIndex = 2;
            btnEjecutar.Text = "Guardar";
            btnEjecutar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEjecutar.UseVisualStyleBackColor = false;
            btnEjecutar.Click += BtnEjecutar_Click;
            // 
            // pnlTitulo
            // 
            pnlTitulo.BackColor = Color.FromArgb(48, 66, 80);
            pnlTitulo.Controls.Add(pnlLinea);
            pnlTitulo.Controls.Add(imgLogo);
            pnlTitulo.Controls.Add(lblTitulo);
            pnlTitulo.Dock = DockStyle.Top;
            pnlTitulo.Location = new Point(0, 0);
            pnlTitulo.Name = "pnlTitulo";
            pnlTitulo.Size = new Size(307, 57);
            pnlTitulo.TabIndex = 3;
            // 
            // pnlLinea
            // 
            pnlLinea.BackColor = Color.FromArgb(192, 64, 0);
            pnlLinea.Dock = DockStyle.Bottom;
            pnlLinea.Location = new Point(0, 56);
            pnlLinea.Name = "pnlLinea";
            pnlLinea.Size = new Size(307, 1);
            pnlLinea.TabIndex = 5;
            // 
            // imgLogo
            // 
            imgLogo.BackColor = Color.FromArgb(48, 66, 80);
            imgLogo.ForeColor = Color.WhiteSmoke;
            imgLogo.IconChar = FontAwesome.Sharp.IconChar.Key;
            imgLogo.IconColor = Color.WhiteSmoke;
            imgLogo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            imgLogo.IconSize = 35;
            imgLogo.Location = new Point(15, 12);
            imgLogo.Name = "imgLogo";
            imgLogo.Size = new Size(35, 35);
            imgLogo.SizeMode = PictureBoxSizeMode.CenterImage;
            imgLogo.TabIndex = 4;
            imgLogo.TabStop = false;
            // 
            // lblTitulo
            // 
            lblTitulo.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblTitulo.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.ForeColor = Color.WhiteSmoke;
            lblTitulo.Location = new Point(56, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(239, 41);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Cambiar Contraseña";
            lblTitulo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(17, 80);
            label1.Name = "label1";
            label1.Size = new Size(136, 21);
            label1.TabIndex = 4;
            label1.Text = "Contraseña Actual";
            // 
            // txtPasswordActual
            // 
            txtPasswordActual.BorderStyle = BorderStyle.FixedSingle;
            txtPasswordActual.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPasswordActual.Location = new Point(14, 106);
            txtPasswordActual.Name = "txtPasswordActual";
            txtPasswordActual.PasswordChar = '*';
            txtPasswordActual.Size = new Size(243, 29);
            txtPasswordActual.TabIndex = 5;
            // 
            // txtPaswordNueva
            // 
            txtPaswordNueva.BorderStyle = BorderStyle.FixedSingle;
            txtPaswordNueva.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPaswordNueva.Location = new Point(14, 177);
            txtPaswordNueva.Name = "txtPaswordNueva";
            txtPaswordNueva.PasswordChar = '*';
            txtPaswordNueva.Size = new Size(243, 29);
            txtPaswordNueva.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(18, 152);
            label2.Name = "label2";
            label2.Size = new Size(138, 21);
            label2.TabIndex = 6;
            label2.Text = "Contraseña Nueva";
            // 
            // txtRepetirPassword
            // 
            txtRepetirPassword.BorderStyle = BorderStyle.FixedSingle;
            txtRepetirPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtRepetirPassword.Location = new Point(14, 251);
            txtRepetirPassword.Name = "txtRepetirPassword";
            txtRepetirPassword.PasswordChar = '*';
            txtRepetirPassword.Size = new Size(243, 29);
            txtRepetirPassword.TabIndex = 9;
            // 
            // lblRepetir
            // 
            lblRepetir.AutoSize = true;
            lblRepetir.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblRepetir.Location = new Point(17, 225);
            lblRepetir.Name = "lblRepetir";
            lblRepetir.Size = new Size(143, 21);
            lblRepetir.TabIndex = 8;
            lblRepetir.Text = "Repetir Contraseña";
            // 
            // btnPasswordActual
            // 
            btnPasswordActual.FlatAppearance.BorderColor = Color.Gray;
            btnPasswordActual.FlatStyle = FlatStyle.Flat;
            btnPasswordActual.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            btnPasswordActual.IconColor = Color.Gray;
            btnPasswordActual.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnPasswordActual.IconSize = 25;
            btnPasswordActual.Location = new Point(262, 106);
            btnPasswordActual.Name = "btnPasswordActual";
            btnPasswordActual.Size = new Size(35, 29);
            btnPasswordActual.TabIndex = 10;
            btnPasswordActual.UseVisualStyleBackColor = true;
            btnPasswordActual.MouseDown += BtnPasswordActual_MouseDown;
            btnPasswordActual.MouseUp += BtnPasswordActual_MouseUp;
            // 
            // btnPasswordNueva
            // 
            btnPasswordNueva.FlatAppearance.BorderColor = Color.Gray;
            btnPasswordNueva.FlatStyle = FlatStyle.Flat;
            btnPasswordNueva.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            btnPasswordNueva.IconColor = Color.Gray;
            btnPasswordNueva.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnPasswordNueva.IconSize = 25;
            btnPasswordNueva.Location = new Point(262, 177);
            btnPasswordNueva.Name = "btnPasswordNueva";
            btnPasswordNueva.Size = new Size(35, 29);
            btnPasswordNueva.TabIndex = 11;
            btnPasswordNueva.UseVisualStyleBackColor = true;
            btnPasswordNueva.MouseDown += BtnPasswordNueva_MouseDown;
            btnPasswordNueva.MouseUp += BtnPasswordNueva_MouseUp;
            // 
            // btnRepetirPassword
            // 
            btnRepetirPassword.FlatAppearance.BorderColor = Color.Gray;
            btnRepetirPassword.FlatStyle = FlatStyle.Flat;
            btnRepetirPassword.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            btnRepetirPassword.IconColor = Color.Gray;
            btnRepetirPassword.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRepetirPassword.IconSize = 25;
            btnRepetirPassword.Location = new Point(262, 251);
            btnRepetirPassword.Name = "btnRepetirPassword";
            btnRepetirPassword.Size = new Size(35, 29);
            btnRepetirPassword.TabIndex = 12;
            btnRepetirPassword.UseVisualStyleBackColor = true;
            btnRepetirPassword.MouseDown += BtnRepetirPassword_MouseDown;
            btnRepetirPassword.MouseUp += BtnRepetirPassword_MouseUp;
            // 
            // _99901_CambiarPassword
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(307, 359);
            ControlBox = false;
            Controls.Add(btnRepetirPassword);
            Controls.Add(btnPasswordNueva);
            Controls.Add(btnPasswordActual);
            Controls.Add(txtRepetirPassword);
            Controls.Add(lblRepetir);
            Controls.Add(txtPaswordNueva);
            Controls.Add(label2);
            Controls.Add(txtPasswordActual);
            Controls.Add(label1);
            Controls.Add(pnlTitulo);
            Controls.Add(pnlBotonera);
            Name = "_00019_CambiarPassword";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Cambiar Contraseña";
            pnlBotonera.ResumeLayout(false);
            pnlTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)imgLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlBotonera;
        private FontAwesome.Sharp.IconButton btnEjecutar;
        private FontAwesome.Sharp.IconButton btnSalir;
        private Panel pnlTitulo;
        private Panel pnlLinea;
        private FontAwesome.Sharp.IconPictureBox imgLogo;
        private Label lblTitulo;
        private Label label1;
        private TextBox txtPasswordActual;
        private TextBox txtPaswordNueva;
        private Label label2;
        private TextBox txtRepetirPassword;
        private Label lblRepetir;
        private FontAwesome.Sharp.IconButton btnPasswordActual;
        private FontAwesome.Sharp.IconButton btnPasswordNueva;
        private FontAwesome.Sharp.IconButton btnRepetirPassword;
    }
}