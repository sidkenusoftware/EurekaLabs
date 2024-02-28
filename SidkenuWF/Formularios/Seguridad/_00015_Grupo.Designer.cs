namespace SidkenuWF.Formularios.Seguridad
{
    partial class _00015_Grupo
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
            btnAgregarQuitarEmpleados = new FontAwesome.Sharp.IconButton();
            btnAgregarQuitarFormularios = new FontAwesome.Sharp.IconButton();
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
            pnlBotonera.Controls.Add(btnAgregarQuitarFormularios);
            pnlBotonera.Controls.Add(btnAgregarQuitarEmpleados);
            pnlBotonera.Location = new Point(722, 111);
            pnlBotonera.Size = new Size(78, 339);
            // 
            // btnAgregarQuitarEmpleados
            // 
            btnAgregarQuitarEmpleados.Dock = DockStyle.Top;
            btnAgregarQuitarEmpleados.FlatAppearance.BorderSize = 0;
            btnAgregarQuitarEmpleados.FlatStyle = FlatStyle.Flat;
            btnAgregarQuitarEmpleados.ForeColor = Color.FromArgb(64, 64, 64);
            btnAgregarQuitarEmpleados.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            btnAgregarQuitarEmpleados.IconColor = Color.FromArgb(64, 64, 64);
            btnAgregarQuitarEmpleados.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAgregarQuitarEmpleados.IconSize = 35;
            btnAgregarQuitarEmpleados.Location = new Point(0, 0);
            btnAgregarQuitarEmpleados.Name = "btnAgregarQuitarEmpleados";
            btnAgregarQuitarEmpleados.Size = new Size(78, 93);
            btnAgregarQuitarEmpleados.TabIndex = 1;
            btnAgregarQuitarEmpleados.Text = "Asignar Quitar Empleados";
            btnAgregarQuitarEmpleados.TextImageRelation = TextImageRelation.ImageAboveText;
            btnAgregarQuitarEmpleados.UseVisualStyleBackColor = true;
            btnAgregarQuitarEmpleados.Click += BtnAgregarQuitarEmpleados_Click;
            // 
            // btnAgregarQuitarFormularios
            // 
            btnAgregarQuitarFormularios.Dock = DockStyle.Top;
            btnAgregarQuitarFormularios.FlatAppearance.BorderSize = 0;
            btnAgregarQuitarFormularios.FlatStyle = FlatStyle.Flat;
            btnAgregarQuitarFormularios.ForeColor = Color.FromArgb(64, 64, 64);
            btnAgregarQuitarFormularios.IconChar = FontAwesome.Sharp.IconChar.DesktopAlt;
            btnAgregarQuitarFormularios.IconColor = Color.FromArgb(64, 64, 64);
            btnAgregarQuitarFormularios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAgregarQuitarFormularios.IconSize = 35;
            btnAgregarQuitarFormularios.Location = new Point(0, 93);
            btnAgregarQuitarFormularios.Name = "btnAgregarQuitarFormularios";
            btnAgregarQuitarFormularios.Size = new Size(78, 93);
            btnAgregarQuitarFormularios.TabIndex = 2;
            btnAgregarQuitarFormularios.Text = "Asignar Quitar Formularios";
            btnAgregarQuitarFormularios.TextImageRelation = TextImageRelation.ImageAboveText;
            btnAgregarQuitarFormularios.UseVisualStyleBackColor = true;
            btnAgregarQuitarFormularios.Click += BtnAgregarQuitarFormularios_Click;
            // 
            // _00015_Grupo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Name = "_00015_Grupo";
            Text = "Tsidkenu";
            pnlBotonera.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FontAwesome.Sharp.IconButton btnAgregarQuitarFormularios;
        private FontAwesome.Sharp.IconButton btnAgregarQuitarEmpleados;
    }
}