namespace SidkenuWF.Formularios.Base.Controles.Foto
{
    partial class fCapturarImagenWebCam
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
            pnlSeparadorInferior = new Panel();
            pnlBotonera = new Panel();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            lblDispositivo = new Label();
            cmbDispositivo = new ComboBox();
            panel1 = new Panel();
            btnCerrar = new FontAwesome.Sharp.IconButton();
            lblTitulo = new Label();
            panel2 = new Panel();
            imgImagenWebCam = new PictureBox();
            pnlBotonera.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgImagenWebCam).BeginInit();
            SuspendLayout();
            // 
            // pnlSeparadorInferior
            // 
            pnlSeparadorInferior.BackColor = Color.Gray;
            pnlSeparadorInferior.Dock = DockStyle.Bottom;
            pnlSeparadorInferior.Location = new Point(0, 393);
            pnlSeparadorInferior.Name = "pnlSeparadorInferior";
            pnlSeparadorInferior.Size = new Size(450, 2);
            pnlSeparadorInferior.TabIndex = 5;
            // 
            // pnlBotonera
            // 
            pnlBotonera.BackColor = Color.Gray;
            pnlBotonera.Controls.Add(iconButton1);
            pnlBotonera.Controls.Add(lblDispositivo);
            pnlBotonera.Controls.Add(cmbDispositivo);
            pnlBotonera.Dock = DockStyle.Bottom;
            pnlBotonera.Location = new Point(0, 395);
            pnlBotonera.Name = "pnlBotonera";
            pnlBotonera.Size = new Size(450, 55);
            pnlBotonera.TabIndex = 4;
            // 
            // iconButton1
            // 
            iconButton1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            iconButton1.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            iconButton1.FlatAppearance.MouseDownBackColor = Color.Gray;
            iconButton1.FlatAppearance.MouseOverBackColor = Color.Silver;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.ForeColor = Color.WhiteSmoke;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.Camera;
            iconButton1.IconColor = Color.WhiteSmoke;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 30;
            iconButton1.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton1.Location = new Point(328, 7);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(110, 40);
            iconButton1.TabIndex = 12;
            iconButton1.Text = "Capturar";
            iconButton1.TextAlign = ContentAlignment.MiddleRight;
            iconButton1.UseVisualStyleBackColor = true;
            iconButton1.Click += btnCapturar_Click;
            // 
            // lblDispositivo
            // 
            lblDispositivo.AutoSize = true;
            lblDispositivo.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblDispositivo.ForeColor = Color.WhiteSmoke;
            lblDispositivo.Location = new Point(10, 3);
            lblDispositivo.Name = "lblDispositivo";
            lblDispositivo.Size = new Size(99, 17);
            lblDispositivo.TabIndex = 10;
            lblDispositivo.Text = "Ingesos Brutos";
            // 
            // cmbDispositivo
            // 
            cmbDispositivo.BackColor = Color.WhiteSmoke;
            cmbDispositivo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDispositivo.FormattingEnabled = true;
            cmbDispositivo.Location = new Point(7, 24);
            cmbDispositivo.Name = "cmbDispositivo";
            cmbDispositivo.Size = new Size(300, 23);
            cmbDispositivo.TabIndex = 11;
            cmbDispositivo.SelectionChangeCommitted += cmbDispositivo_SelectionChangeCommitted;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gray;
            panel1.Controls.Add(btnCerrar);
            panel1.Controls.Add(lblTitulo);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(450, 50);
            panel1.TabIndex = 6;
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            btnCerrar.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            btnCerrar.FlatAppearance.MouseDownBackColor = Color.Gray;
            btnCerrar.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.ForeColor = Color.WhiteSmoke;
            btnCerrar.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            btnCerrar.IconColor = Color.WhiteSmoke;
            btnCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCerrar.IconSize = 30;
            btnCerrar.Location = new Point(401, 5);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(44, 40);
            btnCerrar.TabIndex = 3;
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.ForeColor = Color.WhiteSmoke;
            lblTitulo.Location = new Point(11, 13);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(384, 24);
            lblTitulo.TabIndex = 2;
            lblTitulo.Text = "Capturar Imagen";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gray;
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 50);
            panel2.Name = "panel2";
            panel2.Size = new Size(450, 2);
            panel2.TabIndex = 7;
            // 
            // imgImagenWebCam
            // 
            imgImagenWebCam.BackColor = Color.Silver;
            imgImagenWebCam.Dock = DockStyle.Fill;
            imgImagenWebCam.Location = new Point(0, 52);
            imgImagenWebCam.Name = "imgImagenWebCam";
            imgImagenWebCam.Size = new Size(450, 341);
            imgImagenWebCam.SizeMode = PictureBoxSizeMode.StretchImage;
            imgImagenWebCam.TabIndex = 8;
            imgImagenWebCam.TabStop = false;
            // 
            // fCapturarImagenWebCam
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(450, 450);
            ControlBox = false;
            Controls.Add(imgImagenWebCam);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pnlSeparadorInferior);
            Controls.Add(pnlBotonera);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(450, 450);
            MinimumSize = new Size(450, 450);
            Name = "fCapturarImagenWebCam";
            StartPosition = FormStartPosition.CenterParent;
            FormClosed += fCapturarImagenWebCam_FormClosed;
            Load += fCapturarImagenWebCam_Load;
            pnlBotonera.ResumeLayout(false);
            pnlBotonera.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)imgImagenWebCam).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlSeparadorInferior;
        private Panel pnlBotonera;
        private Panel panel1;
        private Label lblTitulo;
        private FontAwesome.Sharp.IconButton btnCerrar;
        private Panel panel2;
        private PictureBox imgImagenWebCam;
        private Label lblDispositivo;
        private ComboBox cmbDispositivo;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}