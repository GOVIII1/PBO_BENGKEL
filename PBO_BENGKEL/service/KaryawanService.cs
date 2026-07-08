using System;
using System.Data;
using MySql.Data.MySqlClient;
using PBO_BENGKEL.konfigurasi;

namespace PBO_BENGKEL.service
{
    internal class KaryawanService
    {
        public DataTable TampilkanSemua()
        {
            DataTable dt = new DataTable();
            try
            {
                using (var conn = Koneksi.GetConn())
                {
                    conn.Open();
                    string query = @"SELECT u.username AS 'Username', u.password AS 'Password', u.role AS 'Role',
                                     k.nama_lengkap AS 'Nama Lengkap', k.no_hp AS 'No HP', k.alamat AS 'Alamat', k.foto AS 'Foto'
                                     FROM users u
                                     LEFT JOIN karyawan k ON u.username = k.username
                                     ORDER BY u.username";
                    new MySqlDataAdapter(new MySqlCommand(query, conn)).Fill(dt);
                }
            }
            catch (Exception) { }
            return dt;
        }

        public bool Tambah(string username, string password, string role,
                           string namaLengkap, string noHp, string alamat, string foto)
        {
            try
            {
                using (var conn = Koneksi.GetConn())
                {
                    conn.Open();
                    using (var tx = conn.BeginTransaction())
                    {
                        string q1 = "INSERT INTO users (username, password, role) VALUES (@u, @p, @r)";
                        using (var cmd = new MySqlCommand(q1, conn, tx))
                        {
                            cmd.Parameters.AddWithValue("@u", username);
                            cmd.Parameters.AddWithValue("@p", password);
                            cmd.Parameters.AddWithValue("@r", role);
                            cmd.ExecuteNonQuery();
                        }

                        string q2 = "INSERT INTO karyawan (username, nama_lengkap, no_hp, alamat, foto) VALUES (@u, @n, @hp, @a, @f)";
                        using (var cmd = new MySqlCommand(q2, conn, tx))
                        {
                            cmd.Parameters.AddWithValue("@u", username);
                            cmd.Parameters.AddWithValue("@n", namaLengkap ?? "");
                            cmd.Parameters.AddWithValue("@hp", noHp ?? "");
                            cmd.Parameters.AddWithValue("@a", alamat ?? "");
                            cmd.Parameters.AddWithValue("@f", foto);
                            cmd.ExecuteNonQuery();
                        }

                        tx.Commit();
                        return true;
                    }
                }
            }
            catch { return false; }
        }

        public bool Ubah(string username, string password, string role,
                         string namaLengkap, string noHp, string alamat, string foto)
        {
            try
            {
                using (var conn = Koneksi.GetConn())
                {
                    conn.Open();
                    using (var tx = conn.BeginTransaction())
                    {
                        string q1 = "UPDATE users SET password = @p, role = @r WHERE username = @u";
                        using (var cmd = new MySqlCommand(q1, conn, tx))
                        {
                            cmd.Parameters.AddWithValue("@p", password);
                            cmd.Parameters.AddWithValue("@r", role);
                            cmd.Parameters.AddWithValue("@u", username);
                            cmd.ExecuteNonQuery();
                        }

                        string cek = "SELECT COUNT(*) FROM karyawan WHERE username = @u";
                        using (var cmd = new MySqlCommand(cek, conn, tx))
                        {
                            cmd.Parameters.AddWithValue("@u", username);
                            if (Convert.ToInt32(cmd.ExecuteScalar()) > 0)
                            {
                                string q2 = "UPDATE karyawan SET nama_lengkap = @n, no_hp = @hp, alamat = @a, foto = @f WHERE username = @u";
                                using (var cmd2 = new MySqlCommand(q2, conn, tx))
                                {
                                    cmd2.Parameters.AddWithValue("@n", namaLengkap ?? "");
                                    cmd2.Parameters.AddWithValue("@hp", noHp ?? "");
                                    cmd2.Parameters.AddWithValue("@a", alamat ?? "");
                                    cmd2.Parameters.AddWithValue("@f", foto);
                                    cmd2.Parameters.AddWithValue("@u", username);
                                    cmd2.ExecuteNonQuery();
                                }
                            }
                            else
                            {
                                string q2 = "INSERT INTO karyawan (username, nama_lengkap, no_hp, alamat, foto) VALUES (@u, @n, @hp, @a, @f)";
                                using (var cmd2 = new MySqlCommand(q2, conn, tx))
                                {
                                    cmd2.Parameters.AddWithValue("@u", username);
                                    cmd2.Parameters.AddWithValue("@n", namaLengkap ?? "");
                                    cmd2.Parameters.AddWithValue("@hp", noHp ?? "");
                                    cmd2.Parameters.AddWithValue("@a", alamat ?? "");
                                    cmd2.Parameters.AddWithValue("@f", foto);
                                    cmd2.ExecuteNonQuery();
                                }
                            }
                        }

                        tx.Commit();
                        return true;
                    }
                }
            }
            catch { return false; }
        }

        public bool Hapus(string username)
        {
            try
            {
                using (var conn = Koneksi.GetConn())
                {
                    conn.Open();
                    using (var tx = conn.BeginTransaction())
                    {
                        using (var cmd = new MySqlCommand("DELETE FROM karyawan WHERE username = @u", conn, tx))
                        {
                            cmd.Parameters.AddWithValue("@u", username);
                            cmd.ExecuteNonQuery();
                        }
                        using (var cmd = new MySqlCommand("DELETE FROM users WHERE username = @u", conn, tx))
                        {
                            cmd.Parameters.AddWithValue("@u", username);
                            cmd.ExecuteNonQuery();
                        }
                        tx.Commit();
                        return true;
                    }
                }
            }
            catch { return false; }
        }

        public DataRow GetDetail(string username)
        {
            try
            {
                using (var conn = Koneksi.GetConn())
                {
                    conn.Open();
                    string query = @"SELECT u.username, u.password, u.role, k.nama_lengkap, k.no_hp, k.alamat, k.foto
                                     FROM users u
                                     LEFT JOIN karyawan k ON u.username = k.username
                                     WHERE u.username = @u";
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@u", username);
                        DataTable dt = new DataTable();
                        new MySqlDataAdapter(cmd).Fill(dt);
                        if (dt.Rows.Count > 0) return dt.Rows[0];
                    }
                }
            }
            catch { }
            return null;
        }
    }
}
