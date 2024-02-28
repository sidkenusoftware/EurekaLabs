namespace SidkenuWF.Formularios.Seguridad
{
    partial class _00025_PuestoTrabajo_Abm
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
            txtNumeroSerie = new TextBox();
            btnNumeroSerie = new FontAwesome.Sharp.IconButton();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(31, 90);
            label1.Name = "label1";
            label1.Size = new Size(182, 16);
            label1.TabIndex = 19;
            label1.Text = "Nombre del Puesto de Trabajo";
            // 
            // txtDescripcion
            // 
            txtDescripcion.BackColor = Color.WhiteSmoke;
            txtDescripcion.BorderStyle = BorderStyle.FixedSingle;
            txtDescripcion.Font = new Font("Arial", 24F, FontStyle.Regular, GraphicsUnit.Point);
            txtDescripcion.ForeColor = Color.FromArgb(64, 64, 64);
            txtDescripcion.Location = new Point(28, 111);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.PlaceholderText = "Ej: Puesto 1";
            txtDescripcion.Size = new Size(408, 44);
            txtDescripcion.TabIndex = 18;
            // 
            // txtNumeroSerie
            // 
            txtNumeroSerie.BackColor = Color.WhiteSmoke;
            txtNumeroSerie.BorderStyle = BorderStyle.FixedSingle;
            txtNumeroSerie.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtNumeroSerie.ForeColor = Color.FromArgb(64, 64, 64);
            txtNumeroSerie.Location = new Point(31, 197);
            txtNumeroSerie.Name = "txtNumeroSerie";
            txtNumeroSerie.PasswordChar = '*';
            txtNumeroSerie.ReadOnly = true;
            txtNumeroSerie.Size = new Size(290, 29);
            txtNumeroSerie.TabIndex = 20;
            // 
            // btnNumeroSerie
            // 
            btnNumeroSerie.BackColor = Color.White;
            btnNumeroSerie.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            btnNumeroSerie.FlatStyle = FlatStyle.Flat;
            btnNumeroSerie.ForeColor = Color.FromArgb(64, 64, 64);
            btnNumeroSerie.IconChar = FontAwesome.Sharp.IconChar.Computer;
            btnNumeroSerie.IconColor = Color.FromArgb(64, 64, 64);
            btnNumeroSerie.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnNumeroSerie.IconSize = 30;
            btnNumeroSerie.Location = new Point(327, 192);
            btnNumeroSerie.Name = "btnNumeroSerie";
            btnNumeroSerie.Size = new Size(109, 40);
            btnNumeroSerie.TabIndex = 24;
            btnNumeroSerie.Text = "Obtener Serial";
            btnNumeroSerie.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNumeroSerie.UseVisualStyleBackColor = false;
            btnNumeroSerie.Click += BtnBorrarCliente_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(64, 64, 64);
            label2.Location = new Point(31, 175);
            label2.Name = "label2";
            label2.Size = new Size(234, 16);
            label2.TabIndex = 25;
            label2.Text = "Numero de Serie del Puesto de Trabajo";
            // 
            // _00025_PuestoTrabajo_Abm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(466, 298);
            Controls.Add(label2);
            Controls.Add(btnNumeroSerie);
            Controls.Add(txtNumeroSerie);
            Controls.Add(label1);
            Controls.Add(txtDescripcion);
            MaximumSize = new Size(482, 337);
            MinimumSize = new Size(482, 337);
            Name = "_00025_PuestoTrabajo_Abm";
            Text = "Puesto de Trabajo";
            Controls.SetChildIndex(txtDescripcion, 0);
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(txtNumeroSerie, 0);
            Controls.SetChildIndex(btnNumeroSerie, 0);
            Controls.SetChildIndex(label2, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtDescripcion;
        private TextBox txtNumeroSerie;
        private FontAwesome.Sharp.IconButton btnNumeroSerie;
        private Label label2;
    }
}