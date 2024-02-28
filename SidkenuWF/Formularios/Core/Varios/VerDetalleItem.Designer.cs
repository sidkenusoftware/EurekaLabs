namespace SidkenuWF.Formularios.Core.Varios
{
    partial class VerDetalleItem
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
            dgvGrilla = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvGrilla).BeginInit();
            SuspendLayout();
            // 
            // dgvGrilla
            // 
            dgvGrilla.AllowUserToAddRows = false;
            dgvGrilla.AllowUserToDeleteRows = false;
            dgvGrilla.BackgroundColor = Color.White;
            dgvGrilla.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGrilla.Dock = DockStyle.Fill;
            dgvGrilla.Location = new Point(0, 59);
            dgvGrilla.Name = "dgvGrilla";
            dgvGrilla.ReadOnly = true;
            dgvGrilla.RowHeadersVisible = false;
            dgvGrilla.RowTemplate.Height = 25;
            dgvGrilla.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGrilla.Size = new Size(784, 352);
            dgvGrilla.TabIndex = 136;
            // 
            // VerDetalleItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 411);
            Controls.Add(dgvGrilla);
            MaximumSize = new Size(800, 450);
            MinimumSize = new Size(800, 450);
            Name = "VerDetalleItem";
            Text = "Sidkenu";
            Load += VerDetalleItem_Load;
            Controls.SetChildIndex(dgvGrilla, 0);
            ((System.ComponentModel.ISupportInitialize)dgvGrilla).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvGrilla;
    }
}