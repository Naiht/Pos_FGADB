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
        public int idcredito { get; set; }
        public v_VentasCli()
        {
            InitializeComponent();
        }




        public string enombrec { get; set; }
        public string ecedulacli { get; set; }
        public float emonto { get; set; }
        public string edireccion { get; set; }
        public int etelefono { get; set; }
        public int eestado { get; set; }
        public bool funcion { get; set; }


        sqlcon2 sql = new sqlcon2();

        private void v_proveedor_Load(object sender, EventArgs e)
        {
            dtgv_Clientes.ReadOnly = true;
            dtgv_Clientes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dtgv_Clientes.AllowUserToResizeRows = false;


            DataTable dt;
            dt = sql.tablas("credito", "Select nombrecliente, cedulacliente, monto, direccioncliente, telefono, estadocredito, IDcredito from credito where estadocredito = 1");
            if (dt.Rows.Count > 0)
            {
                if (funcion == false)
                {
                    dtgv_Clientes.DataSource = dt;
                    dtgv_Clientes.Columns[0].HeaderText = "Nombre";
                    dtgv_Clientes.Columns[1].HeaderText = "Cedula";
                    dtgv_Clientes.Columns[2].HeaderText = "Monto";
                    dtgv_Clientes.Columns[3].HeaderText = "Dirección";
                    dtgv_Clientes.Columns[4].HeaderText = "Telefono";
                    dtgv_Clientes.Columns[5].HeaderText = "ID";

                    dtgv_Clientes.Columns.Remove("estadocredito");
                }
                else
                {
                    dtgv_Clientes.DataSource = dt;
                    dtgv_Clientes.Columns[0].HeaderText = "Nombre";
                    dtgv_Clientes.Columns[1].HeaderText = "Cedula";
                    dtgv_Clientes.Columns[2].HeaderText = "Monto";
                    dtgv_Clientes.Columns[3].HeaderText = "Dirección";
                    dtgv_Clientes.Columns[4].HeaderText = "Telefono";
                    dtgv_Clientes.Columns[5].HeaderText = "Estado del credito";
                    btn_AgrCliente.Visible = false;
                }


            }
        }

        //BotonAceptar
        private void btn_Registrar_Click(object sender, EventArgs e)
        {
            if (dtgv_Clientes.SelectedRows != null)
            {
                if (funcion == false)
                {
                    DialogResult = DialogResult.OK;

                    nombrec = dtgv_Clientes.CurrentRow.Cells[0].Value.ToString();
                    cedulacli = dtgv_Clientes.CurrentRow.Cells[1].Value.ToString();
                    monto = float.Parse(dtgv_Clientes.CurrentRow.Cells[2].Value.ToString());
                    idcredito = int.Parse(dtgv_Clientes.CurrentRow.Cells[5].Value.ToString());
                    this.Close();
                }
                else {
                    DialogResult = DialogResult.OK;

                    enombrec = dtgv_Clientes.CurrentRow.Cells[0].Value.ToString();
                    ecedulacli = dtgv_Clientes.CurrentRow.Cells[1].Value.ToString();
                    emonto = float.Parse(dtgv_Clientes.CurrentRow.Cells[2].Value.ToString());
                    edireccion = dtgv_Clientes.CurrentRow.Cells[3].Value.ToString();
                    etelefono = int.Parse(dtgv_Clientes.CurrentRow.Cells[4].Value.ToString());
                    eestado = int.Parse(dtgv_Clientes.CurrentRow.Cells[5].Value.ToString());
                    this.Close();
                }

            }
            else {
                MessageBox.Show("Seleccione un cliente o precione canclear","Seleccoine un cliente",MessageBoxButtons.OK);
            }
        }
        //Boton aceptar fin
        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btn_AgrCliente_Click(object sender, EventArgs e)
        {
            v_AgregCliente mensaje2 = new v_AgregCliente();
            mensaje2.ShowDialog();

            if (mensaje2.DialogResult == DialogResult.OK)
            {
                nombrec = mensaje2.nombreca;
                cedulacli = mensaje2.cedulaclia;
                this.DialogResult = DialogResult.OK;

                this.Close();
            }
        }
    }
}
