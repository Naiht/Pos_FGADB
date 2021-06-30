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
        int pos = 0;
       

        private void v_proveedor_Load(object sender, EventArgs e)
        {
            dtgv_proveedores.ReadOnly = true;
            dtgv_proveedores.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dtgv_proveedores.AllowUserToAddRows = false;

            dtgv_Telefonos.ReadOnly = true;
            dtgv_Telefonos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dtgv_Telefonos.AllowUserToAddRows = false;

            dtgv_eliminar.ReadOnly = true;
            dtgv_eliminar.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dtgv_eliminar.AllowUserToAddRows = false;
            dtgv_eliminar.Visible = false;
            dtgv_eliminar.Columns.Add("telefonos", "Telefonos");

            dtgv_agregar.ReadOnly = true;
            dtgv_agregar.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dtgv_agregar.AllowUserToAddRows = false;
            dtgv_agregar.Visible = false;
            dtgv_agregar.Columns.Add("telefonos", "Telefonos");

            rb_nombre.Checked = true;

            consulta(true, "");

            btn_Remover.Enabled = false;
            btn_Modificar.Enabled = false;
            rb_nombre.Checked = true;
        }
        
        #region celular
        DataTable dtp;
        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            if (txt_Telefono.Text != "")
            {
                int x = 0;
                int xx = 0;
                DataRow row = dtp.NewRow();
                for (int i = 0; i < dtgv_Telefonos.Rows.Count; i++)
                {
                    if (txt_Telefono.Text == dtgv_Telefonos.Rows[i].Cells[0].Value.ToString())
                    {
                        xx = 1;
                    }
                }
                if (xx != 1)
                {
                    row["Telefonos"] = txt_Telefono.Text.ToString();
                    dtp.Rows.Add(row);
                    dtp.AcceptChanges();
                    dtgv_Telefonos.DataSource = dtp;
                }
                else
                {
                    MessageBox.Show("Ese numero ya ha sido ingresado");
                }
                for (int i = 0; i < dtgv_agregar.Rows.Count; i++)
                {
                    if (txt_Telefono.Text == dtgv_agregar.Rows[i].Cells[0].Value.ToString())
                    {
                        x = 1;
                    }
                }
                if (x != 1 && xx != 1)
                {
                    dtgv_agregar.Rows.Add(txt_Telefono.Text);
                }

                for (int i = 0; i < dtgv_eliminar.Rows.Count; i++)
                {
                    if (dtgv_eliminar.Rows[i].Cells[0].Value.ToString() == txt_Telefono.Text)
                    {
                        dtgv_eliminar.Rows.RemoveAt(i);
                    }
                }
                txt_Telefono.Clear();
                btn_Modificar.Enabled = true;
            }
            else
            {
                MessageBox.Show("La casilla telefino esta vacia");
            }
            
        }
        
        int fila;
        private void dtgv_proveedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            fila = 0;
            fila = dtgv_proveedores.CurrentRow.Index;
            txt_ID_Proveedor.Text = dtgv_proveedores.Rows[fila].Cells[0].Value.ToString();
            txt_NomProveedor.Text = dtgv_proveedores.Rows[fila].Cells[1].Value.ToString();

            dtp = sql.tablas("ProveedorPhone", "SELECT PhoneProveedor AS [Telefonos] FROM ProveedorPhone WHERE RUC ='" + txt_ID_Proveedor.Text + "'");
            if (dtp.Rows.Count > 0)
            {
                dtgv_Telefonos.DataSource = dtp;
            }
            else
            {
                dtgv_Telefonos.DataSource = null;
            }
            btn_Remover.Enabled = false;
            btn_Modificar.Enabled = false;
            txt_Telefono.Clear();
            dtgv_eliminar.Rows.Clear();
            dtgv_agregar.Rows.Clear();
        }
        #endregion
        private void btn_Remover_Click(object sender, EventArgs e)
        {
            int x = 0;
            for(int i = 0; i < dtgv_eliminar.Rows.Count; i++)
            {
                if (dtgv_Telefonos.Rows[fila2].Cells[0].Value.ToString() == dtgv_eliminar.Rows[i].Cells[0].Value.ToString())
                {
                    x = 1;
                }
            }
            if (x != 1)
            {
                dtgv_eliminar.Rows.Add(dtgv_Telefonos.Rows[fila2].Cells[0].Value.ToString());
                for(int i = 0; i < dtgv_agregar.Rows.Count; i++)
                {
                    if (dtgv_Telefonos.Rows[fila2].Cells[0].Value.ToString() == dtgv_agregar.Rows[i].Cells[0].Value.ToString())
                    {
                        dtgv_agregar.Rows.RemoveAt(i);
                    }
                }
            }
            
            dtgv_Telefonos.Rows.RemoveAt(fila2);
            btn_Remover.Enabled = false;
            btn_Modificar.Enabled = true;
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            txt_Busqueda.Clear();
            txt_ID_Proveedor.Clear();
            txt_NomProveedor.Clear();
            txt_Telefono.Clear();
            dtgv_agregar.Rows.Clear();
            dtgv_eliminar.Rows.Clear();
            dtgv_Telefonos.DataSource = null;
            btn_Remover.Enabled = false;
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            if (txt_NomProveedor.Text != "")
            {
                if(dtgv_agregar.Rows.Count > 0)
                {
                    DialogResult venta = MessageBox.Show("¿Los registros son correctos?", "", MessageBoxButtons.YesNo);

                    //registra los nuevos numeros del proveedor 
                    if (venta == DialogResult.Yes)
                    {
                        for (int i = 0; i < dtgv_agregar.Rows.Count; i++)
                        {
                            sql.multiple("INSERT INTO ProveedorPhone (PhoneProveedor,RUC)VALUES('" + dtgv_agregar.Rows[i].Cells[0].Value.ToString() + "','" + txt_ID_Proveedor.Text + "')");
                        }
                    }
                }
                if (dtgv_eliminar.Rows.Count > 0)
                {
                    DialogResult venta = MessageBox.Show("¿Los registros son correctos?", "", MessageBoxButtons.YesNo);

                    //elimina los registros deseados
                    if (venta == DialogResult.Yes)
                    {
                        for (int i = 0; i < dtgv_eliminar.Rows.Count; i++)
                        {
                            sql.multiple("DELETE FROM ProveedorPhone WHERE RUC='" + txt_ID_Proveedor.Text + "' and PhoneProveedor='" + dtgv_eliminar.Rows[i].Cells[0].Value.ToString() + "'");
                        }
                    }
                }
                for (int i = 0; i < viejos.Length; i++)
                {
                    //MessageBox.Show("nuevos " + nuevos.Length + "viejos" + viejos.Length);
                    if (nuevos[i] != "" && viejos[i] != "")
                    {
                        sql.multiple("UPDATE ProveedorPhone SET PhoneProveedor='" + nuevos[i] + "' WHERE RUC='" + txt_ID_Proveedor.Text + "' and PhoneProveedor='" + viejos[i] + "'");
                    }
                    
                }
                MessageBox.Show("Los datos del proveedor se actualizaron correctamente", "Edicion de proveedor", MessageBoxButtons.OK);

            }
            dtgv_agregar.Rows.Clear();
            dtgv_eliminar.Rows.Clear();
            btn_Modificar.Enabled = false;
            btn_Remover.Enabled = false;
            Array.Clear(nuevos, 0, nuevos.Length);
            Array.Clear(viejos, 0, viejos.Length);
        }

        private void consulta(bool normal,string id)
        {
            DataTable dt;
            if (normal)
            {
                dt = sql.tablas("proveedor", "SELECT RUC,nombreproveedor AS [Nombre],active AS [Estado Activo] FROM proveedor");
            }
            else
            {
                dt = sql.tablas("proveedor", "SELECT RUC,nombreproveedor AS [Nombre],active AS [Estado Activo] FROM proveedor WHERE RUC ='" + id + "'");
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
                dt = sql.tablas("proveedor", "SELECT RUC,nombreproveedor AS [Nombre],active AS [Estado Activo] FROM proveedor");
            }
            else
            {
                dt = sql.tablas("proveedor", "SELECT RUC,nombreproveedor AS [Nombre],active AS [Estado Activo] FROM proveedor WHERE nombreproveedor like '%" + nombre + "%'");
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
        int fila2;
        private void dtgv_Telefonos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            fila2 = 0;
            fila2 = int.Parse(dtgv_Telefonos.CurrentCell.RowIndex.ToString());
            //MessageBox.Show("" + fila);
            btn_Remover.Enabled = true;
        }
        string[] nuevos = new string[1];
        string[] viejos = new string[1];
        private void dtgv_Telefonos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string nuevo;
            // MessageBox.Show("" + dtgv_Telefonos.CurrentCell.Value.ToString());
           
            viejos[pos] = dtgv_Telefonos.CurrentCell.Value.ToString();
            //MessageBox.Show("" + viejos[pos]+"  "+pos);
            Array.Resize(ref viejos, viejos.Length + 1);
            //MessageBox.Show("indices" + viejos.Length);
            nuevo = Microsoft.VisualBasic.Interaction.InputBox("Ingresa el nuevo numero", "Modificar un numero", "" + dtgv_Telefonos.CurrentCell.Value.ToString());
            nuevos[pos] = nuevo;
            Array.Resize(ref nuevos, nuevos.Length + 1);
            dtgv_Telefonos.CurrentCell.Value = nuevo;
            btn_Modificar.Enabled = true;
            //MessageBox.Show("" + nuevo);
            pos++;
            //MessageBox.Show("" + pos);
        }
    }
}
