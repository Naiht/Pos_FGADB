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
    public partial class v_IGasto : Form
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

        private void pb_Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion

        public v_IGasto()
        {
            InitializeComponent();
        }

        private void v_IGasto_Load(object sender, EventArgs e)
        {
            dtgv_gastos.ReadOnly = true;
            dtgv_gastos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dtgv_gastos.AllowUserToAddRows = false;
            dtgv_gastos.Columns.Add("descripcion", "Descripcion");
            dtgv_gastos.Columns.Add("total", "Total");
            dtgv_gastos.Columns.Add("fecha", "Fecha");
        }

        ValidarV validar = new ValidarV();

        private void btn_Agregar_Click(object sender, EventArgs e)//ingesa datos al datagridview 
        {
            
            if (validar.validarfrm(this) == false)
            {
                dtgv_gastos.Rows.Add(txt_descripcion.Text, txt_total.Text, string.Format("{0: MM-dd-yyyy}", dtp_fechalimite.Value));
            }
            else
            {
                MessageBox.Show("No puede dejar ningun campo vacío", "Campos incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        

        private void btn_Registrar_Click(object sender, EventArgs e)
        {

        }

        //validaciones de valores permitidos

        private void txt_descripcion_KeyPress(object sender, KeyPressEventArgs e)//valida caracteres permitidos en el textbox de la descripcion
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;//permite solo introducir numeros
            }
            else
            {
                if (char.IsControl(e.KeyChar))
                {
                    e.Handled = false;//permite teclas de control
                }
                else
                {
                    if(char.IsSeparator(e.KeyChar))
                    {
                        e.Handled = false;//permite usar la barra espaciadora
                    }
                    else
                    {
                        e.Handled = true;//desactiva el resto de teclas pulsadas
                    }
                }
            }
        }

        private void txt_total_KeyPress(object sender, KeyPressEventArgs e)//valida caracteres permitidos en el textbox del total
        {
            if (Char.IsDigit(e.KeyChar))
            {
                //permite solo introducir numeros
                e.Handled = false;
            }
            else
            {
                if (char.IsControl(e.KeyChar))
                {
                    //permite teclas de control
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;//desactiva el resto de teclas pulsadas
                }
            }
        }
    }
}
