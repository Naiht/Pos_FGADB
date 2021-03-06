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
    public partial class v_EditProducto : Form
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
        public v_EditProducto()
        {
            InitializeComponent();
        }
        sqlcon2 sql = new sqlcon2();
        private void v_EditProducto_Load(object sender, EventArgs e)
        {
            dtgv_Productos.ReadOnly = true;
            dtgv_Productos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dtgv_Productos.AllowUserToAddRows = false;
            
            rb_nombre.Checked = true;

            consulta(true, "");

        }

        private void consulta(bool normal,string nombre)
        {
            DataTable dt;
            if (normal)
            {
                dt = sql.tablas("productos", "SELECT IDproducto AS [Codigo],nombreproducto AS [Nombre], inventario_max AS [Inventario Maximo],inventario_min AS [Inventario Minimo],existencias AS [Existencias],P_venta AS [Precio Venta]" +
                    ",P_compra AS [Precio Compra] FROM productos");
                
            }
            else
            {
                dt = sql.tablas("productos", "SELECT IDproducto AS [Codigo],nombreproducto AS [Nombre], inventario_max AS [Inventario Maximo],inventario_min AS [Inventario Minimo],existencias AS [Existencias],P_venta AS [Precio Venta]" +
                    ",P_compra AS [Precio Compra] FROM productos WHERE nombreproducto like '%" + nombre + "%'");
            }
            if (dt.Rows.Count > 0)
            {
                dtgv_Productos.DataSource = dt;
            }
        }

        private void consulta2(bool normal, string id)
        {
            DataTable dt;
            if (normal)
            {
                dt = sql.tablas("productos", "SELECT IDproducto AS [Codigo],nombreproducto AS [Nombre], inventario_max AS [Inventario Maximo],inventario_min AS [Inventario Minimo],existencias AS [Existencias],P_venta AS [Precio Venta]" +
                    ",P_compra AS [Precio Compra] FROM productos");
            }
            else
            {
                dt = sql.tablas("productos", "SELECT IDproducto AS [Codigo],nombreproducto AS [Nombre], inventario_max AS [Inventario Maximo]," +
                    "inventario_min AS [Inventario Minimo],existencias AS [Existencias],P_venta AS [Precio Venta],P_compra AS [Precio Compra] FROM productos where IDproducto = '" + id +"'");
            }
            if (dt.Rows.Count > 0)
            {
                dtgv_Productos.DataSource = dt;
            }
        }
        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            if (txt_Busqueda.Text != "")
            {
                if (rb_id.Checked)
                {
                    consulta2(false, txt_Busqueda.Text);
                }
                else
                {
                    if (rb_nombre.Checked)
                    {
                        consulta(false, txt_Busqueda.Text);
                    }
                }
            }
            else
            {
                consulta(true, "");
            }
        }

        int fila;
        private void dtgv_Producos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            fila = 0;
            fila = dtgv_Productos.CurrentRow.Index;

            txt_idproducto.Text = dtgv_Productos.Rows[fila].Cells[0].Value.ToString();
            txt_NomProducto.Text = dtgv_Productos.Rows[fila].Cells[1].Value.ToString();
            txt_Inv_Max.Text = dtgv_Productos.Rows[fila].Cells[2].Value.ToString();
            txt_Inv_min.Text = dtgv_Productos.Rows[fila].Cells[3].Value.ToString();
            txt_Precio_Compra.Text = dtgv_Productos.Rows[fila].Cells[6].Value.ToString();
            txt_Precio_Venta.Text = dtgv_Productos.Rows[fila].Cells[5].Value.ToString();

        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            txt_Busqueda.Clear();
            txt_NomProducto.Clear();
            txt_Inv_Max.Clear();
            txt_Inv_min.Clear();
            txt_Precio_Compra.Clear();
            txt_Precio_Venta.Clear();
            txt_idproducto.Clear();
            consulta(true, "");
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
           if(txt_NomProducto.Text != "" && txt_Inv_Max.Text != "" && txt_Inv_min.Text != "" && txt_Precio_Compra.Text != "" && txt_Precio_Venta.Text != "")
           {
                if (int.Parse(txt_Inv_Max.Text) > int.Parse(txt_Inv_min.Text))
                {
                    if (int.Parse(txt_Precio_Venta.Text) > float.Parse(txt_Precio_Compra.Text))
                    {
                        if (int.Parse(txt_Inv_min.Text) < int.Parse(dtgv_Productos.Rows[fila].Cells[4].Value.ToString()))
                        {
                            if(int.Parse(txt_Inv_Max.Text)> int.Parse(dtgv_Productos.Rows[fila].Cells[4].Value.ToString()))
                            {
                                sql.multiple("UPDATE productos SET nombreproducto='" + txt_NomProducto.Text + "',inventario_max=" + int.Parse(txt_Inv_Max.Text) + ",inventario_min=" + int.Parse(txt_Inv_min.Text) + ",P_venta=" + int.Parse(txt_Precio_Venta.Text) +
                                   ",P_compra= " + float.Parse(txt_Precio_Compra.Text) + "WHERE IDproducto = '" + txt_idproducto.Text + "'");

                                MessageBox.Show("Se edito con el producto con exito");
                            }
                            MessageBox.Show("El inventario maximo no puede ser menor a la existencia del producto");
                        }
                        else
                        {
                            MessageBox.Show("El inventario minimo no puede ser mayor a la existencia del producto ");
                        }
                    }
                    else
                    {
                        MessageBox.Show("El precio de venta debe ser mayor al precio de compra ");
                    }
                    
                }
                else
                {
                    MessageBox.Show("El inventario maximo debe ser mayor al inventario minimo");
                }
                
           }
           else
           {
                MessageBox.Show("No puede dejar campos vacios");
           }
        }
    }
}
