namespace SidkenuWF.Formularios.Core
{
    partial class _00146_ConfiguracionBalanza
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            gpbPeso = new GroupBox();
            nudEquivalencia = new NumericUpDown();
            label14 = new Label();
            label13 = new Label();
            chkConvierteUnidadPeso = new Base.Controles.SidkenuToggleButton();
            label10 = new Label();
            nudDecimalPeso = new NumericUpDown();
            label11 = new Label();
            nudCodigoPeso = new NumericUpDown();
            gpbImporte = new GroupBox();
            label9 = new Label();
            nudDecimalImporte = new NumericUpDown();
            label8 = new Label();
            nudCodigoImporte = new NumericUpDown();
            tabPage2 = new TabPage();
            label6 = new Label();
            nudIdentImportePesoHasta = new NumericUpDown();
            label7 = new Label();
            nudIdentImportePesoDesde = new NumericUpDown();
            label4 = new Label();
            nudIdentCodigoArticuloHasta = new NumericUpDown();
            label5 = new Label();
            nudIdentCodigoArticuloDesde = new NumericUpDown();
            label3 = new Label();
            nudIdentTipoCodigoHasta = new NumericUpDown();
            label2 = new Label();
            nudIdentTipoCodigoDesde = new NumericUpDown();
            label1 = new Label();
            nudLongitudTotal = new NumericUpDown();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            gpbPeso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudEquivalencia).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudDecimalPeso).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudCodigoPeso).BeginInit();
            gpbImporte.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudDecimalImporte).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudCodigoImporte).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudIdentImportePesoHasta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudIdentImportePesoDesde).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudIdentCodigoArticuloHasta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudIdentCodigoArticuloDesde).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudIdentTipoCodigoHasta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudIdentTipoCodigoDesde).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudLongitudTotal).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 57);
            tabControl1.Name = "tabControl1";
            tabControl1.Padding = new Point(10, 10);
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(602, 346);
            tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.White;
            tabPage1.Controls.Add(gpbPeso);
            tabPage1.Controls.Add(gpbImporte);
            tabPage1.Location = new Point(4, 38);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(594, 304);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Principal";
            // 
            // gpbPeso
            // 
            gpbPeso.Controls.Add(nudEquivalencia);
            gpbPeso.Controls.Add(label14);
            gpbPeso.Controls.Add(label13);
            gpbPeso.Controls.Add(chkConvierteUnidadPeso);
            gpbPeso.Controls.Add(label10);
            gpbPeso.Controls.Add(nudDecimalPeso);
            gpbPeso.Controls.Add(label11);
            gpbPeso.Controls.Add(nudCodigoPeso);
            gpbPeso.Location = new Point(10, 109);
            gpbPeso.Name = "gpbPeso";
            gpbPeso.Size = new Size(564, 182);
            gpbPeso.TabIndex = 7;
            gpbPeso.TabStop = false;
            gpbPeso.Text = "[ Identificación por Peso ]";
            // 
            // nudEquivalencia
            // 
            nudEquivalencia.BorderStyle = BorderStyle.FixedSingle;
            nudEquivalencia.DecimalPlaces = 4;
            nudEquivalencia.Enabled = false;
            nudEquivalencia.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            nudEquivalencia.Location = new Point(126, 134);
            nudEquivalencia.Maximum = new decimal(new int[] { 1215752192, 23, 0, 0 });
            nudEquivalencia.Name = "nudEquivalencia";
            nudEquivalencia.Size = new Size(188, 27);
            nudEquivalencia.TabIndex = 116;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(35, 139);
            label14.Name = "label14";
            label14.Size = new Size(85, 16);
            label14.TabIndex = 115;
            label14.Text = "Equivalencia";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(71, 104);
            label13.Name = "label13";
            label13.Size = new Size(162, 16);
            label13.TabIndex = 111;
            label13.Text = "Convierte unidad de Peso";
            // 
            // chkConvierteUnidadPeso
            // 
            chkConvierteUnidadPeso.AutoSize = true;
            chkConvierteUnidadPeso.Location = new Point(20, 100);
            chkConvierteUnidadPeso.MinimumSize = new Size(45, 22);
            chkConvierteUnidadPeso.Name = "chkConvierteUnidadPeso";
            chkConvierteUnidadPeso.OffBackColor = Color.Gray;
            chkConvierteUnidadPeso.OffToggleColor = Color.Gainsboro;
            chkConvierteUnidadPeso.OnBackColor = Color.Green;
            chkConvierteUnidadPeso.OnToggleColor = Color.WhiteSmoke;
            chkConvierteUnidadPeso.Size = new Size(45, 22);
            chkConvierteUnidadPeso.TabIndex = 110;
            chkConvierteUnidadPeso.UseVisualStyleBackColor = true;
            chkConvierteUnidadPeso.CheckedChanged += ChkConvierteUnidadPeso_CheckedChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(252, 26);
            label10.Name = "label10";
            label10.Size = new Size(111, 15);
            label10.TabIndex = 7;
            label10.Text = "Cantidad decimales";
            // 
            // nudDecimalPeso
            // 
            nudDecimalPeso.BorderStyle = BorderStyle.FixedSingle;
            nudDecimalPeso.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            nudDecimalPeso.Location = new Point(252, 46);
            nudDecimalPeso.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudDecimalPeso.Name = "nudDecimalPeso";
            nudDecimalPeso.Size = new Size(188, 27);
            nudDecimalPeso.TabIndex = 6;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(23, 26);
            label11.Name = "label11";
            label11.Size = new Size(46, 15);
            label11.TabIndex = 5;
            label11.Text = "Codigo";
            // 
            // nudCodigoPeso
            // 
            nudCodigoPeso.BorderStyle = BorderStyle.FixedSingle;
            nudCodigoPeso.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            nudCodigoPeso.Location = new Point(20, 46);
            nudCodigoPeso.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudCodigoPeso.Name = "nudCodigoPeso";
            nudCodigoPeso.Size = new Size(188, 27);
            nudCodigoPeso.TabIndex = 4;
            // 
            // gpbImporte
            // 
            gpbImporte.Controls.Add(label9);
            gpbImporte.Controls.Add(nudDecimalImporte);
            gpbImporte.Controls.Add(label8);
            gpbImporte.Controls.Add(nudCodigoImporte);
            gpbImporte.Location = new Point(10, 12);
            gpbImporte.Name = "gpbImporte";
            gpbImporte.Size = new Size(564, 91);
            gpbImporte.TabIndex = 6;
            gpbImporte.TabStop = false;
            gpbImporte.Text = "[ Identificación por Importe ]";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(255, 31);
            label9.Name = "label9";
            label9.Size = new Size(111, 15);
            label9.TabIndex = 7;
            label9.Text = "Cantidad decimales";
            // 
            // nudDecimalImporte
            // 
            nudDecimalImporte.BorderStyle = BorderStyle.FixedSingle;
            nudDecimalImporte.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            nudDecimalImporte.Location = new Point(252, 51);
            nudDecimalImporte.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudDecimalImporte.Name = "nudDecimalImporte";
            nudDecimalImporte.Size = new Size(188, 27);
            nudDecimalImporte.TabIndex = 6;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(23, 31);
            label8.Name = "label8";
            label8.Size = new Size(46, 15);
            label8.TabIndex = 5;
            label8.Text = "Codigo";
            // 
            // nudCodigoImporte
            // 
            nudCodigoImporte.BorderStyle = BorderStyle.FixedSingle;
            nudCodigoImporte.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            nudCodigoImporte.Location = new Point(20, 51);
            nudCodigoImporte.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudCodigoImporte.Name = "nudCodigoImporte";
            nudCodigoImporte.Size = new Size(188, 27);
            nudCodigoImporte.TabIndex = 4;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.White;
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(nudIdentImportePesoHasta);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(nudIdentImportePesoDesde);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(nudIdentCodigoArticuloHasta);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(nudIdentCodigoArticuloDesde);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(nudIdentTipoCodigoHasta);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(nudIdentTipoCodigoDesde);
            tabPage2.Controls.Add(label1);
            tabPage2.Controls.Add(nudLongitudTotal);
            tabPage2.Location = new Point(4, 38);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(594, 304);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Codigo de barras";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(305, 220);
            label6.Name = "label6";
            label6.Size = new Size(258, 15);
            label6.TabIndex = 13;
            label6.Text = "Cantidad dígito para identificar el Importe/Peso";
            // 
            // nudIdentImportePesoHasta
            // 
            nudIdentImportePesoHasta.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            nudIdentImportePesoHasta.Location = new Point(305, 238);
            nudIdentImportePesoHasta.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudIdentImportePesoHasta.Name = "nudIdentImportePesoHasta";
            nudIdentImportePesoHasta.Size = new Size(268, 27);
            nudIdentImportePesoHasta.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(20, 220);
            label7.Name = "label7";
            label7.Size = new Size(242, 15);
            label7.TabIndex = 11;
            label7.Text = "Desde dígito para identificar el Importe/Peso";
            // 
            // nudIdentImportePesoDesde
            // 
            nudIdentImportePesoDesde.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            nudIdentImportePesoDesde.Location = new Point(20, 238);
            nudIdentImportePesoDesde.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudIdentImportePesoDesde.Name = "nudIdentImportePesoDesde";
            nudIdentImportePesoDesde.Size = new Size(268, 27);
            nudIdentImportePesoDesde.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(305, 156);
            label4.Name = "label4";
            label4.Size = new Size(286, 15);
            label4.TabIndex = 9;
            label4.Text = "Cantidad dígito para identificar el Código de Articulo";
            // 
            // nudIdentCodigoArticuloHasta
            // 
            nudIdentCodigoArticuloHasta.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            nudIdentCodigoArticuloHasta.Location = new Point(305, 174);
            nudIdentCodigoArticuloHasta.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudIdentCodigoArticuloHasta.Name = "nudIdentCodigoArticuloHasta";
            nudIdentCodigoArticuloHasta.Size = new Size(268, 27);
            nudIdentCodigoArticuloHasta.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 156);
            label5.Name = "label5";
            label5.Size = new Size(270, 15);
            label5.TabIndex = 7;
            label5.Text = "Desde dígito para identificar el Código de Articulo";
            // 
            // nudIdentCodigoArticuloDesde
            // 
            nudIdentCodigoArticuloDesde.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            nudIdentCodigoArticuloDesde.Location = new Point(20, 174);
            nudIdentCodigoArticuloDesde.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudIdentCodigoArticuloDesde.Name = "nudIdentCodigoArticuloDesde";
            nudIdentCodigoArticuloDesde.Size = new Size(268, 27);
            nudIdentCodigoArticuloDesde.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(307, 94);
            label3.Name = "label3";
            label3.Size = new Size(272, 15);
            label3.TabIndex = 5;
            label3.Text = "Cantidad dígitos para identificar el Tipo de Código";
            // 
            // nudIdentTipoCodigoHasta
            // 
            nudIdentTipoCodigoHasta.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            nudIdentTipoCodigoHasta.Location = new Point(307, 112);
            nudIdentTipoCodigoHasta.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudIdentTipoCodigoHasta.Name = "nudIdentTipoCodigoHasta";
            nudIdentTipoCodigoHasta.Size = new Size(268, 27);
            nudIdentTipoCodigoHasta.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 94);
            label2.Name = "label2";
            label2.Size = new Size(251, 15);
            label2.TabIndex = 3;
            label2.Text = "Desde dígito para identificar el Tipo de Código";
            // 
            // nudIdentTipoCodigoDesde
            // 
            nudIdentTipoCodigoDesde.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            nudIdentTipoCodigoDesde.Location = new Point(22, 112);
            nudIdentTipoCodigoDesde.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudIdentTipoCodigoDesde.Name = "nudIdentTipoCodigoDesde";
            nudIdentTipoCodigoDesde.Size = new Size(268, 27);
            nudIdentTipoCodigoDesde.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 28);
            label1.Name = "label1";
            label1.Size = new Size(83, 15);
            label1.TabIndex = 1;
            label1.Text = "Longitud Total";
            // 
            // nudLongitudTotal
            // 
            nudLongitudTotal.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            nudLongitudTotal.Location = new Point(22, 46);
            nudLongitudTotal.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudLongitudTotal.Name = "nudLongitudTotal";
            nudLongitudTotal.Size = new Size(133, 27);
            nudLongitudTotal.TabIndex = 0;
            // 
            // _00146_ConfiguracionBalanza
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(602, 443);
            Controls.Add(tabControl1);
            Name = "_00146_ConfiguracionBalanza";
            Text = "Parametrizacion de Balanza";
            Load += _00146_ConfiguracionBalanza_Load;
            Controls.SetChildIndex(tabControl1, 0);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            gpbPeso.ResumeLayout(false);
            gpbPeso.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudEquivalencia).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudDecimalPeso).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudCodigoPeso).EndInit();
            gpbImporte.ResumeLayout(false);
            gpbImporte.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudDecimalImporte).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudCodigoImporte).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudIdentImportePesoHasta).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudIdentImportePesoDesde).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudIdentCodigoArticuloHasta).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudIdentCodigoArticuloDesde).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudIdentTipoCodigoHasta).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudIdentTipoCodigoDesde).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudLongitudTotal).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label6;
        private NumericUpDown nudIdentImportePesoHasta;
        private Label label7;
        private NumericUpDown nudIdentImportePesoDesde;
        private Label label4;
        private NumericUpDown nudIdentCodigoArticuloHasta;
        private Label label5;
        private NumericUpDown nudIdentCodigoArticuloDesde;
        private Label label3;
        private NumericUpDown nudIdentTipoCodigoHasta;
        private Label label2;
        private NumericUpDown nudIdentTipoCodigoDesde;
        private Label label1;
        private NumericUpDown nudLongitudTotal;
        private GroupBox gpbPeso;
        private Label label10;
        private NumericUpDown nudDecimalPeso;
        private Label label11;
        private NumericUpDown nudCodigoPeso;
        private GroupBox gpbImporte;
        private Label label9;
        private NumericUpDown nudDecimalImporte;
        private Label label8;
        private NumericUpDown nudCodigoImporte;
        private Label label13;
        private Base.Controles.SidkenuToggleButton chkConvierteUnidadPeso;
        private NumericUpDown nudEquivalencia;
        private Label label14;
    }
}