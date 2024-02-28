namespace SidkenuWF.Formularios.Seguridad
{
    partial class _00020_ModuloSeguridad
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
            pnlContenedor = new Panel();
            btnEmprea = new FontAwesome.Sharp.IconButton();
            btnPersona = new FontAwesome.Sharp.IconButton();
            btnConfiguracionGeneral = new FontAwesome.Sharp.IconButton();
            menuStrip1 = new MenuStrip();
            empresaToolStripMenuItem = new ToolStripMenuItem();
            aBMEmpresaToolStripMenuItem = new ToolStripMenuItem();
            nuevaEmpresaToolStripMenuItem = new ToolStripMenuItem();
            personaToolStripMenuItem = new ToolStripMenuItem();
            nuevaPersonaToolStripMenuItem = new ToolStripMenuItem();
            aBMPersonaToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripSeparator();
            usuariosToolStripMenuItem = new ToolStripMenuItem();
            configuracionToolStripMenuItem = new ToolStripMenuItem();
            configuracionGeneralToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            parametricasToolStripMenuItem = new ToolStripMenuItem();
            aBMCondicionDeIvaToolStripMenuItem = new ToolStripMenuItem();
            ingresoBrutoToolStripMenuItem = new ToolStripMenuItem();
            provinciaToolStripMenuItem = new ToolStripMenuItem();
            localidadToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripSeparator();
            aBMGrupoToolStripMenuItem = new ToolStripMenuItem();
            formularioToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            btnUsuario = new FontAwesome.Sharp.IconButton();
            pnlMenuLateral.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMenuLateral
            // 
            pnlMenuLateral.Controls.Add(btnConfiguracionGeneral);
            pnlMenuLateral.Controls.Add(btnUsuario);
            pnlMenuLateral.Controls.Add(btnPersona);
            pnlMenuLateral.Controls.Add(btnEmprea);
            pnlMenuLateral.Location = new Point(0, 72);
            pnlMenuLateral.Size = new Size(124, 378);
            pnlMenuLateral.Controls.SetChildIndex(btnEmprea, 0);
            pnlMenuLateral.Controls.SetChildIndex(btnPersona, 0);
            pnlMenuLateral.Controls.SetChildIndex(btnUsuario, 0);
            pnlMenuLateral.Controls.SetChildIndex(btnConfiguracionGeneral, 0);
            pnlMenuLateral.Controls.SetChildIndex(bordeCostadoBotoneraMenu, 0);
            // 
            // pnlContenedor
            // 
            pnlContenedor.Dock = DockStyle.Fill;
            pnlContenedor.Location = new Point(124, 72);
            pnlContenedor.Name = "pnlContenedor";
            pnlContenedor.Size = new Size(676, 378);
            pnlContenedor.TabIndex = 1;
            pnlContenedor.ControlRemoved += PnlContenedor_ControlRemoved;
            // 
            // btnEmprea
            // 
            btnEmprea.Dock = DockStyle.Top;
            btnEmprea.FlatAppearance.BorderSize = 0;
            btnEmprea.FlatStyle = FlatStyle.Flat;
            btnEmprea.IconChar = FontAwesome.Sharp.IconChar.HouseChimneyCrack;
            btnEmprea.IconColor = Color.Gray;
            btnEmprea.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEmprea.IconSize = 30;
            btnEmprea.ImageAlign = ContentAlignment.MiddleLeft;
            btnEmprea.Location = new Point(0, 0);
            btnEmprea.Name = "btnEmprea";
            btnEmprea.Size = new Size(124, 46);
            btnEmprea.TabIndex = 3;
            btnEmprea.Text = "Empresa";
            btnEmprea.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEmprea.UseVisualStyleBackColor = true;
            btnEmprea.Click += BtnEmpresa_Click;
            // 
            // btnPersona
            // 
            btnPersona.Dock = DockStyle.Top;
            btnPersona.FlatAppearance.BorderSize = 0;
            btnPersona.FlatStyle = FlatStyle.Flat;
            btnPersona.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            btnPersona.IconColor = Color.Gray;
            btnPersona.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnPersona.IconSize = 30;
            btnPersona.ImageAlign = ContentAlignment.MiddleLeft;
            btnPersona.Location = new Point(0, 46);
            btnPersona.Name = "btnPersona";
            btnPersona.Size = new Size(124, 46);
            btnPersona.TabIndex = 4;
            btnPersona.Text = "Persona";
            btnPersona.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPersona.UseVisualStyleBackColor = true;
            btnPersona.Click += BtnPersona_Click;
            // 
            // btnConfiguracionGeneral
            // 
            btnConfiguracionGeneral.Dock = DockStyle.Top;
            btnConfiguracionGeneral.FlatAppearance.BorderSize = 0;
            btnConfiguracionGeneral.FlatStyle = FlatStyle.Flat;
            btnConfiguracionGeneral.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            btnConfiguracionGeneral.IconColor = Color.Gray;
            btnConfiguracionGeneral.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnConfiguracionGeneral.IconSize = 30;
            btnConfiguracionGeneral.ImageAlign = ContentAlignment.MiddleLeft;
            btnConfiguracionGeneral.Location = new Point(0, 138);
            btnConfiguracionGeneral.Name = "btnConfiguracionGeneral";
            btnConfiguracionGeneral.Size = new Size(124, 45);
            btnConfiguracionGeneral.TabIndex = 5;
            btnConfiguracionGeneral.Text = "Ajustes";
            btnConfiguracionGeneral.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnConfiguracionGeneral.UseVisualStyleBackColor = true;
            btnConfiguracionGeneral.Click += BtnConfiguracionGeneral_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { empresaToolStripMenuItem, personaToolStripMenuItem, configuracionToolStripMenuItem, salirToolStripMenuItem });
            menuStrip1.Location = new Point(0, 43);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(10, 5, 0, 5);
            menuStrip1.Size = new Size(800, 29);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // empresaToolStripMenuItem
            // 
            empresaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aBMEmpresaToolStripMenuItem, nuevaEmpresaToolStripMenuItem });
            empresaToolStripMenuItem.Name = "empresaToolStripMenuItem";
            empresaToolStripMenuItem.Size = new Size(64, 19);
            empresaToolStripMenuItem.Text = "Empresa";
            // 
            // aBMEmpresaToolStripMenuItem
            // 
            aBMEmpresaToolStripMenuItem.Name = "aBMEmpresaToolStripMenuItem";
            aBMEmpresaToolStripMenuItem.Size = new Size(156, 22);
            aBMEmpresaToolStripMenuItem.Text = "Nueva Empresa";
            aBMEmpresaToolStripMenuItem.Click += ABMEmpresaToolStripMenuItem_Click;
            // 
            // nuevaEmpresaToolStripMenuItem
            // 
            nuevaEmpresaToolStripMenuItem.Name = "nuevaEmpresaToolStripMenuItem";
            nuevaEmpresaToolStripMenuItem.Size = new Size(156, 22);
            nuevaEmpresaToolStripMenuItem.Text = "Consulta";
            nuevaEmpresaToolStripMenuItem.Click += BtnEmpresa_Click;
            // 
            // personaToolStripMenuItem
            // 
            personaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nuevaPersonaToolStripMenuItem, aBMPersonaToolStripMenuItem, toolStripMenuItem2, usuariosToolStripMenuItem });
            personaToolStripMenuItem.Name = "personaToolStripMenuItem";
            personaToolStripMenuItem.Size = new Size(61, 19);
            personaToolStripMenuItem.Text = "Persona";
            // 
            // nuevaPersonaToolStripMenuItem
            // 
            nuevaPersonaToolStripMenuItem.Name = "nuevaPersonaToolStripMenuItem";
            nuevaPersonaToolStripMenuItem.Size = new Size(153, 22);
            nuevaPersonaToolStripMenuItem.Text = "Nueva Persona";
            nuevaPersonaToolStripMenuItem.Click += NuevaPersonaToolStripMenuItem_Click;
            // 
            // aBMPersonaToolStripMenuItem
            // 
            aBMPersonaToolStripMenuItem.Name = "aBMPersonaToolStripMenuItem";
            aBMPersonaToolStripMenuItem.Size = new Size(153, 22);
            aBMPersonaToolStripMenuItem.Text = "Consulta";
            aBMPersonaToolStripMenuItem.Click += BtnPersona_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(150, 6);
            // 
            // usuariosToolStripMenuItem
            // 
            usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            usuariosToolStripMenuItem.Size = new Size(153, 22);
            usuariosToolStripMenuItem.Text = "Usuarios";
            usuariosToolStripMenuItem.Click += BtnUsuario_Click;
            // 
            // configuracionToolStripMenuItem
            // 
            configuracionToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { configuracionGeneralToolStripMenuItem, toolStripMenuItem1, parametricasToolStripMenuItem });
            configuracionToolStripMenuItem.Name = "configuracionToolStripMenuItem";
            configuracionToolStripMenuItem.Size = new Size(95, 19);
            configuracionToolStripMenuItem.Text = "Configuración";
            // 
            // configuracionGeneralToolStripMenuItem
            // 
            configuracionGeneralToolStripMenuItem.Name = "configuracionGeneralToolStripMenuItem";
            configuracionGeneralToolStripMenuItem.Size = new Size(142, 22);
            configuracionGeneralToolStripMenuItem.Text = "Ajustes";
            configuracionGeneralToolStripMenuItem.Click += BtnConfiguracionGeneral_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(139, 6);
            // 
            // parametricasToolStripMenuItem
            // 
            parametricasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aBMCondicionDeIvaToolStripMenuItem, ingresoBrutoToolStripMenuItem, provinciaToolStripMenuItem, localidadToolStripMenuItem, toolStripMenuItem3, aBMGrupoToolStripMenuItem, formularioToolStripMenuItem });
            parametricasToolStripMenuItem.Name = "parametricasToolStripMenuItem";
            parametricasToolStripMenuItem.Size = new Size(142, 22);
            parametricasToolStripMenuItem.Text = "Parametricas";
            // 
            // aBMCondicionDeIvaToolStripMenuItem
            // 
            aBMCondicionDeIvaToolStripMenuItem.Name = "aBMCondicionDeIvaToolStripMenuItem";
            aBMCondicionDeIvaToolStripMenuItem.Size = new Size(163, 22);
            aBMCondicionDeIvaToolStripMenuItem.Text = "Condición de Iva";
            aBMCondicionDeIvaToolStripMenuItem.Click += ABMCondicionDeIvaToolStripMenuItem_Click;
            // 
            // ingresoBrutoToolStripMenuItem
            // 
            ingresoBrutoToolStripMenuItem.Name = "ingresoBrutoToolStripMenuItem";
            ingresoBrutoToolStripMenuItem.Size = new Size(163, 22);
            ingresoBrutoToolStripMenuItem.Text = "Ingreso Bruto";
            ingresoBrutoToolStripMenuItem.Click += IngresoBrutoToolStripMenuItem_Click;
            // 
            // provinciaToolStripMenuItem
            // 
            provinciaToolStripMenuItem.Name = "provinciaToolStripMenuItem";
            provinciaToolStripMenuItem.Size = new Size(163, 22);
            provinciaToolStripMenuItem.Text = "Provincia";
            provinciaToolStripMenuItem.Click += provinciaToolStripMenuItem_Click;
            // 
            // localidadToolStripMenuItem
            // 
            localidadToolStripMenuItem.Name = "localidadToolStripMenuItem";
            localidadToolStripMenuItem.Size = new Size(163, 22);
            localidadToolStripMenuItem.Text = "Localidad";
            localidadToolStripMenuItem.Click += localidadToolStripMenuItem_Click;
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(160, 6);
            // 
            // aBMGrupoToolStripMenuItem
            // 
            aBMGrupoToolStripMenuItem.Name = "aBMGrupoToolStripMenuItem";
            aBMGrupoToolStripMenuItem.Size = new Size(163, 22);
            aBMGrupoToolStripMenuItem.Text = "Grupo";
            aBMGrupoToolStripMenuItem.Click += ABMGrupoToolStripMenuItem_Click;
            // 
            // formularioToolStripMenuItem
            // 
            formularioToolStripMenuItem.Name = "formularioToolStripMenuItem";
            formularioToolStripMenuItem.Size = new Size(163, 22);
            formularioToolStripMenuItem.Text = "Formulario";
            formularioToolStripMenuItem.Click += formularioToolStripMenuItem_Click;
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(51, 19);
            salirToolStripMenuItem.Text = "Volver";
            salirToolStripMenuItem.Click += BtnSalir_Click;
            // 
            // btnUsuario
            // 
            btnUsuario.Dock = DockStyle.Top;
            btnUsuario.FlatAppearance.BorderSize = 0;
            btnUsuario.FlatStyle = FlatStyle.Flat;
            btnUsuario.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            btnUsuario.IconColor = Color.Gray;
            btnUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnUsuario.IconSize = 30;
            btnUsuario.ImageAlign = ContentAlignment.MiddleLeft;
            btnUsuario.Location = new Point(0, 92);
            btnUsuario.Name = "btnUsuario";
            btnUsuario.Size = new Size(124, 46);
            btnUsuario.TabIndex = 6;
            btnUsuario.Text = "Usuario";
            btnUsuario.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUsuario.UseVisualStyleBackColor = true;
            btnUsuario.Click += BtnUsuario_Click;
            // 
            // _00020_ModuloSeguridad
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(pnlContenedor);
            Controls.Add(menuStrip1);
            DoubleBuffered = true;
            MainMenuStrip = menuStrip1;
            Name = "_00020_ModuloSeguridad";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Ajustes del Sistema";
            Controls.SetChildIndex(pnlTitulo, 0);
            Controls.SetChildIndex(menuStrip1, 0);
            Controls.SetChildIndex(pnlMenuLateral, 0);
            Controls.SetChildIndex(pnlContenedor, 0);
            pnlMenuLateral.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel pnlContenedor;
        private FontAwesome.Sharp.IconButton btnEmprea;
        private FontAwesome.Sharp.IconButton btnPersona;
        private FontAwesome.Sharp.IconButton btnConfiguracionGeneral;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem empresaToolStripMenuItem;
        private ToolStripMenuItem aBMEmpresaToolStripMenuItem;
        private ToolStripMenuItem nuevaEmpresaToolStripMenuItem;
        private ToolStripMenuItem personaToolStripMenuItem;
        private ToolStripMenuItem aBMPersonaToolStripMenuItem;
        private ToolStripMenuItem nuevaPersonaToolStripMenuItem;
        private ToolStripMenuItem configuracionToolStripMenuItem;
        private ToolStripMenuItem parametricasToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripMenuItem usuariosToolStripMenuItem;
        private ToolStripMenuItem aBMCondicionDeIvaToolStripMenuItem;
        private FontAwesome.Sharp.IconButton btnUsuario;
        private ToolStripMenuItem configuracionGeneralToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem aBMGrupoToolStripMenuItem;
        private ToolStripMenuItem provinciaToolStripMenuItem;
        private ToolStripMenuItem localidadToolStripMenuItem;
        private ToolStripMenuItem ingresoBrutoToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem3;
        private ToolStripMenuItem formularioToolStripMenuItem;
        public ToolStripMenuItem salirToolStripMenuItem;
    }
}