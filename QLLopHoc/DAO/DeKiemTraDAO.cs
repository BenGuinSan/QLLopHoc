using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLLopHoc.DTO;

namespace QLLopHoc.DAO
{
    public class DeKiemTraDAO
    {
        public DeKiemTraDAO() { }

        public ArrayList loadList()
        {
            ArrayList tmpList = new ArrayList();
            try
            {
                string sqlQuery = "Select * from dekiemtra";
                SqlCommand cmd = new SqlCommand(sqlQuery, DatabaseConnect.GetConnection());
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    DeKiemTraDTO dekiemtra = new DeKiemTraDTO();
                    dekiemtra.Madekiemtra = dr["madekiemtra"].ToString();
                    dekiemtra.Machuong = dr["machuong"].ToString();
                    dekiemtra.Tieude = dr["tieude"].ToString();
                    dekiemtra.Hinhphat = int.Parse(dr["hinhphat"].ToString());
                    dekiemtra.Xemdapan = int.Parse(dr["xemdapan"].ToString());
                    dekiemtra.Troncauhoi = int.Parse(dr["troncauhoi"].ToString());
                    dekiemtra.Thoigiantao = DateTime.Parse(dr["thoigiantao"].ToString());
                    dekiemtra.Thoigianbatdau = DateTime.Parse(dr["thoigianbatdau"].ToString());
                    dekiemtra.Thoigianketthuc = DateTime.Parse(dr["thoigianketthuc"].ToString());
                    dekiemtra.Daxoa = int.Parse(dr["daxoa"].ToString());
                    tmpList.Add(dekiemtra);
                }

            } catch (Exception ex) {
                MessageBox.Show("Lỗi xảy ra ở file DekiemtraDAO:" + ex.Message);
            }
            finally
            {
                DatabaseConnect.CloseConnection();
            }
            return tmpList;
        }
        public bool ThemDeKiemTra(DeKiemTraDTO dekiemtra)
        {
            try
            {
                string sql_themdekiemtra = "INSERT INTO dekiemtra(madekiemtra,machuong,tieude,thoigianbatdau,thoigianketthuc,hinhphat,xemdapan,thoigiantao,troncauhoi,daxoa) " +
                    "VALUES (@madekiemtra,@machuong,N'" + dekiemtra.Tieude + "',@thoigianbatdau,@thoigianketthuc,@hinhphat,@xemdapan,@thoigiantao,@troncauhoi,@daxoa)";
                SqlCommand cmd_themdekiemtra = new SqlCommand(sql_themdekiemtra, DatabaseConnect.GetConnection());
                cmd_themdekiemtra.Parameters.AddWithValue("@madekiemtra", Guid.Parse(dekiemtra.Madekiemtra));
                cmd_themdekiemtra.Parameters.AddWithValue("@machuong", Guid.Parse(dekiemtra.Machuong));
                cmd_themdekiemtra.Parameters.AddWithValue("@thoigianbatdau", dekiemtra.Thoigianbatdau);
                cmd_themdekiemtra.Parameters.AddWithValue("@thoigianketthuc", dekiemtra.Thoigianketthuc);
                cmd_themdekiemtra.Parameters.AddWithValue("@hinhphat", dekiemtra.Hinhphat);
                cmd_themdekiemtra.Parameters.AddWithValue("@xemdapan", dekiemtra.Xemdapan);
                cmd_themdekiemtra.Parameters.AddWithValue("@thoigiantao", dekiemtra.Thoigiantao);
                cmd_themdekiemtra.Parameters.AddWithValue("@troncauhoi", dekiemtra.Troncauhoi);
                cmd_themdekiemtra.Parameters.AddWithValue("@daxoa", dekiemtra.Daxoa);
                cmd_themdekiemtra.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xảy ra ở file DekiemtraDAO:" + ex.Message);
                return false;
            }
            finally
            {
                DatabaseConnect.CloseConnection();
            }
        }

        public bool SuaDeKiemTra(DeKiemTraDTO dekiemtra)
        {
            try
            {
                string sql_themdekiemtra = "UPDATE dekiemtra SET thoigianbatdau = @thoigianbatdau, thoigianketthuc = @thoigianketthuc WHERE madekiemtra = @madekiemtra";
                SqlCommand cmd_themdekiemtra = new SqlCommand(sql_themdekiemtra, DatabaseConnect.GetConnection());
                cmd_themdekiemtra.Parameters.AddWithValue("@madekiemtra", Guid.Parse(dekiemtra.Madekiemtra));
                cmd_themdekiemtra.Parameters.AddWithValue("@thoigianbatdau", dekiemtra.Thoigianbatdau);
                cmd_themdekiemtra.Parameters.AddWithValue("@thoigianketthuc", dekiemtra.Thoigianketthuc);
                cmd_themdekiemtra.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xảy ra ở file DekiemtraDAO:" + ex.Message);
                return false;
            }
            finally
            {
                DatabaseConnect.CloseConnection();
            }
        }

