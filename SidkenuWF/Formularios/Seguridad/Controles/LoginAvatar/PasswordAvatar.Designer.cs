namespace SidkenuWF.Formularios.Base.Controles.LoginAvatar
{
    partial class PasswordAvatar
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
            btnIngresar = new Button();
            btnVerPassword = new FontAwesome.Sharp.IconButton();
            txtPassword = new TextBox();
            label2 = new Label();
            label1 = new Label();
            pnlLinea = new Panel();
            btnCancelar = new Button();
            linkOlvidastePassword = new LinkLabel();
            SuspendLayout();
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.Green;
            btnIngresar.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            btnIngresar.FlatStyle = FlatStyle.Flat;
            btnIngresar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnIngresar.ForeColor = Color.WhiteSmoke;
            btnIngresar.Location = new Point(69, 147);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(115, 35);
            btnIngresar.TabIndex = 11;
            btnIngresar.Text = "Ingresar";
            btnIngresar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += BtnIngresar_Click;
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
            btnVerPassword.Location = new Point(287, 95);
            btnVerPassword.Name = "btnVerPassword";
            btnVerPassword.Size = new Size(32, 29);
            btnVerPassword.TabIndex = 10;
            btnVerPassword.UseVisualStyleBackColor = false;
            btnVerPassword.MouseDown += BtnVerPassword_MouseDown;
            btnVerPassword.MouseUp += BtnVerPassword_MouseUp;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(69, 95);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(212, 29);
            txtPassword.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(69, 71);
            label2.Name = "label2";
            label2.Size = new Size(89, 21);
            label2.TabIndex = 8;
            label2.Text = "Contraseña";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(13, 11);
            label1.Name = "label1";
            label1.Size = new Size(212, 25);
            label1.TabIndex = 13;
            label1.Text = "Ingrese una Contraseña";
            // 
            // pnlLinea
            // 
            pnlLinea.BackColor = Color.FromArgb(192, 64, 0);
            pnlLinea.Location = new Point(10, 40);
            pnlLinea.Name = "pnlLinea";
            pnlLinea.Size = new Size(364, 1);
            pnlLinea.TabIndex = 12;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Maroon;
            btnCancelar.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.ForeColor = Color.WhiteSmoke;
            btnCancelar.Location = new Point(204, 147);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(115, 35);
            btnCancelar.TabIndex = 14;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += BtnCancelar_Click;
            // 
            // linkOlvidastePassword
            // 
            linkOlvidastePassword.AutoSize = true;
            linkOlvidastePassword.LinkColor = Color.FromArgb(224, 224, 224);
            linkOlvidastePassword.Location = new Point(118, 218);
            linkOlvidastePassword.Name = "linkOlvidastePassword";
            linkOlvidastePassword.Size = new Size(147, 15);
            linkOlvidastePassword.TabIndex = 15;
            linkOlvidastePassword.TabStop = true;
            linkOlvidastePassword.Text = "¿ Olvidaste la Contraseña ?";
            linkOlvidastePassword.LinkClicked += LinkOlvidastePassword_LinkClicked;
            // 
            // PasswordAvatar
            // 
            AcceptButton = btnIngresar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            CancelButton = btnCancelar;
            ClientSize = new Size(384, 261);
            Controls.Add(linkOlvidastePassword);
            Controls.Add(btnCancelar);
            Controls.Add(label1);
            Controls.Add(pnlLinea);
            Controls.Add(btnIngresar);
            Controls.Add(btnVerPassword);
            Controls.Add(txtPassword);
            Controls.Add(label2);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MaximumSize = new Size(400, 300);
            MinimizeBox = false;
            MinimumSize = new Size(400, 300);
            Name = "PasswordAvatar";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Contraseña";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnIngresar;
        private FontAwesome.Sharp.IconButton btnVerPassword;
        private TextBox txtPassword;
        private Label label2;
        private Label label1;
        private Panel pnlLinea;
        private Button btnCancelar;
        private LinkLabel linkOlvidastePassword;
    }
}