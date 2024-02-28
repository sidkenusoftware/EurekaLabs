namespace SidkenuWF.Formularios.Core
{
    partial class _00127_Marca_Abm
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
            panel1 = new Panel();
            label4 = new Label();
            label3 = new Label();
            chkEmpresa = new Base.Controles.SidkenuToggleButton();
            label2 = new Label();
            txtCodigo = new TextBox();
            label1 = new Label();
            txtDescripcion = new TextBox();
            chkAumentoPrecioPublico = new Base.Controles.SidkenuToggleButton();
            cmbTipoAumentoPrecioPublico = new ComboBox();
            nudAumentoPrecioPublico = new NumericUpDown();
            panel2 = new Panel();
            label5 = new Label();
            panel3 = new Panel();
            nudAumentoPrecioPublicoListaPrecio = new NumericUpDown();
            chkAumentoPrecioPublicoListaPrecio = new Base.Controles.SidkenuToggleButton();
            label6 = new Label();
            cmbTipoAumentoPrecioPublicoListaPrecio = new ComboBox();
            lblActivarIncrementoPrecio = new Label();
            lblActivarIncrementoPrecioListaPrecio = new Label();
            ((System.ComponentModel.ISupportInitialize)nudAumentoPrecioPublico).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudAumentoPrecioPublicoListaPrecio).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.BackColor = Color.LightGray;
            panel1.Location = new Point(12, 345);
            panel1.Name = "panel1";
            panel1.Size = new Size(522, 1);
            panel1.TabIndex = 180;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(192, 0, 0);
            label4.Location = new Point(251, 351);
            label4.Name = "label4";
            label4.Size = new Size(280, 56);
            label4.TabIndex = 179;
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
            label3.Location = new Point(57, 371);
            label3.Name = "label3";
            label3.Size = new Size(186, 16);
            label3.TabIndex = 178;
            label3.Text = "Pertenece solo a una Empresa";
            // 
            // chkEmpresa
            // 
            chkEmpresa.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            chkEmpresa.AutoSize = true;
            chkEmpresa.Location = new Point(12, 368);
            chkEmpresa.MinimumSize = new Size(45, 22);
            chkEmpresa.Name = "chkEmpresa";
            chkEmpresa.OffBackColor = Color.Gray;
            chkEmpresa.OffToggleColor = Color.Gainsboro;
            chkEmpresa.OnBackColor = Color.Green;
            chkEmpresa.OnToggleColor = Color.WhiteSmoke;
            chkEmpresa.Size = new Size(45, 22);
            chkEmpresa.TabIndex = 177;
            chkEmpresa.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(64, 64, 64);
            label2.Location = new Point(18, 71);
            label2.Name = "label2";
            label2.Size = new Size(47, 16);
            label2.TabIndex = 176;
            label2.Text = "Codigo";
            // 
            // txtCodigo
            // 
            txtCodigo.BackColor = Color.WhiteSmoke;
            txtCodigo.BorderStyle = BorderStyle.FixedSingle;
            txtCodigo.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtCodigo.ForeColor = Color.FromArgb(64, 64, 64);
            txtCodigo.Location = new Point(15, 92);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(158, 29);
            txtCodigo.TabIndex = 173;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(18, 132);
            label1.Name = "label1";
            label1.Size = new Size(92, 16);
            label1.TabIndex = 175;
            label1.Text = "Nombre Marca";
            // 
            // txtDescripcion
            // 
            txtDescripcion.BackColor = Color.WhiteSmoke;
            txtDescripcion.BorderStyle = BorderStyle.FixedSingle;
            txtDescripcion.Font = new Font("Arial", 24F, FontStyle.Regular, GraphicsUnit.Point);
            txtDescripcion.ForeColor = Color.FromArgb(64, 64, 64);
            txtDescripcion.Location = new Point(15, 153);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(516, 44);
            txtDescripcion.TabIndex = 174;
            // 
            // chkAumentoPrecioPublico
            // 
            chkAumentoPrecioPublico.AutoSize = true;
            chkAumentoPrecioPublico.Location = new Point(17, 220);
            chkAumentoPrecioPublico.MinimumSize = new Size(45, 22);
            chkAumentoPrecioPublico.Name = "chkAumentoPrecioPublico";
            chkAumentoPrecioPublico.OffBackColor = Color.Gray;
            chkAumentoPrecioPublico.OffToggleColor = Color.Gainsboro;
            chkAumentoPrecioPublico.OnBackColor = Color.Green;
            chkAumentoPrecioPublico.OnToggleColor = Color.WhiteSmoke;
            chkAumentoPrecioPublico.Size = new Size(45, 22);
            chkAumentoPrecioPublico.TabIndex = 181;
            chkAumentoPrecioPublico.UseVisualStyleBackColor = true;
            chkAumentoPrecioPublico.CheckedChanged += ChkAumentoPrecioPublico_CheckedChanged;
            // 
            // cmbTipoAumentoPrecioPublico
            // 
            cmbTipoAumentoPrecioPublico.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoAumentoPrecioPublico.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbTipoAumentoPrecioPublico.FormattingEnabled = true;
            cmbTipoAumentoPrecioPublico.Location = new Point(391, 217);
            cmbTipoAumentoPrecioPublico.Name = "cmbTipoAumentoPrecioPublico";
            cmbTipoAumentoPrecioPublico.Size = new Size(138, 29);
            cmbTipoAumentoPrecioPublico.TabIndex = 184;
            // 
            // nudAumentoPrecioPublico
            // 
            nudAumentoPrecioPublico.DecimalPlaces = 2;
            nudAumentoPrecioPublico.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            nudAumentoPrecioPublico.Location = new Point(254, 218);
            nudAumentoPrecioPublico.Maximum = new decimal(new int[] { -159383552, 46653770, 5421, 0 });
            nudAumentoPrecioPublico.Name = "nudAumentoPrecioPublico";
            nudAumentoPrecioPublico.Size = new Size(131, 27);
            nudAumentoPrecioPublico.TabIndex = 183;
            nudAumentoPrecioPublico.TextAlign = HorizontalAlignment.Right;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightGray;
            panel2.Location = new Point(14, 205);
            panel2.Name = "panel2";
            panel2.Size = new Size(522, 1);
            panel2.TabIndex = 185;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(64, 64, 64);
            label5.Location = new Point(71, 216);
            label5.Name = "label5";
            label5.Size = new Size(176, 32);
            label5.TabIndex = 187;
            label5.Text = "Activar Incremento del Precio\r\nde Venta al Público";
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightGray;
            panel3.Location = new Point(14, 272);
            panel3.Name = "panel3";
            panel3.Size = new Size(522, 1);
            panel3.TabIndex = 188;
            // 
            // nudAumentoPrecioPublicoListaPrecio
            // 
            nudAumentoPrecioPublicoListaPrecio.DecimalPlaces = 2;
            nudAumentoPrecioPublicoListaPrecio.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            nudAumentoPrecioPublicoListaPrecio.Location = new Point(254, 288);
            nudAumentoPrecioPublicoListaPrecio.Maximum = new decimal(new int[] { -159383552, 46653770, 5421, 0 });
            nudAumentoPrecioPublicoListaPrecio.Name = "nudAumentoPrecioPublicoListaPrecio";
            nudAumentoPrecioPublicoListaPrecio.Size = new Size(131, 27);
            nudAumentoPrecioPublicoListaPrecio.TabIndex = 190;
            nudAumentoPrecioPublicoListaPrecio.TextAlign = HorizontalAlignment.Right;
            // 
            // chkAumentoPrecioPublicoListaPrecio
            // 
            chkAumentoPrecioPublicoListaPrecio.AutoSize = true;
            chkAumentoPrecioPublicoListaPrecio.Location = new Point(17, 290);
            chkAumentoPrecioPublicoListaPrecio.MinimumSize = new Size(45, 22);
            chkAumentoPrecioPublicoListaPrecio.Name = "chkAumentoPrecioPublicoListaPrecio";
            chkAumentoPrecioPublicoListaPrecio.OffBackColor = Color.Gray;
            chkAumentoPrecioPublicoListaPrecio.OffToggleColor = Color.Gainsboro;
            chkAumentoPrecioPublicoListaPrecio.OnBackColor = Color.Green;
            chkAumentoPrecioPublicoListaPrecio.OnToggleColor = Color.WhiteSmoke;
            chkAumentoPrecioPublicoListaPrecio.Size = new Size(45, 22);
            chkAumentoPrecioPublicoListaPrecio.TabIndex = 189;
            chkAumentoPrecioPublicoListaPrecio.UseVisualStyleBackColor = true;
            chkAumentoPrecioPublicoListaPrecio.CheckedChanged += ChkAumentoPrecioPublicoImpuesto_CheckedChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(64, 64, 64);
            label6.Location = new Point(71, 277);
            label6.Name = "label6";
            label6.Size = new Size(176, 48);
            label6.TabIndex = 191;
            label6.Text = "Activar Incremento del Precio\r\nde Venta al Público \r\npor Lista de Precio";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cmbTipoAumentoPrecioPublicoListaPrecio
            // 
            cmbTipoAumentoPrecioPublicoListaPrecio.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoAumentoPrecioPublicoListaPrecio.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbTipoAumentoPrecioPublicoListaPrecio.FormattingEnabled = true;
            cmbTipoAumentoPrecioPublicoListaPrecio.Location = new Point(391, 287);
            cmbTipoAumentoPrecioPublicoListaPrecio.Name = "cmbTipoAumentoPrecioPublicoListaPrecio";
            cmbTipoAumentoPrecioPublicoListaPrecio.Size = new Size(138, 29);
            cmbTipoAumentoPrecioPublicoListaPrecio.TabIndex = 192;
            // 
            // lblActivarIncrementoPrecio
            // 
            lblActivarIncrementoPrecio.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblActivarIncrementoPrecio.AutoSize = true;
            lblActivarIncrementoPrecio.BackColor = Color.Transparent;
            lblActivarIncrementoPrecio.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblActivarIncrementoPrecio.ForeColor = Color.FromArgb(192, 64, 0);
            lblActivarIncrementoPrecio.Location = new Point(71, 253);
            lblActivarIncrementoPrecio.Name = "lblActivarIncrementoPrecio";
            lblActivarIncrementoPrecio.Size = new Size(400, 14);
            lblActivarIncrementoPrecio.TabIndex = 195;
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
            lblActivarIncrementoPrecioListaPrecio.Location = new Point(71, 328);
            lblActivarIncrementoPrecioListaPrecio.Name = "lblActivarIncrementoPrecioListaPrecio";
            lblActivarIncrementoPrecioListaPrecio.Size = new Size(400, 14);
            lblActivarIncrementoPrecioListaPrecio.TabIndex = 196;
            lblActivarIncrementoPrecioListaPrecio.Text = "Para ACTIVAR esta opción debera hacerlo desde la CONFIGURACION del Sistema\r\n";
            lblActivarIncrementoPrecioListaPrecio.TextAlign = ContentAlignment.MiddleCenter;
            lblActivarIncrementoPrecioListaPrecio.Visible = false;
            // 
            // _00127_Marca_Abm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(545, 452);
            Controls.Add(lblActivarIncrementoPrecioListaPrecio);
            Controls.Add(lblActivarIncrementoPrecio);
            Controls.Add(cmbTipoAumentoPrecioPublicoListaPrecio);
            Controls.Add(label6);
            Controls.Add(nudAumentoPrecioPublicoListaPrecio);
            Controls.Add(chkAumentoPrecioPublicoListaPrecio);
            Controls.Add(panel3);
            Controls.Add(label5);
            Controls.Add(panel2);
            Controls.Add(cmbTipoAumentoPrecioPublico);
            Controls.Add(nudAumentoPrecioPublico);
            Controls.Add(chkAumentoPrecioPublico);
            Controls.Add(panel1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(chkEmpresa);
            Controls.Add(label2);
            Controls.Add(txtCodigo);
            Controls.Add(label1);
            Controls.Add(txtDescripcion);
            MaximumSize = new Size(561, 491);
            MinimumSize = new Size(561, 491);
            Name = "_00127_Marca_Abm";
            Text = "Marca";
            Controls.SetChildIndex(txtDescripcion, 0);
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(txtCodigo, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(chkEmpresa, 0);
            Controls.SetChildIndex(label3, 0);
            Controls.SetChildIndex(label4, 0);
            Controls.SetChildIndex(panel1, 0);
            Controls.SetChildIndex(chkAumentoPrecioPublico, 0);
            Controls.SetChildIndex(nudAumentoPrecioPublico, 0);
            Controls.SetChildIndex(cmbTipoAumentoPrecioPublico, 0);
            Controls.SetChildIndex(panel2, 0);
            Controls.SetChildIndex(label5, 0);
            Controls.SetChildIndex(panel3, 0);
            Controls.SetChildIndex(chkAumentoPrecioPublicoListaPrecio, 0);
            Controls.SetChildIndex(nudAumentoPrecioPublicoListaPrecio, 0);
            Controls.SetChildIndex(label6, 0);
            Controls.SetChildIndex(cmbTipoAumentoPrecioPublicoListaPrecio, 0);
            Controls.SetChildIndex(lblActivarIncrementoPrecio, 0);
            Controls.SetChildIndex(lblActivarIncrementoPrecioListaPrecio, 0);
            ((System.ComponentModel.ISupportInitialize)nudAumentoPrecioPublico).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudAumentoPrecioPublicoListaPrecio).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label4;
        private Label label3;
        private Base.Controles.SidkenuToggleButton chkEmpresa;
        private Label label2;
        private TextBox txtCodigo;
        private Label label1;
        private TextBox txtDescripcion;
        private Base.Controles.SidkenuToggleButton chkAumentoPrecioPublico;
        private ComboBox cmbTipoAumentoPrecioPublico;
        private NumericUpDown nudAumentoPrecioPublico;
        private Panel panel2;
        private Label label5;
        private Panel panel3;
        private NumericUpDown nudAumentoPrecioPublicoListaPrecio;
        private Base.Controles.SidkenuToggleButton chkAumentoPrecioPublicoListaPrecio;
        private Label label6;
        private ComboBox cmbTipoAumentoPrecioPublicoListaPrecio;
        private Label lblActivarIncrementoPrecio;
        private Label lblActivarIncrementoPrecioListaPrecio;
    }
}