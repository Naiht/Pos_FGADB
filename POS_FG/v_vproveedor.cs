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
    public partial class v_vproveedor : Form
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

        public v_vproveedor()
        {
            InitializeComponent();
        }
        sqlcon2 sql = new sqlcon2();

        public string RUC {get; set; }

        private void consulta(bool normal, string id)
        {
            DataTable dt;
            if (normal)
            {
                dt = sql.tablas("proveedor", "SELECT RUC,nombreproveedor,active FROM proveedor");
            }
            else
            {
                dt = sql.tablas("proveedor", "SELECT RUC,nombreproveedor,active FROM proveedor WHERE RUC LIKE '%" + id + "%'");
            }
            if (dt.Rows.Count > 0)
            {
                dtgv_proveedores.DataSource = dt;
                dtgv_proveedores.Columns[0].HeaderText = "RUC";
                dtgv_proveedores.Columns[1].HeaderText = "NOMBRE";
                dtgv_proveedores.Columns[1].Width = 200;
                dtgv_proveedores.Columns[2].HeaderText = "ACTIVO";
            }
        }

        private void consulta2(bool normal, string nombre)
        {
            DataTable dt;
            if (normal)
            {
                dt = sql.tablas("proveedor", "SELECT RUC,nombreproveedor,active FROM proveedor");
            }
            else
            {
                dt = sql.tablas("proveedor", "SELECT RUC,nombreproveedor,active FROM proveedor WHERE nombreproveedor like '%" + nombre + "%'");
            }
            if (dt.Rows.Count > 0)
            {
                dtgv_proveedores.DataSource = dt;
                dtgv_proveedores.Columns[0].HeaderText = "RUC";
                dtgv_proveedores.Columns[1].HeaderText = "NOMBRE";
                dtgv_proveedores.Columns[2].HeaderText = "ACTIVO";
            }
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            if (txt_Busqueda.Text != "")
            {
                if (rb_id.Checked)
                {
                    consulta(false, txt_Busqueda.Text);
                }
                else
                {
                    if (rb_nombre.Checked)
                    {
                        consulta2(false, txt_Busqueda.Text);
                    }
                }
            }
            else
            {
                consulta(true, "");
            }
        }

        private void v_vproveedor_Load(object sender, EventArgs e)
        {
            dtgv_proveedores.ReadOnly = true;
            dtgv_proveedores.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dtgv_proveedores.AllowUserToAddRows = false;

            rb_nombre.Checked = true;

            consulta(true, "");


        }

        private void dtgv_proveedores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult = DialogResult.OK;

            RUC = dtgv_proveedores.CurrentRow.Cells[0].Value.ToString();
            this.Close();
        }
    }
}
