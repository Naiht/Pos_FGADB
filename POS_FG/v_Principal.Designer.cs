namespace POS_FG
{
    partial class v_Principal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ventaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creditoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gatosExternosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosSuministradosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gastosExternoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteCreditoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ventaToolStripMenuItem,
            this.verToolStripMenuItem,
            this.ingresarToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.cerrarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1195, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ventaToolStripMenuItem
            // 
            this.ventaToolStripMenuItem.Name = "ventaToolStripMenuItem";
            this.ventaToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.ventaToolStripMenuItem.Text = "Venta";
            this.ventaToolStripMenuItem.Click += new System.EventHandler(this.ventaToolStripMenuItem_Click);
            // 
            // verToolStripMenuItem
            // 
            this.verToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.facturasToolStripMenuItem,
            this.creditoToolStripMenuItem,
            this.gatosExternosToolStripMenuItem,
            this.productosSuministradosToolStripMenuItem});
            this.verToolStripMenuItem.Name = "verToolStripMenuItem";
            this.verToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.verToolStripMenuItem.Text = "Ver";
            // 
            // facturasToolStripMenuItem
            // 
            this.facturasToolStripMenuItem.Name = "facturasToolStripMenuItem";
            this.facturasToolStripMenuItem.Size = new System.Drawing.Size(253, 26);
            this.facturasToolStripMenuItem.Text = "Facturas";
            // 
            // creditoToolStripMenuItem
            // 
            this.creditoToolStripMenuItem.Name = "creditoToolStripMenuItem";
            this.creditoToolStripMenuItem.Size = new System.Drawing.Size(253, 26);
            this.creditoToolStripMenuItem.Text = "Creditos";
            // 
            // gatosExternosToolStripMenuItem
            // 
            this.gatosExternosToolStripMenuItem.Name = "gatosExternosToolStripMenuItem";
            this.gatosExternosToolStripMenuItem.Size = new System.Drawing.Size(253, 26);
            this.gatosExternosToolStripMenuItem.Text = "Gatos externos";
            this.gatosExternosToolStripMenuItem.Click += new System.EventHandler(this.gatosExternosToolStripMenuItem_Click);
            // 
            // productosSuministradosToolStripMenuItem
            // 
            this.productosSuministradosToolStripMenuItem.Name = "productosSuministradosToolStripMenuItem";
            this.productosSuministradosToolStripMenuItem.Size = new System.Drawing.Size(253, 26);
            this.productosSuministradosToolStripMenuItem.Text = "Productos suministrados";
            this.productosSuministradosToolStripMenuItem.Click += new System.EventHandler(this.productosSuministradosToolStripMenuItem_Click);
            // 
            // ingresarToolStripMenuItem
            // 
            this.ingresarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productosToolStripMenuItem,
            this.proveedorToolStripMenuItem,
            this.gastosExternoToolStripMenuItem});
            this.ingresarToolStripMenuItem.Name = "ingresarToolStripMenuItem";
            this.ingresarToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.ingresarToolStripMenuItem.Text = "Ingresar";
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.productosToolStripMenuItem.Text = "Producto";
            this.productosToolStripMenuItem.Click += new System.EventHandler(this.productosToolStripMenuItem_Click);
            // 
            // proveedorToolStripMenuItem
            // 
            this.proveedorToolStripMenuItem.Name = "proveedorToolStripMenuItem";
            this.proveedorToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.proveedorToolStripMenuItem.Text = "Proveedor";
            this.proveedorToolStripMenuItem.Click += new System.EventHandler(this.proveedorToolStripMenuItem_Click);
            // 
            // gastosExternoToolStripMenuItem
            // 
            this.gastosExternoToolStripMenuItem.Name = "gastosExternoToolStripMenuItem";
            this.gastosExternoToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.gastosExternoToolStripMenuItem.Text = "Gastos externos";
            this.gastosExternoToolStripMenuItem.Click += new System.EventHandler(this.gastosExternoToolStripMenuItem_Click);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productoToolStripMenuItem,
            this.proveedorToolStripMenuItem1,
            this.clienteCreditoToolStripMenuItem});
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.editarToolStripMenuItem.Text = "Editar";
            // 
            // productoToolStripMenuItem
            // 
            this.productoToolStripMenuItem.Name = "productoToolStripMenuItem";
            this.productoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.productoToolStripMenuItem.Text = "Producto";
            // 
            // proveedorToolStripMenuItem1
            // 
            this.proveedorToolStripMenuItem1.Name = "proveedorToolStripMenuItem1";
            this.proveedorToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.proveedorToolStripMenuItem1.Text = "Proveedor";
            this.proveedorToolStripMenuItem1.Click += new System.EventHandler(this.proveedorToolStripMenuItem1_Click);
            // 
            // clienteCreditoToolStripMenuItem
            // 
            this.clienteCreditoToolStripMenuItem.Name = "clienteCreditoToolStripMenuItem";
            this.clienteCreditoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.clienteCreditoToolStripMenuItem.Text = "Cliente/Credito";
            this.clienteCreditoToolStripMenuItem.Click += new System.EventHandler(this.clienteCreditoToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // cerrarToolStripMenuItem
            // 
            this.cerrarToolStripMenuItem.Name = "cerrarToolStripMenuItem";
            this.cerrarToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.cerrarToolStripMenuItem.Text = "Cerrar";
            this.cerrarToolStripMenuItem.Click += new System.EventHandler(this.cerrarToolStripMenuItem_Click);
            // 
            // v_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 666);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "v_Principal";
            this.Text = "POS_FG(BETA)";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ventaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proveedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proveedorToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem verToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creditoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gatosExternosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosSuministradosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gastosExternoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteCreditoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarToolStripMenuItem;
    }
}

