using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;

namespace POS_FG
{
    public partial class v_VerFacturaDetalle : Form
    {
        sqlcon2 sql = new sqlcon2();

        #region MouseDragger
        //Activa el movimiento de la ventana con el panel
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void pan_Sup_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void lbl_NombreV_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pb_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pb_Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion
        public v_VerFacturaDetalle()
        {
            InitializeComponent();
        }

        public v_VerFacturaDetalle(String factura)
        {
            InitializeComponent();

            dtgv_FacturaD.ReadOnly = true;
            dtgv_FacturaD.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dtgv_FacturaD.AllowUserToResizeRows = false;

            DataTable dt;
            dt = sql.tablas("detalle", "select p.nombreproducto, d.cantidadcompra, p.P_venta, f.monto from detalle d INNER JOIN factura f ON d.IDfactura = f.IDfactura INNER JOIN productos p ON p.IDproducto = d.IDproducto where f.IDfactura = " + factura);
            if (dt.Rows.Count > 0)
            {
                dtgv_FacturaD.DataSource = dt;

                dtgv_FacturaD.Columns[0].HeaderText = "Producto";
                dtgv_FacturaD.Columns[1].HeaderText = "Cantidad";
                dtgv_FacturaD.Columns[2].HeaderText = "Precio";

                dtgv_FacturaD.Rows[dtgv_FacturaD.RowCount - 1].Cells[0].Value = "Total";
            }


            //dtgv_FacturaD.Rows[dtgv_FacturaD.RowCount - 1].Cells[2].Value = "" + dtgv_FacturaD.Rows[0].Cells[3].Value.ToString();
        }
    }
}
