namespace SidkenuWF.Formularios.Core
{
    partial class _00120_TransferenciaCajas
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
            label3 = new Label();
            cmbCaja = new ComboBox();
            label5 = new Label();
            btnTransferir = new FontAwesome.Sharp.IconButton();
            nudMontoTranferir = new NumericUpDown();
            lblMensaje = new Label();
            cmbEmpresa = new ComboBox();
            label4 = new Label();
            lblMensajeMontoDisponible = new Label();
            pnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudMontoTranferir).BeginInit();
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
            pnlTitulo.Size = new Size(502, 57);
            pnlTitulo.TabIndex = 17;
            // 
            // pnlLinea
            // 
            pnlLinea.BackColor = Color.FromArgb(192, 64, 0);
            pnlLinea.Dock = DockStyle.Bottom;
            pnlLinea.Location = new Point(0, 56);
            pnlLinea.Name = "pnlLinea";
            pnlLinea.Size = new Size(502, 1);
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
            lblTitulo.Location = new Point(65, 8);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(369, 41);
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
            btnSalir.Location = new Point(446, 4);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(49, 49);
            btnSalir.TabIndex = 0;
            btnSalir.Text = "Salir";
            btnSalir.TextImageRelation = TextImageRelation.ImageAboveText;
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += BtnSalir_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(64, 64, 64);
            label3.Location = new Point(117, 173);
            label3.Name = "label3";
            label3.Size = new Size(111, 16);
            label3.TabIndex = 27;
            label3.Text = "Monto a Transferir";
            // 
            // cmbCaja
            // 
            cmbCaja.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCaja.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            cmbCaja.FormattingEnabled = true;
            cmbCaja.Location = new Point(117, 120);
            cmbCaja.Name = "cmbCaja";
            cmbCaja.Size = new Size(349, 28);
            cmbCaja.TabIndex = 31;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(64, 64, 64);
            label5.Location = new Point(28, 126);
            label5.Name = "label5";
            label5.Size = new Size(81, 16);
            label5.TabIndex = 32;
            label5.Text = "Caja Destino";
            // 
            // btnTransferir
            // 
            btnTransferir.BackColor = Color.FromArgb(54, 74, 90);
            btnTransferir.FlatStyle = FlatStyle.Flat;
            btnTransferir.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnTransferir.ForeColor = Color.White;
            btnTransferir.IconChar = FontAwesome.Sharp.IconChar.None;
            btnTransferir.IconColor = Color.Black;
            btnTransferir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnTransferir.Location = new Point(174, 266);
            btnTransferir.Name = "btnTransferir";
            btnTransferir.Size = new Size(165, 38);
            btnTransferir.TabIndex = 33;
            btnTransferir.Text = "Transferir";
            btnTransferir.UseVisualStyleBackColor = false;
            btnTransferir.Click += BtnTransferir_Click;
            // 
            // nudMontoTranferir
            // 
            nudMontoTranferir.BackColor = Color.White;
            nudMontoTranferir.DecimalPlaces = 2;
            nudMontoTranferir.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            nudMontoTranferir.Location = new Point(117, 192);
            nudMontoTranferir.Maximum = new decimal(new int[] { -727379968, 232, 0, 0 });
            nudMontoTranferir.Name = "nudMontoTranferir";
            nudMontoTranferir.Size = new Size(208, 31);
            nudMontoTranferir.TabIndex = 36;
            // 
            // lblMensaje
            // 
            lblMensaje.BackColor = Color.Transparent;
            lblMensaje.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblMensaje.ForeColor = Color.FromArgb(192, 0, 0);
            lblMensaje.Location = new Point(117, 151);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(349, 23);
            lblMensaje.TabIndex = 46;
            lblMensaje.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cmbEmpresa
            // 
            cmbEmpresa.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEmpresa.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            cmbEmpresa.FormattingEnabled = true;
            cmbEmpresa.Location = new Point(117, 86);
            cmbEmpresa.Name = "cmbEmpresa";
            cmbEmpresa.Size = new Size(349, 28);
            cmbEmpresa.TabIndex = 48;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(64, 64, 64);
            label4.Location = new Point(50, 93);
            label4.Name = "label4";
            label4.Size = new Size(59, 16);
            label4.TabIndex = 47;
            label4.Text = "Empresa";
            // 
            // lblMensajeMontoDisponible
            // 
            lblMensajeMontoDisponible.BackColor = Color.Transparent;
            lblMensajeMontoDisponible.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblMensajeMontoDisponible.ForeColor = Color.FromArgb(54, 74, 90);
            lblMensajeMontoDisponible.Location = new Point(117, 226);
            lblMensajeMontoDisponible.Name = "lblMensajeMontoDisponible";
            lblMensajeMontoDisponible.Size = new Size(349, 23);
            lblMensajeMontoDisponible.TabIndex = 49;
            lblMensajeMontoDisponible.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // _00120_TransferenciaCajas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(502, 316);
            ControlBox = false;
            Controls.Add(lblMensajeMontoDisponible);
            Controls.Add(cmbEmpresa);
            Controls.Add(label4);
            Controls.Add(lblMensaje);
            Controls.Add(nudMontoTranferir);
            Controls.Add(btnTransferir);
            Controls.Add(label5);
            Controls.Add(cmbCaja);
            Controls.Add(label3);
            Controls.Add(pnlTitulo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximumSize = new Size(518, 355);
            MinimumSize = new Size(518, 355);
            Name = "_00120_TransferenciaCajas";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Transferir";
            Load += _00120_Transferir_Load;
            pnlTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)imgLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudMontoTranferir).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Panel pnlTitulo;
        private Panel pnlLinea;
        private FontAwesome.Sharp.IconPictureBox imgLogo;
        private Label lblTitulo;
        private FontAwesome.Sharp.IconButton btnSalir;
        private Label label2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private CheckBox chkTransferirDinero;
        private Label label3;
        private ComboBox cmbCaja;
        private Label label5;
        private FontAwesome.Sharp.IconButton btnTransferir;
        private NumericUpDown nudMontoTranferir;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox5;
        private Label label6;
        private Label label7;
        private Label lblMensaje;
        private ComboBox cmbEmpresa;
        private Label label4;
        private Label lblMensajeMontoDisponible;
    }
}