namespace SidkenuWF.Formularios.Base
{
    partial class FormularioAsignarQuitar
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            pnlSuperior = new Panel();
            imgLogoTitulo = new FontAwesome.Sharp.IconPictureBox();
            lblTitulo = new Label();
            pnlEntidadSeleccionada = new Panel();
            lblEntidadSeleccionada = new Label();
            pnlLinea = new Panel();
            pnlNoAsignado = new Panel();
            dgvGrillaNoAsignado = new DataGridView();
            pnlBuscarNoAsignado = new Panel();
            btnBuscarNoAsignado = new FontAwesome.Sharp.IconButton();
            txtBuscarNoAsignado = new TextBox();
            label1 = new Label();
            pnlBotoneraNoAsignado = new Panel();
            btnDesmarcarNoAsignado = new FontAwesome.Sharp.IconButton();
            btnMarcarNoAsignado = new FontAwesome.Sharp.IconButton();
            lblTituloNoAsignado = new Label();
            pnlAsignado = new Panel();
            dgvGrillaAsignado = new DataGridView();
            pnlBuscarAsignado = new Panel();
            btnBuscarAsignado = new FontAwesome.Sharp.IconButton();
            txtBuscarAsignado = new TextBox();
            label2 = new Label();
            pnlBotoneraAsignado = new Panel();
            btnDesmarcarAsignado = new FontAwesome.Sharp.IconButton();
            btnMarcarAsignado = new FontAwesome.Sharp.IconButton();
            lblTituloAsignado = new Label();
            pnlCentro = new Panel();
            btnQuitar = new FontAwesome.Sharp.IconButton();
            btnAgregar = new FontAwesome.Sharp.IconButton();
            btnSalir = new FontAwesome.Sharp.IconButton();
            pnlSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgLogoTitulo).BeginInit();
            pnlEntidadSeleccionada.SuspendLayout();
            pnlNoAsignado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGrillaNoAsignado).BeginInit();
            pnlBuscarNoAsignado.SuspendLayout();
            pnlBotoneraNoAsignado.SuspendLayout();
            pnlAsignado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGrillaAsignado).BeginInit();
            pnlBuscarAsignado.SuspendLayout();
            pnlBotoneraAsignado.SuspendLayout();
            pnlCentro.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSuperior
            // 
            pnlSuperior.BackColor = Color.FromArgb(48, 66, 80);
            pnlSuperior.Controls.Add(btnSalir);
            pnlSuperior.Controls.Add(imgLogoTitulo);
            pnlSuperior.Controls.Add(lblTitulo);
            pnlSuperior.Dock = DockStyle.Top;
            pnlSuperior.Location = new Point(0, 0);
            pnlSuperior.Name = "pnlSuperior";
            pnlSuperior.Size = new Size(784, 56);
            pnlSuperior.TabIndex = 0;
            // 
            // imgLogoTitulo
            // 
            imgLogoTitulo.BackColor = Color.FromArgb(48, 66, 80);
            imgLogoTitulo.ForeColor = Color.WhiteSmoke;
            imgLogoTitulo.IconChar = FontAwesome.Sharp.IconChar.None;
            imgLogoTitulo.IconColor = Color.WhiteSmoke;
            imgLogoTitulo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            imgLogoTitulo.IconSize = 37;
            imgLogoTitulo.Location = new Point(33, 9);
            imgLogoTitulo.Name = "imgLogoTitulo";
            imgLogoTitulo.Size = new Size(40, 37);
            imgLogoTitulo.SizeMode = PictureBoxSizeMode.CenterImage;
            imgLogoTitulo.TabIndex = 1;
            imgLogoTitulo.TabStop = false;
            // 
            // lblTitulo
            // 
            lblTitulo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblTitulo.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.ForeColor = Color.WhiteSmoke;
            lblTitulo.Location = new Point(79, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(607, 35);
            lblTitulo.TabIndex = 0;
            lblTitulo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlEntidadSeleccionada
            // 
            pnlEntidadSeleccionada.BackColor = Color.FromArgb(48, 66, 80);
            pnlEntidadSeleccionada.Controls.Add(lblEntidadSeleccionada);
            pnlEntidadSeleccionada.Controls.Add(pnlLinea);
            pnlEntidadSeleccionada.Dock = DockStyle.Top;
            pnlEntidadSeleccionada.Location = new Point(0, 56);
            pnlEntidadSeleccionada.Name = "pnlEntidadSeleccionada";
            pnlEntidadSeleccionada.Size = new Size(784, 56);
            pnlEntidadSeleccionada.TabIndex = 1;
            // 
            // lblEntidadSeleccionada
            // 
            lblEntidadSeleccionada.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblEntidadSeleccionada.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblEntidadSeleccionada.ForeColor = Color.WhiteSmoke;
            lblEntidadSeleccionada.Location = new Point(33, 11);
            lblEntidadSeleccionada.Name = "lblEntidadSeleccionada";
            lblEntidadSeleccionada.Size = new Size(693, 35);
            lblEntidadSeleccionada.TabIndex = 1;
            lblEntidadSeleccionada.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlLinea
            // 
            pnlLinea.BackColor = Color.FromArgb(255, 128, 0);
            pnlLinea.Dock = DockStyle.Top;
            pnlLinea.Location = new Point(0, 0);
            pnlLinea.Name = "pnlLinea";
            pnlLinea.Size = new Size(784, 2);
            pnlLinea.TabIndex = 0;
            // 
            // pnlNoAsignado
            // 
            pnlNoAsignado.BackColor = Color.FromArgb(255, 255, 192);
            pnlNoAsignado.Controls.Add(dgvGrillaNoAsignado);
            pnlNoAsignado.Controls.Add(pnlBuscarNoAsignado);
            pnlNoAsignado.Controls.Add(pnlBotoneraNoAsignado);
            pnlNoAsignado.Controls.Add(lblTituloNoAsignado);
            pnlNoAsignado.Dock = DockStyle.Left;
            pnlNoAsignado.Location = new Point(0, 112);
            pnlNoAsignado.Name = "pnlNoAsignado";
            pnlNoAsignado.Size = new Size(344, 349);
            pnlNoAsignado.TabIndex = 2;
            // 
            // dgvGrillaNoAsignado
            // 
            dgvGrillaNoAsignado.AllowUserToAddRows = false;
            dgvGrillaNoAsignado.AllowUserToDeleteRows = false;
            dgvGrillaNoAsignado.BackgroundColor = Color.WhiteSmoke;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.Red;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvGrillaNoAsignado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvGrillaNoAsignado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGrillaNoAsignado.Dock = DockStyle.Fill;
            dgvGrillaNoAsignado.GridColor = Color.SteelBlue;
            dgvGrillaNoAsignado.Location = new Point(0, 83);
            dgvGrillaNoAsignado.Name = "dgvGrillaNoAsignado";
            dgvGrillaNoAsignado.RowHeadersVisible = false;
            dataGridViewCellStyle6.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle6.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle6.SelectionForeColor = Color.WhiteSmoke;
            dgvGrillaNoAsignado.RowsDefaultCellStyle = dataGridViewCellStyle6;
            dgvGrillaNoAsignado.RowTemplate.Height = 25;
            dgvGrillaNoAsignado.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGrillaNoAsignado.Size = new Size(344, 222);
            dgvGrillaNoAsignado.TabIndex = 3;
            // 
            // pnlBuscarNoAsignado
            // 
            pnlBuscarNoAsignado.BackColor = Color.Gray;
            pnlBuscarNoAsignado.Controls.Add(btnBuscarNoAsignado);
            pnlBuscarNoAsignado.Controls.Add(txtBuscarNoAsignado);
            pnlBuscarNoAsignado.Controls.Add(label1);
            pnlBuscarNoAsignado.Dock = DockStyle.Top;
            pnlBuscarNoAsignado.Location = new Point(0, 43);
            pnlBuscarNoAsignado.Name = "pnlBuscarNoAsignado";
            pnlBuscarNoAsignado.Size = new Size(344, 40);
            pnlBuscarNoAsignado.TabIndex = 2;
            // 
            // btnBuscarNoAsignado
            // 
            btnBuscarNoAsignado.FlatAppearance.BorderColor = Color.WhiteSmoke;
            btnBuscarNoAsignado.FlatStyle = FlatStyle.Flat;
            btnBuscarNoAsignado.ForeColor = Color.WhiteSmoke;
            btnBuscarNoAsignado.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            btnBuscarNoAsignado.IconColor = Color.WhiteSmoke;
            btnBuscarNoAsignado.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBuscarNoAsignado.IconSize = 15;
            btnBuscarNoAsignado.Location = new Point(287, 8);
            btnBuscarNoAsignado.Name = "btnBuscarNoAsignado";
            btnBuscarNoAsignado.Size = new Size(41, 23);
            btnBuscarNoAsignado.TabIndex = 2;
            btnBuscarNoAsignado.UseVisualStyleBackColor = true;
            btnBuscarNoAsignado.Click += BtnBuscarNoAsignado_Click;
            // 
            // txtBuscarNoAsignado
            // 
            txtBuscarNoAsignado.BorderStyle = BorderStyle.FixedSingle;
            txtBuscarNoAsignado.Location = new Point(58, 8);
            txtBuscarNoAsignado.Name = "txtBuscarNoAsignado";
            txtBuscarNoAsignado.Size = new Size(223, 23);
            txtBuscarNoAsignado.TabIndex = 1;
            txtBuscarNoAsignado.KeyPress += TxtBuscarNoAsignado_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(10, 11);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 0;
            label1.Text = "Buscar";
            // 
            // pnlBotoneraNoAsignado
            // 
            pnlBotoneraNoAsignado.BackColor = Color.Gainsboro;
            pnlBotoneraNoAsignado.Controls.Add(btnDesmarcarNoAsignado);
            pnlBotoneraNoAsignado.Controls.Add(btnMarcarNoAsignado);
            pnlBotoneraNoAsignado.Dock = DockStyle.Bottom;
            pnlBotoneraNoAsignado.Location = new Point(0, 305);
            pnlBotoneraNoAsignado.Name = "pnlBotoneraNoAsignado";
            pnlBotoneraNoAsignado.Size = new Size(344, 44);
            pnlBotoneraNoAsignado.TabIndex = 1;
            // 
            // btnDesmarcarNoAsignado
            // 
            btnDesmarcarNoAsignado.FlatStyle = FlatStyle.Flat;
            btnDesmarcarNoAsignado.IconChar = FontAwesome.Sharp.IconChar.Clone;
            btnDesmarcarNoAsignado.IconColor = Color.Black;
            btnDesmarcarNoAsignado.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDesmarcarNoAsignado.IconSize = 20;
            btnDesmarcarNoAsignado.Location = new Point(47, 6);
            btnDesmarcarNoAsignado.Name = "btnDesmarcarNoAsignado";
            btnDesmarcarNoAsignado.Size = new Size(33, 31);
            btnDesmarcarNoAsignado.TabIndex = 1;
            btnDesmarcarNoAsignado.UseVisualStyleBackColor = true;
            btnDesmarcarNoAsignado.Click += BtnDesmarcarNoAsignado_Click;
            // 
            // btnMarcarNoAsignado
            // 
            btnMarcarNoAsignado.FlatStyle = FlatStyle.Flat;
            btnMarcarNoAsignado.ForeColor = Color.FromArgb(64, 64, 64);
            btnMarcarNoAsignado.IconChar = FontAwesome.Sharp.IconChar.CheckDouble;
            btnMarcarNoAsignado.IconColor = Color.FromArgb(64, 64, 64);
            btnMarcarNoAsignado.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMarcarNoAsignado.IconSize = 20;
            btnMarcarNoAsignado.Location = new Point(8, 6);
            btnMarcarNoAsignado.Name = "btnMarcarNoAsignado";
            btnMarcarNoAsignado.Size = new Size(33, 31);
            btnMarcarNoAsignado.TabIndex = 0;
            btnMarcarNoAsignado.UseVisualStyleBackColor = true;
            btnMarcarNoAsignado.Click += BtnMarcarNoAsignado_Click;
            // 
            // lblTituloNoAsignado
            // 
            lblTituloNoAsignado.BackColor = Color.Gainsboro;
            lblTituloNoAsignado.Dock = DockStyle.Top;
            lblTituloNoAsignado.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTituloNoAsignado.ForeColor = Color.FromArgb(64, 64, 64);
            lblTituloNoAsignado.Location = new Point(0, 0);
            lblTituloNoAsignado.Name = "lblTituloNoAsignado";
            lblTituloNoAsignado.Size = new Size(344, 43);
            lblTituloNoAsignado.TabIndex = 0;
            lblTituloNoAsignado.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlAsignado
            // 
            pnlAsignado.BackColor = Color.FromArgb(255, 255, 192);
            pnlAsignado.Controls.Add(dgvGrillaAsignado);
            pnlAsignado.Controls.Add(pnlBuscarAsignado);
            pnlAsignado.Controls.Add(pnlBotoneraAsignado);
            pnlAsignado.Controls.Add(lblTituloAsignado);
            pnlAsignado.Dock = DockStyle.Right;
            pnlAsignado.Location = new Point(431, 112);
            pnlAsignado.Name = "pnlAsignado";
            pnlAsignado.Size = new Size(353, 349);
            pnlAsignado.TabIndex = 3;
            // 
            // dgvGrillaAsignado
            // 
            dgvGrillaAsignado.AllowUserToAddRows = false;
            dgvGrillaAsignado.AllowUserToDeleteRows = false;
            dgvGrillaAsignado.BackgroundColor = Color.WhiteSmoke;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.Red;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgvGrillaAsignado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgvGrillaAsignado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGrillaAsignado.Dock = DockStyle.Fill;
            dgvGrillaAsignado.GridColor = Color.SteelBlue;
            dgvGrillaAsignado.Location = new Point(0, 83);
            dgvGrillaAsignado.Name = "dgvGrillaAsignado";
            dgvGrillaAsignado.RowHeadersVisible = false;
            dataGridViewCellStyle8.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle8.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle8.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle8.SelectionForeColor = Color.WhiteSmoke;
            dgvGrillaAsignado.RowsDefaultCellStyle = dataGridViewCellStyle8;
            dgvGrillaAsignado.RowTemplate.Height = 25;
            dgvGrillaAsignado.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGrillaAsignado.Size = new Size(353, 222);
            dgvGrillaAsignado.TabIndex = 4;
            // 
            // pnlBuscarAsignado
            // 
            pnlBuscarAsignado.BackColor = Color.Gray;
            pnlBuscarAsignado.Controls.Add(btnBuscarAsignado);
            pnlBuscarAsignado.Controls.Add(txtBuscarAsignado);
            pnlBuscarAsignado.Controls.Add(label2);
            pnlBuscarAsignado.Dock = DockStyle.Top;
            pnlBuscarAsignado.Location = new Point(0, 43);
            pnlBuscarAsignado.Name = "pnlBuscarAsignado";
            pnlBuscarAsignado.Size = new Size(353, 40);
            pnlBuscarAsignado.TabIndex = 3;
            // 
            // btnBuscarAsignado
            // 
            btnBuscarAsignado.FlatAppearance.BorderColor = Color.WhiteSmoke;
            btnBuscarAsignado.FlatStyle = FlatStyle.Flat;
            btnBuscarAsignado.ForeColor = Color.WhiteSmoke;
            btnBuscarAsignado.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            btnBuscarAsignado.IconColor = Color.WhiteSmoke;
            btnBuscarAsignado.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBuscarAsignado.IconSize = 15;
            btnBuscarAsignado.Location = new Point(301, 8);
            btnBuscarAsignado.Name = "btnBuscarAsignado";
            btnBuscarAsignado.Size = new Size(41, 23);
            btnBuscarAsignado.TabIndex = 5;
            btnBuscarAsignado.UseVisualStyleBackColor = true;
            btnBuscarAsignado.Click += BtnBuscarAsignado_Click;
            // 
            // txtBuscarAsignado
            // 
            txtBuscarAsignado.BorderStyle = BorderStyle.FixedSingle;
            txtBuscarAsignado.Location = new Point(72, 8);
            txtBuscarAsignado.Name = "txtBuscarAsignado";
            txtBuscarAsignado.Size = new Size(223, 23);
            txtBuscarAsignado.TabIndex = 4;
            txtBuscarAsignado.KeyPress += TxtBuscarAsignado_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(24, 11);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 3;
            label2.Text = "Buscar";
            // 
            // pnlBotoneraAsignado
            // 
            pnlBotoneraAsignado.BackColor = Color.Gainsboro;
            pnlBotoneraAsignado.Controls.Add(btnDesmarcarAsignado);
            pnlBotoneraAsignado.Controls.Add(btnMarcarAsignado);
            pnlBotoneraAsignado.Dock = DockStyle.Bottom;
            pnlBotoneraAsignado.Location = new Point(0, 305);
            pnlBotoneraAsignado.Name = "pnlBotoneraAsignado";
            pnlBotoneraAsignado.Size = new Size(353, 44);
            pnlBotoneraAsignado.TabIndex = 2;
            // 
            // btnDesmarcarAsignado
            // 
            btnDesmarcarAsignado.FlatStyle = FlatStyle.Flat;
            btnDesmarcarAsignado.IconChar = FontAwesome.Sharp.IconChar.Clone;
            btnDesmarcarAsignado.IconColor = Color.Black;
            btnDesmarcarAsignado.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDesmarcarAsignado.IconSize = 20;
            btnDesmarcarAsignado.Location = new Point(50, 6);
            btnDesmarcarAsignado.Name = "btnDesmarcarAsignado";
            btnDesmarcarAsignado.Size = new Size(33, 31);
            btnDesmarcarAsignado.TabIndex = 3;
            btnDesmarcarAsignado.UseVisualStyleBackColor = true;
            btnDesmarcarAsignado.Click += BtnDesmarcarAsignado_Click;
            // 
            // btnMarcarAsignado
            // 
            btnMarcarAsignado.FlatStyle = FlatStyle.Flat;
            btnMarcarAsignado.ForeColor = Color.FromArgb(64, 64, 64);
            btnMarcarAsignado.IconChar = FontAwesome.Sharp.IconChar.CheckDouble;
            btnMarcarAsignado.IconColor = Color.FromArgb(64, 64, 64);
            btnMarcarAsignado.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMarcarAsignado.IconSize = 20;
            btnMarcarAsignado.Location = new Point(11, 6);
            btnMarcarAsignado.Name = "btnMarcarAsignado";
            btnMarcarAsignado.Size = new Size(33, 31);
            btnMarcarAsignado.TabIndex = 2;
            btnMarcarAsignado.UseVisualStyleBackColor = true;
            btnMarcarAsignado.Click += BtnMarcarAsignado_Click;
            // 
            // lblTituloAsignado
            // 
            lblTituloAsignado.BackColor = Color.Gainsboro;
            lblTituloAsignado.Dock = DockStyle.Top;
            lblTituloAsignado.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTituloAsignado.ForeColor = Color.FromArgb(64, 64, 64);
            lblTituloAsignado.Location = new Point(0, 0);
            lblTituloAsignado.Name = "lblTituloAsignado";
            lblTituloAsignado.Size = new Size(353, 43);
            lblTituloAsignado.TabIndex = 1;
            lblTituloAsignado.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlCentro
            // 
            pnlCentro.Controls.Add(btnQuitar);
            pnlCentro.Controls.Add(btnAgregar);
            pnlCentro.Dock = DockStyle.Fill;
            pnlCentro.Location = new Point(344, 112);
            pnlCentro.Name = "pnlCentro";
            pnlCentro.Size = new Size(87, 349);
            pnlCentro.TabIndex = 4;
            // 
            // btnQuitar
            // 
            btnQuitar.FlatStyle = FlatStyle.Flat;
            btnQuitar.ForeColor = Color.FromArgb(64, 64, 64);
            btnQuitar.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            btnQuitar.IconColor = Color.FromArgb(192, 64, 0);
            btnQuitar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnQuitar.IconSize = 30;
            btnQuitar.Location = new Point(10, 202);
            btnQuitar.Name = "btnQuitar";
            btnQuitar.Size = new Size(68, 63);
            btnQuitar.TabIndex = 1;
            btnQuitar.Text = "Quitar";
            btnQuitar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnQuitar.UseVisualStyleBackColor = true;
            btnQuitar.Click += BtnQuitar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.ForeColor = Color.FromArgb(64, 64, 64);
            btnAgregar.IconChar = FontAwesome.Sharp.IconChar.ArrowRight;
            btnAgregar.IconColor = Color.FromArgb(192, 64, 0);
            btnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAgregar.IconSize = 30;
            btnAgregar.Location = new Point(10, 119);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(68, 63);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "Agregar";
            btnAgregar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += BtnAgregar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Anchor = AnchorStyles.Right;
            btnSalir.BackColor = Color.FromArgb(54, 74, 90);
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.ForeColor = Color.WhiteSmoke;
            btnSalir.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            btnSalir.IconColor = Color.WhiteSmoke;
            btnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSalir.IconSize = 25;
            btnSalir.Location = new Point(728, 5);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(48, 45);
            btnSalir.TabIndex = 2;
            btnSalir.Text = "Salir";
            btnSalir.TextImageRelation = TextImageRelation.ImageAboveText;
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += BtnSalir_Click;
            // 
            // FormularioAsignarQuitar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 461);
            Controls.Add(pnlCentro);
            Controls.Add(pnlAsignado);
            Controls.Add(pnlNoAsignado);
            Controls.Add(pnlEntidadSeleccionada);
            Controls.Add(pnlSuperior);
            MaximizeBox = false;
            MaximumSize = new Size(800, 500);
            MinimizeBox = false;
            MinimumSize = new Size(800, 500);
            Name = "FormularioAsignarQuitar";
            StartPosition = FormStartPosition.CenterParent;
            Load += FormularioAsignarQuitar_Load;
            pnlSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)imgLogoTitulo).EndInit();
            pnlEntidadSeleccionada.ResumeLayout(false);
            pnlNoAsignado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvGrillaNoAsignado).EndInit();
            pnlBuscarNoAsignado.ResumeLayout(false);
            pnlBuscarNoAsignado.PerformLayout();
            pnlBotoneraNoAsignado.ResumeLayout(false);
            pnlAsignado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvGrillaAsignado).EndInit();
            pnlBuscarAsignado.ResumeLayout(false);
            pnlBuscarAsignado.PerformLayout();
            pnlBotoneraAsignado.ResumeLayout(false);
            pnlCentro.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlSuperior;
        private Panel pnlEntidadSeleccionada;
        private Panel pnlLinea;
        private FontAwesome.Sharp.IconPictureBox imgLogoTitulo;
        private Label lblTitulo;
        private Label lblEntidadSeleccionada;
        private Panel pnlNoAsignado;
        private Panel pnlAsignado;
        private Panel pnlCentro;
        private FontAwesome.Sharp.IconButton btnQuitar;
        private FontAwesome.Sharp.IconButton btnAgregar;
        private Label lblTituloNoAsignado;
        private Label lblTituloAsignado;
        private Panel pnlBotoneraNoAsignado;
        private Panel pnlBotoneraAsignado;
        private FontAwesome.Sharp.IconButton btnDesmarcarNoAsignado;
        private FontAwesome.Sharp.IconButton btnMarcarNoAsignado;
        private FontAwesome.Sharp.IconButton btnDesmarcarAsignado;
        private FontAwesome.Sharp.IconButton btnMarcarAsignado;
        private Panel pnlBuscarNoAsignado;
        private FontAwesome.Sharp.IconButton btnBuscarNoAsignado;
        private TextBox txtBuscarNoAsignado;
        private Label label1;
        private Panel pnlBuscarAsignado;
        private FontAwesome.Sharp.IconButton btnBuscarAsignado;
        private TextBox txtBuscarAsignado;
        private Label label2;
        public DataGridView dgvGrillaNoAsignado;
        public DataGridView dgvGrillaAsignado;
        private FontAwesome.Sharp.IconButton btnSalir;
    }
}