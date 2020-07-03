using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class FormMaster : Form
    {
        public FormMaster()
        {
            InitializeComponent();
        }

        private void FormMaster_Load(object sender, EventArgs e)
        {

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLogin objFormLogin = new FormLogin();
            this.Hide();
            objFormLogin.Show();
        }

        private void penjualanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPenjualan objFormPenjualan = new FormPenjualan();
            this.Hide();
            objFormPenjualan.Show();
        }

        private void barangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBarang objFormBarang = new FormBarang();
            this.Hide();
            objFormBarang.Show();
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCustomer objFormCustomer = new FormCustomer();
            this.Hide();
            objFormCustomer.Show();
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUser objFormUser = new FormUser();
            this.Hide();
            objFormUser.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
