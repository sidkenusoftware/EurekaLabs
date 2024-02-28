namespace SidkenuWF.Formularios.Seguridad
{
    partial class Empresas
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
            flpContenedor = new FlowLayoutPanel();
            pnlLinea = new Panel();
            pnlSuperior = new Panel();
            label1 = new Label();
            panel1 = new Panel();
            pnlSuperior.SuspendLayout();
            SuspendLayout();
            // 
            // flpContenedor
            // 
            flpContenedor.BackColor = Color.Silver;
            flpContenedor.Dock = DockStyle.Fill;
            flpContenedor.Location = new Point(0, 44);
            flpContenedor.Name = "flpContenedor";
            flpContenedor.Padding = new Padding(10);
            flpContenedor.Size = new Size(743, 451);
            flpContenedor.TabIndex = 3;
            // 
            // pnlLinea
            // 
            pnlLinea.BackColor = Color.FromArgb(255, 128, 0);
            pnlLinea.Dock = DockStyle.Bottom;
            pnlLinea.Location = new Point(0, 43);
            pnlLinea.Name = "pnlLinea";
            pnlLinea.Size = new Size(743, 1);
            pnlLinea.TabIndex = 0;
            // 
            // pnlSuperior
            // 
            pnlSuperior.BackColor = Color.FromArgb(48, 66, 80);
            pnlSuperior.Controls.Add(label1);
            pnlSuperior.Controls.Add(pnlLinea);
            pnlSuperior.Dock = DockStyle.Top;
            pnlSuperior.ForeColor = Color.WhiteSmoke;
            pnlSuperior.Location = new Point(0, 0);
            pnlSuperior.Name = "pnlSuperior";
            pnlSuperior.Size = new Size(743, 44);
            pnlSuperior.TabIndex = 2;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(6, 5);
            label1.Name = "label1";
            label1.Size = new Size(731, 33);
            label1.TabIndex = 1;
            label1.Text = "Seleccione una Empresa";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(192, 64, 0);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 495);
            panel1.Name = "panel1";
            panel1.Size = new Size(743, 5);
            panel1.TabIndex = 4;
            // 
            // Empresas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(743, 500);
            Controls.Add(flpContenedor);
            Controls.Add(pnlSuperior);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MaximumSize = new Size(743, 500);
            MdiChildrenMinimizedAnchorBottom = false;
            MinimumSize = new Size(743, 500);
            Name = "Empresas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Empresas";
            pnlSuperior.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flpContenedor;
        private Panel pnlLinea;
        private Panel pnlSuperior;
        private Label label1;
        private Panel panel1;
    }
}