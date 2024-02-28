namespace SidkenuWF.Formularios.Core
{
    partial class _00113_ModuloCaja
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
            cajasToolStripMenuItem = new ToolStripMenuItem();
            nuevaToolStripMenuItem = new ToolStripMenuItem();
            CajaConsultaToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            gastosToolStripMenuItem = new ToolStripMenuItem();
            nuevoToolStripMenuItem = new ToolStripMenuItem();
            consultaToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            tipoDeGastosToolStripMenuItem = new ToolStripMenuItem();
            nuevoToolStripMenuItem1 = new ToolStripMenuItem();
            consultaToolStripMenuItem1 = new ToolStripMenuItem();
            btnCajas = new FontAwesome.Sharp.IconButton();
            pnlContenedor = new Panel();
            pnlMenuLateral.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMenuLateral
            // 
            pnlMenuLateral.Controls.Add(btnCajas);
            pnlMenuLateral.Location = new Point(0, 72);
            pnlMenuLateral.Size = new Size(124, 378);
            pnlMenuLateral.Controls.SetChildIndex(bordeCostadoBotoneraMenu, 0);
            pnlMenuLateral.Controls.SetChildIndex(btnCajas, 0);
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { cajasToolStripMenuItem, gastosToolStripMenuItem, salirToolStripMenuItem });
            menuStrip1.Location = new Point(0, 43);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(10, 5, 0, 5);
            menuStrip1.Size = new Size(800, 29);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // cajasToolStripMenuItem
            // 
            cajasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nuevaToolStripMenuItem, CajaConsultaToolStripMenuItem });
            cajasToolStripMenuItem.Name = "cajasToolStripMenuItem";
            cajasToolStripMenuItem.Size = new Size(47, 19);
            cajasToolStripMenuItem.Text = "Cajas";
            // 
            // nuevaToolStripMenuItem
            // 
            nuevaToolStripMenuItem.Name = "nuevaToolStripMenuItem";
            nuevaToolStripMenuItem.Size = new Size(121, 22);
            nuevaToolStripMenuItem.Text = "Nueva";
            nuevaToolStripMenuItem.Click += NuevaCajaToolStripMenuItem_Click;
            // 
            // CajaConsultaToolStripMenuItem
            // 
            CajaConsultaToolStripMenuItem.Name = "CajaConsultaToolStripMenuItem";
            CajaConsultaToolStripMenuItem.Size = new Size(121, 22);
            CajaConsultaToolStripMenuItem.Text = "Consulta";
            CajaConsultaToolStripMenuItem.Click += CajaConsultaToolStripMenuItem_Click;
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(51, 19);
            salirToolStripMenuItem.Text = "Volver";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // gastosToolStripMenuItem
            // 
            gastosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nuevoToolStripMenuItem, consultaToolStripMenuItem, toolStripMenuItem1, tipoDeGastosToolStripMenuItem });
            gastosToolStripMenuItem.Name = "gastosToolStripMenuItem";
            gastosToolStripMenuItem.Size = new Size(54, 19);
            gastosToolStripMenuItem.Text = "Gastos";
            // 
            // nuevoToolStripMenuItem
            // 
            nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            nuevoToolStripMenuItem.Size = new Size(151, 22);
            nuevoToolStripMenuItem.Text = "Nuevo";
            // 
            // consultaToolStripMenuItem
            // 
            consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            consultaToolStripMenuItem.Size = new Size(151, 22);
            consultaToolStripMenuItem.Text = "Consulta";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(148, 6);
            // 
            // tipoDeGastosToolStripMenuItem
            // 
            tipoDeGastosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nuevoToolStripMenuItem1, consultaToolStripMenuItem1 });
            tipoDeGastosToolStripMenuItem.Name = "tipoDeGastosToolStripMenuItem";
            tipoDeGastosToolStripMenuItem.Size = new Size(151, 22);
            tipoDeGastosToolStripMenuItem.Text = "Tipo de Gastos";
            // 
            // nuevoToolStripMenuItem1
            // 
            nuevoToolStripMenuItem1.Name = "nuevoToolStripMenuItem1";
            nuevoToolStripMenuItem1.Size = new Size(121, 22);
            nuevoToolStripMenuItem1.Text = "Nuevo ";
            // 
            // consultaToolStripMenuItem1
            // 
            consultaToolStripMenuItem1.Name = "consultaToolStripMenuItem1";
            consultaToolStripMenuItem1.Size = new Size(121, 22);
            consultaToolStripMenuItem1.Text = "Consulta";
            // 
            // btnCajas
            // 
            btnCajas.Dock = DockStyle.Top;
            btnCajas.FlatAppearance.BorderSize = 0;
            btnCajas.FlatStyle = FlatStyle.Flat;
            btnCajas.IconChar = FontAwesome.Sharp.IconChar.SackDollar;
            btnCajas.IconColor = Color.Gray;
            btnCajas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCajas.IconSize = 25;
            btnCajas.ImageAlign = ContentAlignment.MiddleLeft;
            btnCajas.Location = new Point(0, 0);
            btnCajas.Name = "btnCajas";
            btnCajas.Size = new Size(124, 45);
            btnCajas.TabIndex = 8;
            btnCajas.Text = "Cajas y Movimientos";
            btnCajas.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCajas.UseVisualStyleBackColor = true;
            btnCajas.Click += CajasToolStripMenuItem_Click;
            // 
            // pnlContenedor
            // 
            pnlContenedor.Dock = DockStyle.Fill;
            pnlContenedor.Location = new Point(124, 72);
            pnlContenedor.Name = "pnlContenedor";
            pnlContenedor.Size = new Size(676, 378);
            pnlContenedor.TabIndex = 8;
            // 
            // _00113_ModuloCaja
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlContenedor);
            Controls.Add(menuStrip1);
            Name = "_00113_ModuloCaja";
            Text = "Modulo de Caja";
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
        private ToolStripMenuItem cajasToolStripMenuItem;
        private ToolStripMenuItem CajaConsultaToolStripMenuItem;
        private FontAwesome.Sharp.IconButton btnCajas;
        private Panel pnlContenedor;
        private ToolStripMenuItem nuevaToolStripMenuItem;
        private ToolStripMenuItem gastosToolStripMenuItem;
        private ToolStripMenuItem nuevoToolStripMenuItem;
        private ToolStripMenuItem consultaToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem tipoDeGastosToolStripMenuItem;
        private ToolStripMenuItem nuevoToolStripMenuItem1;
        private ToolStripMenuItem consultaToolStripMenuItem1;
    }
}