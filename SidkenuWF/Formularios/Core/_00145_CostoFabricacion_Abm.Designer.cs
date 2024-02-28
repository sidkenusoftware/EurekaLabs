namespace SidkenuWF.Formularios.Core
{
    partial class _00145_CostoFabricacion_Abm
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
            nudMonto = new NumericUpDown();
            label1 = new Label();
            txtDescripcion = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)nudMonto).BeginInit();
            SuspendLayout();
            // 
            // nudMonto
            // 
            nudMonto.DecimalPlaces = 2;
            nudMonto.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            nudMonto.Location = new Point(29, 186);
            nudMonto.Maximum = new decimal(new int[] { -159383552, 46653770, 5421, 0 });
            nudMonto.Name = "nudMonto";
            nudMonto.Size = new Size(131, 27);
            nudMonto.TabIndex = 193;
            nudMonto.TextAlign = HorizontalAlignment.Right;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(32, 88);
            label1.Name = "label1";
            label1.Size = new Size(130, 16);
            label1.TabIndex = 190;
            label1.Text = "Costo de Fabricación";
            // 
            // txtDescripcion
            // 
            txtDescripcion.BackColor = Color.WhiteSmoke;
            txtDescripcion.BorderStyle = BorderStyle.FixedSingle;
            txtDescripcion.Font = new Font("Arial", 24F, FontStyle.Regular, GraphicsUnit.Point);
            txtDescripcion.ForeColor = Color.FromArgb(64, 64, 64);
            txtDescripcion.Location = new Point(29, 109);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(427, 44);
            txtDescripcion.TabIndex = 189;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(64, 64, 64);
            label2.Location = new Point(29, 167);
            label2.Name = "label2";
            label2.Size = new Size(43, 16);
            label2.TabIndex = 194;
            label2.Text = "Monto";
            // 
            // _00145_CostoFabricacion_Abm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(487, 292);
            Controls.Add(label2);
            Controls.Add(nudMonto);
            Controls.Add(label1);
            Controls.Add(txtDescripcion);
            MaximumSize = new Size(503, 331);
            MinimumSize = new Size(503, 331);
            Name = "_00145_CostoFabricacion_Abm";
            Text = "Costo de Fabricacion";
            Controls.SetChildIndex(txtDescripcion, 0);
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(nudMonto, 0);
            Controls.SetChildIndex(label2, 0);
            ((System.ComponentModel.ISupportInitialize)nudMonto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown nudMonto;
        private Label label1;
        private TextBox txtDescripcion;
        private Label label2;
    }
}