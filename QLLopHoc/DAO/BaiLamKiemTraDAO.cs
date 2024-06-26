﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLLopHoc.DTO;
using System.Windows;

namespace QLLopHoc.DAO
{
    internal class BaiLamKiemTraDAO
    {
        public BaiLamKiemTraDAO()
        {
        }

        public ArrayList loadList()
        {
            ArrayList listTmp = new ArrayList();
            try
            {

                string sql_get_all = "SELECT * FROM bailamkiemtra";
                SqlCommand cmd = new SqlCommand(sql_get_all, DatabaseConnect.GetConnection());

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    BaiLamKiemTra tmp = new BaiLamKiemTra();
                    tmp.Mabailam = dr["mabailam"].ToString();
                    tmp.Mataikhoan = dr["mataikhoan"].ToString();
                    tmp.Madekiemtra = dr["madekiemtra"].ToString();
                    tmp.Thoigiannop = DateTime.Parse(dr["thoigiannop"].ToString());
                    tmp.Diem = float.Parse(dr["diem"].ToString());
                    tmp.Socaudung = int.Parse(dr["socaudung"].ToString());
                    tmp.Noptre = int.Parse(dr["noptre"].ToString());
                    listTmp.Add(tmp);
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xảy ra ở file BailamKiemTraDAO:" + ex.Message);
            }
            finally
            {
                DatabaseConnect.CloseConnection();
            }
            return listTmp;
        }
        public int addBaiLamKiemTra(BaiLamKiemTra blkt)
        {
            string sql = "INSERT INTO bailamkiemtra(mabailam,mataikhoan,madekiemtra,diem,thoigiannop,socaudung,noptre) VALUES (@mabailam,@mataikhoan,@madekiemtra,@diem,@thoigiannop,@socaudung,@noptre)";
            SqlCommand command = new SqlCommand(sql, DatabaseConnect.GetConnection());
            command.Parameters.Add("@mabailam", SqlDbType.UniqueIdentifier).Value = Guid.Parse(blkt.Mabailam);
            command.Parameters.Add("@mataikhoan", SqlDbType.UniqueIdentifier).Value = Guid.Parse(blkt.Mataikhoan);
            command.Parameters.Add("@madekiemtra", SqlDbType.UniqueIdentifier).Value = Guid.Parse(blkt.Madekiemtra);
            command.Parameters.Add("@diem", SqlDbType.Float).Value = blkt.Diem;
            command.Parameters.Add("@thoigiannop", SqlDbType.DateTime).Value = blkt.Thoigiannop;
            command.Parameters.Add("@socaudung", SqlDbType.Int).Value = blkt.Socaudung;
            command.Parameters.Add("@noptre", SqlDbType.Int).Value = blkt.Noptre;

            int isSuccess = command.ExecuteNonQuery();

            return isSuccess;
        }

        public DataTable ThongKeDiemHocSinhTheoMaDeKiemTra(string madekiemtra)
        {
            try
            {
                string sql_thamgia = "select t.hoten,b.diem,b.socaudung,b.noptre,b.thoigiannop\r\n" +
                    "from taikhoan t join bailamkiemtra b on t.mataikhoan = b.mataikhoan\r\nwhere b.madekiemtra = @madekiemtra";
                SqlCommand cmd = new SqlCommand(sql_thamgia, DatabaseConnect.GetConnection());
                cmd.Parameters.AddWithValue("@madekiemtra", Guid.Parse(madekiemtra));
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                return dataSet.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xảy ra ở file BaiLamKiemTraDAO:" + ex.Message);
                return null;
            }
            finally
            {
                DatabaseConnect.CloseConnection();
            }
        }

        public DataTable ThongKeDiemHocSinhTheoMaTaiKhoanVaMaChuong(string mataikhoan, string machuong)
        {
            try
            {
                string sql_thamgia = "select madekiemtra,diem,socaudung,noptre,thoigiannop\r\n" +
                    "from bailamkiemtra\r\n" +
                    "where mataikhoan = @mataikhoan and madekiemtra in " +
                    "(\r\n\tselect madekiemtra\r\n\t" +
                    "from dekiemtra \r\n\t" +
                    "where machuong = @machuong and xemdapan = 1\r\n)";
                SqlCommand cmd = new SqlCommand(sql_thamgia, DatabaseConnect.GetConnection());
                cmd.Parameters.AddWithValue("@mataikhoan", Guid.Parse(mataikhoan));
                cmd.Parameters.AddWithValue("@machuong", Guid.Parse(machuong));
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                return dataSet.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xảy ra ở file BaiLamKiemTraDAO:" + ex.Message);
                return null;
            }
            finally
            {
                DatabaseConnect.CloseConnection();
            }
        }
    }
}
