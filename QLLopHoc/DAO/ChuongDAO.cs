using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using QLLopHoc.DTO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace QLLopHoc.DAO
{
    public class ChuongDAO
    {
        public ChuongDAO()
        {
        }

        public ArrayList loadList()
        {
            ArrayList listTmp = new ArrayList();
            try
            {

                string sql_get_all = "SELECT * FROM chuong";
                SqlCommand cmd = new SqlCommand(sql_get_all, DatabaseConnect.GetConnection());

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    ChuongDTO tmp = new ChuongDTO();
                    tmp.Machuong = dr["machuong"].ToString();
                    tmp.Malop = dr["malophoc"].ToString();
                    tmp.Thoigiantao = DateTime.Parse(dr["thoigiantao"].ToString());
                    tmp.Tenchuong = dr["ten"].ToString();
                    tmp.Daxoa = Convert.ToInt32(dr["daxoa"].ToString());
                    listTmp.Add(tmp);
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xảy ra ở file ChuongDAO:" + ex.Message);
            }
            finally
            {
                DatabaseConnect.CloseConnection();
            }
            return listTmp;
        }

        public bool ThemChuong(ChuongDTO chuong)
        {
            try
            {
                string sql_chuong = "INSERT INTO chuong(machuong,ten,thoigiantao,malophoc,daxoa) VALUES (@machuong,N'" + chuong.Tenchuong + "',@thoigiantao,@malophoc,@daxoa)";
                SqlCommand cmd_chuong = new SqlCommand(sql_chuong, DatabaseConnect.GetConnection());
                cmd_chuong.Parameters.AddWithValue("@machuong", Guid.Parse(chuong.Machuong));
                cmd_chuong.Parameters.AddWithValue("@thoigiantao", chuong.Thoigiantao);
                cmd_chuong.Parameters.AddWithValue("@daxoa", chuong.Daxoa);
                cmd_chuong.Parameters.AddWithValue("@malophoc", Guid.Parse(chuong.Malop));
                cmd_chuong.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xảy ra ở file ChuongDAO:" + ex.Message);
                return false;
            }
            finally
            {
                DatabaseConnect.CloseConnection();
            }
        }

        public bool SuaChuong(ChuongDTO chuong)
        {
            try
            {
                string sql_chuong = "UPDATE chuong SET ten = N'" + chuong.Tenchuong + "' WHERE machuong = @machuong";
                SqlCommand cmd_chuong = new SqlCommand(sql_chuong, DatabaseConnect.GetConnection());
                cmd_chuong.Parameters.AddWithValue("@machuong", Guid.Parse(chuong.Machuong));
                cmd_chuong.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xảy ra ở file ChuongDAO:" + ex.Message);
                return false;
            }
            finally
            {
                DatabaseConnect.CloseConnection();
            }
        }

        public bool XoaChuong(string machuong)
        {
            try
            {
                string sql_chuong = "UPDATE chuong SET daxoa = 1 WHERE machuong = @machuong";
                SqlCommand cmd_chuong = new SqlCommand(sql_chuong, DatabaseConnect.GetConnection());
                cmd_chuong.Parameters.AddWithValue("@machuong", Guid.Parse(machuong));
                cmd_chuong.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xảy ra ở file ChuongDAO:" + ex.Message);
                return false;
            }
            finally
            {
                DatabaseConnect.CloseConnection();
            }
        }
    }
}
