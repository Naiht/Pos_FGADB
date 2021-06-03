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
    public partial class v_VentasCli : Form
    {
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


        public v_VentasCli()
        {
            InitializeComponent();
        }

        private void pb_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pb_Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        sqlcon2 sql = new sqlcon2();
        private void v_proveedor_Load(object sender, EventArgs e)
        {

            dtgv_Clientes.ReadOnly = true;
            dtgv_Clientes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dtgv_Clientes.AllowUserToResizeRows = false;


            DataTable dt;
            dt = sql.tablas("credito", "select * from credito");
            if (dt.Rows.Count > 0)
            {
                dtgv_Clientes.DataSource = dt;
            }
        }

        private void btn_Registrar_Click(object sender, EventArgs e)
        {
        }
    }
}
