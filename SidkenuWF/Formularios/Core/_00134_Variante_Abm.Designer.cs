namespace SidkenuWF.Formularios.Core
{
    partial class _00134_Variante_Abm
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
            panel1 = new Panel();
            label4 = new Label();
            label3 = new Label();
            chkEmpresa = new Base.Controles.SidkenuToggleButton();
            label2 = new Label();
            txtCodigo = new TextBox();
            label1 = new Label();
            txtDescripcion = new TextBox();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGray;
            panel1.Location = new Point(11, 233);
            panel1.Name = "panel1";
            panel1.Size = new Size(522, 1);
            panel1.TabIndex = 106;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(192, 0, 0);
            label4.Location = new Point(250, 239);
            label4.Name = "label4";
            label4.Size = new Size(280, 56);
            label4.TabIndex = 105;
            label4.Text = "Nota: si activa esta opción los datos que esta \r\ncargando solo podra ser visualizado por la empresa que\r\nlo esta dando de alta y no en las sucursales en caso de \r\ntenerlas.\r\n";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(64, 64, 64);
            label3.Location = new Point(56, 259);
            label3.Name = "label3";
            label3.Size = new Size(186, 16);
            label3.TabIndex = 104;
            label3.Text = "Pertenece solo a una Empresa";
            // 
            // chkEmpresa
            // 
            chkEmpresa.AutoSize = true;
            chkEmpresa.Location = new Point(11, 256);
            chkEmpresa.MinimumSize = new Size(45, 22);
            chkEmpresa.Name = "chkEmpresa";
            chkEmpresa.OffBackColor = Color.Gray;
            chkEmpresa.OffToggleColor = Color.Gainsboro;
            chkEmpresa.OnBackColor = Color.Green;
            chkEmpresa.OnToggleColor = Color.WhiteSmoke;
            chkEmpresa.Size = new Size(45, 22);
            chkEmpresa.TabIndex = 103;
            chkEmpresa.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(64, 64, 64);
            label2.Location = new Point(31, 73);
            label2.Name = "label2";
            label2.Size = new Size(47, 16);
            label2.TabIndex = 102;
            label2.Text = "Codigo";
            // 
            // txtCodigo
            // 
            txtCodigo.BackColor = Color.WhiteSmoke;
            txtCodigo.BorderStyle = BorderStyle.FixedSingle;
            txtCodigo.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtCodigo.ForeColor = Color.FromArgb(64, 64, 64);
            txtCodigo.Location = new Point(28, 94);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(158, 29);
            txtCodigo.TabIndex = 99;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(31, 133);
            label1.Name = "label1";
            label1.Size = new Size(103, 16);
            label1.TabIndex = 101;
            label1.Text = "Nombre Variante";
            // 
            // txtDescripcion
            // 
            txtDescripcion.BackColor = Color.WhiteSmoke;
            txtDescripcion.BorderStyle = BorderStyle.FixedSingle;
            txtDescripcion.Font = new Font("Arial", 24F, FontStyle.Regular, GraphicsUnit.Point);
            txtDescripcion.ForeColor = Color.FromArgb(64, 64, 64);
            txtDescripcion.Location = new Point(28, 154);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(483, 44);
            txtDescripcion.TabIndex = 100;
            // 
            // _00134_Variante_Abm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(543, 340);
            Controls.Add(panel1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(chkEmpresa);
            Controls.Add(label2);
            Controls.Add(txtCodigo);
            Controls.Add(label1);
            Controls.Add(txtDescripcion);
            MaximumSize = new Size(559, 379);
            MinimumSize = new Size(559, 379);
            Name = "_00134_Variante_Abm";
            Text = "Variantes / Variantes";
            Controls.SetChildIndex(txtDescripcion, 0);
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(txtCodigo, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(chkEmpresa, 0);
            Controls.SetChildIndex(label3, 0);
            Controls.SetChildIndex(label4, 0);
            Controls.SetChildIndex(panel1, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label4;
        private Label label3;
        private Base.Controles.SidkenuToggleButton chkEmpresa;
        private Label label2;
        private TextBox txtCodigo;
        private Label label1;
        private TextBox txtDescripcion;
    }
}