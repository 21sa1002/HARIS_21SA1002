-- Membuat Database
CREATE DATABASE tokoBangunan;

USE tokoBangunan;

-- Tabel tbPenjualan
CREATE TABLE tbPenjualan (
    idPenjualan VARCHAR(6) PRIMARY KEY,
    idPesanan INT,
    namaPelanggan VARCHAR(255),
    namaBarang VARCHAR(255),
    jumlah INT,
    hargaBarang INT,
    subTotal INT
);

-- Tabel tbBarang
CREATE TABLE IF NOT EXISTS tbBarang (
    idBarang VARCHAR(6) PRIMARY KEY,
    namaBarang VARCHAR(255),
    hargaBarang INT,
    stokBarang INT,
    namaKategori VARCHAR(255),
    idSuplier VARCHAR(6)
);

-- Tabel detailPenjualan
CREATE TABLE IF NOT EXISTS detailPenjualan (
    idPesanan VARCHAR(6),
    idPenjualan VARCHAR(6),
    idBarang VARCHAR(6),
    totalPenjualan INT,
    totalTerjual INT
);

-- Tabel tbPelanggan
CREATE TABLE IF NOT EXISTS tbPelanggan (
    idPelanggan VARCHAR(6) PRIMARY KEY,
    namaPelanggan VARCHAR(255),
    telepon VARCHAR(20),
    email VARCHAR(255),
    alamat VARCHAR(255)
);

-- Tabel tbKaryawan
CREATE TABLE IF NOT EXISTS tbKaryawan (
    idKaryawan INT PRIMARY KEY AUTO_INCREMENT,
    username VARCHAR(255),
    password VARCHAR(255),
    namaKaryawan VARCHAR(255)
);

-- Tabel pesanan
CREATE TABLE IF NOT EXISTS pesanan (
    idPesanan VARCHAR(6) PRIMARY KEY,
    idPelanggan VARCHAR(6),
    tanggalPesanan DATE,
    totalHarga INT,
    jenisBayar VARCHAR(50),
    statusPesanan VARCHAR(50)
);

-- Tabel tbSuplier
CREATE TABLE IF NOT EXISTS tbSuplier (
    idSuplier VARCHAR(6) PRIMARY KEY,
    namaSuplier VARCHAR(255),
    tipeBarang VARCHAR(255),
    telepon VARCHAR(20)
);

-- Tabel kategori_barang
CREATE TABLE IF NOT EXISTS kategori_barang (
    idkategori VARCHAR(6) PRIMARY KEY,
    namaKategori VARCHAR(255),
    tipeSatuan INT,
    stokMaks INT
);
