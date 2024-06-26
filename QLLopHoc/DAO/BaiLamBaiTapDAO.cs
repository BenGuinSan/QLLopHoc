﻿using System;
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
    public class BaiLamBaiTapDAO
    {
        public BaiLamBaiTapDAO()
        {
        }

        public ArrayList loadList()
        {
            ArrayList listTmp = new ArrayList();
            try
            {

                string sql_get_all = "SELECT * FROM bailambaitap";
                SqlCommand cmd = new SqlCommand(sql_get_all, DatabaseConnect.GetConnection());

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    BaiLamBaiTapDTO tmp = new BaiLamBaiTapDTO();
                    tmp.Mabailam = dr["mabailam"].ToString();
                    tmp.Mataikhoan = dr["mataikhoan"].ToString();
                    tmp.Mabaitap = dr["mabaitap"].ToString();
                    tmp.Nhanxet = dr["nhanxet"].ToString();
                    tmp.Diem = float.Parse(dr["diem"].ToString());
                    tmp.Noptre = int.Parse(dr["noptre"].ToString());
                    tmp.Noidung = dr["noidung"].ToString();
                    tmp.Thoigiannopbai = DateTime.Parse(dr["thoigiannopbai"].ToString());
                    listTmp.Add(tmp);
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xảy ra ở file BailambaitapDAO: " + ex.Message);
            }
            finally
            {
                DatabaseConnect.CloseConnection();
            }
            return listTmp;
        }

        public bool CreateBaiLamBaiTap(BaiLamBaiTapDTO blbt)
        {
            try
            {
                string sql = "INSERT INTO bailambaitap(mabailam,mataikhoan,mabaitap,noidung,thoigiannopbai,nhanxet,diem,noptre) VALUES (@mabailam, @mataikhoan, @mabaitap, @noidung, @thoigiannopbai, @nhanxet, @diem, @noptre)";
                SqlCommand command = new SqlCommand(sql,DatabaseConnect.GetConnection());
                command.Parameters.AddWithValue("@mabailam", blbt.Mabailam);
                command.Parameters.AddWithValue("@mataikhoan", blbt.Mataikhoan);
                command.Parameters.AddWithValue("@mabaitap", blbt.Mabaitap);
                command.Parameters.AddWithValue("@noidung", blbt.Noidung);
                command.Parameters.AddWithValue("@thoigiannopbai", blbt.Thoigiannopbai);
                command.Parameters.AddWithValue("@nhanxet", (object)blbt.Nhanxet ?? DBNull.Value);
                command.Parameters.AddWithValue("@diem", (object)blbt.Diem ?? DBNull.Value);
                command.Parameters.AddWithValue("@noptre", blbt.Noptre);
                int index = command.ExecuteNonQuery();
                if (index > 0) return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi xảy ra ở file BailambaitapDAO" + ex.Message);
            }
            finally
            {
                DatabaseConnect.CloseConnection();
            }
            return false;
        }
        public bool DeleteBaiLamBaiTapByMaBaiLam(string mabailam)
        {
            try
            {
                string sql_delete = "DELETE FROM bailambaitap WHERE mabailam=@mabailam";
                SqlCommand command = new SqlCommand(sql_delete, DatabaseConnect.GetConnection());
                command.Parameters.AddWithValue("@mabailam", Guid.Parse(mabailam));
                int index = command.ExecuteNonQuery();
                if (index > 0) return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                DatabaseConnect.CloseConnection();
            }
            return false;
        }
        public bool ChamDiemBaiLamBaiTap(BaiLamBaiTapDTO blbt)
        {
            try
            {
                string sql = "UPDATE bailambaitap SET diem=@diem, nhanxet=@nhanxet WHERE mabailam=@mabailam";
                SqlCommand command = new SqlCommand(sql, DatabaseConnect.GetConnection());
                command.Parameters.AddWithValue("@diem", blbt.Diem);
                command.Parameters.AddWithValue("@nhanxet", blbt.Nhanxet);
                command.Parameters.AddWithValue("@mabailam", blbt.Mabailam);
                int index = command.ExecuteNonQuery();
                if (index > 0) return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                DatabaseConnect.CloseConnection();
            }
            return false;
        }

        public DataTable ThongKeDiemHocSinhTheoMaBaiTap(string mabaitap)
        {
            try
            {
                string sql_thamgia = "select t.hoten,b.diem,b.noptre,b.thoigiannopbai\r\n" +
                    "from taikhoan t join bailambaitap b on t.mataikhoan = b.mataikhoan\r\n" +
                    "where b.mabaitap = @mabaitap AND b.diem <> -1";
                SqlCommand cmd = new SqlCommand(sql_thamgia, DatabaseConnect.GetConnection());
                cmd.Parameters.AddWithValue("@mabaitap", Guid.Parse(mabaitap));
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                return dataSet.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xảy ra ở file BaiLamBaiTapDAO:" + ex.Message);
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
                string sql_thamgia = "select bt.tieude,bl.diem,bl.noptre,bl.thoigiannopbai\r\n" +
                    "from bailambaitap bl join baitap bt on bl.mabaitap = bt.mabaitap\r\n" +
                    "where bt.machuong = @machuong AND bl.mataikhoan = @mataikhoan AND bl.diem <> -1 AND bt.congkhaidapan = 1";
                SqlCommand cmd = new SqlCommand(sql_thamgia, DatabaseConnect.GetConnection());
                cmd.Parameters.AddWithValue("@machuong", Guid.Parse(machuong));
                cmd.Parameters.AddWithValue("@mataikhoan", Guid.Parse(mataikhoan));
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                return dataSet.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xảy ra ở file BaiLamBaiTapDAO:" + ex.Message);
                return null;
            }
            finally
            {
                DatabaseConnect.CloseConnection();
            }
        }
    }

}
