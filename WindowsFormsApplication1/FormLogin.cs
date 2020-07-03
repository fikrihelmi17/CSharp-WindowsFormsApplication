using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.Sql;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class FormLogin : Form
    {
        public SqlCommand cmd;
        public SqlDataReader reader;

        koneksiDB connDb = new koneksiDB();
        public FormLogin()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            koneksiDB connDb = new koneksiDB();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            connDb.koneksi();

            try
            {
                string username = txtUsername.Text.Trim();
                string password = txtPassword.Text.Trim();

                string sql = "SELECT * FROM TUser WHERE nama_user='" + username + "' and password='" + password + "'";
                cmd = new SqlCommand(sql, connDb.conn);
                reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    FormMaster objFormMaster = new FormMaster();
                    this.Hide();
                    objFormMaster.Show();
                }
                else
                {
                    MessageBox.Show("Username dan Password Salah !!!");
                }
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
            }

        }
    }
}
