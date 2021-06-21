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
    public partial class v_iProveedor : Form
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

        public v_iProveedor(string nombre)
        {
            InitializeComponent();
            txt_NomProveedor.Text = nombre;
        }

        public v_iProveedor()
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

        private void v_proveedor_Load(object sender, EventArgs e)
        {
            dtgv_Telefonos.Columns.Add("telefonos", "Telefonos");
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            dtgv_Telefonos.Rows.Add(txt_Telefono.Text);
        }

        private void txt_Telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                //permite solo introducir numeros y teclas de control
                e.Handled = false;
            }
            else
            {
                e.Handled = true;//desactiva el resto de teclas pulsadas
            }
        }
    }
}
