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
    public partial class v_RepProductos : Form
    {
        public v_RepProductos()
        {
            InitializeComponent();
        }

        private void v_RepProductos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'pulperiafgDataSet.productos' Puede moverla o quitarla según sea necesario.
            this.productosTableAdapter.Fill(this.pulperiafgDataSet.productos);

            this.reportViewer1.RefreshReport();
        }
    }
}
