namespace SidkenuWF.Formularios.Core
{
    partial class _00122_Articulo
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
            btnVariantes = new FontAwesome.Sharp.IconButton();
            btnVerStock = new FontAwesome.Sharp.IconButton();
            btnVerListaPrecio = new FontAwesome.Sharp.IconButton();
            btnConfeccionarKit = new FontAwesome.Sharp.IconButton();
            btnVerKit = new FontAwesome.Sharp.IconButton();
            btnVerFormula = new FontAwesome.Sharp.IconButton();
            btnConfeccionarFormula = new FontAwesome.Sharp.IconButton();
            pnlBotonera.SuspendLayout();
            SuspendLayout();
            // 
            // pnlInferior
            // 
            pnlInferior.Location = new Point(0, 627);
            pnlInferior.Size = new Size(558, 36);
            // 
            // pnlBotonera
            // 
            pnlBotonera.Controls.Add(btnVerFormula);
            pnlBotonera.Controls.Add(btnConfeccionarFormula);
            pnlBotonera.Controls.Add(btnVerKit);
            pnlBotonera.Controls.Add(btnConfeccionarKit);
            pnlBotonera.Controls.Add(btnVerListaPrecio);
            pnlBotonera.Controls.Add(btnVerStock);
            pnlBotonera.Controls.Add(btnVariantes);
            pnlBotonera.Location = new Point(585, 111);
            pnlBotonera.Size = new Size(144, 552);
            // 
            // btnVariantes
            // 
            btnVariantes.Dock = DockStyle.Top;
            btnVariantes.FlatAppearance.BorderSize = 0;
            btnVariantes.FlatStyle = FlatStyle.Flat;
            btnVariantes.ForeColor = Color.FromArgb(64, 64, 64);
            btnVariantes.IconChar = FontAwesome.Sharp.IconChar.Box;
            btnVariantes.IconColor = Color.FromArgb(192, 64, 0);
            btnVariantes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnVariantes.IconSize = 25;
            btnVariantes.Location = new Point(0, 0);
            btnVariantes.Name = "btnVariantes";
            btnVariantes.Size = new Size(144, 50);
            btnVariantes.TabIndex = 1;
            btnVariantes.Text = "Generador de Variantes";
            btnVariantes.TextImageRelation = TextImageRelation.ImageAboveText;
            btnVariantes.UseVisualStyleBackColor = true;
            btnVariantes.Visible = false;
            btnVariantes.Click += BtnVariantes_Click;
            // 
            // btnVerStock
            // 
            btnVerStock.Dock = DockStyle.Top;
            btnVerStock.FlatAppearance.BorderSize = 0;
            btnVerStock.FlatStyle = FlatStyle.Flat;
            btnVerStock.ForeColor = Color.FromArgb(64, 64, 64);
            btnVerStock.IconChar = FontAwesome.Sharp.IconChar.Box;
            btnVerStock.IconColor = Color.FromArgb(192, 64, 0);
            btnVerStock.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnVerStock.IconSize = 25;
            btnVerStock.Location = new Point(0, 50);
            btnVerStock.Name = "btnVerStock";
            btnVerStock.Size = new Size(144, 50);
            btnVerStock.TabIndex = 2;
            btnVerStock.Text = "Ver Stock";
            btnVerStock.TextImageRelation = TextImageRelation.ImageAboveText;
            btnVerStock.UseVisualStyleBackColor = true;
            btnVerStock.Click += BtnVerStock_Click;
            // 
            // btnVerListaPrecio
            // 
            btnVerListaPrecio.Dock = DockStyle.Top;
            btnVerListaPrecio.FlatAppearance.BorderSize = 0;
            btnVerListaPrecio.FlatStyle = FlatStyle.Flat;
            btnVerListaPrecio.ForeColor = Color.FromArgb(64, 64, 64);
            btnVerListaPrecio.IconChar = FontAwesome.Sharp.IconChar.Box;
            btnVerListaPrecio.IconColor = Color.FromArgb(192, 64, 0);
            btnVerListaPrecio.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnVerListaPrecio.IconSize = 25;
            btnVerListaPrecio.Location = new Point(0, 100);
            btnVerListaPrecio.Name = "btnVerListaPrecio";
            btnVerListaPrecio.Size = new Size(144, 50);
            btnVerListaPrecio.TabIndex = 3;
            btnVerListaPrecio.Text = "Ver Lista de Precios";
            btnVerListaPrecio.TextImageRelation = TextImageRelation.ImageAboveText;
            btnVerListaPrecio.UseVisualStyleBackColor = true;
            btnVerListaPrecio.Click += BtnVerListaPrecio_Click;
            // 
            // btnConfeccionarKit
            // 
            btnConfeccionarKit.Dock = DockStyle.Top;
            btnConfeccionarKit.FlatAppearance.BorderSize = 0;
            btnConfeccionarKit.FlatStyle = FlatStyle.Flat;
            btnConfeccionarKit.ForeColor = Color.FromArgb(64, 64, 64);
            btnConfeccionarKit.IconChar = FontAwesome.Sharp.IconChar.Box;
            btnConfeccionarKit.IconColor = Color.FromArgb(192, 64, 0);
            btnConfeccionarKit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnConfeccionarKit.IconSize = 25;
            btnConfeccionarKit.Location = new Point(0, 150);
            btnConfeccionarKit.Name = "btnConfeccionarKit";
            btnConfeccionarKit.Size = new Size(144, 47);
            btnConfeccionarKit.TabIndex = 4;
            btnConfeccionarKit.Text = "Confeccionar Kit";
            btnConfeccionarKit.TextImageRelation = TextImageRelation.ImageAboveText;
            btnConfeccionarKit.UseVisualStyleBackColor = true;
            btnConfeccionarKit.Visible = false;
            btnConfeccionarKit.Click += BtnConfeccionarKit_Click;
            // 
            // btnVerKit
            // 
            btnVerKit.Dock = DockStyle.Top;
            btnVerKit.FlatAppearance.BorderSize = 0;
            btnVerKit.FlatStyle = FlatStyle.Flat;
            btnVerKit.ForeColor = Color.FromArgb(64, 64, 64);
            btnVerKit.IconChar = FontAwesome.Sharp.IconChar.Box;
            btnVerKit.IconColor = Color.FromArgb(192, 64, 0);
            btnVerKit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnVerKit.IconSize = 25;
            btnVerKit.Location = new Point(0, 197);
            btnVerKit.Name = "btnVerKit";
            btnVerKit.Size = new Size(144, 50);
            btnVerKit.TabIndex = 5;
            btnVerKit.Text = "Ver Kit";
            btnVerKit.TextImageRelation = TextImageRelation.ImageAboveText;
            btnVerKit.UseVisualStyleBackColor = true;
            btnVerKit.Visible = false;
            btnVerKit.Click += BtnVerKit_Click;
            // 
            // btnVerFormula
            // 
            btnVerFormula.Dock = DockStyle.Top;
            btnVerFormula.FlatAppearance.BorderSize = 0;
            btnVerFormula.FlatStyle = FlatStyle.Flat;
            btnVerFormula.ForeColor = Color.FromArgb(64, 64, 64);
            btnVerFormula.IconChar = FontAwesome.Sharp.IconChar.Box;
            btnVerFormula.IconColor = Color.FromArgb(192, 64, 0);
            btnVerFormula.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnVerFormula.IconSize = 25;
            btnVerFormula.Location = new Point(0, 294);
            btnVerFormula.Name = "btnVerFormula";
            btnVerFormula.Size = new Size(144, 50);
            btnVerFormula.TabIndex = 7;
            btnVerFormula.Text = "Ver Formula";
            btnVerFormula.TextImageRelation = TextImageRelation.ImageAboveText;
            btnVerFormula.UseVisualStyleBackColor = true;
            btnVerFormula.Visible = false;
            btnVerFormula.Click += BtnVerFormula_Click;
            // 
            // btnConfeccionarFormula
            // 
            btnConfeccionarFormula.Dock = DockStyle.Top;
            btnConfeccionarFormula.FlatAppearance.BorderSize = 0;
            btnConfeccionarFormula.FlatStyle = FlatStyle.Flat;
            btnConfeccionarFormula.ForeColor = Color.FromArgb(64, 64, 64);
            btnConfeccionarFormula.IconChar = FontAwesome.Sharp.IconChar.Box;
            btnConfeccionarFormula.IconColor = Color.FromArgb(192, 64, 0);
            btnConfeccionarFormula.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnConfeccionarFormula.IconSize = 25;
            btnConfeccionarFormula.Location = new Point(0, 247);
            btnConfeccionarFormula.Name = "btnConfeccionarFormula";
            btnConfeccionarFormula.Size = new Size(144, 47);
            btnConfeccionarFormula.TabIndex = 6;
            btnConfeccionarFormula.Text = "Confeccionar Formula";
            btnConfeccionarFormula.TextImageRelation = TextImageRelation.ImageAboveText;
            btnConfeccionarFormula.UseVisualStyleBackColor = true;
            btnConfeccionarFormula.Visible = false;
            btnConfeccionarFormula.Click += BtnConfeccionarFormula_Click;
            // 
            // _00122_Articulo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(729, 663);
            Name = "_00122_Articulo";
            Text = "Articulo";
            pnlBotonera.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FontAwesome.Sharp.IconButton btnVariantes;
        private FontAwesome.Sharp.IconButton btnVerListaPrecio;
        private FontAwesome.Sharp.IconButton btnVerStock;
        private FontAwesome.Sharp.IconButton btnConfeccionarKit;
        private FontAwesome.Sharp.IconButton btnVerKit;
        private FontAwesome.Sharp.IconButton btnVerFormula;
        private FontAwesome.Sharp.IconButton btnConfeccionarFormula;
    }
}