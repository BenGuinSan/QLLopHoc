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



    }
}
