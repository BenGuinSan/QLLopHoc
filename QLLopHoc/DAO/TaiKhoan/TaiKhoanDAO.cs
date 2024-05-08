using System;
using System.Collections.Generic;
using System.Data;
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
        public List<TaiKhoanDTO> get_danhSach()
        {
            List<TaiKhoanDTO> danhSachTaiKhoan = new List<TaiKhoanDTO>();
   
            using(SqlConnection connection = DatabaseConnect.GetConnection())
            {
                string sqlQuery = "SELECT mataikhoan, hoten, email, matkhau, sodienthoai, anhdaidien, manhomquyen,daxoa FROM dbo.taikhoan";
                using (SqlCommand cmd = new SqlCommand(sqlQuery, connection))
                {
                    using(SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while(reader.Read())
                        {
                            TaiKhoanDTO taikhoan = new TaiKhoanDTO
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

        public bool check_taikhoan(string email, string password)
        {
            using (SqlConnection conn = DatabaseConnect.GetConnection())
            {
                string sqlstring = "SELECT * FROM taikhoan WHERE email=@email;";
                using (SqlCommand command = new SqlCommand(sqlstring, conn))
                {
                    command.Parameters.AddWithValue("@email", email);
         
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
              
                            var storedPassword = (string)reader["matkhau"];

                            // So sánh mật khẩu được cung cấp với mật khẩu đã lưu
                            if (password == storedPassword)
                            {
                                // Mật khẩu khớp, xác thực thành công
                                return true;
                            }
                            else
                            {
                                // Mật khẩu không khớp, xác thực thất bại
                                return false;
                            }

                        }
                        else
                        {
                            // Xử lý trường hợp không tìm thấy tài khoản
                            return false;
                        }
                       
                    }
                  
                }
            }
        }

        public Boolean insert_taikhoan(TaiKhoanDTO tk)
        {
            using(SqlConnection connection = DatabaseConnect.GetConnection())
            {
                string sqlQuery = "INSERT INTO taikhoan( hoten, email, matkhau, sodienthoai, anhdaidien, manhomquyen,daxoa) VALUES ( @hoten, @email, @matkhau, @sodienthoai, @anhdaidien, @manhomquyen,0)";

                using (SqlCommand cmd = new SqlCommand (sqlQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@hoten", tk.Hoten);
                    cmd.Parameters.AddWithValue("@email", tk.Email);
                    cmd.Parameters.AddWithValue("@matkhau", tk.Matkhau);
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

        public DataTable getDSTaiKhoan() {
            DataTable dt = new DataTable();
        
            using (SqlConnection connection = DatabaseConnect.GetConnection())
            {
                string sqlQuery = "SELECT hoten, email, sodienthoai, daxoa FROM TaiKhoan where manhomquyen=2";
                using(SqlCommand cmd = new SqlCommand(sqlQuery, connection)) {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
                connection.Close();
                return dt;
            }
        }

        public string get_tenlop_malop(string malop)
        {
            string temp = null;
            using (SqlConnection conn = DatabaseConnect.GetConnection())
            {
                string sqlstring = "Select ten from lophoc where malophoc=@malophoc";
                using (SqlCommand command = new SqlCommand(sqlstring, conn))
                {
                    command.Parameters.AddWithValue("@malophoc", malop);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        temp = reader["ten"].ToString();
                    }
                }
            }

            return temp;
        }
        public string get_tenchuong_machuong(string machuong)
        {
            string temp = null;
            using (SqlConnection conn = DatabaseConnect.GetConnection())
            {
                string sqlstring = "Select ten from chuong where machuong=@machuong";
                using (SqlCommand command = new SqlCommand(sqlstring, conn))
                {
                    command.Parameters.AddWithValue("@machuong", machuong);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        temp = reader["ten"].ToString();
                    }
                }
            }

            return temp;
        }
        public string get_tengiangvien_magiangvien(string magiangvien)
        {
            string temp = null;
            using (SqlConnection conn = DatabaseConnect.GetConnection())
            {
                string sqlstring = "Select hoten from taikhoan where mataikhoan=@mataikhoan";
                using (SqlCommand command = new SqlCommand(sqlstring, conn))
                {
                    command.Parameters.AddWithValue("@mataikhoan", magiangvien);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        temp = reader["hoten"].ToString();
                    }
                }
            }

            return temp;
        }
        public void update_ten_sodienthoai_bymatoaikhoan(string ten, string sodienthoai, string mataikhoan)
        {
            using (SqlConnection conn = DatabaseConnect.GetConnection())
            {
                string sqlstring = "Update taikhoan set hoten=@hoten,sodienthoai=@sodienthoai where mataikhoan=@mataikhoan";
                using (SqlCommand command = new SqlCommand(sqlstring, conn))
                {
                    command.Parameters.AddWithValue("@mataikhoan", mataikhoan);
                    command.Parameters.AddWithValue("@hoten", ten);
                    command.Parameters.AddWithValue("@sodienthoai", sodienthoai);
                    int temp = command.ExecuteNonQuery();
                }
            }
        }
        public void update_anhcanhan(string tenhinh, string email)
        {
            using (SqlConnection conn = DatabaseConnect.GetConnection())
            {
                string sqlstring = "Update taikhoan set anhdaidien=@anhdaidien where email=@email";
                using (SqlCommand command = new SqlCommand(sqlstring, conn))
                {
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@anhdaidien", tenhinh);
                    int temp = command.ExecuteNonQuery();
                }
            }
        }
        public void ban_taikhoan(string email)
        {
            using (SqlConnection conn = DatabaseConnect.GetConnection())
            {
                string sqlstring = "Update taikhoan set daxoa=1 where email=@email";
                using (SqlCommand command = new SqlCommand(sqlstring, conn))
                {
                    command.Parameters.AddWithValue("@email", email);
                    int temp = command.ExecuteNonQuery();
                }
            }
        }
        public void unban_taikhoan(string email)
        {
            using (SqlConnection conn = DatabaseConnect.GetConnection())
            {
                string sqlstring = "Update taikhoan set daxoa=0 where email=@email";
                using (SqlCommand command = new SqlCommand(sqlstring, conn))
                {
                    command.Parameters.AddWithValue("@email", email);
                    int temp = command.ExecuteNonQuery();
                }
            }
        }
        public DataTable LayDanhSachTaiKhoan()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();

            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select * from taikhoan ";
            command.Connection = DatabaseConnect.GetConnection();
            adapter.SelectCommand = command;
            dt.Clear();
            adapter.Fill(dt);
            DatabaseConnect.CloseConnection();
            return dt;

        }

        public Boolean UpdateTaiKhoan(TaiKhoanDTO tk)
        {
            try
            {

                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = @"UPDATE taikhoan set 
                               mataikhoan=N'" + tk.Mataikhoan +
                               @"',manhomquyen=N'" + tk.Manhomquyen +
                               @"',hoten=N'" + tk.Hoten +
                               @"',email=N'" + tk.Email +
                               @"',matkhau=N'" + tk.Matkhau +
                               @"',sodienthoai=N'" + tk.Sodienthoai +
                               @"',anhdaidien=N'" + tk.Anhdaidien +
                               @"'where  (mataikhoan=N'" + tk.Mataikhoan + @"')";
                command.Connection = DatabaseConnect.GetConnection();
                command.ExecuteNonQuery();
                DatabaseConnect.CloseConnection();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }
        }
    }
}
