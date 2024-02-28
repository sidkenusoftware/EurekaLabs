namespace SidkenuWF.Formularios.Seguridad.Controles.LoginAvatar
{
    partial class OlvidastePassword
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
            imgkey = new FontAwesome.Sharp.IconPictureBox();
            label1 = new Label();
            label2 = new Label();
            lblMensaje = new Label();
            btnCancelar = new Button();
            btnIngresar = new Button();
            ((System.ComponentModel.ISupportInitialize)imgkey).BeginInit();
            SuspendLayout();
            // 
            // imgkey
            // 
            imgkey.BackColor = Color.FromArgb(64, 64, 64);
            imgkey.ForeColor = Color.Silver;
            imgkey.IconChar = FontAwesome.Sharp.IconChar.RoadLock;
            imgkey.IconColor = Color.Silver;
            imgkey.IconFont = FontAwesome.Sharp.IconFont.Auto;
            imgkey.IconSize = 85;
            imgkey.Location = new Point(169, 24);
            imgkey.Name = "imgkey";
            imgkey.Size = new Size(96, 85);
            imgkey.SizeMode = PictureBoxSizeMode.StretchImage;
            imgkey.TabIndex = 0;
            imgkey.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(104, 112);
            label1.Name = "label1";
            label1.Size = new Size(216, 32);
            label1.TabIndex = 1;
            label1.Text = "Crear nueva clave";
            // 
            // label2
            // 
            label2.BackColor = Color.FromArgb(64, 64, 0);
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(255, 128, 0);
            label2.Location = new Point(46, 216);
            label2.Name = "label2";
            label2.Size = new Size(335, 39);
            label2.TabIndex = 2;
            label2.Text = "Necesitarás acceso a tu correo  electrónico";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMensaje
            // 
            lblMensaje.ForeColor = Color.White;
            lblMensaje.Location = new Point(30, 147);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(369, 63);
            lblMensaje.TabIndex = 3;
            lblMensaje.Text = "Para estar seguro que efectivamente sos vos quien está solicitando una nueva clave, vamos a enviarte a la cuenta ... que ingresaste cuando te registraste en el sistema.\r\n";
            lblMensaje.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Maroon;
            btnCancelar.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.ForeColor = Color.WhiteSmoke;
            btnCancelar.Location = new Point(218, 277);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(115, 35);
            btnCancelar.TabIndex = 16;
            btnCancelar.Text = "Volver";
            btnCancelar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += BtnCancelar_Click;
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.Green;
            btnIngresar.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            btnIngresar.FlatStyle = FlatStyle.Flat;
            btnIngresar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnIngresar.ForeColor = Color.WhiteSmoke;
            btnIngresar.Location = new Point(83, 277);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(115, 35);
            btnIngresar.TabIndex = 15;
            btnIngresar.Text = "Enviar";
            btnIngresar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += BtnIngresar_Click;
            // 
            // OlvidastePassword
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(432, 334);
            Controls.Add(btnCancelar);
            Controls.Add(btnIngresar);
            Controls.Add(lblMensaje);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(imgkey);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MaximumSize = new Size(448, 373);
            MinimizeBox = false;
            MinimumSize = new Size(448, 373);
            Name = "OlvidastePassword";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Restaurar Contraseña";
            ((System.ComponentModel.ISupportInitialize)imgkey).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconPictureBox imgkey;
        private Label label1;
        private Label label2;
        private Label lblMensaje;
        private Button btnCancelar;
        private Button btnIngresar;
    }
}