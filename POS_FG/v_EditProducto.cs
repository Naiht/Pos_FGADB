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
            dtgv_Producos.ReadOnly = true;
            dtgv_Producos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dtgv_Producos.AllowUserToAddRows = false;

            DataTable dt;
            dt = sql.tablas("productos", "SELECT IDproducto,nombreproducto, inventario_max,inventario_min,existencias,P_venta,P_compra FROM productos");
            if (dt.Rows.Count > 0)
            {
                dtgv_Producos.DataSource = dt;
            }
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            if (txt_Busqueda.Text != "")
            {
                if (rb_id.Checked)
                {
                    foreach (DataGridViewRow Row in dtgv_Producos.Rows)
                    {
                        String strFila = Row.Index.ToString();
                        string Valor = Convert.ToString(Row.Cells[0].Value);

                        if (Valor == this.txt_Busqueda.Text)
                        {
                            txt_NomProducto.Text = Convert.ToString(dtgv_Producos.Rows[int.Parse(strFila)].Cells[1].Value);
                            txt_Inv_Max.Text = Convert.ToString(dtgv_Producos.Rows[int.Parse(strFila)].Cells[2].Value);
                            txt_Inv_min.Text = Convert.ToString(dtgv_Producos.Rows[int.Parse(strFila)].Cells[3].Value);
                            txt_Precio_Compra.Text = Convert.ToString(dtgv_Producos.Rows[int.Parse(strFila)].Cells[6].Value);
                            txt_Precio_Venta.Text = Convert.ToString(dtgv_Producos.Rows[int.Parse(strFila)].Cells[5].Value);
                        }
                    }
                }
                else
                {
                    if (rb_nombre.Checked)
                    {
                        foreach (DataGridViewRow Row in dtgv_Producos.Rows)
                        {
                            String strFila = Row.Index.ToString();
                            string Valor = Convert.ToString(Row.Cells[1].Value);

                            if (Valor == this.txt_Busqueda.Text)
                            {
                                txt_NomProducto.Text = Convert.ToString(dtgv_Producos.Rows[int.Parse(strFila)].Cells[1].Value);
                                txt_Inv_Max.Text = Convert.ToString(dtgv_Producos.Rows[int.Parse(strFila)].Cells[2].Value);
                                txt_Inv_min.Text = Convert.ToString(dtgv_Producos.Rows[int.Parse(strFila)].Cells[3].Value);
                                txt_Precio_Compra.Text = Convert.ToString(dtgv_Producos.Rows[int.Parse(strFila)].Cells[6].Value);
                                txt_Precio_Venta.Text = Convert.ToString(dtgv_Producos.Rows[int.Parse(strFila)].Cells[5].Value);
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("La casilla buscar no puede estar vacia ", "Campos incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        int fila;
        private void dtgv_Producos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            fila = 0;
            fila = dtgv_Producos.CurrentRow.Index;

            txt_NomProducto.Text = dtgv_Producos.Rows[fila].Cells[1].Value.ToString();
            txt_Inv_Max.Text = dtgv_Producos.Rows[fila].Cells[2].Value.ToString();
            txt_Inv_min.Text = dtgv_Producos.Rows[fila].Cells[3].Value.ToString();
            txt_Precio_Compra.Text = dtgv_Producos.Rows[fila].Cells[6].Value.ToString();
            txt_Precio_Venta.Text = dtgv_Producos.Rows[fila].Cells[5].Value.ToString();
        }
    }
}
