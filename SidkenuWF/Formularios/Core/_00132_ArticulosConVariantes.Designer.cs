namespace SidkenuWF.Formularios.Core
{
    partial class _00132_ArticulosConVariantes
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
            pnlBotonera = new Panel();
            btnEjecutar = new FontAwesome.Sharp.IconButton();
            pnlTestigo = new Panel();
            lblArticuloSeleccionada = new Label();
            groupBox1 = new GroupBox();
            pnlStockPrecioIndividual = new Panel();
            rdbVariante1 = new RadioButton();
            rdbIndividual = new RadioButton();
            panel1 = new Panel();
            label3 = new Label();
            chkStockPrecioIndividuales = new Base.Controles.SidkenuToggleButton();
            label2 = new Label();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            cmbVariante2 = new ComboBox();
            label1 = new Label();
            cmbVariante1 = new ComboBox();
            dpbCombinaciones = new GroupBox();
            label4 = new Label();
            pnlBotonera.SuspendLayout();
            pnlTestigo.SuspendLayout();
            groupBox1.SuspendLayout();
            pnlStockPrecioIndividual.SuspendLayout();
            SuspendLayout();
            // 
            // pnlBotonera
            // 
            pnlBotonera.BackColor = Color.FromArgb(48, 66, 80);
            pnlBotonera.Controls.Add(label4);
            pnlBotonera.Controls.Add(btnEjecutar);
            pnlBotonera.Dock = DockStyle.Bottom;
            pnlBotonera.Location = new Point(0, 521);
            pnlBotonera.Name = "pnlBotonera";
            pnlBotonera.Size = new Size(784, 40);
            pnlBotonera.TabIndex = 2;
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
            btnEjecutar.Location = new Point(13, 6);
            btnEjecutar.Name = "btnEjecutar";
            btnEjecutar.Size = new Size(201, 28);
            btnEjecutar.TabIndex = 2;
            btnEjecutar.Text = "Guardar y Generar Articulos";
            btnEjecutar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEjecutar.UseVisualStyleBackColor = false;
            btnEjecutar.Click += BtnEjecutar_Click;
            // 
            // pnlTestigo
            // 
            pnlTestigo.BackColor = Color.FromArgb(192, 64, 0);
            pnlTestigo.Controls.Add(lblArticuloSeleccionada);
            pnlTestigo.Dock = DockStyle.Top;
            pnlTestigo.Location = new Point(0, 59);
            pnlTestigo.Name = "pnlTestigo";
            pnlTestigo.Size = new Size(784, 41);
            pnlTestigo.TabIndex = 5;
            // 
            // lblArticuloSeleccionada
            // 
            lblArticuloSeleccionada.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblArticuloSeleccionada.BackColor = Color.Transparent;
            lblArticuloSeleccionada.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblArticuloSeleccionada.ForeColor = Color.White;
            lblArticuloSeleccionada.Location = new Point(19, 6);
            lblArticuloSeleccionada.Name = "lblArticuloSeleccionada";
            lblArticuloSeleccionada.Size = new Size(749, 29);
            lblArticuloSeleccionada.TabIndex = 0;
            lblArticuloSeleccionada.Text = "Articulo Selecc. => ";
            lblArticuloSeleccionada.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pnlStockPrecioIndividual);
            groupBox1.Controls.Add(panel1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(chkStockPrecioIndividuales);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(iconButton1);
            groupBox1.Controls.Add(cmbVariante2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(cmbVariante1);
            groupBox1.Location = new Point(8, 103);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(769, 110);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "[ Variantes ]";
            // 
            // pnlStockPrecioIndividual
            // 
            pnlStockPrecioIndividual.BackColor = Color.WhiteSmoke;
            pnlStockPrecioIndividual.Controls.Add(rdbVariante1);
            pnlStockPrecioIndividual.Controls.Add(rdbIndividual);
            pnlStockPrecioIndividual.Location = new Point(219, 57);
            pnlStockPrecioIndividual.Name = "pnlStockPrecioIndividual";
            pnlStockPrecioIndividual.Size = new Size(541, 45);
            pnlStockPrecioIndividual.TabIndex = 9;
            // 
            // rdbVariante1
            // 
            rdbVariante1.AutoSize = true;
            rdbVariante1.Checked = true;
            rdbVariante1.Location = new Point(28, 14);
            rdbVariante1.Name = "rdbVariante1";
            rdbVariante1.Size = new Size(196, 19);
            rdbVariante1.TabIndex = 1;
            rdbVariante1.TabStop = true;
            rdbVariante1.Text = "Stock / Precio por Variante Nro 1";
            rdbVariante1.UseVisualStyleBackColor = true;
            rdbVariante1.CheckedChanged += RdbVariante1_CheckedChanged;
            // 
            // rdbIndividual
            // 
            rdbIndividual.AutoSize = true;
            rdbIndividual.Location = new Point(291, 14);
            rdbIndividual.Name = "rdbIndividual";
            rdbIndividual.Size = new Size(153, 19);
            rdbIndividual.TabIndex = 0;
            rdbIndividual.Text = "Stock / Precio Individual";
            rdbIndividual.UseVisualStyleBackColor = true;
            rdbIndividual.CheckedChanged += RdbVariante1_CheckedChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.Location = new Point(213, 57);
            panel1.Name = "panel1";
            panel1.Size = new Size(1, 45);
            panel1.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(66, 65);
            label3.Name = "label3";
            label3.Size = new Size(144, 30);
            label3.TabIndex = 7;
            label3.Text = "Usar Stock y Precio Costo \r\nIndividuales";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // chkStockPrecioIndividuales
            // 
            chkStockPrecioIndividuales.AutoSize = true;
            chkStockPrecioIndividuales.Location = new Point(14, 69);
            chkStockPrecioIndividuales.MinimumSize = new Size(45, 22);
            chkStockPrecioIndividuales.Name = "chkStockPrecioIndividuales";
            chkStockPrecioIndividuales.OffBackColor = Color.Gray;
            chkStockPrecioIndividuales.OffToggleColor = Color.Gainsboro;
            chkStockPrecioIndividuales.OnBackColor = Color.Green;
            chkStockPrecioIndividuales.OnToggleColor = Color.WhiteSmoke;
            chkStockPrecioIndividuales.Size = new Size(45, 22);
            chkStockPrecioIndividuales.TabIndex = 6;
            chkStockPrecioIndividuales.UseVisualStyleBackColor = true;
            chkStockPrecioIndividuales.CheckedChanged += ChkStockPrecioIndividuales_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(345, 21);
            label2.Name = "label2";
            label2.Size = new Size(81, 30);
            label2.TabIndex = 5;
            label2.Text = "Variante Nro 2\r\n(Columna)";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // iconButton1
            // 
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.Location = new Point(683, 24);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(77, 23);
            iconButton1.TabIndex = 4;
            iconButton1.Text = "Combinar";
            iconButton1.UseVisualStyleBackColor = true;
            iconButton1.Click += BtnCombinarVariantes_Click;
            // 
            // cmbVariante2
            // 
            cmbVariante2.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbVariante2.FormattingEnabled = true;
            cmbVariante2.Location = new Point(432, 25);
            cmbVariante2.Name = "cmbVariante2";
            cmbVariante2.Size = new Size(213, 23);
            cmbVariante2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 21);
            label1.Name = "label1";
            label1.Size = new Size(81, 30);
            label1.TabIndex = 1;
            label1.Text = "Variante Nro 1\r\n(Fila)";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cmbVariante1
            // 
            cmbVariante1.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbVariante1.FormattingEnabled = true;
            cmbVariante1.Location = new Point(98, 25);
            cmbVariante1.Name = "cmbVariante1";
            cmbVariante1.Size = new Size(213, 23);
            cmbVariante1.TabIndex = 0;
            // 
            // dpbCombinaciones
            // 
            dpbCombinaciones.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dpbCombinaciones.Location = new Point(8, 219);
            dpbCombinaciones.Name = "dpbCombinaciones";
            dpbCombinaciones.Size = new Size(769, 296);
            dpbCombinaciones.TabIndex = 7;
            dpbCombinaciones.TabStop = false;
            dpbCombinaciones.Text = "[ Combinaciones ]";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.ForeColor = Color.Beige;
            label4.Location = new Point(384, 5);
            label4.Name = "label4";
            label4.Size = new Size(394, 30);
            label4.TabIndex = 8;
            label4.Text = "Nota: Las Variantes NUEVAS que coincidan con las variantyes ya cargadas \r\n           NO se cargaran nuevamente.";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // _00132_ArticulosConVariantes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(dpbCombinaciones);
            Controls.Add(groupBox1);
            Controls.Add(pnlTestigo);
            Controls.Add(pnlBotonera);
            MinimumSize = new Size(800, 600);
            Name = "_00132_ArticulosConVariantes";
            Text = "Articulos Con Variantes";
            Load += _00132_ArticulosConVariantes_Load;
            Controls.SetChildIndex(pnlBotonera, 0);
            Controls.SetChildIndex(pnlTestigo, 0);
            Controls.SetChildIndex(groupBox1, 0);
            Controls.SetChildIndex(dpbCombinaciones, 0);
            pnlBotonera.ResumeLayout(false);
            pnlBotonera.PerformLayout();
            pnlTestigo.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            pnlStockPrecioIndividual.ResumeLayout(false);
            pnlStockPrecioIndividual.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlBotonera;
        private FontAwesome.Sharp.IconButton btnEjecutar;
        private Panel pnlTestigo;
        private Label lblArticuloSeleccionada;
        private GroupBox groupBox1;
        private ComboBox cmbVariante2;
        private Label label1;
        private ComboBox cmbVariante1;
        private GroupBox dpbCombinaciones;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Label label2;
        private Label label3;
        private Base.Controles.SidkenuToggleButton chkStockPrecioIndividuales;
        private Panel panel1;
        private Panel pnlStockPrecioIndividual;
        private RadioButton rdbVariante1;
        private RadioButton rdbIndividual;
        private Label label4;
    }
}