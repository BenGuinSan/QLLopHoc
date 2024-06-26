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
    public class ChiTietBaiLamKiemTraDAO
    {
        public ChiTietBaiLamKiemTraDAO()
        {
        }

        public ArrayList loadList()
        {
            ArrayList listTmp = new ArrayList();
            try
            {

                string sql_get_all = "SELECT * FROM chitietbailamkiemtra";
                SqlCommand cmd = new SqlCommand(sql_get_all, DatabaseConnect.GetConnection());

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    ChiTietBaiLamKiemTraDTO tmp = new ChiTietBaiLamKiemTraDTO();
                    tmp.Mabailamkiemtra = dr["mabailamkiemtra"].ToString();
                    tmp.Macauhoi = dr["macauhoi"].ToString();
                    tmp.Dapanchon = dr["dapanchon"].ToString();
                    tmp.Thutu = Convert.ToInt16(dr["thutu"].ToString());
                    listTmp.Add(tmp);
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xảy ra ở file chitietbailambaiktDAO:" + ex.Message);
            }
            finally
            {
                DatabaseConnect.CloseConnection();
            }
            return listTmp;
        }
        public void addChiTietBaiLamKiemTra(ArrayList chitietbailam)
        {
            try
            {
                string sql = "INSERT INTO chitietbailamkiemtra(mabailamkiemtra,macauhoi,dapanchon,thutu) VALUES (@mabailamkt,@macauhoi,@dapanchon,@thutu)";
                SqlCommand command = new SqlCommand(sql, DatabaseConnect.GetConnection());
                foreach (ChiTietBaiLamKiemTraDTO ct in chitietbailam)
                {
                    command.Parameters.Clear();
                    command.Parameters.Add("@mabailamkt", SqlDbType.UniqueIdentifier).Value = Guid.Parse(ct.Mabailamkiemtra);
                    command.Parameters.Add("@macauhoi", SqlDbType.UniqueIdentifier).Value =
                        Guid.Parse(ct.Macauhoi);
                    command.Parameters.Add("@dapanchon", SqlDbType.UniqueIdentifier).Value = string.IsNullOrEmpty(ct.Dapanchon) ? DBNull.Value : (object)Guid.Parse(ct.Dapanchon);
                    command.Parameters.AddWithValue("@thutu", ct.Thutu);
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xảy ra ở file chitietbailambaiktDAO:" + ex.Message);
            }
            finally
            {
                DatabaseConnect.CloseConnection();
            }
        }
    }
}
