namespace SidkenuWF.Formularios.Core.Controles
{
    partial class CtrolCaja
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            pnlLateral = new Panel();
            lblCaja = new Label();
            btnAbrirCaja = new FontAwesome.Sharp.IconButton();
            btnVerDetalle = new FontAwesome.Sharp.IconButton();
            btnCerrarCaja = new FontAwesome.Sharp.IconButton();
            btnNuevoGasto = new FontAwesome.Sharp.IconButton();
            btnPagarProveedor = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            btnTransferir = new FontAwesome.Sharp.IconButton();
            lblMontoApertura = new Label();
            btnCajaExterna = new FontAwesome.Sharp.IconButton();
            SuspendLayout();
            // 
            // pnlLateral
            // 
            pnlLateral.BackColor = Color.FromArgb(192, 64, 0);
            pnlLateral.Dock = DockStyle.Left;
            pnlLateral.Location = new Point(0, 0);
            pnlLateral.Name = "pnlLateral";
            pnlLateral.Size = new Size(5, 125);
            pnlLateral.TabIndex = 0;
            // 
            // lblCaja
            // 
            lblCaja.BackColor = Color.WhiteSmoke;
            lblCaja.Dock = DockStyle.Top;
            lblCaja.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblCaja.ForeColor = Color.SteelBlue;
            lblCaja.Location = new Point(5, 0);
            lblCaja.Name = "lblCaja";
            lblCaja.Padding = new Padding(15, 0, 0, 0);
            lblCaja.Size = new Size(302, 46);
            lblCaja.TabIndex = 1;
            lblCaja.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnAbrirCaja
            // 
            btnAbrirCaja.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAbrirCaja.BackColor = Color.Green;
            btnAbrirCaja.FlatAppearance.BorderSize = 0;
            btnAbrirCaja.FlatStyle = FlatStyle.Flat;
            btnAbrirCaja.ForeColor = Color.White;
            btnAbrirCaja.IconChar = FontAwesome.Sharp.IconChar.CashRegister;
            btnAbrirCaja.IconColor = Color.White;
            btnAbrirCaja.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAbrirCaja.IconSize = 30;
            btnAbrirCaja.Location = new Point(13, 88);
            btnAbrirCaja.Name = "btnAbrirCaja";
            btnAbrirCaja.Size = new Size(34, 32);
            btnAbrirCaja.TabIndex = 8;
            btnAbrirCaja.UseVisualStyleBackColor = false;
            btnAbrirCaja.Click += BtnAbrirCaja_Click;
            // 
            // btnVerDetalle
            // 
            btnVerDetalle.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnVerDetalle.BackColor = Color.Gray;
            btnVerDetalle.FlatAppearance.BorderSize = 0;
            btnVerDetalle.FlatStyle = FlatStyle.Flat;
            btnVerDetalle.ForeColor = Color.White;
            btnVerDetalle.IconChar = FontAwesome.Sharp.IconChar.ListAlt;
            btnVerDetalle.IconColor = Color.White;
            btnVerDetalle.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnVerDetalle.IconSize = 30;
            btnVerDetalle.Location = new Point(53, 88);
            btnVerDetalle.Name = "btnVerDetalle";
            btnVerDetalle.Size = new Size(34, 32);
            btnVerDetalle.TabIndex = 9;
            btnVerDetalle.UseVisualStyleBackColor = false;
            // 
            // btnCerrarCaja
            // 
            btnCerrarCaja.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCerrarCaja.BackColor = Color.FromArgb(192, 0, 0);
            btnCerrarCaja.FlatAppearance.BorderSize = 0;
            btnCerrarCaja.FlatStyle = FlatStyle.Flat;
            btnCerrarCaja.ForeColor = Color.White;
            btnCerrarCaja.IconChar = FontAwesome.Sharp.IconChar.CashRegister;
            btnCerrarCaja.IconColor = Color.White;
            btnCerrarCaja.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCerrarCaja.IconSize = 30;
            btnCerrarCaja.Location = new Point(94, 88);
            btnCerrarCaja.Name = "btnCerrarCaja";
            btnCerrarCaja.Size = new Size(34, 32);
            btnCerrarCaja.TabIndex = 11;
            btnCerrarCaja.UseVisualStyleBackColor = false;
            btnCerrarCaja.Click += BtnCerrarCaja_Click;
            // 
            // btnNuevoGasto
            // 
            btnNuevoGasto.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnNuevoGasto.BackColor = Color.Blue;
            btnNuevoGasto.FlatAppearance.BorderSize = 0;
            btnNuevoGasto.FlatStyle = FlatStyle.Flat;
            btnNuevoGasto.ForeColor = Color.White;
            btnNuevoGasto.IconChar = FontAwesome.Sharp.IconChar.MoneyCheckDollar;
            btnNuevoGasto.IconColor = Color.White;
            btnNuevoGasto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnNuevoGasto.IconSize = 30;
            btnNuevoGasto.Location = new Point(174, 88);
            btnNuevoGasto.Name = "btnNuevoGasto";
            btnNuevoGasto.Size = new Size(34, 32);
            btnNuevoGasto.TabIndex = 12;
            btnNuevoGasto.UseVisualStyleBackColor = false;
            btnNuevoGasto.Click += BtnNuevoGasto_Click;
            // 
            // btnPagarProveedor
            // 
            btnPagarProveedor.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnPagarProveedor.BackColor = Color.FromArgb(255, 128, 0);
            btnPagarProveedor.FlatAppearance.BorderSize = 0;
            btnPagarProveedor.FlatStyle = FlatStyle.Flat;
            btnPagarProveedor.ForeColor = Color.White;
            btnPagarProveedor.IconChar = FontAwesome.Sharp.IconChar.Truck;
            btnPagarProveedor.IconColor = Color.White;
            btnPagarProveedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnPagarProveedor.IconSize = 30;
            btnPagarProveedor.Location = new Point(214, 88);
            btnPagarProveedor.Name = "btnPagarProveedor";
            btnPagarProveedor.Size = new Size(34, 32);
            btnPagarProveedor.TabIndex = 13;
            btnPagarProveedor.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(192, 64, 0);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(307, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(5, 125);
            panel1.TabIndex = 14;
            // 
            // btnTransferir
            // 
            btnTransferir.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnTransferir.BackColor = Color.FromArgb(192, 0, 192);
            btnTransferir.FlatAppearance.BorderSize = 0;
            btnTransferir.FlatStyle = FlatStyle.Flat;
            btnTransferir.ForeColor = Color.White;
            btnTransferir.IconChar = FontAwesome.Sharp.IconChar.MoneyBillTransfer;
            btnTransferir.IconColor = Color.White;
            btnTransferir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnTransferir.IconSize = 30;
            btnTransferir.Location = new Point(134, 88);
            btnTransferir.Name = "btnTransferir";
            btnTransferir.Size = new Size(34, 32);
            btnTransferir.TabIndex = 15;
            btnTransferir.UseVisualStyleBackColor = false;
            btnTransferir.Click += BtnTransferir_Click;
            // 
            // lblMontoApertura
            // 
            lblMontoApertura.BackColor = Color.WhiteSmoke;
            lblMontoApertura.Dock = DockStyle.Top;
            lblMontoApertura.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblMontoApertura.ForeColor = Color.FromArgb(192, 64, 0);
            lblMontoApertura.Location = new Point(5, 46);
            lblMontoApertura.Name = "lblMontoApertura";
            lblMontoApertura.Padding = new Padding(15, 0, 0, 0);
            lblMontoApertura.Size = new Size(302, 30);
            lblMontoApertura.TabIndex = 16;
            lblMontoApertura.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnCajaExterna
            // 
            btnCajaExterna.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCajaExterna.BackColor = Color.FromArgb(64, 64, 64);
            btnCajaExterna.FlatAppearance.BorderSize = 0;
            btnCajaExterna.FlatStyle = FlatStyle.Flat;
            btnCajaExterna.ForeColor = Color.White;
            btnCajaExterna.IconChar = FontAwesome.Sharp.IconChar.SackDollar;
            btnCajaExterna.IconColor = Color.White;
            btnCajaExterna.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCajaExterna.IconSize = 30;
            btnCajaExterna.Location = new Point(264, 88);
            btnCajaExterna.Name = "btnCajaExterna";
            btnCajaExterna.Size = new Size(34, 32);
            btnCajaExterna.TabIndex = 17;
            btnCajaExterna.UseVisualStyleBackColor = false;
            // 
            // CtrolCaja
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(btnCajaExterna);
            Controls.Add(lblMontoApertura);
            Controls.Add(lblCaja);
            Controls.Add(panel1);
            Controls.Add(btnTransferir);
            Controls.Add(btnPagarProveedor);
            Controls.Add(btnNuevoGasto);
            Controls.Add(btnCerrarCaja);
            Controls.Add(btnVerDetalle);
            Controls.Add(btnAbrirCaja);
            Controls.Add(pnlLateral);
            Name = "CtrolCaja";
            Size = new Size(312, 125);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlLateral;
        private Label lblCaja;
        public FontAwesome.Sharp.IconButton btnAbrirCaja;
        public FontAwesome.Sharp.IconButton btnVerDetalle;
        public FontAwesome.Sharp.IconButton btnCerrarCaja;
        public FontAwesome.Sharp.IconButton btnNuevoGasto;
        public FontAwesome.Sharp.IconButton btnPagarProveedor;
        private Panel panel1;
        public FontAwesome.Sharp.IconButton btnTransferir;
        private Label lblMontoApertura;
        public FontAwesome.Sharp.IconButton btnCajaExterna;
    }
}
