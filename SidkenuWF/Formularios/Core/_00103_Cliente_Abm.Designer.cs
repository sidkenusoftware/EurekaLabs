namespace SidkenuWF.Formularios.Core
{
    partial class _00103_Cliente_Abm
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
            txtRazonSocial = new TextBox();
            tabCtrolDatos = new TabControl();
            tabPageInformacionGeneral = new TabPage();
            panel1 = new Panel();
            label4 = new Label();
            label3 = new Label();
            chkEmpresa = new Base.Controles.SidkenuToggleButton();
            cmbTipoDocumento = new ComboBox();
            label9 = new Label();
            dtpFechaNacimiento = new DateTimePicker();
            label14 = new Label();
            txtCorreoElectronico = new TextBox();
            txtTelefono = new TextBox();
            txtDocumento = new TextBox();
            txtDireccion = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label5 = new Label();
            tabPage1 = new TabPage();
            nudBonificacion = new NumericUpDown();
            label12 = new Label();
            chkBonificacion = new Base.Controles.SidkenuToggleButton();
            label10 = new Label();
            nudMontoMaximoCompra = new NumericUpDown();
            label6 = new Label();
            chkCuentaCorriente = new Base.Controles.SidkenuToggleButton();
            chkListaPrecio = new Base.Controles.SidkenuToggleButton();
            cmbListaPrecio = new ComboBox();
            btnNuevaListaPrecio = new FontAwesome.Sharp.IconButton();
            label2 = new Label();
            cmbTipoResponsabilidad = new ComboBox();
            btnNuevTipoResponsabilidad = new FontAwesome.Sharp.IconButton();
            label11 = new Label();
            tabCtrolDatos.SuspendLayout();
            tabPageInformacionGeneral.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudBonificacion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudMontoMaximoCompra).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(27, 71);
            label1.Name = "label1";
            label1.Size = new Size(201, 16);
            label1.TabIndex = 23;
            label1.Text = "Razón Social / Apellido y Nombre";
            // 
            // txtRazonSocial
            // 
            txtRazonSocial.BackColor = Color.WhiteSmoke;
            txtRazonSocial.BorderStyle = BorderStyle.FixedSingle;
            txtRazonSocial.Font = new Font("Arial", 24F, FontStyle.Regular, GraphicsUnit.Point);
            txtRazonSocial.ForeColor = Color.FromArgb(64, 64, 64);
            txtRazonSocial.Location = new Point(24, 92);
            txtRazonSocial.Name = "txtRazonSocial";
            txtRazonSocial.PlaceholderText = "Ej: Cristian / Negocio";
            txtRazonSocial.Size = new Size(567, 44);
            txtRazonSocial.TabIndex = 22;
            // 
            // tabCtrolDatos
            // 
            tabCtrolDatos.Controls.Add(tabPageInformacionGeneral);
            tabCtrolDatos.Controls.Add(tabPage1);
            tabCtrolDatos.Location = new Point(24, 150);
            tabCtrolDatos.Name = "tabCtrolDatos";
            tabCtrolDatos.Padding = new Point(20, 10);
            tabCtrolDatos.SelectedIndex = 0;
            tabCtrolDatos.Size = new Size(567, 360);
            tabCtrolDatos.TabIndex = 24;
            // 
            // tabPageInformacionGeneral
            // 
            tabPageInformacionGeneral.BackColor = Color.White;
            tabPageInformacionGeneral.Controls.Add(panel1);
            tabPageInformacionGeneral.Controls.Add(label4);
            tabPageInformacionGeneral.Controls.Add(label3);
            tabPageInformacionGeneral.Controls.Add(chkEmpresa);
            tabPageInformacionGeneral.Controls.Add(cmbTipoDocumento);
            tabPageInformacionGeneral.Controls.Add(label9);
            tabPageInformacionGeneral.Controls.Add(dtpFechaNacimiento);
            tabPageInformacionGeneral.Controls.Add(label14);
            tabPageInformacionGeneral.Controls.Add(txtCorreoElectronico);
            tabPageInformacionGeneral.Controls.Add(txtTelefono);
            tabPageInformacionGeneral.Controls.Add(txtDocumento);
            tabPageInformacionGeneral.Controls.Add(txtDireccion);
            tabPageInformacionGeneral.Controls.Add(label8);
            tabPageInformacionGeneral.Controls.Add(label7);
            tabPageInformacionGeneral.Controls.Add(label5);
            tabPageInformacionGeneral.Location = new Point(4, 38);
            tabPageInformacionGeneral.Name = "tabPageInformacionGeneral";
            tabPageInformacionGeneral.Padding = new Padding(3);
            tabPageInformacionGeneral.Size = new Size(559, 318);
            tabPageInformacionGeneral.TabIndex = 0;
            tabPageInformacionGeneral.Text = "Información General";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Bottom;
            panel1.BackColor = Color.LightGray;
            panel1.Location = new Point(19, 249);
            panel1.Name = "panel1";
            panel1.Size = new Size(522, 1);
            panel1.TabIndex = 105;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(192, 0, 0);
            label4.Location = new Point(270, 256);
            label4.Name = "label4";
            label4.Size = new Size(280, 56);
            label4.TabIndex = 94;
            label4.Text = "Nota: si activa esta opción los datos que esta \r\ncargando solo podra ser visualizado por la empresa que\r\nlo esta dando de alta y no en las sucursales en caso de \r\ntenerlas.\r\n";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(64, 64, 64);
            label3.Location = new Point(66, 268);
            label3.Name = "label3";
            label3.Size = new Size(186, 16);
            label3.TabIndex = 93;
            label3.Text = "Pertenece solo a una Empresa";
            // 
            // chkEmpresa
            // 
            chkEmpresa.AutoSize = true;
            chkEmpresa.Location = new Point(15, 264);
            chkEmpresa.MinimumSize = new Size(45, 22);
            chkEmpresa.Name = "chkEmpresa";
            chkEmpresa.OffBackColor = Color.Gray;
            chkEmpresa.OffToggleColor = Color.Gainsboro;
            chkEmpresa.OnBackColor = Color.Green;
            chkEmpresa.OnToggleColor = Color.WhiteSmoke;
            chkEmpresa.Size = new Size(45, 22);
            chkEmpresa.TabIndex = 92;
            chkEmpresa.UseVisualStyleBackColor = true;
            // 
            // cmbTipoDocumento
            // 
            cmbTipoDocumento.BackColor = Color.WhiteSmoke;
            cmbTipoDocumento.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoDocumento.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            cmbTipoDocumento.ForeColor = Color.FromArgb(64, 64, 64);
            cmbTipoDocumento.FormattingEnabled = true;
            cmbTipoDocumento.ItemHeight = 16;
            cmbTipoDocumento.Location = new Point(18, 87);
            cmbTipoDocumento.MaxDropDownItems = 12;
            cmbTipoDocumento.Name = "cmbTipoDocumento";
            cmbTipoDocumento.Size = new Size(193, 24);
            cmbTipoDocumento.TabIndex = 90;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.FromArgb(64, 64, 64);
            label9.Location = new Point(18, 67);
            label9.Name = "label9";
            label9.Size = new Size(76, 16);
            label9.TabIndex = 89;
            label9.Text = "Documento";
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dtpFechaNacimiento.Format = DateTimePickerFormat.Short;
            dtpFechaNacimiento.Location = new Point(258, 143);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(169, 22);
            dtpFechaNacimiento.TabIndex = 84;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.Transparent;
            label14.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label14.ForeColor = Color.FromArgb(64, 64, 64);
            label14.Location = new Point(258, 124);
            label14.Name = "label14";
            label14.Size = new Size(116, 16);
            label14.TabIndex = 83;
            label14.Text = "Fecha Nacimiento";
            // 
            // txtCorreoElectronico
            // 
            txtCorreoElectronico.BackColor = Color.WhiteSmoke;
            txtCorreoElectronico.BorderStyle = BorderStyle.FixedSingle;
            txtCorreoElectronico.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtCorreoElectronico.ForeColor = Color.FromArgb(64, 64, 64);
            txtCorreoElectronico.Location = new Point(18, 199);
            txtCorreoElectronico.Name = "txtCorreoElectronico";
            txtCorreoElectronico.PlaceholderText = "Ej: sidkenusoftware@gmail.com";
            txtCorreoElectronico.Size = new Size(521, 22);
            txtCorreoElectronico.TabIndex = 80;
            // 
            // txtTelefono
            // 
            txtTelefono.BackColor = Color.WhiteSmoke;
            txtTelefono.BorderStyle = BorderStyle.FixedSingle;
            txtTelefono.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtTelefono.ForeColor = Color.FromArgb(64, 64, 64);
            txtTelefono.Location = new Point(18, 143);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.PlaceholderText = "Ej: 999-9999999";
            txtTelefono.Size = new Size(234, 22);
            txtTelefono.TabIndex = 79;
            // 
            // txtDocumento
            // 
            txtDocumento.BackColor = Color.WhiteSmoke;
            txtDocumento.BorderStyle = BorderStyle.FixedSingle;
            txtDocumento.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtDocumento.ForeColor = Color.FromArgb(64, 64, 64);
            txtDocumento.Location = new Point(217, 87);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.PlaceholderText = "Ej: 99999999";
            txtDocumento.Size = new Size(210, 22);
            txtDocumento.TabIndex = 78;
            // 
            // txtDireccion
            // 
            txtDireccion.BackColor = Color.WhiteSmoke;
            txtDireccion.BorderStyle = BorderStyle.FixedSingle;
            txtDireccion.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtDireccion.ForeColor = Color.FromArgb(64, 64, 64);
            txtDireccion.Location = new Point(18, 27);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.PlaceholderText = "Ej: Sarmiento 134";
            txtDireccion.Size = new Size(521, 22);
            txtDireccion.TabIndex = 77;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(64, 64, 64);
            label8.Location = new Point(18, 180);
            label8.Name = "label8";
            label8.Size = new Size(118, 16);
            label8.TabIndex = 74;
            label8.Text = "Correo Electrónico";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(64, 64, 64);
            label7.Location = new Point(18, 124);
            label7.Name = "label7";
            label7.Size = new Size(61, 16);
            label7.TabIndex = 73;
            label7.Text = "Teléfono";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(64, 64, 64);
            label5.Location = new Point(18, 8);
            label5.Name = "label5";
            label5.Size = new Size(64, 16);
            label5.TabIndex = 71;
            label5.Text = "Direccion";
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.White;
            tabPage1.Controls.Add(nudBonificacion);
            tabPage1.Controls.Add(label12);
            tabPage1.Controls.Add(chkBonificacion);
            tabPage1.Controls.Add(label10);
            tabPage1.Controls.Add(nudMontoMaximoCompra);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(chkCuentaCorriente);
            tabPage1.Controls.Add(chkListaPrecio);
            tabPage1.Controls.Add(cmbListaPrecio);
            tabPage1.Controls.Add(btnNuevaListaPrecio);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(cmbTipoResponsabilidad);
            tabPage1.Controls.Add(btnNuevTipoResponsabilidad);
            tabPage1.Controls.Add(label11);
            tabPage1.Location = new Point(4, 38);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(559, 318);
            tabPage1.TabIndex = 1;
            tabPage1.Text = "Venta";
            // 
            // nudBonificacion
            // 
            nudBonificacion.DecimalPlaces = 2;
            nudBonificacion.Location = new Point(67, 205);
            nudBonificacion.Maximum = new decimal(new int[] { 1661992960, 1808227885, 5, 0 });
            nudBonificacion.Name = "nudBonificacion";
            nudBonificacion.Size = new Size(120, 23);
            nudBonificacion.TabIndex = 98;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ForeColor = Color.FromArgb(64, 64, 64);
            label12.Location = new Point(19, 184);
            label12.Name = "label12";
            label12.Size = new Size(77, 16);
            label12.TabIndex = 97;
            label12.Text = "Bonificación";
            // 
            // chkBonificacion
            // 
            chkBonificacion.AutoSize = true;
            chkBonificacion.BackColor = Color.White;
            chkBonificacion.Location = new Point(16, 204);
            chkBonificacion.MinimumSize = new Size(45, 22);
            chkBonificacion.Name = "chkBonificacion";
            chkBonificacion.OffBackColor = Color.Gray;
            chkBonificacion.OffToggleColor = Color.Gainsboro;
            chkBonificacion.OnBackColor = Color.Green;
            chkBonificacion.OnToggleColor = Color.WhiteSmoke;
            chkBonificacion.Size = new Size(45, 22);
            chkBonificacion.TabIndex = 96;
            chkBonificacion.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.FromArgb(192, 64, 0);
            label10.Location = new Point(196, 154);
            label10.Name = "label10";
            label10.Size = new Size(278, 16);
            label10.TabIndex = 95;
            label10.Text = "Nota: si es 0 (Cero) no tendra límite de compra\r\n";
            // 
            // nudMontoMaximoCompra
            // 
            nudMontoMaximoCompra.DecimalPlaces = 2;
            nudMontoMaximoCompra.Location = new Point(67, 150);
            nudMontoMaximoCompra.Maximum = new decimal(new int[] { 1661992960, 1808227885, 5, 0 });
            nudMontoMaximoCompra.Name = "nudMontoMaximoCompra";
            nudMontoMaximoCompra.Size = new Size(120, 23);
            nudMontoMaximoCompra.TabIndex = 88;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(64, 64, 64);
            label6.Location = new Point(19, 129);
            label6.Name = "label6";
            label6.Size = new Size(104, 16);
            label6.TabIndex = 87;
            label6.Text = "Cuenta Corriente";
            // 
            // chkCuentaCorriente
            // 
            chkCuentaCorriente.AutoSize = true;
            chkCuentaCorriente.BackColor = Color.White;
            chkCuentaCorriente.Location = new Point(16, 149);
            chkCuentaCorriente.MinimumSize = new Size(45, 22);
            chkCuentaCorriente.Name = "chkCuentaCorriente";
            chkCuentaCorriente.OffBackColor = Color.Gray;
            chkCuentaCorriente.OffToggleColor = Color.Gainsboro;
            chkCuentaCorriente.OnBackColor = Color.Green;
            chkCuentaCorriente.OnToggleColor = Color.WhiteSmoke;
            chkCuentaCorriente.Size = new Size(45, 22);
            chkCuentaCorriente.TabIndex = 86;
            chkCuentaCorriente.UseVisualStyleBackColor = false;
            // 
            // chkListaPrecio
            // 
            chkListaPrecio.AutoSize = true;
            chkListaPrecio.BackColor = Color.White;
            chkListaPrecio.Location = new Point(16, 93);
            chkListaPrecio.MinimumSize = new Size(45, 22);
            chkListaPrecio.Name = "chkListaPrecio";
            chkListaPrecio.OffBackColor = Color.Gray;
            chkListaPrecio.OffToggleColor = Color.Gainsboro;
            chkListaPrecio.OnBackColor = Color.Green;
            chkListaPrecio.OnToggleColor = Color.WhiteSmoke;
            chkListaPrecio.Size = new Size(45, 22);
            chkListaPrecio.TabIndex = 85;
            chkListaPrecio.UseVisualStyleBackColor = false;
            // 
            // cmbListaPrecio
            // 
            cmbListaPrecio.BackColor = Color.WhiteSmoke;
            cmbListaPrecio.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbListaPrecio.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            cmbListaPrecio.ForeColor = Color.FromArgb(64, 64, 64);
            cmbListaPrecio.FormattingEnabled = true;
            cmbListaPrecio.ItemHeight = 17;
            cmbListaPrecio.Location = new Point(67, 93);
            cmbListaPrecio.MaxDropDownItems = 12;
            cmbListaPrecio.Name = "cmbListaPrecio";
            cmbListaPrecio.Size = new Size(424, 25);
            cmbListaPrecio.TabIndex = 82;
            // 
            // btnNuevaListaPrecio
            // 
            btnNuevaListaPrecio.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            btnNuevaListaPrecio.FlatStyle = FlatStyle.Flat;
            btnNuevaListaPrecio.ForeColor = Color.FromArgb(64, 64, 64);
            btnNuevaListaPrecio.IconChar = FontAwesome.Sharp.IconChar.None;
            btnNuevaListaPrecio.IconColor = Color.FromArgb(64, 64, 64);
            btnNuevaListaPrecio.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnNuevaListaPrecio.Location = new Point(497, 94);
            btnNuevaListaPrecio.Name = "btnNuevaListaPrecio";
            btnNuevaListaPrecio.Size = new Size(35, 24);
            btnNuevaListaPrecio.TabIndex = 84;
            btnNuevaListaPrecio.Text = "...";
            btnNuevaListaPrecio.UseVisualStyleBackColor = true;
            btnNuevaListaPrecio.Click += BtnNuevaListaPrecio_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(64, 64, 64);
            label2.Location = new Point(19, 74);
            label2.Name = "label2";
            label2.Size = new Size(94, 16);
            label2.TabIndex = 83;
            label2.Text = "Lista de Precio";
            // 
            // cmbTipoResponsabilidad
            // 
            cmbTipoResponsabilidad.BackColor = Color.WhiteSmoke;
            cmbTipoResponsabilidad.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoResponsabilidad.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            cmbTipoResponsabilidad.ForeColor = Color.FromArgb(64, 64, 64);
            cmbTipoResponsabilidad.FormattingEnabled = true;
            cmbTipoResponsabilidad.ItemHeight = 17;
            cmbTipoResponsabilidad.Location = new Point(16, 34);
            cmbTipoResponsabilidad.MaxDropDownItems = 12;
            cmbTipoResponsabilidad.Name = "cmbTipoResponsabilidad";
            cmbTipoResponsabilidad.Size = new Size(475, 25);
            cmbTipoResponsabilidad.TabIndex = 79;
            // 
            // btnNuevTipoResponsabilidad
            // 
            btnNuevTipoResponsabilidad.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            btnNuevTipoResponsabilidad.FlatStyle = FlatStyle.Flat;
            btnNuevTipoResponsabilidad.ForeColor = Color.FromArgb(64, 64, 64);
            btnNuevTipoResponsabilidad.IconChar = FontAwesome.Sharp.IconChar.None;
            btnNuevTipoResponsabilidad.IconColor = Color.FromArgb(64, 64, 64);
            btnNuevTipoResponsabilidad.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnNuevTipoResponsabilidad.Location = new Point(497, 35);
            btnNuevTipoResponsabilidad.Name = "btnNuevTipoResponsabilidad";
            btnNuevTipoResponsabilidad.Size = new Size(35, 24);
            btnNuevTipoResponsabilidad.TabIndex = 81;
            btnNuevTipoResponsabilidad.Text = "...";
            btnNuevTipoResponsabilidad.UseVisualStyleBackColor = true;
            btnNuevTipoResponsabilidad.Click += BtnNuevoTipoResponsabilidad_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = Color.FromArgb(64, 64, 64);
            label11.Location = new Point(19, 15);
            label11.Name = "label11";
            label11.Size = new Size(130, 16);
            label11.TabIndex = 80;
            label11.Text = "Tipo Responsabilidad";
            // 
            // _00103_Cliente_Abm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(615, 569);
            Controls.Add(label1);
            Controls.Add(txtRazonSocial);
            Controls.Add(tabCtrolDatos);
            Name = "_00103_Cliente_Abm";
            Text = "Cliente";
            Controls.SetChildIndex(tabCtrolDatos, 0);
            Controls.SetChildIndex(txtRazonSocial, 0);
            Controls.SetChildIndex(label1, 0);
            tabCtrolDatos.ResumeLayout(false);
            tabPageInformacionGeneral.ResumeLayout(false);
            tabPageInformacionGeneral.PerformLayout();
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudBonificacion).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudMontoMaximoCompra).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtRazonSocial;
        private TabControl tabCtrolDatos;
        private TabPage tabPageInformacionGeneral;
        private DateTimePicker dtpFechaNacimiento;
        private Label label14;
        private TextBox txtCorreoElectronico;
        private TextBox txtTelefono;
        private TextBox txtDocumento;
        private TextBox txtDireccion;
        private Label label8;
        private Label label7;
        private Label label5;
        private TabPage tabPage1;
        private ComboBox cmbTipoDocumento;
        private Label label9;
        private ComboBox cmbTipoResponsabilidad;
        private FontAwesome.Sharp.IconButton btnNuevTipoResponsabilidad;
        private Label label11;
        private ComboBox cmbListaPrecio;
        private FontAwesome.Sharp.IconButton btnNuevaListaPrecio;
        private Label label2;
        private Label label3;
        private Base.Controles.SidkenuToggleButton chkEmpresa;
        private Label label4;
        private Base.Controles.SidkenuToggleButton chkListaPrecio;
        private Base.Controles.SidkenuToggleButton chkCuentaCorriente;
        private NumericUpDown nudMontoMaximoCompra;
        private Label label6;
        private NumericUpDown nudBonificacion;
        private Label label12;
        private Base.Controles.SidkenuToggleButton chkBonificacion;
        private Label label10;
        private Panel panel1;
    }
}