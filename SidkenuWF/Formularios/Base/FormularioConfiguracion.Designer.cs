namespace SidkenuWF.Formularios.Base
{
    partial class FormularioConfiguracion
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
            btnEjecutar = new FontAwesome.Sharp.IconButton();
            pnlTitulo = new Panel();
            pnlLinea = new Panel();
            imgLogo = new FontAwesome.Sharp.IconPictureBox();
            lblTitulo = new Label();
            btnSalir = new FontAwesome.Sharp.IconButton();
            pnlBotonera.SuspendLayout();
            pnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgLogo).BeginInit();
            SuspendLayout();
            // 
            // pnlBotonera
            // 
            pnlBotonera.BackColor = Color.FromArgb(48, 66, 80);
            pnlBotonera.Controls.Add(btnEjecutar);
            pnlBotonera.Dock = DockStyle.Bottom;
            pnlBotonera.Location = new Point(0, 410);
            pnlBotonera.Name = "pnlBotonera";
            pnlBotonera.Size = new Size(761, 40);
            pnlBotonera.TabIndex = 2;
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
            pnlTitulo.Controls.Add(btnSalir);
            pnlTitulo.Dock = DockStyle.Top;
            pnlTitulo.Location = new Point(0, 0);
            pnlTitulo.Name = "pnlTitulo";
            pnlTitulo.Size = new Size(761, 57);
            pnlTitulo.TabIndex = 3;
            // 
            // pnlLinea
            // 
            pnlLinea.BackColor = Color.FromArgb(192, 64, 0);
            pnlLinea.Dock = DockStyle.Bottom;
            pnlLinea.Location = new Point(0, 56);
            pnlLinea.Name = "pnlLinea";
            pnlLinea.Size = new Size(761, 1);
            pnlLinea.TabIndex = 5;
            // 
            // imgLogo
            // 
            imgLogo.BackColor = Color.FromArgb(48, 66, 80);
            imgLogo.ForeColor = Color.WhiteSmoke;
            imgLogo.IconChar = FontAwesome.Sharp.IconChar.None;
            imgLogo.IconColor = Color.WhiteSmoke;
            imgLogo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            imgLogo.IconSize = 35;
            imgLogo.Location = new Point(14, 10);
            imgLogo.Name = "imgLogo";
            imgLogo.Size = new Size(35, 35);
            imgLogo.SizeMode = PictureBoxSizeMode.CenterImage;
            imgLogo.TabIndex = 4;
            imgLogo.TabStop = false;
            // 
            // lblTitulo
            // 
            lblTitulo.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblTitulo.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.ForeColor = Color.WhiteSmoke;
            lblTitulo.Location = new Point(55, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(645, 41);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Titulo";
            lblTitulo.TextAlign = ContentAlignment.MiddleLeft;
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
            btnSalir.IconSize = 25;
            btnSalir.Location = new Point(707, 5);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(49, 49);
            btnSalir.TabIndex = 0;
            btnSalir.Text = "Salir";
            btnSalir.TextImageRelation = TextImageRelation.ImageAboveText;
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += BtnSalir_Click;
            // 
            // FormularioSetting
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(761, 450);
            Controls.Add(pnlTitulo);
            Controls.Add(pnlBotonera);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormularioSetting";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Sidkenu";
            pnlBotonera.ResumeLayout(false);
            pnlTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)imgLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlBotonera;
        private FontAwesome.Sharp.IconButton btnEjecutar;
        private Panel pnlTitulo;
        private Panel pnlLinea;
        private FontAwesome.Sharp.IconPictureBox imgLogo;
        private Label lblTitulo;
        private FontAwesome.Sharp.IconButton btnSalir;
    }
}