namespace SidkenuWF.Formularios.Core.Controles
{
    partial class CtrolOrdenFabricacion
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
            panel1 = new Panel();
            label1 = new Label();
            lblNroRef = new Label();
            lblArtBase = new Label();
            btnInformacion = new FontAwesome.Sharp.IconButton();
            pnlBotonera = new Panel();
            btnFinalizar = new FontAwesome.Sharp.IconButton();
            btnProcesar = new FontAwesome.Sharp.IconButton();
            btnCancelarFabricacion = new FontAwesome.Sharp.IconButton();
            pnlLinea = new Panel();
            pnlBotonera.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(192, 64, 0);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(6, 115);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(11, 13);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 3;
            label1.Text = "Nro Ref:";
            // 
            // lblNroRef
            // 
            lblNroRef.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblNroRef.BackColor = Color.Transparent;
            lblNroRef.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblNroRef.Location = new Point(71, 7);
            lblNroRef.Name = "lblNroRef";
            lblNroRef.Size = new Size(111, 26);
            lblNroRef.TabIndex = 4;
            lblNroRef.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblArtBase
            // 
            lblArtBase.BackColor = Color.Transparent;
            lblArtBase.Dock = DockStyle.Bottom;
            lblArtBase.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblArtBase.Location = new Point(6, 40);
            lblArtBase.Name = "lblArtBase";
            lblArtBase.Size = new Size(214, 35);
            lblArtBase.TabIndex = 5;
            lblArtBase.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnInformacion
            // 
            btnInformacion.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnInformacion.FlatAppearance.BorderSize = 0;
            btnInformacion.FlatStyle = FlatStyle.Flat;
            btnInformacion.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            btnInformacion.IconColor = Color.Red;
            btnInformacion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnInformacion.IconSize = 25;
            btnInformacion.Location = new Point(187, 3);
            btnInformacion.Name = "btnInformacion";
            btnInformacion.Size = new Size(30, 31);
            btnInformacion.TabIndex = 6;
            btnInformacion.UseVisualStyleBackColor = true;
            // 
            // pnlBotonera
            // 
            pnlBotonera.Controls.Add(btnFinalizar);
            pnlBotonera.Controls.Add(btnProcesar);
            pnlBotonera.Controls.Add(btnCancelarFabricacion);
            pnlBotonera.Controls.Add(pnlLinea);
            pnlBotonera.Dock = DockStyle.Bottom;
            pnlBotonera.Location = new Point(6, 75);
            pnlBotonera.Name = "pnlBotonera";
            pnlBotonera.Size = new Size(214, 40);
            pnlBotonera.TabIndex = 10;
            // 
            // btnFinalizar
            // 
            btnFinalizar.BackColor = Color.White;
            btnFinalizar.FlatStyle = FlatStyle.Flat;
            btnFinalizar.IconChar = FontAwesome.Sharp.IconChar.FlagCheckered;
            btnFinalizar.IconColor = Color.Green;
            btnFinalizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnFinalizar.IconSize = 25;
            btnFinalizar.Location = new Point(174, 5);
            btnFinalizar.Name = "btnFinalizar";
            btnFinalizar.Size = new Size(34, 31);
            btnFinalizar.TabIndex = 12;
            btnFinalizar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnFinalizar.UseVisualStyleBackColor = false;
            btnFinalizar.Visible = false;
            // 
            // btnProcesar
            // 
            btnProcesar.BackColor = Color.White;
            btnProcesar.FlatStyle = FlatStyle.Flat;
            btnProcesar.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleRight;
            btnProcesar.IconColor = Color.Green;
            btnProcesar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnProcesar.IconSize = 25;
            btnProcesar.Location = new Point(174, 5);
            btnProcesar.Name = "btnProcesar";
            btnProcesar.Size = new Size(34, 31);
            btnProcesar.TabIndex = 11;
            btnProcesar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnProcesar.UseVisualStyleBackColor = false;
            btnProcesar.Visible = false;
            // 
            // btnCancelarFabricacion
            // 
            btnCancelarFabricacion.BackColor = Color.White;
            btnCancelarFabricacion.FlatStyle = FlatStyle.Flat;
            btnCancelarFabricacion.IconChar = FontAwesome.Sharp.IconChar.Cancel;
            btnCancelarFabricacion.IconColor = Color.Red;
            btnCancelarFabricacion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCancelarFabricacion.IconSize = 25;
            btnCancelarFabricacion.Location = new Point(6, 5);
            btnCancelarFabricacion.Name = "btnCancelarFabricacion";
            btnCancelarFabricacion.Size = new Size(32, 31);
            btnCancelarFabricacion.TabIndex = 10;
            btnCancelarFabricacion.TextAlign = ContentAlignment.MiddleLeft;
            btnCancelarFabricacion.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancelarFabricacion.UseVisualStyleBackColor = false;
            btnCancelarFabricacion.Visible = false;
            // 
            // pnlLinea
            // 
            pnlLinea.BackColor = Color.FromArgb(192, 0, 0);
            pnlLinea.Dock = DockStyle.Top;
            pnlLinea.Location = new Point(0, 0);
            pnlLinea.Name = "pnlLinea";
            pnlLinea.Size = new Size(214, 1);
            pnlLinea.TabIndex = 3;
            // 
            // CtrolOrdenFabricacion
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(lblArtBase);
            Controls.Add(pnlBotonera);
            Controls.Add(btnInformacion);
            Controls.Add(lblNroRef);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "CtrolOrdenFabricacion";
            Size = new Size(220, 115);
            pnlBotonera.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        public FontAwesome.Sharp.IconButton btnInformacion;
        public FontAwesome.Sharp.IconButton btnFinalizar;
        public FontAwesome.Sharp.IconButton btnProcesar;
        public FontAwesome.Sharp.IconButton btnCancelarFabricacion;
        private Panel pnlLinea;
        public Label lblNroRef;
        public Label lblArtBase;
        public Panel pnlBotonera;
    }
}
