-- ============================================
-- RESET & SETUP DATABASE PBO_BENGKEL v2
-- ============================================

DROP DATABASE IF EXISTS pbo_bengkel;
CREATE DATABASE pbo_bengkel;
USE pbo_bengkel;

-- 1. USER (login)
CREATE TABLE users (
  username VARCHAR(50) NOT NULL PRIMARY KEY,
  password VARCHAR(50) DEFAULT NULL,
  role ENUM('Admin','Kasir','Mekanik') DEFAULT NULL
);

-- 2. KARYAWAN (profil + foto)
CREATE TABLE karyawan (
  id_karyawan INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
  username VARCHAR(50) NOT NULL UNIQUE,
  nama_lengkap VARCHAR(100) DEFAULT NULL,
  no_hp VARCHAR(15) DEFAULT NULL,
  alamat TEXT DEFAULT NULL,
  foto VARCHAR(255) DEFAULT NULL,
  FOREIGN KEY (username) REFERENCES users(username)
);

-- 3. JASA (katalog)
CREATE TABLE jasa (
  id_jasa VARCHAR(10) NOT NULL PRIMARY KEY,
  nama_jasa VARCHAR(100) DEFAULT NULL,
  harga_jasa INT DEFAULT NULL
);

-- 4. SPAREPART (katalog)
CREATE TABLE sparepart (
  id_sparepart VARCHAR(10) NOT NULL PRIMARY KEY,
  nama_sparepart VARCHAR(100) DEFAULT NULL,
  stok INT DEFAULT NULL,
  harga_part INT DEFAULT NULL
);

-- 5. MEKANIK (daftar montir)
CREATE TABLE mekanik (
  id_mekanik VARCHAR(10) NOT NULL PRIMARY KEY,
  nama_mekanik VARCHAR(50) DEFAULT NULL
);

-- 6. PESANAN (satu tabel buat semua status)
CREATE TABLE pesanan (
  id_servis VARCHAR(14) NOT NULL PRIMARY KEY,
  nama_pelanggan VARCHAR(50) NOT NULL,
  no_hp VARCHAR(15) NOT NULL,
  keluhan TEXT,
  plat_nomor VARCHAR(20) NOT NULL,
  dibuat_oleh VARCHAR(50) DEFAULT NULL,
  dikerjakan_oleh VARCHAR(50) DEFAULT NULL,
  status ENUM('Dikirim','Dikerjakan','Selesai','Lunas') DEFAULT 'Dikirim',
  created_at DATETIME DEFAULT CURRENT_TIMESTAMP,
  updated_at DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP
);

-- 7. DETAIL SERVIS (isi jasa/sparepart yg dipake mekanik)
CREATE TABLE detail_servis (
  id_detail INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
  id_servis VARCHAR(14) NOT NULL,
  jenis ENUM('Jasa','Sparepart') NOT NULL,
  id_item VARCHAR(10) DEFAULT NULL,
  nama_item VARCHAR(100) NOT NULL,
  harga INT NOT NULL,
  qty INT NOT NULL DEFAULT 1,
  subtotal INT NOT NULL,
  FOREIGN KEY (id_servis) REFERENCES pesanan(id_servis)
);

-- ============================================
-- SEEDER
-- ============================================

-- USER
INSERT INTO users (username, password, role) VALUES
('admin', 'admin123', 'Admin'),
('kasir1', 'kasir123', 'Kasir'),
('mekanik1', 'mekanik123', 'Mekanik');

-- KARYAWAN
INSERT INTO karyawan (username, nama_lengkap, no_hp, alamat) VALUES
('admin', 'Admin Utama', '081111111111', 'Jl. Raya No. 1'),
('kasir1', 'Kasir Satu', '082222222222', 'Jl. Dagang No. 2'),
('mekanik1', 'Mekanik Satu', '083333333333', 'Jl. Bengkel No. 3');

-- JASA
INSERT INTO jasa (id_jasa, nama_jasa, harga_jasa) VALUES
('J001', 'Ganti Oli Mesin', 50000),
('J002', 'Service CVT', 75000),
('J003', 'Ganti Kampas Rem', 40000),
('J004', 'Tune Up Mesin', 100000),
('J005', 'Tambal Ban', 25000);

-- SPAREPART
INSERT INTO sparepart (id_sparepart, nama_sparepart, stok, harga_part) VALUES
('SP001', 'Oli Mesin 1L', 20, 45000),
('SP002', 'Kampas Rem Depan', 15, 35000),
('SP003', 'V-belt', 10, 55000),
('SP004', 'Busi', 25, 15000),
('SP005', 'Filter Udara', 12, 25000);

-- MEKANIK
INSERT INTO mekanik (id_mekanik, nama_mekanik) VALUES
('M001', 'Figo'),
('M002', 'Aldi');

-- PESANAN
INSERT INTO pesanan (id_servis, nama_pelanggan, no_hp, keluhan, plat_nomor, status) VALUES
('SRV-0000000001', 'Budi', '081234567890', 'Mesin brebet', 'B 1234 ABC', 'Dikirim'),
('SRV-0000000002', 'Ani', '081234567891', 'Rem blong', 'D 5678 DEF', 'Dikirim'),
('SRV-0000000003', 'Cahyo', '081234567892', 'Oli bocor', 'F 9012 GHI', 'Selesai'),
('SRV-0000000004', 'Dewi', '081234567893', 'V-belt putus', 'A 3456 JKL', 'Lunas');
