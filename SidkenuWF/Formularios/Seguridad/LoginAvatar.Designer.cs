namespace SidkenuWF.Formularios.Seguridad
{
    partial class LoginAvatar
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
            flpContenedor = new FlowLayoutPanel();
            btnSalir = new FontAwesome.Sharp.IconButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(101, 114);
            label1.Name = "label1";
            label1.Size = new Size(598, 45);
            label1.TabIndex = 0;
            label1.Text = "¿ Quien está por ingresar al sistema ?";
            // 
            // flpContenedor
            // 
            flpContenedor.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            flpContenedor.Location = new Point(91, 195);
            flpContenedor.Name = "flpContenedor";
            flpContenedor.Size = new Size(621, 320);
            flpContenedor.TabIndex = 1;
            // 
            // btnSalir
            // 
            btnSalir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSalir.FlatAppearance.BorderColor = Color.Gray;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.ForeColor = Color.Gainsboro;
            btnSalir.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            btnSalir.IconColor = Color.Gray;
            btnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSalir.IconSize = 25;
            btnSalir.Location = new Point(751, 8);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(53, 47);
            btnSalir.TabIndex = 2;
            btnSalir.Text = "Salir";
            btnSalir.TextImageRelation = TextImageRelation.ImageAboveText;
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += BtnSalir_Click;
            // 
            // LoginAvatar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            CancelButton = btnSalir;
            ClientSize = new Size(813, 610);
            Controls.Add(btnSalir);
            Controls.Add(flpContenedor);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LoginAvatar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            WindowState = FormWindowState.Maximized;
            Load += _99904_LoginAvatar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private FlowLayoutPanel flpContenedor;
        private FontAwesome.Sharp.IconButton btnSalir;
    }
}