namespace SidkenuWF.Formularios.Core.Controles
{
    partial class CtrolVarianteTituloConStockPrecio
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitulo = new Label();
            pnlContenedor = new Panel();
            label2 = new Label();
            label1 = new Label();
            nudStock = new NumericUpDown();
            nudPrecio = new NumericUpDown();
            pnlContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudStock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudPrecio).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.BackColor = Color.Gray;
            lblTitulo.Dock = DockStyle.Left;
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(0, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(113, 50);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Titulo";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlContenedor
            // 
            pnlContenedor.BackColor = Color.WhiteSmoke;
            pnlContenedor.Controls.Add(label2);
            pnlContenedor.Controls.Add(label1);
            pnlContenedor.Controls.Add(nudStock);
            pnlContenedor.Controls.Add(nudPrecio);
            pnlContenedor.Dock = DockStyle.Fill;
            pnlContenedor.Location = new Point(113, 0);
            pnlContenedor.Name = "pnlContenedor";
            pnlContenedor.Size = new Size(119, 50);
            pnlContenedor.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 29);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 3;
            label2.Text = "Stock";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 7);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 2;
            label1.Text = "Precio";
            // 
            // nudStock
            // 
            nudStock.DecimalPlaces = 2;
            nudStock.Location = new Point(48, 25);
            nudStock.Maximum = new decimal(new int[] { -727379968, 232, 0, 0 });
            nudStock.Name = "nudStock";
            nudStock.Size = new Size(68, 23);
            nudStock.TabIndex = 1;
            // 
            // nudPrecio
            // 
            nudPrecio.DecimalPlaces = 2;
            nudPrecio.Location = new Point(48, 2);
            nudPrecio.Maximum = new decimal(new int[] { -727379968, 232, 0, 0 });
            nudPrecio.Name = "nudPrecio";
            nudPrecio.Size = new Size(68, 23);
            nudPrecio.TabIndex = 0;
            // 
            // CtrolVarianteTituloConStockPrecio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlContenedor);
            Controls.Add(lblTitulo);
            Name = "CtrolVarianteTituloConStockPrecio";
            Size = new Size(232, 50);
            pnlContenedor.ResumeLayout(false);
            pnlContenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudStock).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudPrecio).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitulo;
        private Panel pnlContenedor;
        private Label label2;
        private Label label1;
        private NumericUpDown nudStock;
        private NumericUpDown nudPrecio;
    }
}
