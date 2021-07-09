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
    public partial class v_vproductos : Form
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

        public v_vproductos()
        {
            InitializeComponent();
        }

        sqlcon2 sql = new sqlcon2();
        DataTable dt;

        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Inventario_Max { get; set; }
        public string Inventario_Min { get; set; }
        public string Existencia { get; set; }
        public string Precio_Compra { get; set; }
        public string Precio_Venta { get; set; }


        private void v_vproductos_Load(object sender, EventArgs e)
        {
            dtgv_Productos.ReadOnly = true;
            dtgv_Productos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dtgv_Productos.AllowUserToResizeRows = false;
            dtgv_Productos.AllowUserToAddRows = false;

            rb_Nombre.Checked = true;

           
            
            comboBox1.SelectedIndex = 0;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;

            button1.Visible = false;
            btn_Eliminar.Visible = true;
            btn_Eliminar.Enabled = false;

        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
           
            if (comboBox1.SelectedItem.ToString() == "Activos")
            {
                btn_Eliminar.Visible = true;
                btn_Eliminar.Enabled = false;
                button1.Visible = false;
                if (rb_Nombre.Checked)
                {
                    dt = sql.tablas("productos", "select IDProducto,nombreproducto,inventario_max,inventario_min,existencias,P_venta, P_compra from productos where nombreproducto like '%" + txt_Buscar.Text + "%' AND active = 1");
                }
                else if (rb_Id.Checked)
                {
                    dt = sql.tablas("productos", "select IDProducto,nombreproducto,inventario_max,inventario_min,existencias,P_venta, P_compra from productos where IDProducto like '%" + txt_Buscar.Text + "%' AND active = 1");
                }
                else if (txt_Buscar.Text == "")
                {
                    dt = sql.tablas("productos", "select IDProducto,nombreproducto,inventario_max,inventario_min,existencias,P_venta, P_compra from productos WHERE active = 1");
                }
            }
            else
            {
                button1.Visible = true;
                button1.Enabled = false;
                btn_Eliminar.Visible = false;
                if (rb_Nombre.Checked)
                {
                    dt = sql.tablas("productos", "select IDProducto,nombreproducto,inventario_max,inventario_min,existencias,P_venta, P_compra from productos where nombreproducto like '%" + txt_Buscar.Text + "%' AND active = 0");
                }
                else if (rb_Id.Checked)
                {
                    dt = sql.tablas("productos", "select IDProducto,nombreproducto,inventario_max,inventario_min,existencias,P_venta, P_compra from productos where IDProducto like '%" + txt_Buscar.Text + "%' AND active = 0");
                }
                else if (txt_Buscar.Text == "")
                {
                    dt = sql.tablas("productos", "select IDProducto,nombreproducto,inventario_max,inventario_min,existencias,P_venta, P_compra from productos WHERE active = 0");
                }
            }
            

            if (dt.Rows.Count > 0)
            {
                dtgv_Productos.DataSource = dt;
                dtgv_Productos.Columns[0].HeaderText = "Codigo";
                dtgv_Productos.Columns[1].HeaderText = "Nombre";
                dtgv_Productos.Columns[2].HeaderText = "Inventario Maximo";
                dtgv_Productos.Columns[3].HeaderText = "Inventario Minimo";
                dtgv_Productos.Columns[4].HeaderText = "Existencias";
                dtgv_Productos.Columns[5].HeaderText = "Precio Venta";
                dtgv_Productos.Columns[6].HeaderText = "Precio Compra";
            }
        }

        private void dtgv_Productos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult = DialogResult.OK;

            Codigo = dtgv_Productos.CurrentRow.Cells[0].Value.ToString();
            Nombre = dtgv_Productos.CurrentRow.Cells[1].Value.ToString();
            Inventario_Max = dtgv_Productos.CurrentRow.Cells[2].Value.ToString();
            Inventario_Min = dtgv_Productos.CurrentRow.Cells[3].Value.ToString();
            Existencia = dtgv_Productos.CurrentRow.Cells[4].Value.ToString();
            Precio_Compra = dtgv_Productos.CurrentRow.Cells[6].Value.ToString();
            Precio_Venta = dtgv_Productos.CurrentRow.Cells[5].Value.ToString();

            //MessageBox.Show("" + Codigo + " " + Nombre + " " + Inventario_Max + " " + Inventario_Min + " " + Existencia + " " + Precio_Compra + " " + Precio_Venta);

            this.Close();
        }

        private void btn_Informe_Click(object sender, EventArgs e)
        {

            v_RepProductos rep = new v_RepProductos();
            rep.ShowDialog();
        }

        int fila;
        private void dtgv_Productos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            fila = 0;
            fila = int.Parse(dtgv_Productos.CurrentCell.RowIndex.ToString());
            btn_Eliminar.Enabled = true;
            button1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Esta seguro que quiere activar este producto?", "", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                sql.multiple("UPDATE productos SET active = 1 WHERE IDProducto = '" + dtgv_Productos.Rows[fila].Cells[0].Value.ToString() + "'");
                btn_Eliminar.Enabled = false;
                dtgv_Productos.DataSource = null;
                DataTable dt;
                dt = sql.tablas("productos", "select IDProducto,nombreproducto,inventario_max,inventario_min,existencias,P_venta, P_compra from productos WHERE active = 0");
                dtgv_Productos.DataSource = dt;
                dtgv_Productos.DataSource = dt;
                dtgv_Productos.Columns[0].HeaderText = "Codigo";
                dtgv_Productos.Columns[1].HeaderText = "Nombre";
                dtgv_Productos.Columns[2].HeaderText = "Inventario Maximo";
                dtgv_Productos.Columns[3].HeaderText = "Inventario Minimo";
                dtgv_Productos.Columns[4].HeaderText = "Existencias";
                dtgv_Productos.Columns[5].HeaderText = "Precio Venta";
                dtgv_Productos.Columns[6].HeaderText = "Precio Compra";
            }
            
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Esta seguro que quiere desactivar este producto?", "", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                sql.multiple("UPDATE productos SET active = 0 WHERE IDProducto = '" + dtgv_Productos.Rows[fila].Cells[0].Value.ToString() + "'");
                btn_Eliminar.Enabled = false;
                dtgv_Productos.DataSource = null;
                DataTable dt;
                dt = sql.tablas("productos", "select IDProducto,nombreproducto,inventario_max,inventario_min,existencias,P_venta, P_compra from productos WHERE active = 1");
                dtgv_Productos.DataSource = dt;
                dtgv_Productos.DataSource = dt;
                dtgv_Productos.Columns[0].HeaderText = "Codigo";
                dtgv_Productos.Columns[1].HeaderText = "Nombre";
                dtgv_Productos.Columns[2].HeaderText = "Inventario Maximo";
                dtgv_Productos.Columns[3].HeaderText = "Inventario Minimo";
                dtgv_Productos.Columns[4].HeaderText = "Existencias";
                dtgv_Productos.Columns[5].HeaderText = "Precio Venta";
                dtgv_Productos.Columns[6].HeaderText = "Precio Compra";
            }
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Activos")
            {
                dt = sql.tablas("productos", "select IDProducto,nombreproducto,inventario_max,inventario_min,existencias,P_venta, P_compra from productos WHERE active = 1");
                if (dt.Rows.Count > 0)
                {
                    dtgv_Productos.DataSource = dt;
                    dtgv_Productos.Columns[0].HeaderText = "Codigo";
                    dtgv_Productos.Columns[1].HeaderText = "Nombre";
                    dtgv_Productos.Columns[2].HeaderText = "Inventario Maximo";
                    dtgv_Productos.Columns[3].HeaderText = "Inventario Minimo";
                    dtgv_Productos.Columns[4].HeaderText = "Existencias";
                    dtgv_Productos.Columns[5].HeaderText = "Precio Venta";
                    dtgv_Productos.Columns[6].HeaderText = "Precio Compra";
                }
                btn_Eliminar.Visible = true;
                btn_Eliminar.Enabled = false;
                button1.Visible = false;
            }
            else
            {
                dt = sql.tablas("productos", "select IDProducto,nombreproducto,inventario_max,inventario_min,existencias,P_venta, P_compra from productos WHERE active = 0");
                if (dt.Rows.Count > 0)
                {
                    dtgv_Productos.DataSource = dt;
                    dtgv_Productos.Columns[0].HeaderText = "Codigo";
                    dtgv_Productos.Columns[1].HeaderText = "Nombre";
                    dtgv_Productos.Columns[2].HeaderText = "Inventario Maximo";
                    dtgv_Productos.Columns[3].HeaderText = "Inventario Minimo";
                    dtgv_Productos.Columns[4].HeaderText = "Existencias";
                    dtgv_Productos.Columns[5].HeaderText = "Precio Venta";
                    dtgv_Productos.Columns[6].HeaderText = "Precio Compra";
                }
                button1.Visible = true;
                button1.Enabled = false;
                btn_Eliminar.Visible = false;
            }
        }
    }
}
