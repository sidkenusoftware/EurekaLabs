namespace SidkenuWF.Formularios.Seguridad
{
    partial class _00010_Localidad_Abm
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
            label1 = new Label();
            txtDescripcion = new TextBox();
            cmbProvincia = new ComboBox();
            btnNuevaProvincia = new FontAwesome.Sharp.IconButton();
            label12 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(32, 140);
            label1.Name = "label1";
            label1.Size = new Size(143, 16);
            label1.TabIndex = 17;
            label1.Text = "Nombre de la Localidad";
            // 
            // txtDescripcion
            // 
            txtDescripcion.BackColor = Color.WhiteSmoke;
            txtDescripcion.BorderStyle = BorderStyle.FixedSingle;
            txtDescripcion.Font = new Font("Arial", 24F, FontStyle.Regular, GraphicsUnit.Point);
            txtDescripcion.ForeColor = Color.FromArgb(64, 64, 64);
            txtDescripcion.Location = new Point(29, 161);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.PlaceholderText = "Ej: Capital";
            txtDescripcion.Size = new Size(408, 44);
            txtDescripcion.TabIndex = 16;
            // 
            // cmbProvincia
            // 
            cmbProvincia.BackColor = Color.WhiteSmoke;
            cmbProvincia.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProvincia.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            cmbProvincia.ForeColor = Color.FromArgb(64, 64, 64);
            cmbProvincia.FormattingEnabled = true;
            cmbProvincia.ItemHeight = 17;
            cmbProvincia.Location = new Point(29, 100);
            cmbProvincia.MaxDropDownItems = 12;
            cmbProvincia.Name = "cmbProvincia";
            cmbProvincia.Size = new Size(367, 25);
            cmbProvincia.TabIndex = 86;
            // 
            // btnNuevaProvincia
            // 
            btnNuevaProvincia.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            btnNuevaProvincia.FlatStyle = FlatStyle.Flat;
            btnNuevaProvincia.ForeColor = Color.FromArgb(64, 64, 64);
            btnNuevaProvincia.IconChar = FontAwesome.Sharp.IconChar.None;
            btnNuevaProvincia.IconColor = Color.FromArgb(64, 64, 64);
            btnNuevaProvincia.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnNuevaProvincia.Location = new Point(402, 101);
            btnNuevaProvincia.Name = "btnNuevaProvincia";
            btnNuevaProvincia.Size = new Size(35, 24);
            btnNuevaProvincia.TabIndex = 85;
            btnNuevaProvincia.Text = "...";
            btnNuevaProvincia.UseVisualStyleBackColor = true;
            btnNuevaProvincia.Click += BtnNuevaProvincia_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ForeColor = Color.FromArgb(64, 64, 64);
            label12.Location = new Point(29, 81);
            label12.Name = "label12";
            label12.Size = new Size(59, 16);
            label12.TabIndex = 84;
            label12.Text = "Provincia";
            // 
            // _00010_Localidad_Abm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(473, 281);
            Controls.Add(cmbProvincia);
            Controls.Add(btnNuevaProvincia);
            Controls.Add(label12);
            Controls.Add(label1);
            Controls.Add(txtDescripcion);
            MaximumSize = new Size(489, 320);
            MinimumSize = new Size(489, 320);
            Name = "_00010_Localidad_Abm";
            Controls.SetChildIndex(txtDescripcion, 0);
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(label12, 0);
            Controls.SetChildIndex(btnNuevaProvincia, 0);
            Controls.SetChildIndex(cmbProvincia, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtDescripcion;
        private ComboBox cmbProvincia;
        private FontAwesome.Sharp.IconButton btnNuevaProvincia;
        private Label label12;
    }
}