namespace SidkenuWF.Formularios.Seguridad
{
    partial class AsistenteInicioSistema
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
            btnSalir = new FontAwesome.Sharp.IconButton();
            lblTitulo = new Label();
            pnlLinea = new Panel();
            pnlPasos = new Panel();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pnlPaso2 = new Panel();
            pnlPaso1 = new Panel();
            imgPaso2 = new Base.Controles.SidkenuCircularPictureBox();
            imgPaso1 = new Base.Controles.SidkenuCircularPictureBox();
            imgPaso0 = new Base.Controles.SidkenuCircularPictureBox();
            pnlInferior = new Panel();
            btnGrabar = new Button();
            btnAnterior = new Button();
            btnSiguiente = new Button();
            pnlContenedor = new Panel();
            pnlTitulo.SuspendLayout();
            pnlPasos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgPaso2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgPaso1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgPaso0).BeginInit();
            pnlInferior.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTitulo
            // 
            pnlTitulo.BackColor = Color.FromArgb(48, 66, 80);
            pnlTitulo.Controls.Add(btnSalir);
            pnlTitulo.Controls.Add(lblTitulo);
            pnlTitulo.Controls.Add(pnlLinea);
            pnlTitulo.Dock = DockStyle.Top;
            pnlTitulo.Location = new Point(0, 0);
            pnlTitulo.Name = "pnlTitulo";
            pnlTitulo.Size = new Size(784, 54);
            pnlTitulo.TabIndex = 0;
            // 
            // btnSalir
            // 
            btnSalir.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            btnSalir.BackColor = Color.FromArgb(54, 74, 90);
            btnSalir.FlatAppearance.BorderColor = Color.WhiteSmoke;
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.ForeColor = Color.WhiteSmoke;
            btnSalir.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            btnSalir.IconColor = Color.WhiteSmoke;
            btnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSalir.IconSize = 20;
            btnSalir.Location = new Point(728, 5);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(49, 42);
            btnSalir.TabIndex = 3;
            btnSalir.Text = "Salir";
            btnSalir.TextImageRelation = TextImageRelation.ImageAboveText;
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += BtnSalir_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.ForeColor = Color.WhiteSmoke;
            lblTitulo.Location = new Point(8, 7);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(705, 40);
            lblTitulo.TabIndex = 2;
            lblTitulo.Text = "Asistente para el Inicio del Sistema";
            lblTitulo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlLinea
            // 
            pnlLinea.BackColor = Color.White;
            pnlLinea.Dock = DockStyle.Bottom;
            pnlLinea.Location = new Point(0, 53);
            pnlLinea.Name = "pnlLinea";
            pnlLinea.Size = new Size(784, 1);
            pnlLinea.TabIndex = 0;
            // 
            // pnlPasos
            // 
            pnlPasos.BackColor = Color.FromArgb(192, 64, 0);
            pnlPasos.Controls.Add(label3);
            pnlPasos.Controls.Add(label2);
            pnlPasos.Controls.Add(label1);
            pnlPasos.Controls.Add(pnlPaso2);
            pnlPasos.Controls.Add(pnlPaso1);
            pnlPasos.Controls.Add(imgPaso2);
            pnlPasos.Controls.Add(imgPaso1);
            pnlPasos.Controls.Add(imgPaso0);
            pnlPasos.Dock = DockStyle.Top;
            pnlPasos.Location = new Point(0, 54);
            pnlPasos.Name = "pnlPasos";
            pnlPasos.Size = new Size(784, 92);
            pnlPasos.TabIndex = 1;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Arial Black", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(713, 18);
            label3.Name = "label3";
            label3.Size = new Size(47, 52);
            label3.TabIndex = 7;
            label3.Text = "3";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial Black", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(370, 18);
            label2.Name = "label2";
            label2.Size = new Size(47, 52);
            label2.TabIndex = 6;
            label2.Text = "2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial Black", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(27, 18);
            label1.Name = "label1";
            label1.Size = new Size(47, 52);
            label1.TabIndex = 5;
            label1.Text = "1";
            // 
            // pnlPaso2
            // 
            pnlPaso2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlPaso2.BackColor = Color.WhiteSmoke;
            pnlPaso2.Location = new Point(438, 42);
            pnlPaso2.Name = "pnlPaso2";
            pnlPaso2.Size = new Size(255, 5);
            pnlPaso2.TabIndex = 4;
            // 
            // pnlPaso1
            // 
            pnlPaso1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            pnlPaso1.BackColor = Color.WhiteSmoke;
            pnlPaso1.Location = new Point(93, 42);
            pnlPaso1.Name = "pnlPaso1";
            pnlPaso1.Size = new Size(257, 5);
            pnlPaso1.TabIndex = 3;
            // 
            // imgPaso2
            // 
            imgPaso2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            imgPaso2.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            imgPaso2.BorderColor = Color.White;
            imgPaso2.BorderColor2 = Color.WhiteSmoke;
            imgPaso2.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            imgPaso2.BorderSize = 2;
            imgPaso2.GradientAngle = 50F;
            imgPaso2.Location = new Point(696, 5);
            imgPaso2.Name = "imgPaso2";
            imgPaso2.Size = new Size(79, 79);
            imgPaso2.SizeMode = PictureBoxSizeMode.StretchImage;
            imgPaso2.TabIndex = 2;
            imgPaso2.TabStop = false;
            // 
            // imgPaso1
            // 
            imgPaso1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            imgPaso1.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            imgPaso1.BorderColor = Color.White;
            imgPaso1.BorderColor2 = Color.WhiteSmoke;
            imgPaso1.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            imgPaso1.BorderSize = 2;
            imgPaso1.GradientAngle = 50F;
            imgPaso1.Location = new Point(354, 5);
            imgPaso1.Name = "imgPaso1";
            imgPaso1.Size = new Size(79, 79);
            imgPaso1.SizeMode = PictureBoxSizeMode.StretchImage;
            imgPaso1.TabIndex = 1;
            imgPaso1.TabStop = false;
            // 
            // imgPaso0
            // 
            imgPaso0.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            imgPaso0.BorderColor = Color.Lime;
            imgPaso0.BorderColor2 = Color.Lime;
            imgPaso0.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            imgPaso0.BorderSize = 2;
            imgPaso0.GradientAngle = 50F;
            imgPaso0.Location = new Point(11, 5);
            imgPaso0.Name = "imgPaso0";
            imgPaso0.Size = new Size(79, 79);
            imgPaso0.SizeMode = PictureBoxSizeMode.StretchImage;
            imgPaso0.TabIndex = 0;
            imgPaso0.TabStop = false;
            // 
            // pnlInferior
            // 
            pnlInferior.BackColor = Color.FromArgb(48, 66, 80);
            pnlInferior.Controls.Add(btnGrabar);
            pnlInferior.Controls.Add(btnAnterior);
            pnlInferior.Controls.Add(btnSiguiente);
            pnlInferior.Dock = DockStyle.Bottom;
            pnlInferior.Location = new Point(0, 504);
            pnlInferior.Name = "pnlInferior";
            pnlInferior.Size = new Size(784, 57);
            pnlInferior.TabIndex = 2;
            // 
            // btnGrabar
            // 
            btnGrabar.FlatAppearance.BorderColor = Color.WhiteSmoke;
            btnGrabar.FlatStyle = FlatStyle.Flat;
            btnGrabar.ForeColor = Color.WhiteSmoke;
            btnGrabar.Location = new Point(671, 10);
            btnGrabar.Name = "btnGrabar";
            btnGrabar.Size = new Size(100, 35);
            btnGrabar.TabIndex = 2;
            btnGrabar.Text = "Guardar";
            btnGrabar.UseVisualStyleBackColor = true;
            btnGrabar.Visible = false;
            btnGrabar.Click += BtnGrabar_Click;
            // 
            // btnAnterior
            // 
            btnAnterior.FlatAppearance.BorderColor = Color.WhiteSmoke;
            btnAnterior.FlatStyle = FlatStyle.Flat;
            btnAnterior.ForeColor = Color.WhiteSmoke;
            btnAnterior.Location = new Point(12, 10);
            btnAnterior.Name = "btnAnterior";
            btnAnterior.Size = new Size(100, 35);
            btnAnterior.TabIndex = 1;
            btnAnterior.Text = "Anterior";
            btnAnterior.UseVisualStyleBackColor = true;
            btnAnterior.Click += BtnAnterior_Click;
            // 
            // btnSiguiente
            // 
            btnSiguiente.FlatAppearance.BorderColor = Color.WhiteSmoke;
            btnSiguiente.FlatStyle = FlatStyle.Flat;
            btnSiguiente.ForeColor = Color.WhiteSmoke;
            btnSiguiente.Location = new Point(671, 10);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(100, 35);
            btnSiguiente.TabIndex = 0;
            btnSiguiente.Text = "Siguiente";
            btnSiguiente.UseVisualStyleBackColor = true;
            btnSiguiente.Click += BtnSiguiente_Click;
            // 
            // pnlContenedor
            // 
            pnlContenedor.Dock = DockStyle.Fill;
            pnlContenedor.Location = new Point(0, 146);
            pnlContenedor.Name = "pnlContenedor";
            pnlContenedor.Size = new Size(784, 358);
            pnlContenedor.TabIndex = 3;
            // 
            // _99906_AsistenteInicioSistema
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(pnlContenedor);
            Controls.Add(pnlInferior);
            Controls.Add(pnlPasos);
            Controls.Add(pnlTitulo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MaximumSize = new Size(800, 600);
            MinimizeBox = false;
            MinimumSize = new Size(800, 600);
            Name = "AsistenteInicioSistema";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sidkenu - Asistente";
            Load += _AsistenteInicioSistema_Load;
            pnlTitulo.ResumeLayout(false);
            pnlPasos.ResumeLayout(false);
            pnlPasos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imgPaso2).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgPaso1).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgPaso0).EndInit();
            pnlInferior.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTitulo;
        private Panel pnlLinea;
        private Label lblTitulo;
        private Panel pnlPasos;
        private Base.Controles.SidkenuCircularPictureBox imgPaso2;
        private Base.Controles.SidkenuCircularPictureBox imgPaso1;
        private Base.Controles.SidkenuCircularPictureBox imgPaso0;
        private Panel pnlPaso2;
        private Panel pnlPaso1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel pnlInferior;
        private Panel pnlContenedor;
        private FontAwesome.Sharp.IconButton btnSalir;
        private Button btnAnterior;
        private Button btnSiguiente;
        private Button btnGrabar;
    }
}