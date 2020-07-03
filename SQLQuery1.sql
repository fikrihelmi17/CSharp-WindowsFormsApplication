CREATE TABLE TCustomer(
id_customer char(5) primary key,
nama_customer varchar(75), 
alamat varchar(100),
telepon varchar(15)
)

INSERT INTO TCustomer VALUES('001', 'Fikri Helmi Setiawan', 'Komp. Gading Tutuka 1','08190964003');
select * from TCustomer;					q

CREATE TABLE THead_Penjualan(
no_faktur char(10) primary key,
tanggal date,
id_customer char(5), 
total float,
pajak float
)

CREATE TABLE TDetail_Penjualan(
no_faktur char(10),
kode_barang char(5),
jumlah int
)

CREATE TABLE TBarang(
kode_barang char(5) primary key,
nama_barang varchar(75),
satuan varchar(50), 
stok int,
harga float
)

INSERT INTO TBarang VALUES('001', 'Fikri Helmi Setiawan', 'Komp. Gading Tutuka 1','08190964003');

CREATE TABLE TUser(
id_user char(5) primary key,
nama_lengkap varchar(100),
nama_user varchar(100),
password varchar(100)
)

INSERT INTO TUser VALUES('001', 'Fikri Helmi Setiawan', 'fikrihelmi17','17wordpressGO');

SELECT * FROM TCustomer;
SELECT * FROM THead_Penjualan;
SELECT * FROM TDetail_Penjualan;
SELECT * FROM TBarang;
SELECT * FROM TUser;

delete from TCustomer where id_customer = 001;
delete from TBarang where kode_barang = 001;