        public bool XoaDeKiemTra(DeKiemTraDTO dekiemtra)
        {
            try
            {
                string sql_xoadekiemtra = "UPDATE dekiemtra SET daxoa = 1 WHERE madekiemtra = @madekiemtra";
                SqlCommand cmd_xoadekiemtra = new SqlCommand(sql_xoadekiemtra, DatabaseConnect.GetConnection());
                cmd_xoadekiemtra.Parameters.AddWithValue("@madekiemtra", Guid.Parse(dekiemtra.Madekiemtra));
                cmd_xoadekiemtra.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xảy ra ở file DekiemtraDAO:" + ex.Message);
                return false;
            }
            finally
            {
                DatabaseConnect.CloseConnection();
            }
        }
        public ArrayList GetTatCaBaiKiemTraChuaNopByMaLopHoc(string malop)
        {
            ArrayList listBaitap = new ArrayList();
            try
            {
                string sql = "SELECT madekiemtra,c.machuong,tieude,thoigianbatdau,thoigianketthuc,hinhphat,xemdapan,dkt.thoigiantao,troncauhoi,dkt.daxoa FROM dekiemtra dkt JOIN chuong c ON dkt.machuong=c.machuong JOIN lophoc l ON c.malophoc=l.malophoc WHERE l.malophoc=@malophoc AND dkt.thoigianketthuc > GETDATE() AND dkt.madekiemtra NOT IN (SELECT dkt.madekiemtra FROM dekiemtra dkt JOIN bailamkiemtra bl ON dkt.madekiemtra=bl.madekiemtra)";
                SqlCommand command = new SqlCommand(sql, DatabaseConnect.GetConnection());
                command.Parameters.AddWithValue("@malophoc", Guid.Parse(malop));
                SqlDataReader dr = command.ExecuteReader();
                DeKiemTraDTO tmp;
                while (dr.Read())
                {
                    tmp = new DeKiemTraDTO
                    {
                        Madekiemtra = dr["madekiemtra"].ToString(),
                        Machuong = dr["machuong"].ToString(),
                        Tieude = dr["tieude"].ToString(),
                        Hinhphat = int.Parse(dr["hinhphat"].ToString()),
                        Xemdapan = int.Parse(dr["xemdapan"].ToString()),
                        Troncauhoi = int.Parse(dr["troncauhoi"].ToString()),
                        Thoigiantao = DateTime.Parse(dr["thoigiantao"].ToString()),
                        Thoigianbatdau = DateTime.Parse(dr["thoigianbatdau"].ToString()),
                        Thoigianketthuc = DateTime.Parse(dr["thoigianketthuc"].ToString()),
                        Daxoa = int.Parse(dr["daxoa"].ToString()),
                    };
                    listBaitap.Add(tmp);

                }
                dr.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                DatabaseConnect.CloseConnection();
            }

            return listBaitap;
        }
        public ArrayList GetTatCaBaiKiemTraDaNopByMaLopHoc(string malop, string mataikhoan)
        {
            ArrayList listBaitap = new ArrayList();
            try
            {
                string sql = "SELECT dkt.madekiemtra,c.machuong,tieude,thoigianbatdau,thoigianketthuc,hinhphat,xemdapan,dkt.thoigiantao,troncauhoi,dkt.daxoa FROM dekiemtra dkt JOIN chuong c ON dkt.machuong=c.machuong JOIN lophoc l ON c.malophoc=l.malophoc JOIN bailamkiemtra blkt ON dkt.madekiemtra=blkt.madekiemtra WHERE l.malophoc=@malophoc AND mataikhoan=@mataikhoan";
                SqlCommand command = new SqlCommand(sql, DatabaseConnect.GetConnection());
                command.Parameters.AddWithValue("@malophoc", Guid.Parse(malop));
                command.Parameters.AddWithValue("@mataikhoan", Guid.Parse(mataikhoan));
                SqlDataReader dr = command.ExecuteReader();
                DeKiemTraDTO tmp;
                while (dr.Read())
                {
                    tmp = new DeKiemTraDTO
                    {
                        Madekiemtra = dr["madekiemtra"].ToString(),
                        Machuong = dr["machuong"].ToString(),
                        Tieude = dr["tieude"].ToString(),
                        Hinhphat = int.Parse(dr["hinhphat"].ToString()),
                        Xemdapan = int.Parse(dr["xemdapan"].ToString()),
                        Troncauhoi = int.Parse(dr["troncauhoi"].ToString()),
                        Thoigiantao = DateTime.Parse(dr["thoigiantao"].ToString()),
                        Thoigianbatdau = DateTime.Parse(dr["thoigianbatdau"].ToString()),
                        Thoigianketthuc = DateTime.Parse(dr["thoigianketthuc"].ToString()),
                        Daxoa = int.Parse(dr["daxoa"].ToString()),
                    };
                    listBaitap.Add(tmp);

                }
                dr.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                DatabaseConnect.CloseConnection();
            }

            return listBaitap;
        }
    }


}
