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
    public partial class v_VerCredito : Form
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

        public v_VerCredito()
        {
            InitializeComponent();
        }


        private void v_VerCredito_Load(object sender, EventArgs e)
        {
            dtgv_Creditos.ReadOnly = true;
            dtgv_Creditos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dtgv_Creditos.AllowUserToResizeRows = false;

            consultaglobal(true,"");
        }


        private void consultaglobal(bool normal, string nombre) {
            DataTable dt;
            if (normal)
            {
                dt = sql.tablas("credito", "Select nombrecliente, cedulacliente, monto, direccioncliente, fecha_limite ,telefono, estadocredito from credito ");

            }
            else {
                dt = sql.tablas("credito", "Select nombrecliente, cedulacliente, monto, direccioncliente, fecha_limite ,telefono, estadocredito from credito where nombrecliente like '%"+nombre+ "%'");

            }            
            if (dt.Rows.Count > 0)
            {
                dtgv_Creditos.DataSource = dt;
                dtgv_Creditos.Columns[0].HeaderText = "Nombre";
                dtgv_Creditos.Columns[1].HeaderText = "Cedula";
                dtgv_Creditos.Columns[2].HeaderText = "Monto";
                dtgv_Creditos.Columns[3].HeaderText = "Dirección";
                dtgv_Creditos.Columns[4].HeaderText = "Fecha limite";
                dtgv_Creditos.Columns[5].HeaderText = "Telefono";
                dtgv_Creditos.Columns[6].HeaderText = "Activo/No Activo";
            }
        }

        private void btn_BsCliente_Click(object sender, EventArgs e)
        {
            if (txt_Nombre.Text != "")
            {
                consultaglobal(false, txt_Nombre.Text);
                btn_Limpiar.Enabled = true;
            }
            else {
                consultaglobal(true, "");
            }
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            txt_Nombre.Clear();
            consultaglobal(true,"");
            txt_Nombre.Text = "";
            btn_Limpiar.Enabled = false;
        }

    }
}
