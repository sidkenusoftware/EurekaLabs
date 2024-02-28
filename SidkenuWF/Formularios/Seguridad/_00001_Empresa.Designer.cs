namespace SidkenuWF.Formularios.Seguridad
{
    partial class _00001_Empresa
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
            pnlBotonera.SuspendLayout();
            SuspendLayout();
            // 
            // pnlInferior
            // 
            pnlInferior.Location = new Point(0, 568);
            pnlInferior.Size = new Size(696, 30);
            // 
            // pnlBotonera
            // 
            pnlBotonera.Controls.Add(btnAgregarQuitarEmpleados);
            pnlBotonera.Location = new Point(722, 111);
            pnlBotonera.Size = new Size(78, 487);
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
            btnAgregarQuitarEmpleados.TabIndex = 0;
            btnAgregarQuitarEmpleados.Text = "Asignar Quitar Empleados";
            btnAgregarQuitarEmpleados.TextImageRelation = TextImageRelation.ImageAboveText;
            btnAgregarQuitarEmpleados.UseVisualStyleBackColor = true;
            btnAgregarQuitarEmpleados.Click += BtnAgregarQuitarEmpleados_Click;
            // 
            // _00001_Empresa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 598);
            MinimumSize = new Size(800, 600);
            Name = "_00001_Empresa";
            Text = "Empresa";
            pnlBotonera.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FontAwesome.Sharp.IconButton btnAgregarQuitarEmpleados;
    }
}