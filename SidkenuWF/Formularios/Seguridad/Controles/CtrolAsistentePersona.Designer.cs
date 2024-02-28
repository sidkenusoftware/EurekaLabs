namespace SidkenuWF.Formularios.Base.Controles
{
    partial class CtrolAsistentePersona
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CtrolAsistentePersona));
            label2 = new Label();
            pnlLinea = new Panel();
            label1 = new Label();
            txtNombre = new TextBox();
            CtrolFoto = new Foto.SidkenuFoto();
            txtApellido = new TextBox();
            label3 = new Label();
            txtTelefono = new TextBox();
            txtCuil = new TextBox();
            txtDireccion = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            dtpFechaNacimiento = new DateTimePicker();
            label14 = new Label();
            txtCorreoElectronico = new TextBox();
            label8 = new Label();
            lblAnuncio = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(21, 11);
            label2.Name = "label2";
            label2.Size = new Size(368, 32);
            label2.TabIndex = 5;
            label2.Text = "Datos del Dueño de la Compañia";
            // 
            // pnlLinea
            // 
            pnlLinea.BackColor = Color.Silver;
            pnlLinea.Location = new Point(18, 51);
            pnlLinea.Name = "pnlLinea";
            pnlLinea.Size = new Size(737, 1);
            pnlLinea.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(18, 72);
            label1.Name = "label1";
            label1.Size = new Size(52, 16);
            label1.TabIndex = 7;
            label1.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.WhiteSmoke;
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombre.Location = new Point(18, 91);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Ej: Cristian";
            txtNombre.Size = new Size(586, 39);
            txtNombre.TabIndex = 9;
            // 
            // CtrolFoto
            // 
            CtrolFoto.BackColor = Color.WhiteSmoke;
            CtrolFoto.Imagen = (Image)resources.GetObject("CtrolFoto.Imagen");
            CtrolFoto.Location = new Point(625, 72);
            CtrolFoto.MinimumSize = new Size(130, 157);
            CtrolFoto.Name = "CtrolFoto";
            CtrolFoto.Size = new Size(130, 188);
            CtrolFoto.TabIndex = 10;
            // 
            // txtApellido
            // 
            txtApellido.BackColor = Color.WhiteSmoke;
            txtApellido.BorderStyle = BorderStyle.FixedSingle;
            txtApellido.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtApellido.Location = new Point(18, 158);
            txtApellido.Name = "txtApellido";
            txtApellido.PlaceholderText = "Ej: Apellido";
            txtApellido.Size = new Size(586, 39);
            txtApellido.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(18, 139);
            label3.Name = "label3";
            label3.Size = new Size(53, 16);
            label3.TabIndex = 11;
            label3.Text = "Apellido";
            // 
            // txtTelefono
            // 
            txtTelefono.BackColor = Color.WhiteSmoke;
            txtTelefono.BorderStyle = BorderStyle.FixedSingle;
            txtTelefono.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtTelefono.ForeColor = Color.FromArgb(64, 64, 64);
            txtTelefono.Location = new Point(411, 249);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.PlaceholderText = "Ej: 999-9999999";
            txtTelefono.Size = new Size(193, 25);
            txtTelefono.TabIndex = 85;
            // 
            // txtCuil
            // 
            txtCuil.BackColor = Color.WhiteSmoke;
            txtCuil.BorderStyle = BorderStyle.FixedSingle;
            txtCuil.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtCuil.ForeColor = Color.FromArgb(64, 64, 64);
            txtCuil.Location = new Point(141, 249);
            txtCuil.Name = "txtCuil";
            txtCuil.PlaceholderText = "Ej: 99-99999999-9";
            txtCuil.Size = new Size(169, 25);
            txtCuil.TabIndex = 84;
            // 
            // txtDireccion
            // 
            txtDireccion.BackColor = Color.WhiteSmoke;
            txtDireccion.BorderStyle = BorderStyle.FixedSingle;
            txtDireccion.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtDireccion.ForeColor = Color.FromArgb(64, 64, 64);
            txtDireccion.Location = new Point(141, 218);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.PlaceholderText = "Ej: Sarmiento 134";
            txtDireccion.Size = new Size(463, 25);
            txtDireccion.TabIndex = 83;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(64, 64, 64);
            label7.Location = new Point(351, 252);
            label7.Name = "label7";
            label7.Size = new Size(54, 16);
            label7.TabIndex = 82;
            label7.Text = "Teléfono";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(64, 64, 64);
            label6.Location = new Point(100, 249);
            label6.Name = "label6";
            label6.Size = new Size(35, 16);
            label6.TabIndex = 81;
            label6.Text = "CUIL";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(64, 64, 64);
            label5.Location = new Point(74, 221);
            label5.Name = "label5";
            label5.Size = new Size(61, 16);
            label5.TabIndex = 80;
            label5.Text = "Direccion";
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dtpFechaNacimiento.Format = DateTimePickerFormat.Short;
            dtpFechaNacimiento.Location = new Point(141, 311);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(148, 25);
            dtpFechaNacimiento.TabIndex = 89;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.Transparent;
            label14.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label14.ForeColor = Color.FromArgb(64, 64, 64);
            label14.Location = new Point(23, 316);
            label14.Name = "label14";
            label14.Size = new Size(112, 16);
            label14.TabIndex = 88;
            label14.Text = "Fecha Nacimiento";
            // 
            // txtCorreoElectronico
            // 
            txtCorreoElectronico.BackColor = Color.WhiteSmoke;
            txtCorreoElectronico.BorderStyle = BorderStyle.FixedSingle;
            txtCorreoElectronico.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtCorreoElectronico.ForeColor = Color.FromArgb(64, 64, 64);
            txtCorreoElectronico.Location = new Point(141, 280);
            txtCorreoElectronico.Name = "txtCorreoElectronico";
            txtCorreoElectronico.PlaceholderText = "Ej: sidkenusoftware@gmail.com";
            txtCorreoElectronico.Size = new Size(463, 25);
            txtCorreoElectronico.TabIndex = 87;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(64, 64, 64);
            label8.Location = new Point(21, 283);
            label8.Name = "label8";
            label8.Size = new Size(114, 16);
            label8.TabIndex = 86;
            label8.Text = "Correo Electrónico";
            // 
            // lblAnuncio
            // 
            lblAnuncio.BackColor = Color.Gainsboro;
            lblAnuncio.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblAnuncio.ForeColor = Color.FromArgb(192, 64, 0);
            lblAnuncio.Location = new Point(295, 312);
            lblAnuncio.Name = "lblAnuncio";
            lblAnuncio.Size = new Size(482, 32);
            lblAnuncio.TabIndex = 90;
            lblAnuncio.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CtrolAsistentePersona
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblAnuncio);
            Controls.Add(dtpFechaNacimiento);
            Controls.Add(label14);
            Controls.Add(txtCorreoElectronico);
            Controls.Add(label8);
            Controls.Add(txtTelefono);
            Controls.Add(txtCuil);
            Controls.Add(txtDireccion);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtApellido);
            Controls.Add(label3);
            Controls.Add(CtrolFoto);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(pnlLinea);
            Name = "CtrolAsistentePersona";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Panel pnlLinea;
        private Label label1;
        private TextBox txtNombre;
        private Foto.SidkenuFoto CtrolFoto;
        private TextBox txtApellido;
        private Label label3;
        private TextBox txtTelefono;
        private TextBox txtCuil;
        private TextBox txtDireccion;
        private Label label7;
        private Label label6;
        private Label label5;
        private DateTimePicker dtpFechaNacimiento;
        private Label label14;
        private TextBox txtCorreoElectronico;
        private Label label8;
        private Label lblAnuncio;
    }
}
