﻿using System;
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
    public partial class v_IProducto : Form
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
        #endregion

        public v_IProducto()
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

        public void limpiar()// funcion para limpiar los valores de los controles. esta funcin se llama desde el boton cancelar
        {
            txt_ID_Producto.Clear();
            txt_NomProducto.Clear();
            txt_Inv_Max.Clear();
            txt_Inv_min.Clear();
            txt_Existencia.Clear();
            txt_Precio_Compra.Clear();
            txt_Precio_Venta.Clear();
            txt_ID_Proveedor.Clear();
            txt_numfactura.Clear();
            
            dtgv_Producto.Rows.Clear();
        }

        ValidarV validar = new ValidarV();

        private void btn_Agregar_Click(object sender, EventArgs e)//agrega un producto al datagridview para preparar el ingreso del producto, proveedor y suministro 
        {
            if (validar.validarfrm(this) == false)
            {

            }
            else
            {
                MessageBox.Show("No puede dejar ningun campo vacío", "Campos incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }        

    
        private void v_IProducto_Load(object sender, EventArgs e)//carga el nombre de las columnas del datagridview 
        {
            dtgv_Producto.ReadOnly = true;
            dtgv_Producto.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dtgv_Producto.AllowUserToAddRows = false;
            dtgv_Producto.Columns.Add("id", "Codigo");//0
            dtgv_Producto.Columns.Add("nombre", "Nombre");//1
            dtgv_Producto.Columns.Add("invmax", "Inventario Max");//2
            dtgv_Producto.Columns.Add("invmin", "Inventario Min");//3
            dtgv_Producto.Columns.Add("existencia", "Existencia");//4
            dtgv_Producto.Columns.Add("pcompra", "Precio Compra");//5
            dtgv_Producto.Columns.Add("pventa", "Precio Venta");//6
            dtgv_Producto.Columns.Add("idprov", "ID Proveedor");//7
            dtgv_Producto.Columns.Add("numfactura", "Numero Factura");//8
            dtgv_Producto.Columns.Add("fechafactura", "Fecha");//9
            btn_Remover.Enabled = false;
            btn_Registrar.Enabled = false;
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)//limpia todos los registro 
        {
            limpiar();
            dataGridView1.DataSource = null;
            txt_ID_Proveedor.Enabled = true;
            btn_Remover.Enabled = false;
            btn_Registrar.Enabled = false;
            txt_numfactura.Enabled = true;
            dtp_fechafacturacompra.Enabled = true;
        }

        private void btn_Remover_Click(object sender, EventArgs e)// borra la fila seleccionada en el datagridview
        {
            dtgv_Producto.Rows.RemoveAt(fila);
            btn_Remover.Enabled = false;//desactiva el boton remover para no causar errores
            //validacion en situacion especial pendiente 
           /* if (fila == dtgv_Producto.Rows.Count - 1)//permite elimiar el resgistro que se selecciona automaticamente luego de borrar uno sin necesidad de clickear sobre una fila
            {
                fila = fila - 1;
            }
            else
            {
                fila = fila + 1;
            }
            if (dtgv_Producto.Rows.Count > 1 )// desactiva el boton en caso que se elimine el ultimo registro del dgv
            {
                btn_Remover.Enabled = true;
            }
            else
            {
                btn_Remover.Enabled = false;
            }
           */
        }

        private void btn_Registrar_Click(object sender, EventArgs e)
        {
            if (dtgv_Producto.Rows.Count >= 1)
            {
                DialogResult venta = MessageBox.Show("¿Los datos de la factura son correctos?", "", MessageBoxButtons.YesNo);

                //registro de gastos en la bd 
                if (venta == DialogResult.Yes)
                {
                    for (int i = 0; i < dtgv_Producto.Rows.Count; i++)
                    {
                        float a = 0;

                        DataTable dt;
                        dt = sql.tablas("productos", "SELECT * FROM productos WHERE IDproducto = '" + dtgv_Producto.Rows[i].Cells[0].Value.ToString()+"'");
                        if (dt.Rows.Count > 0)
                        {
                            //MessageBox.Show("se actualiza la cantidad ");
                            

                            sql.multiple("UPDATE productos SET existencias = existencias+" + int.Parse(dtgv_Producto.Rows[i].Cells[4].Value.ToString()) + " WHERE IDproducto='" + dtgv_Producto.Rows[i].Cells[0].Value.ToString() + "'");

                            

                            a = int.Parse(dtgv_Producto.Rows[i].Cells[4].Value.ToString()) * float.Parse(dtgv_Producto.Rows[i].Cells[5].Value.ToString());//el monto pagado por ese producto

                            sql.multiple("INSERT INTO suministro (RUC,IDproducto,montosuministra,fechasuministra,numfacturasuministra,cantidadsuministra)" +
                                "VALUES('" + dtgv_Producto.Rows[i].Cells[7].Value.ToString() + "','" + dtgv_Producto.Rows[i].Cells[0].Value.ToString() + "'," + a + ",'" + dtgv_Producto.Rows[i].Cells[9].Value.ToString() + "'," +
                                int.Parse(dtgv_Producto.Rows[i].Cells[8].Value.ToString()) + "," + int.Parse(dtgv_Producto.Rows[i].Cells[4].Value.ToString()) + ")");

                        }
                        else
                        {
                            //MessageBox.Show("se inserta el producto");
                            sql.multiple("INSERT INTO productos(IDproducto, IDpulperia, nombreproducto, inventario_max, inventario_min, existencias, P_venta, P_compra)" +
                                "VALUES('" + dtgv_Producto.Rows[i].Cells[0].Value.ToString() + "',1,'" + dtgv_Producto.Rows[i].Cells[1].Value.ToString() + "'," + int.Parse(dtgv_Producto.Rows[i].Cells[2].Value.ToString()) +
                                "," + int.Parse(dtgv_Producto.Rows[i].Cells[3].Value.ToString()) + "," + int.Parse(dtgv_Producto.Rows[i].Cells[4].Value.ToString()) + "," + int.Parse(dtgv_Producto.Rows[i].Cells[6].Value.ToString()) +
                                "," + float.Parse(dtgv_Producto.Rows[i].Cells[5].Value.ToString()) + ")");

                           

                            a = int.Parse(dtgv_Producto.Rows[i].Cells[4].Value.ToString()) * int.Parse(dtgv_Producto.Rows[i].Cells[5].Value.ToString());//monto pagado por ese producto
                            
                            sql.multiple("INSERT INTO suministro (RUC,IDproducto,montosuministra,fechasuministra,numfacturasuministra,cantidadsuministra)" +
                                "VALUES('" + dtgv_Producto.Rows[i].Cells[7].Value.ToString() + "','" + dtgv_Producto.Rows[i].Cells[0].Value.ToString() + "'," + a + ",'" + dtgv_Producto.Rows[i].Cells[9].Value.ToString() + "'," +
                                int.Parse(dtgv_Producto.Rows[i].Cells[8].Value.ToString()) + "," + int.Parse(dtgv_Producto.Rows[i].Cells[4].Value.ToString()) + ")");

                        }
                    }
                    MessageBox.Show("Se registraron los gastos correctamente", "Registro de Gastos", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Debes ingresar al menos un producto para proceder con el registro ", "Campos incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            txt_ID_Proveedor.Clear();
            txt_numfactura.Clear();
            dtp_fechafacturacompra.Enabled = true;
            txt_numfactura.Enabled = true;
            txt_ID_Proveedor.Enabled = true;
            dtgv_Producto.Rows.Clear();
        }

        int fila;
        private void dtgv_Producto_CellClick(object sender, DataGridViewCellEventArgs e)//obriene el numero de fila selecciona al clickear sobre ella 
        {
            fila = 0;
            fila = int.Parse(dtgv_Producto.CurrentCell.RowIndex.ToString());
            btn_Remover.Enabled = true;
            /*if (fila == dtgv_Producto.Rows.Count - 1)//el menos 1 es porque la filas empiezan en 0
            {
                btn_Remover.Enabled = false;
            }
            else
            {
                btn_Remover.Enabled = true;
            }*/
        }

        //validacion de valores permitidos

        private void txt_ID_Producto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar)||char.IsControl(e.KeyChar))
            {
                e.Handled = false;//permite solo teclas numericas y de control
            }
            else
            {
                e.Handled = true;//no permite cualquier otra techla
            }
        }

        private void txt_NomProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetterOrDigit(e.KeyChar) || char.IsSeparator(e.KeyChar) || char.IsControl(e.KeyChar) || e.KeyChar == 46)
            {
                e.Handled = false;//permite letras y espacios
            }
            else
            {
                e.Handled = true;//no permite cualquier otra tecla
            }
        }

        private void txt_Inv_Max_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;//permite solo teclas numericas y de control
            }
            else
            {
                e.Handled = true;//no permite cualquier otra techla
            }
        }

        private void txt_Inv_min_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;//permite solo teclas numericas y de control
            }
            else
            {
                e.Handled = true;//no permite cualquier otra techla
            }
        }

        private void txt_Existencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;//permite solo teclas numericas y de control
            }
            else
            {
                e.Handled = true;//no permite cualquier otra techla
            }
        }

        private void txt_Precio_Compra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar) || e.KeyChar == 46) 
            {
                e.Handled = false;//permite solo teclas numericas y de control
            }
            else
            {
                e.Handled = true;//no permite cualquier otra techla
            }
        }

        private void txt_Precio_Venta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;//permite solo teclas numericas y de control
            }
            else
            {
                e.Handled = true;//no permite cualquier otra techla
            }
        }

        private void txt_numfactura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;//permite solo teclas numericas y de control
            }
            else
            {
                e.Handled = true;//no permite cualquier otra techla
            }
        }

        private void txt_ID_Proveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetterOrDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;//permite letras y espacios
            }
            else
            {
                e.Handled = true;//no permite cualquier otra tecla
            }
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            v_vproveedor ventana = new v_vproveedor();
            ventana.ShowDialog();
            if (ventana.DialogResult == DialogResult.OK)
            {
                txt_ID_Proveedor.Text = ventana.RUC;
            }
        }

        private void btn_Bproducto_Click(object sender, EventArgs e)
        {
            v_vproductos ventana2 = new v_vproductos();
            ventana2.ShowDialog();
            if (ventana2.DialogResult == DialogResult.OK)
            {
                txt_ID_Producto.Text = ventana2.Codigo;
                txt_NomProducto.Text = ventana2.Nombre;
                txt_Inv_Max.Text = ventana2.Inventario_Max;
                txt_Inv_min.Text = ventana2.Inventario_Min;
                txt_Precio_Compra.Text = ventana2.Precio_Compra;
                txt_Precio_Venta.Text = ventana2.Precio_Venta;

            }
        }
    }
}

