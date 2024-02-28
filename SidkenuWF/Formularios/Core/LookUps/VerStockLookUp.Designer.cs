namespace SidkenuWF.Formularios.Core.LookUps
{
    partial class VerStockLookUp
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
            pnlContenedor = new Panel();
            SuspendLayout();
            // 
            // pnlContenedor
            // 
            pnlContenedor.BackColor = Color.White;
            pnlContenedor.Dock = DockStyle.Fill;
            pnlContenedor.Location = new Point(0, 59);
            pnlContenedor.Name = "pnlContenedor";
            pnlContenedor.Size = new Size(634, 352);
            pnlContenedor.TabIndex = 1;
            // 
            // VerStockLookUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(634, 411);
            Controls.Add(pnlContenedor);
            MaximumSize = new Size(650, 450);
            MinimumSize = new Size(650, 450);
            Name = "VerStockLookUp";
            Text = "Stock";
            Shown += VerStockLookUp_Shown;
            Controls.SetChildIndex(pnlContenedor, 0);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlContenedor;
    }
}