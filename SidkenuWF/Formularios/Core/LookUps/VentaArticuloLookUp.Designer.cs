namespace SidkenuWF.Formularios.Core.LookUps
{
    partial class VentaArticuloLookUp
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
            pnlDetalleInferior = new Panel();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            imgFotoArticulo = new PictureBox();
            tabPage2 = new TabPage();
            dgvGrillaKit = new DataGridView();
            tabPage5 = new TabPage();
            txtDatoAdicional = new TextBox();
            rtbDetalle = new RichTextBox();
            tabPage6 = new TabPage();
            lblRestringidoFormula = new Label();
            dgvGrillaFormula = new DataGridView();
            tabPage7 = new TabPage();
            pnlDetalleSuperior = new Panel();
            tabControl2 = new TabControl();
            tabPage3 = new TabPage();
            dgvGrillaStock = new DataGridView();
            tabPage4 = new TabPage();
            dgvGrillaStockSucursales = new DataGridView();
            tabPage8 = new TabPage();
            dgvGrillaListaPrecios = new DataGridView();
            pnlDetalle.SuspendLayout();
            pnlDetalleInferior.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgFotoArticulo).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGrillaKit).BeginInit();
            tabPage5.SuspendLayout();
            tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGrillaFormula).BeginInit();
            pnlDetalleSuperior.SuspendLayout();
            tabControl2.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGrillaStock).BeginInit();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGrillaStockSucursales).BeginInit();
            tabPage8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGrillaListaPrecios).BeginInit();
            SuspendLayout();
            // 
            // txtBuscar
            // 
            txtBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            txtBuscar.MaximumSize = new Size(856, 29);
            txtBuscar.Size = new Size(856, 29);
            // 
            // pnlDetalle
            // 
            pnlDetalle.Controls.Add(pnlDetalleSuperior);
            pnlDetalle.Controls.Add(pnlDetalleInferior);
            pnlDetalle.Location = new Point(622, 0);
            pnlDetalle.Size = new Size(362, 450);
            pnlDetalle.Controls.SetChildIndex(pnlDetalleInferior, 0);
            pnlDetalle.Controls.SetChildIndex(pnlDetalleSuperior, 0);
            // 
            // pnlDetalleInferior
            // 
            pnlDetalleInferior.BackColor = Color.White;
            pnlDetalleInferior.Controls.Add(tabControl1);
            pnlDetalleInferior.Dock = DockStyle.Bottom;
            pnlDetalleInferior.Location = new Point(2, 240);
            pnlDetalleInferior.Name = "pnlDetalleInferior";
            pnlDetalleInferior.Size = new Size(360, 210);
            pnlDetalleInferior.TabIndex = 4;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Controls.Add(tabPage6);
            tabControl1.Controls.Add(tabPage7);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.Padding = new Point(10, 6);
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(360, 210);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(imgFotoArticulo);
            tabPage1.Location = new Point(4, 30);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(352, 176);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Foto";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // imgFotoArticulo
            // 
            imgFotoArticulo.BorderStyle = BorderStyle.Fixed3D;
            imgFotoArticulo.Dock = DockStyle.Fill;
            imgFotoArticulo.Location = new Point(3, 3);
            imgFotoArticulo.Name = "imgFotoArticulo";
            imgFotoArticulo.Size = new Size(346, 170);
            imgFotoArticulo.SizeMode = PictureBoxSizeMode.Zoom;
            imgFotoArticulo.TabIndex = 0;
            imgFotoArticulo.TabStop = false;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dgvGrillaKit);
            tabPage2.Location = new Point(4, 30);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(352, 176);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Kit";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvGrillaKit
            // 
            dgvGrillaKit.AllowUserToAddRows = false;
            dgvGrillaKit.AllowUserToDeleteRows = false;
            dgvGrillaKit.BackgroundColor = Color.White;
            dgvGrillaKit.BorderStyle = BorderStyle.None;
            dgvGrillaKit.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGrillaKit.Dock = DockStyle.Fill;
            dgvGrillaKit.GridColor = Color.FromArgb(64, 64, 64);
            dgvGrillaKit.Location = new Point(3, 3);
            dgvGrillaKit.MultiSelect = false;
            dgvGrillaKit.Name = "dgvGrillaKit";
            dgvGrillaKit.RowHeadersVisible = false;
            dgvGrillaKit.RowTemplate.Height = 25;
            dgvGrillaKit.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGrillaKit.Size = new Size(346, 170);
            dgvGrillaKit.TabIndex = 2;
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(txtDatoAdicional);
            tabPage5.Controls.Add(rtbDetalle);
            tabPage5.Location = new Point(4, 30);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(352, 176);
            tabPage5.TabIndex = 2;
            tabPage5.Text = "Detalle";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // txtDatoAdicional
            // 
            txtDatoAdicional.BackColor = Color.White;
            txtDatoAdicional.BorderStyle = BorderStyle.FixedSingle;
            txtDatoAdicional.Location = new Point(6, 6);
            txtDatoAdicional.Name = "txtDatoAdicional";
            txtDatoAdicional.ReadOnly = true;
            txtDatoAdicional.Size = new Size(340, 23);
            txtDatoAdicional.TabIndex = 1;
            // 
            // rtbDetalle
            // 
            rtbDetalle.BackColor = Color.White;
            rtbDetalle.BorderStyle = BorderStyle.FixedSingle;
            rtbDetalle.BulletIndent = 3;
            rtbDetalle.Location = new Point(7, 35);
            rtbDetalle.Name = "rtbDetalle";
            rtbDetalle.ReadOnly = true;
            rtbDetalle.ShowSelectionMargin = true;
            rtbDetalle.Size = new Size(339, 134);
            rtbDetalle.TabIndex = 0;
            rtbDetalle.Text = "";
            // 
            // tabPage6
            // 
            tabPage6.Controls.Add(lblRestringidoFormula);
            tabPage6.Controls.Add(dgvGrillaFormula);
            tabPage6.Location = new Point(4, 30);
            tabPage6.Name = "tabPage6";
            tabPage6.Padding = new Padding(3);
            tabPage6.Size = new Size(352, 176);
            tabPage6.TabIndex = 3;
            tabPage6.Text = "Formula";
            tabPage6.UseVisualStyleBackColor = true;
            // 
            // lblRestringidoFormula
            // 
            lblRestringidoFormula.BackColor = Color.Red;
            lblRestringidoFormula.Font = new Font("Arial Rounded MT Bold", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblRestringidoFormula.ForeColor = Color.White;
            lblRestringidoFormula.Location = new Point(18, 44);
            lblRestringidoFormula.Name = "lblRestringidoFormula";
            lblRestringidoFormula.Size = new Size(322, 82);
            lblRestringidoFormula.TabIndex = 3;
            lblRestringidoFormula.Text = "RESTRINGIDO";
            lblRestringidoFormula.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvGrillaFormula
            // 
            dgvGrillaFormula.AllowUserToAddRows = false;
            dgvGrillaFormula.AllowUserToDeleteRows = false;
            dgvGrillaFormula.BackgroundColor = Color.White;
            dgvGrillaFormula.BorderStyle = BorderStyle.None;
            dgvGrillaFormula.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGrillaFormula.Dock = DockStyle.Fill;
            dgvGrillaFormula.GridColor = Color.FromArgb(64, 64, 64);
            dgvGrillaFormula.Location = new Point(3, 3);
            dgvGrillaFormula.MultiSelect = false;
            dgvGrillaFormula.Name = "dgvGrillaFormula";
            dgvGrillaFormula.RowHeadersVisible = false;
            dgvGrillaFormula.RowTemplate.Height = 25;
            dgvGrillaFormula.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGrillaFormula.Size = new Size(346, 170);
            dgvGrillaFormula.TabIndex = 2;
            // 
            // tabPage7
            // 
            tabPage7.Location = new Point(4, 30);
            tabPage7.Name = "tabPage7";
            tabPage7.Padding = new Padding(3);
            tabPage7.Size = new Size(352, 176);
            tabPage7.TabIndex = 4;
            tabPage7.Text = "Sugeridos";
            tabPage7.UseVisualStyleBackColor = true;
            // 
            // pnlDetalleSuperior
            // 
            pnlDetalleSuperior.BackColor = Color.White;
            pnlDetalleSuperior.Controls.Add(tabControl2);
            pnlDetalleSuperior.Dock = DockStyle.Fill;
            pnlDetalleSuperior.Location = new Point(2, 39);
            pnlDetalleSuperior.Name = "pnlDetalleSuperior";
            pnlDetalleSuperior.Size = new Size(360, 201);
            pnlDetalleSuperior.TabIndex = 5;
            // 
            // tabControl2
            // 
            tabControl2.Controls.Add(tabPage3);
            tabControl2.Controls.Add(tabPage4);
            tabControl2.Controls.Add(tabPage8);
            tabControl2.Dock = DockStyle.Fill;
            tabControl2.Location = new Point(0, 0);
            tabControl2.Name = "tabControl2";
            tabControl2.Padding = new Point(10, 6);
            tabControl2.SelectedIndex = 0;
            tabControl2.Size = new Size(360, 201);
            tabControl2.TabIndex = 1;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(dgvGrillaStock);
            tabPage3.Location = new Point(4, 30);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(352, 167);
            tabPage3.TabIndex = 0;
            tabPage3.Text = "Stock";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgvGrillaStock
            // 
            dgvGrillaStock.AllowUserToAddRows = false;
            dgvGrillaStock.AllowUserToDeleteRows = false;
            dgvGrillaStock.BackgroundColor = Color.White;
            dgvGrillaStock.BorderStyle = BorderStyle.None;
            dgvGrillaStock.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGrillaStock.Dock = DockStyle.Fill;
            dgvGrillaStock.GridColor = Color.FromArgb(64, 64, 64);
            dgvGrillaStock.Location = new Point(3, 3);
            dgvGrillaStock.MultiSelect = false;
            dgvGrillaStock.Name = "dgvGrillaStock";
            dgvGrillaStock.RowHeadersVisible = false;
            dgvGrillaStock.RowTemplate.Height = 25;
            dgvGrillaStock.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGrillaStock.Size = new Size(346, 161);
            dgvGrillaStock.TabIndex = 1;
            // 
            // tabPage4
            // 
            tabPage4.BackColor = Color.White;
            tabPage4.Controls.Add(dgvGrillaStockSucursales);
            tabPage4.Location = new Point(4, 30);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(352, 167);
            tabPage4.TabIndex = 1;
            tabPage4.Text = "Stock en Sucursales";
            // 
            // dgvGrillaStockSucursales
            // 
            dgvGrillaStockSucursales.AllowUserToAddRows = false;
            dgvGrillaStockSucursales.AllowUserToDeleteRows = false;
            dgvGrillaStockSucursales.BackgroundColor = Color.White;
            dgvGrillaStockSucursales.BorderStyle = BorderStyle.None;
            dgvGrillaStockSucursales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGrillaStockSucursales.Dock = DockStyle.Fill;
            dgvGrillaStockSucursales.GridColor = Color.FromArgb(64, 64, 64);
            dgvGrillaStockSucursales.Location = new Point(3, 3);
            dgvGrillaStockSucursales.MultiSelect = false;
            dgvGrillaStockSucursales.Name = "dgvGrillaStockSucursales";
            dgvGrillaStockSucursales.RowHeadersVisible = false;
            dgvGrillaStockSucursales.RowTemplate.Height = 25;
            dgvGrillaStockSucursales.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGrillaStockSucursales.Size = new Size(346, 161);
            dgvGrillaStockSucursales.TabIndex = 2;
            // 
            // tabPage8
            // 
            tabPage8.Controls.Add(dgvGrillaListaPrecios);
            tabPage8.Location = new Point(4, 30);
            tabPage8.Name = "tabPage8";
            tabPage8.Padding = new Padding(3);
            tabPage8.Size = new Size(352, 167);
            tabPage8.TabIndex = 2;
            tabPage8.Text = "Lista de Precio";
            tabPage8.UseVisualStyleBackColor = true;
            // 
            // dgvGrillaListaPrecios
            // 
            dgvGrillaListaPrecios.AllowUserToAddRows = false;
            dgvGrillaListaPrecios.AllowUserToDeleteRows = false;
            dgvGrillaListaPrecios.BackgroundColor = Color.White;
            dgvGrillaListaPrecios.BorderStyle = BorderStyle.None;
            dgvGrillaListaPrecios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGrillaListaPrecios.Dock = DockStyle.Fill;
            dgvGrillaListaPrecios.GridColor = Color.FromArgb(64, 64, 64);
            dgvGrillaListaPrecios.Location = new Point(3, 3);
            dgvGrillaListaPrecios.MultiSelect = false;
            dgvGrillaListaPrecios.Name = "dgvGrillaListaPrecios";
            dgvGrillaListaPrecios.RowHeadersVisible = false;
            dgvGrillaListaPrecios.RowTemplate.Height = 25;
            dgvGrillaListaPrecios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGrillaListaPrecios.Size = new Size(346, 161);
            dgvGrillaListaPrecios.TabIndex = 3;
            // 
            // VentaArticuloLookUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 561);
            MaximumSize = new Size(1000, 600);
            MinimumSize = new Size(1000, 600);
            Name = "VentaArticuloLookUp";
            Text = "ArticuloLookUp";
            pnlDetalle.ResumeLayout(false);
            pnlDetalleInferior.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)imgFotoArticulo).EndInit();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvGrillaKit).EndInit();
            tabPage5.ResumeLayout(false);
            tabPage5.PerformLayout();
            tabPage6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvGrillaFormula).EndInit();
            pnlDetalleSuperior.ResumeLayout(false);
            tabControl2.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvGrillaStock).EndInit();
            tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvGrillaStockSucursales).EndInit();
            tabPage8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvGrillaListaPrecios).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlDetalleSuperior;
        private TabControl tabControl2;
        private TabPage tabPage3;
        private Panel pnlDetalleInferior;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        public DataGridView dgvGrillaStock;
        private PictureBox imgFotoArticulo;
        private TabPage tabPage4;
        public DataGridView dgvGrillaStockSucursales;
        private TabPage tabPage5;
        private TabPage tabPage8;
        private TabPage tabPage6;
        private TabPage tabPage7;
        public DataGridView dgvGrillaListaPrecios;
        private RichTextBox rtbDetalle;
        private TextBox txtDatoAdicional;
        public DataGridView dgvGrillaKit;
        public DataGridView dgvGrillaFormula;
        private Label lblRestringidoFormula;
    }
}