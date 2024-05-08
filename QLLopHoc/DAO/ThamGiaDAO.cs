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
    public class ThamGiaDAO
    {
        DataTable dt = new DataTable();
        public ThamGiaDAO()
        {
        }

        // Lay toan bo data tu db vao 1 mang
        public ArrayList loadList()
        {
            ArrayList listTmp = new ArrayList();
            try
            {

                string sql_get_all = "SELECT * FROM thamgialophoc";
                SqlCommand cmd = new SqlCommand(sql_get_all, DatabaseConnect.GetConnection());

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    ThamGiaDTO tmp = new ThamGiaDTO();
                    tmp.Malop = dr["malophoc"].ToString();
                    tmp.Mataikhoan = dr["mataikhoan"].ToString();
                    listTmp.Add(tmp);
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xảy ra ở file ThamgiaDAO:" + ex.Message);
            }
            finally
            {
                DatabaseConnect.CloseConnection();
            }
            return listTmp;
        }

        // Lay ra toan bo sinh vien tham gia lop theo ma tai khoan
        public DataTable LayAllThamGiaById(String mataikhoan)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select * from thamgialophoc where (malophoc=N'" + mataikhoan + @"')";
            command.Connection = DatabaseConnect.GetConnection();
            adapter.SelectCommand = command;
            dt.Clear();
            adapter.Fill(dt);
            DatabaseConnect.CloseConnection();
            return dt;
        }

        // Tham gia lop hoc
        public bool ThemThamGia(ThamGiaDTO thamgia)
        {
            try
            {
                string sql_thamgia = "INSERT INTO thamgialophoc(malophoc,mataikhoan) VALUES (@malophoc,@mataikhoan)";
                SqlCommand cmd = new SqlCommand(sql_thamgia, DatabaseConnect.GetConnection());
                cmd.Parameters.AddWithValue("@malophoc", Guid.Parse(thamgia.Malop));
                cmd.Parameters.AddWithValue("@mataikhoan", Guid.Parse(thamgia.Mataikhoan));
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xảy ra ở file ThamgiaDAO:" + ex.Message);
                return false;
            }
            finally
            {
                DatabaseConnect.CloseConnection();
            }
        }
        public DataTable LayAllThamGiaLopHocByIDLopHoc(String str)
        {

            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select * from thamgialophoc where (malophoc=N'" + str + @"')";
            command.Connection = DatabaseConnect.GetConnection();
            adapter.SelectCommand = command;
            dt.Clear();
            adapter.Fill(dt);
            DatabaseConnect.CloseConnection();
            return dt;
        }

        public Boolean RoiKhoiLopHoc(String str, String maLH)
        {

            try
            {
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "DELETE FROM thamgialophoc where  (mataikhoan=@matk AND malophoc=@malophoc)";
                command.Parameters.AddWithValue("@matk", str);
                command.Parameters.AddWithValue("@malophoc", maLH);
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
        public DataTable DanhSachHocSinhTheoMaLop(string malop)
        {
            try
            {
                string sql_thamgia = "select t.mataikhoan,t.hoten,t.email,t.sodienthoai\r\n" +
                    "from lophoc l join thamgialophoc tg on l.malophoc = tg.malophoc\r\n" +
                    "join taikhoan t on t.mataikhoan = tg.mataikhoan\r\n" +
                    "where l.malophoc = @malophoc";
                //string sql_thamgia = "select * from lophoc";
                SqlCommand cmd = new SqlCommand(sql_thamgia, DatabaseConnect.GetConnection());
                cmd.Parameters.AddWithValue("@malophoc", Guid.Parse(malop));
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                return dataSet.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xảy ra ở file ThamgiaDAO:" + ex.Message);
                return null;
            }
            finally
            {
                DatabaseConnect.CloseConnection();
            }
        }

        public bool XoaThamGia(ThamGiaDTO thamgia)
        {
            try
            {
                string sql_thamgia = "DELETE FROM thamgialophoc WHERE malophoc = @malophoc AND mataikhoan = @mataikhoan";
                SqlCommand cmd = new SqlCommand(sql_thamgia, DatabaseConnect.GetConnection());
                cmd.Parameters.AddWithValue("@malophoc", Guid.Parse(thamgia.Malop));
                cmd.Parameters.AddWithValue("@mataikhoan", Guid.Parse(thamgia.Mataikhoan));
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xảy ra ở file ThamgiaDAO:" + ex.Message);
                return false;
            }
            finally
            {
               DatabaseConnect.CloseConnection();
            }
        }
     
    }
}
