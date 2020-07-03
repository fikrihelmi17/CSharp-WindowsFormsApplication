using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    class koneksiDB
    {
        public SqlConnection conn = null;
        public string connStr;

        public void koneksi()
        {
            connStr = "Server=Fikri\\SQLEXPRESS; Database=Penjualan_0617104005; Integrated Security = True";

            try
            {
                conn = new SqlConnection(connStr);
                conn.Open();
                //MessageBox.Show("Connection Open");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Cannot open connection" + ex.ToString());
            }
        }
    }
}
