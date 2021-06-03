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
    public partial class v_Ventas : Form
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
        #endregion

        public v_Ventas()
        {
            InitializeComponent();
        }

        private void v_Ventas_Load(object sender, EventArgs e)
        {

            dtgv_ProductosV.ReadOnly = true;
            dtgv_ProductosV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dtgv_ProductosV.AllowUserToResizeRows = false;


            DataTable dt;
            dt = sql.tablas("productos","select * from productos");
            if (dt.Rows.Count > 0)
            {
                dtgv_ProductosV.DataSource = dt;
            }
        }

        private void pb_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pb_Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_Credito.Checked){
                btn_BsCliente.Enabled = true;
            }
            else {
                btn_BsCliente.Enabled = false;
            }
        }

    }
}
