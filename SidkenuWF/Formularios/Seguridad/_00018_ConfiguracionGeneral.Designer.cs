namespace SidkenuWF.Formularios.Seguridad
{
    partial class _00018_ConfiguracionGeneral
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
            pnlTitulo = new Panel();
            pnlLinea = new Panel();
            imgLogo = new FontAwesome.Sharp.IconPictureBox();
            lblTitulo = new Label();
            btnSalir = new FontAwesome.Sharp.IconButton();
            tabControlConfiguracion = new TabControl();
            tabPageParametricas = new TabPage();
            flpContenedorParametricas = new FlowLayoutPanel();
            pnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgLogo).BeginInit();
            tabControlConfiguracion.SuspendLayout();
            tabPageParametricas.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTitulo
            // 
            pnlTitulo.BackColor = Color.FromArgb(48, 66, 80);
            pnlTitulo.Controls.Add(pnlLinea);
            pnlTitulo.Controls.Add(imgLogo);
            pnlTitulo.Controls.Add(lblTitulo);
            pnlTitulo.Controls.Add(btnSalir);
            pnlTitulo.Dock = DockStyle.Top;
            pnlTitulo.Location = new Point(0, 0);
            pnlTitulo.Name = "pnlTitulo";
            pnlTitulo.Size = new Size(800, 57);
            pnlTitulo.TabIndex = 1;
            // 
            // pnlLinea
            // 
            pnlLinea.BackColor = Color.FromArgb(192, 64, 0);
            pnlLinea.Dock = DockStyle.Bottom;
            pnlLinea.Location = new Point(0, 56);
            pnlLinea.Name = "pnlLinea";
            pnlLinea.Size = new Size(800, 1);
            pnlLinea.TabIndex = 5;
            // 
            // imgLogo
            // 
            imgLogo.BackColor = Color.FromArgb(48, 66, 80);
            imgLogo.ForeColor = Color.WhiteSmoke;
            imgLogo.IconChar = FontAwesome.Sharp.IconChar.None;
            imgLogo.IconColor = Color.WhiteSmoke;
            imgLogo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            imgLogo.IconSize = 35;
            imgLogo.Location = new Point(15, 12);
            imgLogo.Name = "imgLogo";
            imgLogo.Size = new Size(35, 35);
            imgLogo.SizeMode = PictureBoxSizeMode.CenterImage;
            imgLogo.TabIndex = 4;
            imgLogo.TabStop = false;
            // 
            // lblTitulo
            // 
            lblTitulo.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblTitulo.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.ForeColor = Color.WhiteSmoke;
            lblTitulo.Location = new Point(56, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(686, 41);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Titulo";
            lblTitulo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnSalir
            // 
            btnSalir.Anchor = AnchorStyles.Right;
            btnSalir.BackColor = Color.FromArgb(54, 74, 90);
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.ForeColor = Color.WhiteSmoke;
            btnSalir.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            btnSalir.IconColor = Color.WhiteSmoke;
            btnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSalir.IconSize = 25;
            btnSalir.Location = new Point(748, 5);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(49, 49);
            btnSalir.TabIndex = 0;
            btnSalir.Text = "Salir";
            btnSalir.TextImageRelation = TextImageRelation.ImageAboveText;
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += BtnSalir_Click;
            // 
            // tabControlConfiguracion
            // 
            tabControlConfiguracion.Controls.Add(tabPageParametricas);
            tabControlConfiguracion.Dock = DockStyle.Fill;
            tabControlConfiguracion.Location = new Point(0, 57);
            tabControlConfiguracion.Name = "tabControlConfiguracion";
            tabControlConfiguracion.Padding = new Point(12, 12);
            tabControlConfiguracion.SelectedIndex = 0;
            tabControlConfiguracion.Size = new Size(800, 486);
            tabControlConfiguracion.TabIndex = 2;
            // 
            // tabPageParametricas
            // 
            tabPageParametricas.Controls.Add(flpContenedorParametricas);
            tabPageParametricas.Location = new Point(4, 42);
            tabPageParametricas.Name = "tabPageParametricas";
            tabPageParametricas.Padding = new Padding(3);
            tabPageParametricas.Size = new Size(792, 440);
            tabPageParametricas.TabIndex = 0;
            tabPageParametricas.Text = "Paramétricas";
            tabPageParametricas.UseVisualStyleBackColor = true;
            // 
            // flpContenedorParametricas
            // 
            flpContenedorParametricas.BackColor = Color.WhiteSmoke;
            flpContenedorParametricas.Dock = DockStyle.Fill;
            flpContenedorParametricas.Location = new Point(3, 3);
            flpContenedorParametricas.Name = "flpContenedorParametricas";
            flpContenedorParametricas.Size = new Size(786, 434);
            flpContenedorParametricas.TabIndex = 0;
            // 
            // _00018_ConfiguracionGeneral
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 543);
            Controls.Add(tabControlConfiguracion);
            Controls.Add(pnlTitulo);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "_00018_ConfiguracionGeneral";
            StartPosition = FormStartPosition.CenterParent;
            Load += _99900_ConfiguracionGeneral_Load;
            pnlTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)imgLogo).EndInit();
            tabControlConfiguracion.ResumeLayout(false);
            tabPageParametricas.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTitulo;
        private Panel pnlLinea;
        private FontAwesome.Sharp.IconPictureBox imgLogo;
        private Label lblTitulo;
        private FontAwesome.Sharp.IconButton btnSalir;
        private TabControl tabControlConfiguracion;
        private TabPage tabPageParametricas;
        private FlowLayoutPanel flpContenedorParametricas;
    }
}