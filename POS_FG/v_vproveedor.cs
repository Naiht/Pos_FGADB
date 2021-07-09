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


        
        private void consulta(bool normal, string id,int estado)
        {
            DataTable dt;
            if (normal)
            {
                dt = sql.tablas("proveedor", "SELECT RUC,nombreproveedor,active FROM proveedor WHERE active = "+estado);
            }
            else
            {
                dt = sql.tablas("proveedor", "SELECT RUC,nombreproveedor,active FROM proveedor WHERE RUC LIKE '%" + id + "%' AND active = "+estado);
            }
            if (dt.Rows.Count > 0)
            {
                dtgv_proveedores.DataSource = dt;
                dtgv_proveedores.Columns[0].HeaderText = "RUC";
                dtgv_proveedores.Columns[1].HeaderText = "NOMBRE";
                dtgv_proveedores.Columns[1].Width = 200;
                dtgv_proveedores.Columns[2].HeaderText = "ACTIVO";
                dtgv_proveedores.Columns[2].Visible = false;
            }
        }

        private void consulta2(bool normal, string nombre,int estado)
        {
            DataTable dt;
            if (normal)
            {
                dt = sql.tablas("proveedor", "SELECT RUC,nombreproveedor,active FROM proveedor WHERE active = "+estado);
            }
            else
            {
                dt = sql.tablas("proveedor", "SELECT RUC,nombreproveedor,active FROM proveedor WHERE nombreproveedor like '%" + nombre + "%' AND active = "+estado);
            }
            if (dt.Rows.Count > 0)
            {
                dtgv_proveedores.DataSource = dt;
                dtgv_proveedores.Columns[0].HeaderText = "RUC";
                dtgv_proveedores.Columns[1].HeaderText = "NOMBRE";
                dtgv_proveedores.Columns[1].Width = 200;
                dtgv_proveedores.Columns[2].HeaderText = "ACTIVO";
                dtgv_proveedores.Columns[2].Visible = false;
            }
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Activos")
            {
                btn_Eliminar.Visible = true;
                btn_Eliminar.Enabled = false;
                button1.Visible = false;
                if (txt_Busqueda.Text != "")
                {
                    if (rb_id.Checked)
                    {
                        consulta(false, txt_Busqueda.Text, 1);
                    }
                    else
                    {
                        if (rb_nombre.Checked)
                        {
                            consulta2(false, txt_Busqueda.Text, 1);
                        }
                    }
                }
                else
                {
                    consulta(true, "", 1);
                }
            }
            else
            {
                button1.Visible = true;
                button1.Enabled = false;
                btn_Eliminar.Visible = false;
                if (txt_Busqueda.Text != "")
                {
                    if (rb_id.Checked)
                    {
                        consulta(false, txt_Busqueda.Text, 0);
                    }
                    else
                    {
                        if (rb_nombre.Checked)
                        {
                            consulta2(false, txt_Busqueda.Text, 0);
                        }
                    }
                }
                else
                {
                    consulta(true, "", 0);
                }
            }
            
        }

        private void v_vproveedor_Load(object sender, EventArgs e)
        {
            dtgv_proveedores.ReadOnly = true;
            dtgv_proveedores.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dtgv_proveedores.AllowUserToAddRows = false;

            rb_nombre.Checked = true;

            comboBox1.SelectedIndex = 0;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;

            button1.Visible = false;
            btn_Eliminar.Visible = true;
            btn_Eliminar.Enabled = false;

            


        }

        private void dtgv_proveedores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult = DialogResult.OK;

            RUC = dtgv_proveedores.CurrentRow.Cells[0].Value.ToString();
            this.Close();
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Esta seguro que quiere desactivar este proveedor?", "", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                sql.multiple("UPDATE proveedor SET active = 0 WHERE RUC = '" + dtgv_proveedores.Rows[fila].Cells[0].Value.ToString() + "'");
                btn_Eliminar.Enabled = false;
                dtgv_proveedores.DataSource = null;
                DataTable dt;
                dt = sql.tablas("proveedor", "SELECT RUC,nombreproveedor,active FROM proveedor WHERE active = 1");
                dtgv_proveedores.DataSource = dt;
                dtgv_proveedores.Columns[0].HeaderText = "RUC";
                dtgv_proveedores.Columns[1].HeaderText = "NOMBRE";
                dtgv_proveedores.Columns[1].Width = 200;
                dtgv_proveedores.Columns[2].HeaderText = "ACTIVO";
                dtgv_proveedores.Columns[2].Visible = false;
            }
           
        }

        int fila;
        private void dtgv_proveedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            fila = 0;
            fila = int.Parse(dtgv_proveedores.CurrentCell.RowIndex.ToString());
            btn_Eliminar.Enabled = true;
            button1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Esta seguro que quiere activar este proveedor?", "", MessageBoxButtons.YesNo);
            if(resultado == DialogResult.Yes)
            {
                sql.multiple("UPDATE proveedor SET active = 1 WHERE RUC = '" + dtgv_proveedores.Rows[fila].Cells[0].Value.ToString() + "'");
                button1.Enabled = false;
                dtgv_proveedores.DataSource = null;
                DataTable dt;
                dt = sql.tablas("proveedor", "SELECT RUC,nombreproveedor,active FROM proveedor WHERE active = 0");
                dtgv_proveedores.DataSource = dt;
                dtgv_proveedores.Columns[0].HeaderText = "RUC";
                dtgv_proveedores.Columns[1].HeaderText = "NOMBRE";
                dtgv_proveedores.Columns[1].Width = 200;
                dtgv_proveedores.Columns[2].HeaderText = "ACTIVO";
                dtgv_proveedores.Columns[2].Visible = false;
            }
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Activos")
            {
                consulta(true, "", 1);
                btn_Eliminar.Visible = true;
                btn_Eliminar.Enabled = false;
                button1.Visible = false;
            }
            else
            {
                consulta(true, "", 0);
                button1.Visible = true;
                button1.Enabled = false;
                btn_Eliminar.Visible = false;
            }
        }
    }
}
