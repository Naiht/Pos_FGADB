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
    public partial class v_VGastos : Form
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

        public v_VGastos()
        {
            InitializeComponent();
        }

        private void v_VGastos_Load(object sender, EventArgs e)
        {
            dtgv_vgastos.ReadOnly = true;
            dtgv_vgastos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dtgv_vgastos.AllowUserToResizeRows = false;


            DataTable dt;
            dt = sql.tablas("gasto", "SELECT descripcion,total,fecha FROM gasto");
            if (dt.Rows.Count > 0)
            {
                dtgv_vgastos.DataSource = dt;

            }
        }

        ValidarV validar = new ValidarV();

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            if(rb_Descripcion.Checked)
            {
                if (validar.validarfrm(this) == false)
                {
                    DataTable dt;
                    dt = sql.tablas("gasto", "SELECT descripcion,total,fecha FROM gasto WHERE descripcion = '" + txt_descripcion.Text + "'");
                    if (dt.Rows.Count > 0)
                    {
                        dtgv_vgastos.DataSource = dt;
                    }
                }
                else
                {
                    MessageBox.Show("Debes agregar una descripcion para buscar", "Campos incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                if(rb_Rango.Checked)
                {
                    if (dtp_finicial.Value < dtp_ffinal.Value)
                    {
                        DataTable dt;
                        dt = sql.tablas("gasto", "SELECT descripcion,total,fecha FROM gasto WHERE fecha BETWEEN '" + string.Format("{0: MM-dd-yyyy}", dtp_finicial.Value) + "' AND '" + string.Format("{0: MM-dd-yyyy}", dtp_ffinal.Value) + "'");
                        if (dt.Rows.Count > 0)
                        {
                            dtgv_vgastos.DataSource = dt;

                        }
                    }
                    else
                    {
                        MessageBox.Show("la fecha inicial debe ser anterior a la fecha final", "Campos incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Debes Seleccionar una opción");
                }
            }
        }

        private void txt_descripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetterOrDigit(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;//permite valores alfanumericos y teclas de control
            }
            else
            {
                e.Handled = true;//no permite el resto de teclas
            }
        }
    }
}
