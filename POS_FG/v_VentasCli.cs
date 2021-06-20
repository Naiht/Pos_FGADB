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
    public partial class v_VentasCli : Form
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
        private void pb_Cerrar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
        private void lbl_NombreV_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion


        public string nombrec {get; set;}
        public string cedulacli { get; set; }
        public float monto { get; set; }
        public v_VentasCli()
        {
            InitializeComponent();
        }

        sqlcon2 sql = new sqlcon2();
        private void v_proveedor_Load(object sender, EventArgs e)
        {

            dtgv_Clientes.ReadOnly = true;
            dtgv_Clientes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dtgv_Clientes.AllowUserToResizeRows = false;


            DataTable dt;
            dt = sql.tablas("credito", "Select nombrecliente, cedulacliente, monto, direccioncliente, telefono, estadocredito from credito");
            if (dt.Rows.Count > 0)
            {
                dtgv_Clientes.DataSource = dt;
                dtgv_Clientes.Columns[0].HeaderText = "Nombre";
                dtgv_Clientes.Columns[1].HeaderText = "Cedula";
                dtgv_Clientes.Columns[2].HeaderText = "Monto";
                dtgv_Clientes.Columns[3].HeaderText = "Dirección";
                dtgv_Clientes.Columns[4].HeaderText = "Telefono";

                dtgv_Clientes.Columns.Remove("estadocredito");
            }
        }

        private void btn_Registrar_Click(object sender, EventArgs e)
        {
            if (dtgv_Clientes.SelectedRows != null)
            {
                DialogResult = DialogResult.OK;

                nombrec = dtgv_Clientes.CurrentRow.Cells[0].Value.ToString();
                cedulacli = dtgv_Clientes.CurrentRow.Cells[1].Value.ToString();
                monto = float.Parse(dtgv_Clientes.CurrentRow.Cells[2].Value.ToString());

                this.Close();
            }
            else {
                MessageBox.Show("Seleccione un cliente o precione canclear","Seleccoine un cliente",MessageBoxButtons.OK);
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btn_AgrCliente_Click(object sender, EventArgs e)
        {
            v_AgregCliente mensaje = new v_AgregCliente();
            mensaje.ShowDialog();

            if (mensaje.DialogResult == DialogResult.OK)
            {
                nombrec = mensaje.nombrec;
                cedulacli = mensaje.cedulacli;
                monto = mensaje.monto;
            }
        }
    }
}
