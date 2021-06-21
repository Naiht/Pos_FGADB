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
    public partial class v_ModiCliente : Form
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

        public v_ModiCliente()
        {
            InitializeComponent();
        }

        private void btn_BsCliente_Click(object sender, EventArgs e)
        {
            v_VentasCli mensaje = new v_VentasCli();
            mensaje.funcion = true;
            mensaje.ShowDialog();


            if (mensaje.DialogResult == DialogResult.OK)
            {
                txt_CedCliente.Text = mensaje.ecedulacli;
                txt_NomCliente.Text = mensaje.enombrec;
                txt_Monto.Text = mensaje.emonto.ToString();
                txt_TelefonoCliente.Text = mensaje.etelefono.ToString();
                txt_DireccionCliente.Text = mensaje.edireccion;
            }
        }

        ValidarV validar = new ValidarV();
        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            validar.limpiarfrm(this);
        }

        private void btn_Listo_Click(object sender, EventArgs e)
        {
            if (validar.validarfrm(this) == false)
            {

            }
            else {
                MessageBox.Show("No puede dejar ningun campo vacío","Campos incorrectos",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }
    }
}
