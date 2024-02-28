namespace SidkenuWF.Formularios.Core
{
    partial class _00148_FormaPago
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
            pnlBotonera = new Panel();
            panel1 = new Panel();
            flpBotonera = new FlowLayoutPanel();
            btnEfectivo = new FontAwesome.Sharp.IconButton();
            btnTarjeta = new FontAwesome.Sharp.IconButton();
            btnTransferencia = new FontAwesome.Sharp.IconButton();
            btnCuentaCorriente = new FontAwesome.Sharp.IconButton();
            btnCheque = new FontAwesome.Sharp.IconButton();
            panel3 = new Panel();
            label2 = new Label();
            txtTotalAPagar = new TextBox();
            panel4 = new Panel();
            panel2 = new Panel();
            panel7 = new Panel();
            btnFacturar = new FontAwesome.Sharp.IconButton();
            btnConfirmar = new FontAwesome.Sharp.IconButton();
            panel8 = new Panel();
            label4 = new Label();
            txtTotal = new TextBox();
            label3 = new Label();
            txtTotalInteres = new TextBox();
            label1 = new Label();
            txtTotalCapital = new TextBox();
            panel5 = new Panel();
            dgvGrilla = new DataGridView();
            panel6 = new Panel();
            btnEliminarItem = new FontAwesome.Sharp.IconButton();
            pnlBotonera.SuspendLayout();
            flpBotonera.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGrilla).BeginInit();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // pnlBotonera
            // 
            pnlBotonera.Controls.Add(panel1);
            pnlBotonera.Controls.Add(flpBotonera);
            pnlBotonera.Dock = DockStyle.Top;
            pnlBotonera.Location = new Point(0, 106);
            pnlBotonera.Name = "pnlBotonera";
            pnlBotonera.Size = new Size(827, 44);
            pnlBotonera.TabIndex = 137;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(192, 64, 0);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 42);
            panel1.Name = "panel1";
            panel1.Size = new Size(827, 2);
            panel1.TabIndex = 2;
            // 
            // flpBotonera
            // 
            flpBotonera.Controls.Add(btnEfectivo);
            flpBotonera.Controls.Add(btnTarjeta);
            flpBotonera.Controls.Add(btnTransferencia);
            flpBotonera.Controls.Add(btnCuentaCorriente);
            flpBotonera.Controls.Add(btnCheque);
            flpBotonera.Dock = DockStyle.Fill;
            flpBotonera.Location = new Point(0, 0);
            flpBotonera.Name = "flpBotonera";
            flpBotonera.Size = new Size(827, 44);
            flpBotonera.TabIndex = 3;
            // 
            // btnEfectivo
            // 
            btnEfectivo.BackColor = Color.FromArgb(48, 66, 80);
            btnEfectivo.FlatAppearance.BorderSize = 0;
            btnEfectivo.FlatStyle = FlatStyle.Flat;
            btnEfectivo.ForeColor = Color.White;
            btnEfectivo.IconChar = FontAwesome.Sharp.IconChar.DollarSign;
            btnEfectivo.IconColor = Color.FromArgb(255, 255, 192);
            btnEfectivo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEfectivo.IconSize = 25;
            btnEfectivo.Location = new Point(3, 3);
            btnEfectivo.Name = "btnEfectivo";
            btnEfectivo.Size = new Size(159, 37);
            btnEfectivo.TabIndex = 0;
            btnEfectivo.Text = "Efectivo ( F5 )";
            btnEfectivo.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEfectivo.UseVisualStyleBackColor = false;
            btnEfectivo.Click += BtnEfectivo_Click;
            // 
            // btnTarjeta
            // 
            btnTarjeta.BackColor = Color.FromArgb(48, 66, 80);
            btnTarjeta.FlatAppearance.BorderSize = 0;
            btnTarjeta.FlatStyle = FlatStyle.Flat;
            btnTarjeta.ForeColor = Color.White;
            btnTarjeta.IconChar = FontAwesome.Sharp.IconChar.CreditCardAlt;
            btnTarjeta.IconColor = Color.FromArgb(255, 255, 192);
            btnTarjeta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnTarjeta.IconSize = 25;
            btnTarjeta.Location = new Point(168, 3);
            btnTarjeta.Name = "btnTarjeta";
            btnTarjeta.Size = new Size(159, 37);
            btnTarjeta.TabIndex = 1;
            btnTarjeta.Text = "Tarjeta ( F6 )";
            btnTarjeta.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTarjeta.UseVisualStyleBackColor = false;
            btnTarjeta.Click += BtnTarjeta_Click;
            // 
            // btnTransferencia
            // 
            btnTransferencia.BackColor = Color.FromArgb(48, 66, 80);
            btnTransferencia.FlatAppearance.BorderSize = 0;
            btnTransferencia.FlatStyle = FlatStyle.Flat;
            btnTransferencia.ForeColor = Color.White;
            btnTransferencia.IconChar = FontAwesome.Sharp.IconChar.MoneyBillTransfer;
            btnTransferencia.IconColor = Color.FromArgb(255, 255, 192);
            btnTransferencia.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnTransferencia.IconSize = 25;
            btnTransferencia.Location = new Point(333, 3);
            btnTransferencia.Name = "btnTransferencia";
            btnTransferencia.Size = new Size(159, 37);
            btnTransferencia.TabIndex = 2;
            btnTransferencia.Text = "Transferencia ( F7 )";
            btnTransferencia.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTransferencia.UseVisualStyleBackColor = false;
            btnTransferencia.Click += BtnTransferencia_Click;
            // 
            // btnCuentaCorriente
            // 
            btnCuentaCorriente.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnCuentaCorriente.BackColor = Color.FromArgb(48, 66, 80);
            btnCuentaCorriente.FlatAppearance.BorderSize = 0;
            btnCuentaCorriente.FlatStyle = FlatStyle.Flat;
            btnCuentaCorriente.ForeColor = Color.White;
            btnCuentaCorriente.IconChar = FontAwesome.Sharp.IconChar.PersonWalkingArrowLoopLeft;
            btnCuentaCorriente.IconColor = Color.FromArgb(255, 255, 192);
            btnCuentaCorriente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCuentaCorriente.IconSize = 25;
            btnCuentaCorriente.Location = new Point(498, 3);
            btnCuentaCorriente.Name = "btnCuentaCorriente";
            btnCuentaCorriente.Size = new Size(159, 37);
            btnCuentaCorriente.TabIndex = 3;
            btnCuentaCorriente.Text = "Cuenta Corriente ( F8 )";
            btnCuentaCorriente.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCuentaCorriente.UseVisualStyleBackColor = false;
            btnCuentaCorriente.Click += BtnCuentaCorriente_Click;
            // 
            // btnCheque
            // 
            btnCheque.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnCheque.BackColor = Color.FromArgb(48, 66, 80);
            btnCheque.FlatAppearance.BorderSize = 0;
            btnCheque.FlatStyle = FlatStyle.Flat;
            btnCheque.ForeColor = Color.White;
            btnCheque.IconChar = FontAwesome.Sharp.IconChar.PersonWalkingArrowLoopLeft;
            btnCheque.IconColor = Color.FromArgb(255, 255, 192);
            btnCheque.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCheque.IconSize = 25;
            btnCheque.Location = new Point(663, 3);
            btnCheque.Name = "btnCheque";
            btnCheque.Size = new Size(159, 37);
            btnCheque.TabIndex = 4;
            btnCheque.Text = "Cheque ( F9 )";
            btnCheque.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCheque.UseVisualStyleBackColor = false;
            btnCheque.Click += BtnCheque_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(label2);
            panel3.Controls.Add(txtTotalAPagar);
            panel3.Controls.Add(panel4);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 59);
            panel3.Name = "panel3";
            panel3.Size = new Size(827, 47);
            panel3.TabIndex = 139;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(456, 10);
            label2.Name = "label2";
            label2.Size = new Size(154, 25);
            label2.TabIndex = 6;
            label2.Text = "TOTAL A PAGAR";
            // 
            // txtTotalAPagar
            // 
            txtTotalAPagar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtTotalAPagar.BackColor = Color.FromArgb(64, 64, 64);
            txtTotalAPagar.BorderStyle = BorderStyle.FixedSingle;
            txtTotalAPagar.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtTotalAPagar.ForeColor = Color.White;
            txtTotalAPagar.Location = new Point(615, 5);
            txtTotalAPagar.Name = "txtTotalAPagar";
            txtTotalAPagar.ReadOnly = true;
            txtTotalAPagar.Size = new Size(207, 35);
            txtTotalAPagar.TabIndex = 5;
            txtTotalAPagar.TextAlign = HorizontalAlignment.Right;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(192, 64, 0);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 45);
            panel4.Name = "panel4";
            panel4.Size = new Size(827, 2);
            panel4.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel7);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(txtTotal);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txtTotalInteres);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(txtTotalCapital);
            panel2.Controls.Add(panel5);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 435);
            panel2.Name = "panel2";
            panel2.Size = new Size(827, 83);
            panel2.TabIndex = 138;
            // 
            // panel7
            // 
            panel7.Controls.Add(btnFacturar);
            panel7.Controls.Add(btnConfirmar);
            panel7.Controls.Add(panel8);
            panel7.Dock = DockStyle.Bottom;
            panel7.Location = new Point(0, 40);
            panel7.Name = "panel7";
            panel7.Size = new Size(827, 43);
            panel7.TabIndex = 13;
            // 
            // btnFacturar
            // 
            btnFacturar.BackColor = Color.Green;
            btnFacturar.FlatStyle = FlatStyle.Flat;
            btnFacturar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnFacturar.ForeColor = Color.White;
            btnFacturar.IconChar = FontAwesome.Sharp.IconChar.None;
            btnFacturar.IconColor = Color.Black;
            btnFacturar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnFacturar.Location = new Point(142, 6);
            btnFacturar.Name = "btnFacturar";
            btnFacturar.Size = new Size(124, 33);
            btnFacturar.TabIndex = 12;
            btnFacturar.Text = "Facturar";
            btnFacturar.UseVisualStyleBackColor = false;
            btnFacturar.Click += BtnFacturar_Click;
            // 
            // btnConfirmar
            // 
            btnConfirmar.BackColor = Color.Teal;
            btnConfirmar.FlatStyle = FlatStyle.Flat;
            btnConfirmar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnConfirmar.ForeColor = Color.White;
            btnConfirmar.IconChar = FontAwesome.Sharp.IconChar.None;
            btnConfirmar.IconColor = Color.Black;
            btnConfirmar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnConfirmar.Location = new Point(12, 6);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(124, 33);
            btnConfirmar.TabIndex = 11;
            btnConfirmar.Text = "Grabar";
            btnConfirmar.UseVisualStyleBackColor = false;
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(192, 64, 0);
            panel8.Dock = DockStyle.Top;
            panel8.Location = new Point(0, 0);
            panel8.Name = "panel8";
            panel8.Size = new Size(827, 2);
            panel8.TabIndex = 5;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(560, 11);
            label4.Name = "label4";
            label4.Size = new Size(59, 20);
            label4.TabIndex = 12;
            label4.Text = "TOTAL";
            // 
            // txtTotal
            // 
            txtTotal.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtTotal.BackColor = Color.FromArgb(64, 64, 64);
            txtTotal.BorderStyle = BorderStyle.FixedSingle;
            txtTotal.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTotal.ForeColor = Color.White;
            txtTotal.Location = new Point(625, 8);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(193, 26);
            txtTotal.TabIndex = 11;
            txtTotal.TextAlign = HorizontalAlignment.Right;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(269, 11);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 10;
            label3.Text = "Intereses";
            // 
            // txtTotalInteres
            // 
            txtTotalInteres.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtTotalInteres.BackColor = Color.FromArgb(64, 64, 64);
            txtTotalInteres.BorderStyle = BorderStyle.FixedSingle;
            txtTotalInteres.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTotalInteres.ForeColor = Color.White;
            txtTotalInteres.Location = new Point(351, 8);
            txtTotalInteres.Name = "txtTotalInteres";
            txtTotalInteres.ReadOnly = true;
            txtTotalInteres.Size = new Size(193, 26);
            txtTotalInteres.TabIndex = 9;
            txtTotalInteres.TextAlign = HorizontalAlignment.Right;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(7, 11);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 8;
            label1.Text = "Capital";
            // 
            // txtTotalCapital
            // 
            txtTotalCapital.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtTotalCapital.BackColor = Color.FromArgb(64, 64, 64);
            txtTotalCapital.BorderStyle = BorderStyle.FixedSingle;
            txtTotalCapital.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTotalCapital.ForeColor = Color.White;
            txtTotalCapital.Location = new Point(71, 8);
            txtTotalCapital.Name = "txtTotalCapital";
            txtTotalCapital.ReadOnly = true;
            txtTotalCapital.Size = new Size(193, 26);
            txtTotalCapital.TabIndex = 7;
            txtTotalCapital.TextAlign = HorizontalAlignment.Right;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(192, 64, 0);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(827, 2);
            panel5.TabIndex = 4;
            // 
            // dgvGrilla
            // 
            dgvGrilla.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvGrilla.BackgroundColor = Color.White;
            dgvGrilla.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGrilla.Location = new Point(4, 153);
            dgvGrilla.Name = "dgvGrilla";
            dgvGrilla.ReadOnly = true;
            dgvGrilla.RowHeadersVisible = false;
            dgvGrilla.RowTemplate.Height = 25;
            dgvGrilla.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGrilla.Size = new Size(754, 279);
            dgvGrilla.TabIndex = 140;
            dgvGrilla.RowEnter += DgvGrilla_RowEnter;
            dgvGrilla.RowsAdded += DgvGrilla_RowsAdded;
            dgvGrilla.RowsRemoved += DgvGrilla_RowsRemoved;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(224, 224, 224);
            panel6.Controls.Add(btnEliminarItem);
            panel6.Dock = DockStyle.Right;
            panel6.Location = new Point(762, 150);
            panel6.Name = "panel6";
            panel6.Size = new Size(65, 285);
            panel6.TabIndex = 141;
            // 
            // btnEliminarItem
            // 
            btnEliminarItem.BackColor = Color.FromArgb(64, 64, 64);
            btnEliminarItem.Dock = DockStyle.Top;
            btnEliminarItem.FlatAppearance.BorderSize = 0;
            btnEliminarItem.FlatStyle = FlatStyle.Flat;
            btnEliminarItem.ForeColor = Color.White;
            btnEliminarItem.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            btnEliminarItem.IconColor = Color.FromArgb(255, 128, 0);
            btnEliminarItem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEliminarItem.IconSize = 25;
            btnEliminarItem.Location = new Point(0, 0);
            btnEliminarItem.Name = "btnEliminarItem";
            btnEliminarItem.Size = new Size(65, 57);
            btnEliminarItem.TabIndex = 0;
            btnEliminarItem.Text = "Borrar";
            btnEliminarItem.TextImageRelation = TextImageRelation.ImageAboveText;
            btnEliminarItem.UseVisualStyleBackColor = false;
            btnEliminarItem.Click += BtnEliminarItem_Click;
            // 
            // _00148_FormaPago
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(827, 518);
            Controls.Add(panel6);
            Controls.Add(dgvGrilla);
            Controls.Add(pnlBotonera);
            Controls.Add(panel3);
            Controls.Add(panel2);
            KeyPreview = true;
            MaximumSize = new Size(843, 557);
            MinimumSize = new Size(843, 557);
            Name = "_00148_FormaPago";
            Text = "Medios de Pago";
            Load += _00148_FormaPago_Load;
            Shown += _00148_FormaPago_Shown;
            KeyDown += _00148_FormaPago_KeyDown;
            Controls.SetChildIndex(panel2, 0);
            Controls.SetChildIndex(panel3, 0);
            Controls.SetChildIndex(pnlBotonera, 0);
            Controls.SetChildIndex(dgvGrilla, 0);
            Controls.SetChildIndex(panel6, 0);
            pnlBotonera.ResumeLayout(false);
            flpBotonera.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvGrilla).EndInit();
            panel6.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlBotonera;
        private Panel panel1;
        private FlowLayoutPanel flpBotonera;
        private FontAwesome.Sharp.IconButton btnEfectivo;
        private FontAwesome.Sharp.IconButton btnTarjeta;
        private FontAwesome.Sharp.IconButton btnTransferencia;
        private FontAwesome.Sharp.IconButton btnCuentaCorriente;
        private Panel panel3;
        private Label label2;
        private TextBox txtTotalAPagar;
        private Panel panel4;
        private Panel panel2;
        private Panel panel5;
        private DataGridView dgvGrilla;
        private Label label4;
        private TextBox txtTotal;
        private Label label3;
        private TextBox txtTotalInteres;
        private Label label1;
        private TextBox txtTotalCapital;
        private Panel panel6;
        private FontAwesome.Sharp.IconButton btnEliminarItem;
        private Panel panel7;
        private Panel panel8;
        private FontAwesome.Sharp.IconButton btnFacturar;
        private FontAwesome.Sharp.IconButton btnConfirmar;
        private FontAwesome.Sharp.IconButton btnCheque;
    }
}