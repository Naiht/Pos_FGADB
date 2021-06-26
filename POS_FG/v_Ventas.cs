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
    public partial class v_Ventas : Form
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

        public v_Ventas()
        {
            InitializeComponent();
        }

        private void v_Ventas_Load(object sender, EventArgs e)
        {

            dtgv_ProductosV.ReadOnly = true;
            dtgv_ProductosV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dtgv_ProductosV.AllowUserToResizeRows = false;

            rb_Nombre.Checked = true;

            dtgv_Factura.Columns.Add("", "Codigo");
            dtgv_Factura.Columns.Add("", "Nombre");
            dtgv_Factura.Columns.Add("", "Precio");

            dtgv_Factura.ReadOnly = true;
            dtgv_Factura.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dtgv_Factura.AllowUserToResizeRows = false;

            //dtgv_Factura.Rows.Add();
            dtgv_Factura.Rows[dtgv_Factura.RowCount-1].Cells[0].Value = "Total";

            DataTable dt;
            dt = sql.tablas("productos","select IDProducto,nombreproducto,P_venta from productos");
            if (dt.Rows.Count > 0)
            {
                dtgv_ProductosV.DataSource = dt;
                dtgv_ProductosV.Columns[0].HeaderText = "Codigo";
                dtgv_ProductosV.Columns[1].HeaderText = "Nombre";
                dtgv_ProductosV.Columns[2].HeaderText = "Precio";
            }
        }

        private void pb_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pb_Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_Credito.Checked){
                btn_BsCliente.Enabled = true;
                btn_BsCliente.BackColor = Color.DimGray;
            }
            else {
                btn_BsCliente.BackColor = Color.White;
                btn_BsCliente.Enabled = false;
            }
        }

        private float monto = 0;
        private string cedula = "";
        private void btn_BsCliente_Click(object sender, EventArgs e)
        {
            v_VentasCli mensaje = new v_VentasCli();
            mensaje.ShowDialog();

            if (mensaje.DialogResult == DialogResult.OK) {
                txt_NomCliente.Text = mensaje.nombrec;
                cedula = mensaje.cedulacli;
                monto = mensaje.monto;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            v_RepProductos rep = new v_RepProductos();
            rep.ShowDialog();
        }
        
        int fila;
        float total = 0;
        private void dtgv_ProductosV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            fila = dtgv_ProductosV.CurrentRow.Index;//Variable que guarda la fila seleccionada
            dtgv_Factura.Rows.Insert(0,dtgv_ProductosV.Rows[fila].Cells[0].Value, dtgv_ProductosV.Rows[fila].Cells[1].Value, dtgv_ProductosV.Rows[fila].Cells[2].Value);

            total = float.Parse(dtgv_ProductosV.Rows[fila].Cells[2].Value.ToString()) + total;//Variable que almacena el total de venta
            dtgv_Factura.Rows[dtgv_Factura.RowCount - 1].Cells[2].Value = ""+total;
        }

        private void btn_Remover_Click(object sender, EventArgs e)
        {
            if (dtgv_Factura.Rows.Count > 1)
            {
                total = total - float.Parse(dtgv_Factura.Rows[dtgv_Factura.CurrentRow.Index].Cells[2].Value.ToString());//Variable que almacena el total de venta
                dtgv_Factura.Rows[dtgv_Factura.RowCount - 1].Cells[2].Value = "" + total;
                dtgv_Factura.Rows.Remove(dtgv_Factura.CurrentRow);
            }
            else {
                MessageBox.Show("No quedan productos por remover","No hay productos",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void btn_Finalizar_Click(object sender, EventArgs e)
        {
            if (dtgv_Factura.Rows.Count > 1)
            {
                DialogResult venta = MessageBox.Show("¿Es correcta la venta?","",MessageBoxButtons.YesNo);

                //Informacion de la factura a la base de datos
                if (venta == DialogResult.Yes)
                {
                    sql.multiple("insert into factura (monto,fecha) values ("+total+",'06/25/2021')");
                    for (int i = 0; i < dtgv_Factura.Rows.Count -1; i++)
                    {
                        sql.multiple("insert into detalle (IDproducto,IDfactura,cantidadcompra) values " +
                            "('"+dtgv_Factura.Rows[i].Cells[0].Value.ToString()+"',31,2)");
                    }
                }
            }
            else
            {
                MessageBox.Show("Para realizar una venta primero tiene que ingresar productos", "No hay productos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
