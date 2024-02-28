namespace SidkenuWF.Formularios.Core
{
    partial class _00142_OrdenesFabricacion
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
            pnlMenu = new Panel();
            btnNuevo = new FontAwesome.Sharp.IconButton();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            pnlEnProceso = new Panel();
            flpEnProceso = new FlowLayoutPanel();
            panel8 = new Panel();
            panel9 = new Panel();
            label1 = new Label();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            textBox2 = new TextBox();
            pnlSeparador2 = new Panel();
            pnlFinalizados = new Panel();
            flpFinalizado = new FlowLayoutPanel();
            panel5 = new Panel();
            panel6 = new Panel();
            label3 = new Label();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            textBox1 = new TextBox();
            pnlSeparador1 = new Panel();
            pnlPendiente = new Panel();
            flpPendientes = new FlowLayoutPanel();
            panel2 = new Panel();
            pnlBusqueda = new Panel();
            label2 = new Label();
            btnBuscarPendiente = new FontAwesome.Sharp.IconButton();
            txtBuscarPendiente = new TextBox();
            tabPage2 = new TabPage();
            pnlMenu.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            pnlEnProceso.SuspendLayout();
            panel9.SuspendLayout();
            pnlFinalizados.SuspendLayout();
            panel6.SuspendLayout();
            pnlPendiente.SuspendLayout();
            pnlBusqueda.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = Color.FromArgb(48, 66, 80);
            pnlMenu.Controls.Add(btnNuevo);
            pnlMenu.Dock = DockStyle.Top;
            pnlMenu.Location = new Point(0, 59);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(784, 52);
            pnlMenu.TabIndex = 1;
            // 
            // btnNuevo
            // 
            btnNuevo.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnNuevo.BackColor = Color.FromArgb(54, 74, 90);
            btnNuevo.FlatAppearance.BorderColor = Color.WhiteSmoke;
            btnNuevo.FlatAppearance.BorderSize = 0;
            btnNuevo.FlatStyle = FlatStyle.Flat;
            btnNuevo.ForeColor = Color.WhiteSmoke;
            btnNuevo.IconChar = FontAwesome.Sharp.IconChar.Add;
            btnNuevo.IconColor = Color.WhiteSmoke;
            btnNuevo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnNuevo.IconSize = 22;
            btnNuevo.Location = new Point(8, 7);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(43, 38);
            btnNuevo.TabIndex = 4;
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += BtnNuevo_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 111);
            tabControl1.Name = "tabControl1";
            tabControl1.Padding = new Point(6, 10);
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(784, 450);
            tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(pnlEnProceso);
            tabPage1.Controls.Add(pnlSeparador2);
            tabPage1.Controls.Add(pnlFinalizados);
            tabPage1.Controls.Add(pnlSeparador1);
            tabPage1.Controls.Add(pnlPendiente);
            tabPage1.Location = new Point(4, 38);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(776, 408);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Ordenes de Fabricación";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // pnlEnProceso
            // 
            pnlEnProceso.BackColor = Color.White;
            pnlEnProceso.Controls.Add(flpEnProceso);
            pnlEnProceso.Controls.Add(panel8);
            pnlEnProceso.Controls.Add(panel9);
            pnlEnProceso.Dock = DockStyle.Fill;
            pnlEnProceso.Location = new Point(246, 3);
            pnlEnProceso.Name = "pnlEnProceso";
            pnlEnProceso.Size = new Size(284, 402);
            pnlEnProceso.TabIndex = 8;
            // 
            // flpEnProceso
            // 
            flpEnProceso.AllowDrop = true;
            flpEnProceso.Dock = DockStyle.Fill;
            flpEnProceso.Location = new Point(0, 77);
            flpEnProceso.Name = "flpEnProceso";
            flpEnProceso.Size = new Size(284, 325);
            flpEnProceso.TabIndex = 2;
            // 
            // panel8
            // 
            panel8.BackColor = Color.Gainsboro;
            panel8.Dock = DockStyle.Top;
            panel8.Location = new Point(0, 74);
            panel8.Name = "panel8";
            panel8.Size = new Size(284, 3);
            panel8.TabIndex = 1;
            // 
            // panel9
            // 
            panel9.Controls.Add(label1);
            panel9.Controls.Add(iconButton2);
            panel9.Controls.Add(textBox2);
            panel9.Dock = DockStyle.Top;
            panel9.Location = new Point(0, 0);
            panel9.Name = "panel9";
            panel9.Size = new Size(284, 74);
            panel9.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.BackColor = Color.WhiteSmoke;
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(7, 6);
            label1.Name = "label1";
            label1.Size = new Size(289, 23);
            label1.TabIndex = 6;
            label1.Text = "Ordenes en Proceso";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // iconButton2
            // 
            iconButton2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconButton2.BackColor = Color.FromArgb(48, 66, 80);
            iconButton2.FlatAppearance.BorderColor = Color.WhiteSmoke;
            iconButton2.FlatStyle = FlatStyle.Flat;
            iconButton2.ForeColor = Color.WhiteSmoke;
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            iconButton2.IconColor = Color.WhiteSmoke;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.IconSize = 20;
            iconButton2.Location = new Point(203, 37);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(75, 29);
            iconButton2.TabIndex = 5;
            iconButton2.Text = "Buscar";
            iconButton2.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton2.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(7, 37);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Ingrese un texto";
            textBox2.Size = new Size(190, 29);
            textBox2.TabIndex = 4;
            // 
            // pnlSeparador2
            // 
            pnlSeparador2.BackColor = Color.FromArgb(64, 64, 64);
            pnlSeparador2.Dock = DockStyle.Right;
            pnlSeparador2.Location = new Point(530, 3);
            pnlSeparador2.Name = "pnlSeparador2";
            pnlSeparador2.Size = new Size(10, 402);
            pnlSeparador2.TabIndex = 7;
            // 
            // pnlFinalizados
            // 
            pnlFinalizados.BackColor = Color.White;
            pnlFinalizados.Controls.Add(flpFinalizado);
            pnlFinalizados.Controls.Add(panel5);
            pnlFinalizados.Controls.Add(panel6);
            pnlFinalizados.Dock = DockStyle.Right;
            pnlFinalizados.Location = new Point(540, 3);
            pnlFinalizados.Name = "pnlFinalizados";
            pnlFinalizados.Size = new Size(233, 402);
            pnlFinalizados.TabIndex = 6;
            // 
            // flpFinalizado
            // 
            flpFinalizado.AllowDrop = true;
            flpFinalizado.Dock = DockStyle.Fill;
            flpFinalizado.Location = new Point(0, 77);
            flpFinalizado.Name = "flpFinalizado";
            flpFinalizado.Size = new Size(233, 325);
            flpFinalizado.TabIndex = 2;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Gainsboro;
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 74);
            panel5.Name = "panel5";
            panel5.Size = new Size(233, 3);
            panel5.TabIndex = 1;
            // 
            // panel6
            // 
            panel6.Controls.Add(label3);
            panel6.Controls.Add(iconButton1);
            panel6.Controls.Add(textBox1);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(233, 74);
            panel6.TabIndex = 0;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.BackColor = Color.WhiteSmoke;
            label3.ForeColor = Color.FromArgb(64, 64, 64);
            label3.Location = new Point(6, 6);
            label3.Name = "label3";
            label3.Size = new Size(220, 23);
            label3.TabIndex = 8;
            label3.Text = "Ordenes Finalizadas";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // iconButton1
            // 
            iconButton1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconButton1.BackColor = Color.FromArgb(48, 66, 80);
            iconButton1.FlatAppearance.BorderColor = Color.WhiteSmoke;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.ForeColor = Color.WhiteSmoke;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            iconButton1.IconColor = Color.WhiteSmoke;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 20;
            iconButton1.Location = new Point(152, 37);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(75, 29);
            iconButton1.TabIndex = 5;
            iconButton1.Text = "Buscar";
            iconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton1.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(7, 37);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Ingrese un texto";
            textBox1.Size = new Size(139, 29);
            textBox1.TabIndex = 4;
            // 
            // pnlSeparador1
            // 
            pnlSeparador1.BackColor = Color.FromArgb(64, 64, 64);
            pnlSeparador1.Dock = DockStyle.Left;
            pnlSeparador1.Location = new Point(236, 3);
            pnlSeparador1.Name = "pnlSeparador1";
            pnlSeparador1.Size = new Size(10, 402);
            pnlSeparador1.TabIndex = 5;
            // 
            // pnlPendiente
            // 
            pnlPendiente.BackColor = Color.White;
            pnlPendiente.Controls.Add(flpPendientes);
            pnlPendiente.Controls.Add(panel2);
            pnlPendiente.Controls.Add(pnlBusqueda);
            pnlPendiente.Dock = DockStyle.Left;
            pnlPendiente.Location = new Point(3, 3);
            pnlPendiente.Name = "pnlPendiente";
            pnlPendiente.Size = new Size(233, 402);
            pnlPendiente.TabIndex = 4;
            // 
            // flpPendientes
            // 
            flpPendientes.AllowDrop = true;
            flpPendientes.Dock = DockStyle.Fill;
            flpPendientes.Location = new Point(0, 77);
            flpPendientes.Name = "flpPendientes";
            flpPendientes.Size = new Size(233, 325);
            flpPendientes.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gainsboro;
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 74);
            panel2.Name = "panel2";
            panel2.Size = new Size(233, 3);
            panel2.TabIndex = 1;
            // 
            // pnlBusqueda
            // 
            pnlBusqueda.Controls.Add(label2);
            pnlBusqueda.Controls.Add(btnBuscarPendiente);
            pnlBusqueda.Controls.Add(txtBuscarPendiente);
            pnlBusqueda.Dock = DockStyle.Top;
            pnlBusqueda.Location = new Point(0, 0);
            pnlBusqueda.Name = "pnlBusqueda";
            pnlBusqueda.Size = new Size(233, 74);
            pnlBusqueda.TabIndex = 0;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.BackColor = Color.WhiteSmoke;
            label2.ForeColor = Color.FromArgb(64, 64, 64);
            label2.Location = new Point(7, 6);
            label2.Name = "label2";
            label2.Size = new Size(220, 23);
            label2.TabIndex = 7;
            label2.Text = "Ordenes Pendientes";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnBuscarPendiente
            // 
            btnBuscarPendiente.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBuscarPendiente.BackColor = Color.FromArgb(48, 66, 80);
            btnBuscarPendiente.FlatAppearance.BorderColor = Color.WhiteSmoke;
            btnBuscarPendiente.FlatStyle = FlatStyle.Flat;
            btnBuscarPendiente.ForeColor = Color.WhiteSmoke;
            btnBuscarPendiente.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            btnBuscarPendiente.IconColor = Color.WhiteSmoke;
            btnBuscarPendiente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBuscarPendiente.IconSize = 20;
            btnBuscarPendiente.Location = new Point(152, 37);
            btnBuscarPendiente.Name = "btnBuscarPendiente";
            btnBuscarPendiente.Size = new Size(75, 29);
            btnBuscarPendiente.TabIndex = 5;
            btnBuscarPendiente.Text = "Buscar";
            btnBuscarPendiente.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBuscarPendiente.UseVisualStyleBackColor = false;
            // 
            // txtBuscarPendiente
            // 
            txtBuscarPendiente.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBuscarPendiente.BorderStyle = BorderStyle.FixedSingle;
            txtBuscarPendiente.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtBuscarPendiente.Location = new Point(7, 37);
            txtBuscarPendiente.Name = "txtBuscarPendiente";
            txtBuscarPendiente.PlaceholderText = "Ingrese un texto";
            txtBuscarPendiente.Size = new Size(139, 29);
            txtBuscarPendiente.TabIndex = 4;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 38);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(776, 408);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Ordenes de Fabricación (Lista)";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // _00142_OrdenesFabricacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(tabControl1);
            Controls.Add(pnlMenu);
            Name = "_00142_OrdenesFabricacion";
            Text = "Ordenes de Fabricación";
            FormClosing += _00142_OrdenesFabricacion_FormClosing;
            Shown += _00142_OrdenesFabricacion_Shown;
            Controls.SetChildIndex(pnlMenu, 0);
            Controls.SetChildIndex(tabControl1, 0);
            pnlMenu.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            pnlEnProceso.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            pnlFinalizados.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            pnlPendiente.ResumeLayout(false);
            pnlBusqueda.ResumeLayout(false);
            pnlBusqueda.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlMenu;
        private FontAwesome.Sharp.IconButton btnNuevo;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private Panel pnlSeparador1;
        private Panel pnlPendiente;
        private FlowLayoutPanel flpPendientes;
        private Panel panel2;
        private Panel pnlBusqueda;
        private FontAwesome.Sharp.IconButton btnBuscarPendiente;
        public TextBox txtBuscarPendiente;
        private TabPage tabPage2;
        private Panel pnlEnProceso;
        private FlowLayoutPanel flpEnProceso;
        private Panel panel8;
        private Panel panel9;
        private FontAwesome.Sharp.IconButton iconButton2;
        public TextBox textBox2;
        private Panel pnlSeparador2;
        private Panel pnlFinalizados;
        private FlowLayoutPanel flpFinalizado;
        private Panel panel5;
        private Panel panel6;
        private FontAwesome.Sharp.IconButton iconButton1;
        public TextBox textBox1;
        private Label label1;
        private Label label3;
        private Label label2;
    }
}