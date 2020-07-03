using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data.OleDb;

namespace WindowsFormsApplication1
{
    public partial class FormPenjualan : Form
    {
        public SqlCommand cmd;
        public SqlDataReader reader;

        int harga;
        int jumlah;
        int subTotal;
        int total;
        int pajak;
        int totalBayar;
        int sisa;
        int jumlahBayar;
        int kembali;
        int i = 0;
        int no = 1;

        string kodeBarang;
        int jumlahBarang;

        int totalRows;

        string fakturDB, no_faktur;
        int fakturNo;
       
        koneksiDB connDb = new koneksiDB();

        void isiComboID()
        {
            connDb.koneksi();

            try
            {
                string sql = "SELECT id_customer FROM TCustomer";


                cmd = new SqlCommand(sql, connDb.conn);

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cmbIdCustomer.Items.Add(reader[0]);
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

        void isiComboKode()
        {
            connDb.koneksi();

            try
            {
                string sql = "SELECT kode_barang FROM TBarang";


                cmd = new SqlCommand(sql, connDb.conn);

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cmbKodeBarang.Items.Add(reader[0]);

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

        private void button1_Click(object sender, EventArgs e)
        {
            FormMaster objFormMaster = new FormMaster();
            this.Hide();
            objFormMaster.Show();
        }

        

        void NoFaktur()
        {
            connDb.koneksi();
            DateTime now = DateTime.Now;
            string finalMonth, finalYear;

            if (now.Month > 9)
            {
                finalMonth = Convert.ToString(now.Month);
            }
            else
            {
                finalMonth = "0" + Convert.ToString(now.Month);
            }

            try
            {
                string query = "SELECT TOP 1 no_faktur FROM THead_Penjualan ORDER BY no_faktur DESC";

                cmd = new SqlCommand(query, connDb.conn);
                reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    fakturDB = Convert.ToString(reader[0]);
                    fakturNo = Convert.ToInt32(fakturDB.Substring(6));
                    fakturNo = fakturNo + 1;
                    MessageBox.Show(Convert.ToString(fakturNo));
                    if (fakturNo > 9)
                    {
                        no_faktur = "00" + Convert.ToString(fakturNo);
                    }
                    else if (fakturNo > 99)
                    {
                        no_faktur = "0" + Convert.ToString(fakturNo);
                    }
                    else if (fakturNo > 999)
                    {
                        no_faktur = Convert.ToString(fakturNo);
                    }
                    else
                    {
                        no_faktur = "000" + Convert.ToString(fakturNo);
                    }
                }
                else
                {
                    no_faktur = "0001";
                }
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }

            }

            finalYear = now.ToString("yy");

            txtFaktur.Text = "FJ" + finalMonth + finalYear + no_faktur;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cmbIdCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            connDb.koneksi();

            try
            {
                string sql = "SELECT * FROM TCustomer WHERE id_customer = '" + cmbIdCustomer.Text + "'";

                cmd = new SqlCommand(sql, connDb.conn);

                reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    txtNamaCustomer.Text = reader[1].ToString();
                    rtbAlamat.Text = reader[2].ToString();
                    txtNoTelepon.Text = reader[3].ToString();
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

        private void txtJumlah_TextChanged(object sender, EventArgs e)
        {
            //int sisa;
            sisa = Convert.ToInt32(txtJumlahBayar.Text) - totalBayar;
            txtKembali.Text = Convert.ToString(sisa);
        }

        private void cmbKodeBarang_SelectedIndexChanged(object sender, EventArgs e)
        {
            connDb.koneksi();

            try
            {
                string sql = "SELECT * FROM TBarang WHERE kode_barang = '" + cmbKodeBarang.Text + "'";

                cmd = new SqlCommand(sql, connDb.conn);

                reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    txtNamaBarang.Text = reader[1].ToString();
                    txtSatuan.Text = reader[2].ToString();
                    txtHarga.Text = reader[4].ToString();
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

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            connDb.koneksi();
           
            try
            {
                string sql = "INSERT INTO THead_Penjualan VALUES(" +
                "'" + txtFaktur.Text + "','" + dtpTanggal.Text + "'," +
                "'" + cmbIdCustomer.Text + "','" + txtTotal.Text + "'," +
                "'" + txtPajak.Text + "')";

                cmd = new SqlCommand(sql, connDb.conn);

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data berhasil tersimpan");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Data Tidak Berhasil Disimpan" + ex.ToString());
                }

                for (int j = 0; j < totalRows; j++)
                {
                    kodeBarang = dgvBarang.Rows[j].Cells[1].Value.ToString();
                    jumlahBarang = Convert.ToInt32(dgvBarang.Rows[j].Cells[6].Value.ToString());

                    string query = "INSERT INTO TDetail_Penjualan VALUES(" +
                        "'" + txtFaktur.Text + "','" + kodeBarang + "'," +
                        "'" + jumlahBarang + "')";

                    cmd = new SqlCommand(query, connDb.conn);
                    cmd.ExecuteNonQuery();
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

        private void btnBatal_Click(object sender, EventArgs e)
        {
            txtFaktur.Text = "";
            cmbIdCustomer.SelectedIndex = -1;
            txtNamaCustomer.Text = "";
            txtNoTelepon.Text = "";
            rtbAlamat.Text = "";
            cmbKodeBarang.SelectedIndex = 0;
            txtNamaBarang.Text = "";
            txtSatuan.Text = "";
            txtHarga.Text = "";
            txtJumlah.Text = "";
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            jumlah = Convert.ToInt32(txtJumlah.Text);
            harga = Convert.ToInt32(txtHarga.Text);
            subTotal = jumlah * harga;

            dgvBarang.Rows.Add();
            dgvBarang.Rows[i].Cells[0].Value = no;
            dgvBarang.Rows[i].Cells[1].Value = cmbKodeBarang.Text;
            dgvBarang.Rows[i].Cells[2].Value = txtNamaBarang.Text;
            dgvBarang.Rows[i].Cells[3].Value = txtSatuan.Text;
            dgvBarang.Rows[i].Cells[4].Value = txtHarga.Text;
            dgvBarang.Rows[i].Cells[5].Value = jumlah;
            dgvBarang.Rows[i].Cells[6].Value = subTotal;

            no++;
            i++;

            total = total + subTotal;
            pajak = total / 10;
            totalBayar = total + pajak;

            txtTotal.Text = Convert.ToString(total);
            txtPajak.Text = Convert.ToString(pajak);
            txtTotalBayar.Text = Convert.ToString(totalBayar);
        }

        public FormPenjualan()
        {
            InitializeComponent();
            isiComboID();
            isiComboKode();
            NoFaktur();

        }


    }
}
