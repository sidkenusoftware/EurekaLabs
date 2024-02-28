namespace SidkenuWF.Formularios.Base.Controles
{
    partial class CtrolAsistenteEmpresa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CtrolAsistenteEmpresa));
            txtDescripcion = new TextBox();
            label1 = new Label();
            pnlLinea = new Panel();
            label2 = new Label();
            CtrolFoto = new Foto.SidkenuFoto();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            txtReferente = new TextBox();
            label10 = new Label();
            txtCorreoElectronico = new TextBox();
            txtTelefono = new TextBox();
            txtCuit = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            txtDireccion = new TextBox();
            txtAbreviatura = new TextBox();
            txtCodigo = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            tabPage2 = new TabPage();
            cmbLocalidad = new ComboBox();
            btnNuevaLocalidad = new FontAwesome.Sharp.IconButton();
            label13 = new Label();
            cmbProvincia = new ComboBox();
            dtpFechaInicioActividades = new DateTimePicker();
            label14 = new Label();
            btnNuevaProvincia = new FontAwesome.Sharp.IconButton();
            label12 = new Label();
            btnNuevoIngresoBruto = new FontAwesome.Sharp.IconButton();
            cmbIngresoBruto = new ComboBox();
            txtIngresoBruto = new TextBox();
            label9 = new Label();
            cmbCondicionIva = new ComboBox();
            btnNuevaCondicionIva = new FontAwesome.Sharp.IconButton();
            label11 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // txtDescripcion
            // 
            txtDescripcion.BackColor = Color.WhiteSmoke;
            txtDescripcion.BorderStyle = BorderStyle.FixedSingle;
            txtDescripcion.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtDescripcion.Location = new Point(18, 86);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.PlaceholderText = "Ej: Tsidkenu Software";
            txtDescripcion.Size = new Size(586, 39);
            txtDescripcion.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(18, 66);
            label1.Name = "label1";
            label1.Size = new Size(205, 16);
            label1.TabIndex = 1;
            label1.Text = "Nombre de la Compañia / Negocio";
            // 
            // pnlLinea
            // 
            pnlLinea.BackColor = Color.Silver;
            pnlLinea.Location = new Point(18, 51);
            pnlLinea.Name = "pnlLinea";
            pnlLinea.Size = new Size(737, 1);
            pnlLinea.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(21, 11);
            label2.Name = "label2";
            label2.Size = new Size(249, 32);
            label2.TabIndex = 3;
            label2.Text = "Datos de la Compañia";
            // 
            // CtrolFoto
            // 
            CtrolFoto.BackColor = Color.WhiteSmoke;
            CtrolFoto.Imagen = (Image)resources.GetObject("CtrolFoto.Imagen");
            CtrolFoto.Location = new Point(625, 72);
            CtrolFoto.MinimumSize = new Size(130, 157);
            CtrolFoto.Name = "CtrolFoto";
            CtrolFoto.Size = new Size(130, 188);
            CtrolFoto.TabIndex = 4;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(18, 137);
            tabControl1.Name = "tabControl1";
            tabControl1.Padding = new Point(10, 7);
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(590, 204);
            tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(txtReferente);
            tabPage1.Controls.Add(label10);
            tabPage1.Controls.Add(txtCorreoElectronico);
            tabPage1.Controls.Add(txtTelefono);
            tabPage1.Controls.Add(txtCuit);
            tabPage1.Controls.Add(label8);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(txtDireccion);
            tabPage1.Controls.Add(txtAbreviatura);
            tabPage1.Controls.Add(txtCodigo);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.Location = new Point(4, 32);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(582, 168);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Información General";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtReferente
            // 
            txtReferente.BackColor = Color.WhiteSmoke;
            txtReferente.BorderStyle = BorderStyle.FixedSingle;
            txtReferente.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtReferente.ForeColor = Color.FromArgb(64, 64, 64);
            txtReferente.Location = new Point(134, 135);
            txtReferente.Name = "txtReferente";
            txtReferente.PlaceholderText = "Ej: Jesus";
            txtReferente.Size = new Size(436, 25);
            txtReferente.TabIndex = 91;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.FromArgb(64, 64, 64);
            label10.Location = new Point(67, 138);
            label10.Name = "label10";
            label10.Size = new Size(59, 16);
            label10.TabIndex = 90;
            label10.Text = "Contacto";
            // 
            // txtCorreoElectronico
            // 
            txtCorreoElectronico.BackColor = Color.WhiteSmoke;
            txtCorreoElectronico.BorderStyle = BorderStyle.FixedSingle;
            txtCorreoElectronico.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtCorreoElectronico.ForeColor = Color.FromArgb(64, 64, 64);
            txtCorreoElectronico.Location = new Point(134, 104);
            txtCorreoElectronico.Name = "txtCorreoElectronico";
            txtCorreoElectronico.PlaceholderText = "Ej: sidkenusoftware@gmail.com";
            txtCorreoElectronico.Size = new Size(436, 25);
            txtCorreoElectronico.TabIndex = 89;
            // 
            // txtTelefono
            // 
            txtTelefono.BackColor = Color.WhiteSmoke;
            txtTelefono.BorderStyle = BorderStyle.FixedSingle;
            txtTelefono.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtTelefono.ForeColor = Color.FromArgb(64, 64, 64);
            txtTelefono.Location = new Point(398, 72);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.PlaceholderText = "Ej: 999-9999999";
            txtTelefono.Size = new Size(172, 25);
            txtTelefono.TabIndex = 88;
            // 
            // txtCuit
            // 
            txtCuit.BackColor = Color.WhiteSmoke;
            txtCuit.BorderStyle = BorderStyle.FixedSingle;
            txtCuit.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtCuit.ForeColor = Color.FromArgb(64, 64, 64);
            txtCuit.Location = new Point(134, 72);
            txtCuit.Name = "txtCuit";
            txtCuit.PlaceholderText = "Ej: 99-99999999-9";
            txtCuit.Size = new Size(169, 25);
            txtCuit.TabIndex = 87;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(64, 64, 64);
            label8.Location = new Point(14, 107);
            label8.Name = "label8";
            label8.Size = new Size(114, 16);
            label8.TabIndex = 86;
            label8.Text = "Correo Electrónico";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(64, 64, 64);
            label7.Location = new Point(338, 75);
            label7.Name = "label7";
            label7.Size = new Size(54, 16);
            label7.TabIndex = 85;
            label7.Text = "Teléfono";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(64, 64, 64);
            label6.Location = new Point(93, 75);
            label6.Name = "label6";
            label6.Size = new Size(35, 16);
            label6.TabIndex = 84;
            label6.Text = "CUIT";
            // 
            // txtDireccion
            // 
            txtDireccion.BackColor = Color.WhiteSmoke;
            txtDireccion.BorderStyle = BorderStyle.FixedSingle;
            txtDireccion.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtDireccion.ForeColor = Color.FromArgb(64, 64, 64);
            txtDireccion.Location = new Point(134, 41);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.PlaceholderText = "Ej: Sarmiento 134";
            txtDireccion.Size = new Size(436, 25);
            txtDireccion.TabIndex = 83;
            // 
            // txtAbreviatura
            // 
            txtAbreviatura.BackColor = Color.WhiteSmoke;
            txtAbreviatura.BorderStyle = BorderStyle.FixedSingle;
            txtAbreviatura.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtAbreviatura.ForeColor = Color.FromArgb(64, 64, 64);
            txtAbreviatura.Location = new Point(398, 10);
            txtAbreviatura.Name = "txtAbreviatura";
            txtAbreviatura.PlaceholderText = "Ej: SK";
            txtAbreviatura.Size = new Size(172, 25);
            txtAbreviatura.TabIndex = 82;
            // 
            // txtCodigo
            // 
            txtCodigo.BackColor = Color.WhiteSmoke;
            txtCodigo.BorderStyle = BorderStyle.FixedSingle;
            txtCodigo.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtCodigo.ForeColor = Color.FromArgb(64, 64, 64);
            txtCodigo.Location = new Point(135, 10);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.PlaceholderText = "Ej: 123";
            txtCodigo.Size = new Size(169, 25);
            txtCodigo.TabIndex = 81;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(64, 64, 64);
            label5.Location = new Point(67, 44);
            label5.Name = "label5";
            label5.Size = new Size(61, 16);
            label5.TabIndex = 80;
            label5.Text = "Direccion";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(64, 64, 64);
            label4.Location = new Point(321, 14);
            label4.Name = "label4";
            label4.Size = new Size(71, 16);
            label4.TabIndex = 79;
            label4.Text = "Abreviatura";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(64, 64, 64);
            label3.Location = new Point(82, 13);
            label3.Name = "label3";
            label3.Size = new Size(47, 16);
            label3.TabIndex = 78;
            label3.Text = "Código";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(cmbLocalidad);
            tabPage2.Controls.Add(btnNuevaLocalidad);
            tabPage2.Controls.Add(label13);
            tabPage2.Controls.Add(cmbProvincia);
            tabPage2.Controls.Add(dtpFechaInicioActividades);
            tabPage2.Controls.Add(label14);
            tabPage2.Controls.Add(btnNuevaProvincia);
            tabPage2.Controls.Add(label12);
            tabPage2.Controls.Add(btnNuevoIngresoBruto);
            tabPage2.Controls.Add(cmbIngresoBruto);
            tabPage2.Controls.Add(txtIngresoBruto);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(cmbCondicionIva);
            tabPage2.Controls.Add(btnNuevaCondicionIva);
            tabPage2.Controls.Add(label11);
            tabPage2.Location = new Point(4, 32);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(582, 168);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Datos Adicionales";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // cmbLocalidad
            // 
            cmbLocalidad.BackColor = Color.WhiteSmoke;
            cmbLocalidad.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbLocalidad.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            cmbLocalidad.ForeColor = Color.FromArgb(64, 64, 64);
            cmbLocalidad.FormattingEnabled = true;
            cmbLocalidad.ItemHeight = 17;
            cmbLocalidad.Location = new Point(119, 133);
            cmbLocalidad.MaxDropDownItems = 12;
            cmbLocalidad.Name = "cmbLocalidad";
            cmbLocalidad.Size = new Size(323, 25);
            cmbLocalidad.TabIndex = 103;
            // 
            // btnNuevaLocalidad
            // 
            btnNuevaLocalidad.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            btnNuevaLocalidad.FlatStyle = FlatStyle.Flat;
            btnNuevaLocalidad.ForeColor = Color.FromArgb(64, 64, 64);
            btnNuevaLocalidad.IconChar = FontAwesome.Sharp.IconChar.None;
            btnNuevaLocalidad.IconColor = Color.FromArgb(64, 64, 64);
            btnNuevaLocalidad.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnNuevaLocalidad.Location = new Point(448, 133);
            btnNuevaLocalidad.Name = "btnNuevaLocalidad";
            btnNuevaLocalidad.Size = new Size(35, 25);
            btnNuevaLocalidad.TabIndex = 102;
            btnNuevaLocalidad.Text = "...";
            btnNuevaLocalidad.UseVisualStyleBackColor = true;
            btnNuevaLocalidad.Click += BtnNuevaLocalidad_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label13.ForeColor = Color.FromArgb(64, 64, 64);
            label13.Location = new Point(48, 137);
            label13.Name = "label13";
            label13.Size = new Size(62, 16);
            label13.TabIndex = 101;
            label13.Text = "Localidad";
            // 
            // cmbProvincia
            // 
            cmbProvincia.BackColor = Color.WhiteSmoke;
            cmbProvincia.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProvincia.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            cmbProvincia.ForeColor = Color.FromArgb(64, 64, 64);
            cmbProvincia.FormattingEnabled = true;
            cmbProvincia.ItemHeight = 17;
            cmbProvincia.Location = new Point(119, 102);
            cmbProvincia.MaxDropDownItems = 12;
            cmbProvincia.Name = "cmbProvincia";
            cmbProvincia.Size = new Size(323, 25);
            cmbProvincia.TabIndex = 100;
            // 
            // dtpFechaInicioActividades
            // 
            dtpFechaInicioActividades.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dtpFechaInicioActividades.Format = DateTimePickerFormat.Short;
            dtpFechaInicioActividades.Location = new Point(119, 72);
            dtpFechaInicioActividades.Name = "dtpFechaInicioActividades";
            dtpFechaInicioActividades.Size = new Size(148, 25);
            dtpFechaInicioActividades.TabIndex = 99;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.Transparent;
            label14.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label14.ForeColor = Color.FromArgb(64, 64, 64);
            label14.Location = new Point(4, 76);
            label14.Name = "label14";
            label14.Size = new Size(106, 16);
            label14.TabIndex = 98;
            label14.Text = "Inicio Actividades";
            // 
            // btnNuevaProvincia
            // 
            btnNuevaProvincia.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            btnNuevaProvincia.FlatStyle = FlatStyle.Flat;
            btnNuevaProvincia.ForeColor = Color.FromArgb(64, 64, 64);
            btnNuevaProvincia.IconChar = FontAwesome.Sharp.IconChar.None;
            btnNuevaProvincia.IconColor = Color.FromArgb(64, 64, 64);
            btnNuevaProvincia.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnNuevaProvincia.Location = new Point(448, 102);
            btnNuevaProvincia.Name = "btnNuevaProvincia";
            btnNuevaProvincia.Size = new Size(35, 24);
            btnNuevaProvincia.TabIndex = 97;
            btnNuevaProvincia.Text = "...";
            btnNuevaProvincia.UseVisualStyleBackColor = true;
            btnNuevaProvincia.Click += BtnNuevaProvincia_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ForeColor = Color.FromArgb(64, 64, 64);
            label12.Location = new Point(54, 106);
            label12.Name = "label12";
            label12.Size = new Size(59, 16);
            label12.TabIndex = 96;
            label12.Text = "Provincia";
            // 
            // btnNuevoIngresoBruto
            // 
            btnNuevoIngresoBruto.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            btnNuevoIngresoBruto.FlatStyle = FlatStyle.Flat;
            btnNuevoIngresoBruto.ForeColor = Color.FromArgb(64, 64, 64);
            btnNuevoIngresoBruto.IconChar = FontAwesome.Sharp.IconChar.None;
            btnNuevoIngresoBruto.IconColor = Color.FromArgb(64, 64, 64);
            btnNuevoIngresoBruto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnNuevoIngresoBruto.Location = new Point(407, 11);
            btnNuevoIngresoBruto.Name = "btnNuevoIngresoBruto";
            btnNuevoIngresoBruto.Size = new Size(35, 24);
            btnNuevoIngresoBruto.TabIndex = 95;
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
            cmbIngresoBruto.Location = new Point(119, 11);
            cmbIngresoBruto.MaxDropDownItems = 12;
            cmbIngresoBruto.Name = "cmbIngresoBruto";
            cmbIngresoBruto.Size = new Size(282, 25);
            cmbIngresoBruto.TabIndex = 94;
            // 
            // txtIngresoBruto
            // 
            txtIngresoBruto.BackColor = Color.WhiteSmoke;
            txtIngresoBruto.BorderStyle = BorderStyle.FixedSingle;
            txtIngresoBruto.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtIngresoBruto.ForeColor = Color.FromArgb(64, 64, 64);
            txtIngresoBruto.Location = new Point(448, 11);
            txtIngresoBruto.Name = "txtIngresoBruto";
            txtIngresoBruto.PlaceholderText = "Ej: 9999999";
            txtIngresoBruto.Size = new Size(127, 25);
            txtIngresoBruto.TabIndex = 93;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.FromArgb(64, 64, 64);
            label9.Location = new Point(29, 15);
            label9.Name = "label9";
            label9.Size = new Size(84, 16);
            label9.TabIndex = 92;
            label9.Text = "Ingreso Bruto";
            // 
            // cmbCondicionIva
            // 
            cmbCondicionIva.BackColor = Color.WhiteSmoke;
            cmbCondicionIva.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCondicionIva.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            cmbCondicionIva.ForeColor = Color.FromArgb(64, 64, 64);
            cmbCondicionIva.FormattingEnabled = true;
            cmbCondicionIva.ItemHeight = 17;
            cmbCondicionIva.Location = new Point(119, 42);
            cmbCondicionIva.MaxDropDownItems = 12;
            cmbCondicionIva.Name = "cmbCondicionIva";
            cmbCondicionIva.Size = new Size(323, 25);
            cmbCondicionIva.TabIndex = 89;
            // 
            // btnNuevaCondicionIva
            // 
            btnNuevaCondicionIva.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            btnNuevaCondicionIva.FlatStyle = FlatStyle.Flat;
            btnNuevaCondicionIva.ForeColor = Color.FromArgb(64, 64, 64);
            btnNuevaCondicionIva.IconChar = FontAwesome.Sharp.IconChar.None;
            btnNuevaCondicionIva.IconColor = Color.FromArgb(64, 64, 64);
            btnNuevaCondicionIva.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnNuevaCondicionIva.Location = new Point(448, 42);
            btnNuevaCondicionIva.Name = "btnNuevaCondicionIva";
            btnNuevaCondicionIva.Size = new Size(35, 24);
            btnNuevaCondicionIva.TabIndex = 91;
            btnNuevaCondicionIva.Text = "...";
            btnNuevaCondicionIva.UseVisualStyleBackColor = true;
            btnNuevaCondicionIva.Click += BtnNuevaCondicionIva_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = Color.FromArgb(64, 64, 64);
            label11.Location = new Point(12, 46);
            label11.Name = "label11";
            label11.Size = new Size(101, 16);
            label11.TabIndex = 90;
            label11.Text = "Condición de Iva";
            // 
            // CtrolAsistenteEmpresa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tabControl1);
            Controls.Add(CtrolFoto);
            Controls.Add(label2);
            Controls.Add(pnlLinea);
            Controls.Add(label1);
            Controls.Add(txtDescripcion);
            Name = "CtrolAsistenteEmpresa";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDescripcion;
        private Label label1;
        private Panel pnlLinea;
        private Label label2;
        private Foto.SidkenuFoto CtrolFoto;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TextBox txtDireccion;
        private TextBox txtAbreviatura;
        private TextBox txtCodigo;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox txtCorreoElectronico;
        private TextBox txtTelefono;
        private TextBox txtCuit;
        private Label label8;
        private Label label7;
        private Label label6;
        private TextBox txtReferente;
        private Label label10;
        private FontAwesome.Sharp.IconButton btnNuevoIngresoBruto;
        private ComboBox cmbIngresoBruto;
        private TextBox txtIngresoBruto;
        private Label label9;
        private ComboBox cmbCondicionIva;
        private FontAwesome.Sharp.IconButton btnNuevaCondicionIva;
        private Label label11;
        private ComboBox cmbProvincia;
        private DateTimePicker dtpFechaInicioActividades;
        private Label label14;
        private FontAwesome.Sharp.IconButton btnNuevaProvincia;
        private Label label12;
        private ComboBox cmbLocalidad;
        private FontAwesome.Sharp.IconButton btnNuevaLocalidad;
        private Label label13;
    }
}
