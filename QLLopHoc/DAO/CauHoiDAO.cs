using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using QLLopHoc.DTO;

namespace QLLopHoc.DAO
{
    public class CauHoiDAO
    {
        public ArrayList loadList()
        {
            ArrayList listTmp = new ArrayList();
            try
            {

                string sql_get_all = "SELECT * FROM cauhoi";
                SqlCommand cmd = new SqlCommand(sql_get_all, DatabaseConnect.GetConnection());

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    CauHoiDTO tmp = new CauHoiDTO();
                    tmp.Macauhoi = dr["macauhoi"].ToString();
                    tmp.Mataikhoan = dr["mataikhoan"].ToString();
                    tmp.Noidung = dr["noidung"].ToString();
                    tmp.Daxoa = Convert.ToInt32(dr["daxoa"]);
                    listTmp.Add(tmp);
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xảy ra ở file CauhoiDAO:" + ex.Message);
            }
            finally
            {
                DatabaseConnect.CloseConnection();
            }
            return listTmp;
        }

        public bool ThemCauHoi(CauHoiDTO cauhoi)
        {
            try
            {
                string sql_themcauhoi = "INSERT INTO cauhoi(macauhoi,noidung,mataikhoan,daxoa) VALUES (@macauhoi,N'" + cauhoi.Noidung + "',@mataikhoan,@daxoa)";
                SqlCommand cmd_themcauhoi = new SqlCommand(sql_themcauhoi, DatabaseConnect.GetConnection());
                cmd_themcauhoi.Parameters.AddWithValue("@macauhoi", Guid.Parse(cauhoi.Macauhoi));
                cmd_themcauhoi.Parameters.AddWithValue("@mataikhoan", Guid.Parse(cauhoi.Mataikhoan));
                cmd_themcauhoi.Parameters.AddWithValue("@daxoa", Convert.ToInt32(cauhoi.Daxoa));
                cmd_themcauhoi.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xảy ra ở file CauhoiDAO:" + ex.Message);
                return false;
            }
            finally
            {
                DatabaseConnect.CloseConnection();
            }
        }
        public void XoaCauHoi(string macauhoi)
        {
            try
            {
                string sql_xoacauhoi = "UPDATE cauhoi SET daxoa = 1 WHERE macauhoi = @macauhoi";
                SqlCommand cmd_xoacauhoi = new SqlCommand(sql_xoacauhoi, DatabaseConnect.GetConnection());
                cmd_xoacauhoi.Parameters.AddWithValue("@macauhoi", Guid.Parse(macauhoi));
                cmd_xoacauhoi.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xảy ra ở file CauhoiDAO:" + ex.Message);
            }
            finally
            {
                DatabaseConnect.CloseConnection();
            }
        }
        public bool SuaCauHoi(CauHoiDTO cauhoi)
        {
            try
            {
                string sql_suacauhoi = "UPDATE cauhoi SET noidung = N'" + cauhoi.Noidung + "', daxoa = @daxoa WHERE macauhoi = @macauhoi";
                SqlCommand cmd_suacauhoi = new SqlCommand(sql_suacauhoi, DatabaseConnect.GetConnection());
                cmd_suacauhoi.Parameters.AddWithValue("@daxoa", cauhoi.Daxoa);
                cmd_suacauhoi.Parameters.AddWithValue("@macauhoi", Guid.Parse(cauhoi.Macauhoi));
                cmd_suacauhoi.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xảy ra ở file CauhoiDAO:" + ex.Message);
                return false;
            }
            finally
            {
               DatabaseConnect.CloseConnection();
            }
        }
        public ArrayList GetDanhSachCauHoiByMaTaiKhoan(string matk)
        {
            ArrayList listTmp = new ArrayList();
            try
            {

                string sql_get_all = "SELECT * FROM cauhoi WHERE mataikhoan = @mataikhoan";
                SqlCommand cmd = new SqlCommand(sql_get_all, DatabaseConnect.GetConnection());
                cmd.Parameters.AddWithValue("@mataikhoan", Guid.Parse(matk));
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    CauHoiDTO tmp = new CauHoiDTO();
                    tmp.Macauhoi = dr["macauhoi"].ToString();
                    tmp.Mataikhoan = dr["mataikhoan"].ToString();
                    tmp.Noidung = dr["noidung"].ToString();
                    tmp.Daxoa = Convert.ToInt32(dr["daxoa"]);
                    listTmp.Add(tmp);
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xảy ra ở file CauhoiDAO:" + ex.Message);
            }
            finally
            {
                DatabaseConnect.CloseConnection();
            }
            return listTmp;
        }
    }
}
