namespace SidkenuWF.Formularios.Base
{
    partial class FormularioConsulta
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            pnlTitulo = new Panel();
            imgLogo = new FontAwesome.Sharp.IconPictureBox();
            lblTitulo = new Label();
            btnSalir = new FontAwesome.Sharp.IconButton();
            pnlLinea = new Panel();
            pnlSuperior = new Panel();
            pnlBusqueda = new Panel();
            btnBuscar = new FontAwesome.Sharp.IconButton();
            txtBuscar = new TextBox();
            chkVerEliminados = new Controles.SidkenuToggleButton();
            lblVerEliminado = new Label();
            btnEliminar = new FontAwesome.Sharp.IconButton();
            btnEditar = new FontAwesome.Sharp.IconButton();
            btnNuevo = new FontAwesome.Sharp.IconButton();
            pnlBotonera = new Panel();
            pnlCerrarBotoneraLateral = new Panel();
            pnlLineaLateral = new Panel();
            btnCerraMenuLateral = new FontAwesome.Sharp.IconButton();
            pnlInferior = new Panel();
            btnDesmarcarTodo = new FontAwesome.Sharp.IconButton();
            btnMarcarTodo = new FontAwesome.Sharp.IconButton();
            pnlLineaInferior = new Panel();
            lblCantidadRegistros = new Label();
            pnlContenedor = new Panel();
            dgvGrilla = new DataGridView();
            pnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgLogo).BeginInit();
            pnlSuperior.SuspendLayout();
            pnlBusqueda.SuspendLayout();
            pnlCerrarBotoneraLateral.SuspendLayout();
            pnlInferior.SuspendLayout();
            pnlContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGrilla).BeginInit();
            SuspendLayout();
            // 
            // pnlTitulo
            // 
            pnlTitulo.BackColor = Color.FromArgb(48, 66, 80);
            pnlTitulo.Controls.Add(imgLogo);
            pnlTitulo.Controls.Add(lblTitulo);
            pnlTitulo.Controls.Add(btnSalir);
            pnlTitulo.Controls.Add(pnlLinea);
            pnlTitulo.Dock = DockStyle.Top;
            pnlTitulo.Location = new Point(0, 0);
            pnlTitulo.Name = "pnlTitulo";
            pnlTitulo.Size = new Size(711, 59);
            pnlTitulo.TabIndex = 0;
            // 
            // imgLogo
            // 
            imgLogo.BackColor = Color.FromArgb(48, 66, 80);
            imgLogo.ForeColor = Color.WhiteSmoke;
            imgLogo.IconChar = FontAwesome.Sharp.IconChar.None;
            imgLogo.IconColor = Color.WhiteSmoke;
            imgLogo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            imgLogo.IconSize = 35;
            imgLogo.Location = new Point(19, 13);
            imgLogo.Name = "imgLogo";
            imgLogo.Size = new Size(35, 35);
            imgLogo.SizeMode = PictureBoxSizeMode.CenterImage;
            imgLogo.TabIndex = 3;
            imgLogo.TabStop = false;
            // 
            // lblTitulo
            // 
            lblTitulo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblTitulo.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.ForeColor = Color.WhiteSmoke;
            lblTitulo.Location = new Point(58, 5);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(580, 48);
            lblTitulo.TabIndex = 2;
            lblTitulo.Text = "Titulo";
            lblTitulo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnSalir
            // 
            btnSalir.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            btnSalir.BackColor = Color.FromArgb(54, 74, 90);
            btnSalir.FlatAppearance.BorderColor = Color.WhiteSmoke;
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.ForeColor = Color.WhiteSmoke;
            btnSalir.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            btnSalir.IconColor = Color.WhiteSmoke;
            btnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSalir.IconSize = 25;
            btnSalir.Location = new Point(646, 5);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(49, 49);
            btnSalir.TabIndex = 1;
            btnSalir.Text = "Salir";
            btnSalir.TextImageRelation = TextImageRelation.ImageAboveText;
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += BtnSalir_Click;
            // 
            // pnlLinea
            // 
            pnlLinea.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlLinea.Location = new Point(9, 57);
            pnlLinea.Name = "pnlLinea";
            pnlLinea.Size = new Size(693, 1);
            pnlLinea.TabIndex = 0;
            // 
            // pnlSuperior
            // 
            pnlSuperior.BackColor = Color.FromArgb(48, 66, 80);
            pnlSuperior.Controls.Add(pnlBusqueda);
            pnlSuperior.Controls.Add(btnEliminar);
            pnlSuperior.Controls.Add(btnEditar);
            pnlSuperior.Controls.Add(btnNuevo);
            pnlSuperior.Dock = DockStyle.Top;
            pnlSuperior.Location = new Point(0, 59);
            pnlSuperior.Name = "pnlSuperior";
            pnlSuperior.Size = new Size(711, 52);
            pnlSuperior.TabIndex = 1;
            // 
            // pnlBusqueda
            // 
            pnlBusqueda.Controls.Add(btnBuscar);
            pnlBusqueda.Controls.Add(txtBuscar);
            pnlBusqueda.Controls.Add(chkVerEliminados);
            pnlBusqueda.Controls.Add(lblVerEliminado);
            pnlBusqueda.Dock = DockStyle.Right;
            pnlBusqueda.Location = new Point(263, 0);
            pnlBusqueda.Name = "pnlBusqueda";
            pnlBusqueda.Size = new Size(448, 52);
            pnlBusqueda.TabIndex = 4;
            // 
            // btnBuscar
            // 
            btnBuscar.Anchor = AnchorStyles.Right;
            btnBuscar.FlatAppearance.BorderColor = Color.WhiteSmoke;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.ForeColor = Color.WhiteSmoke;
            btnBuscar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            btnBuscar.IconColor = Color.WhiteSmoke;
            btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBuscar.IconSize = 20;
            btnBuscar.Location = new Point(361, 11);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 29);
            btnBuscar.TabIndex = 3;
            btnBuscar.Text = "Buscar";
            btnBuscar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += BtnBuscar_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtBuscar.BorderStyle = BorderStyle.FixedSingle;
            txtBuscar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtBuscar.Location = new Point(175, 11);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = "Ingrese un texto";
            txtBuscar.Size = new Size(180, 29);
            txtBuscar.TabIndex = 2;
            txtBuscar.KeyPress += TxtBuscar_KeyPress;
            // 
            // chkVerEliminados
            // 
            chkVerEliminados.Anchor = AnchorStyles.Left;
            chkVerEliminados.AutoSize = true;
            chkVerEliminados.Location = new Point(118, 14);
            chkVerEliminados.MinimumSize = new Size(45, 22);
            chkVerEliminados.Name = "chkVerEliminados";
            chkVerEliminados.OffBackColor = Color.Gray;
            chkVerEliminados.OffToggleColor = Color.Gainsboro;
            chkVerEliminados.OnBackColor = Color.Maroon;
            chkVerEliminados.OnToggleColor = Color.WhiteSmoke;
            chkVerEliminados.Size = new Size(45, 22);
            chkVerEliminados.TabIndex = 1;
            chkVerEliminados.UseVisualStyleBackColor = true;
            chkVerEliminados.CheckedChanged += ChkEliminados_CheckedChanged;
            // 
            // lblVerEliminado
            // 
            lblVerEliminado.Anchor = AnchorStyles.Left;
            lblVerEliminado.ForeColor = Color.WhiteSmoke;
            lblVerEliminado.Location = new Point(13, 14);
            lblVerEliminado.Name = "lblVerEliminado";
            lblVerEliminado.Size = new Size(96, 23);
            lblVerEliminado.TabIndex = 0;
            lblVerEliminado.Text = "Ver Eliminados";
            lblVerEliminado.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(54, 74, 90);
            btnEliminar.FlatAppearance.BorderColor = Color.WhiteSmoke;
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.ForeColor = Color.WhiteSmoke;
            btnEliminar.IconChar = FontAwesome.Sharp.IconChar.Trash;
            btnEliminar.IconColor = Color.WhiteSmoke;
            btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEliminar.IconSize = 22;
            btnEliminar.Location = new Point(110, 7);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(43, 38);
            btnEliminar.TabIndex = 3;
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += BtnEliminar_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.FromArgb(54, 74, 90);
            btnEditar.FlatAppearance.BorderColor = Color.WhiteSmoke;
            btnEditar.FlatAppearance.BorderSize = 0;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.ForeColor = Color.WhiteSmoke;
            btnEditar.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            btnEditar.IconColor = Color.WhiteSmoke;
            btnEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEditar.IconSize = 22;
            btnEditar.Location = new Point(61, 7);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(43, 38);
            btnEditar.TabIndex = 2;
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += BtnEditar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = Color.FromArgb(54, 74, 90);
            btnNuevo.FlatAppearance.BorderColor = Color.WhiteSmoke;
            btnNuevo.FlatAppearance.BorderSize = 0;
            btnNuevo.FlatStyle = FlatStyle.Flat;
            btnNuevo.ForeColor = Color.WhiteSmoke;
            btnNuevo.IconChar = FontAwesome.Sharp.IconChar.Add;
            btnNuevo.IconColor = Color.WhiteSmoke;
            btnNuevo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnNuevo.IconSize = 22;
            btnNuevo.Location = new Point(12, 7);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(43, 38);
            btnNuevo.TabIndex = 1;
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += BtnNuevo_Click;
            // 
            // pnlBotonera
            // 
            pnlBotonera.BackColor = Color.FromArgb(225, 225, 225);
            pnlBotonera.Dock = DockStyle.Right;
            pnlBotonera.Location = new Point(612, 111);
            pnlBotonera.Name = "pnlBotonera";
            pnlBotonera.Size = new Size(99, 396);
            pnlBotonera.TabIndex = 2;
            // 
            // pnlCerrarBotoneraLateral
            // 
            pnlCerrarBotoneraLateral.BackColor = Color.FromArgb(225, 225, 225);
            pnlCerrarBotoneraLateral.Controls.Add(pnlLineaLateral);
            pnlCerrarBotoneraLateral.Controls.Add(btnCerraMenuLateral);
            pnlCerrarBotoneraLateral.Dock = DockStyle.Right;
            pnlCerrarBotoneraLateral.Location = new Point(585, 111);
            pnlCerrarBotoneraLateral.Name = "pnlCerrarBotoneraLateral";
            pnlCerrarBotoneraLateral.Size = new Size(27, 396);
            pnlCerrarBotoneraLateral.TabIndex = 3;
            // 
            // pnlLineaLateral
            // 
            pnlLineaLateral.BackColor = Color.FromArgb(192, 64, 0);
            pnlLineaLateral.Dock = DockStyle.Right;
            pnlLineaLateral.Location = new Point(26, 0);
            pnlLineaLateral.Name = "pnlLineaLateral";
            pnlLineaLateral.Size = new Size(1, 396);
            pnlLineaLateral.TabIndex = 1;
            // 
            // btnCerraMenuLateral
            // 
            btnCerraMenuLateral.Anchor = AnchorStyles.Left;
            btnCerraMenuLateral.BackColor = Color.FromArgb(225, 225, 225);
            btnCerraMenuLateral.FlatAppearance.BorderColor = Color.WhiteSmoke;
            btnCerraMenuLateral.FlatAppearance.BorderSize = 0;
            btnCerraMenuLateral.FlatStyle = FlatStyle.Flat;
            btnCerraMenuLateral.ForeColor = Color.WhiteSmoke;
            btnCerraMenuLateral.IconChar = FontAwesome.Sharp.IconChar.ArrowsH;
            btnCerraMenuLateral.IconColor = Color.Gray;
            btnCerraMenuLateral.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCerraMenuLateral.IconSize = 20;
            btnCerraMenuLateral.Location = new Point(3, 127);
            btnCerraMenuLateral.Name = "btnCerraMenuLateral";
            btnCerraMenuLateral.Size = new Size(20, 100);
            btnCerraMenuLateral.TabIndex = 0;
            btnCerraMenuLateral.UseVisualStyleBackColor = false;
            btnCerraMenuLateral.Click += BtnCerraMenuLateral_Click;
            // 
            // pnlInferior
            // 
            pnlInferior.BackColor = Color.FromArgb(48, 66, 80);
            pnlInferior.Controls.Add(btnDesmarcarTodo);
            pnlInferior.Controls.Add(btnMarcarTodo);
            pnlInferior.Controls.Add(pnlLineaInferior);
            pnlInferior.Controls.Add(lblCantidadRegistros);
            pnlInferior.Dock = DockStyle.Bottom;
            pnlInferior.Location = new Point(0, 471);
            pnlInferior.Name = "pnlInferior";
            pnlInferior.Size = new Size(585, 36);
            pnlInferior.TabIndex = 4;
            // 
            // btnDesmarcarTodo
            // 
            btnDesmarcarTodo.BackColor = Color.FromArgb(54, 74, 90);
            btnDesmarcarTodo.FlatAppearance.BorderColor = Color.WhiteSmoke;
            btnDesmarcarTodo.FlatAppearance.BorderSize = 0;
            btnDesmarcarTodo.FlatStyle = FlatStyle.Flat;
            btnDesmarcarTodo.ForeColor = Color.WhiteSmoke;
            btnDesmarcarTodo.IconChar = FontAwesome.Sharp.IconChar.Clone;
            btnDesmarcarTodo.IconColor = Color.WhiteSmoke;
            btnDesmarcarTodo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDesmarcarTodo.IconSize = 20;
            btnDesmarcarTodo.Location = new Point(42, 4);
            btnDesmarcarTodo.Name = "btnDesmarcarTodo";
            btnDesmarcarTodo.Size = new Size(29, 24);
            btnDesmarcarTodo.TabIndex = 5;
            btnDesmarcarTodo.UseVisualStyleBackColor = false;
            btnDesmarcarTodo.Click += BtnDesmarcarTodo_Click;
            // 
            // btnMarcarTodo
            // 
            btnMarcarTodo.BackColor = Color.FromArgb(54, 74, 90);
            btnMarcarTodo.FlatAppearance.BorderColor = Color.WhiteSmoke;
            btnMarcarTodo.FlatAppearance.BorderSize = 0;
            btnMarcarTodo.FlatStyle = FlatStyle.Flat;
            btnMarcarTodo.ForeColor = Color.WhiteSmoke;
            btnMarcarTodo.IconChar = FontAwesome.Sharp.IconChar.CheckDouble;
            btnMarcarTodo.IconColor = Color.WhiteSmoke;
            btnMarcarTodo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMarcarTodo.IconSize = 20;
            btnMarcarTodo.Location = new Point(7, 4);
            btnMarcarTodo.Name = "btnMarcarTodo";
            btnMarcarTodo.Size = new Size(29, 24);
            btnMarcarTodo.TabIndex = 4;
            btnMarcarTodo.UseVisualStyleBackColor = false;
            btnMarcarTodo.Click += BtnMarcarTodo_Click;
            // 
            // pnlLineaInferior
            // 
            pnlLineaInferior.Dock = DockStyle.Top;
            pnlLineaInferior.Location = new Point(0, 0);
            pnlLineaInferior.Name = "pnlLineaInferior";
            pnlLineaInferior.Size = new Size(585, 1);
            pnlLineaInferior.TabIndex = 1;
            // 
            // lblCantidadRegistros
            // 
            lblCantidadRegistros.Anchor = AnchorStyles.Right;
            lblCantidadRegistros.ForeColor = Color.WhiteSmoke;
            lblCantidadRegistros.Location = new Point(413, 8);
            lblCantidadRegistros.Name = "lblCantidadRegistros";
            lblCantidadRegistros.Size = new Size(169, 21);
            lblCantidadRegistros.TabIndex = 0;
            lblCantidadRegistros.Text = "Cantidad de Registros: 0";
            lblCantidadRegistros.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlContenedor
            // 
            pnlContenedor.BackColor = Color.White;
            pnlContenedor.Controls.Add(dgvGrilla);
            pnlContenedor.Dock = DockStyle.Fill;
            pnlContenedor.Location = new Point(0, 111);
            pnlContenedor.Name = "pnlContenedor";
            pnlContenedor.Size = new Size(585, 360);
            pnlContenedor.TabIndex = 5;
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
            dgvGrilla.Dock = DockStyle.Fill;
            dgvGrilla.GridColor = Color.FromArgb(64, 64, 64);
            dgvGrilla.Location = new Point(0, 0);
            dgvGrilla.MultiSelect = false;
            dgvGrilla.Name = "dgvGrilla";
            dgvGrilla.RowHeadersVisible = false;
            dgvGrilla.RowTemplate.Height = 25;
            dgvGrilla.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGrilla.Size = new Size(585, 360);
            dgvGrilla.TabIndex = 0;
            dgvGrilla.DataSourceChanged += DgvGrilla_DataSourceChanged;
            dgvGrilla.CellContentClick += DgvGrilla_CellContentClick;
            dgvGrilla.ColumnWidthChanged += dgvGrilla_ColumnWidthChanged;
            dgvGrilla.RowEnter += DgvGrilla_RowEnter;
            dgvGrilla.Paint += DgvGrilla_Paint;
            // 
            // FormularioConsulta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(711, 507);
            ControlBox = false;
            Controls.Add(pnlContenedor);
            Controls.Add(pnlInferior);
            Controls.Add(pnlCerrarBotoneraLateral);
            Controls.Add(pnlBotonera);
            Controls.Add(pnlSuperior);
            Controls.Add(pnlTitulo);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormularioConsulta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sidkenu 2.0";
            Activated += FormularioConsulta_Activated;
            Load += FormularioConsulta_Load;
            Shown += FormularioConsulta_Shown;
            pnlTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)imgLogo).EndInit();
            pnlSuperior.ResumeLayout(false);
            pnlBusqueda.ResumeLayout(false);
            pnlBusqueda.PerformLayout();
            pnlCerrarBotoneraLateral.ResumeLayout(false);
            pnlInferior.ResumeLayout(false);
            pnlContenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvGrilla).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTitulo;
        private Panel pnlLinea;
        private FontAwesome.Sharp.IconButton btnSalir;
        private Panel pnlSuperior;
        private FontAwesome.Sharp.IconPictureBox imgLogo;
        private Label lblTitulo;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private FontAwesome.Sharp.IconButton btnEditar;
        private FontAwesome.Sharp.IconButton btnNuevo;
        private Panel pnlCerrarBotoneraLateral;
        private FontAwesome.Sharp.IconButton btnCerraMenuLateral;
        private Panel pnlLineaLateral;
        private Panel pnlContenedor;
        public Panel pnlInferior;
        private Label lblCantidadRegistros;
        public DataGridView dgvGrilla;
        private Panel pnlBusqueda;
        private Controles.SidkenuToggleButton chkVerEliminados;
        private Label lblVerEliminado;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private Panel pnlLineaInferior;
        public Panel pnlBotonera;
        private FontAwesome.Sharp.IconButton btnDesmarcarTodo;
        private FontAwesome.Sharp.IconButton btnMarcarTodo;
        public TextBox txtBuscar;
    }
}