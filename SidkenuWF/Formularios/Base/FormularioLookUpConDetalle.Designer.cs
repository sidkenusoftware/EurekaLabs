namespace SidkenuWF.Formularios.Base
{
    partial class FormularioLookUpConDetalle
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
            pnlTitulo = new Panel();
            imgLogo = new FontAwesome.Sharp.IconPictureBox();
            lblTitulo = new Label();
            btnSalir = new FontAwesome.Sharp.IconButton();
            pnlLinea = new Panel();
            pnlSuperior = new Panel();
            pnlBusqueda = new Panel();
            btnBuscar = new FontAwesome.Sharp.IconButton();
            txtBuscar = new TextBox();
            pnlContenedor = new Panel();
            dgvGrilla = new DataGridView();
            pnlDetalle = new Panel();
            panel2 = new Panel();
            lblTituloDetalle = new Label();
            panel1 = new Panel();
            panel3 = new Panel();
            pnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgLogo).BeginInit();
            pnlSuperior.SuspendLayout();
            pnlBusqueda.SuspendLayout();
            pnlContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGrilla).BeginInit();
            pnlDetalle.SuspendLayout();
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
            pnlTitulo.Size = new Size(934, 59);
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
            lblTitulo.Size = new Size(803, 48);
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
            btnSalir.Location = new Point(869, 5);
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
            pnlLinea.Size = new Size(916, 1);
            pnlLinea.TabIndex = 0;
            // 
            // pnlSuperior
            // 
            pnlSuperior.BackColor = Color.FromArgb(48, 66, 80);
            pnlSuperior.Controls.Add(pnlBusqueda);
            pnlSuperior.Dock = DockStyle.Top;
            pnlSuperior.Location = new Point(0, 59);
            pnlSuperior.Name = "pnlSuperior";
            pnlSuperior.Size = new Size(934, 52);
            pnlSuperior.TabIndex = 1;
            // 
            // pnlBusqueda
            // 
            pnlBusqueda.Controls.Add(btnBuscar);
            pnlBusqueda.Controls.Add(txtBuscar);
            pnlBusqueda.Dock = DockStyle.Fill;
            pnlBusqueda.Location = new Point(0, 0);
            pnlBusqueda.Name = "pnlBusqueda";
            pnlBusqueda.Size = new Size(934, 52);
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
            btnBuscar.Location = new Point(847, 11);
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
            txtBuscar.Location = new Point(19, 11);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = "Ingrese un texto";
            txtBuscar.Size = new Size(822, 29);
            txtBuscar.TabIndex = 2;
            txtBuscar.KeyPress += TxtBuscar_KeyPress;
            // 
            // pnlContenedor
            // 
            pnlContenedor.BackColor = Color.White;
            pnlContenedor.Controls.Add(dgvGrilla);
            pnlContenedor.Controls.Add(pnlDetalle);
            pnlContenedor.Dock = DockStyle.Fill;
            pnlContenedor.Location = new Point(0, 111);
            pnlContenedor.Name = "pnlContenedor";
            pnlContenedor.Size = new Size(934, 450);
            pnlContenedor.TabIndex = 5;
            // 
            // dgvGrilla
            // 
            dgvGrilla.AllowUserToAddRows = false;
            dgvGrilla.AllowUserToDeleteRows = false;
            dgvGrilla.BackgroundColor = Color.White;
            dgvGrilla.BorderStyle = BorderStyle.None;
            dgvGrilla.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGrilla.Dock = DockStyle.Fill;
            dgvGrilla.GridColor = Color.FromArgb(64, 64, 64);
            dgvGrilla.Location = new Point(0, 0);
            dgvGrilla.MultiSelect = false;
            dgvGrilla.Name = "dgvGrilla";
            dgvGrilla.RowHeadersVisible = false;
            dgvGrilla.RowTemplate.Height = 25;
            dgvGrilla.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGrilla.Size = new Size(572, 450);
            dgvGrilla.TabIndex = 0;
            dgvGrilla.RowEnter += DgvGrilla_RowEnter;
            dgvGrilla.DoubleClick += DgvGrilla_DoubleClick;
            // 
            // pnlDetalle
            // 
            pnlDetalle.BackColor = Color.WhiteSmoke;
            pnlDetalle.Controls.Add(panel2);
            pnlDetalle.Controls.Add(lblTituloDetalle);
            pnlDetalle.Controls.Add(panel1);
            pnlDetalle.Controls.Add(panel3);
            pnlDetalle.Dock = DockStyle.Right;
            pnlDetalle.Location = new Point(572, 0);
            pnlDetalle.Name = "pnlDetalle";
            pnlDetalle.Size = new Size(362, 450);
            pnlDetalle.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(192, 64, 0);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(2, 37);
            panel2.Name = "panel2";
            panel2.Size = new Size(360, 2);
            panel2.TabIndex = 2;
            // 
            // lblTituloDetalle
            // 
            lblTituloDetalle.BackColor = Color.FromArgb(48, 66, 80);
            lblTituloDetalle.Dock = DockStyle.Top;
            lblTituloDetalle.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTituloDetalle.ForeColor = Color.White;
            lblTituloDetalle.Location = new Point(2, 2);
            lblTituloDetalle.Name = "lblTituloDetalle";
            lblTituloDetalle.Size = new Size(360, 35);
            lblTituloDetalle.TabIndex = 1;
            lblTituloDetalle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(192, 64, 0);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(2, 448);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(192, 64, 0);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(362, 2);
            panel3.TabIndex = 3;
            // 
            // FormularioLookUpConDetalle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 561);
            ControlBox = false;
            Controls.Add(pnlContenedor);
            Controls.Add(pnlSuperior);
            Controls.Add(pnlTitulo);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MaximumSize = new Size(950, 600);
            MinimizeBox = false;
            MinimumSize = new Size(950, 600);
            Name = "FormularioLookUpConDetalle";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sidkenu 2.0";
            Activated += FormularioConsulta_Activated;
            Load += FormularioConsulta_Load;
            pnlTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)imgLogo).EndInit();
            pnlSuperior.ResumeLayout(false);
            pnlBusqueda.ResumeLayout(false);
            pnlBusqueda.PerformLayout();
            pnlContenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvGrilla).EndInit();
            pnlDetalle.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTitulo;
        private Panel pnlLinea;
        private FontAwesome.Sharp.IconButton btnSalir;
        private Panel pnlSuperior;
        private FontAwesome.Sharp.IconPictureBox imgLogo;
        private Label lblTitulo;
        private Panel pnlContenedor;
        public DataGridView dgvGrilla;
        private Panel pnlBusqueda;
        private FontAwesome.Sharp.IconButton btnBuscar;
        public TextBox txtBuscar;
        public Panel pnlDetalle;
        private Panel panel1;
        private Label lblTituloDetalle;
        private Panel panel2;
        private Panel panel3;
    }
}