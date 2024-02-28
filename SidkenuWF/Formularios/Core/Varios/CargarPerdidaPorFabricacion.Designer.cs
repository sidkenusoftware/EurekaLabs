namespace SidkenuWF.Formularios.Core.Varios
{
    partial class CargarPerdidaPorFabricacion
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
            lblArticulo = new Label();
            pnlBotonera = new Panel();
            btnEjecutar = new FontAwesome.Sharp.IconButton();
            nudPerdida = new NumericUpDown();
            label8 = new Label();
            cmbTipoPerdida = new ComboBox();
            nudCantidadActual = new NumericUpDown();
            label1 = new Label();
            nudCantidadFinal = new NumericUpDown();
            label2 = new Label();
            pnlTestigo.SuspendLayout();
            pnlBotonera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudPerdida).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudCantidadActual).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudCantidadFinal).BeginInit();
            SuspendLayout();
            // 
            // pnlTestigo
            // 
            pnlTestigo.BackColor = Color.FromArgb(192, 64, 0);
            pnlTestigo.Controls.Add(lblArticulo);
            pnlTestigo.Dock = DockStyle.Top;
            pnlTestigo.Location = new Point(0, 59);
            pnlTestigo.Name = "pnlTestigo";
            pnlTestigo.Size = new Size(366, 54);
            pnlTestigo.TabIndex = 133;
            // 
            // lblArticulo
            // 
            lblArticulo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblArticulo.BackColor = Color.Transparent;
            lblArticulo.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblArticulo.ForeColor = Color.White;
            lblArticulo.Location = new Point(7, 2);
            lblArticulo.Name = "lblArticulo";
            lblArticulo.Size = new Size(356, 45);
            lblArticulo.TabIndex = 0;
            lblArticulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlBotonera
            // 
            pnlBotonera.BackColor = Color.FromArgb(48, 66, 80);
            pnlBotonera.Controls.Add(btnEjecutar);
            pnlBotonera.Dock = DockStyle.Bottom;
            pnlBotonera.Location = new Point(0, 322);
            pnlBotonera.Name = "pnlBotonera";
            pnlBotonera.Size = new Size(366, 40);
            pnlBotonera.TabIndex = 132;
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
            // nudPerdida
            // 
            nudPerdida.DecimalPlaces = 2;
            nudPerdida.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            nudPerdida.Location = new Point(20, 203);
            nudPerdida.Maximum = new decimal(new int[] { -559939584, 902409669, 54, 0 });
            nudPerdida.Name = "nudPerdida";
            nudPerdida.Size = new Size(142, 29);
            nudPerdida.TabIndex = 146;
            nudPerdida.ValueChanged += NudPerdida_ValueChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(20, 183);
            label8.Name = "label8";
            label8.Size = new Size(47, 15);
            label8.TabIndex = 147;
            label8.Text = "Perdida";
            // 
            // cmbTipoPerdida
            // 
            cmbTipoPerdida.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoPerdida.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbTipoPerdida.FormattingEnabled = true;
            cmbTipoPerdida.Location = new Point(168, 203);
            cmbTipoPerdida.Name = "cmbTipoPerdida";
            cmbTipoPerdida.Size = new Size(180, 29);
            cmbTipoPerdida.TabIndex = 162;
            cmbTipoPerdida.SelectionChangeCommitted += NudPerdida_ValueChanged;
            // 
            // nudCantidadActual
            // 
            nudCantidadActual.DecimalPlaces = 2;
            nudCantidadActual.Enabled = false;
            nudCantidadActual.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            nudCantidadActual.Location = new Point(20, 142);
            nudCantidadActual.Maximum = new decimal(new int[] { -559939584, 902409669, 54, 0 });
            nudCantidadActual.Minimum = new decimal(new int[] { 1, 0, 0, 131072 });
            nudCantidadActual.Name = "nudCantidadActual";
            nudCantidadActual.Size = new Size(142, 29);
            nudCantidadActual.TabIndex = 163;
            nudCantidadActual.Value = new decimal(new int[] { 1, 0, 0, 131072 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 122);
            label1.Name = "label1";
            label1.Size = new Size(92, 15);
            label1.TabIndex = 164;
            label1.Text = "Cantidad Actual";
            // 
            // nudCantidadFinal
            // 
            nudCantidadFinal.DecimalPlaces = 2;
            nudCantidadFinal.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            nudCantidadFinal.Location = new Point(20, 265);
            nudCantidadFinal.Maximum = new decimal(new int[] { -559939584, 902409669, 54, 0 });
            nudCantidadFinal.Minimum = new decimal(new int[] { 1, 0, 0, 131072 });
            nudCantidadFinal.Name = "nudCantidadFinal";
            nudCantidadFinal.Size = new Size(142, 29);
            nudCantidadFinal.TabIndex = 165;
            nudCantidadFinal.Value = new decimal(new int[] { 1, 0, 0, 131072 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 245);
            label2.Name = "label2";
            label2.Size = new Size(83, 15);
            label2.TabIndex = 166;
            label2.Text = "Cantidad Final";
            // 
            // CargarPerdidaPorFabricacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(366, 362);
            Controls.Add(nudCantidadFinal);
            Controls.Add(label2);
            Controls.Add(nudCantidadActual);
            Controls.Add(label1);
            Controls.Add(cmbTipoPerdida);
            Controls.Add(nudPerdida);
            Controls.Add(label8);
            Controls.Add(pnlTestigo);
            Controls.Add(pnlBotonera);
            MaximumSize = new Size(382, 401);
            MinimumSize = new Size(382, 401);
            Name = "CargarPerdidaPorFabricacion";
            Text = "Perdida (Scrap)";
            Controls.SetChildIndex(pnlBotonera, 0);
            Controls.SetChildIndex(pnlTestigo, 0);
            Controls.SetChildIndex(label8, 0);
            Controls.SetChildIndex(nudPerdida, 0);
            Controls.SetChildIndex(cmbTipoPerdida, 0);
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(nudCantidadActual, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(nudCantidadFinal, 0);
            pnlTestigo.ResumeLayout(false);
            pnlBotonera.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nudPerdida).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudCantidadActual).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudCantidadFinal).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel pnlTestigo;
        private Label lblArticulo;
        private Panel pnlBotonera;
        private FontAwesome.Sharp.IconButton btnEjecutar;
        private NumericUpDown nudPerdida;
        private Label label8;
        private ComboBox cmbTipoPerdida;
        private NumericUpDown nudCantidadActual;
        private Label label1;
        private NumericUpDown nudCantidadFinal;
        private Label label2;
    }
}