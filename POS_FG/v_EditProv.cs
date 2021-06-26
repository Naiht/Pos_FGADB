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
    public partial class v_EditProv : Form
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

        public v_EditProv()
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
            dtgv_proveedores.ReadOnly = true;
            dtgv_proveedores.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dtgv_proveedores.AllowUserToAddRows = false;

            dtgv_Telefonos.ReadOnly = true;
            dtgv_Telefonos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dtgv_Telefonos.AllowUserToAddRows = false;

            rb_nombre.Checked = true;

            consulta(true, "");
        }

        #region celular
        DataTable dtp;
        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            DataRow row = dtp.NewRow();
            row["PhoneProveedor"] = txt_Telefono.Text.ToString();
            dtp.Rows.Add(row);
            dtp.AcceptChanges();
            dtgv_Telefonos.DataSource = dtp;
        }

        int fila;
        private void dtgv_proveedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            fila = 0;
            fila = dtgv_proveedores.CurrentRow.Index;
            txt_ID_Proveedor.Text = dtgv_proveedores.Rows[fila].Cells[0].Value.ToString();
            txt_NomProveedor.Text = dtgv_proveedores.Rows[fila].Cells[1].Value.ToString();

            dtp = sql.tablas("ProveedorPhone", "SELECT PhoneProveedor FROM ProveedorPhone WHERE RUC ='" + txt_ID_Proveedor.Text + "'");
            if (dtp.Rows.Count > 0)
            {
                dtgv_Telefonos.DataSource = dtp;
            }
        }
        #endregion
        private void btn_Remover_Click(object sender, EventArgs e)
        {

        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            txt_Busqueda.Clear();
            txt_ID_Proveedor.Clear();
            txt_NomProveedor.Clear();
            txt_Telefono.Clear();
            dtgv_Telefonos.DataSource = null;
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {

        }

        private void consulta(bool normal,string id)
        {
            DataTable dt;
            if (normal)
            {
                dt = sql.tablas("proveedor", "SELECT RUC,nombreproveedor,active FROM proveedor");
            }
            else
            {
                dt = sql.tablas("proveedor", "SELECT RUC,nombreproveedor,active FROM proveedor WHERE RUC ='" + id + "'");
            }
            if (dt.Rows.Count > 0)
            {
                dtgv_proveedores.DataSource = dt;
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
            }
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            if(txt_Busqueda.Text != "")
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

        private void txt_ID_Proveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsLetterOrDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;//permite teclas de contros y caracteres alfanumericos
            }
            else
            {
                e.Handled = true;//no permite ninguna otra tecla
            }
        }

        private void txt_NomProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetterOrDigit(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;//permite teclas de contros y caracteres alfanumericos y espacios
            }
            else
            {
                e.Handled = true;//no permite ninguna otra tecla
            }
        }

        private void txt_Telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;//permite teclas de contros y caracteres numericos
            }
            else
            {
                e.Handled = true;//no permite ninguna otra tecla
            }
        }

        private void txt_Busqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetterOrDigit(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;//permite teclas de contros y caracteres alfanumericos y espacios
            }
            else
            {
                e.Handled = true;//no permite ninguna otra tecla
            }
        }
    }
}
