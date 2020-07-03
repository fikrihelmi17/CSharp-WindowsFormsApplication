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
    public partial class FormUser : Form
    {
        public SqlCommand cmd;
        public SqlDataReader reader;
        koneksiDB connDb = new koneksiDB();

        public FormUser()
        {
            InitializeComponent();
        }

        public void clearText()
        {
            txtIdUser.Text = "";
            txtNamaLengkap.Text = "";
            txtNamaUser.Text = "";
            txtPassword.Text = "";
        }



        private void FormUser_Load(object sender, EventArgs e)
        {

        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            clearText();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            connDb.koneksi();

            string IdUser = txtIdUser.Text;
            string NamaLengkap = txtNamaLengkap.Text;
            string NamaUser = txtNamaUser.Text;
            string Password = txtPassword.Text;

            string sql = "INSERT INTO TUser (id_user,nama_lengkap,nama_user,password) VALUES(" +
                "'" + IdUser + "','" + NamaLengkap + "'," +
                "'" + NamaUser + "','" + Password + "')";

            cmd = new SqlCommand(sql, connDb.conn);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data berhasil tersimpan");
                clearText();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Data Tidak Berhasil Disimpan" + ex.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormMaster objFormMaster = new FormMaster();
            this.Hide();
            objFormMaster.Show();
        }
    }
}
