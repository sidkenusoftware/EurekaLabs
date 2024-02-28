namespace SidkenuWF.Formularios.Base.Controles
{
    partial class SidkenuParametrica
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
            btnIngresar = new FontAwesome.Sharp.IconButton();
            lblTitulo = new Label();
            lblLetra = new Label();
            pnlInferior = new Panel();
            SuspendLayout();
            // 
            // btnIngresar
            // 
            btnIngresar.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            btnIngresar.FlatStyle = FlatStyle.Flat;
            btnIngresar.ForeColor = Color.FromArgb(64, 64, 64);
            btnIngresar.IconChar = FontAwesome.Sharp.IconChar.PersonWalkingArrowRight;
            btnIngresar.IconColor = Color.FromArgb(64, 64, 64);
            btnIngresar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnIngresar.IconSize = 25;
            btnIngresar.ImageAlign = ContentAlignment.MiddleLeft;
            btnIngresar.Location = new Point(196, 58);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(86, 28);
            btnIngresar.TabIndex = 1;
            btnIngresar.Text = "Ingresar";
            btnIngresar.TextAlign = ContentAlignment.MiddleRight;
            btnIngresar.UseVisualStyleBackColor = true;
            // 
            // lblTitulo
            // 
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.ForeColor = Color.FromArgb(48, 66, 80);
            lblTitulo.Location = new Point(85, 11);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(197, 39);
            lblTitulo.TabIndex = 3;
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblLetra
            // 
            lblLetra.BackColor = Color.White;
            lblLetra.Font = new Font("Arial Rounded MT Bold", 48F, FontStyle.Regular, GraphicsUnit.Point);
            lblLetra.ForeColor = Color.WhiteSmoke;
            lblLetra.Location = new Point(13, 11);
            lblLetra.Name = "lblLetra";
            lblLetra.Size = new Size(66, 72);
            lblLetra.TabIndex = 4;
            lblLetra.Text = "C";
            lblLetra.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlInferior
            // 
            pnlInferior.BackColor = Color.FromArgb(192, 64, 0);
            pnlInferior.Dock = DockStyle.Bottom;
            pnlInferior.Location = new Point(0, 94);
            pnlInferior.Name = "pnlInferior";
            pnlInferior.Size = new Size(289, 3);
            pnlInferior.TabIndex = 5;
            // 
            // SidkenuParametrica
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            Controls.Add(pnlInferior);
            Controls.Add(lblLetra);
            Controls.Add(lblTitulo);
            Controls.Add(btnIngresar);
            Name = "SidkenuParametrica";
            Size = new Size(289, 97);
            ResumeLayout(false);
        }

        #endregion

        public FontAwesome.Sharp.IconButton btnIngresar;
        private Label lblTitulo;
        private Label lblLetra;
        public Panel pnlInferior;
    }
}
