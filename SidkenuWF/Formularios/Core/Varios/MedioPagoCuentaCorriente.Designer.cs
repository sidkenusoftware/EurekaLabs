namespace SidkenuWF.Formularios.Core.Varios
{
    partial class MedioPagoCuentaCorriente
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
            label13 = new Label();
            nudMonto = new NumericUpDown();
            btnEjecutar = new FontAwesome.Sharp.IconButton();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            txtDocumentoCliente = new TextBox();
            txtTelefonoCliente = new TextBox();
            txtDireccionCliente = new TextBox();
            btnNuevoCliente = new FontAwesome.Sharp.IconButton();
            btnBuscarCliente = new FontAwesome.Sharp.IconButton();
            txtApyNomCliente = new TextBox();
            lblCliente = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            label1 = new Label();
            txtMontoMaximoCompra = new TextBox();
            label2 = new Label();
            txtMontoAdeudado = new TextBox();
            lblClienteMensaje = new Label();
            ((System.ComponentModel.ISupportInitialize)nudMonto).BeginInit();
            SuspendLayout();
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(55, 367);
            label13.Name = "label13";
            label13.Size = new Size(63, 24);
            label13.TabIndex = 138;
            label13.Text = "Monto";
            // 
            // nudMonto
            // 
            nudMonto.DecimalPlaces = 2;
            nudMonto.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            nudMonto.Location = new Point(127, 364);
            nudMonto.Maximum = new decimal(new int[] { -1530494976, 232830, 0, 0 });
            nudMonto.Name = "nudMonto";
            nudMonto.Size = new Size(188, 33);
            nudMonto.TabIndex = 137;
            // 
            // btnEjecutar
            // 
            btnEjecutar.BackColor = Color.Green;
            btnEjecutar.FlatAppearance.BorderSize = 0;
            btnEjecutar.FlatStyle = FlatStyle.Flat;
            btnEjecutar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnEjecutar.ForeColor = Color.White;
            btnEjecutar.IconChar = FontAwesome.Sharp.IconChar.None;
            btnEjecutar.IconColor = Color.Black;
            btnEjecutar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEjecutar.Location = new Point(155, 412);
            btnEjecutar.Name = "btnEjecutar";
            btnEjecutar.Size = new Size(188, 36);
            btnEjecutar.TabIndex = 139;
            btnEjecutar.Text = "Agregar";
            btnEjecutar.UseVisualStyleBackColor = false;
            btnEjecutar.Click += BtnEjecutar_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(30, 124);
            label10.Name = "label10";
            label10.Size = new Size(91, 21);
            label10.TabIndex = 149;
            label10.Text = "Documento";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(55, 229);
            label9.Name = "label9";
            label9.Size = new Size(68, 21);
            label9.TabIndex = 148;
            label9.Text = "Telefono";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(50, 194);
            label8.Name = "label8";
            label8.Size = new Size(75, 21);
            label8.TabIndex = 147;
            label8.Text = "Direccion";
            // 
            // txtDocumentoCliente
            // 
            txtDocumentoCliente.BackColor = Color.White;
            txtDocumentoCliente.BorderStyle = BorderStyle.FixedSingle;
            txtDocumentoCliente.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDocumentoCliente.Location = new Point(127, 120);
            txtDocumentoCliente.Name = "txtDocumentoCliente";
            txtDocumentoCliente.Size = new Size(126, 29);
            txtDocumentoCliente.TabIndex = 146;
            txtDocumentoCliente.KeyPress += TxtDocumentoCliente_KeyPress;
            // 
            // txtTelefonoCliente
            // 
            txtTelefonoCliente.BackColor = Color.White;
            txtTelefonoCliente.BorderStyle = BorderStyle.FixedSingle;
            txtTelefonoCliente.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTelefonoCliente.Location = new Point(127, 225);
            txtTelefonoCliente.Name = "txtTelefonoCliente";
            txtTelefonoCliente.ReadOnly = true;
            txtTelefonoCliente.Size = new Size(126, 29);
            txtTelefonoCliente.TabIndex = 145;
            // 
            // txtDireccionCliente
            // 
            txtDireccionCliente.BackColor = Color.White;
            txtDireccionCliente.BorderStyle = BorderStyle.FixedSingle;
            txtDireccionCliente.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDireccionCliente.Location = new Point(127, 190);
            txtDireccionCliente.Name = "txtDireccionCliente";
            txtDireccionCliente.ReadOnly = true;
            txtDireccionCliente.Size = new Size(343, 29);
            txtDireccionCliente.TabIndex = 144;
            // 
            // btnNuevoCliente
            // 
            btnNuevoCliente.BackColor = Color.White;
            btnNuevoCliente.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            btnNuevoCliente.FlatStyle = FlatStyle.Flat;
            btnNuevoCliente.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnNuevoCliente.ForeColor = Color.FromArgb(64, 64, 64);
            btnNuevoCliente.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            btnNuevoCliente.IconColor = Color.FromArgb(64, 64, 64);
            btnNuevoCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnNuevoCliente.IconSize = 15;
            btnNuevoCliente.Location = new Point(284, 120);
            btnNuevoCliente.Name = "btnNuevoCliente";
            btnNuevoCliente.Size = new Size(29, 29);
            btnNuevoCliente.TabIndex = 143;
            btnNuevoCliente.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNuevoCliente.UseVisualStyleBackColor = false;
            btnNuevoCliente.Click += BtnNuevoCliente_Click;
            // 
            // btnBuscarCliente
            // 
            btnBuscarCliente.BackColor = Color.White;
            btnBuscarCliente.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            btnBuscarCliente.FlatStyle = FlatStyle.Flat;
            btnBuscarCliente.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnBuscarCliente.ForeColor = Color.FromArgb(64, 64, 64);
            btnBuscarCliente.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            btnBuscarCliente.IconColor = Color.FromArgb(64, 64, 64);
            btnBuscarCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBuscarCliente.IconSize = 15;
            btnBuscarCliente.Location = new Point(252, 120);
            btnBuscarCliente.Name = "btnBuscarCliente";
            btnBuscarCliente.Size = new Size(29, 29);
            btnBuscarCliente.TabIndex = 142;
            btnBuscarCliente.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBuscarCliente.UseVisualStyleBackColor = false;
            btnBuscarCliente.Click += BtnBuscarCliente_Click;
            // 
            // txtApyNomCliente
            // 
            txtApyNomCliente.BackColor = Color.White;
            txtApyNomCliente.BorderStyle = BorderStyle.FixedSingle;
            txtApyNomCliente.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtApyNomCliente.Location = new Point(127, 155);
            txtApyNomCliente.Name = "txtApyNomCliente";
            txtApyNomCliente.ReadOnly = true;
            txtApyNomCliente.Size = new Size(343, 29);
            txtApyNomCliente.TabIndex = 141;
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCliente.Location = new Point(63, 155);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(58, 21);
            lblCliente.TabIndex = 140;
            lblCliente.Text = "Cliente";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(224, 224, 224);
            panel1.Location = new Point(21, 266);
            panel1.Name = "panel1";
            panel1.Size = new Size(449, 2);
            panel1.TabIndex = 150;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(224, 224, 224);
            panel2.Location = new Point(21, 353);
            panel2.Name = "panel2";
            panel2.Size = new Size(449, 2);
            panel2.TabIndex = 151;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(44, 278);
            label1.Name = "label1";
            label1.Size = new Size(176, 21);
            label1.TabIndex = 153;
            label1.Text = "Monto Máximo Compra";
            // 
            // txtMontoMaximoCompra
            // 
            txtMontoMaximoCompra.BackColor = Color.Gray;
            txtMontoMaximoCompra.BorderStyle = BorderStyle.FixedSingle;
            txtMontoMaximoCompra.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtMontoMaximoCompra.ForeColor = Color.White;
            txtMontoMaximoCompra.Location = new Point(226, 274);
            txtMontoMaximoCompra.Name = "txtMontoMaximoCompra";
            txtMontoMaximoCompra.ReadOnly = true;
            txtMontoMaximoCompra.Size = new Size(216, 29);
            txtMontoMaximoCompra.TabIndex = 152;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(87, 320);
            label2.Name = "label2";
            label2.Size = new Size(131, 21);
            label2.TabIndex = 155;
            label2.Text = "Monto Adeudado";
            // 
            // txtMontoAdeudado
            // 
            txtMontoAdeudado.BackColor = Color.Gray;
            txtMontoAdeudado.BorderStyle = BorderStyle.FixedSingle;
            txtMontoAdeudado.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtMontoAdeudado.ForeColor = Color.White;
            txtMontoAdeudado.Location = new Point(226, 316);
            txtMontoAdeudado.Name = "txtMontoAdeudado";
            txtMontoAdeudado.ReadOnly = true;
            txtMontoAdeudado.Size = new Size(216, 29);
            txtMontoAdeudado.TabIndex = 154;
            // 
            // lblClienteMensaje
            // 
            lblClienteMensaje.Dock = DockStyle.Top;
            lblClienteMensaje.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblClienteMensaje.ForeColor = Color.Red;
            lblClienteMensaje.Location = new Point(0, 59);
            lblClienteMensaje.Name = "lblClienteMensaje";
            lblClienteMensaje.Size = new Size(493, 50);
            lblClienteMensaje.TabIndex = 156;
            lblClienteMensaje.Text = "Mensaje";
            lblClienteMensaje.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MedioPagoCuentaCorriente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(493, 466);
            Controls.Add(lblClienteMensaje);
            Controls.Add(label2);
            Controls.Add(txtMontoAdeudado);
            Controls.Add(label1);
            Controls.Add(txtMontoMaximoCompra);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(txtDocumentoCliente);
            Controls.Add(txtTelefonoCliente);
            Controls.Add(txtDireccionCliente);
            Controls.Add(btnNuevoCliente);
            Controls.Add(btnBuscarCliente);
            Controls.Add(txtApyNomCliente);
            Controls.Add(lblCliente);
            Controls.Add(btnEjecutar);
            Controls.Add(label13);
            Controls.Add(nudMonto);
            Name = "MedioPagoCuentaCorriente";
            Text = "Cuenta Corriente";
            Load += MedioPagoCuentaCorriente_Load;
            Controls.SetChildIndex(nudMonto, 0);
            Controls.SetChildIndex(label13, 0);
            Controls.SetChildIndex(btnEjecutar, 0);
            Controls.SetChildIndex(lblCliente, 0);
            Controls.SetChildIndex(txtApyNomCliente, 0);
            Controls.SetChildIndex(btnBuscarCliente, 0);
            Controls.SetChildIndex(btnNuevoCliente, 0);
            Controls.SetChildIndex(txtDireccionCliente, 0);
            Controls.SetChildIndex(txtTelefonoCliente, 0);
            Controls.SetChildIndex(txtDocumentoCliente, 0);
            Controls.SetChildIndex(label8, 0);
            Controls.SetChildIndex(label9, 0);
            Controls.SetChildIndex(label10, 0);
            Controls.SetChildIndex(panel1, 0);
            Controls.SetChildIndex(panel2, 0);
            Controls.SetChildIndex(txtMontoMaximoCompra, 0);
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(txtMontoAdeudado, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(lblClienteMensaje, 0);
            ((System.ComponentModel.ISupportInitialize)nudMonto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label13;
        private NumericUpDown nudMonto;
        private FontAwesome.Sharp.IconButton btnEjecutar;
        private Label label10;
        private Label label9;
        private Label label8;
        private TextBox txtDocumentoCliente;
        private TextBox txtTelefonoCliente;
        private TextBox txtDireccionCliente;
        private FontAwesome.Sharp.IconButton btnNuevoCliente;
        private FontAwesome.Sharp.IconButton btnBuscarCliente;
        private TextBox txtApyNomCliente;
        private Label lblCliente;
        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private TextBox txtMontoMaximoCompra;
        private Label label2;
        private TextBox txtMontoAdeudado;
        private Label lblClienteMensaje;
    }
}