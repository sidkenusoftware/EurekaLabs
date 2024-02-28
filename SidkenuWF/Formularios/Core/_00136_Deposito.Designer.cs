namespace SidkenuWF.Formularios.Core
{
    partial class _00136_Deposito
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
            btnMarcarPredeterminado = new FontAwesome.Sharp.IconButton();
            btnAsignarPersona = new FontAwesome.Sharp.IconButton();
            pnlBotonera.SuspendLayout();
            SuspendLayout();
            // 
            // pnlInferior
            // 
            pnlInferior.Location = new Point(0, 414);
            pnlInferior.Size = new Size(696, 36);
            // 
            // pnlBotonera
            // 
            pnlBotonera.Controls.Add(btnAsignarPersona);
            pnlBotonera.Controls.Add(btnMarcarPredeterminado);
            pnlBotonera.Location = new Point(722, 111);
            pnlBotonera.Size = new Size(78, 339);
            // 
            // btnMarcarPredeterminado
            // 
            btnMarcarPredeterminado.Dock = DockStyle.Top;
            btnMarcarPredeterminado.FlatAppearance.BorderSize = 0;
            btnMarcarPredeterminado.FlatStyle = FlatStyle.Flat;
            btnMarcarPredeterminado.ForeColor = Color.FromArgb(64, 64, 64);
            btnMarcarPredeterminado.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            btnMarcarPredeterminado.IconColor = Color.FromArgb(192, 64, 0);
            btnMarcarPredeterminado.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMarcarPredeterminado.IconSize = 35;
            btnMarcarPredeterminado.Location = new Point(0, 0);
            btnMarcarPredeterminado.Name = "btnMarcarPredeterminado";
            btnMarcarPredeterminado.Size = new Size(78, 68);
            btnMarcarPredeterminado.TabIndex = 2;
            btnMarcarPredeterminado.Text = "Marcar Default";
            btnMarcarPredeterminado.TextImageRelation = TextImageRelation.ImageAboveText;
            btnMarcarPredeterminado.UseVisualStyleBackColor = true;
            btnMarcarPredeterminado.Click += BtnMarcarPredeterminado_Click;
            // 
            // btnAsignarPersona
            // 
            btnAsignarPersona.Dock = DockStyle.Top;
            btnAsignarPersona.FlatAppearance.BorderSize = 0;
            btnAsignarPersona.FlatStyle = FlatStyle.Flat;
            btnAsignarPersona.ForeColor = Color.FromArgb(64, 64, 64);
            btnAsignarPersona.IconChar = FontAwesome.Sharp.IconChar.PeopleCarryBox;
            btnAsignarPersona.IconColor = Color.FromArgb(192, 64, 0);
            btnAsignarPersona.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAsignarPersona.IconSize = 35;
            btnAsignarPersona.Location = new Point(0, 68);
            btnAsignarPersona.Name = "btnAsignarPersona";
            btnAsignarPersona.Size = new Size(78, 68);
            btnAsignarPersona.TabIndex = 3;
            btnAsignarPersona.Text = "Asignar Persona";
            btnAsignarPersona.TextImageRelation = TextImageRelation.ImageAboveText;
            btnAsignarPersona.UseVisualStyleBackColor = true;
            btnAsignarPersona.Click += BtnAsignarPersona_Click;
            // 
            // _00136_Deposito
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Name = "_00136_Deposito";
            Text = "Deposito";
            pnlBotonera.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FontAwesome.Sharp.IconButton btnAsignarPersona;
        private FontAwesome.Sharp.IconButton btnMarcarPredeterminado;
    }
}