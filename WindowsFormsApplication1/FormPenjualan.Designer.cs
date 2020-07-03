namespace WindowsFormsApplication1
{
    partial class FormPenjualan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtFaktur = new System.Windows.Forms.TextBox();
            this.txtNamaCustomer = new System.Windows.Forms.TextBox();
            this.txtNoTelepon = new System.Windows.Forms.TextBox();
            this.txtNamaBarang = new System.Windows.Forms.TextBox();
            this.txtSatuan = new System.Windows.Forms.TextBox();
            this.dtpTanggal = new System.Windows.Forms.DateTimePicker();
            this.txtHarga = new System.Windows.Forms.TextBox();
            this.txtJumlah = new System.Windows.Forms.TextBox();
            this.btnTambah = new System.Windows.Forms.Button();
            this.cmbKodeBarang = new System.Windows.Forms.ComboBox();
            this.cmbIdCustomer = new System.Windows.Forms.ComboBox();
            this.dgvBarang = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnBatal = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtPajak = new System.Windows.Forms.TextBox();
            this.txtTotalBayar = new System.Windows.Forms.TextBox();
            this.txtJumlahBayar = new System.Windows.Forms.TextBox();
            this.txtKembali = new System.Windows.Forms.TextBox();
            this.rtbAlamat = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBarang)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "No. Faktur";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Id Customer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nama Customer";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "No. Telepon";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(298, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tanggal";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(298, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Alamat";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Kode Barang";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(132, 164);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Nama Barang";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(248, 164);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Satuan";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(326, 164);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Harga";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(441, 164);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Jumlah";
            // 
            // txtFaktur
            // 
            this.txtFaktur.Location = new System.Drawing.Point(135, 19);
            this.txtFaktur.Name = "txtFaktur";
            this.txtFaktur.Size = new System.Drawing.Size(100, 20);
            this.txtFaktur.TabIndex = 11;
            // 
            // txtNamaCustomer
            // 
            this.txtNamaCustomer.Location = new System.Drawing.Point(135, 79);
            this.txtNamaCustomer.Name = "txtNamaCustomer";
            this.txtNamaCustomer.Size = new System.Drawing.Size(100, 20);
            this.txtNamaCustomer.TabIndex = 12;
            // 
            // txtNoTelepon
            // 
            this.txtNoTelepon.Location = new System.Drawing.Point(135, 112);
            this.txtNoTelepon.Name = "txtNoTelepon";
            this.txtNoTelepon.Size = new System.Drawing.Size(100, 20);
            this.txtNoTelepon.TabIndex = 13;
            // 
            // txtNamaBarang
            // 
            this.txtNamaBarang.Location = new System.Drawing.Point(135, 180);
            this.txtNamaBarang.Name = "txtNamaBarang";
            this.txtNamaBarang.Size = new System.Drawing.Size(100, 20);
            this.txtNamaBarang.TabIndex = 14;
            // 
            // txtSatuan
            // 
            this.txtSatuan.Location = new System.Drawing.Point(251, 180);
            this.txtSatuan.Name = "txtSatuan";
            this.txtSatuan.Size = new System.Drawing.Size(57, 20);
            this.txtSatuan.TabIndex = 15;
            // 
            // dtpTanggal
            // 
            this.dtpTanggal.CustomFormat = "yyyy-MM-dd";
            this.dtpTanggal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTanggal.Location = new System.Drawing.Point(359, 20);
            this.dtpTanggal.Name = "dtpTanggal";
            this.dtpTanggal.Size = new System.Drawing.Size(200, 20);
            this.dtpTanggal.TabIndex = 16;
            // 
            // txtHarga
            // 
            this.txtHarga.Location = new System.Drawing.Point(329, 180);
            this.txtHarga.Name = "txtHarga";
            this.txtHarga.Size = new System.Drawing.Size(100, 20);
            this.txtHarga.TabIndex = 18;
            // 
            // txtJumlah
            // 
            this.txtJumlah.Location = new System.Drawing.Point(444, 180);
            this.txtJumlah.Name = "txtJumlah";
            this.txtJumlah.Size = new System.Drawing.Size(67, 20);
            this.txtJumlah.TabIndex = 19;
            this.txtJumlah.TextChanged += new System.EventHandler(this.txtJumlah_TextChanged);
            // 
            // btnTambah
            // 
            this.btnTambah.Location = new System.Drawing.Point(531, 180);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(41, 20);
            this.btnTambah.TabIndex = 20;
            this.btnTambah.Text = "+";
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // cmbKodeBarang
            // 
            this.cmbKodeBarang.FormattingEnabled = true;
            this.cmbKodeBarang.Location = new System.Drawing.Point(38, 179);
            this.cmbKodeBarang.Name = "cmbKodeBarang";
            this.cmbKodeBarang.Size = new System.Drawing.Size(79, 21);
            this.cmbKodeBarang.TabIndex = 21;
            this.cmbKodeBarang.SelectedIndexChanged += new System.EventHandler(this.cmbKodeBarang_SelectedIndexChanged);
            // 
            // cmbIdCustomer
            // 
            this.cmbIdCustomer.FormattingEnabled = true;
            this.cmbIdCustomer.Location = new System.Drawing.Point(135, 47);
            this.cmbIdCustomer.Name = "cmbIdCustomer";
            this.cmbIdCustomer.Size = new System.Drawing.Size(100, 21);
            this.cmbIdCustomer.TabIndex = 22;
            this.cmbIdCustomer.SelectedIndexChanged += new System.EventHandler(this.cmbIdCustomer_SelectedIndexChanged);
            // 
            // dgvBarang
            // 
            this.dgvBarang.AllowUserToAddRows = false;
            this.dgvBarang.AllowUserToDeleteRows = false;
            this.dgvBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBarang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dgvBarang.Location = new System.Drawing.Point(38, 217);
            this.dgvBarang.Name = "dgvBarang";
            this.dgvBarang.ReadOnly = true;
            this.dgvBarang.Size = new System.Drawing.Size(534, 128);
            this.dgvBarang.TabIndex = 23;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "No";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 25;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Kode Barang";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Nama Barang";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Satuan";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 45;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Harga";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 80;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Jumlah";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 50;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Sub Total";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(214, 365);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(75, 23);
            this.btnSimpan.TabIndex = 24;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnBatal
            // 
            this.btnBatal.Location = new System.Drawing.Point(301, 365);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(75, 23);
            this.btnBatal.TabIndex = 25;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = true;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(399, 372);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "Total";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(399, 398);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 13);
            this.label13.TabIndex = 27;
            this.label13.Text = "Pajak (10%)";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(399, 422);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(61, 13);
            this.label14.TabIndex = 28;
            this.label14.Text = "Total Bayar";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(399, 447);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(70, 13);
            this.label15.TabIndex = 29;
            this.label15.Text = "Jumlah Bayar";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(399, 473);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(44, 13);
            this.label16.TabIndex = 30;
            this.label16.Text = "Kembali";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(472, 365);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 31;
            // 
            // txtPajak
            // 
            this.txtPajak.Location = new System.Drawing.Point(472, 391);
            this.txtPajak.Name = "txtPajak";
            this.txtPajak.Size = new System.Drawing.Size(100, 20);
            this.txtPajak.TabIndex = 32;
            // 
            // txtTotalBayar
            // 
            this.txtTotalBayar.Location = new System.Drawing.Point(472, 415);
            this.txtTotalBayar.Name = "txtTotalBayar";
            this.txtTotalBayar.Size = new System.Drawing.Size(100, 20);
            this.txtTotalBayar.TabIndex = 33;
            // 
            // txtJumlahBayar
            // 
            this.txtJumlahBayar.Location = new System.Drawing.Point(472, 440);
            this.txtJumlahBayar.Name = "txtJumlahBayar";
            this.txtJumlahBayar.Size = new System.Drawing.Size(100, 20);
            this.txtJumlahBayar.TabIndex = 34;
            // 
            // txtKembali
            // 
            this.txtKembali.Location = new System.Drawing.Point(472, 466);
            this.txtKembali.Name = "txtKembali";
            this.txtKembali.Size = new System.Drawing.Size(100, 20);
            this.txtKembali.TabIndex = 35;
            // 
            // rtbAlamat
            // 
            this.rtbAlamat.Location = new System.Drawing.Point(359, 55);
            this.rtbAlamat.Name = "rtbAlamat";
            this.rtbAlamat.Size = new System.Drawing.Size(200, 70);
            this.rtbAlamat.TabIndex = 36;
            this.rtbAlamat.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(38, 473);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 23);
            this.button1.TabIndex = 37;
            this.button1.Text = "Menu Utama";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormPenjualan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 515);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rtbAlamat);
            this.Controls.Add(this.txtKembali);
            this.Controls.Add(this.txtJumlahBayar);
            this.Controls.Add(this.txtTotalBayar);
            this.Controls.Add(this.txtPajak);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.dgvBarang);
            this.Controls.Add(this.cmbIdCustomer);
            this.Controls.Add(this.cmbKodeBarang);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.txtJumlah);
            this.Controls.Add(this.txtHarga);
            this.Controls.Add(this.dtpTanggal);
            this.Controls.Add(this.txtSatuan);
            this.Controls.Add(this.txtNamaBarang);
            this.Controls.Add(this.txtNoTelepon);
            this.Controls.Add(this.txtNamaCustomer);
            this.Controls.Add(this.txtFaktur);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormPenjualan";
            this.Text = "Penjualan";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBarang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtFaktur;
        private System.Windows.Forms.TextBox txtNamaCustomer;
        private System.Windows.Forms.TextBox txtNoTelepon;
        private System.Windows.Forms.TextBox txtNamaBarang;
        private System.Windows.Forms.TextBox txtSatuan;
        private System.Windows.Forms.DateTimePicker dtpTanggal;
        private System.Windows.Forms.TextBox txtHarga;
        private System.Windows.Forms.TextBox txtJumlah;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.ComboBox cmbKodeBarang;
        private System.Windows.Forms.ComboBox cmbIdCustomer;
        private System.Windows.Forms.DataGridView dgvBarang;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtPajak;
        private System.Windows.Forms.TextBox txtTotalBayar;
        private System.Windows.Forms.TextBox txtJumlahBayar;
        private System.Windows.Forms.TextBox txtKembali;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.RichTextBox rtbAlamat;
        private System.Windows.Forms.Button button1;
    }
}

