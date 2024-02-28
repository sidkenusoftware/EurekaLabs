namespace SidkenuWF.Formularios.Core.Controles
{
    partial class CtrolVariante
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
            chkValor = new Base.Controles.SidkenuToggleButton();
            SuspendLayout();
            // 
            // chkValor
            // 
            chkValor.Anchor = AnchorStyles.None;
            chkValor.AutoSize = true;
            chkValor.Location = new Point(12, 10);
            chkValor.MinimumSize = new Size(45, 22);
            chkValor.Name = "chkValor";
            chkValor.OffBackColor = Color.Gray;
            chkValor.OffToggleColor = Color.Gainsboro;
            chkValor.OnBackColor = Color.FromArgb(0, 192, 0);
            chkValor.OnToggleColor = Color.WhiteSmoke;
            chkValor.Size = new Size(45, 22);
            chkValor.TabIndex = 0;
            chkValor.UseVisualStyleBackColor = true;
            // 
            // CtrolVariante
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            Controls.Add(chkValor);
            Name = "CtrolVariante";
            Size = new Size(69, 42);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Base.Controles.SidkenuToggleButton chkValor;
    }
}
