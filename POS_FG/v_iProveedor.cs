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
            btn_Remover.Enabled = false;
        }

        ValidarV validar = new ValidarV();

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            if (txt_Telefono.Text != "")
            {
                dtgv_Telefonos.Rows.Add(txt_Telefono.Text);
                txt_Telefono.Clear();
            }
            else
            {
                MessageBox.Show("Debes ingresar un numero de telefono para agregar", "Campos incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            /*
            if (validar.validarfrm(this) == false)
            {
                dtgv_Telefonos.Rows.Add(txt_Telefono.Text);
                txt_Telefono.Clear();
            }
            else
            {
                MessageBox.Show("Debes ingresar un numero de telefono para agregar", "Campos incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }*/
        }

        private void txt_Telefono_KeyPress(object sender, KeyPressEventArgs e)//evita el usode letras en el campo del numero de telefono del proveedor
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

        private void txt_ID_Proveedor_KeyPress(object sender, KeyPressEventArgs e)//permite el uso de numeros y letras en el id del proveedor
        {
            if (char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = false;
            }
        }

        public void limpiar()//funcion para limpiar todos los controles
        {
            txt_ID_Proveedor.Clear();
            txt_NomProveedor.Clear();
            txt_Telefono.Clear();
            dtgv_Telefonos.Rows.Clear();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e) //llama a la funcin que limpiar los controles
        {
            limpiar();
        }

        private void btn_Remover_Click(object sender, EventArgs e)//borra la fila seleccionada en el dgv
        {
            dtgv_Telefonos.Rows.RemoveAt(fila);
            btn_Remover.Enabled = false;//desactiva el boton remover para no causar errores
            //validacion en situacion especial pendiente
            /*
            if(fila==dtgv_Telefonos.Rows.Count - 1)//permite eliminar el resgistro que se selecciona automaticamente luego de borrar uno sin necesidad de clickear sobre una fila
            {
                fila = fila - 1;
            }
            else
            {
                fila = fila + 1;
            }
            if (dtgv_Telefonos.Rows.Count > 1)//desactiva el boton en caso que se eliimne el ultimo registro del dgv
            {
                btn_Remover.Enabled = true;
            }
            else
            {
                btn_Remover.Enabled = false;
            }*/
        }

        private void btn_Registrar_Click(object sender, EventArgs e)
        {
            if(txt_ID_Proveedor.Text != "")
            {
                if(txt_NomProveedor.Text != "")
                {
                    if (dtgv_Telefonos.Rows.Count > 1)
                    {

                    }
                    else
                    {
                        MessageBox.Show("Debes ingresar al menos un numero del proveedor", "Campos incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Debes ingresar el nombre del proveedor", "Campos incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Debes ingresar el ID del proveedor", "Campos incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        int fila;
        private void dtgv_Telefonos_CellClick(object sender, DataGridViewCellEventArgs e)//obriene el numero de fila selecciona al clickear sobre ella 
        {
            fila = 0;
            fila = int.Parse(dtgv_Telefonos.CurrentCell.RowIndex.ToString());
            if(fila==dtgv_Telefonos.Rows.Count - 1)//el menos 1 es porque la filas empiezan en 0
            {
                btn_Remover.Enabled = false;
            }
            else
            {
                btn_Remover.Enabled = true;
            }
        }
    }
}
