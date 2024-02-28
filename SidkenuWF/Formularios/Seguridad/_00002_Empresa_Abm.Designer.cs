namespace SidkenuWF.Formularios.Seguridad
{
    partial class _00002_Empresa_Abm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_00002_Empresa_Abm));
            ctrolFoto = new Base.Controles.Foto.SidkenuFoto();
            label1 = new Label();
            txtEmpresa = new TextBox();
            tabCtrolDatos = new TabControl();
            tabPageInformacionGeneral = new TabPage();
            txtReferente = new TextBox();
            label10 = new Label();
            txtCorreoElectronico = new TextBox();
            txtTelefono = new TextBox();
            txtCuit = new TextBox();
            txtDireccion = new TextBox();
            txtAbreviatura = new TextBox();
            txtCodigo = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            tabPage1 = new TabPage();
            btnNuevoIngresoBruto = new FontAwesome.Sharp.IconButton();
            cmbIngresoBruto = new ComboBox();
            txtIngresoBruto = new TextBox();
            label9 = new Label();
            cmbLocalidad = new ComboBox();
            cmbProvincia = new ComboBox();
            dtpFechaInicioActividades = new DateTimePicker();
            cmbTipoResponsabilidad = new ComboBox();
            label14 = new Label();
            btnNuevaLocalidad = new FontAwesome.Sharp.IconButton();
            btnNuevaProvincia = new FontAwesome.Sharp.IconButton();
            btnNuevaTipoResponsabilidad = new FontAwesome.Sharp.IconButton();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            tabCtrolDatos.SuspendLayout();
            tabPageInformacionGeneral.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // ctrolFoto
            // 
            ctrolFoto.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ctrolFoto.BackColor = Color.WhiteSmoke;
            ctrolFoto.Imagen = (Image)resources.GetObject("ctrolFoto.Imagen");
            ctrolFoto.Location = new Point(456, 73);
            ctrolFoto.MinimumSize = new Size(130, 157);
            ctrolFoto.Name = "ctrolFoto";
            ctrolFoto.Size = new Size(130, 188);
            ctrolFoto.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(27, 115);
            label1.Name = "label1";
            label1.Size = new Size(146, 16);
            label1.TabIndex = 13;
            label1.Text = "Nombre de la Compañia";
            // 
            // txtEmpresa
            // 
            txtEmpresa.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtEmpresa.BackColor = Color.WhiteSmoke;
            txtEmpresa.BorderStyle = BorderStyle.FixedSingle;
            txtEmpresa.Font = new Font("Arial", 24F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmpresa.ForeColor = Color.FromArgb(64, 64, 64);
            txtEmpresa.Location = new Point(24, 136);
            txtEmpresa.Name = "txtEmpresa";
            txtEmpresa.PlaceholderText = "Ej: Sidkenu";
            txtEmpresa.Size = new Size(420, 44);
            txtEmpresa.TabIndex = 12;
            // 
            // tabCtrolDatos
            // 
            tabCtrolDatos.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabCtrolDatos.Controls.Add(tabPageInformacionGeneral);
            tabCtrolDatos.Controls.Add(tabPage1);
            tabCtrolDatos.Location = new Point(20, 240);
            tabCtrolDatos.Name = "tabCtrolDatos";
            tabCtrolDatos.Padding = new Point(20, 10);
            tabCtrolDatos.SelectedIndex = 0;
            tabCtrolDatos.Size = new Size(566, 353);
            tabCtrolDatos.TabIndex = 14;
            // 
            // tabPageInformacionGeneral
            // 
            tabPageInformacionGeneral.BackColor = Color.White;
            tabPageInformacionGeneral.Controls.Add(txtReferente);
            tabPageInformacionGeneral.Controls.Add(label10);
            tabPageInformacionGeneral.Controls.Add(txtCorreoElectronico);
            tabPageInformacionGeneral.Controls.Add(txtTelefono);
            tabPageInformacionGeneral.Controls.Add(txtCuit);
            tabPageInformacionGeneral.Controls.Add(txtDireccion);
            tabPageInformacionGeneral.Controls.Add(txtAbreviatura);
            tabPageInformacionGeneral.Controls.Add(txtCodigo);
            tabPageInformacionGeneral.Controls.Add(label8);
            tabPageInformacionGeneral.Controls.Add(label7);
            tabPageInformacionGeneral.Controls.Add(label6);
            tabPageInformacionGeneral.Controls.Add(label5);
            tabPageInformacionGeneral.Controls.Add(label4);
            tabPageInformacionGeneral.Controls.Add(label3);
            tabPageInformacionGeneral.Location = new Point(4, 38);
            tabPageInformacionGeneral.Name = "tabPageInformacionGeneral";
            tabPageInformacionGeneral.Padding = new Padding(3);
            tabPageInformacionGeneral.Size = new Size(558, 311);
            tabPageInformacionGeneral.TabIndex = 0;
            tabPageInformacionGeneral.Text = "Información General";
            // 
            // txtReferente
            // 
            txtReferente.BackColor = Color.WhiteSmoke;
            txtReferente.BorderStyle = BorderStyle.FixedSingle;
            txtReferente.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtReferente.ForeColor = Color.FromArgb(64, 64, 64);
            txtReferente.Location = new Point(14, 264);
            txtReferente.Name = "txtReferente";
            txtReferente.PlaceholderText = "Ej: Jesus";
            txtReferente.Size = new Size(521, 25);
            txtReferente.TabIndex = 82;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.FromArgb(64, 64, 64);
            label10.Location = new Point(13, 244);
            label10.Name = "label10";
            label10.Size = new Size(59, 16);
            label10.TabIndex = 81;
            label10.Text = "Contacto";
            // 
            // txtCorreoElectronico
            // 
            txtCorreoElectronico.BackColor = Color.WhiteSmoke;
            txtCorreoElectronico.BorderStyle = BorderStyle.FixedSingle;
            txtCorreoElectronico.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtCorreoElectronico.ForeColor = Color.FromArgb(64, 64, 64);
            txtCorreoElectronico.Location = new Point(14, 208);
            txtCorreoElectronico.Name = "txtCorreoElectronico";
            txtCorreoElectronico.PlaceholderText = "Ej: sidkenusoftware@gmail.com";
            txtCorreoElectronico.Size = new Size(521, 25);
            txtCorreoElectronico.TabIndex = 80;
            // 
            // txtTelefono
            // 
            txtTelefono.BackColor = Color.WhiteSmoke;
            txtTelefono.BorderStyle = BorderStyle.FixedSingle;
            txtTelefono.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtTelefono.ForeColor = Color.FromArgb(64, 64, 64);
            txtTelefono.Location = new Point(192, 152);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.PlaceholderText = "Ej: 999-9999999";
            txtTelefono.Size = new Size(193, 25);
            txtTelefono.TabIndex = 79;
            // 
            // txtCuit
            // 
            txtCuit.BackColor = Color.WhiteSmoke;
            txtCuit.BorderStyle = BorderStyle.FixedSingle;
            txtCuit.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtCuit.ForeColor = Color.FromArgb(64, 64, 64);
            txtCuit.Location = new Point(14, 152);
            txtCuit.Name = "txtCuit";
            txtCuit.PlaceholderText = "Ej: 99-99999999-9";
            txtCuit.Size = new Size(169, 25);
            txtCuit.TabIndex = 78;
            // 
            // txtDireccion
            // 
            txtDireccion.BackColor = Color.WhiteSmoke;
            txtDireccion.BorderStyle = BorderStyle.FixedSingle;
            txtDireccion.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtDireccion.ForeColor = Color.FromArgb(64, 64, 64);
            txtDireccion.Location = new Point(14, 89);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.PlaceholderText = "Ej: Sarmiento 134";
            txtDireccion.Size = new Size(521, 25);
            txtDireccion.TabIndex = 77;
            // 
            // txtAbreviatura
            // 
            txtAbreviatura.BackColor = Color.WhiteSmoke;
            txtAbreviatura.BorderStyle = BorderStyle.FixedSingle;
            txtAbreviatura.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtAbreviatura.ForeColor = Color.FromArgb(64, 64, 64);
            txtAbreviatura.Location = new Point(192, 30);
            txtAbreviatura.Name = "txtAbreviatura";
            txtAbreviatura.PlaceholderText = "Ej: SK";
            txtAbreviatura.Size = new Size(193, 25);
            txtAbreviatura.TabIndex = 76;
            // 
            // txtCodigo
            // 
            txtCodigo.BackColor = Color.WhiteSmoke;
            txtCodigo.BorderStyle = BorderStyle.FixedSingle;
            txtCodigo.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtCodigo.ForeColor = Color.FromArgb(64, 64, 64);
            txtCodigo.Location = new Point(14, 30);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.PlaceholderText = "Ej: 123";
            txtCodigo.Size = new Size(169, 25);
            txtCodigo.TabIndex = 75;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(64, 64, 64);
            label8.Location = new Point(17, 186);
            label8.Name = "label8";
            label8.Size = new Size(114, 16);
            label8.TabIndex = 74;
            label8.Text = "Correo Electrónico";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(64, 64, 64);
            label7.Location = new Point(192, 129);
            label7.Name = "label7";
            label7.Size = new Size(54, 16);
            label7.TabIndex = 73;
            label7.Text = "Teléfono";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(64, 64, 64);
            label6.Location = new Point(17, 129);
            label6.Name = "label6";
            label6.Size = new Size(35, 16);
            label6.TabIndex = 72;
            label6.Text = "CUIT";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(64, 64, 64);
            label5.Location = new Point(17, 70);
            label5.Name = "label5";
            label5.Size = new Size(61, 16);
            label5.TabIndex = 71;
            label5.Text = "Direccion";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(64, 64, 64);
            label4.Location = new Point(192, 11);
            label4.Name = "label4";
            label4.Size = new Size(71, 16);
            label4.TabIndex = 70;
            label4.Text = "Abreviatura";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(64, 64, 64);
            label3.Location = new Point(17, 11);
            label3.Name = "label3";
            label3.Size = new Size(47, 16);
            label3.TabIndex = 69;
            label3.Text = "Código";
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnNuevoIngresoBruto);
            tabPage1.Controls.Add(cmbIngresoBruto);
            tabPage1.Controls.Add(txtIngresoBruto);
            tabPage1.Controls.Add(label9);
            tabPage1.Controls.Add(cmbLocalidad);
            tabPage1.Controls.Add(cmbProvincia);
            tabPage1.Controls.Add(dtpFechaInicioActividades);
            tabPage1.Controls.Add(cmbTipoResponsabilidad);
            tabPage1.Controls.Add(label14);
            tabPage1.Controls.Add(btnNuevaLocalidad);
            tabPage1.Controls.Add(btnNuevaProvincia);
            tabPage1.Controls.Add(btnNuevaTipoResponsabilidad);
            tabPage1.Controls.Add(label13);
            tabPage1.Controls.Add(label12);
            tabPage1.Controls.Add(label11);
            tabPage1.Location = new Point(4, 38);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(558, 311);
            tabPage1.TabIndex = 1;
            tabPage1.Text = "Datos Adicionales";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnNuevoIngresoBruto
            // 
            btnNuevoIngresoBruto.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            btnNuevoIngresoBruto.FlatStyle = FlatStyle.Flat;
            btnNuevoIngresoBruto.ForeColor = Color.FromArgb(64, 64, 64);
            btnNuevoIngresoBruto.IconChar = FontAwesome.Sharp.IconChar.None;
            btnNuevoIngresoBruto.IconColor = Color.FromArgb(64, 64, 64);
            btnNuevoIngresoBruto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnNuevoIngresoBruto.Location = new Point(318, 34);
            btnNuevoIngresoBruto.Name = "btnNuevoIngresoBruto";
            btnNuevoIngresoBruto.Size = new Size(35, 24);
            btnNuevoIngresoBruto.TabIndex = 88;
            btnNuevoIngresoBruto.Text = "...";
            btnNuevoIngresoBruto.UseVisualStyleBackColor = true;
            btnNuevoIngresoBruto.Click += BtnNuevoIngresoBruto_Click;
            // 
            // cmbIngresoBruto
            // 
            cmbIngresoBruto.BackColor = Color.WhiteSmoke;
            cmbIngresoBruto.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbIngresoBruto.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            cmbIngresoBruto.ForeColor = Color.FromArgb(64, 64, 64);
            cmbIngresoBruto.FormattingEnabled = true;
            cmbIngresoBruto.ItemHeight = 17;
            cmbIngresoBruto.Location = new Point(30, 34);
            cmbIngresoBruto.MaxDropDownItems = 12;
            cmbIngresoBruto.Name = "cmbIngresoBruto";
            cmbIngresoBruto.Size = new Size(282, 25);
            cmbIngresoBruto.TabIndex = 87;
            // 
            // txtIngresoBruto
            // 
            txtIngresoBruto.BackColor = Color.WhiteSmoke;
            txtIngresoBruto.BorderStyle = BorderStyle.FixedSingle;
            txtIngresoBruto.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtIngresoBruto.ForeColor = Color.FromArgb(64, 64, 64);
            txtIngresoBruto.Location = new Point(359, 34);
            txtIngresoBruto.Name = "txtIngresoBruto";
            txtIngresoBruto.PlaceholderText = "Ej: 9999999";
            txtIngresoBruto.Size = new Size(168, 25);
            txtIngresoBruto.TabIndex = 86;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.FromArgb(64, 64, 64);
            label9.Location = new Point(30, 15);
            label9.Name = "label9";
            label9.Size = new Size(84, 16);
            label9.TabIndex = 85;
            label9.Text = "Ingreso Bruto";
            // 
            // cmbLocalidad
            // 
            cmbLocalidad.BackColor = Color.WhiteSmoke;
            cmbLocalidad.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbLocalidad.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            cmbLocalidad.ForeColor = Color.FromArgb(64, 64, 64);
            cmbLocalidad.FormattingEnabled = true;
            cmbLocalidad.ItemHeight = 17;
            cmbLocalidad.Location = new Point(30, 269);
            cmbLocalidad.MaxDropDownItems = 12;
            cmbLocalidad.Name = "cmbLocalidad";
            cmbLocalidad.Size = new Size(456, 25);
            cmbLocalidad.TabIndex = 84;
            // 
            // cmbProvincia
            // 
            cmbProvincia.BackColor = Color.WhiteSmoke;
            cmbProvincia.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProvincia.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            cmbProvincia.ForeColor = Color.FromArgb(64, 64, 64);
            cmbProvincia.FormattingEnabled = true;
            cmbProvincia.ItemHeight = 17;
            cmbProvincia.Location = new Point(30, 213);
            cmbProvincia.MaxDropDownItems = 12;
            cmbProvincia.Name = "cmbProvincia";
            cmbProvincia.Size = new Size(456, 25);
            cmbProvincia.TabIndex = 83;
            cmbProvincia.SelectionChangeCommitted += CmbProvincia_SelectionChangeCommitted;
            // 
            // dtpFechaInicioActividades
            // 
            dtpFechaInicioActividades.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dtpFechaInicioActividades.Format = DateTimePickerFormat.Short;
            dtpFechaInicioActividades.Location = new Point(33, 150);
            dtpFechaInicioActividades.Name = "dtpFechaInicioActividades";
            dtpFechaInicioActividades.Size = new Size(148, 25);
            dtpFechaInicioActividades.TabIndex = 82;
            // 
            // cmbTipoResponsabilidad
            // 
            cmbTipoResponsabilidad.BackColor = Color.WhiteSmoke;
            cmbTipoResponsabilidad.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoResponsabilidad.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            cmbTipoResponsabilidad.ForeColor = Color.FromArgb(64, 64, 64);
            cmbTipoResponsabilidad.FormattingEnabled = true;
            cmbTipoResponsabilidad.ItemHeight = 17;
            cmbTipoResponsabilidad.Location = new Point(30, 91);
            cmbTipoResponsabilidad.MaxDropDownItems = 12;
            cmbTipoResponsabilidad.Name = "cmbTipoResponsabilidad";
            cmbTipoResponsabilidad.Size = new Size(456, 25);
            cmbTipoResponsabilidad.TabIndex = 74;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.Transparent;
            label14.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label14.ForeColor = Color.FromArgb(64, 64, 64);
            label14.Location = new Point(33, 131);
            label14.Name = "label14";
            label14.Size = new Size(106, 16);
            label14.TabIndex = 81;
            label14.Text = "Inicio Actividades";
            // 
            // btnNuevaLocalidad
            // 
            btnNuevaLocalidad.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            btnNuevaLocalidad.FlatStyle = FlatStyle.Flat;
            btnNuevaLocalidad.ForeColor = Color.FromArgb(64, 64, 64);
            btnNuevaLocalidad.IconChar = FontAwesome.Sharp.IconChar.None;
            btnNuevaLocalidad.IconColor = Color.FromArgb(64, 64, 64);
            btnNuevaLocalidad.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnNuevaLocalidad.Location = new Point(492, 269);
            btnNuevaLocalidad.Name = "btnNuevaLocalidad";
            btnNuevaLocalidad.Size = new Size(35, 25);
            btnNuevaLocalidad.TabIndex = 80;
            btnNuevaLocalidad.Text = "...";
            btnNuevaLocalidad.UseVisualStyleBackColor = true;
            btnNuevaLocalidad.Click += BtnNuevaLocalidad_Click;
            // 
            // btnNuevaProvincia
            // 
            btnNuevaProvincia.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            btnNuevaProvincia.FlatStyle = FlatStyle.Flat;
            btnNuevaProvincia.ForeColor = Color.FromArgb(64, 64, 64);
            btnNuevaProvincia.IconChar = FontAwesome.Sharp.IconChar.None;
            btnNuevaProvincia.IconColor = Color.FromArgb(64, 64, 64);
            btnNuevaProvincia.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnNuevaProvincia.Location = new Point(492, 214);
            btnNuevaProvincia.Name = "btnNuevaProvincia";
            btnNuevaProvincia.Size = new Size(35, 24);
            btnNuevaProvincia.TabIndex = 79;
            btnNuevaProvincia.Text = "...";
            btnNuevaProvincia.UseVisualStyleBackColor = true;
            btnNuevaProvincia.Click += BtnNuevaProvincia_Click;
            // 
            // btnNuevaTipoResponsabilidad
            // 
            btnNuevaTipoResponsabilidad.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            btnNuevaTipoResponsabilidad.FlatStyle = FlatStyle.Flat;
            btnNuevaTipoResponsabilidad.ForeColor = Color.FromArgb(64, 64, 64);
            btnNuevaTipoResponsabilidad.IconChar = FontAwesome.Sharp.IconChar.None;
            btnNuevaTipoResponsabilidad.IconColor = Color.FromArgb(64, 64, 64);
            btnNuevaTipoResponsabilidad.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnNuevaTipoResponsabilidad.Location = new Point(492, 92);
            btnNuevaTipoResponsabilidad.Name = "btnNuevaTipoResponsabilidad";
            btnNuevaTipoResponsabilidad.Size = new Size(35, 24);
            btnNuevaTipoResponsabilidad.TabIndex = 78;
            btnNuevaTipoResponsabilidad.Text = "...";
            btnNuevaTipoResponsabilidad.UseVisualStyleBackColor = true;
            btnNuevaTipoResponsabilidad.Click += BtnNuevaCondicionIva_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label13.ForeColor = Color.FromArgb(64, 64, 64);
            label13.Location = new Point(33, 250);
            label13.Name = "label13";
            label13.Size = new Size(62, 16);
            label13.TabIndex = 77;
            label13.Text = "Localidad";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ForeColor = Color.FromArgb(64, 64, 64);
            label12.Location = new Point(33, 191);
            label12.Name = "label12";
            label12.Size = new Size(59, 16);
            label12.TabIndex = 76;
            label12.Text = "Provincia";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = Color.FromArgb(64, 64, 64);
            label11.Location = new Point(33, 72);
            label11.Name = "label11";
            label11.Size = new Size(148, 16);
            label11.TabIndex = 75;
            label11.Text = "Tipo de Responsabilidad";
            // 
            // _00002_Empresa_Abm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(608, 652);
            Controls.Add(ctrolFoto);
            Controls.Add(label1);
            Controls.Add(txtEmpresa);
            Controls.Add(tabCtrolDatos);
            MaximumSize = new Size(624, 691);
            MinimumSize = new Size(624, 691);
            Name = "_00002_Empresa_Abm";
            Text = "Empresa";
            Controls.SetChildIndex(tabCtrolDatos, 0);
            Controls.SetChildIndex(txtEmpresa, 0);
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(ctrolFoto, 0);
            tabCtrolDatos.ResumeLayout(false);
            tabPageInformacionGeneral.ResumeLayout(false);
            tabPageInformacionGeneral.PerformLayout();
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Base.Controles.Foto.SidkenuFoto ctrolFoto;
        private Label label1;
        private TextBox txtEmpresa;
        private TabControl tabCtrolDatos;
        private TabPage tabPageInformacionGeneral;
        private TextBox txtReferente;
        private Label label10;
        private TextBox txtCorreoElectronico;
        private TextBox txtTelefono;
        private TextBox txtCuit;
        private TextBox txtDireccion;
        private TextBox txtAbreviatura;
        private TextBox txtCodigo;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TabPage tabPage1;
        private ComboBox cmbIngresoBruto;
        private TextBox txtIngresoBruto;
        private Label label9;
        private ComboBox cmbLocalidad;
        private ComboBox cmbProvincia;
        private DateTimePicker dtpFechaInicioActividades;
        private ComboBox cmbTipoResponsabilidad;
        private Label label14;
        private FontAwesome.Sharp.IconButton btnNuevaLocalidad;
        private FontAwesome.Sharp.IconButton btnNuevaProvincia;
        private FontAwesome.Sharp.IconButton btnNuevaTipoResponsabilidad;
        private Label label13;
        private Label label12;
        private Label label11;
        private FontAwesome.Sharp.IconButton btnNuevoIngresoBruto;
    }
}