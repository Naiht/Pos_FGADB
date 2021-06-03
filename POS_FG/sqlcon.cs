using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rgb
{
    class sqlcon
    {
        private string cadena = "Data Source=(local);Initial Catalog=rgb;Integrated Security=True";
        private SqlConnection coneccion;
        private SqlCommand comando;

        public sqlcon()
        {
            coneccion = new SqlConnection(cadena);
        }

        public bool multiple(String query)
        {
            coneccion.Open();
            comando = new SqlCommand();

            comando.CommandText = query;
            comando.Connection = coneccion;
            int i = comando.ExecuteNonQuery();

            coneccion.Close();
            if (i > 0)
            {
                return true;
            }
            else {
                return false;
            }
        }

        public DataTable tablas(string tabla,string sql)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da;
            DataTable dt = new DataTable();
            da = new SqlDataAdapter(sql, coneccion);
            da.Fill(ds,tabla);
            dt = ds.Tables[tabla];
            return (dt);
        }
    }
}
