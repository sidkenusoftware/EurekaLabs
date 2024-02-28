namespace SidkenuWF.Formularios.Core
{
    partial class _00118_NuevoGasto
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
            cmbTipoGasto = new ComboBox();
            label2 = new Label();
            btnNuevoTipoGasto = new Button();
            nudMonto = new NumericUpDown();
            txtDescripcion = new RichTextBox();
            label3 = new Label();
            label4 = new Label();
            dtpFecha = new DateTimePicker();
            label5 = new Label();
            pnlBotonera = new Panel();
            btnEjecutar = new FontAwesome.Sharp.IconButton();
            pnlTestigo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudMonto).BeginInit();
            pnlBotonera.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTestigo
            // 
            pnlTestigo.BackColor = Color.FromArgb(192, 64, 0);
            pnlTestigo.Controls.Add(lblCajaSeleccionada);
            pnlTestigo.Dock = DockStyle.Top;
            pnlTestigo.Location = new Point(0, 59);
            pnlTestigo.Name = "pnlTestigo";
            pnlTestigo.Size = new Size(493, 52);
            pnlTestigo.TabIndex = 2;
            // 
            // lblCajaSeleccionada
            // 
            lblCajaSeleccionada.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblCajaSeleccionada.BackColor = Color.Transparent;
            lblCajaSeleccionada.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblCajaSeleccionada.ForeColor = Color.White;
            lblCajaSeleccionada.Location = new Point(8, 6);
            lblCajaSeleccionada.Name = "lblCajaSeleccionada";
            lblCajaSeleccionada.Size = new Size(477, 40);
            lblCajaSeleccionada.TabIndex = 0;
            lblCajaSeleccionada.Text = "Caja Seleccionada => ";
            lblCajaSeleccionada.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cmbTipoGasto
            // 
            cmbTipoGasto.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoGasto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbTipoGasto.FormattingEnabled = true;
            cmbTipoGasto.Location = new Point(113, 123);
            cmbTipoGasto.Name = "cmbTipoGasto";
            cmbTipoGasto.Size = new Size(311, 29);
            cmbTipoGasto.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(16, 129);
            label2.Name = "label2";
            label2.Size = new Size(91, 17);
            label2.TabIndex = 4;
            label2.Text = "Tipo de Gasto";
            // 
            // btnNuevoTipoGasto
            // 
            btnNuevoTipoGasto.Location = new Point(430, 123);
            btnNuevoTipoGasto.Name = "btnNuevoTipoGasto";
            btnNuevoTipoGasto.Size = new Size(37, 29);
            btnNuevoTipoGasto.TabIndex = 5;
            btnNuevoTipoGasto.Text = "...";
            btnNuevoTipoGasto.UseVisualStyleBackColor = true;
            btnNuevoTipoGasto.Click += BtnNuevoTipoGasto_Click;
            // 
            // nudMonto
            // 
            nudMonto.DecimalPlaces = 2;
            nudMonto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            nudMonto.Location = new Point(113, 158);
            nudMonto.Maximum = new decimal(new int[] { 1316134912, 2328, 0, 0 });
            nudMonto.Name = "nudMonto";
            nudMonto.Size = new Size(136, 29);
            nudMonto.TabIndex = 6;
            // 
            // txtDescripcion
            // 
            txtDescripcion.BorderStyle = BorderStyle.FixedSingle;
            txtDescripcion.Location = new Point(113, 193);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.ScrollBars = RichTextBoxScrollBars.Vertical;
            txtDescripcion.Size = new Size(311, 126);
            txtDescripcion.TabIndex = 7;
            txtDescripcion.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(60, 163);
            label3.Name = "label3";
            label3.Size = new Size(47, 17);
            label3.TabIndex = 8;
            label3.Text = "Monto";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(31, 193);
            label4.Name = "label4";
            label4.Size = new Size(76, 17);
            label4.TabIndex = 9;
            label4.Text = "Descripcion";
            // 
            // dtpFecha
            // 
            dtpFecha.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(302, 158);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(122, 29);
            dtpFecha.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(255, 163);
            label5.Name = "label5";
            label5.Size = new Size(41, 17);
            label5.TabIndex = 11;
            label5.Text = "Fecha";
            // 
            // pnlBotonera
            // 
            pnlBotonera.BackColor = Color.FromArgb(48, 66, 80);
            pnlBotonera.Controls.Add(btnEjecutar);
            pnlBotonera.Dock = DockStyle.Bottom;
            pnlBotonera.Location = new Point(0, 335);
            pnlBotonera.Name = "pnlBotonera";
            pnlBotonera.Size = new Size(493, 40);
            pnlBotonera.TabIndex = 12;
            // 
            // btnEjecutar
            // 
            btnEjecutar.BackColor = Color.FromArgb(54, 74, 90);
            btnEjecutar.FlatAppearance.BorderColor = Color.WhiteSmoke;
            btnEjecutar.FlatAppearance.BorderSize = 0;
            btnEjecutar.FlatStyle = FlatStyle.Flat;
            btnEjecutar.ForeColor = Color.WhiteSmoke;
            btnEjecutar.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            btnEjecutar.IconColor = Color.WhiteSmoke;
            btnEjecutar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEjecutar.IconSize = 22;
            btnEjecutar.Location = new Point(13, 6);
            btnEjecutar.Name = "btnEjecutar";
            btnEjecutar.Size = new Size(81, 28);
            btnEjecutar.TabIndex = 2;
            btnEjecutar.Text = "Guardar";
            btnEjecutar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEjecutar.UseVisualStyleBackColor = false;
            btnEjecutar.Click += BtnEjecutar_Click;
            // 
            // _00118_NuevoGasto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(493, 375);
            Controls.Add(pnlBotonera);
            Controls.Add(label5);
            Controls.Add(dtpFecha);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtDescripcion);
            Controls.Add(nudMonto);
            Controls.Add(btnNuevoTipoGasto);
            Controls.Add(label2);
            Controls.Add(cmbTipoGasto);
            Controls.Add(pnlTestigo);
            MaximumSize = new Size(509, 414);
            MinimumSize = new Size(509, 414);
            Name = "_00118_NuevoGasto";
            Text = "Gastos";
            Load += EjecutarComandoFormLoad;
            Controls.SetChildIndex(pnlTestigo, 0);
            Controls.SetChildIndex(cmbTipoGasto, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(btnNuevoTipoGasto, 0);
            Controls.SetChildIndex(nudMonto, 0);
            Controls.SetChildIndex(txtDescripcion, 0);
            Controls.SetChildIndex(label3, 0);
            Controls.SetChildIndex(label4, 0);
            Controls.SetChildIndex(dtpFecha, 0);
            Controls.SetChildIndex(label5, 0);
            Controls.SetChildIndex(pnlBotonera, 0);
            pnlTestigo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nudMonto).EndInit();
            pnlBotonera.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlTestigo;
        private Label lblCajaSeleccionada;
        private ComboBox cmbTipoGasto;
        private Label label2;
        private Button btnNuevoTipoGasto;
        private NumericUpDown nudMonto;
        private RichTextBox txtDescripcion;
        private Label label3;
        private Label label4;
        private DateTimePicker dtpFecha;
        private Label label5;
        private Panel pnlBotonera;
        private FontAwesome.Sharp.IconButton btnEjecutar;
    }
}