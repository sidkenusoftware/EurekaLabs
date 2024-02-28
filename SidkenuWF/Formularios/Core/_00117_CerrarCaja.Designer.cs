namespace SidkenuWF.Formularios.Core
{
    partial class _00117_CerrarCaja
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
            label1 = new Label();
            pnlTitulo = new Panel();
            pnlLinea = new Panel();
            imgLogo = new FontAwesome.Sharp.IconPictureBox();
            lblTitulo = new Label();
            btnSalir = new FontAwesome.Sharp.IconButton();
            label2 = new Label();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            chkTransferirDinero = new CheckBox();
            label3 = new Label();
            label4 = new Label();
            cmbEmpresa = new ComboBox();
            cmbCaja = new ComboBox();
            label5 = new Label();
            btnCerrarCaja = new FontAwesome.Sharp.IconButton();
            nudMontoCierre = new NumericUpDown();
            nudMontoProximoTurno = new NumericUpDown();
            nudMontoTranferir = new NumericUpDown();
            iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            iconPictureBox4 = new FontAwesome.Sharp.IconPictureBox();
            nudSistema = new NumericUpDown();
            iconPictureBox5 = new FontAwesome.Sharp.IconPictureBox();
            label6 = new Label();
            label7 = new Label();
            txtDiferencia = new TextBox();
            lblMensaje = new Label();
            pnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudMontoCierre).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudMontoProximoTurno).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudMontoTranferir).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudSistema).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox5).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(30, 73);
            label1.Name = "label1";
            label1.Size = new Size(180, 16);
            label1.TabIndex = 19;
            label1.Text = "Monto declarado por el Cajero";
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
            pnlTitulo.Size = new Size(571, 57);
            pnlTitulo.TabIndex = 17;
            // 
            // pnlLinea
            // 
            pnlLinea.BackColor = Color.FromArgb(192, 64, 0);
            pnlLinea.Dock = DockStyle.Bottom;
            pnlLinea.Location = new Point(0, 56);
            pnlLinea.Name = "pnlLinea";
            pnlLinea.Size = new Size(571, 1);
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
            lblTitulo.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.ForeColor = Color.WhiteSmoke;
            lblTitulo.Location = new Point(65, 8);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(438, 41);
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
            btnSalir.Location = new Point(515, 4);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(49, 49);
            btnSalir.TabIndex = 0;
            btnSalir.Text = "Salir";
            btnSalir.TextImageRelation = TextImageRelation.ImageAboveText;
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += BtnSalir_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(64, 64, 64);
            label2.Location = new Point(303, 73);
            label2.Name = "label2";
            label2.Size = new Size(161, 16);
            label2.TabIndex = 22;
            label2.Text = "Monto para turno siguiente";
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.FromArgb(224, 224, 224);
            iconPictureBox1.ForeColor = Color.FromArgb(64, 64, 64);
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.DollarSign;
            iconPictureBox1.IconColor = Color.FromArgb(64, 64, 64);
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 26;
            iconPictureBox1.Location = new Point(29, 95);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(26, 31);
            iconPictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            iconPictureBox1.TabIndex = 23;
            iconPictureBox1.TabStop = false;
            // 
            // chkTransferirDinero
            // 
            chkTransferirDinero.AutoSize = true;
            chkTransferirDinero.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            chkTransferirDinero.Location = new Point(29, 207);
            chkTransferirDinero.Name = "chkTransferirDinero";
            chkTransferirDinero.Size = new Size(143, 22);
            chkTransferirDinero.TabIndex = 25;
            chkTransferirDinero.Text = "Transferir Dinero";
            chkTransferirDinero.UseVisualStyleBackColor = true;
            chkTransferirDinero.CheckedChanged += ChkTransferirDinero_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(64, 64, 64);
            label3.Location = new Point(96, 324);
            label3.Name = "label3";
            label3.Size = new Size(111, 16);
            label3.TabIndex = 27;
            label3.Text = "Monto a Transferir";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(64, 64, 64);
            label4.Location = new Point(29, 242);
            label4.Name = "label4";
            label4.Size = new Size(59, 16);
            label4.TabIndex = 29;
            label4.Text = "Empresa";
            // 
            // cmbEmpresa
            // 
            cmbEmpresa.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEmpresa.Enabled = false;
            cmbEmpresa.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            cmbEmpresa.FormattingEnabled = true;
            cmbEmpresa.Location = new Point(96, 235);
            cmbEmpresa.Name = "cmbEmpresa";
            cmbEmpresa.Size = new Size(442, 28);
            cmbEmpresa.TabIndex = 30;
            cmbEmpresa.SelectionChangeCommitted += CmbEmpresa_SelectionChangeCommitted;
            // 
            // cmbCaja
            // 
            cmbCaja.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCaja.Enabled = false;
            cmbCaja.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            cmbCaja.FormattingEnabled = true;
            cmbCaja.Location = new Point(96, 270);
            cmbCaja.Name = "cmbCaja";
            cmbCaja.Size = new Size(442, 28);
            cmbCaja.TabIndex = 31;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(64, 64, 64);
            label5.Location = new Point(56, 277);
            label5.Name = "label5";
            label5.Size = new Size(33, 16);
            label5.TabIndex = 32;
            label5.Text = "Caja";
            // 
            // btnCerrarCaja
            // 
            btnCerrarCaja.BackColor = Color.FromArgb(192, 0, 0);
            btnCerrarCaja.FlatStyle = FlatStyle.Flat;
            btnCerrarCaja.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCerrarCaja.ForeColor = Color.White;
            btnCerrarCaja.IconChar = FontAwesome.Sharp.IconChar.None;
            btnCerrarCaja.IconColor = Color.Black;
            btnCerrarCaja.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCerrarCaja.Location = new Point(202, 383);
            btnCerrarCaja.Name = "btnCerrarCaja";
            btnCerrarCaja.Size = new Size(165, 38);
            btnCerrarCaja.TabIndex = 33;
            btnCerrarCaja.Text = "Cerrar Caja (Turno)";
            btnCerrarCaja.UseVisualStyleBackColor = false;
            btnCerrarCaja.Click += BtnCerrarCaja_Click;
            // 
            // nudMontoCierre
            // 
            nudMontoCierre.BackColor = Color.White;
            nudMontoCierre.DecimalPlaces = 2;
            nudMontoCierre.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            nudMontoCierre.Location = new Point(57, 95);
            nudMontoCierre.Maximum = new decimal(new int[] { -727379968, 232, 0, 0 });
            nudMontoCierre.Name = "nudMontoCierre";
            nudMontoCierre.Size = new Size(208, 31);
            nudMontoCierre.TabIndex = 34;
            nudMontoCierre.ValueChanged += NudMontoCierre_ValueChanged;
            // 
            // nudMontoProximoTurno
            // 
            nudMontoProximoTurno.BackColor = Color.White;
            nudMontoProximoTurno.DecimalPlaces = 2;
            nudMontoProximoTurno.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            nudMontoProximoTurno.Location = new Point(332, 95);
            nudMontoProximoTurno.Maximum = new decimal(new int[] { -727379968, 232, 0, 0 });
            nudMontoProximoTurno.Name = "nudMontoProximoTurno";
            nudMontoProximoTurno.Size = new Size(208, 31);
            nudMontoProximoTurno.TabIndex = 35;
            nudMontoProximoTurno.ValueChanged += NudMontoProximoTurno_ValueChanged;
            // 
            // nudMontoTranferir
            // 
            nudMontoTranferir.BackColor = Color.White;
            nudMontoTranferir.DecimalPlaces = 2;
            nudMontoTranferir.Enabled = false;
            nudMontoTranferir.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            nudMontoTranferir.Location = new Point(125, 343);
            nudMontoTranferir.Maximum = new decimal(new int[] { -727379968, 232, 0, 0 });
            nudMontoTranferir.Name = "nudMontoTranferir";
            nudMontoTranferir.Size = new Size(208, 31);
            nudMontoTranferir.TabIndex = 36;
            // 
            // iconPictureBox2
            // 
            iconPictureBox2.BackColor = Color.FromArgb(224, 224, 224);
            iconPictureBox2.ForeColor = Color.FromArgb(64, 64, 64);
            iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.DollarSign;
            iconPictureBox2.IconColor = Color.FromArgb(64, 64, 64);
            iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox2.IconSize = 26;
            iconPictureBox2.Location = new Point(303, 95);
            iconPictureBox2.Name = "iconPictureBox2";
            iconPictureBox2.Size = new Size(26, 31);
            iconPictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            iconPictureBox2.TabIndex = 37;
            iconPictureBox2.TabStop = false;
            // 
            // iconPictureBox3
            // 
            iconPictureBox3.BackColor = Color.FromArgb(224, 224, 224);
            iconPictureBox3.ForeColor = Color.FromArgb(64, 64, 64);
            iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.DollarSign;
            iconPictureBox3.IconColor = Color.FromArgb(64, 64, 64);
            iconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox3.IconSize = 26;
            iconPictureBox3.Location = new Point(96, 343);
            iconPictureBox3.Name = "iconPictureBox3";
            iconPictureBox3.Size = new Size(26, 31);
            iconPictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
            iconPictureBox3.TabIndex = 38;
            iconPictureBox3.TabStop = false;
            // 
            // iconPictureBox4
            // 
            iconPictureBox4.BackColor = Color.FromArgb(224, 224, 224);
            iconPictureBox4.ForeColor = Color.FromArgb(64, 64, 64);
            iconPictureBox4.IconChar = FontAwesome.Sharp.IconChar.DollarSign;
            iconPictureBox4.IconColor = Color.FromArgb(64, 64, 64);
            iconPictureBox4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox4.IconSize = 26;
            iconPictureBox4.Location = new Point(303, 161);
            iconPictureBox4.Name = "iconPictureBox4";
            iconPictureBox4.Size = new Size(26, 33);
            iconPictureBox4.SizeMode = PictureBoxSizeMode.CenterImage;
            iconPictureBox4.TabIndex = 44;
            iconPictureBox4.TabStop = false;
            // 
            // nudSistema
            // 
            nudSistema.BackColor = Color.White;
            nudSistema.DecimalPlaces = 2;
            nudSistema.Enabled = false;
            nudSistema.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            nudSistema.Location = new Point(57, 161);
            nudSistema.Maximum = new decimal(new int[] { -727379968, 232, 0, 0 });
            nudSistema.Minimum = new decimal(new int[] { -727379968, 232, 0, int.MinValue });
            nudSistema.Name = "nudSistema";
            nudSistema.Size = new Size(208, 31);
            nudSistema.TabIndex = 42;
            // 
            // iconPictureBox5
            // 
            iconPictureBox5.BackColor = Color.FromArgb(224, 224, 224);
            iconPictureBox5.ForeColor = Color.FromArgb(64, 64, 64);
            iconPictureBox5.IconChar = FontAwesome.Sharp.IconChar.DollarSign;
            iconPictureBox5.IconColor = Color.FromArgb(64, 64, 64);
            iconPictureBox5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox5.IconSize = 26;
            iconPictureBox5.Location = new Point(29, 161);
            iconPictureBox5.Name = "iconPictureBox5";
            iconPictureBox5.Size = new Size(26, 31);
            iconPictureBox5.SizeMode = PictureBoxSizeMode.CenterImage;
            iconPictureBox5.TabIndex = 41;
            iconPictureBox5.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(64, 64, 64);
            label6.Location = new Point(303, 139);
            label6.Name = "label6";
            label6.Size = new Size(64, 16);
            label6.TabIndex = 40;
            label6.Text = "Diferencia";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(64, 64, 64);
            label7.Location = new Point(30, 139);
            label7.Name = "label7";
            label7.Size = new Size(116, 16);
            label7.TabIndex = 39;
            label7.Text = "Monto del Sistema";
            // 
            // txtDiferencia
            // 
            txtDiferencia.BorderStyle = BorderStyle.FixedSingle;
            txtDiferencia.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtDiferencia.ForeColor = Color.White;
            txtDiferencia.Location = new Point(335, 161);
            txtDiferencia.Name = "txtDiferencia";
            txtDiferencia.ReadOnly = true;
            txtDiferencia.Size = new Size(203, 33);
            txtDiferencia.TabIndex = 45;
            // 
            // lblMensaje
            // 
            lblMensaje.BackColor = Color.Transparent;
            lblMensaje.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblMensaje.ForeColor = Color.FromArgb(192, 0, 0);
            lblMensaje.Location = new Point(96, 301);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(442, 16);
            lblMensaje.TabIndex = 46;
            lblMensaje.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // _00117_CerrarCaja
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(571, 426);
            ControlBox = false;
            Controls.Add(lblMensaje);
            Controls.Add(txtDiferencia);
            Controls.Add(iconPictureBox4);
            Controls.Add(nudSistema);
            Controls.Add(iconPictureBox5);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(iconPictureBox3);
            Controls.Add(iconPictureBox2);
            Controls.Add(nudMontoTranferir);
            Controls.Add(nudMontoProximoTurno);
            Controls.Add(nudMontoCierre);
            Controls.Add(btnCerrarCaja);
            Controls.Add(label5);
            Controls.Add(cmbCaja);
            Controls.Add(cmbEmpresa);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(chkTransferirDinero);
            Controls.Add(iconPictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pnlTitulo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximumSize = new Size(587, 465);
            MinimumSize = new Size(587, 465);
            Name = "_00117_CerrarCaja";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Cerrar Caja";
            Load += _00117_CerrarCaja_Load;
            pnlTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)imgLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudMontoCierre).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudMontoProximoTurno).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudMontoTranferir).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudSistema).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox5).EndInit();
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
        private Label label4;
        private ComboBox cmbEmpresa;
        private ComboBox cmbCaja;
        private Label label5;
        private FontAwesome.Sharp.IconButton btnCerrarCaja;
        private NumericUpDown nudMontoCierre;
        private NumericUpDown nudMontoProximoTurno;
        private NumericUpDown nudMontoTranferir;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox4;
        private NumericUpDown nudSistema;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox5;
        private Label label6;
        private Label label7;
        private TextBox txtDiferencia;
        private Label lblMensaje;
    }
}