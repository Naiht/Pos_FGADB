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
    public partial class v_VSuministro : Form
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

        private void pb_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pb_Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion

        public v_VSuministro()
        {
            InitializeComponent();
        }

        private void v_VSuministro_Load(object sender, EventArgs e)
        {
            
            dtgv_suministro.ReadOnly = true;
            dtgv_suministro.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dtgv_suministro.AllowUserToAddRows = false;

            dtgv_facturas.ReadOnly = true;
            dtgv_facturas.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dtgv_facturas.AllowUserToAddRows = false;

            rb_numfactura.Checked = true;

            consulta(true, "");
        }
        //prueba
        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            if (rb_numfactura.Checked)
            {
                if (txt_numfactura.Text != "")
                {
                    consulta(false, txt_numfactura.Text);
                }
                else
                {
                    dtgv_suministro.DataSource = null;
                    consulta(true, "");
                }
            }
            else
            {
                if (rb_Rango.Checked)
                {
                    if (dtp_finicial.Value < dtp_ffinal.Value)
                    {
                        DataTable dt;
                        dt = sql.tablas("suministro", "select numfacturasuministra AS [NUMERO DE FACTURA], sum(montosuministra) as [TOTAL DE LA FACTURA], fechasuministra AS[FECHA] " +
                            "from suministro where fechasuministra BETWEEN '" + string.Format("{0: MM-dd-yyyy}", dtp_finicial.Value) + "' AND '" + string.Format("{0: MM-dd-yyyy}", dtp_ffinal.Value) + "' group by numfacturasuministra,fechasuministra");
                        if (dt.Rows.Count > 0)
                        {
                            dtgv_facturas.DataSource = dt;
                        }
                    }
                    else
                    {
                        MessageBox.Show("la fecha inicial debe ser anterior a la fecha final", "Campos incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void consulta(bool normal, string factura)
        {
            DataTable dt;
            if (normal)
            {
                dt = sql.tablas("suministro", "select numfacturasuministra AS[NUMERO DE FACTURA], sum(montosuministra) AS[TOTAL DE LA FACTURA], fechasuministra AS[FECHA] from suministro group by numfacturasuministra, fechasuministra");
            }
            else
            {
                dt = sql.tablas("suministro", "select numfacturasuministra AS [NUMERO DE FACTURA],sum(montosuministra) AS [TOTAL DE LA FACTURA],fechasuministra AS[FECHA] from suministro where numfacturasuministra ="+int.Parse(factura)+" group by numfacturasuministra,fechasuministra");
            }
            if (dt.Rows.Count > 0)
            {
                dtgv_facturas.DataSource = dt;
            }
        }


        private void txt_numfactura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                //permite solo introducir numeros
                e.Handled = false;
            }
            else
            {
                if (char.IsControl(e.KeyChar))
                {
                    //permite teclas de control
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;//desactiva el resto de teclas pulsadas
                }
            }
        }

        private void dtgv_facturas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            DataTable dt;
            dt = sql.tablas("productos", "SELECT DISTINCT p.nombreproducto AS [Nombre Producto],d.cantidadsuministra AS [Cantidad], p.P_venta AS [Precio de compra] FROM productos p INNER JOIN " +
                "suministro d ON p.IDproducto=d.IDproducto and numfacturasuministra = " + int.Parse(dtgv_facturas.CurrentRow.Cells[0].Value.ToString()));
            if (dt.Rows.Count > 0)
            {
                dtgv_suministro.DataSource = dt;
            }
        }

        private void rb_todo_CheckedChanged(object sender, EventArgs e)
        {
            consulta(true, "");
            rb_todo.Checked = false;
            rb_numfactura.Checked = true;
            dtgv_suministro.DataSource = null;
        }
    }
}
