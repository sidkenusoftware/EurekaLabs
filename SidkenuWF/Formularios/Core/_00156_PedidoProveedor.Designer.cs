namespace SidkenuWF.Formularios.Core
{
    partial class _00156_PedidoProveedor
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            pnlBotonera = new Panel();
            btnElimnarItem = new FontAwesome.Sharp.IconButton();
            btnCambiarCantidad = new FontAwesome.Sharp.IconButton();
            panel3 = new Panel();
            panel2 = new Panel();
            pnlDatosPrincipal = new Panel();
            panel4 = new Panel();
            btnLimpiarPedido = new FontAwesome.Sharp.IconButton();
            btnArticuloSugerido = new FontAwesome.Sharp.IconButton();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            txtCuitProveedor = new TextBox();
            txtTelefonoProveedor = new TextBox();
            txtDireccionProveedor = new TextBox();
            txtNroPedido = new TextBox();
            label1 = new Label();
            btnBorrarProveedor = new FontAwesome.Sharp.IconButton();
            btnBuscarEmpleado = new FontAwesome.Sharp.IconButton();
            btnNuevoProveedor = new FontAwesome.Sharp.IconButton();
            txtFecha = new TextBox();
            label6 = new Label();
            pnlLineaDatosGenerales = new Panel();
            txtApyNomEmpleado = new TextBox();
            lblVendedor = new Label();
            btnBuscarProveedor = new FontAwesome.Sharp.IconButton();
            txtNombreProveedor = new TextBox();
            lblCliente = new Label();
            pnlArticulo = new Panel();
            txtArticulo = new TextBox();
            label3 = new Label();
            btnBuscar = new FontAwesome.Sharp.IconButton();
            txtBuscar = new TextBox();
            btnAgregarItem = new FontAwesome.Sharp.IconButton();
            pnlLineaBusqueda = new Panel();
            label4 = new Label();
            nudCantidad = new NumericUpDown();
            pnlTotalizadores = new Panel();
            label2 = new Label();
            txtTotal = new TextBox();
            pnlDetalle = new Panel();
            dgvGrilla = new DataGridView();
            MenuGrilla = new ContextMenuStrip(components);
            cambiarCantidadMenuItem = new ToolStripMenuItem();
            eliminarItemMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            pnlBotonera.SuspendLayout();
            pnlDatosPrincipal.SuspendLayout();
            panel4.SuspendLayout();
            pnlArticulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            pnlTotalizadores.SuspendLayout();
            pnlDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGrilla).BeginInit();
            MenuGrilla.SuspendLayout();
            SuspendLayout();
            // 
            // pnlBotonera
            // 
            pnlBotonera.BackColor = Color.Gainsboro;
            pnlBotonera.Controls.Add(btnElimnarItem);
            pnlBotonera.Controls.Add(btnCambiarCantidad);
            pnlBotonera.Controls.Add(panel3);
            pnlBotonera.Controls.Add(panel2);
            pnlBotonera.Dock = DockStyle.Right;
            pnlBotonera.Location = new Point(719, 286);
            pnlBotonera.Name = "pnlBotonera";
            pnlBotonera.Size = new Size(65, 275);
            pnlBotonera.TabIndex = 1;
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
            btnElimnarItem.Click += EliminarItem_Click;
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
            btnCambiarCantidad.Click += CambiarCantidadItem_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(192, 64, 0);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(1, 274);
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
            panel2.Size = new Size(1, 275);
            panel2.TabIndex = 12;
            // 
            // pnlDatosPrincipal
            // 
            pnlDatosPrincipal.BackColor = Color.WhiteSmoke;
            pnlDatosPrincipal.Controls.Add(panel4);
            pnlDatosPrincipal.Controls.Add(label10);
            pnlDatosPrincipal.Controls.Add(label9);
            pnlDatosPrincipal.Controls.Add(label8);
            pnlDatosPrincipal.Controls.Add(txtCuitProveedor);
            pnlDatosPrincipal.Controls.Add(txtTelefonoProveedor);
            pnlDatosPrincipal.Controls.Add(txtDireccionProveedor);
            pnlDatosPrincipal.Controls.Add(txtNroPedido);
            pnlDatosPrincipal.Controls.Add(label1);
            pnlDatosPrincipal.Controls.Add(btnBorrarProveedor);
            pnlDatosPrincipal.Controls.Add(btnBuscarEmpleado);
            pnlDatosPrincipal.Controls.Add(btnNuevoProveedor);
            pnlDatosPrincipal.Controls.Add(txtFecha);
            pnlDatosPrincipal.Controls.Add(label6);
            pnlDatosPrincipal.Controls.Add(pnlLineaDatosGenerales);
            pnlDatosPrincipal.Controls.Add(txtApyNomEmpleado);
            pnlDatosPrincipal.Controls.Add(lblVendedor);
            pnlDatosPrincipal.Controls.Add(btnBuscarProveedor);
            pnlDatosPrincipal.Controls.Add(txtNombreProveedor);
            pnlDatosPrincipal.Controls.Add(lblCliente);
            pnlDatosPrincipal.Dock = DockStyle.Top;
            pnlDatosPrincipal.Location = new Point(0, 59);
            pnlDatosPrincipal.Name = "pnlDatosPrincipal";
            pnlDatosPrincipal.Size = new Size(784, 190);
            pnlDatosPrincipal.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Gainsboro;
            panel4.Controls.Add(btnLimpiarPedido);
            panel4.Controls.Add(btnArticuloSugerido);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 133);
            panel4.Name = "panel4";
            panel4.Size = new Size(784, 56);
            panel4.TabIndex = 26;
            // 
            // btnLimpiarPedido
            // 
            btnLimpiarPedido.BackColor = Color.FromArgb(54, 74, 90);
            btnLimpiarPedido.FlatAppearance.BorderColor = Color.WhiteSmoke;
            btnLimpiarPedido.FlatAppearance.BorderSize = 0;
            btnLimpiarPedido.FlatStyle = FlatStyle.Flat;
            btnLimpiarPedido.ForeColor = Color.WhiteSmoke;
            btnLimpiarPedido.IconChar = FontAwesome.Sharp.IconChar.BroomBall;
            btnLimpiarPedido.IconColor = Color.WhiteSmoke;
            btnLimpiarPedido.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnLimpiarPedido.IconSize = 22;
            btnLimpiarPedido.Location = new Point(167, 7);
            btnLimpiarPedido.Name = "btnLimpiarPedido";
            btnLimpiarPedido.Size = new Size(116, 42);
            btnLimpiarPedido.TabIndex = 7;
            btnLimpiarPedido.Text = "Limpiar (F8)";
            btnLimpiarPedido.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLimpiarPedido.UseVisualStyleBackColor = false;
            btnLimpiarPedido.Click += LimpiarPedido_Click;
            // 
            // btnArticuloSugerido
            // 
            btnArticuloSugerido.BackColor = Color.FromArgb(54, 74, 90);
            btnArticuloSugerido.FlatAppearance.BorderColor = Color.WhiteSmoke;
            btnArticuloSugerido.FlatAppearance.BorderSize = 0;
            btnArticuloSugerido.FlatStyle = FlatStyle.Flat;
            btnArticuloSugerido.ForeColor = Color.WhiteSmoke;
            btnArticuloSugerido.IconChar = FontAwesome.Sharp.IconChar.Box;
            btnArticuloSugerido.IconColor = Color.WhiteSmoke;
            btnArticuloSugerido.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnArticuloSugerido.IconSize = 22;
            btnArticuloSugerido.Location = new Point(9, 7);
            btnArticuloSugerido.Name = "btnArticuloSugerido";
            btnArticuloSugerido.Size = new Size(152, 42);
            btnArticuloSugerido.TabIndex = 6;
            btnArticuloSugerido.Text = "Obtener Articulos Sugeridos (F7)";
            btnArticuloSugerido.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnArticuloSugerido.UseVisualStyleBackColor = false;
            btnArticuloSugerido.Click += ObtenerProductosSugeridos_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(270, 64);
            label10.Name = "label10";
            label10.Size = new Size(32, 15);
            label10.TabIndex = 32;
            label10.Text = "CUIT";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(41, 64);
            label9.Name = "label9";
            label9.Size = new Size(52, 15);
            label9.TabIndex = 31;
            label9.Text = "Telefono";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(36, 39);
            label8.Name = "label8";
            label8.Size = new Size(57, 15);
            label8.TabIndex = 30;
            label8.Text = "Direccion";
            // 
            // txtCuitProveedor
            // 
            txtCuitProveedor.BackColor = Color.White;
            txtCuitProveedor.BorderStyle = BorderStyle.FixedSingle;
            txtCuitProveedor.Enabled = false;
            txtCuitProveedor.Location = new Point(308, 60);
            txtCuitProveedor.Name = "txtCuitProveedor";
            txtCuitProveedor.ReadOnly = true;
            txtCuitProveedor.Size = new Size(126, 23);
            txtCuitProveedor.TabIndex = 29;
            // 
            // txtTelefonoProveedor
            // 
            txtTelefonoProveedor.BackColor = Color.White;
            txtTelefonoProveedor.BorderStyle = BorderStyle.FixedSingle;
            txtTelefonoProveedor.Enabled = false;
            txtTelefonoProveedor.Location = new Point(98, 60);
            txtTelefonoProveedor.Name = "txtTelefonoProveedor";
            txtTelefonoProveedor.ReadOnly = true;
            txtTelefonoProveedor.Size = new Size(96, 23);
            txtTelefonoProveedor.TabIndex = 28;
            // 
            // txtDireccionProveedor
            // 
            txtDireccionProveedor.BackColor = Color.White;
            txtDireccionProveedor.BorderStyle = BorderStyle.FixedSingle;
            txtDireccionProveedor.Enabled = false;
            txtDireccionProveedor.Location = new Point(98, 35);
            txtDireccionProveedor.Name = "txtDireccionProveedor";
            txtDireccionProveedor.ReadOnly = true;
            txtDireccionProveedor.Size = new Size(336, 23);
            txtDireccionProveedor.TabIndex = 27;
            // 
            // txtNroPedido
            // 
            txtNroPedido.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtNroPedido.BackColor = Color.White;
            txtNroPedido.BorderStyle = BorderStyle.FixedSingle;
            txtNroPedido.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtNroPedido.Location = new Point(597, 39);
            txtNroPedido.Name = "txtNroPedido";
            txtNroPedido.ReadOnly = true;
            txtNroPedido.Size = new Size(171, 25);
            txtNroPedido.TabIndex = 25;
            txtNroPedido.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(522, 45);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 24;
            label1.Text = "Nro. Pedido";
            // 
            // btnBorrarProveedor
            // 
            btnBorrarProveedor.BackColor = Color.White;
            btnBorrarProveedor.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            btnBorrarProveedor.FlatStyle = FlatStyle.Flat;
            btnBorrarProveedor.ForeColor = Color.FromArgb(64, 64, 64);
            btnBorrarProveedor.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            btnBorrarProveedor.IconColor = Color.FromArgb(64, 64, 64);
            btnBorrarProveedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBorrarProveedor.IconSize = 15;
            btnBorrarProveedor.Location = new Point(374, 10);
            btnBorrarProveedor.Name = "btnBorrarProveedor";
            btnBorrarProveedor.Size = new Size(27, 23);
            btnBorrarProveedor.TabIndex = 23;
            btnBorrarProveedor.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBorrarProveedor.UseVisualStyleBackColor = false;
            btnBorrarProveedor.Click += BtnBorrarProveedor_Click;
            // 
            // btnBuscarEmpleado
            // 
            btnBuscarEmpleado.BackColor = Color.White;
            btnBuscarEmpleado.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            btnBuscarEmpleado.FlatStyle = FlatStyle.Flat;
            btnBuscarEmpleado.ForeColor = Color.FromArgb(64, 64, 64);
            btnBuscarEmpleado.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            btnBuscarEmpleado.IconColor = Color.FromArgb(64, 64, 64);
            btnBuscarEmpleado.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBuscarEmpleado.IconSize = 15;
            btnBuscarEmpleado.Location = new Point(406, 99);
            btnBuscarEmpleado.Name = "btnBuscarEmpleado";
            btnBuscarEmpleado.Size = new Size(27, 23);
            btnBuscarEmpleado.TabIndex = 8;
            btnBuscarEmpleado.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBuscarEmpleado.UseVisualStyleBackColor = false;
            btnBuscarEmpleado.Click += BtnBuscarEmpleado_Click;
            // 
            // btnNuevoProveedor
            // 
            btnNuevoProveedor.BackColor = Color.White;
            btnNuevoProveedor.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            btnNuevoProveedor.FlatStyle = FlatStyle.Flat;
            btnNuevoProveedor.ForeColor = Color.FromArgb(64, 64, 64);
            btnNuevoProveedor.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            btnNuevoProveedor.IconColor = Color.FromArgb(64, 64, 64);
            btnNuevoProveedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnNuevoProveedor.IconSize = 15;
            btnNuevoProveedor.Location = new Point(407, 10);
            btnNuevoProveedor.Name = "btnNuevoProveedor";
            btnNuevoProveedor.Size = new Size(27, 23);
            btnNuevoProveedor.TabIndex = 16;
            btnNuevoProveedor.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNuevoProveedor.UseVisualStyleBackColor = false;
            btnNuevoProveedor.Click += BtnNuevoProveedor_Click;
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
            pnlLineaDatosGenerales.Location = new Point(0, 189);
            pnlLineaDatosGenerales.Name = "pnlLineaDatosGenerales";
            pnlLineaDatosGenerales.Size = new Size(784, 1);
            pnlLineaDatosGenerales.TabIndex = 11;
            // 
            // txtApyNomEmpleado
            // 
            txtApyNomEmpleado.BackColor = Color.White;
            txtApyNomEmpleado.BorderStyle = BorderStyle.FixedSingle;
            txtApyNomEmpleado.Enabled = false;
            txtApyNomEmpleado.Location = new Point(98, 99);
            txtApyNomEmpleado.Name = "txtApyNomEmpleado";
            txtApyNomEmpleado.ReadOnly = true;
            txtApyNomEmpleado.Size = new Size(309, 23);
            txtApyNomEmpleado.TabIndex = 7;
            // 
            // lblVendedor
            // 
            lblVendedor.AutoSize = true;
            lblVendedor.Location = new Point(31, 103);
            lblVendedor.Name = "lblVendedor";
            lblVendedor.Size = new Size(60, 15);
            lblVendedor.TabIndex = 5;
            lblVendedor.Text = "Empleado";
            // 
            // btnBuscarProveedor
            // 
            btnBuscarProveedor.BackColor = Color.White;
            btnBuscarProveedor.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            btnBuscarProveedor.FlatStyle = FlatStyle.Flat;
            btnBuscarProveedor.ForeColor = Color.FromArgb(64, 64, 64);
            btnBuscarProveedor.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            btnBuscarProveedor.IconColor = Color.FromArgb(64, 64, 64);
            btnBuscarProveedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBuscarProveedor.IconSize = 15;
            btnBuscarProveedor.Location = new Point(348, 10);
            btnBuscarProveedor.Name = "btnBuscarProveedor";
            btnBuscarProveedor.Size = new Size(27, 23);
            btnBuscarProveedor.TabIndex = 4;
            btnBuscarProveedor.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBuscarProveedor.UseVisualStyleBackColor = false;
            btnBuscarProveedor.Click += BtnBuscarProveedor_Click;
            // 
            // txtNombreProveedor
            // 
            txtNombreProveedor.BackColor = Color.White;
            txtNombreProveedor.BorderStyle = BorderStyle.FixedSingle;
            txtNombreProveedor.Location = new Point(98, 10);
            txtNombreProveedor.Name = "txtNombreProveedor";
            txtNombreProveedor.ReadOnly = true;
            txtNombreProveedor.Size = new Size(251, 23);
            txtNombreProveedor.TabIndex = 2;
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Location = new Point(31, 14);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(61, 15);
            lblCliente.TabIndex = 0;
            lblCliente.Text = "Proveedor";
            // 
            // pnlArticulo
            // 
            pnlArticulo.BackColor = Color.WhiteSmoke;
            pnlArticulo.Controls.Add(txtArticulo);
            pnlArticulo.Controls.Add(label3);
            pnlArticulo.Controls.Add(btnBuscar);
            pnlArticulo.Controls.Add(txtBuscar);
            pnlArticulo.Controls.Add(btnAgregarItem);
            pnlArticulo.Controls.Add(pnlLineaBusqueda);
            pnlArticulo.Controls.Add(label4);
            pnlArticulo.Controls.Add(nudCantidad);
            pnlArticulo.Dock = DockStyle.Top;
            pnlArticulo.Location = new Point(0, 249);
            pnlArticulo.Name = "pnlArticulo";
            pnlArticulo.Size = new Size(784, 37);
            pnlArticulo.TabIndex = 3;
            // 
            // txtArticulo
            // 
            txtArticulo.Anchor = AnchorStyles.Left;
            txtArticulo.BorderStyle = BorderStyle.FixedSingle;
            txtArticulo.Enabled = false;
            txtArticulo.Location = new Point(173, 7);
            txtArticulo.Name = "txtArticulo";
            txtArticulo.Size = new Size(234, 23);
            txtArticulo.TabIndex = 20;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Location = new Point(6, 11);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 19;
            label3.Text = "Busqueda";
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
            btnBuscar.Location = new Point(406, 7);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(27, 23);
            btnBuscar.TabIndex = 18;
            btnBuscar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += BtnBuscar_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.Anchor = AnchorStyles.Left;
            txtBuscar.BorderStyle = BorderStyle.FixedSingle;
            txtBuscar.Location = new Point(72, 7);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(98, 23);
            txtBuscar.TabIndex = 17;
            txtBuscar.TextChanged += TxtBuscar_TextChanged;
            txtBuscar.KeyPress += TxtBuscar_KeyPress;
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
            btnAgregarItem.Location = new Point(627, 4);
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
            pnlLineaBusqueda.Size = new Size(784, 1);
            pnlLineaBusqueda.TabIndex = 13;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Location = new Point(451, 11);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 12;
            label4.Text = "Cantidad";
            // 
            // nudCantidad
            // 
            nudCantidad.Anchor = AnchorStyles.Left;
            nudCantidad.DecimalPlaces = 2;
            nudCantidad.Location = new Point(508, 7);
            nudCantidad.Maximum = new decimal(new int[] { -1530494976, 232830, 0, 0 });
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(114, 23);
            nudCantidad.TabIndex = 9;
            nudCantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            nudCantidad.KeyPress += NudCantidad_KeyPress;
            // 
            // pnlTotalizadores
            // 
            pnlTotalizadores.BackColor = Color.WhiteSmoke;
            pnlTotalizadores.Controls.Add(label2);
            pnlTotalizadores.Controls.Add(txtTotal);
            pnlTotalizadores.Dock = DockStyle.Bottom;
            pnlTotalizadores.Location = new Point(0, 513);
            pnlTotalizadores.Name = "pnlTotalizadores";
            pnlTotalizadores.Size = new Size(719, 48);
            pnlTotalizadores.TabIndex = 4;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(431, 11);
            label2.Name = "label2";
            label2.Size = new Size(68, 25);
            label2.TabIndex = 9;
            label2.Text = "TOTAL";
            // 
            // txtTotal
            // 
            txtTotal.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtTotal.BackColor = Color.FromArgb(64, 64, 64);
            txtTotal.BorderStyle = BorderStyle.FixedSingle;
            txtTotal.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtTotal.ForeColor = Color.White;
            txtTotal.Location = new Point(506, 7);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(205, 35);
            txtTotal.TabIndex = 8;
            txtTotal.TextAlign = HorizontalAlignment.Right;
            // 
            // pnlDetalle
            // 
            pnlDetalle.BackColor = Color.WhiteSmoke;
            pnlDetalle.Controls.Add(dgvGrilla);
            pnlDetalle.Controls.Add(panel1);
            pnlDetalle.Dock = DockStyle.Fill;
            pnlDetalle.Location = new Point(0, 286);
            pnlDetalle.Name = "pnlDetalle";
            pnlDetalle.Size = new Size(719, 275);
            pnlDetalle.TabIndex = 5;
            // 
            // dgvGrilla
            // 
            dgvGrilla.AllowUserToAddRows = false;
            dgvGrilla.AllowUserToDeleteRows = false;
            dgvGrilla.BackgroundColor = Color.White;
            dgvGrilla.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvGrilla.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
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
            dgvGrilla.Size = new Size(719, 274);
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
            cambiarCantidadMenuItem.Click += CambiarCantidadItem_Click;
            // 
            // eliminarItemMenuItem
            // 
            eliminarItemMenuItem.Name = "eliminarItemMenuItem";
            eliminarItemMenuItem.Size = new Size(170, 22);
            eliminarItemMenuItem.Text = "Eliminar Item";
            eliminarItemMenuItem.Visible = false;
            eliminarItemMenuItem.Click += EliminarItem_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(192, 64, 0);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 274);
            panel1.Name = "panel1";
            panel1.Size = new Size(719, 1);
            panel1.TabIndex = 12;
            // 
            // _00156_PedidoProveedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(784, 561);
            ControlBox = true;
            Controls.Add(pnlTotalizadores);
            Controls.Add(pnlDetalle);
            Controls.Add(pnlBotonera);
            Controls.Add(pnlArticulo);
            Controls.Add(pnlDatosPrincipal);
            KeyPreview = true;
            MaximizeBox = true;
            MinimizeBox = true;
            MinimumSize = new Size(800, 600);
            Name = "_00156_PedidoProveedor";
            WindowState = FormWindowState.Maximized;
            Shown += _00156_PedidoProveedor_Shown;
            KeyDown += Formulario_KeyDown;
            Controls.SetChildIndex(pnlDatosPrincipal, 0);
            Controls.SetChildIndex(pnlArticulo, 0);
            Controls.SetChildIndex(pnlBotonera, 0);
            Controls.SetChildIndex(pnlDetalle, 0);
            Controls.SetChildIndex(pnlTotalizadores, 0);
            pnlBotonera.ResumeLayout(false);
            pnlDatosPrincipal.ResumeLayout(false);
            pnlDatosPrincipal.PerformLayout();
            panel4.ResumeLayout(false);
            pnlArticulo.ResumeLayout(false);
            pnlArticulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
            pnlTotalizadores.ResumeLayout(false);
            pnlTotalizadores.PerformLayout();
            pnlDetalle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvGrilla).EndInit();
            MenuGrilla.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlBotonera;
        private Panel pnlDatosPrincipal;
        private Panel pnlArticulo;
        private Panel pnlTotalizadores;
        private Panel pnlDetalle;
        private Label lblCliente;
        private FontAwesome.Sharp.IconButton btnBuscarProveedor;
        private FontAwesome.Sharp.IconButton btnBuscarEmpleado;
        private TextBox txtApyNomEmpleado;
        private Label lblVendedor;
        private NumericUpDown nudCantidad;
        private Label label4;
        private Panel pnlLineaDatosGenerales;
        private Panel panel2;
        private Panel pnlLineaBusqueda;
        private Panel panel1;
        private Panel panel3;
        public DataGridView dgvGrilla;
        private FontAwesome.Sharp.IconButton btnAgregarItem;
        private TextBox txtFecha;
        private Label label6;
        private FontAwesome.Sharp.IconButton btnNuevoProveedor;
        private ContextMenuStrip MenuGrilla;
        private ToolStripMenuItem cambiarCantidadMenuItem;
        private ToolStripMenuItem eliminarItemMenuItem;
        private FontAwesome.Sharp.IconButton btnCambiarCantidad;
        private FontAwesome.Sharp.IconButton btnElimnarItem;
        private TextBox txtNombreProveedor;
        private FontAwesome.Sharp.IconButton btnBorrarProveedor;
        private TextBox txtNroPedido;
        private Label label1;
        private Panel panel4;
        private FontAwesome.Sharp.IconButton btnArticuloSugerido;
        private Label label2;
        private TextBox txtTotal;
        private FontAwesome.Sharp.IconButton btnLimpiarPedido;
        private Label label10;
        private Label label9;
        private Label label8;
        private TextBox txtCuitProveedor;
        private TextBox txtTelefonoProveedor;
        private TextBox txtDireccionProveedor;
        private TextBox txtArticulo;
        private Label label3;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private TextBox txtBuscar;
    }
}