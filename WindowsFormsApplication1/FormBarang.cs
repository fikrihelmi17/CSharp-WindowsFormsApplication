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
    public partial class FormBarang : Form
    {
        public SqlCommand cmd;
        public SqlDataReader reader;
        koneksiDB connDb = new koneksiDB();

        public FormBarang()
        {
            InitializeComponent();
        }

        private void FormBarang_Load(object sender, EventArgs e)
        {

        }

        public void clearText()
        {
            txtKodeBarang.Text = "";
            txtNamaBarang.Text = "";
            txtSatuan.Text = "";
            txtStok.Text = "";
            txtHarga.Text = "";

        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            connDb.koneksi();

            string KodeBarang = txtKodeBarang.Text;
            string NamaBarang = txtNamaBarang.Text;
            string Satuan = txtSatuan.Text;
            string Stok = txtStok.Text;
            string Harga = txtHarga.Text;

            string sql = "INSERT INTO TBarang (kode_barang,nama_barang,satuan,stok,harga) VALUES(" +
                "'" + KodeBarang + "','" + NamaBarang + "'," +
                "'" + Satuan + "','" + Stok + "'," +
                "'" + Harga + "')";

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
