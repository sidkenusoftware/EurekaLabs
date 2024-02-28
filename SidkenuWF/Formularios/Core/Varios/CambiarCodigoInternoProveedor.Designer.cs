namespace SidkenuWF.Formularios.Core.Varios
{
    partial class CambiarCodigoInternoProveedor
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
            pnlBotonera = new Panel();
            btnEjecutar = new FontAwesome.Sharp.IconButton();
            pnlTestigo = new Panel();
            lblProveedor = new Label();
            label32 = new Label();
            txtCodigoProveedor = new TextBox();
            pnlBotonera.SuspendLayout();
            pnlTestigo.SuspendLayout();
            SuspendLayout();
            // 
            // pnlBotonera
            // 
            pnlBotonera.BackColor = Color.FromArgb(48, 66, 80);
            pnlBotonera.Controls.Add(btnEjecutar);
            pnlBotonera.Dock = DockStyle.Bottom;
            pnlBotonera.Location = new Point(0, 236);
            pnlBotonera.Name = "pnlBotonera";
            pnlBotonera.Size = new Size(331, 40);
            pnlBotonera.TabIndex = 2;
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
            // pnlTestigo
            // 
            pnlTestigo.BackColor = Color.FromArgb(192, 64, 0);
            pnlTestigo.Controls.Add(lblProveedor);
            pnlTestigo.Dock = DockStyle.Top;
            pnlTestigo.Location = new Point(0, 59);
            pnlTestigo.Name = "pnlTestigo";
            pnlTestigo.Size = new Size(331, 54);
            pnlTestigo.TabIndex = 4;
            // 
            // lblProveedor
            // 
            lblProveedor.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblProveedor.BackColor = Color.Transparent;
            lblProveedor.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblProveedor.ForeColor = Color.White;
            lblProveedor.Location = new Point(9, 9);
            lblProveedor.Name = "lblProveedor";
            lblProveedor.Size = new Size(309, 38);
            lblProveedor.TabIndex = 0;
            lblProveedor.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.Location = new Point(83, 147);
            label32.Name = "label32";
            label32.Size = new Size(46, 15);
            label32.TabIndex = 131;
            label32.Text = "Codigo";
            // 
            // txtCodigoProveedor
            // 
            txtCodigoProveedor.BackColor = Color.WhiteSmoke;
            txtCodigoProveedor.BorderStyle = BorderStyle.FixedSingle;
            txtCodigoProveedor.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtCodigoProveedor.ForeColor = Color.FromArgb(64, 64, 64);
            txtCodigoProveedor.Location = new Point(83, 167);
            txtCodigoProveedor.Name = "txtCodigoProveedor";
            txtCodigoProveedor.Size = new Size(148, 32);
            txtCodigoProveedor.TabIndex = 130;
            // 
            // CambiarCodigoInternoProveedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(331, 276);
            Controls.Add(label32);
            Controls.Add(txtCodigoProveedor);
            Controls.Add(pnlTestigo);
            Controls.Add(pnlBotonera);
            MaximumSize = new Size(347, 315);
            MinimumSize = new Size(347, 315);
            Name = "CambiarCodigoInternoProveedor";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Cambiar Codigo";
            Activated += CambiarCodigoInternoProveedor_Activated;
            Controls.SetChildIndex(pnlBotonera, 0);
            Controls.SetChildIndex(pnlTestigo, 0);
            Controls.SetChildIndex(txtCodigoProveedor, 0);
            Controls.SetChildIndex(label32, 0);
            pnlBotonera.ResumeLayout(false);
            pnlTestigo.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlBotonera;
        private FontAwesome.Sharp.IconButton btnEjecutar;
        private Panel pnlTestigo;
        private Label lblProveedor;
        private Label label32;
        private TextBox txtCodigoProveedor;
    }
}