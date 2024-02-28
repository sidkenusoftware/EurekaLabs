namespace SidkenuWF.Formularios.Core.Varios
{
    partial class AgregarArticulosFabricacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarArticulosFabricacion));
            pnlBotonera = new Panel();
            btnEjecutar = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            txtDescripcionTemp = new TextBox();
            label5 = new Label();
            txtCodigoTemp = new TextBox();
            Foto = new Base.Controles.Foto.SidkenuFoto();
            tabControlDetalle = new TabControl();
            tabPage1 = new TabPage();
            nudTotal = new NumericUpDown();
            label4 = new Label();
            nudCantidad = new NumericUpDown();
            label2 = new Label();
            label32 = new Label();
            txtCodigo = new TextBox();
            dgvGrilla = new DataGridView();
            btnQuitarArticulo = new FontAwesome.Sharp.IconButton();
            btnAgregarArticulo = new FontAwesome.Sharp.IconButton();
            btnBuscarArticulo = new FontAwesome.Sharp.IconButton();
            label31 = new Label();
            txtDescripcion = new TextBox();
            label3 = new Label();
            nudCantidadTotal = new NumericUpDown();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            dtpFechaEntrega = new DateTimePicker();
            label6 = new Label();
            pnlBotonera.SuspendLayout();
            tabControlDetalle.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudTotal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvGrilla).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudCantidadTotal).BeginInit();
            SuspendLayout();
            // 
            // pnlBotonera
            // 
            pnlBotonera.BackColor = Color.FromArgb(48, 66, 80);
            pnlBotonera.Controls.Add(btnEjecutar);
            pnlBotonera.Dock = DockStyle.Bottom;
            pnlBotonera.Location = new Point(0, 589);
            pnlBotonera.Name = "pnlBotonera";
            pnlBotonera.Size = new Size(696, 40);
            pnlBotonera.TabIndex = 3;
            // 
            // btnEjecutar
            // 
            btnEjecutar.BackColor = Color.FromArgb(54, 74, 90);
            btnEjecutar.FlatAppearance.BorderColor = Color.WhiteSmoke;
            btnEjecutar.FlatAppearance.BorderSize = 0;
            btnEjecutar.FlatStyle = FlatStyle.Flat;
            btnEjecutar.ForeColor = Color.WhiteSmoke;
            btnEjecutar.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            btnEjecutar.IconColor = Color.WhiteSmoke;
            btnEjecutar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEjecutar.IconSize = 22;
            btnEjecutar.Location = new Point(10, 4);
            btnEjecutar.Name = "btnEjecutar";
            btnEjecutar.Size = new Size(223, 32);
            btnEjecutar.TabIndex = 2;
            btnEjecutar.Text = "Agregar Detalle de Factura";
            btnEjecutar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEjecutar.UseVisualStyleBackColor = false;
            btnEjecutar.Click += BtnEjecutar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(15, 137);
            label1.Name = "label1";
            label1.Size = new Size(99, 16);
            label1.TabIndex = 28;
            label1.Text = "Nombre Artículo";
            // 
            // txtDescripcionTemp
            // 
            txtDescripcionTemp.BackColor = Color.WhiteSmoke;
            txtDescripcionTemp.BorderStyle = BorderStyle.FixedSingle;
            txtDescripcionTemp.Font = new Font("Arial", 24F, FontStyle.Regular, GraphicsUnit.Point);
            txtDescripcionTemp.ForeColor = Color.FromArgb(64, 64, 64);
            txtDescripcionTemp.Location = new Point(16, 156);
            txtDescripcionTemp.Name = "txtDescripcionTemp";
            txtDescripcionTemp.Size = new Size(364, 44);
            txtDescripcionTemp.TabIndex = 27;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(64, 64, 64);
            label5.Location = new Point(16, 75);
            label5.Name = "label5";
            label5.Size = new Size(47, 16);
            label5.TabIndex = 116;
            label5.Text = "Código";
            // 
            // txtCodigoTemp
            // 
            txtCodigoTemp.BackColor = Color.FromArgb(64, 64, 64);
            txtCodigoTemp.BorderStyle = BorderStyle.FixedSingle;
            txtCodigoTemp.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtCodigoTemp.ForeColor = Color.White;
            txtCodigoTemp.Location = new Point(16, 94);
            txtCodigoTemp.Name = "txtCodigoTemp";
            txtCodigoTemp.ReadOnly = true;
            txtCodigoTemp.Size = new Size(136, 29);
            txtCodigoTemp.TabIndex = 115;
            txtCodigoTemp.TextAlign = HorizontalAlignment.Center;
            // 
            // Foto
            // 
            Foto.BackColor = Color.WhiteSmoke;
            Foto.Imagen = (Image)resources.GetObject("Foto.Imagen");
            Foto.Location = new Point(554, 71);
            Foto.MinimumSize = new Size(130, 157);
            Foto.Name = "Foto";
            Foto.Size = new Size(130, 188);
            Foto.TabIndex = 117;
            // 
            // tabControlDetalle
            // 
            tabControlDetalle.Controls.Add(tabPage1);
            tabControlDetalle.Enabled = false;
            tabControlDetalle.Location = new Point(16, 247);
            tabControlDetalle.Name = "tabControlDetalle";
            tabControlDetalle.SelectedIndex = 0;
            tabControlDetalle.Size = new Size(671, 294);
            tabControlDetalle.TabIndex = 118;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(nudTotal);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(nudCantidad);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label32);
            tabPage1.Controls.Add(txtCodigo);
            tabPage1.Controls.Add(dgvGrilla);
            tabPage1.Controls.Add(btnQuitarArticulo);
            tabPage1.Controls.Add(btnAgregarArticulo);
            tabPage1.Controls.Add(btnBuscarArticulo);
            tabPage1.Controls.Add(label31);
            tabPage1.Controls.Add(txtDescripcion);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(663, 266);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Composición";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // nudTotal
            // 
            nudTotal.Anchor = AnchorStyles.Left;
            nudTotal.BackColor = Color.FromArgb(64, 64, 64);
            nudTotal.DecimalPlaces = 2;
            nudTotal.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            nudTotal.ForeColor = Color.White;
            nudTotal.Location = new Point(457, 224);
            nudTotal.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            nudTotal.Name = "nudTotal";
            nudTotal.Size = new Size(200, 35);
            nudTotal.TabIndex = 142;
            nudTotal.TextAlign = HorizontalAlignment.Right;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Location = new Point(433, 17);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 141;
            label4.Text = "Cantidad";
            // 
            // nudCantidad
            // 
            nudCantidad.Anchor = AnchorStyles.Left;
            nudCantidad.DecimalPlaces = 2;
            nudCantidad.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            nudCantidad.Location = new Point(433, 35);
            nudCantidad.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(92, 29);
            nudCantidad.TabIndex = 140;
            nudCantidad.KeyDown += NudCantidad_KeyDown;
            nudCantidad.KeyPress += NudCantidad_KeyPress;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(311, 230);
            label2.Name = "label2";
            label2.Size = new Size(140, 25);
            label2.TabIndex = 139;
            label2.Text = "Precio Público";
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.Location = new Point(17, 15);
            label32.Name = "label32";
            label32.Size = new Size(46, 15);
            label32.TabIndex = 137;
            label32.Text = "Código";
            // 
            // txtCodigo
            // 
            txtCodigo.BackColor = Color.WhiteSmoke;
            txtCodigo.BorderStyle = BorderStyle.FixedSingle;
            txtCodigo.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtCodigo.ForeColor = Color.FromArgb(64, 64, 64);
            txtCodigo.Location = new Point(17, 35);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(78, 29);
            txtCodigo.TabIndex = 136;
            txtCodigo.KeyDown += TxtCodigo_KeyDown;
            txtCodigo.KeyPress += TxtCodigo_KeyPress;
            // 
            // dgvGrilla
            // 
            dgvGrilla.BackgroundColor = Color.White;
            dgvGrilla.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGrilla.Location = new Point(17, 70);
            dgvGrilla.Name = "dgvGrilla";
            dgvGrilla.ReadOnly = true;
            dgvGrilla.RowHeadersVisible = false;
            dgvGrilla.RowTemplate.Height = 25;
            dgvGrilla.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGrilla.Size = new Size(640, 148);
            dgvGrilla.TabIndex = 135;
            // 
            // btnQuitarArticulo
            // 
            btnQuitarArticulo.FlatAppearance.BorderColor = Color.Gray;
            btnQuitarArticulo.FlatStyle = FlatStyle.Flat;
            btnQuitarArticulo.IconChar = FontAwesome.Sharp.IconChar.Trash;
            btnQuitarArticulo.IconColor = Color.Black;
            btnQuitarArticulo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnQuitarArticulo.IconSize = 25;
            btnQuitarArticulo.Location = new Point(625, 35);
            btnQuitarArticulo.Name = "btnQuitarArticulo";
            btnQuitarArticulo.Size = new Size(30, 29);
            btnQuitarArticulo.TabIndex = 134;
            btnQuitarArticulo.UseVisualStyleBackColor = true;
            // 
            // btnAgregarArticulo
            // 
            btnAgregarArticulo.FlatAppearance.BorderColor = Color.Gray;
            btnAgregarArticulo.FlatStyle = FlatStyle.Flat;
            btnAgregarArticulo.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            btnAgregarArticulo.IconColor = Color.Black;
            btnAgregarArticulo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAgregarArticulo.IconSize = 25;
            btnAgregarArticulo.Location = new Point(591, 35);
            btnAgregarArticulo.Name = "btnAgregarArticulo";
            btnAgregarArticulo.Size = new Size(30, 29);
            btnAgregarArticulo.TabIndex = 133;
            btnAgregarArticulo.UseVisualStyleBackColor = true;
            btnAgregarArticulo.Click += BtnAgregarArticulo_Click;
            // 
            // btnBuscarArticulo
            // 
            btnBuscarArticulo.FlatAppearance.BorderColor = Color.Gray;
            btnBuscarArticulo.FlatStyle = FlatStyle.Flat;
            btnBuscarArticulo.IconChar = FontAwesome.Sharp.IconChar.None;
            btnBuscarArticulo.IconColor = Color.Black;
            btnBuscarArticulo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBuscarArticulo.Location = new Point(531, 35);
            btnBuscarArticulo.Name = "btnBuscarArticulo";
            btnBuscarArticulo.Size = new Size(54, 29);
            btnBuscarArticulo.TabIndex = 132;
            btnBuscarArticulo.Text = "Buscar";
            btnBuscarArticulo.UseVisualStyleBackColor = true;
            btnBuscarArticulo.Click += BtnBuscarArticulo_Click;
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Location = new Point(101, 15);
            label31.Name = "label31";
            label31.Size = new Size(115, 15);
            label31.TabIndex = 131;
            label31.Text = "Nombre del Artículo";
            // 
            // txtDescripcion
            // 
            txtDescripcion.BackColor = Color.WhiteSmoke;
            txtDescripcion.BorderStyle = BorderStyle.FixedSingle;
            txtDescripcion.Enabled = false;
            txtDescripcion.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtDescripcion.ForeColor = Color.FromArgb(64, 64, 64);
            txtDescripcion.Location = new Point(101, 35);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(326, 29);
            txtDescripcion.TabIndex = 130;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Location = new Point(386, 137);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 143;
            label3.Text = "Cantidad";
            // 
            // nudCantidadTotal
            // 
            nudCantidadTotal.Anchor = AnchorStyles.Left;
            nudCantidadTotal.DecimalPlaces = 2;
            nudCantidadTotal.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            nudCantidadTotal.Location = new Point(386, 156);
            nudCantidadTotal.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            nudCantidadTotal.Name = "nudCantidadTotal";
            nudCantidadTotal.Size = new Size(150, 46);
            nudCantidadTotal.TabIndex = 142;
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.FromArgb(54, 74, 90);
            iconButton1.FlatAppearance.BorderColor = Color.WhiteSmoke;
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.ForeColor = Color.WhiteSmoke;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.ArrowDown;
            iconButton1.IconColor = Color.WhiteSmoke;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 22;
            iconButton1.Location = new Point(386, 208);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(150, 33);
            iconButton1.TabIndex = 144;
            iconButton1.Text = "  Agregar Items";
            iconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton1.UseVisualStyleBackColor = false;
            iconButton1.Click += BtnAgregarItem_Click;
            // 
            // dtpFechaEntrega
            // 
            dtpFechaEntrega.CalendarFont = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dtpFechaEntrega.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtpFechaEntrega.Format = DateTimePickerFormat.Short;
            dtpFechaEntrega.Location = new Point(180, 94);
            dtpFechaEntrega.Name = "dtpFechaEntrega";
            dtpFechaEntrega.Size = new Size(200, 29);
            dtpFechaEntrega.TabIndex = 145;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(64, 64, 64);
            label6.Location = new Point(180, 71);
            label6.Name = "label6";
            label6.Size = new Size(187, 16);
            label6.TabIndex = 146;
            label6.Text = "Fecha Compromiso de Entrega";
            // 
            // AgregarArticulosFabricacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(696, 629);
            Controls.Add(label6);
            Controls.Add(dtpFechaEntrega);
            Controls.Add(iconButton1);
            Controls.Add(label3);
            Controls.Add(nudCantidadTotal);
            Controls.Add(Foto);
            Controls.Add(label5);
            Controls.Add(txtCodigoTemp);
            Controls.Add(label1);
            Controls.Add(txtDescripcionTemp);
            Controls.Add(pnlBotonera);
            Controls.Add(tabControlDetalle);
            MaximumSize = new Size(712, 668);
            MinimumSize = new Size(712, 668);
            Name = "AgregarArticulosFabricacion";
            Text = "Agregar Articulo";
            Load += AgregarArticulosFabricacion_Load;
            Shown += AgregarArticulosFabricacion_Shown;
            Controls.SetChildIndex(tabControlDetalle, 0);
            Controls.SetChildIndex(pnlBotonera, 0);
            Controls.SetChildIndex(txtDescripcionTemp, 0);
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(txtCodigoTemp, 0);
            Controls.SetChildIndex(label5, 0);
            Controls.SetChildIndex(Foto, 0);
            Controls.SetChildIndex(nudCantidadTotal, 0);
            Controls.SetChildIndex(label3, 0);
            Controls.SetChildIndex(iconButton1, 0);
            Controls.SetChildIndex(dtpFechaEntrega, 0);
            Controls.SetChildIndex(label6, 0);
            pnlBotonera.ResumeLayout(false);
            tabControlDetalle.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudTotal).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvGrilla).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudCantidadTotal).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlBotonera;
        private FontAwesome.Sharp.IconButton btnEjecutar;
        private Label label1;
        private TextBox txtDescripcionTemp;
        private Label label5;
        private TextBox txtCodigoTemp;
        private Base.Controles.Foto.SidkenuFoto Foto;
        private TabControl tabControlDetalle;
        private TabPage tabPage1;
        private Label label32;
        private TextBox txtCodigo;
        private DataGridView dgvGrilla;
        private FontAwesome.Sharp.IconButton btnQuitarArticulo;
        private FontAwesome.Sharp.IconButton btnAgregarArticulo;
        private FontAwesome.Sharp.IconButton btnBuscarArticulo;
        private Label label31;
        private TextBox txtDescripcion;
        private Label label2;
        private Label label4;
        private NumericUpDown nudCantidad;
        private NumericUpDown nudTotal;
        private Label label3;
        private NumericUpDown nudCantidadTotal;
        private FontAwesome.Sharp.IconButton iconButton1;
        private DateTimePicker dtpFechaEntrega;
        private Label label6;
    }
}