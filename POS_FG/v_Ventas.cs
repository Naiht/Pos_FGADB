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
using Microsoft.VisualBasic;

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

        DataTable dt;
        private void v_Ventas_Load(object sender, EventArgs e)
        {

            dtgv_ProductosV.ReadOnly = true;
            dtgv_ProductosV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dtgv_ProductosV.AllowUserToResizeRows = false;

            rb_Nombre.Checked = true;

            deffac();


            
            dt = sql.tablas("productos", "select IDProducto,nombreproducto,P_venta,existencias from productos");
            if (dt.Rows.Count > 0)
            {
                dtgv_ProductosV.DataSource = dt;
                dtgv_ProductosV.Columns[0].HeaderText = "Codigo";
                dtgv_ProductosV.Columns[1].HeaderText = "Nombre";
                dtgv_ProductosV.Columns[2].HeaderText = "Precio";

                dtgv_ProductosV.Columns[3].Visible = false;
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
            if (chb_Credito.Checked) {
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
        private int idcredito = 0;
        private void btn_BsCliente_Click(object sender, EventArgs e)
        {
            v_VentasCli mensaje = new v_VentasCli();
            mensaje.ShowDialog();

            if (mensaje.DialogResult == DialogResult.OK) {
                txt_NomCliente.Text = mensaje.nombrec;
                cedula = mensaje.cedulacli;
                monto = mensaje.monto;
                idcredito = mensaje.idcredito;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        int fila;
        float total = 0;
        private void dtgv_ProductosV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            fila = dtgv_ProductosV.CurrentRow.Index;//Variable que guarda la fila seleccionada
            dtgv_Factura.Rows.Insert(0, dtgv_ProductosV.Rows[fila].Cells[0].Value, dtgv_ProductosV.Rows[fila].Cells[1].Value,"1",dtgv_ProductosV.Rows[fila].Cells[2].Value);
            float vp = float.Parse(dtgv_ProductosV.Rows[fila].Cells[2].Value.ToString());
            total +=  vp;//Variable que almacena el total de venta
            dtgv_Factura.Rows[dtgv_Factura.RowCount - 1].Cells[3].Value = "" + total;
        }

        private void btn_Remover_Click(object sender, EventArgs e)
        {
            if (dtgv_Factura.Rows.Count > 1)
            {
                //total = total - float.Parse(dtgv_Factura.Rows[dtgv_Factura.CurrentRow.Index].Cells[2].Value.ToString());//Variable que almacena el total de vent
                float multi = 0;
                int temp = 0;
                temp = int.Parse(dtgv_Factura.Rows[dtgv_Factura.CurrentRow.Index].Cells[2].Value.ToString());
                multi = temp * float.Parse(dtgv_Factura.Rows[dtgv_Factura.CurrentRow.Index].Cells[3].Value.ToString());
                total -= multi;
                dtgv_Factura.Rows[dtgv_Factura.RowCount - 1].Cells[3].Value = "" + total;
                dtgv_Factura.Rows.Remove(dtgv_Factura.CurrentRow);
            }
            else {
                MessageBox.Show("No quedan productos por remover", "No hay productos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_Finalizar_Click(object sender, EventArgs e)
        {
            if (dtgv_Factura.Rows.Count > 1)
            {
                DialogResult venta = MessageBox.Show("¿Es correcta la venta?", "", MessageBoxButtons.YesNo);

                //Informacion de la factura a la base de datos ki
                if (venta == DialogResult.Yes){ 

                    if (chb_Credito.Checked == false)
                    {
                        sql.multiple("insert into factura (monto,fecha) values (" + total + ",'" + string.Format("{0: MM-dd-yyyy}", DateTime.Today) + "')");
                        ventas();
                    }
                    else if (chb_Credito.Checked == true && txt_NomCliente.Text != "")
                    {
                        credito();
                        limpventac();
                        sql.multiple("insert into factura (monto,fecha,cliente) values (" + total + ",'" + string.Format("{0: MM-dd-yyyy}", DateTime.Today) + "', '" + txt_NomCliente.Text + "')");
                        ventas();
                    }
                    else
                    {
                        MessageBox.Show("Seleccione un cliente para realizar la venta al credito","Seleccione un cliente",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }

                }
            }
            else
            {
                MessageBox.Show("Para realizar una venta primero tiene que ingresar productos", "No hay productos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void ventas() {
            
            for (int i = 0; i < dtgv_Factura.Rows.Count - 1; i++)
            {
                sql.multiple("insert into detalle (IDproducto,IDfactura,cantidadcompra) values " +
                    "('" + dtgv_Factura.Rows[i].Cells[0].Value.ToString() + "'," + nfactura() + ","+dtgv_Factura.Rows[i].Cells[2].Value.ToString() +")");
            }

            dtgv_Factura.Rows.Clear();

            dtgv_Factura.Rows[dtgv_Factura.RowCount - 1].Cells[0].Value = "Total";

            total = 0;
            dtgv_Factura.Rows[dtgv_Factura.RowCount - 1].Cells[2].Value = "" + total;
        }

        private void credito() {
            monto = monto + total;
            sql.multiple("Execute SpActMonto @monto = "+monto+", @cedula = N'"+cedula+"'");
            
            for (int i = 0; i < dtgv_Factura.Rows.Count - 1; i++)
            {
                sql.multiple("exec SpInsertarDetCreditoV @idc = "+idcredito+" ,@idprod = N'"+ dtgv_Factura.Rows[i].Cells[0].Value.ToString() + "' ,@cantidad = " + dtgv_Factura.Rows[i].Cells[2].Value.ToString());
            }
        }

        private String nfactura() {
            DataTable nfac;
            nfac = sql.tablas("factura", "select IDfactura from factura");
            return nfac.Rows[nfac.Rows.Count - 1][0].ToString();
        }


        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            if (dtgv_Factura.Rows.Count > 1)
            {
                DialogResult venta = MessageBox.Show("¿Desea cancelar esta venta?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (venta == DialogResult.Yes)
                {
                    dtgv_Factura.Rows.Clear();

                    dtgv_Factura.Rows[dtgv_Factura.RowCount - 1].Cells[0].Value = "Total";

                    if (chb_Credito.Checked)
                    {
                        limpventac();
                    }
                }
            }
            else
            {
                MessageBox.Show("Para eliminar una venta primero tiene que ingresar productos", "No hay productos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deffac()
        {
            dtgv_Factura.Columns.Add("", "Codigo");
            dtgv_Factura.Columns.Add("", "Nombre");
            dtgv_Factura.Columns.Add("", "Cantidad");
            dtgv_Factura.Columns.Add("", "Precio");

            dtgv_Factura.ReadOnly = true;
            dtgv_Factura.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dtgv_Factura.AllowUserToResizeRows = false;

            //dtgv_Factura.Rows.Add();
            dtgv_Factura.Rows[dtgv_Factura.RowCount - 1].Cells[0].Value = "Total";
        }

        private void limpventac()
        {
            chb_Credito.Checked = false;
            txt_NomCliente.Clear();
            cedula = "";
            monto = 0;
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            if (rb_Nombre.Checked) {
                dt = sql.tablas("productos", "select IDProducto,nombreproducto,P_venta from productos where nombreproducto like '%" + txt_B.Text + "%'");
            }
            else if (rb_Id.Checked){
                dt = sql.tablas("productos", "select IDProducto,nombreproducto,P_venta from productos where IDProducto like '%" + txt_B.Text + "%'");
            }
            else if(txt_B.Text == ""){
                dt = sql.tablas("productos", "select IDProducto,nombreproducto,P_venta from productos");
            }

            if (dt.Rows.Count > 0)
            {
                dtgv_ProductosV.DataSource = dt;
                dtgv_ProductosV.Columns[0].HeaderText = "Codigo";
                dtgv_ProductosV.Columns[1].HeaderText = "Nombre";
                dtgv_ProductosV.Columns[2].HeaderText = "Precio";
            }

        }

        private void dtgv_Factura_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string input = Interaction.InputBox("Ingrese la cantidad que vende del articulo", "Cantidad","0", this.Width/2, this.Height/2);
            
            try {
                if (int.Parse(input) > 0)
                {
                    //Si la cantidad que se ingresa de producto es superior a la existencia
                    if (int.Parse(input) < int.Parse(dtgv_ProductosV.Rows[dtgv_ProductosV.CurrentRow.Index].Cells[3].Value.ToString())){
                        
                        float multi = 0;

                        //Si el valor del inputbox es mayor que la cantidad en la factura
                        if (int.Parse(input) > int.Parse(dtgv_Factura.Rows[dtgv_Factura.CurrentRow.Index].Cells[2].Value.ToString()))
                        {
                            //Multiplica el nuevo valor por el precio del producto para calcular el total
                            multi = float.Parse(dtgv_Factura.Rows[dtgv_Factura.CurrentRow.Index].Cells[3].Value.ToString()) * float.Parse(input);

                            //Se resta la existencia en el datagridview de productos para luego hacer la actualizacion
                            dtgv_ProductosV.Rows[dtgv_ProductosV.CurrentRow.Index].Cells[3].Value = int.Parse(dtgv_ProductosV.Rows[dtgv_ProductosV.CurrentRow.Index].Cells[3].Value.ToString()) - int.Parse(input);

                            total += multi - float.Parse(dtgv_Factura.Rows[dtgv_Factura.CurrentRow.Index].Cells[3].Value.ToString());
                            //Suma el resultado

                        }
                        else
                        {
                            int temp = 0;//Variable temporal para guardar la cantidad que se le va a remover a la factura
                                         //Se almacena el resutlado de la resta de la cantidad en el inputbox con la cantidad de la factura
                            temp = int.Parse(dtgv_Factura.Rows[dtgv_Factura.CurrentRow.Index].Cells[2].Value.ToString()) - int.Parse(input);
                            //Se resta la existencia en el datagridview de productos para luego hacer la actualizacion
                            dtgv_ProductosV.Rows[dtgv_ProductosV.CurrentRow.Index].Cells[3].Value = int.Parse(dtgv_ProductosV.Rows[dtgv_ProductosV.CurrentRow.Index].Cells[3].Value.ToString()) + temp;

                            //Se multiplica el nuevo precio de ese conjunto
                            multi = temp * float.Parse(dtgv_Factura.Rows[dtgv_Factura.CurrentRow.Index].Cells[3].Value.ToString());
                            //Se le resta el resultado al total
                            total -= multi;
                        }
                        // Se agrega la nueva cantidad a la factura
                        dtgv_Factura.Rows[dtgv_Factura.CurrentRow.Index].Cells[2].Value = input;
                        //Se agrega el nuevo valor a total
                        dtgv_Factura.Rows[dtgv_Factura.RowCount - 1].Cells[3].Value = "" + total;

                    }
                    else {
                        MessageBox.Show("No Hay suficiente producto","Error en la cantidad",MessageBoxButtons.OK);
                    }

                }
                else
                {
                    MessageBox.Show("La cantidad tiene que ser superior a 0", "Error en la cantidad", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
            catch (Exception z)
            {
                MessageBox.Show("Solo se permite el ingreso de numeros","Error en la cantidad",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }

        }
    }
}
