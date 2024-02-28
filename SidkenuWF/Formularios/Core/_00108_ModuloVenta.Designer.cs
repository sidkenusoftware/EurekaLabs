namespace SidkenuWF.Formularios.Core
{
    partial class _00108_ModuloVenta
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
            menuStrip1 = new MenuStrip();
            clienteToolStripMenuItem = new ToolStripMenuItem();
            nuevoClienteToolStripMenuItem = new ToolStripMenuItem();
            consultaDeClientesToolStripMenuItem = new ToolStripMenuItem();
            proveedoresToolStripMenuItem = new ToolStripMenuItem();
            nuevoProveedorToolStripMenuItem = new ToolStripMenuItem();
            consultaDeProveedoresToolStripMenuItem = new ToolStripMenuItem();
            gastosToolStripMenuItem = new ToolStripMenuItem();
            consultaToolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripSeparator();
            nuevoTipoDeGastosToolStripMenuItem = new ToolStripMenuItem();
            tipoDeGastosToolStripMenuItem = new ToolStripMenuItem();
            cajasToolStripMenuItem = new ToolStripMenuItem();
            cToolStripMenuItem = new ToolStripMenuItem();
            consultaToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            listaDePrecioToolStripMenuItem = new ToolStripMenuItem();
            nuevaListaDePrecioToolStripMenuItem = new ToolStripMenuItem();
            consultaDeListasDePreciosToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            pnlContenedor = new Panel();
            btnMovimiento = new FontAwesome.Sharp.IconButton();
            btnCaja = new FontAwesome.Sharp.IconButton();
            btnCliente = new FontAwesome.Sharp.IconButton();
            btnGastos = new FontAwesome.Sharp.IconButton();
            pnlMenuLateral.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMenuLateral
            // 
            pnlMenuLateral.Controls.Add(btnGastos);
            pnlMenuLateral.Controls.Add(btnCliente);
            pnlMenuLateral.Controls.Add(btnCaja);
            pnlMenuLateral.Controls.Add(btnMovimiento);
            pnlMenuLateral.Location = new Point(0, 72);
            pnlMenuLateral.Size = new Size(124, 378);
            pnlMenuLateral.Controls.SetChildIndex(bordeCostadoBotoneraMenu, 0);
            pnlMenuLateral.Controls.SetChildIndex(btnMovimiento, 0);
            pnlMenuLateral.Controls.SetChildIndex(btnCaja, 0);
            pnlMenuLateral.Controls.SetChildIndex(btnCliente, 0);
            pnlMenuLateral.Controls.SetChildIndex(btnGastos, 0);
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { clienteToolStripMenuItem, proveedoresToolStripMenuItem, gastosToolStripMenuItem, cajasToolStripMenuItem, listaDePrecioToolStripMenuItem, salirToolStripMenuItem });
            menuStrip1.Location = new Point(0, 43);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(10, 5, 0, 5);
            menuStrip1.Size = new Size(800, 29);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // clienteToolStripMenuItem
            // 
            clienteToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nuevoClienteToolStripMenuItem, consultaDeClientesToolStripMenuItem });
            clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            clienteToolStripMenuItem.Size = new Size(56, 19);
            clienteToolStripMenuItem.Text = "Cliente";
            // 
            // nuevoClienteToolStripMenuItem
            // 
            nuevoClienteToolStripMenuItem.Name = "nuevoClienteToolStripMenuItem";
            nuevoClienteToolStripMenuItem.Size = new Size(182, 22);
            nuevoClienteToolStripMenuItem.Text = "Nuevo Cliente";
            nuevoClienteToolStripMenuItem.Click += NuevoClienteToolStripMenuItem_Click;
            // 
            // consultaDeClientesToolStripMenuItem
            // 
            consultaDeClientesToolStripMenuItem.Name = "consultaDeClientesToolStripMenuItem";
            consultaDeClientesToolStripMenuItem.Size = new Size(182, 22);
            consultaDeClientesToolStripMenuItem.Text = "Consulta de Clientes";
            consultaDeClientesToolStripMenuItem.Click += ConsultaDeClientesToolStripMenuItem_Click;
            // 
            // proveedoresToolStripMenuItem
            // 
            proveedoresToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nuevoProveedorToolStripMenuItem, consultaDeProveedoresToolStripMenuItem });
            proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            proveedoresToolStripMenuItem.Size = new Size(84, 19);
            proveedoresToolStripMenuItem.Text = "Proveedores";
            // 
            // nuevoProveedorToolStripMenuItem
            // 
            nuevoProveedorToolStripMenuItem.Name = "nuevoProveedorToolStripMenuItem";
            nuevoProveedorToolStripMenuItem.Size = new Size(205, 22);
            nuevoProveedorToolStripMenuItem.Text = "Nuevo Proveedor";
            nuevoProveedorToolStripMenuItem.Click += NuevoProveedorToolStripMenuItem_Click;
            // 
            // consultaDeProveedoresToolStripMenuItem
            // 
            consultaDeProveedoresToolStripMenuItem.Name = "consultaDeProveedoresToolStripMenuItem";
            consultaDeProveedoresToolStripMenuItem.Size = new Size(205, 22);
            consultaDeProveedoresToolStripMenuItem.Text = "Consulta de Proveedores";
            consultaDeProveedoresToolStripMenuItem.Click += ConsultaDeProveedoresToolStripMenuItem_Click;
            // 
            // gastosToolStripMenuItem
            // 
            gastosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { consultaToolStripMenuItem1, toolStripMenuItem2, nuevoTipoDeGastosToolStripMenuItem, tipoDeGastosToolStripMenuItem });
            gastosToolStripMenuItem.Name = "gastosToolStripMenuItem";
            gastosToolStripMenuItem.Size = new Size(54, 19);
            gastosToolStripMenuItem.Text = "Gastos";
            // 
            // consultaToolStripMenuItem1
            // 
            consultaToolStripMenuItem1.Name = "consultaToolStripMenuItem1";
            consultaToolStripMenuItem1.Size = new Size(201, 22);
            consultaToolStripMenuItem1.Text = "Consulta";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(198, 6);
            // 
            // nuevoTipoDeGastosToolStripMenuItem
            // 
            nuevoTipoDeGastosToolStripMenuItem.Name = "nuevoTipoDeGastosToolStripMenuItem";
            nuevoTipoDeGastosToolStripMenuItem.Size = new Size(201, 22);
            nuevoTipoDeGastosToolStripMenuItem.Text = "Nuevo Tipo de Gastos";
            nuevoTipoDeGastosToolStripMenuItem.Click += NuevoTipoDeGastosToolStripMenuItem_Click;
            // 
            // tipoDeGastosToolStripMenuItem
            // 
            tipoDeGastosToolStripMenuItem.Name = "tipoDeGastosToolStripMenuItem";
            tipoDeGastosToolStripMenuItem.Size = new Size(201, 22);
            tipoDeGastosToolStripMenuItem.Text = "Consulta Tipo de Gastos";
            tipoDeGastosToolStripMenuItem.Click += ConsultaTipoGastosToolStripMenuItem_Click;
            // 
            // cajasToolStripMenuItem
            // 
            cajasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cToolStripMenuItem, consultaToolStripMenuItem, toolStripMenuItem1 });
            cajasToolStripMenuItem.Name = "cajasToolStripMenuItem";
            cajasToolStripMenuItem.Size = new Size(47, 19);
            cajasToolStripMenuItem.Text = "Cajas";
            // 
            // cToolStripMenuItem
            // 
            cToolStripMenuItem.Name = "cToolStripMenuItem";
            cToolStripMenuItem.Size = new Size(134, 22);
            cToolStripMenuItem.Text = "Nueva Caja";
            cToolStripMenuItem.Click += NuevaCajaToolStripMenuItem_Click;
            // 
            // consultaToolStripMenuItem
            // 
            consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            consultaToolStripMenuItem.Size = new Size(134, 22);
            consultaToolStripMenuItem.Text = "Consulta";
            consultaToolStripMenuItem.Click += ConsultaCajasToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(131, 6);
            // 
            // listaDePrecioToolStripMenuItem
            // 
            listaDePrecioToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nuevaListaDePrecioToolStripMenuItem, consultaDeListasDePreciosToolStripMenuItem });
            listaDePrecioToolStripMenuItem.Name = "listaDePrecioToolStripMenuItem";
            listaDePrecioToolStripMenuItem.Size = new Size(95, 19);
            listaDePrecioToolStripMenuItem.Text = "Lista de Precio";
            // 
            // nuevaListaDePrecioToolStripMenuItem
            // 
            nuevaListaDePrecioToolStripMenuItem.Name = "nuevaListaDePrecioToolStripMenuItem";
            nuevaListaDePrecioToolStripMenuItem.Size = new Size(226, 22);
            nuevaListaDePrecioToolStripMenuItem.Text = "Nueva Lista de Precio";
            nuevaListaDePrecioToolStripMenuItem.Click += NuevaListaDePrecioToolStripMenuItem_Click;
            // 
            // consultaDeListasDePreciosToolStripMenuItem
            // 
            consultaDeListasDePreciosToolStripMenuItem.Name = "consultaDeListasDePreciosToolStripMenuItem";
            consultaDeListasDePreciosToolStripMenuItem.Size = new Size(226, 22);
            consultaDeListasDePreciosToolStripMenuItem.Text = "Consulta de Listas de Precios";
            consultaDeListasDePreciosToolStripMenuItem.Click += ConsultaDeListasDePreciosToolStripMenuItem_Click;
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(51, 19);
            salirToolStripMenuItem.Text = "Volver";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // pnlContenedor
            // 
            pnlContenedor.Dock = DockStyle.Fill;
            pnlContenedor.Location = new Point(124, 72);
            pnlContenedor.Name = "pnlContenedor";
            pnlContenedor.Size = new Size(676, 378);
            pnlContenedor.TabIndex = 4;
            // 
            // btnMovimiento
            // 
            btnMovimiento.Dock = DockStyle.Top;
            btnMovimiento.FlatAppearance.BorderSize = 0;
            btnMovimiento.FlatStyle = FlatStyle.Flat;
            btnMovimiento.IconChar = FontAwesome.Sharp.IconChar.DollarSign;
            btnMovimiento.IconColor = Color.Gray;
            btnMovimiento.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMovimiento.IconSize = 25;
            btnMovimiento.ImageAlign = ContentAlignment.MiddleLeft;
            btnMovimiento.Location = new Point(0, 0);
            btnMovimiento.Name = "btnMovimiento";
            btnMovimiento.Size = new Size(124, 46);
            btnMovimiento.TabIndex = 4;
            btnMovimiento.Text = "Movimientos";
            btnMovimiento.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMovimiento.UseVisualStyleBackColor = true;
            btnMovimiento.Click += BtnMovimiento_Click;
            // 
            // btnCaja
            // 
            btnCaja.Dock = DockStyle.Top;
            btnCaja.FlatAppearance.BorderSize = 0;
            btnCaja.FlatStyle = FlatStyle.Flat;
            btnCaja.IconChar = FontAwesome.Sharp.IconChar.DollarSign;
            btnCaja.IconColor = Color.Gray;
            btnCaja.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCaja.IconSize = 25;
            btnCaja.ImageAlign = ContentAlignment.MiddleLeft;
            btnCaja.Location = new Point(0, 46);
            btnCaja.Name = "btnCaja";
            btnCaja.Size = new Size(124, 46);
            btnCaja.TabIndex = 5;
            btnCaja.Text = "Caja";
            btnCaja.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCaja.UseVisualStyleBackColor = true;
            btnCaja.Click += ConsultaCajasToolStripMenuItem_Click;
            // 
            // btnCliente
            // 
            btnCliente.Dock = DockStyle.Top;
            btnCliente.FlatAppearance.BorderSize = 0;
            btnCliente.FlatStyle = FlatStyle.Flat;
            btnCliente.IconChar = FontAwesome.Sharp.IconChar.DollarSign;
            btnCliente.IconColor = Color.Gray;
            btnCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCliente.IconSize = 25;
            btnCliente.ImageAlign = ContentAlignment.MiddleLeft;
            btnCliente.Location = new Point(0, 92);
            btnCliente.Name = "btnCliente";
            btnCliente.Size = new Size(124, 46);
            btnCliente.TabIndex = 6;
            btnCliente.Text = "Cliente";
            btnCliente.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCliente.UseVisualStyleBackColor = true;
            btnCliente.Click += ConsultaDeClientesToolStripMenuItem_Click;
            // 
            // btnGastos
            // 
            btnGastos.Dock = DockStyle.Top;
            btnGastos.FlatAppearance.BorderSize = 0;
            btnGastos.FlatStyle = FlatStyle.Flat;
            btnGastos.IconChar = FontAwesome.Sharp.IconChar.DollarSign;
            btnGastos.IconColor = Color.Gray;
            btnGastos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGastos.IconSize = 25;
            btnGastos.ImageAlign = ContentAlignment.MiddleLeft;
            btnGastos.Location = new Point(0, 138);
            btnGastos.Name = "btnGastos";
            btnGastos.Size = new Size(124, 46);
            btnGastos.TabIndex = 7;
            btnGastos.Text = "Gastos";
            btnGastos.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGastos.UseVisualStyleBackColor = true;
            // 
            // _00108_ModuloVenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(pnlContenedor);
            Controls.Add(menuStrip1);
            DoubleBuffered = true;
            Name = "_00108_ModuloVenta";
            Text = "Modulo de Ventas";
            Controls.SetChildIndex(pnlTitulo, 0);
            Controls.SetChildIndex(menuStrip1, 0);
            Controls.SetChildIndex(pnlMenuLateral, 0);
            Controls.SetChildIndex(pnlContenedor, 0);
            pnlMenuLateral.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem clienteToolStripMenuItem;
        private ToolStripMenuItem gastosToolStripMenuItem;
        private ToolStripMenuItem cajasToolStripMenuItem;
        private Panel pnlContenedor;
        private ToolStripMenuItem consultaToolStripMenuItem1;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripMenuItem nuevoTipoDeGastosToolStripMenuItem;
        private ToolStripMenuItem tipoDeGastosToolStripMenuItem;
        private ToolStripMenuItem cToolStripMenuItem;
        private ToolStripMenuItem consultaToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private FontAwesome.Sharp.IconButton btnMovimiento;
        private FontAwesome.Sharp.IconButton btnGastos;
        private FontAwesome.Sharp.IconButton btnCliente;
        private FontAwesome.Sharp.IconButton btnCaja;
        private ToolStripMenuItem nuevoClienteToolStripMenuItem;
        private ToolStripMenuItem consultaDeClientesToolStripMenuItem;
        private ToolStripMenuItem listaDePrecioToolStripMenuItem;
        private ToolStripMenuItem nuevaListaDePrecioToolStripMenuItem;
        private ToolStripMenuItem consultaDeListasDePreciosToolStripMenuItem;
        private ToolStripMenuItem proveedoresToolStripMenuItem;
        private ToolStripMenuItem nuevoProveedorToolStripMenuItem;
        private ToolStripMenuItem consultaDeProveedoresToolStripMenuItem;
    }
}