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

        private void button1_Click(object sender, EventArgs e)
        {
            v_iProveedor ventana = new v_iProveedor();
            ventana.MdiParent = this.ParentForm;
            ventana.Show();
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

        private void btn_Agregar_Click(object sender, EventArgs e)//agrega un producto al datagridview para preparar el ingreso del producto, proveedor y suministro 
        {
            DataTable dt;
            dt = sql.tablas("proveedor", "SELECT RUC,nombreproveedor,active FROM proveedor WHERE RUC = '" + txt_ID_Proveedor.Text +"'");
            if (dt.Rows.Count > 0)
            {
                txt_ID_Proveedor.Enabled = false;
                dtgv_Producto.DataSource = dt;

            }
            else
            {
                MessageBox.Show("Tu mama es puta");
            }        
        }

        private void v_IProducto_Load(object sender, EventArgs e)//carga el nombre de las columnas del datagridview 
        {
            dtgv_Producto.Columns.Add("id", "ID");
            dtgv_Producto.Columns.Add("nombre", "Nombre");
            dtgv_Producto.Columns.Add("invmax", "Inventario Max");
            dtgv_Producto.Columns.Add("invmin", "Inventario Min");
            dtgv_Producto.Columns.Add("existencia", "Existencia");
            dtgv_Producto.Columns.Add("pcompra", "Precio Compra");
            dtgv_Producto.Columns.Add("pventa", "Precio Venta");
            dtgv_Producto.Columns.Add("idprov", "ID Proveedor");
            dtgv_Producto.Columns.Add("numfactura", "Numero Factura");
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)//limpia todos los registro 
        {
            limpiar();
        }

        private void btn_Remover_Click(object sender, EventArgs e)// borra la fila seleccionada en el datagridview
        {
            dtgv_Producto.Rows.RemoveAt(fila);
        }

        private void btn_Registrar_Click(object sender, EventArgs e)
        {

        }

        int fila;
        private void dtgv_Producto_CellClick(object sender, DataGridViewCellEventArgs e)//obriene el numero de fila selecciona al clickear sobre ella 
        {
            fila = 0;
            fila = int.Parse(dtgv_Producto.CurrentCell.RowIndex.ToString());
        }
    }
}
