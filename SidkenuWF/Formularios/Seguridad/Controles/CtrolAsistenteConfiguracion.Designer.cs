namespace SidkenuWF.Formularios.Base.Controles
{
    partial class CtrolAsistenteConfiguracion
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            label2 = new Label();
            pnlLinea = new Panel();
            tabControl1 = new TabControl();
            tbpSeguridad = new TabPage();
            groupBox1 = new GroupBox();
            rdbLoginAvatar = new RadioButton();
            rdbLoginNormal = new RadioButton();
            imgLoginAvatar = new PictureBox();
            imgLoginNormal = new PictureBox();
            panel1 = new Panel();
            panel2 = new Panel();
            tabControl1.SuspendLayout();
            tbpSeguridad.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgLoginAvatar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgLoginNormal).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(27, 11);
            label2.Name = "label2";
            label2.Size = new Size(232, 32);
            label2.TabIndex = 5;
            label2.Text = "Configuración inicial";
            // 
            // pnlLinea
            // 
            pnlLinea.BackColor = Color.Silver;
            pnlLinea.Location = new Point(24, 51);
            pnlLinea.Name = "pnlLinea";
            pnlLinea.Size = new Size(737, 1);
            pnlLinea.TabIndex = 4;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tbpSeguridad);
            tabControl1.Location = new Point(24, 58);
            tabControl1.Name = "tabControl1";
            tabControl1.Padding = new Point(10, 7);
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(737, 280);
            tabControl1.TabIndex = 6;
            // 
            // tbpSeguridad
            // 
            tbpSeguridad.Controls.Add(groupBox1);
            tbpSeguridad.Location = new Point(4, 32);
            tbpSeguridad.Name = "tbpSeguridad";
            tbpSeguridad.Padding = new Padding(3);
            tbpSeguridad.Size = new Size(729, 244);
            tbpSeguridad.TabIndex = 0;
            tbpSeguridad.Text = "Seguridad";
            tbpSeguridad.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdbLoginAvatar);
            groupBox1.Controls.Add(rdbLoginNormal);
            groupBox1.Controls.Add(imgLoginAvatar);
            groupBox1.Controls.Add(imgLoginNormal);
            groupBox1.Controls.Add(panel1);
            groupBox1.Controls.Add(panel2);
            groupBox1.Location = new Point(13, 10);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(321, 162);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "[ Tipo de Login ]";
            // 
            // rdbLoginAvatar
            // 
            rdbLoginAvatar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            rdbLoginAvatar.AutoSize = true;
            rdbLoginAvatar.Location = new Point(216, 132);
            rdbLoginAvatar.Name = "rdbLoginAvatar";
            rdbLoginAvatar.Size = new Size(59, 19);
            rdbLoginAvatar.TabIndex = 3;
            rdbLoginAvatar.Text = "Avatar";
            rdbLoginAvatar.UseVisualStyleBackColor = true;
            // 
            // rdbLoginNormal
            // 
            rdbLoginNormal.AutoSize = true;
            rdbLoginNormal.CheckAlign = ContentAlignment.MiddleRight;
            rdbLoginNormal.Checked = true;
            rdbLoginNormal.Location = new Point(23, 132);
            rdbLoginNormal.Name = "rdbLoginNormal";
            rdbLoginNormal.Size = new Size(65, 19);
            rdbLoginNormal.TabIndex = 2;
            rdbLoginNormal.TabStop = true;
            rdbLoginNormal.Text = "Normal";
            rdbLoginNormal.UseVisualStyleBackColor = true;
            // 
            // imgLoginAvatar
            // 
            imgLoginAvatar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            imgLoginAvatar.BorderStyle = BorderStyle.FixedSingle;
            imgLoginAvatar.Image = Properties.Resources.LoginConAvatar;
            imgLoginAvatar.Location = new Point(168, 22);
            imgLoginAvatar.Name = "imgLoginAvatar";
            imgLoginAvatar.Size = new Size(144, 100);
            imgLoginAvatar.SizeMode = PictureBoxSizeMode.StretchImage;
            imgLoginAvatar.TabIndex = 1;
            imgLoginAvatar.TabStop = false;
            // 
            // imgLoginNormal
            // 
            imgLoginNormal.BorderStyle = BorderStyle.FixedSingle;
            imgLoginNormal.Image = Properties.Resources.LoginNormal;
            imgLoginNormal.Location = new Point(6, 22);
            imgLoginNormal.Name = "imgLoginNormal";
            imgLoginNormal.Size = new Size(147, 100);
            imgLoginNormal.SizeMode = PictureBoxSizeMode.StretchImage;
            imgLoginNormal.TabIndex = 0;
            imgLoginNormal.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(224, 224, 224);
            panel1.Location = new Point(13, 30);
            panel1.Name = "panel1";
            panel1.Size = new Size(145, 96);
            panel1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(224, 224, 224);
            panel2.Location = new Point(171, 30);
            panel2.Name = "panel2";
            panel2.Size = new Size(145, 96);
            panel2.TabIndex = 5;
            // 
            // CtrolAsistenteConfiguracion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tabControl1);
            Controls.Add(label2);
            Controls.Add(pnlLinea);
            Name = "CtrolAsistenteConfiguracion";
            tabControl1.ResumeLayout(false);
            tbpSeguridad.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imgLoginAvatar).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgLoginNormal).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Panel pnlLinea;
        private TabControl tabControl1;
        private TabPage tbpSeguridad;
        private GroupBox groupBox1;
        private RadioButton rdbLoginAvatar;
        private RadioButton rdbLoginNormal;
        private PictureBox imgLoginAvatar;
        private PictureBox imgLoginNormal;
        private Panel panel1;
        private Panel panel2;
    }
}
