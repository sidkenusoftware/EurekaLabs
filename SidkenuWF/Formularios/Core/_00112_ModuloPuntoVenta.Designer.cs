namespace SidkenuWF.Formularios.Core
{
    partial class _00112_ModuloPuntoVenta
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
            btnPuntoVenta = new FontAwesome.Sharp.IconButton();
            pnlContenedor = new Panel();
            btnCliente = new FontAwesome.Sharp.IconButton();
            menuStrip1 = new MenuStrip();
            tarjetaToolStripMenuItem = new ToolStripMenuItem();
            nuevaToolStripMenuItem = new ToolStripMenuItem();
            consultaToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            planDeTarjetaToolStripMenuItem = new ToolStripMenuItem();
            nuevaToolStripMenuItem1 = new ToolStripMenuItem();
            consultaToolStripMenuItem1 = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            bancoToolStripMenuItem = new ToolStripMenuItem();
            nuevoToolStripMenuItem = new ToolStripMenuItem();
            consultaToolStripMenuItem2 = new ToolStripMenuItem();
            pnlMenuLateral.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMenuLateral
            // 
            pnlMenuLateral.Controls.Add(btnCliente);
            pnlMenuLateral.Controls.Add(btnPuntoVenta);
            pnlMenuLateral.Location = new Point(0, 72);
            pnlMenuLateral.Size = new Size(124, 378);
            pnlMenuLateral.Controls.SetChildIndex(btnPuntoVenta, 0);
            pnlMenuLateral.Controls.SetChildIndex(btnCliente, 0);
            pnlMenuLateral.Controls.SetChildIndex(bordeCostadoBotoneraMenu, 0);
            // 
            // btnPuntoVenta
            // 
            btnPuntoVenta.Dock = DockStyle.Top;
            btnPuntoVenta.FlatAppearance.BorderSize = 0;
            btnPuntoVenta.FlatStyle = FlatStyle.Flat;
            btnPuntoVenta.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            btnPuntoVenta.IconColor = Color.Gray;
            btnPuntoVenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnPuntoVenta.IconSize = 25;
            btnPuntoVenta.ImageAlign = ContentAlignment.MiddleLeft;
            btnPuntoVenta.Location = new Point(0, 0);
            btnPuntoVenta.Name = "btnPuntoVenta";
            btnPuntoVenta.Size = new Size(124, 42);
            btnPuntoVenta.TabIndex = 7;
            btnPuntoVenta.Text = "Punto de Venta";
            btnPuntoVenta.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPuntoVenta.UseVisualStyleBackColor = true;
            btnPuntoVenta.Click += BtnPuntoDeVenta_Click;
            // 
            // pnlContenedor
            // 
            pnlContenedor.Dock = DockStyle.Fill;
            pnlContenedor.Location = new Point(124, 72);
            pnlContenedor.Name = "pnlContenedor";
            pnlContenedor.Size = new Size(676, 378);
            pnlContenedor.TabIndex = 7;
            // 
            // btnCliente
            // 
            btnCliente.Dock = DockStyle.Top;
            btnCliente.FlatAppearance.BorderSize = 0;
            btnCliente.FlatStyle = FlatStyle.Flat;
            btnCliente.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            btnCliente.IconColor = Color.Gray;
            btnCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCliente.IconSize = 25;
            btnCliente.ImageAlign = ContentAlignment.MiddleLeft;
            btnCliente.Location = new Point(0, 42);
            btnCliente.Name = "btnCliente";
            btnCliente.Size = new Size(124, 42);
            btnCliente.TabIndex = 8;
            btnCliente.Text = "Clientes";
            btnCliente.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCliente.UseVisualStyleBackColor = true;
            btnCliente.Click += BtnClientes_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { tarjetaToolStripMenuItem, bancoToolStripMenuItem, salirToolStripMenuItem });
            menuStrip1.Location = new Point(0, 43);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(10, 5, 0, 5);
            menuStrip1.Size = new Size(800, 29);
            menuStrip1.TabIndex = 8;
            menuStrip1.Text = "menuStrip1";
            // 
            // tarjetaToolStripMenuItem
            // 
            tarjetaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nuevaToolStripMenuItem, consultaToolStripMenuItem, toolStripMenuItem1, planDeTarjetaToolStripMenuItem });
            tarjetaToolStripMenuItem.Name = "tarjetaToolStripMenuItem";
            tarjetaToolStripMenuItem.Size = new Size(53, 19);
            tarjetaToolStripMenuItem.Text = "Tarjeta";
            // 
            // nuevaToolStripMenuItem
            // 
            nuevaToolStripMenuItem.Name = "nuevaToolStripMenuItem";
            nuevaToolStripMenuItem.Size = new Size(150, 22);
            nuevaToolStripMenuItem.Text = "Nueva";
            nuevaToolStripMenuItem.Click += NuevaTarjeta_Click;
            // 
            // consultaToolStripMenuItem
            // 
            consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            consultaToolStripMenuItem.Size = new Size(150, 22);
            consultaToolStripMenuItem.Text = "Consulta";
            consultaToolStripMenuItem.Click += ConsultaTarjeta_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(147, 6);
            // 
            // planDeTarjetaToolStripMenuItem
            // 
            planDeTarjetaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nuevaToolStripMenuItem1, consultaToolStripMenuItem1 });
            planDeTarjetaToolStripMenuItem.Name = "planDeTarjetaToolStripMenuItem";
            planDeTarjetaToolStripMenuItem.Size = new Size(150, 22);
            planDeTarjetaToolStripMenuItem.Text = "Plan de Tarjeta";
            // 
            // nuevaToolStripMenuItem1
            // 
            nuevaToolStripMenuItem1.Name = "nuevaToolStripMenuItem1";
            nuevaToolStripMenuItem1.Size = new Size(121, 22);
            nuevaToolStripMenuItem1.Text = "Nueva ";
            nuevaToolStripMenuItem1.Click += NuevoPlanDeTarjeta_Click;
            // 
            // consultaToolStripMenuItem1
            // 
            consultaToolStripMenuItem1.Name = "consultaToolStripMenuItem1";
            consultaToolStripMenuItem1.Size = new Size(121, 22);
            consultaToolStripMenuItem1.Text = "Consulta";
            consultaToolStripMenuItem1.Click += ConsultaPlanTarjeta_Click;
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(51, 19);
            salirToolStripMenuItem.Text = "Volver";
            salirToolStripMenuItem.Click += SalirToolStripMenuItem_Click;
            // 
            // bancoToolStripMenuItem
            // 
            bancoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nuevoToolStripMenuItem, consultaToolStripMenuItem2 });
            bancoToolStripMenuItem.Name = "bancoToolStripMenuItem";
            bancoToolStripMenuItem.Size = new Size(52, 19);
            bancoToolStripMenuItem.Text = "Banco";
            // 
            // nuevoToolStripMenuItem
            // 
            nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            nuevoToolStripMenuItem.Size = new Size(180, 22);
            nuevoToolStripMenuItem.Text = "Nuevo";
            nuevoToolStripMenuItem.Click += NuevoBanco_Click;
            // 
            // consultaToolStripMenuItem2
            // 
            consultaToolStripMenuItem2.Name = "consultaToolStripMenuItem2";
            consultaToolStripMenuItem2.Size = new Size(180, 22);
            consultaToolStripMenuItem2.Text = "Consulta";
            consultaToolStripMenuItem2.Click += ConsultaBanco_Click;
            // 
            // _00112_ModuloPuntoVenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlContenedor);
            Controls.Add(menuStrip1);
            Name = "_00112_ModuloPuntoVenta";
            Text = "Punto de Venta";
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

        private FontAwesome.Sharp.IconButton btnPuntoVenta;
        private Panel pnlContenedor;
        private FontAwesome.Sharp.IconButton btnCliente;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem tarjetaToolStripMenuItem;
        private ToolStripMenuItem nuevaToolStripMenuItem;
        private ToolStripMenuItem consultaToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem planDeTarjetaToolStripMenuItem;
        private ToolStripMenuItem nuevaToolStripMenuItem1;
        private ToolStripMenuItem consultaToolStripMenuItem1;
        private ToolStripMenuItem bancoToolStripMenuItem;
        private ToolStripMenuItem nuevoToolStripMenuItem;
        private ToolStripMenuItem consultaToolStripMenuItem2;
    }
}