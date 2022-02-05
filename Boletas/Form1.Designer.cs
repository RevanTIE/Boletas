namespace Boletas
{
    partial class Form1
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelPrincipal = new System.Windows.Forms.SplitContainer();
            this.btnMatrimonios = new System.Windows.Forms.Button();
            this.btnComuniones = new System.Windows.Forms.Button();
            this.btnConfirmaciones = new System.Windows.Forms.Button();
            this.btnBautizos = new System.Windows.Forms.Button();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boletasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bautizosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.confirmacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.primerasComunionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matrimoniosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.respaldosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.respaldarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restaurarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.catálogoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.catequistasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.párrocoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ministrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parroquiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblMensaje = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.panelPrincipal)).BeginInit();
            this.panelPrincipal.Panel1.SuspendLayout();
            this.panelPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.mainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelPrincipal.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.panelPrincipal, "panelPrincipal");
            this.panelPrincipal.Name = "panelPrincipal";
            // 
            // panelPrincipal.Panel1
            // 
            this.panelPrincipal.Panel1.BackColor = System.Drawing.Color.Silver;
            this.panelPrincipal.Panel1.Controls.Add(this.btnMatrimonios);
            this.panelPrincipal.Panel1.Controls.Add(this.btnComuniones);
            this.panelPrincipal.Panel1.Controls.Add(this.btnConfirmaciones);
            this.panelPrincipal.Panel1.Controls.Add(this.btnBautizos);
            this.panelPrincipal.Panel1.Controls.Add(this.picLogo);
            // 
            // panelPrincipal.Panel2
            // 
            resources.ApplyResources(this.panelPrincipal.Panel2, "panelPrincipal.Panel2");
            // 
            // btnMatrimonios
            // 
            this.btnMatrimonios.BackColor = System.Drawing.Color.White;
            this.btnMatrimonios.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnMatrimonios, "btnMatrimonios");
            this.btnMatrimonios.Name = "btnMatrimonios";
            this.btnMatrimonios.UseVisualStyleBackColor = false;
            this.btnMatrimonios.Click += new System.EventHandler(this.btnMatrimonios_Click);
            // 
            // btnComuniones
            // 
            this.btnComuniones.BackColor = System.Drawing.Color.Salmon;
            this.btnComuniones.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnComuniones, "btnComuniones");
            this.btnComuniones.Name = "btnComuniones";
            this.btnComuniones.UseVisualStyleBackColor = false;
            this.btnComuniones.Click += new System.EventHandler(this.btnComuniones_Click);
            // 
            // btnConfirmaciones
            // 
            this.btnConfirmaciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnConfirmaciones.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnConfirmaciones, "btnConfirmaciones");
            this.btnConfirmaciones.Name = "btnConfirmaciones";
            this.btnConfirmaciones.UseVisualStyleBackColor = false;
            this.btnConfirmaciones.Click += new System.EventHandler(this.btnConfirmaciones_Click);
            // 
            // btnBautizos
            // 
            this.btnBautizos.BackColor = System.Drawing.Color.SkyBlue;
            this.btnBautizos.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnBautizos, "btnBautizos");
            this.btnBautizos.Name = "btnBautizos";
            this.btnBautizos.UseVisualStyleBackColor = false;
            this.btnBautizos.Click += new System.EventHandler(this.btnBautizos_Click);
            // 
            // picLogo
            // 
            resources.ApplyResources(this.picLogo, "picLogo");
            this.picLogo.Image = global::Boletas.Properties.Resources.parroquia;
            this.picLogo.Name = "picLogo";
            this.picLogo.TabStop = false;
            this.picLogo.Click += new System.EventHandler(this.picLogo_Click);
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.administrarToolStripMenuItem,
            this.catálogoToolStripMenuItem,
            this.configuraciónToolStripMenuItem,
            this.ayudaToolStripMenuItem,
            this.cerrarSesiónToolStripMenuItem});
            resources.ApplyResources(this.mainMenu, "mainMenu");
            this.mainMenu.Name = "mainMenu";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            resources.ApplyResources(this.inicioToolStripMenuItem, "inicioToolStripMenuItem");
            this.inicioToolStripMenuItem.Click += new System.EventHandler(this.inicioToolStripMenuItem_Click);
            // 
            // administrarToolStripMenuItem
            // 
            this.administrarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.boletasToolStripMenuItem,
            this.respaldosToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.administrarToolStripMenuItem.Name = "administrarToolStripMenuItem";
            resources.ApplyResources(this.administrarToolStripMenuItem, "administrarToolStripMenuItem");
            // 
            // boletasToolStripMenuItem
            // 
            this.boletasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bautizosToolStripMenuItem,
            this.confirmacionesToolStripMenuItem,
            this.primerasComunionesToolStripMenuItem,
            this.matrimoniosToolStripMenuItem});
            this.boletasToolStripMenuItem.Name = "boletasToolStripMenuItem";
            resources.ApplyResources(this.boletasToolStripMenuItem, "boletasToolStripMenuItem");
            // 
            // bautizosToolStripMenuItem
            // 
            this.bautizosToolStripMenuItem.Name = "bautizosToolStripMenuItem";
            resources.ApplyResources(this.bautizosToolStripMenuItem, "bautizosToolStripMenuItem");
            this.bautizosToolStripMenuItem.Click += new System.EventHandler(this.bautizosToolStripMenuItem_Click);
            // 
            // confirmacionesToolStripMenuItem
            // 
            this.confirmacionesToolStripMenuItem.Name = "confirmacionesToolStripMenuItem";
            resources.ApplyResources(this.confirmacionesToolStripMenuItem, "confirmacionesToolStripMenuItem");
            this.confirmacionesToolStripMenuItem.Click += new System.EventHandler(this.confirmacionesToolStripMenuItem_Click);
            // 
            // primerasComunionesToolStripMenuItem
            // 
            this.primerasComunionesToolStripMenuItem.Name = "primerasComunionesToolStripMenuItem";
            resources.ApplyResources(this.primerasComunionesToolStripMenuItem, "primerasComunionesToolStripMenuItem");
            this.primerasComunionesToolStripMenuItem.Click += new System.EventHandler(this.primerasComunionesToolStripMenuItem_Click);
            // 
            // matrimoniosToolStripMenuItem
            // 
            this.matrimoniosToolStripMenuItem.Name = "matrimoniosToolStripMenuItem";
            resources.ApplyResources(this.matrimoniosToolStripMenuItem, "matrimoniosToolStripMenuItem");
            this.matrimoniosToolStripMenuItem.Click += new System.EventHandler(this.matrimoniosToolStripMenuItem_Click);
            // 
            // respaldosToolStripMenuItem
            // 
            this.respaldosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.respaldarToolStripMenuItem,
            this.restaurarToolStripMenuItem});
            this.respaldosToolStripMenuItem.Name = "respaldosToolStripMenuItem";
            resources.ApplyResources(this.respaldosToolStripMenuItem, "respaldosToolStripMenuItem");
            // 
            // respaldarToolStripMenuItem
            // 
            this.respaldarToolStripMenuItem.Name = "respaldarToolStripMenuItem";
            resources.ApplyResources(this.respaldarToolStripMenuItem, "respaldarToolStripMenuItem");
            this.respaldarToolStripMenuItem.Click += new System.EventHandler(this.respaldarToolStripMenuItem_Click);
            // 
            // restaurarToolStripMenuItem
            // 
            this.restaurarToolStripMenuItem.Name = "restaurarToolStripMenuItem";
            resources.ApplyResources(this.restaurarToolStripMenuItem, "restaurarToolStripMenuItem");
            this.restaurarToolStripMenuItem.Click += new System.EventHandler(this.restaurarToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            resources.ApplyResources(this.salirToolStripMenuItem, "salirToolStripMenuItem");
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // catálogoToolStripMenuItem
            // 
            this.catálogoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.empleadosToolStripMenuItem,
            this.catequistasToolStripMenuItem,
            this.párrocoToolStripMenuItem,
            this.ministrosToolStripMenuItem,
            this.estadosToolStripMenuItem});
            this.catálogoToolStripMenuItem.Name = "catálogoToolStripMenuItem";
            resources.ApplyResources(this.catálogoToolStripMenuItem, "catálogoToolStripMenuItem");
            // 
            // empleadosToolStripMenuItem
            // 
            this.empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
            resources.ApplyResources(this.empleadosToolStripMenuItem, "empleadosToolStripMenuItem");
            this.empleadosToolStripMenuItem.Click += new System.EventHandler(this.empleadosToolStripMenuItem_Click);
            // 
            // catequistasToolStripMenuItem
            // 
            this.catequistasToolStripMenuItem.Name = "catequistasToolStripMenuItem";
            resources.ApplyResources(this.catequistasToolStripMenuItem, "catequistasToolStripMenuItem");
            this.catequistasToolStripMenuItem.Click += new System.EventHandler(this.catequistasToolStripMenuItem_Click);
            // 
            // párrocoToolStripMenuItem
            // 
            this.párrocoToolStripMenuItem.Name = "párrocoToolStripMenuItem";
            resources.ApplyResources(this.párrocoToolStripMenuItem, "párrocoToolStripMenuItem");
            this.párrocoToolStripMenuItem.Click += new System.EventHandler(this.párrocoToolStripMenuItem_Click);
            // 
            // estadosToolStripMenuItem
            // 
            this.estadosToolStripMenuItem.Name = "estadosToolStripMenuItem";
            resources.ApplyResources(this.estadosToolStripMenuItem, "estadosToolStripMenuItem");
            this.estadosToolStripMenuItem.Click += new System.EventHandler(this.estadosToolStripMenuItem_Click);
            // 
            // ministrosToolStripMenuItem
            // 
            this.ministrosToolStripMenuItem.Name = "ministrosToolStripMenuItem";
            resources.ApplyResources(this.ministrosToolStripMenuItem, "ministrosToolStripMenuItem");
            this.ministrosToolStripMenuItem.Click += new System.EventHandler(this.ministrosToolStripMenuItem_Click);
            // 
            // configuraciónToolStripMenuItem
            // 
            this.configuraciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuariosToolStripMenuItem,
            this.parroquiaToolStripMenuItem});
            this.configuraciónToolStripMenuItem.Name = "configuraciónToolStripMenuItem";
            resources.ApplyResources(this.configuraciónToolStripMenuItem, "configuraciónToolStripMenuItem");
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            resources.ApplyResources(this.usuariosToolStripMenuItem, "usuariosToolStripMenuItem");
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // parroquiaToolStripMenuItem
            // 
            this.parroquiaToolStripMenuItem.Name = "parroquiaToolStripMenuItem";
            resources.ApplyResources(this.parroquiaToolStripMenuItem, "parroquiaToolStripMenuItem");
            this.parroquiaToolStripMenuItem.Click += new System.EventHandler(this.parroquiaToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            resources.ApplyResources(this.ayudaToolStripMenuItem, "ayudaToolStripMenuItem");
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            resources.ApplyResources(this.acercaDeToolStripMenuItem, "acercaDeToolStripMenuItem");
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // cerrarSesiónToolStripMenuItem
            // 
            this.cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            resources.ApplyResources(this.cerrarSesiónToolStripMenuItem, "cerrarSesiónToolStripMenuItem");
            this.cerrarSesiónToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesiónToolStripMenuItem_Click);
            // 
            // lblMensaje
            // 
            resources.ApplyResources(this.lblMensaje, "lblMensaje");
            this.lblMensaje.Name = "lblMensaje";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.panelPrincipal);
            this.Controls.Add(this.mainMenu);
            this.MainMenuStrip = this.mainMenu;
            this.Name = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelPrincipal.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelPrincipal)).EndInit();
            this.panelPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem boletasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bautizosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem confirmacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem primerasComunionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem matrimoniosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem respaldosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem respaldarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restaurarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem catálogoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuraciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem catequistasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem párrocoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parroquiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.SplitContainer panelPrincipal;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Button btnMatrimonios;
        private System.Windows.Forms.Button btnComuniones;
        private System.Windows.Forms.Button btnConfirmaciones;
        private System.Windows.Forms.Button btnBautizos;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.ToolStripMenuItem ministrosToolStripMenuItem;
    }
}

