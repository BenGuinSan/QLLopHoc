using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using QLLopHoc.DTO;

namespace QLLopHoc.DAO
{
    public class LopHocDAO
    {
        DataTable dt = new DataTable();
        public LopHocDAO()
        {
        }

        public ArrayList loadList()
        {
            ArrayList listTmp = new ArrayList();
            try
            {

                string sql_get_all = "SELECT * FROM lophoc";
                SqlCommand cmd = new SqlCommand(sql_get_all, DatabaseConnect.GetConnection());

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    LopHocDTO tmp = new LopHocDTO();
                    tmp.Malop = dr["malophoc"].ToString();
                    tmp.Mota = dr["mota"].ToString();
                    tmp.Daxoa = int.Parse(dr["daxoa"].ToString());
                    tmp.Magiangvien = dr["magiangvien"].ToString();
                    tmp.Mota = dr["mota"].ToString();
                    tmp.Avatar = dr["anhdaidien"].ToString();
                    tmp.Tenlop = dr["ten"].ToString();
                    listTmp.Add(tmp);
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xảy ra ở file LophocDAO:" + ex.Message);
                Console.WriteLine(ex);
            }
            finally
            {
                DatabaseConnect.CloseConnection();
            }
            return listTmp;
        }

        public ArrayList GetDanhSachTatCaLopHocByMaTaiKhoan(string mataikhoan)
        {
            ArrayList listTmp = new ArrayList();
            try
            {
                string sql_get_all = "select l.* \r\n" +
                    "from lophoc l join thamgialophoc tg on l.malophoc = tg.malophoc \r\n" +
                    "join taikhoan tk on tk.mataikhoan = tg.mataikhoan\r\n" +
                    "where tk.mataikhoan = @mataikhoan\r\n" +
                    "UNION\r\n" +
                    "select lophoc.* \r\n" +
                    "from lophoc join taikhoan on lophoc.magiangvien = taikhoan.mataikhoan\r\n" +
                    "where taikhoan.mataikhoan= @mataikhoan";
                SqlCommand cmd = new SqlCommand(sql_get_all, DatabaseConnect.GetConnection());
                cmd.Parameters.AddWithValue("@mataikhoan", mataikhoan);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    LopHocDTO tmp = new LopHocDTO();
                    tmp.Malop = dr["malophoc"].ToString();
                    tmp.Mota = dr["mota"].ToString();
                    tmp.Daxoa = int.Parse(dr["daxoa"].ToString());
                    tmp.Avatar = dr["anhdaidien"].ToString();
                    tmp.Magiangvien = dr["magiangvien"].ToString();
                    tmp.Tenlop = dr["ten"].ToString();
                    listTmp.Add(tmp);
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xảy ra ở file LophocDAO:" + ex.Message);
            }
            finally
            {
                DatabaseConnect.CloseConnection();
            }
            return listTmp;
        }

        public ArrayList GetDanhSachLopHocGiangDayByMaTaiKhoan(string mataikhoan)
        {
            ArrayList listTmp = new ArrayList();
            try
            {
                string sql_get_giangday =
                    "select l.* \r\n" +
                    "from lophoc l join thamgialophoc tg on l.malophoc = tg.malophoc \r\n" +
                    "join taikhoan tk on tk.mataikhoan = tg.mataikhoan\r\n" +
                    "where tk.mataikhoan = @mataikhoan\r\n";
                SqlCommand cmd = new SqlCommand(sql_get_giangday, DatabaseConnect.GetConnection());
                cmd.Parameters.AddWithValue("@mataikhoan", mataikhoan);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    LopHocDTO tmp = new LopHocDTO();
                    tmp.Malop = dr["malophoc"].ToString();
                    tmp.Mota = dr["mota"].ToString();
                    tmp.Daxoa = int.Parse(dr["daxoa"].ToString());
                    tmp.Avatar = dr["anhdaidien"].ToString();
                    tmp.Magiangvien = dr["magiangvien"].ToString();
                    tmp.Tenlop = dr["ten"].ToString();
                    listTmp.Add(tmp);
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xảy ra ở file LophocDAO:" + ex.Message);
            }
            finally
            {
                DatabaseConnect.CloseConnection();
            }
            return listTmp;
        }

        public ArrayList GetDanhSachLopHocThamGiaByMaTaiKhoan(string mataikhoan)
        {
            ArrayList listTmp = new ArrayList();
            try
            {
                string sql_get_giangday =
                    "select lophoc.* \r\n" +
                    "from lophoc join taikhoan on lophoc.magiangvien = taikhoan.mataikhoan\r\n" +
                    "where taikhoan.mataikhoan= @mataikhoan";
                SqlCommand cmd = new SqlCommand(sql_get_giangday, DatabaseConnect.GetConnection());
                cmd.Parameters.AddWithValue("@mataikhoan", mataikhoan);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    LopHocDTO tmp = new LopHocDTO();
                    tmp.Malop = dr["malophoc"].ToString();
                    tmp.Mota = dr["mota"].ToString();
                    tmp.Daxoa = int.Parse(dr["daxoa"].ToString());
                    tmp.Avatar = dr["anhdaidien"].ToString();
                    tmp.Magiangvien = dr["magiangvien"].ToString();
                    tmp.Tenlop = dr["ten"].ToString();
                    listTmp.Add(tmp);
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xảy ra ở file LophocDAO:" + ex.Message);
            }
            finally
            {
                DatabaseConnect.CloseConnection();
            }
            return listTmp;
        }

        public DataTable LayDanhSachLopHoc()
        {
            DataTable dataTable = new DataTable();

            // Kết nối đến cơ sở dữ liệu
            using (SqlConnection connection = DatabaseConnect.GetConnection())
            {

                // Truy vấn dữ liệu từ SQL Server
                string query = "select lophoc.malophoc,lophoc.ten,lophoc.mota,taikhoan.hoten,lophoc.daxoa from taikhoan,lophoc where magiangvien=mataikhoan and taikhoan.manhomquyen=2";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }
            return dataTable;
        }

        public bool ThemLopHoc(LopHocDTO lophoc)
        {
            try
            {
                string sql_themlophoc = "INSERT INTO lophoc(malophoc,ten,mota,anhdaidien,daxoa,magiangvien) VALUES (@malophoc,N'" + lophoc.Tenlop + "',@mota,@anhdaidien,@daxoa,@magiangvien)";
                SqlCommand cmd_themlophoc = new SqlCommand(sql_themlophoc, DatabaseConnect.GetConnection());
                cmd_themlophoc.Parameters.AddWithValue("@malophoc", Guid.Parse(lophoc.Malop));
                cmd_themlophoc.Parameters.AddWithValue("@mota", lophoc.Mota);
                cmd_themlophoc.Parameters.AddWithValue("@anhdaidien", lophoc.Avatar);
                cmd_themlophoc.Parameters.AddWithValue("@daxoa", lophoc.Daxoa);
                cmd_themlophoc.Parameters.AddWithValue("@magiangvien", Guid.Parse(lophoc.Magiangvien));
                cmd_themlophoc.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xảy ra ở file LophocDAO:" + ex.Message);
                return false;
            }
            finally
            {
               DatabaseConnect.CloseConnection();
            }
        }


        public DataTable LayAllLopHoc()
        {

            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select * from lophoc ";
            command.Connection = DatabaseConnect.GetConnection();
            adapter.SelectCommand = command;
            dt.Clear();
            adapter.Fill(dt);
            DatabaseConnect.CloseConnection();
            return dt;
        }
    }

   
}
