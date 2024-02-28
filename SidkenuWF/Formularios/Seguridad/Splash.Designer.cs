namespace SidkenuWF.Formularios.Seguridad
{
    partial class Splash
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
            bgWorker = new System.ComponentModel.BackgroundWorker();
            pgBar = new ProgressBar();
            lblMensaje = new Label();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // bgWorker
            // 
            bgWorker.WorkerReportsProgress = true;
            bgWorker.WorkerSupportsCancellation = true;
            bgWorker.DoWork += BgWorker_DoWork;
            bgWorker.ProgressChanged += BgWorker_ProgressChanged;
            bgWorker.RunWorkerCompleted += BgWorker_RunWorkerCompleted;
            // 
            // pgBar
            // 
            pgBar.Location = new Point(5, 279);
            pgBar.Name = "pgBar";
            pgBar.Size = new Size(489, 15);
            pgBar.TabIndex = 0;
            // 
            // lblMensaje
            // 
            lblMensaje.BackColor = Color.Transparent;
            lblMensaje.ForeColor = Color.WhiteSmoke;
            lblMensaje.Location = new Point(5, 254);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(489, 21);
            lblMensaje.TabIndex = 1;
            lblMensaje.Text = "Mensaje";
            lblMensaje.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(115, 90);
            label1.Name = "label1";
            label1.Size = new Size(262, 86);
            label1.TabIndex = 2;
            label1.Text = "Sidkenu";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(311, 161);
            label2.Name = "label2";
            label2.Size = new Size(45, 32);
            label2.TabIndex = 3;
            label2.Text = "1.0";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Splash
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 64, 0);
            BackgroundImage = Properties.Resources.fondoInicio;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(500, 300);
            ControlBox = false;
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblMensaje);
            Controls.Add(pgBar);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(500, 300);
            MinimumSize = new Size(500, 300);
            Name = "Splash";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Splash";
            Load += _99905_Splash_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.ComponentModel.BackgroundWorker bgWorker;
        private ProgressBar pgBar;
        private Label lblMensaje;
        private Label label1;
        private Label label2;
    }
}