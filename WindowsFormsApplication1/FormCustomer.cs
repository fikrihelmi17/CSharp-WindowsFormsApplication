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
    public partial class FormCustomer : Form
    {

        public SqlCommand cmd;
        public SqlDataReader reader;
        koneksiDB connDb = new koneksiDB();

        public FormCustomer()
        {
            InitializeComponent();
        }

        public void clearText()
        {
            txtIdCustomer.Text = "";
            txtNamaCustomer.Text = "";
            txtAlamat.Text = "";
            txtTelepon.Text = "";

        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            connDb.koneksi();

            string IdCustomer = txtIdCustomer.Text;
            string NamaCustomer = txtNamaCustomer.Text;
            string Alamat = txtAlamat.Text;
            string Telepon = txtTelepon.Text;

            string sql = "INSERT INTO TCustomer (id_customer,nama_customer,alamat,telepon) VALUES(" +
                "'" + IdCustomer + "','" + NamaCustomer + "'," +
                "'" + Alamat + "','" + Telepon + "')";

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

        private void FormCustomer_Load(object sender, EventArgs e)
        {

        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            clearText();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormMaster objFormMaster = new FormMaster();
            this.Hide();
            objFormMaster.Show();
        }
    }
}
