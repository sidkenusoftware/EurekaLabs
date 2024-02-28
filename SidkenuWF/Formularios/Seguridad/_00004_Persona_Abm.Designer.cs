namespace SidkenuWF.Formularios.Seguridad
{
    partial class _00004_Persona_Abm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_00004_Persona_Abm));
            ctrolFoto = new Base.Controles.Foto.SidkenuFoto();
            label1 = new Label();
            txtApellido = new TextBox();
            tabPageInformacionGeneral = new TabPage();
            dtpFechaNacimiento = new DateTimePicker();
            label14 = new Label();
            txtCorreoElectronico = new TextBox();
            txtTelefono = new TextBox();
            txtCuil = new TextBox();
            txtDireccion = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            tabCtrolDatos = new TabControl();
            label2 = new Label();
            txtNombre = new TextBox();
            tabPageInformacionGeneral.SuspendLayout();
            tabCtrolDatos.SuspendLayout();
            SuspendLayout();
            // 
            // ctrolFoto
            // 
            ctrolFoto.BackColor = Color.WhiteSmoke;
            ctrolFoto.Imagen = (Image)resources.GetObject("ctrolFoto.Imagen");
            ctrolFoto.Location = new Point(457, 77);
            ctrolFoto.MinimumSize = new Size(130, 157);
            ctrolFoto.Name = "ctrolFoto";
            ctrolFoto.Size = new Size(130, 188);
            ctrolFoto.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(29, 82);
            label1.Name = "label1";
            label1.Size = new Size(53, 16);
            label1.TabIndex = 17;
            label1.Text = "Apellido";
            // 
            // txtApellido
            // 
            txtApellido.BackColor = Color.WhiteSmoke;
            txtApellido.BorderStyle = BorderStyle.FixedSingle;
            txtApellido.Font = new Font("Arial", 24F, FontStyle.Regular, GraphicsUnit.Point);
            txtApellido.ForeColor = Color.FromArgb(64, 64, 64);
            txtApellido.Location = new Point(26, 103);
            txtApellido.Name = "txtApellido";
            txtApellido.PlaceholderText = "Ej: Daud";
            txtApellido.Size = new Size(417, 44);
            txtApellido.TabIndex = 16;
            // 
            // tabPageInformacionGeneral
            // 
            tabPageInformacionGeneral.BackColor = Color.White;
            tabPageInformacionGeneral.Controls.Add(dtpFechaNacimiento);
            tabPageInformacionGeneral.Controls.Add(label14);
            tabPageInformacionGeneral.Controls.Add(txtCorreoElectronico);
            tabPageInformacionGeneral.Controls.Add(txtTelefono);
            tabPageInformacionGeneral.Controls.Add(txtCuil);
            tabPageInformacionGeneral.Controls.Add(txtDireccion);
            tabPageInformacionGeneral.Controls.Add(label8);
            tabPageInformacionGeneral.Controls.Add(label7);
            tabPageInformacionGeneral.Controls.Add(label6);
            tabPageInformacionGeneral.Controls.Add(label5);
            tabPageInformacionGeneral.Location = new Point(4, 38);
            tabPageInformacionGeneral.Name = "tabPageInformacionGeneral";
            tabPageInformacionGeneral.Padding = new Padding(3);
            tabPageInformacionGeneral.Size = new Size(559, 242);
            tabPageInformacionGeneral.TabIndex = 0;
            tabPageInformacionGeneral.Text = "Información General";
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dtpFechaNacimiento.Format = DateTimePickerFormat.Short;
            dtpFechaNacimiento.Location = new Point(18, 204);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(148, 25);
            dtpFechaNacimiento.TabIndex = 84;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.Transparent;
            label14.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label14.ForeColor = Color.FromArgb(64, 64, 64);
            label14.Location = new Point(18, 185);
            label14.Name = "label14";
            label14.Size = new Size(112, 16);
            label14.TabIndex = 83;
            label14.Text = "Fecha Nacimiento";
            // 
            // txtCorreoElectronico
            // 
            txtCorreoElectronico.BackColor = Color.WhiteSmoke;
            txtCorreoElectronico.BorderStyle = BorderStyle.FixedSingle;
            txtCorreoElectronico.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtCorreoElectronico.ForeColor = Color.FromArgb(64, 64, 64);
            txtCorreoElectronico.Location = new Point(18, 146);
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
            txtTelefono.Location = new Point(196, 90);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.PlaceholderText = "Ej: 999-9999999";
            txtTelefono.Size = new Size(193, 25);
            txtTelefono.TabIndex = 79;
            // 
            // txtCuil
            // 
            txtCuil.BackColor = Color.WhiteSmoke;
            txtCuil.BorderStyle = BorderStyle.FixedSingle;
            txtCuil.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtCuil.ForeColor = Color.FromArgb(64, 64, 64);
            txtCuil.Location = new Point(18, 90);
            txtCuil.Name = "txtCuil";
            txtCuil.PlaceholderText = "Ej: 99-99999999-9";
            txtCuil.Size = new Size(169, 25);
            txtCuil.TabIndex = 78;
            // 
            // txtDireccion
            // 
            txtDireccion.BackColor = Color.WhiteSmoke;
            txtDireccion.BorderStyle = BorderStyle.FixedSingle;
            txtDireccion.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtDireccion.ForeColor = Color.FromArgb(64, 64, 64);
            txtDireccion.Location = new Point(18, 27);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.PlaceholderText = "Ej: Sarmiento 134";
            txtDireccion.Size = new Size(521, 25);
            txtDireccion.TabIndex = 77;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(64, 64, 64);
            label8.Location = new Point(24, 127);
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
            label7.Location = new Point(199, 70);
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
            label6.Location = new Point(24, 70);
            label6.Name = "label6";
            label6.Size = new Size(35, 16);
            label6.TabIndex = 72;
            label6.Text = "CUIL";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(64, 64, 64);
            label5.Location = new Point(24, 11);
            label5.Name = "label5";
            label5.Size = new Size(61, 16);
            label5.TabIndex = 71;
            label5.Text = "Direccion";
            // 
            // tabCtrolDatos
            // 
            tabCtrolDatos.Controls.Add(tabPageInformacionGeneral);
            tabCtrolDatos.Location = new Point(22, 261);
            tabCtrolDatos.Name = "tabCtrolDatos";
            tabCtrolDatos.Padding = new Point(20, 10);
            tabCtrolDatos.SelectedIndex = 0;
            tabCtrolDatos.Size = new Size(567, 284);
            tabCtrolDatos.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(64, 64, 64);
            label2.Location = new Point(29, 157);
            label2.Name = "label2";
            label2.Size = new Size(52, 16);
            label2.TabIndex = 20;
            label2.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.WhiteSmoke;
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.Font = new Font("Arial", 24F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombre.ForeColor = Color.FromArgb(64, 64, 64);
            txtNombre.Location = new Point(26, 178);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Ej: Cristian";
            txtNombre.Size = new Size(417, 44);
            txtNombre.TabIndex = 19;
            // 
            // _00004_Persona_Abm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(610, 608);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(ctrolFoto);
            Controls.Add(label1);
            Controls.Add(txtApellido);
            Controls.Add(tabCtrolDatos);
            MaximumSize = new Size(626, 647);
            MinimumSize = new Size(626, 647);
            Name = "_00004_Persona_Abm";
            Controls.SetChildIndex(tabCtrolDatos, 0);
            Controls.SetChildIndex(txtApellido, 0);
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(ctrolFoto, 0);
            Controls.SetChildIndex(txtNombre, 0);
            Controls.SetChildIndex(label2, 0);
            tabPageInformacionGeneral.ResumeLayout(false);
            tabPageInformacionGeneral.PerformLayout();
            tabCtrolDatos.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Base.Controles.Foto.SidkenuFoto ctrolFoto;
        private Label label1;
        private TextBox txtApellido;
        private TabPage tabPageInformacionGeneral;
        private TextBox txtCorreoElectronico;
        private TextBox txtTelefono;
        private TextBox txtCuil;
        private TextBox txtDireccion;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private TabControl tabCtrolDatos;
        private Label label2;
        private TextBox txtNombre;
        private DateTimePicker dtpFechaNacimiento;
        private Label label14;
    }
}