namespace CapaVistaMRP
{
    partial class MDI_MRP
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDI_MRP));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printSetupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDeProduccionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoEmpleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoRecetasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoProcesosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoConfiguracionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoInvetarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordenesPendientesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.productosEnProcesoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pedidosEspecialesCRMToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ordenDeProduccionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.contentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seguridadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.polizaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.seguridadToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.gestionDeProduccionToolStripMenuItem,
            this.mantenimientosToolStripMenuItem,
            this.toolsMenu,
            this.reportesToolStripMenuItem,
            this.helpMenu,
            this.seguridadToolStripMenuItem,
            this.polizaToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1181, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator3,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator4,
            this.printToolStripMenuItem,
            this.printPreviewToolStripMenuItem,
            this.printSetupToolStripMenuItem,
            this.toolStripSeparator5,
            this.exitToolStripMenuItem});
            this.fileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(73, 24);
            this.fileMenu.Text = "&Archivo";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.newToolStripMenuItem.Text = "&Nuevo";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.ShowNewForm);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.openToolStripMenuItem.Text = "&Abrir";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenFile);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(257, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.saveToolStripMenuItem.Text = "&Guardar";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.saveAsToolStripMenuItem.Text = "Guardar &como";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.SaveAsToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(257, 6);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripMenuItem.Image")));
            this.printToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.printToolStripMenuItem.Text = "&Imprimir";
            // 
            // printPreviewToolStripMenuItem
            // 
            this.printPreviewToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printPreviewToolStripMenuItem.Image")));
            this.printPreviewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
            this.printPreviewToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.printPreviewToolStripMenuItem.Text = "&Vista previa de impresión";
            // 
            // printSetupToolStripMenuItem
            // 
            this.printSetupToolStripMenuItem.Name = "printSetupToolStripMenuItem";
            this.printSetupToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.printSetupToolStripMenuItem.Text = "Configurar impresión";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(257, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.exitToolStripMenuItem.Text = "&Salir";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolsStripMenuItem_Click);
            // 
            // gestionDeProduccionToolStripMenuItem
            // 
            this.gestionDeProduccionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientoEmpleadosToolStripMenuItem,
            this.mantenimientoRecetasToolStripMenuItem,
            this.mantenimientoProcesosToolStripMenuItem,
            this.mantenimientoConfiguracionToolStripMenuItem,
            this.mantenimientoInvetarioToolStripMenuItem});
            this.gestionDeProduccionToolStripMenuItem.Name = "gestionDeProduccionToolStripMenuItem";
            this.gestionDeProduccionToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.gestionDeProduccionToolStripMenuItem.Text = "MRP";
            this.gestionDeProduccionToolStripMenuItem.Click += new System.EventHandler(this.GestionDeProduccionToolStripMenuItem_Click);
            // 
            // mantenimientoEmpleadosToolStripMenuItem
            // 
            this.mantenimientoEmpleadosToolStripMenuItem.Name = "mantenimientoEmpleadosToolStripMenuItem";
            this.mantenimientoEmpleadosToolStripMenuItem.Size = new System.Drawing.Size(290, 26);
            this.mantenimientoEmpleadosToolStripMenuItem.Text = "Mantenimiento Empleados";
            this.mantenimientoEmpleadosToolStripMenuItem.Click += new System.EventHandler(this.MantenimientoEmpleadosToolStripMenuItem_Click);
            // 
            // mantenimientoRecetasToolStripMenuItem
            // 
            this.mantenimientoRecetasToolStripMenuItem.Name = "mantenimientoRecetasToolStripMenuItem";
            this.mantenimientoRecetasToolStripMenuItem.Size = new System.Drawing.Size(290, 26);
            this.mantenimientoRecetasToolStripMenuItem.Text = "Mantenimiento Recetas";
            this.mantenimientoRecetasToolStripMenuItem.Click += new System.EventHandler(this.MantenimientoRecetasToolStripMenuItem_Click);
            // 
            // mantenimientoProcesosToolStripMenuItem
            // 
            this.mantenimientoProcesosToolStripMenuItem.Name = "mantenimientoProcesosToolStripMenuItem";
            this.mantenimientoProcesosToolStripMenuItem.Size = new System.Drawing.Size(290, 26);
            this.mantenimientoProcesosToolStripMenuItem.Text = "Mantenimiento Procesos";
            this.mantenimientoProcesosToolStripMenuItem.Click += new System.EventHandler(this.MantenimientoProcesosToolStripMenuItem_Click);
            // 
            // mantenimientoConfiguracionToolStripMenuItem
            // 
            this.mantenimientoConfiguracionToolStripMenuItem.Name = "mantenimientoConfiguracionToolStripMenuItem";
            this.mantenimientoConfiguracionToolStripMenuItem.Size = new System.Drawing.Size(290, 26);
            this.mantenimientoConfiguracionToolStripMenuItem.Text = "Mantenimiento Configuracion";
            this.mantenimientoConfiguracionToolStripMenuItem.Click += new System.EventHandler(this.MantenimientoConfiguracionToolStripMenuItem_Click);
            // 
            // mantenimientoInvetarioToolStripMenuItem
            // 
            this.mantenimientoInvetarioToolStripMenuItem.Name = "mantenimientoInvetarioToolStripMenuItem";
            this.mantenimientoInvetarioToolStripMenuItem.Size = new System.Drawing.Size(290, 26);
            this.mantenimientoInvetarioToolStripMenuItem.Text = "Mantenimiento Invetario";
            this.mantenimientoInvetarioToolStripMenuItem.Click += new System.EventHandler(this.MantenimientoInvetarioToolStripMenuItem_Click);
            // 
            // mantenimientosToolStripMenuItem
            // 
            this.mantenimientosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ordenesPendientesToolStripMenuItem1,
            this.productosEnProcesoToolStripMenuItem1,
            this.pedidosEspecialesCRMToolStripMenuItem1,
            this.ordenDeProduccionToolStripMenuItem});
            this.mantenimientosToolStripMenuItem.Name = "mantenimientosToolStripMenuItem";
            this.mantenimientosToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.mantenimientosToolStripMenuItem.Text = "Procesos";
            this.mantenimientosToolStripMenuItem.Click += new System.EventHandler(this.MantenimientosToolStripMenuItem_Click);
            // 
            // ordenesPendientesToolStripMenuItem1
            // 
            this.ordenesPendientesToolStripMenuItem1.Name = "ordenesPendientesToolStripMenuItem1";
            this.ordenesPendientesToolStripMenuItem1.Size = new System.Drawing.Size(251, 26);
            this.ordenesPendientesToolStripMenuItem1.Text = "Ordenes Pendientes";
            this.ordenesPendientesToolStripMenuItem1.Click += new System.EventHandler(this.OrdenesPendientesToolStripMenuItem1_Click);
            // 
            // productosEnProcesoToolStripMenuItem1
            // 
            this.productosEnProcesoToolStripMenuItem1.Name = "productosEnProcesoToolStripMenuItem1";
            this.productosEnProcesoToolStripMenuItem1.Size = new System.Drawing.Size(251, 26);
            this.productosEnProcesoToolStripMenuItem1.Text = "Productos en Proceso";
            this.productosEnProcesoToolStripMenuItem1.Click += new System.EventHandler(this.ProductosEnProcesoToolStripMenuItem1_Click);
            // 
            // pedidosEspecialesCRMToolStripMenuItem1
            // 
            this.pedidosEspecialesCRMToolStripMenuItem1.Name = "pedidosEspecialesCRMToolStripMenuItem1";
            this.pedidosEspecialesCRMToolStripMenuItem1.Size = new System.Drawing.Size(251, 26);
            this.pedidosEspecialesCRMToolStripMenuItem1.Text = "Pedidos Especiales CRM";
            this.pedidosEspecialesCRMToolStripMenuItem1.Click += new System.EventHandler(this.PedidosEspecialesCRMToolStripMenuItem1_Click);
            // 
            // ordenDeProduccionToolStripMenuItem
            // 
            this.ordenDeProduccionToolStripMenuItem.Name = "ordenDeProduccionToolStripMenuItem";
            this.ordenDeProduccionToolStripMenuItem.Size = new System.Drawing.Size(251, 26);
            this.ordenDeProduccionToolStripMenuItem.Text = "Orden de Produccion";
            this.ordenDeProduccionToolStripMenuItem.Click += new System.EventHandler(this.OrdenDeProduccionToolStripMenuItem_Click);
            // 
            // toolsMenu
            // 
            this.toolsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seguridadToolStripMenuItem1});
            this.toolsMenu.Name = "toolsMenu";
            this.toolsMenu.Size = new System.Drawing.Size(112, 24);
            this.toolsMenu.Text = "&Herramientas";
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // helpMenu
            // 
            this.helpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contentsToolStripMenuItem,
            this.indexToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.toolStripSeparator8,
            this.aboutToolStripMenuItem});
            this.helpMenu.Name = "helpMenu";
            this.helpMenu.Size = new System.Drawing.Size(65, 24);
            this.helpMenu.Text = "Ay&uda";
            // 
            // contentsToolStripMenuItem
            // 
            this.contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
            this.contentsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F1)));
            this.contentsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.contentsToolStripMenuItem.Text = "&Contenido";
            // 
            // indexToolStripMenuItem
            // 
            this.indexToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("indexToolStripMenuItem.Image")));
            this.indexToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
            this.indexToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.indexToolStripMenuItem.Text = "&Índice";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("searchToolStripMenuItem.Image")));
            this.searchToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.searchToolStripMenuItem.Text = "&Buscar";
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(221, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.aboutToolStripMenuItem.Text = "&Acerca de... ...";
            // 
            // seguridadToolStripMenuItem
            // 
            this.seguridadToolStripMenuItem.Name = "seguridadToolStripMenuItem";
            this.seguridadToolStripMenuItem.Size = new System.Drawing.Size(91, 24);
            this.seguridadToolStripMenuItem.Text = "Seguridad";
            this.seguridadToolStripMenuItem.Click += new System.EventHandler(this.SeguridadToolStripMenuItem_Click);
            // 
            // polizaToolStripMenuItem
            // 
            this.polizaToolStripMenuItem.Name = "polizaToolStripMenuItem";
            this.polizaToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.polizaToolStripMenuItem.Text = "Poliza";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lblUsuario});
            this.statusStrip1.Location = new System.Drawing.Point(0, 600);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1181, 26);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(57, 20);
            this.toolStripStatusLabel1.Text = "usuario";
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.ToolStripStatusLabel1_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(18, 20);
            this.lblUsuario.Text = "...";
            // 
            // seguridadToolStripMenuItem1
            // 
            this.seguridadToolStripMenuItem1.Name = "seguridadToolStripMenuItem1";
            this.seguridadToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.seguridadToolStripMenuItem1.Text = "Seguridad";
            // 
            // MDI_MRP
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1181, 626);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MDI_MRP";
            this.Text = "MDI_MRP";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MDI_MRP_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem printSetupToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printPreviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsMenu;
        private System.Windows.Forms.ToolStripMenuItem helpMenu;
        private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem gestionDeProduccionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoEmpleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoRecetasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoProcesosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoConfiguracionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordenesPendientesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem productosEnProcesoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pedidosEspecialesCRMToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem seguridadToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblUsuario;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem polizaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoInvetarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordenDeProduccionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seguridadToolStripMenuItem1;
    }
}



