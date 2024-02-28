namespace SidkenuWF.Formularios.Core
{
    partial class _00125_Familia_Abm
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
            label2 = new Label();
            txtCodigo = new TextBox();
            label1 = new Label();
            txtDescripcion = new TextBox();
            panel1 = new Panel();
            label4 = new Label();
            label3 = new Label();
            chkEmpresa = new Base.Controles.SidkenuToggleButton();
            label21 = new Label();
            label23 = new Label();
            chkRestriccionHora = new Base.Controles.SidkenuToggleButton();
            dtpRestriccionHoraVentaHasta = new DateTimePicker();
            dtpRestriccionHoraVentaDesde = new DateTimePicker();
            label5 = new Label();
            label6 = new Label();
            chkAumentoPrecioRangoHora = new Base.Controles.SidkenuToggleButton();
            dtpAumentoPrecioHasta = new DateTimePicker();
            dtpAumentoPrecioDesde = new DateTimePicker();
            cmbTipoAumentoPrecio = new ComboBox();
            nudAumentoPrecio = new NumericUpDown();
            cmbTipoAumentoPrecioPublico = new ComboBox();
            nudAumentoPrecioPublico = new NumericUpDown();
            label7 = new Label();
            chkAumentoPrecioPublico = new Base.Controles.SidkenuToggleButton();
            panel2 = new Panel();
            cmbTipoAumentoPrecioPublicoListaPrecio = new ComboBox();
            nudAumentoPrecioPublicoListaPrecio = new NumericUpDown();
            label8 = new Label();
            chkAumentoPrecioPublicoListaPrecio = new Base.Controles.SidkenuToggleButton();
            lblActivarIncrementoPrecio = new Label();
            lblActivarIncrementoPrecioListaPrecio = new Label();
            ((System.ComponentModel.ISupportInitialize)nudAumentoPrecio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudAumentoPrecioPublico).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudAumentoPrecioPublicoListaPrecio).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(64, 64, 64);
            label2.Location = new Point(16, 68);
            label2.Name = "label2";
            label2.Size = new Size(47, 16);
            label2.TabIndex = 27;
            label2.Text = "Codigo";
            // 
            // txtCodigo
            // 
            txtCodigo.BackColor = Color.WhiteSmoke;
            txtCodigo.BorderStyle = BorderStyle.FixedSingle;
            txtCodigo.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtCodigo.ForeColor = Color.FromArgb(64, 64, 64);
            txtCodigo.Location = new Point(13, 89);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(158, 29);
            txtCodigo.TabIndex = 24;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(16, 126);
            label1.Name = "label1";
            label1.Size = new Size(144, 16);
            label1.TabIndex = 26;
            label1.Text = "Nombre Familia / Rubro";
            // 
            // txtDescripcion
            // 
            txtDescripcion.BackColor = Color.WhiteSmoke;
            txtDescripcion.BorderStyle = BorderStyle.FixedSingle;
            txtDescripcion.Font = new Font("Arial", 24F, FontStyle.Regular, GraphicsUnit.Point);
            txtDescripcion.ForeColor = Color.FromArgb(64, 64, 64);
            txtDescripcion.Location = new Point(13, 147);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(516, 44);
            txtDescripcion.TabIndex = 25;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.BackColor = Color.LightGray;
            panel1.Location = new Point(10, 468);
            panel1.Name = "panel1";
            panel1.Size = new Size(522, 1);
            panel1.TabIndex = 102;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(192, 0, 0);
            label4.Location = new Point(249, 474);
            label4.Name = "label4";
            label4.Size = new Size(280, 56);
            label4.TabIndex = 101;
            label4.Text = "Nota: si activa esta opción los datos que esta \r\ncargando solo podra ser visualizado por la empresa que\r\nlo esta dando de alta y no en las sucursales en caso de \r\ntenerlas.\r\n";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(64, 64, 64);
            label3.Location = new Point(55, 494);
            label3.Name = "label3";
            label3.Size = new Size(186, 16);
            label3.TabIndex = 100;
            label3.Text = "Pertenece solo a una Empresa";
            // 
            // chkEmpresa
            // 
            chkEmpresa.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            chkEmpresa.AutoSize = true;
            chkEmpresa.Location = new Point(10, 491);
            chkEmpresa.MinimumSize = new Size(45, 22);
            chkEmpresa.Name = "chkEmpresa";
            chkEmpresa.OffBackColor = Color.Gray;
            chkEmpresa.OffToggleColor = Color.Gainsboro;
            chkEmpresa.OnBackColor = Color.Green;
            chkEmpresa.OnToggleColor = Color.WhiteSmoke;
            chkEmpresa.Size = new Size(45, 22);
            chkEmpresa.TabIndex = 99;
            chkEmpresa.UseVisualStyleBackColor = true;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.BackColor = Color.Transparent;
            label21.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label21.ForeColor = Color.FromArgb(64, 64, 64);
            label21.Location = new Point(396, 203);
            label21.Name = "label21";
            label21.Size = new Size(23, 32);
            label21.TabIndex = 165;
            label21.Text = "-";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.BackColor = Color.Transparent;
            label23.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label23.ForeColor = Color.FromArgb(64, 64, 64);
            label23.Location = new Point(76, 203);
            label23.Name = "label23";
            label23.Size = new Size(205, 32);
            label23.TabIndex = 164;
            label23.Text = "Activar la restriccion para la venta \r\nen un rango de hora";
            // 
            // chkRestriccionHora
            // 
            chkRestriccionHora.AutoSize = true;
            chkRestriccionHora.Location = new Point(21, 208);
            chkRestriccionHora.MinimumSize = new Size(45, 22);
            chkRestriccionHora.Name = "chkRestriccionHora";
            chkRestriccionHora.OffBackColor = Color.Gray;
            chkRestriccionHora.OffToggleColor = Color.Gainsboro;
            chkRestriccionHora.OnBackColor = Color.Green;
            chkRestriccionHora.OnToggleColor = Color.WhiteSmoke;
            chkRestriccionHora.Size = new Size(45, 22);
            chkRestriccionHora.TabIndex = 163;
            chkRestriccionHora.UseVisualStyleBackColor = true;
            chkRestriccionHora.CheckedChanged += ChkRestriccionHora_CheckedChanged;
            // 
            // dtpRestriccionHoraVentaHasta
            // 
            dtpRestriccionHoraVentaHasta.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtpRestriccionHoraVentaHasta.Format = DateTimePickerFormat.Time;
            dtpRestriccionHoraVentaHasta.Location = new Point(417, 205);
            dtpRestriccionHoraVentaHasta.Name = "dtpRestriccionHoraVentaHasta";
            dtpRestriccionHoraVentaHasta.ShowUpDown = true;
            dtpRestriccionHoraVentaHasta.Size = new Size(112, 29);
            dtpRestriccionHoraVentaHasta.TabIndex = 162;
            // 
            // dtpRestriccionHoraVentaDesde
            // 
            dtpRestriccionHoraVentaDesde.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtpRestriccionHoraVentaDesde.Format = DateTimePickerFormat.Time;
            dtpRestriccionHoraVentaDesde.Location = new Point(287, 205);
            dtpRestriccionHoraVentaDesde.Name = "dtpRestriccionHoraVentaDesde";
            dtpRestriccionHoraVentaDesde.ShowUpDown = true;
            dtpRestriccionHoraVentaDesde.Size = new Size(111, 29);
            dtpRestriccionHoraVentaDesde.TabIndex = 161;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(64, 64, 64);
            label5.Location = new Point(396, 247);
            label5.Name = "label5";
            label5.Size = new Size(23, 32);
            label5.TabIndex = 170;
            label5.Text = "-";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(64, 64, 64);
            label6.Location = new Point(76, 260);
            label6.Name = "label6";
            label6.Size = new Size(206, 32);
            label6.TabIndex = 169;
            label6.Text = "Activar el aumento de Precio para \r\nuna rango de hora";
            // 
            // chkAumentoPrecioRangoHora
            // 
            chkAumentoPrecioRangoHora.AutoSize = true;
            chkAumentoPrecioRangoHora.Location = new Point(21, 265);
            chkAumentoPrecioRangoHora.MinimumSize = new Size(45, 22);
            chkAumentoPrecioRangoHora.Name = "chkAumentoPrecioRangoHora";
            chkAumentoPrecioRangoHora.OffBackColor = Color.Gray;
            chkAumentoPrecioRangoHora.OffToggleColor = Color.Gainsboro;
            chkAumentoPrecioRangoHora.OnBackColor = Color.Green;
            chkAumentoPrecioRangoHora.OnToggleColor = Color.WhiteSmoke;
            chkAumentoPrecioRangoHora.Size = new Size(45, 22);
            chkAumentoPrecioRangoHora.TabIndex = 168;
            chkAumentoPrecioRangoHora.UseVisualStyleBackColor = true;
            chkAumentoPrecioRangoHora.CheckedChanged += ChkAumentoPrecioPublico_CheckedChanged;
            // 
            // dtpAumentoPrecioHasta
            // 
            dtpAumentoPrecioHasta.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtpAumentoPrecioHasta.Format = DateTimePickerFormat.Time;
            dtpAumentoPrecioHasta.Location = new Point(417, 249);
            dtpAumentoPrecioHasta.Name = "dtpAumentoPrecioHasta";
            dtpAumentoPrecioHasta.ShowUpDown = true;
            dtpAumentoPrecioHasta.Size = new Size(112, 29);
            dtpAumentoPrecioHasta.TabIndex = 167;
            // 
            // dtpAumentoPrecioDesde
            // 
            dtpAumentoPrecioDesde.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtpAumentoPrecioDesde.Format = DateTimePickerFormat.Time;
            dtpAumentoPrecioDesde.Location = new Point(287, 249);
            dtpAumentoPrecioDesde.Name = "dtpAumentoPrecioDesde";
            dtpAumentoPrecioDesde.ShowUpDown = true;
            dtpAumentoPrecioDesde.Size = new Size(111, 29);
            dtpAumentoPrecioDesde.TabIndex = 166;
            // 
            // cmbTipoAumentoPrecio
            // 
            cmbTipoAumentoPrecio.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoAumentoPrecio.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbTipoAumentoPrecio.FormattingEnabled = true;
            cmbTipoAumentoPrecio.Location = new Point(391, 285);
            cmbTipoAumentoPrecio.Name = "cmbTipoAumentoPrecio";
            cmbTipoAumentoPrecio.Size = new Size(138, 29);
            cmbTipoAumentoPrecio.TabIndex = 172;
            // 
            // nudAumentoPrecio
            // 
            nudAumentoPrecio.DecimalPlaces = 2;
            nudAumentoPrecio.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            nudAumentoPrecio.Location = new Point(287, 286);
            nudAumentoPrecio.Name = "nudAumentoPrecio";
            nudAumentoPrecio.Size = new Size(98, 27);
            nudAumentoPrecio.TabIndex = 171;
            nudAumentoPrecio.TextAlign = HorizontalAlignment.Right;
            // 
            // cmbTipoAumentoPrecioPublico
            // 
            cmbTipoAumentoPrecioPublico.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoAumentoPrecioPublico.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbTipoAumentoPrecioPublico.FormattingEnabled = true;
            cmbTipoAumentoPrecioPublico.Location = new Point(391, 343);
            cmbTipoAumentoPrecioPublico.Name = "cmbTipoAumentoPrecioPublico";
            cmbTipoAumentoPrecioPublico.Size = new Size(138, 29);
            cmbTipoAumentoPrecioPublico.TabIndex = 188;
            // 
            // nudAumentoPrecioPublico
            // 
            nudAumentoPrecioPublico.DecimalPlaces = 2;
            nudAumentoPrecioPublico.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            nudAumentoPrecioPublico.Location = new Point(258, 344);
            nudAumentoPrecioPublico.Maximum = new decimal(new int[] { -159383552, 46653770, 5421, 0 });
            nudAumentoPrecioPublico.Name = "nudAumentoPrecioPublico";
            nudAumentoPrecioPublico.Size = new Size(127, 27);
            nudAumentoPrecioPublico.TabIndex = 187;
            nudAumentoPrecioPublico.TextAlign = HorizontalAlignment.Right;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(64, 64, 64);
            label7.Location = new Point(76, 341);
            label7.Name = "label7";
            label7.Size = new Size(176, 32);
            label7.TabIndex = 186;
            label7.Text = "Activar Incremento del Precio\r\nde Venta al Público";
            // 
            // chkAumentoPrecioPublico
            // 
            chkAumentoPrecioPublico.AutoSize = true;
            chkAumentoPrecioPublico.Location = new Point(21, 346);
            chkAumentoPrecioPublico.MinimumSize = new Size(45, 22);
            chkAumentoPrecioPublico.Name = "chkAumentoPrecioPublico";
            chkAumentoPrecioPublico.OffBackColor = Color.Gray;
            chkAumentoPrecioPublico.OffToggleColor = Color.Gainsboro;
            chkAumentoPrecioPublico.OnBackColor = Color.Green;
            chkAumentoPrecioPublico.OnToggleColor = Color.WhiteSmoke;
            chkAumentoPrecioPublico.Size = new Size(45, 22);
            chkAumentoPrecioPublico.TabIndex = 185;
            chkAumentoPrecioPublico.UseVisualStyleBackColor = true;
            chkAumentoPrecioPublico.CheckedChanged += ChkAumentoPrecioPublico_CheckedChanged;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightGray;
            panel2.Location = new Point(10, 328);
            panel2.Name = "panel2";
            panel2.Size = new Size(522, 1);
            panel2.TabIndex = 189;
            // 
            // cmbTipoAumentoPrecioPublicoListaPrecio
            // 
            cmbTipoAumentoPrecioPublicoListaPrecio.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoAumentoPrecioPublicoListaPrecio.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbTipoAumentoPrecioPublicoListaPrecio.FormattingEnabled = true;
            cmbTipoAumentoPrecioPublicoListaPrecio.Location = new Point(391, 407);
            cmbTipoAumentoPrecioPublicoListaPrecio.Name = "cmbTipoAumentoPrecioPublicoListaPrecio";
            cmbTipoAumentoPrecioPublicoListaPrecio.Size = new Size(138, 29);
            cmbTipoAumentoPrecioPublicoListaPrecio.TabIndex = 193;
            // 
            // nudAumentoPrecioPublicoListaPrecio
            // 
            nudAumentoPrecioPublicoListaPrecio.DecimalPlaces = 2;
            nudAumentoPrecioPublicoListaPrecio.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            nudAumentoPrecioPublicoListaPrecio.Location = new Point(258, 408);
            nudAumentoPrecioPublicoListaPrecio.Maximum = new decimal(new int[] { -159383552, 46653770, 5421, 0 });
            nudAumentoPrecioPublicoListaPrecio.Name = "nudAumentoPrecioPublicoListaPrecio";
            nudAumentoPrecioPublicoListaPrecio.Size = new Size(127, 27);
            nudAumentoPrecioPublicoListaPrecio.TabIndex = 192;
            nudAumentoPrecioPublicoListaPrecio.TextAlign = HorizontalAlignment.Right;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(64, 64, 64);
            label8.Location = new Point(76, 397);
            label8.Name = "label8";
            label8.Size = new Size(176, 48);
            label8.TabIndex = 191;
            label8.Text = "Activar Incremento del Precio\r\nde Venta al Público \r\npor Lista de Precio";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // chkAumentoPrecioPublicoListaPrecio
            // 
            chkAumentoPrecioPublicoListaPrecio.AutoSize = true;
            chkAumentoPrecioPublicoListaPrecio.Location = new Point(21, 410);
            chkAumentoPrecioPublicoListaPrecio.MinimumSize = new Size(45, 22);
            chkAumentoPrecioPublicoListaPrecio.Name = "chkAumentoPrecioPublicoListaPrecio";
            chkAumentoPrecioPublicoListaPrecio.OffBackColor = Color.Gray;
            chkAumentoPrecioPublicoListaPrecio.OffToggleColor = Color.Gainsboro;
            chkAumentoPrecioPublicoListaPrecio.OnBackColor = Color.Green;
            chkAumentoPrecioPublicoListaPrecio.OnToggleColor = Color.WhiteSmoke;
            chkAumentoPrecioPublicoListaPrecio.Size = new Size(45, 22);
            chkAumentoPrecioPublicoListaPrecio.TabIndex = 190;
            chkAumentoPrecioPublicoListaPrecio.UseVisualStyleBackColor = true;
            chkAumentoPrecioPublicoListaPrecio.CheckedChanged += ChkAumentoPrecioPublicoImpuesto_CheckedChanged;
            // 
            // lblActivarIncrementoPrecio
            // 
            lblActivarIncrementoPrecio.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblActivarIncrementoPrecio.AutoSize = true;
            lblActivarIncrementoPrecio.BackColor = Color.Transparent;
            lblActivarIncrementoPrecio.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblActivarIncrementoPrecio.ForeColor = Color.FromArgb(192, 64, 0);
            lblActivarIncrementoPrecio.Location = new Point(76, 378);
            lblActivarIncrementoPrecio.Name = "lblActivarIncrementoPrecio";
            lblActivarIncrementoPrecio.Size = new Size(400, 14);
            lblActivarIncrementoPrecio.TabIndex = 194;
            lblActivarIncrementoPrecio.Text = "Para ACTIVAR esta opción debera hacerlo desde la CONFIGURACION del Sistema\r\n";
            lblActivarIncrementoPrecio.TextAlign = ContentAlignment.MiddleCenter;
            lblActivarIncrementoPrecio.Visible = false;
            // 
            // lblActivarIncrementoPrecioListaPrecio
            // 
            lblActivarIncrementoPrecioListaPrecio.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblActivarIncrementoPrecioListaPrecio.AutoSize = true;
            lblActivarIncrementoPrecioListaPrecio.BackColor = Color.Transparent;
            lblActivarIncrementoPrecioListaPrecio.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblActivarIncrementoPrecioListaPrecio.ForeColor = Color.FromArgb(192, 64, 0);
            lblActivarIncrementoPrecioListaPrecio.Location = new Point(76, 449);
            lblActivarIncrementoPrecioListaPrecio.Name = "lblActivarIncrementoPrecioListaPrecio";
            lblActivarIncrementoPrecioListaPrecio.Size = new Size(400, 14);
            lblActivarIncrementoPrecioListaPrecio.TabIndex = 195;
            lblActivarIncrementoPrecioListaPrecio.Text = "Para ACTIVAR esta opción debera hacerlo desde la CONFIGURACION del Sistema\r\n";
            lblActivarIncrementoPrecioListaPrecio.TextAlign = ContentAlignment.MiddleCenter;
            lblActivarIncrementoPrecioListaPrecio.Visible = false;
            // 
            // _00125_Familia_Abm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(542, 576);
            Controls.Add(lblActivarIncrementoPrecioListaPrecio);
            Controls.Add(lblActivarIncrementoPrecio);
            Controls.Add(dtpAumentoPrecioHasta);
            Controls.Add(dtpAumentoPrecioDesde);
            Controls.Add(dtpRestriccionHoraVentaHasta);
            Controls.Add(dtpRestriccionHoraVentaDesde);
            Controls.Add(cmbTipoAumentoPrecioPublicoListaPrecio);
            Controls.Add(nudAumentoPrecioPublicoListaPrecio);
            Controls.Add(label8);
            Controls.Add(chkAumentoPrecioPublicoListaPrecio);
            Controls.Add(panel2);
            Controls.Add(cmbTipoAumentoPrecioPublico);
            Controls.Add(nudAumentoPrecioPublico);
            Controls.Add(label7);
            Controls.Add(chkAumentoPrecioPublico);
            Controls.Add(cmbTipoAumentoPrecio);
            Controls.Add(nudAumentoPrecio);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(chkAumentoPrecioRangoHora);
            Controls.Add(label21);
            Controls.Add(label23);
            Controls.Add(chkRestriccionHora);
            Controls.Add(panel1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(chkEmpresa);
            Controls.Add(label2);
            Controls.Add(txtCodigo);
            Controls.Add(label1);
            Controls.Add(txtDescripcion);
            MinimumSize = new Size(558, 551);
            Name = "_00125_Familia_Abm";
            Text = "Familia / Rubro";
            Controls.SetChildIndex(txtDescripcion, 0);
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(txtCodigo, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(chkEmpresa, 0);
            Controls.SetChildIndex(label3, 0);
            Controls.SetChildIndex(label4, 0);
            Controls.SetChildIndex(panel1, 0);
            Controls.SetChildIndex(chkRestriccionHora, 0);
            Controls.SetChildIndex(label23, 0);
            Controls.SetChildIndex(label21, 0);
            Controls.SetChildIndex(chkAumentoPrecioRangoHora, 0);
            Controls.SetChildIndex(label6, 0);
            Controls.SetChildIndex(label5, 0);
            Controls.SetChildIndex(nudAumentoPrecio, 0);
            Controls.SetChildIndex(cmbTipoAumentoPrecio, 0);
            Controls.SetChildIndex(chkAumentoPrecioPublico, 0);
            Controls.SetChildIndex(label7, 0);
            Controls.SetChildIndex(nudAumentoPrecioPublico, 0);
            Controls.SetChildIndex(cmbTipoAumentoPrecioPublico, 0);
            Controls.SetChildIndex(panel2, 0);
            Controls.SetChildIndex(chkAumentoPrecioPublicoListaPrecio, 0);
            Controls.SetChildIndex(label8, 0);
            Controls.SetChildIndex(nudAumentoPrecioPublicoListaPrecio, 0);
            Controls.SetChildIndex(cmbTipoAumentoPrecioPublicoListaPrecio, 0);
            Controls.SetChildIndex(dtpRestriccionHoraVentaDesde, 0);
            Controls.SetChildIndex(dtpRestriccionHoraVentaHasta, 0);
            Controls.SetChildIndex(dtpAumentoPrecioDesde, 0);
            Controls.SetChildIndex(dtpAumentoPrecioHasta, 0);
            Controls.SetChildIndex(lblActivarIncrementoPrecio, 0);
            Controls.SetChildIndex(lblActivarIncrementoPrecioListaPrecio, 0);
            ((System.ComponentModel.ISupportInitialize)nudAumentoPrecio).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudAumentoPrecioPublico).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudAumentoPrecioPublicoListaPrecio).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private TextBox txtCodigo;
        private Label label1;
        private TextBox txtDescripcion;
        private Panel panel1;
        private Label label4;
        private Label label3;
        private Base.Controles.SidkenuToggleButton chkEmpresa;
        private Label label21;
        private Label label23;
        private Base.Controles.SidkenuToggleButton chkRestriccionHora;
        private DateTimePicker dtpRestriccionHoraVentaHasta;
        private DateTimePicker dtpRestriccionHoraVentaDesde;
        private Label label5;
        private Label label6;
        private Base.Controles.SidkenuToggleButton chkAumentoPrecioRangoHora;
        private DateTimePicker dtpAumentoPrecioHasta;
        private DateTimePicker dtpAumentoPrecioDesde;
        private ComboBox cmbTipoAumentoPrecio;
        private NumericUpDown nudAumentoPrecio;
        private ComboBox cmbTipoAumentoPrecioPublico;
        private NumericUpDown nudAumentoPrecioPublico;
        private Label label7;
        private Base.Controles.SidkenuToggleButton chkAumentoPrecioPublico;
        private Panel panel2;
        private ComboBox cmbTipoAumentoPrecioPublicoListaPrecio;
        private NumericUpDown nudAumentoPrecioPublicoListaPrecio;
        private Label label8;
        private Base.Controles.SidkenuToggleButton chkAumentoPrecioPublicoListaPrecio;
        private Label lblActivarIncrementoPrecio;
        private Label lblActivarIncrementoPrecioListaPrecio;
    }
}