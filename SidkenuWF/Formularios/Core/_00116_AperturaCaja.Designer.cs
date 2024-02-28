namespace SidkenuWF.Formularios.Core
{
    partial class _00116_AperturaCaja
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
            pnlTitulo = new Panel();
            pnlLinea = new Panel();
            imgLogo = new FontAwesome.Sharp.IconPictureBox();
            lblTitulo = new Label();
            btnSalir = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            btnAbrirCaja = new FontAwesome.Sharp.IconButton();
            txtMonto = new TextBox();
            iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            pnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).BeginInit();
            SuspendLayout();
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
            pnlTitulo.Size = new Size(450, 57);
            pnlTitulo.TabIndex = 1;
            // 
            // pnlLinea
            // 
            pnlLinea.BackColor = Color.FromArgb(192, 64, 0);
            pnlLinea.Dock = DockStyle.Bottom;
            pnlLinea.Location = new Point(0, 56);
            pnlLinea.Name = "pnlLinea";
            pnlLinea.Size = new Size(450, 1);
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
            lblTitulo.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.ForeColor = Color.WhiteSmoke;
            lblTitulo.Location = new Point(56, 6);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(316, 41);
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
            btnSalir.Location = new Point(394, 3);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(49, 49);
            btnSalir.TabIndex = 0;
            btnSalir.Text = "Salir";
            btnSalir.TextImageRelation = TextImageRelation.ImageAboveText;
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += BtnSalir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(87, 86);
            label1.Name = "label1";
            label1.Size = new Size(136, 18);
            label1.TabIndex = 15;
            label1.Text = "Monto de Apertura";
            // 
            // btnAbrirCaja
            // 
            btnAbrirCaja.BackColor = Color.Green;
            btnAbrirCaja.FlatStyle = FlatStyle.Flat;
            btnAbrirCaja.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnAbrirCaja.ForeColor = Color.White;
            btnAbrirCaja.IconChar = FontAwesome.Sharp.IconChar.None;
            btnAbrirCaja.IconColor = Color.Black;
            btnAbrirCaja.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAbrirCaja.Location = new Point(126, 175);
            btnAbrirCaja.Name = "btnAbrirCaja";
            btnAbrirCaja.Size = new Size(174, 45);
            btnAbrirCaja.TabIndex = 16;
            btnAbrirCaja.Text = "Abrir Caja (Turno)";
            btnAbrirCaja.UseVisualStyleBackColor = false;
            btnAbrirCaja.Click += BtnAbrirCaja_Click;
            // 
            // txtMonto
            // 
            txtMonto.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtMonto.BackColor = Color.WhiteSmoke;
            txtMonto.BorderStyle = BorderStyle.FixedSingle;
            txtMonto.Font = new Font("Arial", 24F, FontStyle.Regular, GraphicsUnit.Point);
            txtMonto.ForeColor = Color.FromArgb(64, 64, 64);
            txtMonto.Location = new Point(126, 107);
            txtMonto.Name = "txtMonto";
            txtMonto.PlaceholderText = "Ej: $ 100";
            txtMonto.Size = new Size(215, 44);
            txtMonto.TabIndex = 14;
            // 
            // iconPictureBox2
            // 
            iconPictureBox2.BackColor = Color.WhiteSmoke;
            iconPictureBox2.BorderStyle = BorderStyle.FixedSingle;
            iconPictureBox2.ForeColor = Color.FromArgb(64, 64, 64);
            iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.MoneyBillAlt;
            iconPictureBox2.IconColor = Color.FromArgb(64, 64, 64);
            iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox2.IconSize = 40;
            iconPictureBox2.Location = new Point(85, 107);
            iconPictureBox2.Name = "iconPictureBox2";
            iconPictureBox2.Size = new Size(40, 44);
            iconPictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            iconPictureBox2.TabIndex = 25;
            iconPictureBox2.TabStop = false;
            // 
            // _00116_AperturaCaja
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(450, 248);
            Controls.Add(iconPictureBox2);
            Controls.Add(btnAbrirCaja);
            Controls.Add(label1);
            Controls.Add(txtMonto);
            Controls.Add(pnlTitulo);
            MaximumSize = new Size(466, 287);
            MinimumSize = new Size(466, 287);
            Name = "_00116_AperturaCaja";
            Text = "Caja";
            pnlTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)imgLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlTitulo;
        private Panel pnlLinea;
        private FontAwesome.Sharp.IconPictureBox imgLogo;
        private Label lblTitulo;
        private FontAwesome.Sharp.IconButton btnSalir;
        private Label label1;
        private FontAwesome.Sharp.IconButton btnAbrirCaja;
        private TextBox txtMonto;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
    }
}