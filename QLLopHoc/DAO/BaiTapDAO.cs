﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using QLLopHoc.DTO;

namespace QLLopHoc.DAO
{
    public class BaiTapDAO
    {
        public BaiTapDAO()
        {
        }

        public ArrayList loadList()
        {
            ArrayList listTmp = new ArrayList();
            try
            {
                string sql_getall = "SELECT * FROM baitap ";
                SqlCommand cmd = new SqlCommand(sql_getall, DatabaseConnect.GetConnection());

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    BaiTapDTO tmp = new BaiTapDTO();
                    tmp.Mabaitap = dr["mabaitap"].ToString();
                    tmp.Machuong = dr["machuong"].ToString();
                    tmp.Tieude = dr["tieude"].ToString();
                    tmp.Noidungbaitap = dr["noidungbaitap"].ToString();
                    tmp.Noidungdapan = dr["noidungdapan"].ToString();
                    tmp.Thoigiantao = DateTime.Parse(dr["thoigiantao"].ToString());
                    tmp.Thoigianbatdau = DateTime.Parse(dr["thoigianbatdau"].ToString());
                    tmp.Thoigianketthuc = DateTime.Parse(dr["thoigianketthuc"].ToString());
                    tmp.Congkhaidapan = int.Parse(dr["congkhaidapan"].ToString());
                    tmp.Daxoa = int.Parse(dr["daxoa"].ToString());
                    tmp.Nopbu = int.Parse(dr["nopbu"].ToString());
                    listTmp.Add(tmp);
                }
                dr.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xảy ra ở file BaitapDAO:" + ex.Message);
            }
            finally
            {
                DatabaseConnect.CloseConnection();
            }
            return listTmp;
        }

        public bool createBaiTap(BaiTapDTO bt)
        {
            try
            {
                string sql_getall = "INSERT INTO baitap(mabaitap,machuong,tieude,noidungbaitap,noidungdapan,thoigiantao,thoigianbatdau,thoigianketthuc,congkhaidapan,daxoa,nopbu) VALUES (@mabaitap,@machuong,@tieude,@noidungbaitap,@noidungdapan,@thoigiantao,@thoigianbatdau,@thoigianketthuc,@congkhaidapan,@daxoa,@nopbu)";
                SqlCommand command = new SqlCommand(sql_getall, DatabaseConnect.GetConnection());
                command.Parameters.AddWithValue("@mabaitap", Guid.Parse(bt.Mabaitap));
                command.Parameters.AddWithValue("@machuong", Guid.Parse(bt.Machuong));
                command.Parameters.AddWithValue("@tieude", bt.Tieude);
                command.Parameters.AddWithValue("@noidungbaitap", bt.Noidungbaitap);
                command.Parameters.AddWithValue("@noidungdapan", bt.Noidungdapan);
                command.Parameters.AddWithValue("@thoigiantao", bt.Thoigiantao.ToString());
                command.Parameters.AddWithValue("@thoigianbatdau", bt.Thoigianbatdau);
                command.Parameters.AddWithValue("@thoigianketthuc", bt.Thoigianketthuc);
                command.Parameters.AddWithValue("@congkhaidapan", bt.Congkhaidapan);
                command.Parameters.AddWithValue("@daxoa", bt.Daxoa);
                command.Parameters.AddWithValue("@nopbu", bt.Nopbu);
                int index = command.ExecuteNonQuery();

                if (index > 0) return true;
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                DatabaseConnect.CloseConnection();
            }
            return false;
        }

