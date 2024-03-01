namespace SidkenuWF.Formularios.Core
{
    partial class _00114_ModuloDashBoard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            menuStrip1 = new MenuStrip();
            salirToolStripMenuItem = new ToolStripMenuItem();
            flpContenedor = new FlowLayoutPanel();
            panel1 = new Panel();
            label1 = new Label();
            chartVentaSemanal = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panel2 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            ctrolDashTotalVentas = new Controles.CtrolDashboard();
            ctrolDashCantClientes = new Controles.CtrolDashboard();
            ctrolDashCaja = new Controles.CtrolDashboard();
            pnlMenuLateral.SuspendLayout();
            menuStrip1.SuspendLayout();
            flpContenedor.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartVentaSemanal).BeginInit();
            panel2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMenuLateral
            // 
            pnlMenuLateral.Location = new Point(0, 72);
            pnlMenuLateral.Size = new Size(124, 489);
            // 
            // pnlTitulo
            // 
            pnlTitulo.Size = new Size(784, 43);
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { salirToolStripMenuItem });
            menuStrip1.Location = new Point(0, 43);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(10, 5, 0, 5);
            menuStrip1.Size = new Size(784, 29);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(51, 19);
            salirToolStripMenuItem.Text = "Volver";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // flpContenedor
            // 
            flpContenedor.AutoScroll = true;
            flpContenedor.Controls.Add(panel1);
            flpContenedor.Controls.Add(panel2);
            flpContenedor.Dock = DockStyle.Fill;
            flpContenedor.Location = new Point(124, 72);
            flpContenedor.Name = "flpContenedor";
            flpContenedor.Size = new Size(660, 489);
            flpContenedor.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(224, 224, 224);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(chartVentaSemanal);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(632, 296);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(192, 64, 0);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(632, 35);
            label1.TabIndex = 1;
            label1.Text = "Ventas Semanales";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // chartVentaSemanal
            // 
            chartArea1.Name = "ChartArea1";
            chartVentaSemanal.ChartAreas.Add(chartArea1);
            chartVentaSemanal.Dock = DockStyle.Bottom;
            legend1.Name = "Legend1";
            chartVentaSemanal.Legends.Add(legend1);
            chartVentaSemanal.Location = new Point(0, 35);
            chartVentaSemanal.Name = "chartVentaSemanal";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Ventas";
            chartVentaSemanal.Series.Add(series1);
            chartVentaSemanal.Size = new Size(632, 261);
            chartVentaSemanal.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(224, 224, 224);
            panel2.Controls.Add(flowLayoutPanel1);
            panel2.Location = new Point(3, 305);
            panel2.Name = "panel2";
            panel2.Size = new Size(632, 296);
            panel2.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.White;
            flowLayoutPanel1.Controls.Add(ctrolDashTotalVentas);
            flowLayoutPanel1.Controls.Add(ctrolDashCantClientes);
            flowLayoutPanel1.Controls.Add(ctrolDashCaja);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(632, 296);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // ctrolDashTotalVentas
            // 
            ctrolDashTotalVentas.BackColor = Color.FromArgb(64, 64, 64);
            ctrolDashTotalVentas.Location = new Point(3, 3);
            ctrolDashTotalVentas.Name = "ctrolDashTotalVentas";
            ctrolDashTotalVentas.Size = new Size(265, 91);
            ctrolDashTotalVentas.TabIndex = 0;
            // 
            // ctrolDashCantClientes
            // 
            ctrolDashCantClientes.BackColor = Color.FromArgb(64, 64, 64);
            ctrolDashCantClientes.Location = new Point(274, 3);
            ctrolDashCantClientes.Name = "ctrolDashCantClientes";
            ctrolDashCantClientes.Size = new Size(265, 91);
            ctrolDashCantClientes.TabIndex = 1;
            // 
            // ctrolDashCaja
            // 
            ctrolDashCaja.BackColor = Color.FromArgb(64, 64, 64);
            ctrolDashCaja.Location = new Point(3, 100);
            ctrolDashCaja.Name = "ctrolDashCaja";
            ctrolDashCaja.Size = new Size(265, 91);
            ctrolDashCaja.TabIndex = 2;
            // 
            // _00114_ModuloDashBoard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(flpContenedor);
            Controls.Add(menuStrip1);
            Name = "_00114_ModuloDashBoard";
            Text = "DashBoard";
            FormClosed += _00114_ModuloDashBoard_FormClosed;
            Load += _00114_ModuloDashBoard_Load;
            Shown += _00114_ModuloDashBoard_Shown;
            Controls.SetChildIndex(pnlTitulo, 0);
            Controls.SetChildIndex(menuStrip1, 0);
            Controls.SetChildIndex(pnlMenuLateral, 0);
            Controls.SetChildIndex(flpContenedor, 0);
            pnlMenuLateral.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            flpContenedor.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartVentaSemanal).EndInit();
            panel2.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem salirToolStripMenuItem;
        private FlowLayoutPanel flpContenedor;
        private Panel panel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartVentaSemanal;
        private Panel panel2;
        private FlowLayoutPanel flowLayoutPanel1;
        private Controles.CtrolDashboard ctrolDashTotalVentas;
        private Controles.CtrolDashboard ctrolDashCantClientes;
        private Controles.CtrolDashboard ctrolDashCaja;
        private Label label1;
    }
}