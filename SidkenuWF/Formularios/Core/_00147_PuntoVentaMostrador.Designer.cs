namespace SidkenuWF.Formularios.Core
{
    partial class _00147_PuntoVentaMostrador
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
            pnlBotonera = new Panel();
            btnVerDetalle = new FontAwesome.Sharp.IconButton();
            btnElimnarItem = new FontAwesome.Sharp.IconButton();
            btnCambiarCantidad = new FontAwesome.Sharp.IconButton();
            panel3 = new Panel();
            panel2 = new Panel();
            pnlDatosPrincipal = new Panel();
            btnBorrarCliente = new FontAwesome.Sharp.IconButton();
            btnBuscarVendedor = new FontAwesome.Sharp.IconButton();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            txtDocumentoCliente = new TextBox();
            txtTelefonoCliente = new TextBox();
            txtDireccionCliente = new TextBox();
            btnNuevoCliente = new FontAwesome.Sharp.IconButton();
            txtFecha = new TextBox();
            label6 = new Label();
            pnlLineaDatosGenerales = new Panel();
            cmbListaPrecio = new ComboBox();
            lblListaPrecio = new Label();
            txtApyNomVendedor = new TextBox();
            lblVendedor = new Label();
            btnBuscarCliente = new FontAwesome.Sharp.IconButton();
            txtApyNomCliente = new TextBox();
            lblCliente = new Label();
            pnlArticulo = new Panel();
            imgOperacion = new FontAwesome.Sharp.IconPictureBox();
            txtArticulo = new TextBox();
            pnlModoManual = new Panel();
            btnAgregarItem = new FontAwesome.Sharp.IconButton();
            pnlLineaBusqueda = new Panel();
            label4 = new Label();
            label3 = new Label();
            nudCantidad = new NumericUpDown();
            btnBuscar = new FontAwesome.Sharp.IconButton();
            txtBuscar = new TextBox();
            pnlTotalizadores = new Panel();
            btnActivarModoManual = new FontAwesome.Sharp.IconButton();
            btnActivarBalanza = new FontAwesome.Sharp.IconButton();
            btnCargarArticuloFabricacion = new FontAwesome.Sharp.IconButton();
            btnBuscarArticulo = new FontAwesome.Sharp.IconButton();
            btnFacturar = new FontAwesome.Sharp.IconButton();
            label5 = new Label();
            label2 = new Label();
            label1 = new Label();
            nudDescuento = new NumericUpDown();
            txtTotal = new TextBox();
            txtSubTotal = new TextBox();
            pnlDetalle = new Panel();
            dgvGrilla = new DataGridView();
            MenuGrilla = new ContextMenuStrip(components);
            cambiarCantidadMenuItem = new ToolStripMenuItem();
            eliminarItemMenuItem = new ToolStripMenuItem();
            pnlUltimoIngreso = new Panel();
            panel4 = new Panel();
            lblUltimoItem = new Label();
            panel1 = new Panel();
            pnlBotonera.SuspendLayout();
            pnlDatosPrincipal.SuspendLayout();
            pnlArticulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgOperacion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            pnlTotalizadores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudDescuento).BeginInit();
            pnlDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGrilla).BeginInit();
            MenuGrilla.SuspendLayout();
            pnlUltimoIngreso.SuspendLayout();
            SuspendLayout();
            // 
            // pnlBotonera
            // 
            pnlBotonera.BackColor = Color.Gainsboro;
            pnlBotonera.Controls.Add(btnVerDetalle);
            pnlBotonera.Controls.Add(btnElimnarItem);
            pnlBotonera.Controls.Add(btnCambiarCantidad);
            pnlBotonera.Controls.Add(panel3);
            pnlBotonera.Controls.Add(panel2);
            pnlBotonera.Dock = DockStyle.Right;
            pnlBotonera.Location = new Point(719, 180);
            pnlBotonera.Name = "pnlBotonera";
            pnlBotonera.Size = new Size(65, 381);
            pnlBotonera.TabIndex = 1;
            // 
            // btnVerDetalle
            // 
            btnVerDetalle.BackColor = Color.FromArgb(64, 64, 64);
            btnVerDetalle.Dock = DockStyle.Top;
            btnVerDetalle.FlatAppearance.BorderSize = 0;
            btnVerDetalle.FlatStyle = FlatStyle.Flat;
            btnVerDetalle.ForeColor = Color.White;
            btnVerDetalle.IconChar = FontAwesome.Sharp.IconChar.ListAlt;
            btnVerDetalle.IconColor = Color.FromArgb(255, 128, 0);
            btnVerDetalle.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnVerDetalle.IconSize = 20;
            btnVerDetalle.Location = new Point(1, 116);
            btnVerDetalle.Name = "btnVerDetalle";
            btnVerDetalle.Size = new Size(64, 58);
            btnVerDetalle.TabIndex = 16;
            btnVerDetalle.Text = "Ver Detalle";
            btnVerDetalle.TextImageRelation = TextImageRelation.ImageAboveText;
            btnVerDetalle.UseVisualStyleBackColor = false;
            btnVerDetalle.Visible = false;
            btnVerDetalle.Click += BtnVerDetalle_Click;
            // 
            // btnElimnarItem
            // 
            btnElimnarItem.BackColor = Color.FromArgb(64, 64, 64);
            btnElimnarItem.Dock = DockStyle.Top;
            btnElimnarItem.FlatAppearance.BorderSize = 0;
            btnElimnarItem.FlatStyle = FlatStyle.Flat;
            btnElimnarItem.ForeColor = Color.White;
            btnElimnarItem.IconChar = FontAwesome.Sharp.IconChar.Trash;
            btnElimnarItem.IconColor = Color.FromArgb(255, 128, 0);
            btnElimnarItem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnElimnarItem.IconSize = 20;
            btnElimnarItem.Location = new Point(1, 58);
            btnElimnarItem.Name = "btnElimnarItem";
            btnElimnarItem.Size = new Size(64, 58);
            btnElimnarItem.TabIndex = 15;
            btnElimnarItem.Text = "Borrar";
            btnElimnarItem.TextImageRelation = TextImageRelation.ImageAboveText;
            btnElimnarItem.UseVisualStyleBackColor = false;
            btnElimnarItem.Visible = false;
            btnElimnarItem.Click += EliminarItemToolStripMenuItem_Click;
            // 
            // btnCambiarCantidad
            // 
            btnCambiarCantidad.BackColor = Color.FromArgb(64, 64, 64);
            btnCambiarCantidad.Dock = DockStyle.Top;
            btnCambiarCantidad.FlatAppearance.BorderSize = 0;
            btnCambiarCantidad.FlatStyle = FlatStyle.Flat;
            btnCambiarCantidad.ForeColor = Color.White;
            btnCambiarCantidad.IconChar = FontAwesome.Sharp.IconChar.ListNumeric;
            btnCambiarCantidad.IconColor = Color.FromArgb(255, 128, 0);
            btnCambiarCantidad.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCambiarCantidad.IconSize = 20;
            btnCambiarCantidad.Location = new Point(1, 0);
            btnCambiarCantidad.Name = "btnCambiarCantidad";
            btnCambiarCantidad.Size = new Size(64, 58);
            btnCambiarCantidad.TabIndex = 14;
            btnCambiarCantidad.Text = "Cambiar Cantidad";
            btnCambiarCantidad.TextImageRelation = TextImageRelation.ImageAboveText;
            btnCambiarCantidad.UseVisualStyleBackColor = false;
            btnCambiarCantidad.Visible = false;
            btnCambiarCantidad.Click += CambiarCantidadToolStripMenuItem_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(192, 64, 0);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(1, 380);
            panel3.Name = "panel3";
            panel3.Size = new Size(64, 1);
            panel3.TabIndex = 13;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(192, 64, 0);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1, 381);
            panel2.TabIndex = 12;
            // 
            // pnlDatosPrincipal
            // 
            pnlDatosPrincipal.BackColor = Color.WhiteSmoke;
            pnlDatosPrincipal.Controls.Add(btnBorrarCliente);
            pnlDatosPrincipal.Controls.Add(btnBuscarVendedor);
            pnlDatosPrincipal.Controls.Add(label10);
            pnlDatosPrincipal.Controls.Add(label9);
            pnlDatosPrincipal.Controls.Add(label8);
            pnlDatosPrincipal.Controls.Add(txtDocumentoCliente);
            pnlDatosPrincipal.Controls.Add(txtTelefonoCliente);
            pnlDatosPrincipal.Controls.Add(txtDireccionCliente);
            pnlDatosPrincipal.Controls.Add(btnNuevoCliente);
            pnlDatosPrincipal.Controls.Add(txtFecha);
            pnlDatosPrincipal.Controls.Add(label6);
            pnlDatosPrincipal.Controls.Add(pnlLineaDatosGenerales);
            pnlDatosPrincipal.Controls.Add(cmbListaPrecio);
            pnlDatosPrincipal.Controls.Add(lblListaPrecio);
            pnlDatosPrincipal.Controls.Add(txtApyNomVendedor);
            pnlDatosPrincipal.Controls.Add(lblVendedor);
            pnlDatosPrincipal.Controls.Add(btnBuscarCliente);
            pnlDatosPrincipal.Controls.Add(txtApyNomCliente);
            pnlDatosPrincipal.Controls.Add(lblCliente);
            pnlDatosPrincipal.Dock = DockStyle.Top;
            pnlDatosPrincipal.Location = new Point(0, 59);
            pnlDatosPrincipal.Name = "pnlDatosPrincipal";
            pnlDatosPrincipal.Size = new Size(784, 121);
            pnlDatosPrincipal.TabIndex = 2;
            // 
            // btnBorrarCliente
            // 
            btnBorrarCliente.BackColor = Color.White;
            btnBorrarCliente.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            btnBorrarCliente.FlatStyle = FlatStyle.Flat;
            btnBorrarCliente.ForeColor = Color.FromArgb(64, 64, 64);
            btnBorrarCliente.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            btnBorrarCliente.IconColor = Color.FromArgb(64, 64, 64);
            btnBorrarCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBorrarCliente.IconSize = 15;
            btnBorrarCliente.Location = new Point(374, 10);
            btnBorrarCliente.Name = "btnBorrarCliente";
            btnBorrarCliente.Size = new Size(27, 23);
            btnBorrarCliente.TabIndex = 23;
            btnBorrarCliente.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBorrarCliente.UseVisualStyleBackColor = false;
            btnBorrarCliente.Click += BtnBorrarCliente_Click;
            // 
            // btnBuscarVendedor
            // 
            btnBuscarVendedor.BackColor = Color.White;
            btnBuscarVendedor.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            btnBuscarVendedor.FlatStyle = FlatStyle.Flat;
            btnBuscarVendedor.ForeColor = Color.FromArgb(64, 64, 64);
            btnBuscarVendedor.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            btnBuscarVendedor.IconColor = Color.FromArgb(64, 64, 64);
            btnBuscarVendedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBuscarVendedor.IconSize = 15;
            btnBuscarVendedor.Location = new Point(407, 90);
            btnBuscarVendedor.Name = "btnBuscarVendedor";
            btnBuscarVendedor.Size = new Size(27, 23);
            btnBuscarVendedor.TabIndex = 8;
            btnBuscarVendedor.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBuscarVendedor.UseVisualStyleBackColor = false;
            btnBuscarVendedor.Click += BtnBuscarVendedor_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(232, 64);
            label10.Name = "label10";
            label10.Size = new Size(70, 15);
            label10.TabIndex = 22;
            label10.Text = "Documento";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(41, 64);
            label9.Name = "label9";
            label9.Size = new Size(52, 15);
            label9.TabIndex = 21;
            label9.Text = "Telefono";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(36, 39);
            label8.Name = "label8";
            label8.Size = new Size(57, 15);
            label8.TabIndex = 20;
            label8.Text = "Direccion";
            // 
            // txtDocumentoCliente
            // 
            txtDocumentoCliente.BackColor = Color.White;
            txtDocumentoCliente.BorderStyle = BorderStyle.FixedSingle;
            txtDocumentoCliente.Enabled = false;
            txtDocumentoCliente.Location = new Point(308, 60);
            txtDocumentoCliente.Name = "txtDocumentoCliente";
            txtDocumentoCliente.ReadOnly = true;
            txtDocumentoCliente.Size = new Size(126, 23);
            txtDocumentoCliente.TabIndex = 19;
            // 
            // txtTelefonoCliente
            // 
            txtTelefonoCliente.BackColor = Color.White;
            txtTelefonoCliente.BorderStyle = BorderStyle.FixedSingle;
            txtTelefonoCliente.Enabled = false;
            txtTelefonoCliente.Location = new Point(98, 60);
            txtTelefonoCliente.Name = "txtTelefonoCliente";
            txtTelefonoCliente.ReadOnly = true;
            txtTelefonoCliente.Size = new Size(96, 23);
            txtTelefonoCliente.TabIndex = 18;
            // 
            // txtDireccionCliente
            // 
            txtDireccionCliente.BackColor = Color.White;
            txtDireccionCliente.BorderStyle = BorderStyle.FixedSingle;
            txtDireccionCliente.Enabled = false;
            txtDireccionCliente.Location = new Point(98, 35);
            txtDireccionCliente.Name = "txtDireccionCliente";
            txtDireccionCliente.ReadOnly = true;
            txtDireccionCliente.Size = new Size(336, 23);
            txtDireccionCliente.TabIndex = 17;
            // 
            // btnNuevoCliente
            // 
            btnNuevoCliente.BackColor = Color.White;
            btnNuevoCliente.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            btnNuevoCliente.FlatStyle = FlatStyle.Flat;
            btnNuevoCliente.ForeColor = Color.FromArgb(64, 64, 64);
            btnNuevoCliente.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            btnNuevoCliente.IconColor = Color.FromArgb(64, 64, 64);
            btnNuevoCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnNuevoCliente.IconSize = 15;
            btnNuevoCliente.Location = new Point(407, 10);
            btnNuevoCliente.Name = "btnNuevoCliente";
            btnNuevoCliente.Size = new Size(27, 23);
            btnNuevoCliente.TabIndex = 16;
            btnNuevoCliente.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNuevoCliente.UseVisualStyleBackColor = false;
            btnNuevoCliente.Click += BtnNuevoCliente_Click;
            // 
            // txtFecha
            // 
            txtFecha.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtFecha.BackColor = Color.White;
            txtFecha.BorderStyle = BorderStyle.FixedSingle;
            txtFecha.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtFecha.Location = new Point(597, 8);
            txtFecha.Name = "txtFecha";
            txtFecha.ReadOnly = true;
            txtFecha.Size = new Size(171, 25);
            txtFecha.TabIndex = 13;
            txtFecha.TextAlign = HorizontalAlignment.Center;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(554, 12);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 12;
            label6.Text = "Fecha";
            // 
            // pnlLineaDatosGenerales
            // 
            pnlLineaDatosGenerales.BackColor = Color.FromArgb(192, 64, 0);
            pnlLineaDatosGenerales.Dock = DockStyle.Bottom;
            pnlLineaDatosGenerales.Location = new Point(0, 120);
            pnlLineaDatosGenerales.Name = "pnlLineaDatosGenerales";
            pnlLineaDatosGenerales.Size = new Size(784, 1);
            pnlLineaDatosGenerales.TabIndex = 11;
            // 
            // cmbListaPrecio
            // 
            cmbListaPrecio.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cmbListaPrecio.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbListaPrecio.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            cmbListaPrecio.FormattingEnabled = true;
            cmbListaPrecio.Location = new Point(597, 87);
            cmbListaPrecio.Name = "cmbListaPrecio";
            cmbListaPrecio.Size = new Size(171, 25);
            cmbListaPrecio.TabIndex = 10;
            // 
            // lblListaPrecio
            // 
            lblListaPrecio.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblListaPrecio.AutoSize = true;
            lblListaPrecio.Location = new Point(509, 92);
            lblListaPrecio.Name = "lblListaPrecio";
            lblListaPrecio.Size = new Size(83, 15);
            lblListaPrecio.TabIndex = 9;
            lblListaPrecio.Text = "Lista de Precio";
            // 
            // txtApyNomVendedor
            // 
            txtApyNomVendedor.BackColor = Color.White;
            txtApyNomVendedor.BorderStyle = BorderStyle.FixedSingle;
            txtApyNomVendedor.Enabled = false;
            txtApyNomVendedor.Location = new Point(99, 90);
            txtApyNomVendedor.Name = "txtApyNomVendedor";
            txtApyNomVendedor.ReadOnly = true;
            txtApyNomVendedor.Size = new Size(309, 23);
            txtApyNomVendedor.TabIndex = 7;
            // 
            // lblVendedor
            // 
            lblVendedor.AutoSize = true;
            lblVendedor.Location = new Point(36, 94);
            lblVendedor.Name = "lblVendedor";
            lblVendedor.Size = new Size(57, 15);
            lblVendedor.TabIndex = 5;
            lblVendedor.Text = "Vendedor";
            // 
            // btnBuscarCliente
            // 
            btnBuscarCliente.BackColor = Color.White;
            btnBuscarCliente.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            btnBuscarCliente.FlatStyle = FlatStyle.Flat;
            btnBuscarCliente.ForeColor = Color.FromArgb(64, 64, 64);
            btnBuscarCliente.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            btnBuscarCliente.IconColor = Color.FromArgb(64, 64, 64);
            btnBuscarCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBuscarCliente.IconSize = 15;
            btnBuscarCliente.Location = new Point(348, 10);
            btnBuscarCliente.Name = "btnBuscarCliente";
            btnBuscarCliente.Size = new Size(27, 23);
            btnBuscarCliente.TabIndex = 4;
            btnBuscarCliente.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBuscarCliente.UseVisualStyleBackColor = false;
            btnBuscarCliente.Click += BtnBuscarCliente_Click;
            // 
            // txtApyNomCliente
            // 
            txtApyNomCliente.BackColor = Color.White;
            txtApyNomCliente.BorderStyle = BorderStyle.FixedSingle;
            txtApyNomCliente.Location = new Point(98, 10);
            txtApyNomCliente.Name = "txtApyNomCliente";
            txtApyNomCliente.ReadOnly = true;
            txtApyNomCliente.Size = new Size(251, 23);
            txtApyNomCliente.TabIndex = 2;
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Location = new Point(49, 10);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(44, 15);
            lblCliente.TabIndex = 0;
            lblCliente.Text = "Cliente";
            // 
            // pnlArticulo
            // 
            pnlArticulo.BackColor = Color.WhiteSmoke;
            pnlArticulo.Controls.Add(imgOperacion);
            pnlArticulo.Controls.Add(txtArticulo);
            pnlArticulo.Controls.Add(pnlModoManual);
            pnlArticulo.Controls.Add(btnAgregarItem);
            pnlArticulo.Controls.Add(pnlLineaBusqueda);
            pnlArticulo.Controls.Add(label4);
            pnlArticulo.Controls.Add(label3);
            pnlArticulo.Controls.Add(nudCantidad);
            pnlArticulo.Controls.Add(btnBuscar);
            pnlArticulo.Controls.Add(txtBuscar);
            pnlArticulo.Dock = DockStyle.Top;
            pnlArticulo.Location = new Point(0, 180);
            pnlArticulo.Name = "pnlArticulo";
            pnlArticulo.Size = new Size(719, 37);
            pnlArticulo.TabIndex = 3;
            // 
            // imgOperacion
            // 
            imgOperacion.BackColor = Color.Transparent;
            imgOperacion.BorderStyle = BorderStyle.FixedSingle;
            imgOperacion.ForeColor = Color.Green;
            imgOperacion.IconChar = FontAwesome.Sharp.IconChar.BalanceScale;
            imgOperacion.IconColor = Color.Green;
            imgOperacion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            imgOperacion.IconSize = 24;
            imgOperacion.Location = new Point(598, 7);
            imgOperacion.Name = "imgOperacion";
            imgOperacion.Size = new Size(25, 24);
            imgOperacion.SizeMode = PictureBoxSizeMode.StretchImage;
            imgOperacion.TabIndex = 17;
            imgOperacion.TabStop = false;
            imgOperacion.Visible = false;
            // 
            // txtArticulo
            // 
            txtArticulo.Anchor = AnchorStyles.Left;
            txtArticulo.BorderStyle = BorderStyle.FixedSingle;
            txtArticulo.Enabled = false;
            txtArticulo.Location = new Point(200, 7);
            txtArticulo.Name = "txtArticulo";
            txtArticulo.Size = new Size(234, 23);
            txtArticulo.TabIndex = 16;
            // 
            // pnlModoManual
            // 
            pnlModoManual.BackColor = Color.Green;
            pnlModoManual.Location = new Point(527, 30);
            pnlModoManual.Name = "pnlModoManual";
            pnlModoManual.Size = new Size(68, 4);
            pnlModoManual.TabIndex = 15;
            pnlModoManual.Visible = false;
            // 
            // btnAgregarItem
            // 
            btnAgregarItem.Anchor = AnchorStyles.Left;
            btnAgregarItem.BackColor = Color.White;
            btnAgregarItem.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            btnAgregarItem.FlatStyle = FlatStyle.Flat;
            btnAgregarItem.ForeColor = Color.FromArgb(64, 64, 64);
            btnAgregarItem.IconChar = FontAwesome.Sharp.IconChar.Add;
            btnAgregarItem.IconColor = Color.FromArgb(64, 64, 64);
            btnAgregarItem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAgregarItem.IconSize = 15;
            btnAgregarItem.Location = new Point(628, 4);
            btnAgregarItem.Name = "btnAgregarItem";
            btnAgregarItem.Size = new Size(85, 28);
            btnAgregarItem.TabIndex = 14;
            btnAgregarItem.Text = "Agregar";
            btnAgregarItem.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAgregarItem.UseVisualStyleBackColor = false;
            btnAgregarItem.Click += BtnAgregarItem_Click;
            // 
            // pnlLineaBusqueda
            // 
            pnlLineaBusqueda.BackColor = Color.FromArgb(192, 64, 0);
            pnlLineaBusqueda.Dock = DockStyle.Bottom;
            pnlLineaBusqueda.Location = new Point(0, 36);
            pnlLineaBusqueda.Name = "pnlLineaBusqueda";
            pnlLineaBusqueda.Size = new Size(719, 1);
            pnlLineaBusqueda.TabIndex = 13;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Location = new Point(466, 11);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 12;
            label4.Text = "Cantidad";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Location = new Point(33, 11);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 11;
            label3.Text = "Busqueda";
            // 
            // nudCantidad
            // 
            nudCantidad.Anchor = AnchorStyles.Left;
            nudCantidad.DecimalPlaces = 2;
            nudCantidad.Enabled = false;
            nudCantidad.Location = new Point(527, 7);
            nudCantidad.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(68, 23);
            nudCantidad.TabIndex = 9;
            nudCantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            nudCantidad.KeyPress += NudCantidad_KeyPress;
            // 
            // btnBuscar
            // 
            btnBuscar.Anchor = AnchorStyles.Left;
            btnBuscar.BackColor = Color.White;
            btnBuscar.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.ForeColor = Color.FromArgb(64, 64, 64);
            btnBuscar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            btnBuscar.IconColor = Color.FromArgb(64, 64, 64);
            btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBuscar.IconSize = 15;
            btnBuscar.Location = new Point(433, 7);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(27, 23);
            btnBuscar.TabIndex = 7;
            btnBuscar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += BtnBuscar_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.Anchor = AnchorStyles.Left;
            txtBuscar.BorderStyle = BorderStyle.FixedSingle;
            txtBuscar.Location = new Point(99, 7);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(95, 23);
            txtBuscar.TabIndex = 6;
            txtBuscar.KeyPress += TxtBuscar_KeyPress;
            // 
            // pnlTotalizadores
            // 
            pnlTotalizadores.BackColor = Color.WhiteSmoke;
            pnlTotalizadores.Controls.Add(btnActivarModoManual);
            pnlTotalizadores.Controls.Add(btnActivarBalanza);
            pnlTotalizadores.Controls.Add(btnCargarArticuloFabricacion);
            pnlTotalizadores.Controls.Add(btnBuscarArticulo);
            pnlTotalizadores.Controls.Add(btnFacturar);
            pnlTotalizadores.Controls.Add(label5);
            pnlTotalizadores.Controls.Add(label2);
            pnlTotalizadores.Controls.Add(label1);
            pnlTotalizadores.Controls.Add(nudDescuento);
            pnlTotalizadores.Controls.Add(txtTotal);
            pnlTotalizadores.Controls.Add(txtSubTotal);
            pnlTotalizadores.Dock = DockStyle.Bottom;
            pnlTotalizadores.Location = new Point(0, 451);
            pnlTotalizadores.Name = "pnlTotalizadores";
            pnlTotalizadores.Size = new Size(719, 110);
            pnlTotalizadores.TabIndex = 4;
            // 
            // btnActivarModoManual
            // 
            btnActivarModoManual.BackColor = Color.FromArgb(54, 74, 90);
            btnActivarModoManual.FlatAppearance.BorderColor = Color.WhiteSmoke;
            btnActivarModoManual.FlatAppearance.BorderSize = 0;
            btnActivarModoManual.FlatStyle = FlatStyle.Flat;
            btnActivarModoManual.ForeColor = Color.WhiteSmoke;
            btnActivarModoManual.IconChar = FontAwesome.Sharp.IconChar.MoneyBills;
            btnActivarModoManual.IconColor = Color.WhiteSmoke;
            btnActivarModoManual.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnActivarModoManual.IconSize = 22;
            btnActivarModoManual.Location = new Point(9, 73);
            btnActivarModoManual.Name = "btnActivarModoManual";
            btnActivarModoManual.Size = new Size(140, 28);
            btnActivarModoManual.TabIndex = 10;
            btnActivarModoManual.Text = "(F11) Act. Manual";
            btnActivarModoManual.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnActivarModoManual.UseVisualStyleBackColor = false;
            btnActivarModoManual.Click += BtnActivarModoManual_Click;
            // 
            // btnActivarBalanza
            // 
            btnActivarBalanza.BackColor = Color.FromArgb(54, 74, 90);
            btnActivarBalanza.FlatAppearance.BorderColor = Color.WhiteSmoke;
            btnActivarBalanza.FlatAppearance.BorderSize = 0;
            btnActivarBalanza.FlatStyle = FlatStyle.Flat;
            btnActivarBalanza.ForeColor = Color.WhiteSmoke;
            btnActivarBalanza.IconChar = FontAwesome.Sharp.IconChar.MoneyBills;
            btnActivarBalanza.IconColor = Color.WhiteSmoke;
            btnActivarBalanza.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnActivarBalanza.IconSize = 22;
            btnActivarBalanza.Location = new Point(153, 40);
            btnActivarBalanza.Name = "btnActivarBalanza";
            btnActivarBalanza.Size = new Size(140, 28);
            btnActivarBalanza.TabIndex = 9;
            btnActivarBalanza.Text = "(F9) Act. Balanza";
            btnActivarBalanza.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnActivarBalanza.UseVisualStyleBackColor = false;
            btnActivarBalanza.Click += BtnActivarBalanza_Click;
            // 
            // btnCargarArticuloFabricacion
            // 
            btnCargarArticuloFabricacion.BackColor = Color.FromArgb(54, 74, 90);
            btnCargarArticuloFabricacion.FlatAppearance.BorderColor = Color.WhiteSmoke;
            btnCargarArticuloFabricacion.FlatAppearance.BorderSize = 0;
            btnCargarArticuloFabricacion.FlatStyle = FlatStyle.Flat;
            btnCargarArticuloFabricacion.ForeColor = Color.WhiteSmoke;
            btnCargarArticuloFabricacion.IconChar = FontAwesome.Sharp.IconChar.MoneyBills;
            btnCargarArticuloFabricacion.IconColor = Color.WhiteSmoke;
            btnCargarArticuloFabricacion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCargarArticuloFabricacion.IconSize = 22;
            btnCargarArticuloFabricacion.Location = new Point(9, 40);
            btnCargarArticuloFabricacion.Name = "btnCargarArticuloFabricacion";
            btnCargarArticuloFabricacion.Size = new Size(140, 28);
            btnCargarArticuloFabricacion.TabIndex = 8;
            btnCargarArticuloFabricacion.Text = "(F7) Art. Fabr.";
            btnCargarArticuloFabricacion.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCargarArticuloFabricacion.UseVisualStyleBackColor = false;
            btnCargarArticuloFabricacion.Click += BtnCargarArticuloFabricacion_Click;
            // 
            // btnBuscarArticulo
            // 
            btnBuscarArticulo.BackColor = Color.FromArgb(54, 74, 90);
            btnBuscarArticulo.FlatAppearance.BorderColor = Color.WhiteSmoke;
            btnBuscarArticulo.FlatAppearance.BorderSize = 0;
            btnBuscarArticulo.FlatStyle = FlatStyle.Flat;
            btnBuscarArticulo.ForeColor = Color.WhiteSmoke;
            btnBuscarArticulo.IconChar = FontAwesome.Sharp.IconChar.MoneyBills;
            btnBuscarArticulo.IconColor = Color.WhiteSmoke;
            btnBuscarArticulo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBuscarArticulo.IconSize = 22;
            btnBuscarArticulo.Location = new Point(153, 7);
            btnBuscarArticulo.Name = "btnBuscarArticulo";
            btnBuscarArticulo.Size = new Size(140, 28);
            btnBuscarArticulo.TabIndex = 7;
            btnBuscarArticulo.Text = "(F6) Buscar";
            btnBuscarArticulo.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBuscarArticulo.UseVisualStyleBackColor = false;
            btnBuscarArticulo.Click += BtnBuscar_Click;
            // 
            // btnFacturar
            // 
            btnFacturar.BackColor = Color.FromArgb(54, 74, 90);
            btnFacturar.FlatAppearance.BorderColor = Color.WhiteSmoke;
            btnFacturar.FlatAppearance.BorderSize = 0;
            btnFacturar.FlatStyle = FlatStyle.Flat;
            btnFacturar.ForeColor = Color.WhiteSmoke;
            btnFacturar.IconChar = FontAwesome.Sharp.IconChar.MoneyBills;
            btnFacturar.IconColor = Color.WhiteSmoke;
            btnFacturar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnFacturar.IconSize = 22;
            btnFacturar.Location = new Point(9, 7);
            btnFacturar.Name = "btnFacturar";
            btnFacturar.Size = new Size(140, 28);
            btnFacturar.TabIndex = 6;
            btnFacturar.Text = "(F5) Facturar";
            btnFacturar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnFacturar.UseVisualStyleBackColor = false;
            btnFacturar.Click += BtnFacturar_Click;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(505, 40);
            label5.Name = "label5";
            label5.Size = new Size(105, 20);
            label5.TabIndex = 5;
            label5.Text = "Descuento [%}";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(346, 73);
            label2.Name = "label2";
            label2.Size = new Size(154, 25);
            label2.TabIndex = 4;
            label2.Text = "TOTAL A PAGAR";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(428, 10);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 3;
            label1.Text = "Sub-Total";
            // 
            // nudDescuento
            // 
            nudDescuento.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            nudDescuento.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            nudDescuento.Location = new Point(613, 37);
            nudDescuento.Name = "nudDescuento";
            nudDescuento.Size = new Size(99, 27);
            nudDescuento.TabIndex = 2;
            nudDescuento.TextAlign = HorizontalAlignment.Right;
            nudDescuento.ValueChanged += NudDescuento_ValueChanged;
            // 
            // txtTotal
            // 
            txtTotal.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtTotal.BackColor = Color.FromArgb(64, 64, 64);
            txtTotal.BorderStyle = BorderStyle.FixedSingle;
            txtTotal.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtTotal.ForeColor = Color.White;
            txtTotal.Location = new Point(505, 68);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(207, 35);
            txtTotal.TabIndex = 1;
            txtTotal.TextAlign = HorizontalAlignment.Right;
            // 
            // txtSubTotal
            // 
            txtSubTotal.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtSubTotal.BackColor = Color.White;
            txtSubTotal.BorderStyle = BorderStyle.FixedSingle;
            txtSubTotal.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtSubTotal.Location = new Point(505, 7);
            txtSubTotal.Name = "txtSubTotal";
            txtSubTotal.ReadOnly = true;
            txtSubTotal.Size = new Size(207, 27);
            txtSubTotal.TabIndex = 0;
            txtSubTotal.TextAlign = HorizontalAlignment.Right;
            // 
            // pnlDetalle
            // 
            pnlDetalle.BackColor = Color.WhiteSmoke;
            pnlDetalle.Controls.Add(dgvGrilla);
            pnlDetalle.Controls.Add(pnlUltimoIngreso);
            pnlDetalle.Controls.Add(panel1);
            pnlDetalle.Dock = DockStyle.Fill;
            pnlDetalle.Location = new Point(0, 217);
            pnlDetalle.Name = "pnlDetalle";
            pnlDetalle.Size = new Size(719, 234);
            pnlDetalle.TabIndex = 5;
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
            dgvGrilla.ContextMenuStrip = MenuGrilla;
            dgvGrilla.Dock = DockStyle.Fill;
            dgvGrilla.GridColor = Color.FromArgb(64, 64, 64);
            dgvGrilla.Location = new Point(0, 0);
            dgvGrilla.MultiSelect = false;
            dgvGrilla.Name = "dgvGrilla";
            dgvGrilla.RowHeadersVisible = false;
            dgvGrilla.RowTemplate.Height = 25;
            dgvGrilla.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGrilla.Size = new Size(719, 189);
            dgvGrilla.TabIndex = 13;
            dgvGrilla.RowEnter += DgvGrilla_RowEnter;
            dgvGrilla.RowsAdded += DgvGrilla_RowsAdded;
            dgvGrilla.RowsRemoved += DgvGrilla_RowsRemoved;
            // 
            // MenuGrilla
            // 
            MenuGrilla.Items.AddRange(new ToolStripItem[] { cambiarCantidadMenuItem, eliminarItemMenuItem });
            MenuGrilla.Name = "MenuGrilla";
            MenuGrilla.Size = new Size(171, 48);
            // 
            // cambiarCantidadMenuItem
            // 
            cambiarCantidadMenuItem.Name = "cambiarCantidadMenuItem";
            cambiarCantidadMenuItem.Size = new Size(170, 22);
            cambiarCantidadMenuItem.Text = "Cambiar Cantidad";
            cambiarCantidadMenuItem.Visible = false;
            cambiarCantidadMenuItem.Click += CambiarCantidadToolStripMenuItem_Click;
            // 
            // eliminarItemMenuItem
            // 
            eliminarItemMenuItem.Name = "eliminarItemMenuItem";
            eliminarItemMenuItem.Size = new Size(170, 22);
            eliminarItemMenuItem.Text = "Eliminar Item";
            eliminarItemMenuItem.Visible = false;
            eliminarItemMenuItem.Click += EliminarItemToolStripMenuItem_Click;
            // 
            // pnlUltimoIngreso
            // 
            pnlUltimoIngreso.Controls.Add(panel4);
            pnlUltimoIngreso.Controls.Add(lblUltimoItem);
            pnlUltimoIngreso.Dock = DockStyle.Bottom;
            pnlUltimoIngreso.Location = new Point(0, 189);
            pnlUltimoIngreso.Name = "pnlUltimoIngreso";
            pnlUltimoIngreso.Size = new Size(719, 44);
            pnlUltimoIngreso.TabIndex = 14;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(192, 64, 0);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(719, 2);
            panel4.TabIndex = 13;
            // 
            // lblUltimoItem
            // 
            lblUltimoItem.BackColor = Color.FromArgb(64, 64, 64);
            lblUltimoItem.Dock = DockStyle.Fill;
            lblUltimoItem.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblUltimoItem.ForeColor = Color.FromArgb(255, 255, 192);
            lblUltimoItem.Location = new Point(0, 0);
            lblUltimoItem.Name = "lblUltimoItem";
            lblUltimoItem.Size = new Size(719, 44);
            lblUltimoItem.TabIndex = 0;
            lblUltimoItem.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(192, 64, 0);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 233);
            panel1.Name = "panel1";
            panel1.Size = new Size(719, 1);
            panel1.TabIndex = 12;
            // 
            // _00147_PuntoVentaMostrador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(784, 561);
            ControlBox = true;
            Controls.Add(pnlDetalle);
            Controls.Add(pnlTotalizadores);
            Controls.Add(pnlArticulo);
            Controls.Add(pnlBotonera);
            Controls.Add(pnlDatosPrincipal);
            KeyPreview = true;
            MaximizeBox = true;
            MinimizeBox = true;
            MinimumSize = new Size(800, 600);
            Name = "_00147_PuntoVentaMostrador";
            WindowState = FormWindowState.Maximized;
            Load += _00147_PuntoVentaMostrador_Load;
            KeyDown += _00147_PuntoVentaMostrador_KeyDown;
            Controls.SetChildIndex(pnlDatosPrincipal, 0);
            Controls.SetChildIndex(pnlBotonera, 0);
            Controls.SetChildIndex(pnlArticulo, 0);
            Controls.SetChildIndex(pnlTotalizadores, 0);
            Controls.SetChildIndex(pnlDetalle, 0);
            pnlBotonera.ResumeLayout(false);
            pnlDatosPrincipal.ResumeLayout(false);
            pnlDatosPrincipal.PerformLayout();
            pnlArticulo.ResumeLayout(false);
            pnlArticulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imgOperacion).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
            pnlTotalizadores.ResumeLayout(false);
            pnlTotalizadores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudDescuento).EndInit();
            pnlDetalle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvGrilla).EndInit();
            MenuGrilla.ResumeLayout(false);
            pnlUltimoIngreso.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlBotonera;
        private Panel pnlDatosPrincipal;
        private Panel pnlArticulo;
        private Panel pnlTotalizadores;
        private Panel pnlDetalle;
        private Label lblCliente;
        private FontAwesome.Sharp.IconButton btnBuscarCliente;
        private FontAwesome.Sharp.IconButton btnBuscarVendedor;
        private TextBox txtApyNomVendedor;
        private Label lblVendedor;
        private ComboBox cmbListaPrecio;
        private Label lblListaPrecio;
        private NumericUpDown nudCantidad;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private TextBox txtBuscar;
        private Label label4;
        private Label label3;
        private Panel pnlLineaDatosGenerales;
        private Label label1;
        private NumericUpDown nudDescuento;
        private TextBox txtTotal;
        private TextBox txtSubTotal;
        private Label label5;
        private Label label2;
        private Panel panel2;
        private Panel pnlLineaBusqueda;
        private Panel panel1;
        private Panel panel3;
        public DataGridView dgvGrilla;
        private FontAwesome.Sharp.IconButton btnAgregarItem;
        private TextBox txtFecha;
        private Label label6;
        private FontAwesome.Sharp.IconButton btnNuevoCliente;
        private Label label10;
        private Label label9;
        private Label label8;
        private TextBox txtDocumentoCliente;
        private TextBox txtTelefonoCliente;
        private TextBox txtDireccionCliente;
        private Panel pnlModoManual;
        private TextBox txtArticulo;
        private Panel pnlUltimoIngreso;
        private Label lblUltimoItem;
        private Panel panel4;
        private FontAwesome.Sharp.IconPictureBox imgOperacion;
        private ContextMenuStrip MenuGrilla;
        private ToolStripMenuItem cambiarCantidadMenuItem;
        private ToolStripMenuItem eliminarItemMenuItem;
        private FontAwesome.Sharp.IconButton btnCambiarCantidad;
        private FontAwesome.Sharp.IconButton btnElimnarItem;
        private FontAwesome.Sharp.IconButton btnVerDetalle;
        private FontAwesome.Sharp.IconButton btnFacturar;
        private TextBox txtApyNomCliente;
        private FontAwesome.Sharp.IconButton btnBorrarCliente;
        private FontAwesome.Sharp.IconButton btnActivarModoManual;
        private FontAwesome.Sharp.IconButton btnActivarBalanza;
        private FontAwesome.Sharp.IconButton btnCargarArticuloFabricacion;
        private FontAwesome.Sharp.IconButton btnBuscarArticulo;
    }
}