namespace SidkenuWF.Formularios.Core
{
    partial class _00141_ConfeccionarFormula
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            pnlEntidadSeleccionada = new Panel();
            label1 = new Label();
            lblEntidadSeleccionada = new Label();
            pnlBotonera = new Panel();
            btnEjecutar = new FontAwesome.Sharp.IconButton();
            panel2 = new Panel();
            label9 = new Label();
            chkVerEliminados = new Base.Controles.SidkenuToggleButton();
            nudCantidadArticulos = new NumericUpDown();
            label8 = new Label();
            btnBuscar = new FontAwesome.Sharp.IconButton();
            label6 = new Label();
            txtCodigo = new TextBox();
            btnQuitarProveedor = new FontAwesome.Sharp.IconButton();
            btnAgregarProveedor = new FontAwesome.Sharp.IconButton();
            label31 = new Label();
            txtDescripcion = new TextBox();
            dgvGrilla = new DataGridView();
            menu = new ContextMenuStrip(components);
            cambiarCantidadToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            agregarPerdidaToolStripMenuItem = new ToolStripMenuItem();
            pnlEntidadSeleccionada.SuspendLayout();
            pnlBotonera.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudCantidadArticulos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvGrilla).BeginInit();
            menu.SuspendLayout();
            SuspendLayout();
            // 
            // pnlEntidadSeleccionada
            // 
            pnlEntidadSeleccionada.BackColor = Color.FromArgb(192, 64, 0);
            pnlEntidadSeleccionada.Controls.Add(label1);
            pnlEntidadSeleccionada.Controls.Add(lblEntidadSeleccionada);
            pnlEntidadSeleccionada.Dock = DockStyle.Top;
            pnlEntidadSeleccionada.Location = new Point(0, 59);
            pnlEntidadSeleccionada.Name = "pnlEntidadSeleccionada";
            pnlEntidadSeleccionada.Size = new Size(784, 48);
            pnlEntidadSeleccionada.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(8, 15);
            label1.Name = "label1";
            label1.Size = new Size(142, 17);
            label1.TabIndex = 2;
            label1.Text = "Producto Seleccionado";
            // 
            // lblEntidadSeleccionada
            // 
            lblEntidadSeleccionada.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblEntidadSeleccionada.BackColor = Color.FromArgb(192, 64, 0);
            lblEntidadSeleccionada.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblEntidadSeleccionada.ForeColor = Color.WhiteSmoke;
            lblEntidadSeleccionada.Location = new Point(171, 6);
            lblEntidadSeleccionada.Name = "lblEntidadSeleccionada";
            lblEntidadSeleccionada.Size = new Size(607, 35);
            lblEntidadSeleccionada.TabIndex = 1;
            lblEntidadSeleccionada.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlBotonera
            // 
            pnlBotonera.BackColor = Color.FromArgb(48, 66, 80);
            pnlBotonera.Controls.Add(btnEjecutar);
            pnlBotonera.Dock = DockStyle.Bottom;
            pnlBotonera.Location = new Point(0, 521);
            pnlBotonera.Name = "pnlBotonera";
            pnlBotonera.Size = new Size(784, 40);
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
            btnEjecutar.Location = new Point(13, 6);
            btnEjecutar.Name = "btnEjecutar";
            btnEjecutar.Size = new Size(96, 28);
            btnEjecutar.TabIndex = 2;
            btnEjecutar.Text = "Guardar";
            btnEjecutar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEjecutar.UseVisualStyleBackColor = false;
            btnEjecutar.Click += BtnEjecutar_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gainsboro;
            panel2.Controls.Add(label9);
            panel2.Controls.Add(chkVerEliminados);
            panel2.Controls.Add(nudCantidadArticulos);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(btnBuscar);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(txtCodigo);
            panel2.Controls.Add(btnQuitarProveedor);
            panel2.Controls.Add(btnAgregarProveedor);
            panel2.Controls.Add(label31);
            panel2.Controls.Add(txtDescripcion);
            panel2.Controls.Add(dgvGrilla);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 107);
            panel2.Name = "panel2";
            panel2.Size = new Size(784, 414);
            panel2.TabIndex = 5;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(635, 390);
            label9.Name = "label9";
            label9.Size = new Size(84, 15);
            label9.TabIndex = 147;
            label9.Text = "Ver Eliminados";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // chkVerEliminados
            // 
            chkVerEliminados.AutoSize = true;
            chkVerEliminados.Location = new Point(725, 386);
            chkVerEliminados.MinimumSize = new Size(45, 22);
            chkVerEliminados.Name = "chkVerEliminados";
            chkVerEliminados.OffBackColor = Color.Gray;
            chkVerEliminados.OffToggleColor = Color.Gainsboro;
            chkVerEliminados.OnBackColor = Color.Green;
            chkVerEliminados.OnToggleColor = Color.WhiteSmoke;
            chkVerEliminados.Size = new Size(45, 22);
            chkVerEliminados.TabIndex = 146;
            chkVerEliminados.UseVisualStyleBackColor = true;
            chkVerEliminados.CheckedChanged += ChkVerEliminados_CheckedChanged;
            // 
            // nudCantidadArticulos
            // 
            nudCantidadArticulos.DecimalPlaces = 6;
            nudCantidadArticulos.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            nudCantidadArticulos.Location = new Point(455, 30);
            nudCantidadArticulos.Maximum = new decimal(new int[] { -559939584, 902409669, 54, 0 });
            nudCantidadArticulos.Name = "nudCantidadArticulos";
            nudCantidadArticulos.Size = new Size(144, 29);
            nudCantidadArticulos.TabIndex = 6;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(455, 10);
            label8.Name = "label8";
            label8.Size = new Size(55, 15);
            label8.TabIndex = 145;
            label8.Text = "Cantidad";
            // 
            // btnBuscar
            // 
            btnBuscar.Anchor = AnchorStyles.Right;
            btnBuscar.BackColor = Color.FromArgb(54, 74, 90);
            btnBuscar.FlatAppearance.BorderColor = Color.WhiteSmoke;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.ForeColor = Color.WhiteSmoke;
            btnBuscar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            btnBuscar.IconColor = Color.WhiteSmoke;
            btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBuscar.IconSize = 20;
            btnBuscar.Location = new Point(602, 30);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(93, 29);
            btnBuscar.TabIndex = 144;
            btnBuscar.Text = "Buscar";
            btnBuscar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += BtnBuscar_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 10);
            label6.Name = "label6";
            label6.Size = new Size(46, 15);
            label6.TabIndex = 143;
            label6.Text = "Codigo";
            // 
            // txtCodigo
            // 
            txtCodigo.BackColor = Color.WhiteSmoke;
            txtCodigo.BorderStyle = BorderStyle.FixedSingle;
            txtCodigo.Enabled = false;
            txtCodigo.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtCodigo.ForeColor = Color.FromArgb(64, 64, 64);
            txtCodigo.Location = new Point(12, 30);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(123, 29);
            txtCodigo.TabIndex = 142;
            // 
            // btnQuitarProveedor
            // 
            btnQuitarProveedor.FlatAppearance.BorderColor = Color.Gray;
            btnQuitarProveedor.FlatStyle = FlatStyle.Flat;
            btnQuitarProveedor.IconChar = FontAwesome.Sharp.IconChar.Trash;
            btnQuitarProveedor.IconColor = Color.Black;
            btnQuitarProveedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnQuitarProveedor.IconSize = 25;
            btnQuitarProveedor.Location = new Point(742, 30);
            btnQuitarProveedor.Name = "btnQuitarProveedor";
            btnQuitarProveedor.Size = new Size(30, 29);
            btnQuitarProveedor.TabIndex = 141;
            btnQuitarProveedor.UseVisualStyleBackColor = true;
            btnQuitarProveedor.Click += BtnQuitarProveedor_Click;
            // 
            // btnAgregarProveedor
            // 
            btnAgregarProveedor.FlatAppearance.BorderColor = Color.Gray;
            btnAgregarProveedor.FlatStyle = FlatStyle.Flat;
            btnAgregarProveedor.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            btnAgregarProveedor.IconColor = Color.Black;
            btnAgregarProveedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAgregarProveedor.IconSize = 25;
            btnAgregarProveedor.Location = new Point(708, 30);
            btnAgregarProveedor.Name = "btnAgregarProveedor";
            btnAgregarProveedor.Size = new Size(30, 29);
            btnAgregarProveedor.TabIndex = 140;
            btnAgregarProveedor.UseVisualStyleBackColor = true;
            btnAgregarProveedor.Click += BtnAgregarProveedor_Click;
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Location = new Point(141, 10);
            label31.Name = "label31";
            label31.Size = new Size(69, 15);
            label31.TabIndex = 139;
            label31.Text = "Descripcion";
            // 
            // txtDescripcion
            // 
            txtDescripcion.BackColor = Color.WhiteSmoke;
            txtDescripcion.BorderStyle = BorderStyle.FixedSingle;
            txtDescripcion.Enabled = false;
            txtDescripcion.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtDescripcion.ForeColor = Color.FromArgb(64, 64, 64);
            txtDescripcion.Location = new Point(141, 30);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(308, 29);
            txtDescripcion.TabIndex = 138;
            // 
            // dgvGrilla
            // 
            dgvGrilla.AllowUserToAddRows = false;
            dgvGrilla.AllowUserToDeleteRows = false;
            dgvGrilla.BackgroundColor = Color.White;
            dgvGrilla.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvGrilla.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvGrilla.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGrilla.ContextMenuStrip = menu;
            dgvGrilla.GridColor = Color.FromArgb(64, 64, 64);
            dgvGrilla.Location = new Point(13, 65);
            dgvGrilla.MultiSelect = false;
            dgvGrilla.Name = "dgvGrilla";
            dgvGrilla.RowHeadersVisible = false;
            dgvGrilla.RowTemplate.Height = 25;
            dgvGrilla.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGrilla.Size = new Size(760, 315);
            dgvGrilla.TabIndex = 4;
            dgvGrilla.RowEnter += DgvGrilla_RowEnter;
            // 
            // menu
            // 
            menu.Items.AddRange(new ToolStripItem[] { cambiarCantidadToolStripMenuItem, toolStripMenuItem1, agregarPerdidaToolStripMenuItem });
            menu.Name = "menu";
            menu.Size = new Size(171, 54);
            // 
            // cambiarCantidadToolStripMenuItem
            // 
            cambiarCantidadToolStripMenuItem.Name = "cambiarCantidadToolStripMenuItem";
            cambiarCantidadToolStripMenuItem.Size = new Size(170, 22);
            cambiarCantidadToolStripMenuItem.Text = "Cambiar Cantidad";
            cambiarCantidadToolStripMenuItem.Click += CambiarCantidad_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(167, 6);
            // 
            // agregarPerdidaToolStripMenuItem
            // 
            agregarPerdidaToolStripMenuItem.Name = "agregarPerdidaToolStripMenuItem";
            agregarPerdidaToolStripMenuItem.Size = new Size(170, 22);
            agregarPerdidaToolStripMenuItem.Text = "Agregar Perdida";
            agregarPerdidaToolStripMenuItem.Click += AgregarPerdida_Click;
            // 
            // _00141_ConfeccionarFormula
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(panel2);
            Controls.Add(pnlEntidadSeleccionada);
            Controls.Add(pnlBotonera);
            MinimumSize = new Size(800, 600);
            Name = "_00141_ConfeccionarFormula";
            Text = "Confeccionar Formula";
            Load += _00140_Confeccionarkit_Load;
            Shown += _00140_Confeccionarkit_Shown;
            Controls.SetChildIndex(pnlBotonera, 0);
            Controls.SetChildIndex(pnlEntidadSeleccionada, 0);
            Controls.SetChildIndex(panel2, 0);
            pnlEntidadSeleccionada.ResumeLayout(false);
            pnlEntidadSeleccionada.PerformLayout();
            pnlBotonera.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudCantidadArticulos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvGrilla).EndInit();
            menu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlEntidadSeleccionada;
        private Label lblEntidadSeleccionada;
        private Label label1;
        private Panel pnlBotonera;
        private FontAwesome.Sharp.IconButton btnEjecutar;
        private Panel panel2;
        public DataGridView dgvGrilla;
        private Label label6;
        private TextBox txtCodigo;
        private FontAwesome.Sharp.IconButton btnQuitarProveedor;
        private FontAwesome.Sharp.IconButton btnAgregarProveedor;
        private Label label31;
        private TextBox txtDescripcion;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private NumericUpDown nudCantidadArticulos;
        private Label label8;
        private Label label9;
        private Base.Controles.SidkenuToggleButton chkVerEliminados;
        private ContextMenuStrip menu;
        private ToolStripMenuItem cambiarCantidadToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem agregarPerdidaToolStripMenuItem;
    }
}