namespace Login
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.menu = new System.Windows.Forms.MenuStrip();
            this.moduloReparacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionarClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionarVehiculosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionarReparacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moduloAdministracionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionarUsuariosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionarServiciosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionarMecanicosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionarRepuestosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionarTipoVehiculosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Saludo = new System.Windows.Forms.Label();
            this.CerrarSecion = new System.Windows.Forms.Button();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.moduloReparacionToolStripMenuItem,
            this.moduloAdministracionToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(618, 24);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // moduloReparacionToolStripMenuItem
            // 
            this.moduloReparacionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionarClientesToolStripMenuItem,
            this.gestionarVehiculosToolStripMenuItem,
            this.gestionarReparacionToolStripMenuItem});
            this.moduloReparacionToolStripMenuItem.Name = "moduloReparacionToolStripMenuItem";
            this.moduloReparacionToolStripMenuItem.Size = new System.Drawing.Size(123, 20);
            this.moduloReparacionToolStripMenuItem.Text = "Modulo Reparacion";
            // 
            // gestionarClientesToolStripMenuItem
            // 
            this.gestionarClientesToolStripMenuItem.Name = "gestionarClientesToolStripMenuItem";
            this.gestionarClientesToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.gestionarClientesToolStripMenuItem.Text = "Gestionar Clientes";
            this.gestionarClientesToolStripMenuItem.Click += new System.EventHandler(this.gestionarClientesToolStripMenuItem_Click);
            // 
            // gestionarVehiculosToolStripMenuItem
            // 
            this.gestionarVehiculosToolStripMenuItem.Name = "gestionarVehiculosToolStripMenuItem";
            this.gestionarVehiculosToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.gestionarVehiculosToolStripMenuItem.Text = "Gestionar Vehiculos";
            this.gestionarVehiculosToolStripMenuItem.Click += new System.EventHandler(this.gestionarVehiculosToolStripMenuItem_Click);
            // 
            // gestionarReparacionToolStripMenuItem
            // 
            this.gestionarReparacionToolStripMenuItem.Name = "gestionarReparacionToolStripMenuItem";
            this.gestionarReparacionToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.gestionarReparacionToolStripMenuItem.Text = "Gestionar Reparacion";
            this.gestionarReparacionToolStripMenuItem.Click += new System.EventHandler(this.gestionarReparacionToolStripMenuItem_Click);
            // 
            // moduloAdministracionToolStripMenuItem
            // 
            this.moduloAdministracionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionarUsuariosToolStripMenuItem1,
            this.gestionarServiciosToolStripMenuItem,
            this.gestionarMecanicosToolStripMenuItem,
            this.gestionarRepuestosToolStripMenuItem,
            this.gestionarTipoVehiculosToolStripMenuItem});
            this.moduloAdministracionToolStripMenuItem.Name = "moduloAdministracionToolStripMenuItem";
            this.moduloAdministracionToolStripMenuItem.Size = new System.Drawing.Size(145, 20);
            this.moduloAdministracionToolStripMenuItem.Text = "Modulo Administracion";
            // 
            // gestionarUsuariosToolStripMenuItem1
            // 
            this.gestionarUsuariosToolStripMenuItem1.Name = "gestionarUsuariosToolStripMenuItem1";
            this.gestionarUsuariosToolStripMenuItem1.Size = new System.Drawing.Size(204, 22);
            this.gestionarUsuariosToolStripMenuItem1.Text = "Gestionar Usuarios";
            this.gestionarUsuariosToolStripMenuItem1.Click += new System.EventHandler(this.gestionarUsuariosToolStripMenuItem1_Click);
            // 
            // gestionarServiciosToolStripMenuItem
            // 
            this.gestionarServiciosToolStripMenuItem.Name = "gestionarServiciosToolStripMenuItem";
            this.gestionarServiciosToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.gestionarServiciosToolStripMenuItem.Text = "Gestionar Servicios";
            this.gestionarServiciosToolStripMenuItem.Click += new System.EventHandler(this.gestionarServiciosToolStripMenuItem_Click);
            // 
            // gestionarMecanicosToolStripMenuItem
            // 
            this.gestionarMecanicosToolStripMenuItem.Name = "gestionarMecanicosToolStripMenuItem";
            this.gestionarMecanicosToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.gestionarMecanicosToolStripMenuItem.Text = "Gestionar Mecanicos";
            this.gestionarMecanicosToolStripMenuItem.Click += new System.EventHandler(this.gestionarMecanicosToolStripMenuItem_Click);
            // 
            // gestionarRepuestosToolStripMenuItem
            // 
            this.gestionarRepuestosToolStripMenuItem.Name = "gestionarRepuestosToolStripMenuItem";
            this.gestionarRepuestosToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.gestionarRepuestosToolStripMenuItem.Text = "Gestionar Repuestos";
            this.gestionarRepuestosToolStripMenuItem.Click += new System.EventHandler(this.gestionarRepuestosToolStripMenuItem_Click);
            // 
            // gestionarTipoVehiculosToolStripMenuItem
            // 
            this.gestionarTipoVehiculosToolStripMenuItem.Name = "gestionarTipoVehiculosToolStripMenuItem";
            this.gestionarTipoVehiculosToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.gestionarTipoVehiculosToolStripMenuItem.Text = "Gestionar Tipo Vehiculos";
            this.gestionarTipoVehiculosToolStripMenuItem.Click += new System.EventHandler(this.gestionarTipoVehiculosToolStripMenuItem_Click);
            // 
            // Saludo
            // 
            this.Saludo.AutoSize = true;
            this.Saludo.Location = new System.Drawing.Point(383, 6);
            this.Saludo.Name = "Saludo";
            this.Saludo.Size = new System.Drawing.Size(63, 13);
            this.Saludo.TabIndex = 1;
            this.Saludo.Text = "Bienvenido ";
            // 
            // CerrarSecion
            // 
            this.CerrarSecion.Location = new System.Drawing.Point(469, 1);
            this.CerrarSecion.Name = "CerrarSecion";
            this.CerrarSecion.Size = new System.Drawing.Size(88, 23);
            this.CerrarSecion.TabIndex = 2;
            this.CerrarSecion.Text = "Cerrar Secion";
            this.CerrarSecion.UseVisualStyleBackColor = true;
            this.CerrarSecion.Click += new System.EventHandler(this.CerrarSecion_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(618, 393);
            this.Controls.Add(this.CerrarSecion);
            this.Controls.Add(this.Saludo);
            this.Controls.Add(this.menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menu;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.Label Saludo;
        private System.Windows.Forms.Button CerrarSecion;
        private System.Windows.Forms.ToolStripMenuItem moduloReparacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionarClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionarVehiculosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moduloAdministracionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionarUsuariosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem gestionarServiciosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionarMecanicosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionarRepuestosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionarTipoVehiculosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionarReparacionToolStripMenuItem;
    }
}