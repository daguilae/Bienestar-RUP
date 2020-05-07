namespace ERP_RUP
{
	partial class ERP_RUP
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
			this.menuStrip = new System.Windows.Forms.MenuStrip();
			this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.hRMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.mRPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.sCMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.fRMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.seguridadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.menuStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip
			// 
			this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.hRMToolStripMenuItem,
            this.fRMToolStripMenuItem,
            this.sCMToolStripMenuItem,
            this.mRPToolStripMenuItem,
            this.seguridadToolStripMenuItem,
            this.ayudaToolStripMenuItem});
			this.menuStrip.Location = new System.Drawing.Point(0, 0);
			this.menuStrip.Name = "menuStrip";
			this.menuStrip.Size = new System.Drawing.Size(632, 24);
			this.menuStrip.TabIndex = 0;
			this.menuStrip.Text = "MenuStrip";
			// 
			// inicioToolStripMenuItem
			// 
			this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
			this.inicioToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
			this.inicioToolStripMenuItem.Text = "Inicio";
			// 
			// hRMToolStripMenuItem
			// 
			this.hRMToolStripMenuItem.Name = "hRMToolStripMenuItem";
			this.hRMToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
			this.hRMToolStripMenuItem.Text = "HRM";
			this.hRMToolStripMenuItem.Click += new System.EventHandler(this.HRMToolStripMenuItem_Click);
			// 
			// mRPToolStripMenuItem
			// 
			this.mRPToolStripMenuItem.Name = "mRPToolStripMenuItem";
			this.mRPToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.mRPToolStripMenuItem.Text = "MRP";
			this.mRPToolStripMenuItem.Click += new System.EventHandler(this.MRPToolStripMenuItem_Click);
			// 
			// sCMToolStripMenuItem
			// 
			this.sCMToolStripMenuItem.Name = "sCMToolStripMenuItem";
			this.sCMToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.sCMToolStripMenuItem.Text = "SCM";
			this.sCMToolStripMenuItem.Click += new System.EventHandler(this.SCMToolStripMenuItem_Click);
			// 
			// fRMToolStripMenuItem
			// 
			this.fRMToolStripMenuItem.Name = "fRMToolStripMenuItem";
			this.fRMToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
			this.fRMToolStripMenuItem.Text = "FRM";
			this.fRMToolStripMenuItem.Click += new System.EventHandler(this.FRMToolStripMenuItem_Click);
			// 
			// seguridadToolStripMenuItem
			// 
			this.seguridadToolStripMenuItem.Name = "seguridadToolStripMenuItem";
			this.seguridadToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
			this.seguridadToolStripMenuItem.Text = "Seguridad";
			// 
			// ayudaToolStripMenuItem
			// 
			this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
			this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
			this.ayudaToolStripMenuItem.Text = "Ayuda";
			// 
			// ERP_RUP
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(632, 453);
			this.Controls.Add(this.menuStrip);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.IsMdiContainer = true;
			this.MainMenuStrip = this.menuStrip;
			this.Name = "ERP_RUP";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ERP_RUP";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.ERP_RUP_Load);
			this.menuStrip.ResumeLayout(false);
			this.menuStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		#endregion


		private System.Windows.Forms.MenuStrip menuStrip;
		private System.Windows.Forms.ToolTip toolTip;
		private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem hRMToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem mRPToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem sCMToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fRMToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem seguridadToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
	}
}



