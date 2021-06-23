using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace POS_FG
{
    public partial class v_AgregCliente : Form
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

        private void pb_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion


        public string nombreca { get; set; }
        public string cedulaclia { get; set; }
        public float montoa { get; set; }

        public v_AgregCliente()
        {
            InitializeComponent();
        }

        sqlcon2 sql = new sqlcon2();
        ValidarV validar = new ValidarV();
        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            if (validar.validarfrm(this) == false)
            {
                DialogResult resultado = MessageBox.Show("¿Son correctos los datos del cliente?", "Nuevo Cliente", MessageBoxButtons.OKCancel);

                if (resultado == DialogResult.OK)
                {
                    DialogResult = DialogResult.OK;

                    nombreca = txt_NomCliente.Text;
                    cedulaclia = txt_CedCliente.Text;
                    montoa = 0;



                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("No puede dejar ningun campo vacío", "Campos incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }


    }
}
