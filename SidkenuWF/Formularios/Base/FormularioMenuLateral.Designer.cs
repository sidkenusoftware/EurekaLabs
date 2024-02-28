namespace SidkenuWF.Formularios.Base
{
    partial class FormularioMenuLateral
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
            pnlMenuLateral = new Panel();
            btnSalir = new FontAwesome.Sharp.IconButton();
            pnlTitulo = new Panel();
            lblTitulo = new Label();
            pnlMenuLateral.SuspendLayout();
            pnlTitulo.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMenuLateral
            // 
            pnlMenuLateral.BackColor = Color.FromArgb(235, 235, 235);
            pnlMenuLateral.Controls.Add(btnSalir);
            pnlMenuLateral.Dock = DockStyle.Left;
            pnlMenuLateral.Location = new Point(0, 43);
            pnlMenuLateral.Name = "pnlMenuLateral";
            pnlMenuLateral.Size = new Size(124, 407);
            pnlMenuLateral.TabIndex = 1;
            // 
            // btnSalir
            // 
            btnSalir.Dock = DockStyle.Bottom;
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.ForeColor = Color.DimGray;
            btnSalir.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            btnSalir.IconColor = Color.DimGray;
            btnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSalir.IconSize = 30;
            btnSalir.Location = new Point(0, 370);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(124, 37);
            btnSalir.TabIndex = 1;
            btnSalir.Text = "Volver";
            btnSalir.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += BtnSalir_Click;
            // 
            // pnlTitulo
            // 
            pnlTitulo.BackColor = Color.FromArgb(64, 64, 64);
            pnlTitulo.Controls.Add(lblTitulo);
            pnlTitulo.Dock = DockStyle.Top;
            pnlTitulo.Location = new Point(0, 0);
            pnlTitulo.Name = "pnlTitulo";
            pnlTitulo.Size = new Size(800, 43);
            pnlTitulo.TabIndex = 2;
            // 
            // lblTitulo
            // 
            lblTitulo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblTitulo.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.ForeColor = Color.WhiteSmoke;
            lblTitulo.Location = new Point(8, 7);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(780, 28);
            lblTitulo.TabIndex = 3;
            lblTitulo.Text = "Titulo";
            lblTitulo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // FormularioMenuLateral
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlMenuLateral);
            Controls.Add(pnlTitulo);
            Name = "FormularioMenuLateral";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormularioMenuLateral";
            Load += FormularioMenuLateral_Load;
            pnlMenuLateral.ResumeLayout(false);
            pnlTitulo.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private FontAwesome.Sharp.IconButton btnSalir;
        public Panel pnlMenuLateral;
        public Panel pnlTitulo;
        private Label lblTitulo;
    }
}