        public bool EditBaiTap(BaiTapDTO bt)
        {
            try
            {
                string sql_getall = "UPDATE baitap SET tieude=@tieude,noidungbaitap=@noidungbaitap,noidungdapan=@noidungdapan,thoigianbatdau=@thoigianbatdau,thoigianketthuc=@thoigianketthuc,congkhaidapan=@congkhaidapan,nopbu=@nopbu WHERE mabaitap=@mabaitap";
                SqlCommand command = new SqlCommand(sql_getall, DatabaseConnect.GetConnection());
                command.Parameters.AddWithValue("@tieude", bt.Tieude);
                command.Parameters.AddWithValue("@noidungbaitap", bt.Noidungbaitap);
                command.Parameters.AddWithValue("@noidungdapan", bt.Noidungdapan);
                command.Parameters.AddWithValue("@thoigianbatdau", bt.Thoigianbatdau);
                command.Parameters.AddWithValue("@thoigianketthuc", bt.Thoigianketthuc);
                command.Parameters.AddWithValue("@congkhaidapan", bt.Congkhaidapan);
                command.Parameters.AddWithValue("@nopbu", bt.Nopbu);
                command.Parameters.AddWithValue("@mabaitap", Guid.Parse(bt.Mabaitap));
                int index = command.ExecuteNonQuery();

                if (index > 0) return true;
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                DatabaseConnect.CloseConnection();
            }
            return false;
        }
        public bool DeleteBaiTapByMaBaiTap(string mabaitap)
        {
            try
            {
                string sql_delete = "DELETE FROM baitap WHERE mabaitap=@mabaitap";
                SqlCommand command = new SqlCommand(sql_delete, DatabaseConnect.GetConnection());
                command.Parameters.Add("@mabaitap", SqlDbType.UniqueIdentifier).Value = Guid.Parse(mabaitap);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xảy ra ở file BaitapDAO:" + ex.Message);
                Console.WriteLine(ex.Message);
            }
            finally
            {
                DatabaseConnect.CloseConnection();
            }
            return true;
        }
        public bool DeleteBaiTapByChangeState(string mabaitap)
        {
            try
            {
                string sql_delete = "UPDATE baitap SET daxoa=1 WHERE mabaitap=@mabaitap";
                SqlCommand command = new SqlCommand(sql_delete, DatabaseConnect.GetConnection());
                command.Parameters.Add("@mabaitap", SqlDbType.UniqueIdentifier).Value = Guid.Parse(mabaitap);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xảy ra ở file BaitapDAO:" + ex.Message);
                Console.WriteLine(ex);
            }
            finally
            {
                DatabaseConnect.CloseConnection();
            }
            return true;
        }
        public ArrayList GetTatCaBaiTapDaNopByMaLopHoc(string malop, string mataikhoan)
        {
            ArrayList listBaitap = new ArrayList();
            try
            {
                string sql = "SELECT bt.mabaitap,c.machuong,tieude,noidungbaitap,noidungdapan,bt.thoigiantao,thoigianbatdau,thoigianketthuc,congkhaidapan,bt.daxoa,bt.nopbu FROM baitap bt JOIN chuong c ON bt.machuong=c.machuong JOIN lophoc l ON c.malophoc=l.malophoc JOIN bailambaitap bl ON bl.mabaitap=bt.mabaitap WHERE l.malophoc=@malophoc AND bl.mataikhoan=@mataikhoan ";
                SqlCommand command = new SqlCommand(sql, DatabaseConnect.GetConnection());
                command.Parameters.AddWithValue("@malophoc", Guid.Parse(malop));
                command.Parameters.AddWithValue("@mataikhoan", Guid.Parse(mataikhoan));
                SqlDataReader dr = command.ExecuteReader();

                while (dr.Read())
                {
                    BaiTapDTO tmp = new BaiTapDTO
                    {
                        Mabaitap = dr["mabaitap"].ToString(),
                        Machuong = dr["machuong"].ToString(),
                        Tieude = dr["tieude"].ToString(),
                        Noidungbaitap = dr["noidungbaitap"].ToString(),
                        Noidungdapan = dr["noidungdapan"].ToString(),
                        Thoigiantao = DateTime.Parse(dr["thoigiantao"].ToString()),
                        Thoigianbatdau = DateTime.Parse(dr["thoigianbatdau"].ToString()),
                        Thoigianketthuc = DateTime.Parse(dr["thoigianketthuc"].ToString()),
                        Congkhaidapan = int.Parse(dr["congkhaidapan"].ToString()),
                        Daxoa = int.Parse(dr["daxoa"].ToString()),
                        Nopbu = int.Parse(dr["nopbu"].ToString())
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
        public ArrayList GetTatCaBaiTapChuaNopByMaLopHoc(string malop)
        {
            ArrayList listBaitap = new ArrayList();
            try
            {
                string sql = "SELECT bt.mabaitap,c.machuong,tieude,noidungbaitap,noidungdapan,bt.thoigiantao,thoigianbatdau,thoigianketthuc,congkhaidapan,bt.daxoa,bt.nopbu FROM baitap bt JOIN chuong c ON bt.machuong=c.machuong JOIN lophoc l ON c.malophoc=l.malophoc  WHERE l.malophoc=@malophoc AND (bt.nopbu=1 OR bt.thoigianketthuc > GETDATE()) AND bt.mabaitap NOT IN (SELECT bt2.mabaitap FROM baitap bt2 JOIN bailambaitap bl2 ON bl2.mabaitap=bt2.mabaitap)";
                SqlCommand command = new SqlCommand(sql, DatabaseConnect.GetConnection());
                command.Parameters.AddWithValue("@malophoc", Guid.Parse(malop));
                SqlDataReader dr = command.ExecuteReader();
                BaiTapDTO tmp;
                while (dr.Read())
                {
                    tmp = new BaiTapDTO
                    {
                        Mabaitap = dr["mabaitap"].ToString(),
                        Machuong = dr["machuong"].ToString(),
                        Tieude = dr["tieude"].ToString(),
                        Noidungbaitap = dr["noidungbaitap"].ToString(),
                        Noidungdapan = dr["noidungdapan"].ToString(),
                        Thoigiantao = DateTime.Parse(dr["thoigiantao"].ToString()),
                        Thoigianbatdau = DateTime.Parse(dr["thoigianbatdau"].ToString()),
                        Thoigianketthuc = DateTime.Parse(dr["thoigianketthuc"].ToString()),
                        Congkhaidapan = int.Parse(dr["congkhaidapan"].ToString()),
                        Daxoa = int.Parse(dr["daxoa"].ToString()),
                        Nopbu = int.Parse(dr["nopbu"].ToString())

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
