namespace SidkenuWF.Formularios.Core.LookUps
{
    partial class VerDetalleOrdenFabricacion
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dgvGrilla = new DataGridView();
            pnlBotonera = new Panel();
            btnGenerarOrdenFabricacion = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)dgvGrilla).BeginInit();
            pnlBotonera.SuspendLayout();
            SuspendLayout();
            // 
            // dgvGrilla
            // 
            dgvGrilla.AllowUserToAddRows = false;
            dgvGrilla.AllowUserToDeleteRows = false;
            dgvGrilla.BackgroundColor = Color.White;
            dgvGrilla.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvGrilla.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvGrilla.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGrilla.Dock = DockStyle.Fill;
            dgvGrilla.GridColor = Color.FromArgb(64, 64, 64);
            dgvGrilla.Location = new Point(0, 59);
            dgvGrilla.MultiSelect = false;
            dgvGrilla.Name = "dgvGrilla";
            dgvGrilla.RowHeadersVisible = false;
            dgvGrilla.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvGrilla.RowTemplate.Height = 25;
            dgvGrilla.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGrilla.Size = new Size(658, 352);
            dgvGrilla.TabIndex = 2;
            dgvGrilla.CellFormatting += DgvGrilla_CellFormatting;
            dgvGrilla.RowEnter += DgvGrilla_RowEnter;
            // 
            // pnlBotonera
            // 
            pnlBotonera.BackColor = Color.FromArgb(225, 225, 225);
            pnlBotonera.Controls.Add(btnGenerarOrdenFabricacion);
            pnlBotonera.Dock = DockStyle.Right;
            pnlBotonera.Location = new Point(658, 59);
            pnlBotonera.Name = "pnlBotonera";
            pnlBotonera.Size = new Size(76, 352);
            pnlBotonera.TabIndex = 8;
            // 
            // btnGenerarOrdenFabricacion
            // 
            btnGenerarOrdenFabricacion.Dock = DockStyle.Top;
            btnGenerarOrdenFabricacion.FlatAppearance.BorderSize = 0;
            btnGenerarOrdenFabricacion.FlatStyle = FlatStyle.Flat;
            btnGenerarOrdenFabricacion.ForeColor = Color.FromArgb(64, 64, 64);
            btnGenerarOrdenFabricacion.IconChar = FontAwesome.Sharp.IconChar.Box;
            btnGenerarOrdenFabricacion.IconColor = Color.FromArgb(192, 64, 0);
            btnGenerarOrdenFabricacion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGenerarOrdenFabricacion.IconSize = 25;
            btnGenerarOrdenFabricacion.Location = new Point(0, 0);
            btnGenerarOrdenFabricacion.Name = "btnGenerarOrdenFabricacion";
            btnGenerarOrdenFabricacion.Size = new Size(76, 88);
            btnGenerarOrdenFabricacion.TabIndex = 2;
            btnGenerarOrdenFabricacion.Text = "Generador Orden de Fabricación";
            btnGenerarOrdenFabricacion.TextImageRelation = TextImageRelation.ImageAboveText;
            btnGenerarOrdenFabricacion.UseVisualStyleBackColor = true;
            btnGenerarOrdenFabricacion.Visible = false;
            btnGenerarOrdenFabricacion.Click += BtnGenerarOrdenFabricacion_Click;
            // 
            // VerDetalleOrdenFabricacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(734, 411);
            Controls.Add(dgvGrilla);
            Controls.Add(pnlBotonera);
            MaximumSize = new Size(750, 450);
            MinimumSize = new Size(750, 450);
            Name = "VerDetalleOrdenFabricacion";
            Text = "Detalle Orden de Fabricación";
            Shown += VerDetalleOrdenFabricacion_Shown;
            Controls.SetChildIndex(pnlBotonera, 0);
            Controls.SetChildIndex(dgvGrilla, 0);
            ((System.ComponentModel.ISupportInitialize)dgvGrilla).EndInit();
            pnlBotonera.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        public DataGridView dgvGrilla;
        private Panel pnlBotonera;
        private FontAwesome.Sharp.IconButton btnGenerarOrdenFabricacion;
    }
}