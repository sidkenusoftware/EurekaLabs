namespace SidkenuWF.Formularios.Core
{
    partial class _00121_PagoProveedor
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
            pnlTestigo = new Panel();
            lblCajaSeleccionada = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            button1 = new Button();
            pnlTestigo.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTestigo
            // 
            pnlTestigo.BackColor = Color.FromArgb(192, 64, 0);
            pnlTestigo.Controls.Add(lblCajaSeleccionada);
            pnlTestigo.Dock = DockStyle.Top;
            pnlTestigo.Location = new Point(0, 59);
            pnlTestigo.Name = "pnlTestigo";
            pnlTestigo.Size = new Size(735, 44);
            pnlTestigo.TabIndex = 3;
            // 
            // lblCajaSeleccionada
            // 
            lblCajaSeleccionada.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblCajaSeleccionada.BackColor = Color.Transparent;
            lblCajaSeleccionada.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblCajaSeleccionada.ForeColor = Color.White;
            lblCajaSeleccionada.Location = new Point(19, 6);
            lblCajaSeleccionada.Name = "lblCajaSeleccionada";
            lblCajaSeleccionada.Size = new Size(709, 32);
            lblCajaSeleccionada.TabIndex = 0;
            lblCajaSeleccionada.Text = "Caja Seleccionada => ";
            lblCajaSeleccionada.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoScroll = true;
            tableLayoutPanel1.AutoScrollMargin = new Size(0, 20);
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(button1, 0, 0);
            tableLayoutPanel1.Location = new Point(146, 133);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(466, 305);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Fill;
            button1.Location = new Point(4, 4);
            button1.Name = "button1";
            button1.Size = new Size(225, 145);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // _00121_PagoProveedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(735, 450);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(pnlTestigo);
            Name = "_00121_PagoProveedor";
            Text = "Pago Proveedor";
            Controls.SetChildIndex(pnlTestigo, 0);
            Controls.SetChildIndex(tableLayoutPanel1, 0);
            pnlTestigo.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTestigo;
        private Label lblCajaSeleccionada;
        private TableLayoutPanel tableLayoutPanel1;
        private Button button1;
    }
}