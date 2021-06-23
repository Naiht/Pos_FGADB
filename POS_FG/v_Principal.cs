using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_FG
{
    public partial class v_Principal : Form
    {
        public v_Principal()
        {
            InitializeComponent();
        }

        private void ventaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v_Ventas ventana = new v_Ventas();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v_IProducto ventana = new v_IProducto();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void proveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v_iProveedor ventana = new v_iProveedor();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void proveedorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            v_EditProv ventana = new v_EditProv();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gatosExternosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v_VGastos ventana = new v_VGastos();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void productosSuministradosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v_VSuministro ventana = new v_VSuministro();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void gastosExternoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v_IGasto ventana = new v_IGasto();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void clienteCreditoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v_ModiCliente ventana = new v_ModiCliente();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void creditoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v_VerCredito ventana = new v_VerCredito();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void facturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v_VerFacturas ventana = new v_VerFacturas();
            ventana.MdiParent = this;
            ventana.Show();

        }

        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v_EditProducto ventana = new v_EditProducto();
            ventana.MdiParent = this;
            ventana.Show();
        }
    }
}
