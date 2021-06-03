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

        }
    }
}
