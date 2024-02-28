namespace SidkenuWF.Formularios.Core.Controles
{
    partial class CtrolVerStock
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
            pnlLinea = new Panel();
            pnlStock = new Panel();
            lblStock = new Label();
            label1 = new Label();
            pnlDeposito = new Panel();
            lblDeposito = new Label();
            pnlStock.SuspendLayout();
            pnlDeposito.SuspendLayout();
            SuspendLayout();
            // 
            // pnlLinea
            // 
            pnlLinea.BackColor = Color.FromArgb(255, 128, 0);
            pnlLinea.Dock = DockStyle.Bottom;
            pnlLinea.Location = new Point(0, 35);
            pnlLinea.Name = "pnlLinea";
            pnlLinea.Size = new Size(628, 2);
            pnlLinea.TabIndex = 0;
            // 
            // pnlStock
            // 
            pnlStock.Controls.Add(lblStock);
            pnlStock.Controls.Add(label1);
            pnlStock.Dock = DockStyle.Right;
            pnlStock.Location = new Point(466, 0);
            pnlStock.Name = "pnlStock";
            pnlStock.Size = new Size(162, 35);
            pnlStock.TabIndex = 1;
            // 
            // lblStock
            // 
            lblStock.Dock = DockStyle.Fill;
            lblStock.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblStock.Location = new Point(45, 0);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(117, 35);
            lblStock.TabIndex = 2;
            lblStock.Text = "10000000000";
            lblStock.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Left;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(45, 35);
            label1.TabIndex = 1;
            label1.Text = "Stock:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlDeposito
            // 
            pnlDeposito.Controls.Add(lblDeposito);
            pnlDeposito.Dock = DockStyle.Fill;
            pnlDeposito.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            pnlDeposito.Location = new Point(0, 0);
            pnlDeposito.Name = "pnlDeposito";
            pnlDeposito.Size = new Size(466, 35);
            pnlDeposito.TabIndex = 2;
            // 
            // lblDeposito
            // 
            lblDeposito.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblDeposito.Location = new Point(3, 3);
            lblDeposito.Name = "lblDeposito";
            lblDeposito.Size = new Size(368, 29);
            lblDeposito.TabIndex = 0;
            lblDeposito.Text = "Deposito 1";
            lblDeposito.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // CtrolVerStock
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(pnlDeposito);
            Controls.Add(pnlStock);
            Controls.Add(pnlLinea);
            Name = "CtrolVerStock";
            Size = new Size(628, 37);
            Load += CtrolVerStock_Load;
            pnlStock.ResumeLayout(false);
            pnlDeposito.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlLinea;
        private Panel pnlStock;
        private Label lblStock;
        private Label label1;
        private Panel pnlDeposito;
        private Label lblDeposito;
    }
}
