using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using QLLopHoc.DTO;

namespace QLLopHoc.DAO
{
    public class TaiKhoanDAO
    {
        // Khởi tạo 1 mảng kiểu <TaiKhoan> để lưu trữ danh sách tài khoản từ database
        public List<TaiKhoan> get_danhSach()
        {
            List<TaiKhoan> danhSachTaiKhoan = new List<TaiKhoan>();
            using(SqlConnection connection = DatabaseConnect.GetConnection())
            {
                string sqlQuery = "SELECT mataikhoan, hoten, email, matkhau, sodienthoai, anhdaidien, manhomquyen,daxoa FROM dbo.taikhoan";
                using (SqlCommand cmd = new SqlCommand(sqlQuery, connection))
                {
                    using(SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while(reader.Read())
                        {
                            TaiKhoan taikhoan = new TaiKhoan
                            {
                                Mataikhoan = reader["mataikhoan"].ToString(),
                                Hoten = reader["hoten"].ToString(),
                                Email = reader["email"].ToString(),
                                Matkhau = reader["matkhau"].ToString(),
                                Sodienthoai = reader["sodienthoai"].ToString(),
                                Anhdaidien = reader["anhdaidien"].ToString(),
                                Manhomquyen = Convert.ToInt32(reader["manhomquyen"]),
                                Daxoa = Convert.ToInt32(reader["daxoa"])
                            };
                            danhSachTaiKhoan.Add(taikhoan);
                        }
                    }
                }
            }
            return danhSachTaiKhoan;
        }

        public Boolean check_taikhoan(string email, string password)
        {
            using(SqlConnection connection = DatabaseConnect.GetConnection())
            {
                string sqlQuery = "Select * from taikhoan where email=@email";
                using(SqlCommand cmd = new SqlCommand(sqlQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@email", email);
                    using(var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            var storedPasswordHash = (string)reader["matkhau"];
                 
                            return BCrypt.Net.BCrypt.Verify(password, storedPasswordHash);
                        }
                        else
                            return false;
                    }

                }
            }
        }

        public Boolean insert_taikhoan(TaiKhoan tk)
        {
            using(SqlConnection connection = DatabaseConnect.GetConnection())
            {
                string sqlQuery = "INSERT INTO taikhoan( hoten, email, matkhau, sodienthoai, anhdaidien, manhomquyen,daxoa) VALUES ( @hoten, @email, @matkhau, @sodienthoai, @anhdaidien, @manhomquyen,0)";

                string salt = BCrypt.Net.BCrypt.GenerateSalt();
                string hash = BCrypt.Net.BCrypt.HashPassword(tk.Matkhau, salt);

                using (SqlCommand cmd = new SqlCommand (sqlQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@hoten", tk.Hoten);
                    cmd.Parameters.AddWithValue("@email", tk.Email);
                    cmd.Parameters.AddWithValue("@matkhau", hash);
                    cmd.Parameters.AddWithValue("@sodienthoai", DBNull.Value);
                    cmd.Parameters.AddWithValue("@anhdaidien", "canhan1");
                    cmd.Parameters.AddWithValue("@manhomquyen", tk.Manhomquyen);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }


    }
}
